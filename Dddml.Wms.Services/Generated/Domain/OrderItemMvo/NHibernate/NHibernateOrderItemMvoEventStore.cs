﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemMvo;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.OrderItemMvo.NHibernate
{

	public class NHibernateOrderItemMvoEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new OrderItemMvoEventId((OrderItemId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(OrderItemMvoStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(OrderItemMvoStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            OrderItemId idObj = (OrderItemId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<OrderItemMvoStateEventBase>();
            criteria.Add(Restrictions.Eq("StateEventId.OrderItemIdOrderId", idObj.OrderId));
            criteria.Add(Restrictions.Eq("StateEventId.OrderItemIdOrderItemSeqId", idObj.OrderItemSeqId));
            criteria.Add(Restrictions.Le("StateEventId.OrderVersion", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("StateEventId.OrderVersion"));
            var es = criteria.List<IEvent>();
            foreach (OrderItemMvoStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((OrderItemMvoStateEventBase)es.Last()).StateEventId.OrderVersion : default(long),
                Events = es
            };
        }

	}

}

