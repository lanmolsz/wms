﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePartyDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Party;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Party.NHibernate
{

	public class NHibernatePartyEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new PartyEventId((string)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(PartyStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(PartyStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            string idObj = (string)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<PartyStateEventBase>();
            criteria.Add(Restrictions.Eq("PartyEventId.PartyId", idObj));
            criteria.Add(Restrictions.Le("PartyEventId.Version", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("PartyEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (PartyStateEventBase e in es)
            {
                e.EventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((PartyStateEventBase)es.Last()).PartyEventId.Version : default(long),
                Events = es
            };
        }

	}

}

