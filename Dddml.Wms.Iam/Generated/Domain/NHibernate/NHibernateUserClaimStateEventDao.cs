﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.User.NHibernate
{

	public class NHibernateUserClaimStateEventDao : IUserClaimStateEventDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernateUserClaimStateEventDao ()
		{
		}

		public void Save(IUserClaimStateEvent stateEvent)
		{
			CurrentSession.Save(stateEvent);
            var saveable = stateEvent as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IUserClaimStateEvent> FindByUserEventId(UserEventId userEventId)
        {
            var criteria = CurrentSession.CreateCriteria<UserClaimStateEventBase>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("StateEventId.UserId", userEventId.UserId))
                .Add(Restrictions.Eq("StateEventId.UserVersion", userEventId.Version))
                ;

            return criteria.Add(partIdCondition).List<UserClaimStateEventBase>();
        }

	}
}

