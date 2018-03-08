﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItemMvo;
using Dddml.Wms.Domain.Shipment;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.ShipmentItemMvo.NHibernate
{

	public class NHibernateShipmentItemMvoEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new ShipmentItemMvoEventId((ShipmentItemId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(ShipmentItemMvoStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(ShipmentItemMvoStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            ShipmentItemId idObj = (ShipmentItemId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<ShipmentItemMvoStateEventBase>();
            criteria.Add(Restrictions.Eq("StateEventId.ShipmentItemIdShipmentId", idObj.ShipmentId));
            criteria.Add(Restrictions.Eq("StateEventId.ShipmentItemIdShipmentItemSeqId", idObj.ShipmentItemSeqId));
            criteria.Add(Restrictions.Le("StateEventId.ShipmentVersion", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("StateEventId.ShipmentVersion"));
            var es = criteria.List<IEvent>();
            foreach (ShipmentItemMvoStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((ShipmentItemMvoStateEventBase)es.Last()).StateEventId.ShipmentVersion : default(long),
                Events = es
            };
        }

	}

}

