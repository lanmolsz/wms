﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePartyRoleDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PartyRole;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.PartyRole.NHibernate
{

	public class NHibernatePartyRoleEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new PartyRoleEventId((PartyRoleId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(PartyRoleStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(PartyRoleStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            PartyRoleId idObj = (PartyRoleId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<PartyRoleStateEventBase>();
            criteria.Add(Restrictions.Eq("PartyRoleEventId.PartyRoleIdPartyId", idObj.PartyId));
            criteria.Add(Restrictions.Eq("PartyRoleEventId.PartyRoleIdRoleTypeId", idObj.RoleTypeId));
            criteria.Add(Restrictions.Le("PartyRoleEventId.Version", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("PartyRoleEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (PartyRoleStateEventBase e in es)
            {
                e.EventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((PartyRoleStateEventBase)es.Last()).PartyRoleEventId.Version : default(long),
                Events = es
            };
        }

	}

}

