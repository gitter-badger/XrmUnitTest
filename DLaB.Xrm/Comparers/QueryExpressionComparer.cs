﻿using System.Collections.Generic;
using DLaB.Common;
using DLaB.Xrm;
using Microsoft.Xrm.Sdk.Query;

namespace DLaB.Xrm.Comparers
{
    public class QueryExpressionComparer : IEqualityComparer<QueryExpression>
    {
        public bool Equals(QueryExpression qe1, QueryExpression qe2)
        {
            if (qe1 == qe2) { return true; }
            if (qe1 == null || qe2 == null) { return false; }

            return
                // Cheap checks First
                qe1.Distinct == qe2.Distinct &&
                qe1.EntityName == qe2.EntityName &&
                qe1.NoLock == qe2.NoLock &&
                qe1.TopCount == qe2.TopCount &&
                // More Expensive Second
                qe1.ColumnSet.IsEqual(qe2.ColumnSet) &&
                qe1.Criteria.IsEqual(qe2.Criteria) &&
                new EnumerableComparer<LinkEntity>(new LinkEntityComparer()).Equals(qe1.LinkEntities, qe2.LinkEntities) &&
                new EnumerableComparer<OrderExpression>(new OrderExpressionComparer()).Equals(qe1.Orders, qe2.Orders) &&
                qe1.PageInfo.IsEqual(qe2.PageInfo);
        }

        public int GetHashCode(QueryExpression qe)
        {
            qe.ThrowIfNull("qe");

            // Skip the more expensive checks for the hash code.  They are more likely to mutate as well...
            return new HashCode()
                // .Hash(qe.ColumnSet, new ColumnSetComparer())
                .Hash(qe.Criteria, new FilterExpressionComparer()) // Guestimating this, combined with the Entity Name, should be unique for 90%+ of the time
                .Hash(qe.Distinct)
                .Hash(qe.EntityName)
                .Hash(qe.NoLock)
                .Hash(qe.TopCount);
                // .Hash(qe.LinkEntities, new EnumerableComparer<LinkEntity>(new LinkEntityComparer()))
                // .Hash(qe.Orders, new EnumerableComparer<OrderExpression>(new OrderExpressionComparer()))
                // .Hash(qe.PageInfo, new PagingInfoComparer())
        }
    }
}
