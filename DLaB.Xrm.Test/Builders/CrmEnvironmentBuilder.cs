﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DLaB.Common;
using Microsoft.Xrm.Sdk;

namespace DLaB.Xrm.Test.Builders
{

    /// <summary>
    /// Class to simplify the simplest cases of creating entities without changing the defaults.  Use the CrmEnvironmentBuilderBase to provide application specific logic
    /// </summary>
    public sealed class CrmEnvironmentBuilder : CrmEnvironmentBuilderBase<CrmEnvironmentBuilder>
    {
        protected override CrmEnvironmentBuilder This
        {
            get { return this; }
        }
    }

    /// <summary>
    /// Class to simplify the simplest cases of creating entities without changing the defaults.
    /// </summary>
    public abstract class CrmEnvironmentBuilderBase<TDerived> where TDerived : CrmEnvironmentBuilderBase<TDerived>
    {
        protected abstract TDerived This { get; }
        protected EntityBuilderManager EntityBuilders { get; set; }

        protected CrmEnvironmentBuilderBase()
        {
            try
            {
                EntityBuilders = new EntityBuilderManager();
            }
            catch (TypeInitializationException ex)
            {
                // Loading of the Early Bound Entities Could cause a major Exception
                throw ex.InnerException;
            }
        }

        #region Fluent Methods

        /// <summary>
        /// Allows for the specification of any fluent methods to the builder for the specific entity
        /// </summary>
        /// <typeparam name="TBuilder">The type of the builder.</typeparam>
        /// <param name="id">The identifier.</param>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public TDerived WithBuilder<TBuilder>(Id id, Action<TBuilder> action) where TBuilder : class
        {
            var result = EntityBuilders.Get(id);
            var builder = result as TBuilder;
            if (builder == null)
            {
                throw new Exception(String.Format("Unexpected type of builder!  Builder for {0}, was not of type {1}, but type {2}.", id, typeof (TBuilder).FullName, result.GetType().FullName));
            }
            action(builder);
            return This;
        }

        /// <summary>
        /// Allows for the specification of any fluent methods to the builder for the specific entity
        /// </summary>
        /// <typeparam name="TBuilder">The type of the builder.</typeparam>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public TDerived WithBuilder<TBuilder>(Action<TBuilder> action) 
            where TBuilder : class
        {
            EntityBuilders.WithBuilder(action);
            return This;
        }

        public TDerived WithChildEntities(Id parent, params Id[] ids)
        {
            EntityBuilders.Get(parent);
            foreach (var id in ids)
            {
                var name = EntityHelper.GetParentEntityAttributeName(TestBase.GetType(id), TestBase.GetType(parent));
                EntityBuilders.Get(id).WithAttributeValue(name, parent.EntityReference);
            }

            return This;
        }

        /// <summary>
        /// Creates the Entities using the default Builder for the given entity type
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns></returns>
        public TDerived WithEntities(params Id[] ids)
        {
            foreach (var id in ids)
            {
                EntityBuilders.Get(id);
            }
            return This;
        }

        #endregion // Fluent Methods

        /// <summary>
        /// Creates all of the Ids defined by the builder, using the given Service
        /// </summary>
        /// <param name="service">The service.</param>
        /// <returns></returns>
        public Dictionary<Guid, Entity> Create(IOrganizationService service)
        {
            return EntityBuilders.Create(service);
        }

        /// <summary>
        /// Manages what the default builder is for the Entity Type, and the specific builder by id
        /// </summary>
        protected class EntityBuilderManager
        {
            #region Properties

            /// <summary>
            /// The builder for each specific entity
            /// </summary>
            /// <value>
            /// The builders.
            /// </value>
            private Dictionary<Guid, BuilderInfo> Builders { get; set; }

            /// <summary>
            /// Manages the same list of Builders as the Builders Property, but by logical name
            /// </summary>
            /// <value>
            /// The type of the builders by entity.
            /// </value>
            private Dictionary<string, List<BuilderInfo>> BuildersByEntityType { get; set; }

            private static readonly object BuilderConstructorForEntityLock = new object();
            /// <summary>
            /// Contains constructors for the default builders of each entity type.  Whenever a new Builder is needed, this contains the constructor that will be invoked.
            /// </summary>
            /// <value>
            /// The builder for entity.
            /// </value>
            private static Dictionary<string, ConstructorInfo> BuilderConstructorForEntity { get; set; }
            
            /// <summary>
            /// Manages Custom Builder Fluent Actions.  Key is entity Logical Name.  Value is fluent actions to apply to Builder
            /// </summary>
            /// <value>
            /// The custom builder actions.
            /// </value>
            private Dictionary<string, Action<object>> CustomBuilderFluentActions { get; set; }

            private Dictionary<Guid, Id> Ids {get; set;}

            #endregion Properties

            #region Constructors

            static EntityBuilderManager()
            {
                var builderInterface = typeof (IEntityBuilder);
                var genericInterface = typeof(IEntityBuilder<>);
                // Load all types that have EntityBuilder<> as a base class
                var entityBuilders = from t in TestSettings.EntityBuilder.Assembly.GetTypes()
                    where builderInterface.IsAssignableFrom(t)
                    select new
                    {
                        EntityType = t.GetInterfaces().First(i => i.IsGenericType && i.GetGenericTypeDefinition() == genericInterface).GenericTypeArguments[0], 
                        Builder = t
                    };

                BuilderConstructorForEntity = entityBuilders.ToDictionary(k => EntityHelper.GetEntityLogicalName(k.EntityType), v => v.Builder.GetConstructor(new[] {typeof (Id)}));

                foreach (var builder in BuilderConstructorForEntity)
                {
                    if (builder.Key == "entity" || builder.Value != null)
                    {
                        continue;
                    }

                    throw new Exception("Entity Builder " + builder.Key + " does not contain a Constructor of type (Id)!");
                }
            }


            public EntityBuilderManager()
            {
                BuildersByEntityType = new Dictionary<string, List<BuilderInfo>>();
                Builders = new Dictionary<Guid, BuilderInfo>();
                CustomBuilderFluentActions = new Dictionary<string, Action<object>>();
                Ids = new Dictionary<Guid, Id>();
            }

            #endregion // Constructors

            /// <summary>
            /// Adds the custom fluent action if one doesn't already exist, and combines if one does already exist.
            /// </summary>
            /// <param name="logicalName">Name of the logical.</param>
            /// <param name="action">The action.</param>
            private void AddCustomAction(string logicalName, Action<object> action)
            {
                Action<Object> customAction;
                if (CustomBuilderFluentActions.TryGetValue(logicalName, out customAction))
                {
                    // Builder already has custom Action.  Create new custom Action that first calls old, then calls new
                    CustomBuilderFluentActions[logicalName] = b =>
                    {
                        customAction(b);
                        action(b);
                    };
                }
                else
                {
                    CustomBuilderFluentActions[logicalName] = action;
                }
            }

            /// <summary>
            /// Applies the custom action to all Builders for the given type.
            /// </summary>
            /// <typeparam name="TBuilder">The type of the builder.</typeparam>
            /// <param name="logicalName">Name of the logical.</param>
            /// <param name="action">The action.</param>
            /// <exception cref="System.Exception"></exception>
            private void ApplyCustomAction<TBuilder>(string logicalName, Action<TBuilder> action) where TBuilder : class
            {
                List<BuilderInfo> builders;
                if (!BuildersByEntityType.TryGetValue(logicalName, out builders))
                {
                    return;
                }

                foreach (var result in builders)
                {
                    var builder = result as TBuilder;
                    if (builder == null)
                    {
                        throw new Exception(String.Format("Unexpected type of builder!  Builder for {0}, was not of type {1}, but type {2}.", logicalName, typeof(TBuilder).FullName, result.GetType().FullName));
                    }
                    action(builder);
                }
            }

            /// <summary>
            /// Applies all custom fluent actions to the builder
            /// </summary>
            /// <param name="logicalName">Name of the logical.</param>
            /// <param name="builder">The builder.</param>
            private void ApplyCustomActions(string logicalName, object builder)
            {
                Action<Object> customAction;
                if (CustomBuilderFluentActions.TryGetValue(logicalName, out customAction))
                {
                    customAction(builder);
                }
            }

            /// <summary>
            /// Creates the specified entities in the correct Dependent Order, returning the entities created.
            /// </summary>
            /// <param name="service">The service.</param>
            /// <returns></returns>
            public Dictionary<Guid, Entity> Create(IOrganizationService service)
            {
                var results = new Dictionary<Guid, Entity>();
                foreach (var name in EntityDependency.Mapper.EntityCreationOrder)
                {
                    List<BuilderInfo> values;
                    if (!BuildersByEntityType.TryGetValue(name, out values))
                    {
                        // Should this be an exception?
                        continue;
                    }

                    foreach (var entity in values.Select(value => CreateEntity(service, value)))
                    {
                        Id id;
                        results.Add(entity.Id, entity);
                        if (Ids.TryGetValue(entity.Id, out id))
                        {
                            id.Entity = entity;
                        }
                    }
                }

                return results;
            }

            /// <summary>
            /// Updates the Builder with any attributes set in the Id's Entity.
            /// </summary>
            /// <param name="service">The service.</param>
            /// <param name="info">The builder.</param>
            /// <returns></returns>
            private static Entity CreateEntity(IOrganizationService service, BuilderInfo info)
            {
                var entity = info.Id.Entity;
                var builder = info.Builder;
                if (entity != null)
                {
                    foreach (var att in entity.Attributes)
                    {
                        builder.WithAttributeValue(att.Key, att.Value);
                    }
                }

                return builder.Create(service);
            }

            /// <summary>
            /// Gets the builder for the given Id, casting it to the given type T
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="id">The identifier.</param>
            /// <returns></returns>
            // ReSharper disable once UnusedMember.Local
            public T Get<T>(Id id)
            {
                return (T) Get(id);
            }

            /// <summary>
            /// Gets the builder for the given Id
            /// </summary>
            /// <param name="id">The identifier.</param>
            /// <returns></returns>
            public IEntityBuilder Get(Id id)
            {
                BuilderInfo builder;
                if (id != Guid.Empty && !Ids.ContainsKey(id))
                {
                    Ids.Add(id, id);
                }
                if (Builders.TryGetValue(id, out builder)) { return builder.Builder; }

                // Add the Entity to the mapper to make sure it can be created in the correct order
                EntityDependency.Mapper.Add(id);

                // Get the default Builder, or if no builder is defined, create a Generic Builder
                var constructor = (BuilderConstructorForEntity.ContainsKey(id) ? BuilderConstructorForEntity[id] : GetGenericConstructor(id));
                builder = new BuilderInfo(id, (IEntityBuilder) constructor.Invoke(new object[] { id }));

                // Apply any Custom Actions
                ApplyCustomActions(id, builder);

                // Add the Builder to both Dictionaries (keyed by Id and Logical Name)
                BuildersByEntityType.AddOrAppend(id, builder);
                Builders.Add(id, builder);

                return builder.Builder;
            }

            /// <summary>
            /// Creates a GenericEntityBuilder of the type of logical name being passed in.  Employs locking since BuilderForEntity is static
            /// </summary>
            /// <param name="logicalName">Name of the Entity to create a GenericEntityBuilder Constructor For.</param>
            /// <returns></returns>
            private ConstructorInfo GetGenericConstructor(string logicalName)
            {
                ConstructorInfo constructor;
                if (BuilderConstructorForEntity.TryGetValue(logicalName, out constructor))
                {
                    return constructor;
                }

                lock (BuilderConstructorForEntityLock)
                {
                    if (BuilderConstructorForEntity.TryGetValue(logicalName, out constructor))
                    {
                        return constructor;
                    }

                    var builder = typeof (GenericEntityBuilder<>).MakeGenericType(TestBase.GetType(logicalName));
                    constructor = builder.GetConstructor(new[] {typeof (Id)});
                    BuilderConstructorForEntity.Add(logicalName, constructor);
                    return constructor;
                }
            }

            /// <summary>
            /// Allows for the specification of any fluent methods to all existing builders, and any future builders for the given entity type
            /// </summary>
            /// <typeparam name="TBuilder">The type of the builder.</typeparam>
            /// <param name="action">The action.</param>
            /// <returns></returns>
            /// <exception cref="System.Exception"></exception>
            public void WithBuilder<TBuilder>(Action<TBuilder> action) 
                where TBuilder : class
            {
                var baseType = typeof(TBuilder).BaseType;
                if (baseType == null || baseType.GetGenericTypeDefinition() != typeof(EntityBuilder<>))
                {
                    throw new Exception("Builder is not directly inheriting from EntityBuilder<>, which is not currently supported");
                }

                // ReSharper disable once PossibleNullReferenceException
                var entityType = typeof(TBuilder).BaseType.GetGenericArguments()[0];
                var logicalName = EntityHelper.GetEntityLogicalName(entityType);

                // Handle all existing Builders
                ApplyCustomAction(logicalName, action);

                // Handle all future Builders
                AddCustomAction(logicalName, b => action((TBuilder)b)); // Convert Action<TBuilder> to Action<Object>
            }

            private class BuilderInfo
            {
                public Id Id { get; private set; }
                public IEntityBuilder Builder { get; private set; }

                public BuilderInfo(Id id, IEntityBuilder builder)
                {
                    Id = id;
                    Builder = builder;

                }
            }
        }
    }
}
