﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementLineMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementLineMvo;
using Dddml.Wms.Domain.Movement;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.MovementLineMvo.NHibernate
{

	public class NHibernateMovementLineMvoEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new MovementLineMvoEventId((MovementLineId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedEventType()
		{
			return typeof(MovementLineMvoEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(MovementLineMvoEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            MovementLineId idObj = (MovementLineId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<MovementLineMvoEventBase>();
            criteria.Add(Restrictions.Eq("MovementLineMvoEventId.MovementLineIdMovementDocumentNumber", idObj.MovementDocumentNumber));
            criteria.Add(Restrictions.Eq("MovementLineMvoEventId.MovementLineIdLineNumber", idObj.LineNumber));
            criteria.Add(Restrictions.Le("MovementLineMvoEventId.MovementVersion", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("MovementLineMvoEventId.MovementVersion"));
            var es = criteria.List<IEvent>();
            foreach (MovementLineMvoEventBase e in es)
            {
                e.EventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((MovementLineMvoEventBase)es.Last()).MovementLineMvoEventId.MovementVersion : default(long),
                Events = es
            };
        }

	}

}

