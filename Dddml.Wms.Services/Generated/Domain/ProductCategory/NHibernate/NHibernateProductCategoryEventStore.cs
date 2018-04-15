﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductCategoryDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategory;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.ProductCategory.NHibernate
{

	public class NHibernateProductCategoryEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new ProductCategoryEventId((string)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(ProductCategoryStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(ProductCategoryStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            string idObj = (string)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<ProductCategoryStateEventBase>();
            criteria.Add(Restrictions.Eq("ProductCategoryEventId.ProductCategoryId", idObj));
            criteria.Add(Restrictions.Le("ProductCategoryEventId.Version", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("ProductCategoryEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (ProductCategoryStateEventBase e in es)
            {
                e.EventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((ProductCategoryStateEventBase)es.Last()).ProductCategoryEventId.Version : default(long),
                Events = es
            };
        }

	}

}

