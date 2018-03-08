﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeValueMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeValueMvo;
using Dddml.Wms.Domain.Attribute;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.AttributeValueMvo.NHibernate
{

	public class NHibernateAttributeValueMvoEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new AttributeValueMvoEventId((AttributeValueId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(AttributeValueMvoStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(AttributeValueMvoStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            AttributeValueId idObj = (AttributeValueId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<AttributeValueMvoStateEventBase>();
            criteria.Add(Restrictions.Eq("StateEventId.AttributeValueIdAttributeId", idObj.AttributeId));
            criteria.Add(Restrictions.Eq("StateEventId.AttributeValueIdValue", idObj.Value));
            criteria.Add(Restrictions.Le("StateEventId.AttributeVersion", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("StateEventId.AttributeVersion"));
            var es = criteria.List<IEvent>();
            foreach (AttributeValueMvoStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((AttributeValueMvoStateEventBase)es.Last()).StateEventId.AttributeVersion : default(long),
                Events = es
            };
        }

	}

}

