﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserLoginMvo;
using Dddml.Wms.Domain.User;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.UserLoginMvo.NHibernate
{

	public class NHibernateUserLoginMvoEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new UserLoginMvoStateEventId((UserLoginId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(UserLoginMvoStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(UserLoginMvoStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            UserLoginId idObj = (UserLoginId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<UserLoginMvoStateEventBase>();
            criteria.Add(Restrictions.Eq("StateEventId.UserLoginIdUserId", idObj.UserId));
            criteria.Add(Restrictions.Eq("StateEventId.UserLoginIdLoginKeyLoginProvider", idObj.LoginKeyLoginProvider));
            criteria.Add(Restrictions.Eq("StateEventId.UserLoginIdLoginKeyProviderKey", idObj.LoginKeyProviderKey));
            criteria.Add(Restrictions.Le("StateEventId.UserVersion", version));
            criteria.AddOrder(Order.Asc("StateEventId.UserVersion"));
            var es = criteria.List<IEvent>();
            foreach (UserLoginMvoStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((UserLoginMvoStateEventBase)es.Last()).StateEventId.UserVersion : default(long),
                Events = es
            };
        }

	}

}

