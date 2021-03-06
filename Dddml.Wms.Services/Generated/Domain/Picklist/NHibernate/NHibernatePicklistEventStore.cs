﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Picklist.NHibernate
{

	public class NHibernatePicklistEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new PicklistEventId((string)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedEventType()
		{
			return typeof(PicklistEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(PicklistEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            string idObj = (string)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<PicklistEventBase>();
            criteria.Add(Restrictions.Eq("PicklistEventId.PicklistId", idObj));
            criteria.Add(Restrictions.Le("PicklistEventId.Version", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("PicklistEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (PicklistEventBase e in es)
            {
                e.EventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((PicklistEventBase)es.Last()).PicklistEventId.Version : default(long),
                Events = es
            };
        }

	}

}

