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
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.User.NHibernate
{

	public partial class NHibernateUserStateQueryRepository : IUserStateQueryRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "UserId", "UserName", "AccessFailedCount", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEndDateUtc", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "SecurityStamp", "UserRoles", "UserClaims", "UserPermissions", "UserLogins", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateUserStateQueryRepository ()
		{
		}

		[Transaction (ReadOnly = true)]
		public IUserState Get(string id)
		{
			IUserState state = CurrentSession.Get<UserState>(id);
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IUserState>(state, new Type[] { typeof(ISaveable) }, _readOnlyPropertyNames);
            }
			return state;
		}

        [Transaction(ReadOnly = true)]
        public IEnumerable<IUserState> GetAll(int firstResult, int maxResults)
        {
            var criteria = CurrentSession.CreateCriteria<UserState>();
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<UserState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<UserState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<UserState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserState> Get(Dddml.Support.Criterion.ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<UserState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<UserState>();
        }


        [Transaction(ReadOnly = true)]
        public virtual IUserState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null)
        {
            var list = (IList<UserState>)Get(filter, orders, 0, 1);
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null)
        {
            return GetFirst(new KeyValuePair<string, object>[] { keyValue }, orders);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var filter = new KeyValuePair<string, object>[] { new KeyValuePair<string, object>(propertyName, propertyValue) };
            return Get(filter, orders, firstResult, maxResults);
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
        {
            var criteria = CurrentSession.CreateCriteria<UserState>();
            criteria.SetProjection(Projections.RowCountInt64());
            NHibernateUtils.CriteriaAddFilter(criteria, filter);
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(Dddml.Support.Criterion.ICriterion filter)
        {
            var criteria = CurrentSession.CreateCriteria<UserState>();
            criteria.SetProjection(Projections.RowCountInt64());
            if (filter != null)
            {
                NHibernateICriterion hc = CriterionUtils.ToNHibernateCriterion(filter);
                criteria.Add(hc);
            }
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserRoleState GetUserRole(string userId, string roleId)
        {
            var entityId = new UserRoleId(userId, roleId);
            return CurrentSession.Get<UserRoleState>(entityId);
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IUserRoleState> GetUserRoles(string userId)
        {
            var criteria = CurrentSession.CreateCriteria<UserRoleState>();
            var partIdCondition = global::NHibernate.Criterion.Restrictions.Conjunction()
                .Add(global::NHibernate.Criterion.Restrictions.Eq("UserRoleId.UserId", userId))
                ;

            return criteria.Add(partIdCondition).List<UserRoleState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserClaimState GetUserClaim(string userId, int claimId)
        {
            var entityId = new UserClaimId(userId, claimId);
            return CurrentSession.Get<UserClaimState>(entityId);
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IUserClaimState> GetUserClaims(string userId)
        {
            var criteria = CurrentSession.CreateCriteria<UserClaimState>();
            var partIdCondition = global::NHibernate.Criterion.Restrictions.Conjunction()
                .Add(global::NHibernate.Criterion.Restrictions.Eq("UserClaimId.UserId", userId))
                ;

            return criteria.Add(partIdCondition).List<UserClaimState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserPermissionState GetUserPermission(string userId, string permissionId)
        {
            var entityId = new UserPermissionId(userId, permissionId);
            return CurrentSession.Get<UserPermissionState>(entityId);
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IUserPermissionState> GetUserPermissions(string userId)
        {
            var criteria = CurrentSession.CreateCriteria<UserPermissionState>();
            var partIdCondition = global::NHibernate.Criterion.Restrictions.Conjunction()
                .Add(global::NHibernate.Criterion.Restrictions.Eq("UserPermissionId.UserId", userId))
                ;

            return criteria.Add(partIdCondition).List<UserPermissionState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserLoginState GetUserLogin(string userId, LoginKey loginKey)
        {
            var entityId = new UserLoginId(userId, loginKey);
            return CurrentSession.Get<UserLoginState>(entityId);
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IUserLoginState> GetUserLogins(string userId)
        {
            var criteria = CurrentSession.CreateCriteria<UserLoginState>();
            var partIdCondition = global::NHibernate.Criterion.Restrictions.Conjunction()
                .Add(global::NHibernate.Criterion.Restrictions.Eq("UserLoginId.UserId", userId))
                ;

            return criteria.Add(partIdCondition).List<UserLoginState>();
        }


        protected static void AddNotDeletedRestriction(ICriteria criteria)
        {
            criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        }

	}
}

