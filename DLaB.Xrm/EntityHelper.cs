﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Xrm.Sdk;

namespace DLaB.Xrm
{
    public class EntityHelper
    {
        public static string GetEntityLogicalName<T>() where T : Entity
        {
            return GetEntityLogicalName(typeof(T));
        }

        public static string GetEntityLogicalName(Type type)
        {
            if (type.IsGenericParameter && type.BaseType != null)
            {
                // Handle SomeType<TEntity> where TEntity : Entity
                return GetEntityLogicalName(type.BaseType);
            }

            var field = type.GetField("EntityLogicalName");
            if (field == null)
            {
                if (type == typeof(Entity))
                {
                    return "entity";
                }
                else
                {
                    throw new Exception("Type " + type.FullName + " does not contain an EntityLogicalName Field");
                }
            }
            return (string)field.GetValue(null);
        }

        #region Determine Type

        public static Type GetType<T>(string entityLogicalName) where T : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
        {
            var contextType = typeof(T);
            if (contextType.Name == "OrganizationServiceContext")
            {
                throw new Exception("Must pass in a derived type from Microsoft.Xrm.Sdk.Client.OrganizationServiceContext");
            }

            return GetType(contextType.Assembly, contextType.Namespace, entityLogicalName);
        }

        private static ConcurrentDictionary<string, Dictionary<String, Type>> _cache = new ConcurrentDictionary<string, Dictionary<String, Type>>();
        public static Type GetType(Assembly earlyBoundAssembly, string @namespace, string entityLogicalName)
        {
            var key = "LogicalNameToEntityMapping|" + earlyBoundAssembly.FullName + "|" + @namespace;
            var mappings = _cache.GetOrAdd(key, k =>
            {
                var entityType = typeof(Entity);
                return earlyBoundAssembly.GetTypes().
                    Where(t => t.Namespace == @namespace && entityType.IsAssignableFrom(t)).
                    Select(t => new
                    {
                        Key = GetEntityLogicalName(t),
                        Value = t
                    }).
                    ToDictionary(v => v.Key, v => v.Value);
            });

            Type otherType;
            if (!mappings.TryGetValue(entityLogicalName, out otherType))
            {
                throw new Exception(String.Format("Unable to find a Type in assembly \"{0}\", namespace \"{1}\", with a logical name of \"{2}\"", earlyBoundAssembly.FullName, @namespace, entityLogicalName));
            }

            return otherType;
        }

        public static bool IsTypeDefined<T>(string entityLogicalName) where T : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
        {
            var contextType = typeof(T);
            if (contextType.Name == "OrganizationServiceContext")
            {
                throw new Exception("Must pass in a derived type from Microsoft.Xrm.Sdk.Client.OrganizationServiceContext");
            }

            return IsTypeDefined(contextType.Assembly, contextType.Namespace, entityLogicalName);
        }

        public static bool IsTypeDefined(Assembly earlyBoundAssembly, string @namespace, string entityLogicalName)
        {
            var key = "LogicalNameToEntityMapping|" + earlyBoundAssembly.FullName + "|" + @namespace;
            var mappings = _cache.GetOrAdd(key, k =>
            {
                var entityType = typeof(Entity);
                return earlyBoundAssembly.GetTypes().
                    Where(t => t.Namespace == @namespace && entityType.IsAssignableFrom(t)).
                    Select(t => new
                    {
                        Key = GetEntityLogicalName(t),
                        Value = t
                    }).
                    ToDictionary(v => v.Key, v => v.Value);
            });

            return mappings.ContainsKey(entityLogicalName);
        }

        #endregion // Determine Type

        #region Determine Id Attribute Name

        /// <summary>
        /// Returns the attribute name of the id of the entity
        /// </summary>
        /// <param name="logicalName"></param>
        /// <returns></returns>
        public static string GetIdAttributeName(string logicalName)
        {
            return GetIrregularIdAttributeName(logicalName) ?? logicalName + "id";
        }

        /// <summary>
        /// Returns the attribute name of the id of the entity
        /// </summary>
        /// <typeparam name="T">Entity Type to use Reflection to lookup the entity logical name for</typeparam>
        /// <returns></returns>
        public static string GetIdAttributeName<T>() where T : Entity
        {
            return GetIdAttributeName(GetEntityLogicalName<T>());
        }

        /// <summary>
        /// Returns the attribute name of the id of the entity if it doesn't follow the standard (logicalName + id) rule, or null
        /// </summary>
        /// <param name="logicalName"></param>
        /// <returns></returns>
        public static string GetIrregularIdAttributeName(string logicalName)
        {
            string name = null;

            switch (logicalName)
            {
                case "activitypointer":
                case "appointment":
                case "bulkoperation":
                case "campaignactivity":
                case "campaignresponse":
                case "email":
                case "fax":
                case "incidentresolution":
                case "letter":
                case "opportunityclose":
                case "phonecall":
                case "quoteclose":
                case "recurringappointmentmaster":
                case "serviceappointment":
                case "task":
                    name = "activityid";
                    break;
            }

            return name;
        }

        /// <summary>
        /// Returns the attribute name of the id of the entity if it doesn't follow the standard (logicalName + id) rule, or null
        /// </summary>
        /// <typeparam name="T">Entity Type to use Reflection to lookup the entity logical name for</typeparam>
        /// <returns></returns>
        public static string GetIrregularIdAttributeName<T>() where T : Entity
        {
            return GetIrregularIdAttributeName(GetEntityLogicalName<T>());
        }

        #endregion // Determine Id Attribute Name

        #region Determine Entity Attribute Name Name

        /// <summary>
        /// Gets the Primary Field (name) info. 
        /// </summary>
        /// <param name="logicalName">Name of the logical.</param>
        /// <returns></returns>
        public static PrimaryFieldInfo GetPrimaryFieldInfo(string logicalName)
        {
            var info = new PrimaryFieldInfo();
            if (logicalName.Length >= 4 && logicalName[3] == '_')
            {
                // Handle Special Cases
                switch (logicalName)
                {
                    default:
                        info.AttributeName = logicalName.Substring(0, 4) + "name";
                        break;
                }
            }
            else
            {
                switch (logicalName)
                {
                    case "businessunitnewsarticle":
                        info.AttributeName = "articletitle";
                        info.MaximumLength = 300;
                        break;

                    case "transactioncurrency":
                        info.AttributeName = "currencyname";
                        break;

                    case "customerrelationship":
                        info.AttributeName = "customerroleidname";
                        break;

                    case "importjob":
                        info.AttributeName = "data";
                        info.MaximumLength = 1073741823;
                        break;

                    case "transformationparametermapping":
                        info.AttributeName = "data";
                        info.MaximumLength = 500;
                        break;

                    case "activitymimeattachment":
                        info.AttributeName = "fileName";
                        info.MaximumLength = 255;
                        break;

                    case "contact":
                    case "lead":
                    case "systemuser":
                        info.AttributeName = "fullname";
                        break;

                    case "solution":
                    case "publisher":
                        info.AttributeName = "friendlyname";
                        break;

                    case "account":
                    case "asyncoperation":
                    case "bulkdeleteoperation":
                    case "businessunit":
                    case "calendar":
                    case "calendarrule":
                    case "campaign":
                    case "competitor":
                    case "connection":
                    case "connectionrole":
                    case "constraintbasedgroup":
                    case "contracttemplate":
                    case "convertrule":
                    case "convertruleitem":
                    case "customeraddress":
                    case "discounttype":
                    case "duplicaterule":
                    case "emailserverprofile":
                    case "entitlement":
                    case "entitlementchannel":
                    case "entitlementtemplate":
                    case "entitlementtemplatechannel":
                    case "equipment":
                    case "fieldsecurityprofile":
                    case "goalrollupquery":
                    case "import":
                    case "importfile":
                    case "importmap":
                    case "invoice":
                    case "mailbox":
                    case "mailmergetemplate":
                    case "metric":
                    case "opportunity":
                    case "organization":
                    case "pluginassembly":
                    case "plugintype":
                    case "pricelevel":
                    case "privilege":
                    case "processsession":
                    case "product":
                    case "publisheraddress":
                    case "queue":
                    case "quote":
                    case "relationshiprole":
                    case "report":
                    case "resource":
                    case "resourcegroup":
                    case "resourcespec":
                    case "role":
                    case "routingrule":
                    case "routingruleitem":
                    case "salesliterature":
                    case "salesorder":
                    case "savedquery":
                    case "savedqueryvisualization":
                    case "sdkmessage":
                    case "sdkmessageprocessingstep":
                    case "sdkmessageprocessingstepimage":
                    case "service":
                    case "serviceendpoint":
                    case "sharepointdocumentlocation":
                    case "sharepointsite":
                    case "site":
                    case "sla":
                    case "systemform":
                    case "team":
                    case "territory":
                    case "uom":
                    case "uomschedule":
                    case "userform":
                    case "userquery":
                    case "userqueryvisualization":
                    case "webresource":
                        info.AttributeName = "name";
                        break;

                    case "list":
                        info.AttributeName = "listname";
                        info.MaximumLength = 128;
                        break;

                    case "activityparty":
                        info.AttributeName = "partyidname";
                        info.MaximumLength = 400;
                        break;

                    case "invoicedetail":
                    case "opportunityproduct":
                    case "productpricelevel":
                    case "quotedetail":
                    case "salesorderdetail":
                        info.AttributeName = "productidname";
                        break;

                    case "socialprofile":
                        info.AttributeName = "profilename";
                        break;

                    case "postfollow":
                        info.AttributeName = "regardingobjectidname";
                        info.MaximumLength = 4000;
                        break;

                    case "columnmapping":
                        info.AttributeName = "sourceattributename";
                        info.MaximumLength = 160;
                        break;

                    case "processstage":
                        info.AttributeName = "stagename";
                        break;

                    case "activitypointer":
                    case "annotation":
                    case "appointment":
                    case "bulkoperation":
                    case "campaignactivity":
                    case "campaignresponse":
                    case "email":
                    case "fax":
                    case "incidentresolution":
                    case "letter":
                    case "opportunityclose":
                    case "orderclose":
                    case "phonecall":
                    case "quoteclose":
                    case "recurringappointmentmaster":
                    case "serviceappointment":
                    case "socialactivity":
                    case "task":
                        info.AttributeName = "subject";
                        info.MaximumLength = 200;
                        break;

                    case "teamtemplate":
                        info.AttributeName = "teamtemplatename";
                        break;

                    case "post":
                    case "postcomment":
                    case "tracelog":
                        info.AttributeName = "text";
                        info.MaximumLength = 1000;
                        break;

                    case "contract":
                    case "contractdetail":
                    case "goal":
                    case "incident":
                    case "kbarticle":
                    case "kbarticlecomment":
                    case "kbarticletemplate":
                    case "queueitem":
                    case "salesliteratureitem":
                    case "subject":
                    case "template":
                        info.AttributeName = "title";
                        break;

                    default:
                        info.AttributeName = null;
                        break;
                }
            }

            return info;
        }

        public class PrimaryFieldInfo
        {
            public string AttributeName { get; set; }
            public int MaximumLength { get; set; }

            public PrimaryFieldInfo()
            {
                MaximumLength = 100;
            }

        }

        #endregion // Determine Entity Attribute Name Name

        #region Determine Parent Attribute Name

        /// <summary>
        /// Gets the attribute name of the first attribute with the given Parent Type.
        /// </summary>
        /// <param name="childType">Type of the child.</param>
        /// <param name="parentType">Type of the parent.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static string GetParentEntityAttributeName(Type childType, Type parentType)
        {
            var attributeName = childType.GetProperties().Where(p => p.PropertyType == parentType).Select(GetNameAttribute).FirstOrDefault();
            if (attributeName == null)
            {
                throw new Exception(String.Format("No Property found for type {0}, of type {1} with AttributeLogicalNameAttribute", childType.FullName, parentType.FullName));
            }
            return attributeName.LogicalName; 
        }

        private static AttributeLogicalNameAttribute GetNameAttribute(PropertyInfo property)
        {
            return property.GetCustomAttribute(typeof(AttributeLogicalNameAttribute), true) as AttributeLogicalNameAttribute;
        }

        /// <summary>
        /// Gets the attribute name of the first attribute with the given parentLogicalName.
        /// </summary>
        /// <typeparam name="TChild">The type of the child.</typeparam>
        /// <typeparam name="TParent">The type of the parent.</typeparam>
        /// <returns></returns>
        public static string GetParentEntityAttributeName<TChild,TParent>() where TChild : Entity where TParent : Entity
        {
            return GetParentEntityAttributeName(typeof (TChild), typeof (TParent));
        }

        #endregion Determine Parent Attribute Name
    }
}
