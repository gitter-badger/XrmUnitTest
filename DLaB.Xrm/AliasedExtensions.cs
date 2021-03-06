﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;

namespace DLaB.Xrm
{
    public static partial class Extensions
    {
        #region Entity

        #region AddAliased

        public static void AddAliasedEntity(this Entity entity, Entity entityToAdd)
        {
            foreach (var attribute in entityToAdd.Attributes.Where(a => !(a.Value is AliasedValue)))
            {
                entity.AddAliasedValue(entityToAdd.LogicalName, attribute.Key, attribute.Value);
            }
        }

        /// <summary>
        /// Adds the value to the entity as an Aliased Value.  Helpful when you need to add attributes
        /// that are for other entities locally, in such a way that it looks like it was added by a link on a query
        /// expression
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="logicalName">The logical name from which the aliased value would have come from</param>
        /// <param name="attributeName">The logical name of the attribute of the aliased value</param>
        /// <param name="value">The Value to store in the aliased value</param>
        public static void AddAliasedValue(this Entity entity, string logicalName, string attributeName, object value)
        {
            entity.AddAliasedValue(null, logicalName, attributeName, value);
        }

        /// <summary>
        /// Adds the value to the entity as an Aliased Value.  Helpful when you need to add attributes
        /// that are for other entities locally, in such a way that it looks like it was added by a link on a query
        /// expression
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="aliasName">Aliased Name of the Attribute</param>
        /// <param name="logicalName">The logical name from which the aliased value would have come from</param>
        /// <param name="attributeName">The logical name of the attribute of the aliased value</param>
        /// <param name="value">The Value to store in the aliased value</param>
        public static void AddAliasedValue(this Entity entity, string aliasName, string logicalName, string attributeName, object value)
        {
            aliasName = aliasName ?? logicalName;
            entity.Attributes.Add(aliasName + "." + attributeName,
                new AliasedValue(logicalName, attributeName, value));
        }

        /// <summary>
        /// Adds the value to the entity as an Aliased Value, or replaces an already existing value.  Helpful when you need to add attributes
        /// that are for other entities locally, in such a way that it looks like it was added by a link on a query
        /// expression
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="logicalName">The logical name from which the aliased value would have come from</param>
        /// <param name="attributeName">The logical name of the attribute of the aliased value</param>
        /// <param name="value">The Value to store in the aliased value</param>
        public static void AddOrReplaceAliasedValue(this Entity entity, string logicalName, string attributeName, object value)
        {
            // Check for value already existing
            foreach (var attribute in entity.Attributes.Where(a => a.Value is AliasedValue))
            {
                var aliasedValue = ((AliasedValue)attribute.Value);
                if (aliasedValue.EntityLogicalName != logicalName || aliasedValue.AttributeLogicalName != attributeName) { continue; }

                entity[attribute.Key] = new AliasedValue(aliasedValue.EntityLogicalName, aliasedValue.AttributeLogicalName, value);
                return;
            }

            entity.AddAliasedValue(logicalName, attributeName, value);
        }

        #endregion AddAliased

        #region GetAliasedEntity

                public static T GetAliasedEntity<T>(this Entity entity) where T : Entity, new()
        {
            return entity.GetAliasedEntity<T>(null);
        }

        public static T GetAliasedEntity<T>(this Entity entity, string aliasedEntityName) where T : Entity, new()
        {
            var entityLogicalName = EntityHelper.GetEntityLogicalName<T>();
            var aliasedEntity = new T();
            var idAttribute = GetIdAttributeName(aliasedEntity);

            foreach (var entry in entity.Attributes)
            {
                var aliased = entry.Value as AliasedValue;
                if (aliased != null && aliased.EntityLogicalName == entityLogicalName &&
                    (
                        (aliasedEntityName == null && // No Entity Attribute Name Specified
                            (entry.Key.Contains(".") || entry.Key == aliased.AttributeLogicalName || aliased.AttributeLogicalName == idAttribute))
                    // And the key contains a "." or is an exact match on the aliased attribute logical name.  This keeps groupings that may not be the same type (Date Group by Day) from populating the aliased entity
                    // The one exception for this is the Id. which we want to include if we can
                    ||
                        (aliasedEntityName != null && // Or an Entity Attribute Name is specifed, and 
                            entry.Key.StartsWith(aliasedEntityName + ".")) // it starts with the aliasedEntityName + ".
                    ))
                {
                    aliasedEntity[aliased.AttributeLogicalName] = aliased.Value;
                    string formattedValue;
                    if (entity.FormattedValues.TryGetValue(entry.Key, out formattedValue))
                    {
                        aliasedEntity.FormattedValues[aliased.AttributeLogicalName] = formattedValue;
                    }
                }
            }

            // Remove names for Entity References.  
            foreach (var entry in aliasedEntity.Attributes.Where(a => a.Key.EndsWith("name")).ToList())
            {
                var nonNameAttribute = entry.Key.Substring(0, entry.Key.Length - "name".Length);
                if (aliasedEntity.Contains(nonNameAttribute))
                {
                    var entityRef = aliasedEntity[nonNameAttribute] as EntityReference;
                    if (entityRef != null && entityRef.Name == (string)entry.Value)
                    {
                        aliasedEntity.Attributes.Remove(entry.Key);
                    }
                }
            }


            if (aliasedEntity.Attributes.Contains(idAttribute))
            {
                aliasedEntity.Id = (Guid)aliasedEntity[idAttribute];
            }

            return aliasedEntity;
        }

        #endregion GetAliasedEntity

        #region GetAliasedValue

        /// <summary>
        /// Returns the Aliased Value for a column specified in a Linked entity, returning the default value for 
        /// the type if it wasn't found
        /// </summary>
        /// <typeparam name="T">The type of the aliased attribute form the linked entity</typeparam>
        /// <param name="entity"></param>
        /// <param name="attributeName">The aliased attribute from the linked entity.  Can be preappended with the
        /// linked entities logical name and a period. ie "Contact.LastName"</param>
        /// <returns></returns>
        public static T GetAliasedValue<T>(this Entity entity, string attributeName)
        {
            var aliasedEntityName = SplitAliasedAttributeEntityName(ref attributeName);

            var value = (from entry in entity.Attributes
                         where entry.IsSpecifiedAliasedValue(aliasedEntityName, attributeName)
                         select entry.Value).FirstOrDefault();

            if (value == null)
            {
                return default(T);
            }

            var aliased = value as AliasedValue;
            if (aliased == null)
            {
                throw new InvalidCastException(String.Format("Attribute {0} was of type {1}, not AliasedValue", attributeName, value.GetType().FullName));
            }

            try
            {
                // If the primary key of an entity is returned, it is returned as a Guid.  If it is a FK, it is returned as an Entity Reference
                // Handle that here
                if (typeof(T) == typeof(EntityReference) && aliased.Value is Guid)
                {
                    return (T)(object)new EntityReference(aliased.EntityLogicalName, (Guid)aliased.Value);
                }

                if (typeof(T) == typeof(Guid) && aliased.Value is EntityReference)
                {
                    return (T)(object)((EntityReference)aliased.Value).Id;
                }

                return (T)aliased.Value;
            }
            catch (InvalidCastException)
            {
                throw new InvalidCastException(
                    String.Format("Unable to cast attribute {0}.{1} from type {2} to type {3}",
                        aliased.EntityLogicalName, aliased.AttributeLogicalName,
                        aliased.Value.GetType().Name, typeof(T).Name));
            }
        }

        #endregion GetAliasedValue

        #region HasAliasedAttribute

        /// <summary>
        /// Returns the Aliased Value for a column specified in a Linked entity
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="attributeName">The aliased attribute from the linked entity.  Can be preappeneded with the
        /// linked entities logical name and a period. ie "Contact.LastName"</param>
        /// <returns></returns>
        public static bool HasAliasedAttribute(this Entity entity, string attributeName)
        {
            var aliasedEntityName = SplitAliasedAttributeEntityName(ref attributeName);
            return entity.Attributes.Any(e =>
                e.IsSpecifiedAliasedValue(aliasedEntityName, attributeName));
        }

        #endregion HasAliasedAttribute

        #region Helpers

        private static bool IsSpecifiedAliasedValue(this KeyValuePair<string, object> entry, string aliasedEntityName, string attributeName)
        {
            var aliased = entry.Value as AliasedValue;
            if (aliased == null)
            {
                return false;
            }

            // There are two ways to define an Aliased name that need to be handled
            //   1. At the Entity level in Query Expression or Fetch Xml.  This makes the key in the format AliasedEntityName.AttributeName
            //   2. At the attribute level in FetchXml Group.   This makes the key the Attribute Name.  The aliased Entity Name should always be null in this case

            bool value = false;
            if (aliasedEntityName == null)
            {
                // No aliased entity name specified.  If attribute name matches, assume it's correct, or, 
                //     if the key is the attribute name.  This covers the 2nd possibility above
                value = aliased.AttributeLogicalName == attributeName || entry.Key == attributeName;
            }
            else if (aliased.AttributeLogicalName == attributeName)
            {
                // The Aliased Entity Name has been defined.  Check to see if the attribute name join is valid
                value = entry.Key == aliasedEntityName + "." + attributeName;
            }
            return value;
        }

        /// <summary>
        /// Handles spliting the attributeName if it is formated as "EntityAliasedName.AttributeName",
        /// updating the attribute name and returning the aliased EntityName
        /// </summary>
        /// <param name="attributeName"></param>
        private static string SplitAliasedAttributeEntityName(ref string attributeName)
        {
            string aliasedEntityName = null;
            if (attributeName.Contains('.'))
            {
                var split = attributeName.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                if (split.Length != 2)
                {
                    throw new Exception("Attribute Name was specified for an Alaised Value with " + split.Length +
                    " split parts, and two were expected.  Attribute Name = " + attributeName);
                }
                aliasedEntityName = split[0];
                attributeName = split[1];
            }

            return aliasedEntityName;
        }

        #endregion Helpers

        #endregion Entity
    }
}
