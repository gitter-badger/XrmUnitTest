﻿using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using DLaB.Common;
using DLaB.Xrm.Client;
using DLaB.Xrm.Test.Entities;
using DLaB.Xrm.LocalCrm;
using Microsoft.Xrm.Sdk;

namespace DLaB.Xrm.Test
{
    public class TestBase
    {
        public static string OrgName { get; set; }
        public static bool UseLocalCrmDatabase { get; set; }

        static TestBase()
        {
            UserUnitTestSettingsLoaded = false;
        }

        #region GetOrganizationServiceProxy

        public static IClientSideOrganizationService GetOrganizationService(string organizationName = null,
            Guid impersonationUserId = new Guid(), bool enableProxyTypes = true)
        {
            LoadUserUnitTestSettings();
            organizationName = organizationName ?? OrgName;
            if (UseLocalCrmDatabase) { return GetLocalCrmDatabaseOrganizationService(organizationName, impersonationUserId); }

            var info = GetCrmServiceEntity(organizationName, enableProxyTypes);

            if (Config.GetAppSettingOrDefault("UseDebugCredentialsForTesting", true))
            {
                // Only in Unit tests should this be allowed.
                info.UserName = ConfigurationManager.AppSettings["DebugUserAccountName"];
                info.UserPassword = ConfigurationManager.AppSettings["DebugUserAccountPassword"];
                info.UserDomainName = ConfigurationManager.AppSettings["DebugUserAccountDomain"];
            }
            return CrmServiceUtility.GetOrganizationService(info);
        }

        private static IClientSideOrganizationService GetLocalCrmDatabaseOrganizationService(string organizationName, Guid impersonationUserId)
        {
            // Create a unique Database for each Unit Test by looking up the first method in the stack trace that has a TestMethodAttribute,
            // and using it's method handle, combined with the OrganizationName, as a unqiue Key
            var method = GetUnitTestMethod() ?? MethodBase.GetCurrentMethod();
            string databaseKey = String.Format("UnitTest {0}:{1}:{2}", method.Name, organizationName, method.MethodHandle);

            var info = LocalCrmDatabaseInfo.Create(TestSettings.EarlyBound.Assembly, TestSettings.EarlyBound.Namespace, databaseKey, impersonationUserId);

            var service = new LocalCrmDatabaseOrganizationService(info);

            // Create BU and SystemUser for currently executing user
            var bu = new Entity(BusinessUnit.EntityLogicalName)
            {
                [BusinessUnit.Fields.Name] = "Currently Executing BusinessUnit"
            };
            bu.Id = service.Create(bu);

            var id = service.Create(new Entity(SystemUser.EntityLogicalName)
            {
                [SystemUser.Fields.FirstName] = Environment.UserDomainName.Split('/').First(),
                [SystemUser.Fields.LastName] = Environment.UserName,
                [SystemUser.Fields.BusinessUnitId] = bu.ToEntityReference(),
            }.ToSdkEntity());

            info = LocalCrmDatabaseInfo.Create(TestSettings.EarlyBound.Assembly, TestSettings.EarlyBound.Namespace, databaseKey, id, impersonationUserId, bu.Id);

            return new LocalCrmDatabaseOrganizationService(info);
        }

        private static MethodBase GetUnitTestMethod()
        {
            var frames = new StackTrace().GetFrames();
            if (frames == null)
            {
                throw new Exception("Unable to get the StackTrace");
            }

            return frames.Reverse(). // Stacks are LIFO, Reverse to start at the bottom.
                          Select(frame => frame.GetMethod()).
                          FirstOrDefault(method => method.GetCustomAttributes(false).Any(o => o.GetType() == TestSettings.TestFrameworkProvider.Value.TestMethodAttributeType));
        }

        public static CrmServiceInfo GetCrmServiceEntity(bool enableProxyTypes = true)
        {
            return GetCrmServiceEntity(OrgName, enableProxyTypes);
        }

        public static CrmServiceInfo GetCrmServiceEntity(string organizationName, bool enableProxyTypes = true)
        {
            LoadUserUnitTestSettings();
            return new CrmServiceInfo(organizationName) { EnableProxyTypes = enableProxyTypes };
        }

        #endregion // GetOrganizationServiceProxy

        #region UnitTestSetting.user.config

        private static bool UserUnitTestSettingsLoaded { get; set; }

        private static readonly object LocalSettingsLock = new Object();
        /// <summary>
        /// Loads the user unit test settings in a multi-thread safe manner, verifying that it is loaded once only.
        /// </summary>
        private static void LoadUserUnitTestSettings()
        {
            if (UserUnitTestSettingsLoaded) { return; }

            lock (LocalSettingsLock)
            {
                if (UserUnitTestSettingsLoaded) { return; }
                LoadUserUnitTestSettingsInternal();
                UserUnitTestSettingsLoaded = true;
            }
        }

        private static void LoadUserUnitTestSettingsInternal()
        {
            var userConfig = GetUserConfig();
            if (userConfig != null)
            {
                AddSettingsToAppConfig(userConfig);
            }

            OrgName = Config.GetAppSettingOrDefault("OrgName", "Specify \"OrgName\" in App.Config");
            UseLocalCrmDatabase = Config.GetAppSettingOrDefault("UseLocalCrmDatabase", false);
        }

        private static void AddSettingsToAppConfig(Configuration userConfig)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (Path.GetFileName(config.FilePath) == "vstest.executionengine.x86.exe.Config")
            {
                throw new Exception("Unit Test Project Must Contain an App.Config file to be able to Load User Settings into!");
            }
            var update = false;

            // Load AppSettings into App.Config for settings that aren't already contained in the App.Config
            foreach (var setting in userConfig.AppSettings.Settings.Cast<KeyValueConfigurationElement>())
            {
                var appSetting = config.AppSettings.Settings[setting.Key];
                if (appSetting == null)
                {
                    // Add
                    update = true;
                    config.AppSettings.Settings.Add(setting.Key, setting.Value);
                }
                else if (appSetting.Value != setting.Value)
                {
                    // Update
                    update = true;
                    appSetting.Value = setting.Value;
                }
            }

            if (update)
            {
                config.Save(ConfigurationSaveMode.Modified, false);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private static Configuration GetUserConfig()
        {
            var userConfigPath = TestSettings.UserTestConfigPath.Value;

            if (!File.Exists(userConfigPath) && userConfigPath.EndsWith("user.config"))
            {
                // Attempt to lookup the non User Config settings.  This is used when the user config is copied over from a checked in version
                var index = userConfigPath.LastIndexOf("user.config", StringComparison.Ordinal);
                var configPath = userConfigPath.Remove(index, "user.".Length);

                // Copy Non User config to User config
                File.Copy(configPath, userConfigPath);
            }

            if (!File.Exists(userConfigPath))
            {
                return null;
            }

            var configMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = userConfigPath,
            };
            return ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
        }

        #endregion // UnitTestSetting.user.config

        /// <summary>
        /// Gets the Entity type based on the entity logical name.
        /// </summary>
        /// <param name="entityLogicalName">Name of the entity logical.</param>
        /// <returns></returns>
        public static Type GetType(string entityLogicalName)
        {
            return EntityHelper.GetType(TestSettings.EarlyBound.Assembly, TestSettings.EarlyBound.Namespace, entityLogicalName);
        }
    }
}
