﻿using System;
using System.Linq.Expressions;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace DLaB.Xrm
{
    public class TypedQueryExpression<TEntity> where TEntity : Entity
    {
        public QueryExpression Query { get; set; }

        #region Pass Through QueryExpression Calls

        public bool Distinct => Query.Distinct;
        public bool NoLock => Query.NoLock;
        public PagingInfo PageInfo => Query.PageInfo;
        public DataCollection<LinkEntity> LinkEntities => Query.LinkEntities;
        public FilterExpression Criteria => Query.Criteria;
        public DataCollection<OrderExpression> Orders => Query.Orders;
        public string EntityName => Query.EntityName;
        public ColumnSet ColumnSet => Query.ColumnSet;
        public int? TopCount => Query.TopCount;
        
        public void AddOrder(string attributeName, OrderType orderType)
        {
            Query.AddOrder(attributeName, orderType);
        }

        public LinkEntity AddLink(string linkToEntityName, string linkFromAttributeName, string linkToAttributeName)
        {
            return Query.AddLink(linkToEntityName, linkFromAttributeName, linkToAttributeName);
        }

        public LinkEntity AddLink(string linkToEntityName, string linkFromAttributeName, string linkToAttributeName, JoinOperator joinOperator)
        {
            return Query.AddLink(linkToEntityName, linkFromAttributeName, linkToAttributeName, joinOperator);
        }

        #endregion Pass Through QueryExpression Calls

        #region Constructors
        public TypedQueryExpression(QueryExpression qe)
        {
            Query = qe;
        }

        #endregion Constructors

        #region Type Conversions

        public static implicit operator QueryExpression(TypedQueryExpression<TEntity> container)
        {
            return container?.Query;
        }

        #endregion Type Conversions

        #region AddLink
        public LinkEntity AddLink(string linkToEntityName, string linkAttributesName)
        {
            return Query.AddLink(linkToEntityName, linkAttributesName, linkAttributesName);
        }

        public LinkEntity AddLink(string linkToEntityName, string linkAttributesName, JoinOperator joinType)
        {
            return Query.AddLink(linkToEntityName, linkAttributesName, linkAttributesName, joinType);
        }
        #endregion // AddLink

        #region AddLink<T>

        #region Same Link Attribute Name
        /// <summary>
        /// Adds the type T as a linked entity to the query expression, additionally ensuring it is active.
        /// Assumes both entities have the same attribute name to link on.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="linkAttributesName"></param>
        /// <returns></returns>
        public LinkEntity AddLink<T>(string linkAttributesName) where T : Entity
        {
            return Query.AddLink<T>(linkAttributesName, linkAttributesName);
        }

        /// <summary>
        /// Adds the type T as a linked entity to the query expression, additionally ensuring it is active.
        /// Assumes both entities have the same attribute name to link on.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="linkAttributesName"></param>
        /// <param name="anonymousTypeInitializer">An Anonymous Type Initializer where the properties of the anonymous
        /// type are the column names to add</param>
        /// <returns></returns>
        public LinkEntity AddLink<T>(string linkAttributesName, Expression<Func<T, object>> anonymousTypeInitializer) where T : Entity
        {
            return Query.AddLink(linkAttributesName, linkAttributesName, anonymousTypeInitializer);
        }

        /// <summary>
        /// Adds the type T as a linked entity, additionally ensuring it is active.
        /// Assumes both entities have the same attribute name to link on.
        /// </summary>
        /// <typeparam name="T">The type of the entity that is to be linked and asserted active.</typeparam>
        /// <param name="linkAttributesName">Name of the link attributes.</param>
        /// <param name="joinType">Type of the join to perform.</param>
        /// <returns></returns>
        public LinkEntity AddLink<T>(string linkAttributesName, JoinOperator joinType) where T : Entity
        {
            return Query.AddLink<T>(linkAttributesName, linkAttributesName, joinType);
        }

        /// <summary>
        /// Adds the type T as a linked entity, additionally ensuring it is active.
        /// Assumes both entities have the same attribute name to link on.
        /// </summary>
        /// <typeparam name="T">The type of the entity that is to be linked and asserted active.</typeparam>
        /// <param name="linkAttributesName">Name of the link attributes.</param>
        /// <param name="joinType">Type of the join to perform.</param>
        /// <param name="anonymousTypeInitializer">An Anonymous Type Initializer where the properties of the anonymous
        /// type are the column names to add</param>
        /// <returns></returns>
        public LinkEntity AddLink<T>(string linkAttributesName, JoinOperator joinType, Expression<Func<T, object>> anonymousTypeInitializer) where T : Entity
        {
            return Query.AddLink(linkAttributesName, linkAttributesName, joinType, anonymousTypeInitializer);
        }
        #endregion // Same Link Attribute Name

        #region Different Link Attribute Names
        /// <summary>
        /// Adds the type T as a linked entity to the query expression, additionally ensuring it is active.
        /// </summary>
        /// <typeparam name="T">The type of the entity that is to be linked and asserted active.</typeparam>
        /// <param name="linkFromAttributeName">Name of the link from attribute.</param>
        /// <param name="linkToAttributeName">Name of the link to attribute.</param>
        /// <returns></returns>
        public LinkEntity AddLink<T>(string linkFromAttributeName, string linkToAttributeName) where T : Entity
        {
            return Query.AddLink<T>(linkFromAttributeName, linkToAttributeName);
        }

        /// <summary>
        /// Adds the type T as a linked entity to the query expression, additionally ensuring it is active.
        /// </summary>
        /// <typeparam name="T">The type of the entity that is to be linked and asserted active.</typeparam>
        /// <param name="linkFromAttributeName">Name of the link from attribute.</param>
        /// <param name="linkToAttributeName">Name of the link to attribute.</param>
        /// <param name="anonymousTypeInitializer">An Anonymous Type Initializer where the properties of the anonymous
        /// type are the column names to add</param>
        /// <returns></returns>
        public LinkEntity AddLink<T>(string linkFromAttributeName, string linkToAttributeName, Expression<Func<T, object>> anonymousTypeInitializer) where T : Entity
        {
            return Query.AddLink(linkFromAttributeName, linkToAttributeName, anonymousTypeInitializer);
        }

        /// <summary>
        /// Adds the type T as a linked entity, additionally ensuring it is active.
        /// </summary>
        /// <typeparam name="T">The type of the entity that is to be linked and asserted active.</typeparam>
        /// <param name="linkFromAttributeName">Name of the link from attribute.</param>
        /// <param name="linkToAttributeName">Name of the link to attribute.</param>
        /// <param name="joinType">Type of the join to perform.</param>
        /// <returns></returns>
        public LinkEntity AddLink<T>(string linkFromAttributeName, string linkToAttributeName, JoinOperator joinType) where T : Entity
        {
            return Query.AddLink<T>(linkFromAttributeName, linkToAttributeName, joinType);
        }

        /// <summary>
        /// Adds the type T as a linked entity, additionally ensuring it is active.
        /// </summary>
        /// <typeparam name="T">The type of the entity that is to be linked and asserted active.</typeparam>
        /// <param name="linkFromAttributeName">Name of the link from attribute.</param>
        /// <param name="linkToAttributeName">Name of the link to attribute.</param>
        /// <param name="joinType">Type of the join to perform.</param>
        /// <param name="anonymousTypeInitializer">An Anonymous Type Initializer where the properties of the anonymous
        /// type are the column names to add</param>
        /// <returns></returns>
        public LinkEntity AddLink<T>(string linkFromAttributeName, string linkToAttributeName, JoinOperator joinType, Expression<Func<T, object>> anonymousTypeInitializer) where T : Entity
        {
            return Query.AddLink(linkFromAttributeName, linkToAttributeName, joinType, anonymousTypeInitializer);
        }
        #endregion // Different Link Attribute Names

        #endregion // AddLink<T>

        #region QueryExpression Extensions Methods

        /// <summary>
        /// Depending on the Type of T, adds the correct is active criteria Statement
        /// Note: Does not work for Linked Entities
        /// </summary>
        public TypedQueryExpression<TEntity> ActiveOnly()
        {
            Query.Criteria.ActiveOnly<TEntity>();
            return this;
        }

        public TypedQueryExpression<TEntity> First()
        {
            Query.First();
            return this;
        }

        /// <summary>
        /// Returns a SQL-ish representation of the QueryExpression's Criteria
        /// </summary>
        /// <returns></returns>
        public string GetSqlStatement()
        {
            return Query.GetSqlStatement();
        }

        public TypedQueryExpression<TEntity> StateIs(object entityStateEnum)
        {
            Query.Criteria.StateIs(entityStateEnum);
            return this;
        }

        /// <summary>
        /// Updates the Query Expression to only return only the first entity that matches the query expression expression criteria.
        /// Shortcut for setting the Query's PageInfo.Count and PageInfo.PageNumber to 1.
        /// </summary>
        /// <param name="count">The count of entities to restrict the result of the query to.</param>
        public TypedQueryExpression<TEntity> Take(int count)
        {
            Query.Take(count);
            return this;
        }

        /// <summary>
        /// Adds the column name and value pairs to the criteria of the given QueryExpression
        /// </summary>
        /// <param name="columnNameAndValuePairs">List of pairs that look like this:
        /// (string name of the column, value of the column) ie. "name", "John Doe" </param>
        public TypedQueryExpression<TEntity> WhereEqual(params object[] columnNameAndValuePairs)
        {
            Query.WhereEqual(columnNameAndValuePairs);
            return this;
        }

        /// <summary>
        /// Adds an In Condition to the QueryExpression Criteria
        /// </summary>
        /// <param name="columnName">The name of the column to perform the in against.</param>
        /// <param name="values">The list of values to search for being in the column name.</param>
        public TypedQueryExpression<TEntity> WhereIn(string columnName, params object[] values)
        {
            Query.WhereIn(columnName, values);
            return this;
        }


        #endregion // QueryExpression Extension Methods

    }
}
