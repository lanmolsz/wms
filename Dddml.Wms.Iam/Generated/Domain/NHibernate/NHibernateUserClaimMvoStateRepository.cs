﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserClaimMvo;
using Dddml.Wms.Domain.User;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.UserClaimMvo.NHibernate
{

	public partial class NHibernateUserClaimMvoStateRepository : IUserClaimMvoStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "UserClaimId", "ClaimType", "ClaimValue", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "UserUserName", "UserAccessFailedCount", "UserEmail", "UserEmailConfirmed", "UserLockoutEnabled", "UserLockoutEndDateUtc", "UserPasswordHash", "UserPhoneNumber", "UserPhoneNumberConfirmed", "UserTwoFactorEnabled", "UserSecurityStamp", "UserUserRoles", "UserUserClaims", "UserUserPermissions", "UserUserLogins", "UserVersion", "UserCreatedBy", "UserCreatedAt", "UserUpdatedBy", "UserUpdatedAt", "UserActive", "UserDeleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateUserClaimMvoStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IUserClaimMvoState Get(UserClaimId id, bool nullAllowed)
		{
			IUserClaimMvoState state = CurrentSession.Get<UserClaimMvoState> (id);
			if (!nullAllowed && state == null) {
				state = new UserClaimMvoState ();
				(state as UserClaimMvoState).UserClaimId = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IUserClaimMvoState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(IUserClaimMvoState state)
		{
            IUserClaimMvoState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IUserClaimMvoState>(state);
            }
			CurrentSession.SaveOrUpdate (s);

			var saveable = s as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
		}

        //protected static void AddNotDeletedRestriction(ICriteria criteria)
        //{
        //    criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        //}

	}
}

