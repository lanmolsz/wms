﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistItemMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistItemMvo;
using Dddml.Wms.Domain.PicklistBin;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.PicklistItemMvo.NHibernate
{

	public class NHibernatePicklistItemMvoEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new PicklistItemMvoEventId((PicklistBinPicklistItemId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedEventType()
		{
			return typeof(PicklistItemMvoEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(PicklistItemMvoEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            PicklistBinPicklistItemId idObj = (PicklistBinPicklistItemId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<PicklistItemMvoEventBase>();
            criteria.Add(Restrictions.Eq("PicklistItemMvoEventId.PicklistBinPicklistItemIdPicklistBinId", idObj.PicklistBinId));
            criteria.Add(Restrictions.Eq("PicklistItemMvoEventId.PicklistBinPicklistItemIdPicklistItemOrderShipGrpInvIdOrderId", idObj.PicklistItemOrderShipGrpInvId.OrderId));
            criteria.Add(Restrictions.Eq("PicklistItemMvoEventId.PicklistBinPicklistItemIdPicklistItemOrderShipGrpInvIdOrderItemSeqId", idObj.PicklistItemOrderShipGrpInvId.OrderItemSeqId));
            criteria.Add(Restrictions.Eq("PicklistItemMvoEventId.PicklistBinPicklistItemIdPicklistItemOrderShipGrpInvIdShipGroupSeqId", idObj.PicklistItemOrderShipGrpInvId.ShipGroupSeqId));
            criteria.Add(Restrictions.Eq("PicklistItemMvoEventId.PicklistBinPicklistItemIdPicklistItemOrderShipGrpInvIdProductId", idObj.PicklistItemOrderShipGrpInvId.ProductId));
            criteria.Add(Restrictions.Eq("PicklistItemMvoEventId.PicklistBinPicklistItemIdPicklistItemOrderShipGrpInvIdLocatorId", idObj.PicklistItemOrderShipGrpInvId.LocatorId));
            criteria.Add(Restrictions.Eq("PicklistItemMvoEventId.PicklistBinPicklistItemIdPicklistItemOrderShipGrpInvIdAttributeSetInstanceId", idObj.PicklistItemOrderShipGrpInvId.AttributeSetInstanceId));
            criteria.Add(Restrictions.Le("PicklistItemMvoEventId.PicklistBinVersion", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("PicklistItemMvoEventId.PicklistBinVersion"));
            var es = criteria.List<IEvent>();
            foreach (PicklistItemMvoEventBase e in es)
            {
                e.EventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((PicklistItemMvoEventBase)es.Last()).PicklistItemMvoEventId.PicklistBinVersion : default(long),
                Events = es
            };
        }

	}

}

