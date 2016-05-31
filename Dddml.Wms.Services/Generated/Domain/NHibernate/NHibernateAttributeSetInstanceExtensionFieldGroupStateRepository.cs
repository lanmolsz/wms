﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;

namespace Dddml.Wms.Domain.NHibernate
{

	public class NHibernateAttributeSetInstanceExtensionFieldGroupStateRepository : IAttributeSetInstanceExtensionFieldGroupStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernateAttributeSetInstanceExtensionFieldGroupStateRepository ()
		{
		}

		[Transaction (ReadOnly = true)]
		public IAttributeSetInstanceExtensionFieldGroupState Get (string id)
		{
			IAttributeSetInstanceExtensionFieldGroupState state = CurrentSession.Get<AttributeSetInstanceExtensionFieldGroupState> (id);
			if (state == null) {
				state = new AttributeSetInstanceExtensionFieldGroupState ();
				(state as AttributeSetInstanceExtensionFieldGroupState).Id = id;
			}
			return state;
		}

        [Transaction(ReadOnly = true)]
        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> GetAll(int firstResult, int maxResults)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldGroupState>();
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            return criteria.List<AttributeSetInstanceExtensionFieldGroupState>();
        }

		[Transaction]
		public void Save (IAttributeSetInstanceExtensionFieldGroupState state)
		{
			CurrentSession.SaveOrUpdate (state);

			var saveable = state as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
		}

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldGroupState>();

            if (filter != null)
            {
                SetCriteriaFilter(criteria, filter);
            }
            if (orders != null)
            {
                SetCriteriaOrders(criteria, orders);
            }

            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            return criteria.List<AttributeSetInstanceExtensionFieldGroupState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(Dddml.Support.Criterion.ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldGroupState>();

            if (filter != null)
            {
                NHibernateICriterion hc = CriterionUtils.ToNHibernateCriterion(filter);
                criteria.Add(hc);
            }
            if (orders != null)
            {
                SetCriteriaOrders(criteria, orders);
            }

            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            return criteria.List<AttributeSetInstanceExtensionFieldGroupState>();
        }


        [Transaction(ReadOnly = true)]
        public virtual IAttributeSetInstanceExtensionFieldGroupState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null)
        {
            var list = (IList<AttributeSetInstanceExtensionFieldGroupState>)Get(filter, orders, 0, 1);
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        [Transaction(ReadOnly = true)]
        public virtual IAttributeSetInstanceExtensionFieldGroupState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null)
        {
            return GetFirst(new KeyValuePair<string, object>[] { keyValue }, orders);
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldGroupState>();
            criteria.SetProjection(Projections.RowCountInt64());
            SetCriteriaFilter(criteria, filter);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(Dddml.Support.Criterion.ICriterion filter)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldGroupState>();
            criteria.SetProjection(Projections.RowCountInt64());
            if (filter != null)
            {
                NHibernateICriterion hc = CriterionUtils.ToNHibernateCriterion(filter);
                criteria.Add(hc);
            }
            return criteria.UniqueResult<long>();
        }

        protected void SetCriteriaFilter(ICriteria criteria, IEnumerable<KeyValuePair<string, object>> filter)
        {
            foreach (KeyValuePair<string, object> p in filter)
            {
                SetCriteriaFilterPair(criteria, p);
            }
        }

        protected void SetCriteriaFilterPair(ICriteria criteria, KeyValuePair<string, object> filterPair)
        {
            if (filterPair.Value == null)
            {
                criteria.Add(Expression.IsNull(filterPair.Key));
            }
            else
            {
                criteria.Add(Expression.Eq(filterPair.Key, filterPair.Value));
            }
        }

        protected void SetCriteriaOrders(ICriteria criteria, IList<string> orders)
        {
            foreach (var order in orders)
            {
                bool isDesc = order.StartsWith("-");
                var pName = isDesc ? order.Substring(1) : order;
                criteria.AddOrder(isDesc ? Order.Desc(pName) : Order.Asc(pName));
            }
        }

	}
}

