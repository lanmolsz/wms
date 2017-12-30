﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.PhysicalInventory.NHibernate
{

	public class NHibernatePhysicalInventoryEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new PhysicalInventoryStateEventId((string)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(PhysicalInventoryStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(PhysicalInventoryStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            string idObj = (string)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<PhysicalInventoryStateEventBase>();
            criteria.Add(Restrictions.Eq("StateEventId.DocumentNumber", idObj));
            criteria.Add(Restrictions.Le("StateEventId.Version", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("StateEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (PhysicalInventoryStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((PhysicalInventoryStateEventBase)es.Last()).StateEventId.Version : default(long),
                Events = es
            };
        }

	}

}
