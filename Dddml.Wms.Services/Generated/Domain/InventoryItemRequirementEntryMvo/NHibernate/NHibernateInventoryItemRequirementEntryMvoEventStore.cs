﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementEntryMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirementEntryMvo;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryPRTriggered;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.InventoryItemRequirementEntryMvo.NHibernate
{

	public class NHibernateInventoryItemRequirementEntryMvoEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new InventoryItemRequirementEntryMvoEventId((InventoryItemRequirementEntryId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedEventType()
		{
			return typeof(InventoryItemRequirementEntryMvoEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(InventoryItemRequirementEntryMvoEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            InventoryItemRequirementEntryId idObj = (InventoryItemRequirementEntryId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<InventoryItemRequirementEntryMvoEventBase>();
            criteria.Add(Restrictions.Eq("InventoryItemRequirementEntryMvoEventId.InventoryItemRequirementEntryIdInventoryItemRequirementIdProductId", idObj.InventoryItemRequirementId.ProductId));
            criteria.Add(Restrictions.Eq("InventoryItemRequirementEntryMvoEventId.InventoryItemRequirementEntryIdInventoryItemRequirementIdLocatorId", idObj.InventoryItemRequirementId.LocatorId));
            criteria.Add(Restrictions.Eq("InventoryItemRequirementEntryMvoEventId.InventoryItemRequirementEntryIdInventoryItemRequirementIdAttributeSetInstanceId", idObj.InventoryItemRequirementId.AttributeSetInstanceId));
            criteria.Add(Restrictions.Eq("InventoryItemRequirementEntryMvoEventId.InventoryItemRequirementEntryIdEntrySeqId", idObj.EntrySeqId));
            criteria.Add(Restrictions.Le("InventoryItemRequirementEntryMvoEventId.InventoryItemRequirementVersion", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("InventoryItemRequirementEntryMvoEventId.InventoryItemRequirementVersion"));
            var es = criteria.List<IEvent>();
            foreach (InventoryItemRequirementEntryMvoEventBase e in es)
            {
                e.EventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((InventoryItemRequirementEntryMvoEventBase)es.Last()).InventoryItemRequirementEntryMvoEventId.InventoryItemRequirementVersion : default(long),
                Events = es
            };
        }

	}

}

