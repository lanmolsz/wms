﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserRoleMvo;
using Dddml.Wms.Domain.User;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.UserRoleMvo.NHibernate
{

	public class NHibernateUserRoleMvoEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new UserRoleMvoEventId((UserRoleId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(UserRoleMvoStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(UserRoleMvoStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            UserRoleId idObj = (UserRoleId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<UserRoleMvoStateEventBase>();
            criteria.Add(Restrictions.Eq("UserRoleMvoEventId.UserRoleIdUserId", idObj.UserId));
            criteria.Add(Restrictions.Eq("UserRoleMvoEventId.UserRoleIdRoleId", idObj.RoleId));
            criteria.Add(Restrictions.Le("UserRoleMvoEventId.UserVersion", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("UserRoleMvoEventId.UserVersion"));
            var es = criteria.List<IEvent>();
            foreach (UserRoleMvoStateEventBase e in es)
            {
                e.EventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((UserRoleMvoStateEventBase)es.Last()).UserRoleMvoEventId.UserVersion : default(long),
                Events = es
            };
        }

	}

}

