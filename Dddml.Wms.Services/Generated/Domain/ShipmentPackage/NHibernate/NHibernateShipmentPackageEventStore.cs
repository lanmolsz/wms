﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentPackageDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackage;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.ShipmentPackage.NHibernate
{

	public class NHibernateShipmentPackageEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new ShipmentPackageEventId((ShipmentPackageId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(ShipmentPackageStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(ShipmentPackageStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            ShipmentPackageId idObj = (ShipmentPackageId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<ShipmentPackageStateEventBase>();
            criteria.Add(Restrictions.Eq("ShipmentPackageEventId.ShipmentPackageIdShipmentId", idObj.ShipmentId));
            criteria.Add(Restrictions.Eq("ShipmentPackageEventId.ShipmentPackageIdShipmentPackageSeqId", idObj.ShipmentPackageSeqId));
            criteria.Add(Restrictions.Le("ShipmentPackageEventId.Version", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("ShipmentPackageEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (ShipmentPackageStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((ShipmentPackageStateEventBase)es.Last()).ShipmentPackageEventId.Version : default(long),
                Events = es
            };
        }

	}

}
