﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemEntryMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItemEntryMvo;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.SellableInventoryItemEntryMvo.NHibernate
{

	public partial class NHibernateSellableInventoryItemEntryMvoStateRepository : ISellableInventoryItemEntryMvoStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "SellableInventoryItemEntryId", "SellableQuantity", "SourceEventId", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "SellableInventoryItemSellableQuantity", "SellableInventoryItemEntries", "SellableInventoryItemVersion", "SellableInventoryItemCreatedBy", "SellableInventoryItemCreatedAt", "SellableInventoryItemUpdatedBy", "SellableInventoryItemUpdatedAt" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateSellableInventoryItemEntryMvoStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public ISellableInventoryItemEntryMvoState Get(SellableInventoryItemEntryId id, bool nullAllowed)
		{
			ISellableInventoryItemEntryMvoState state = CurrentSession.Get<SellableInventoryItemEntryMvoState> (id);
			if (!nullAllowed && state == null) {
				state = new SellableInventoryItemEntryMvoState ();
				(state as SellableInventoryItemEntryMvoState).SellableInventoryItemEntryId = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<ISellableInventoryItemEntryMvoState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(ISellableInventoryItemEntryMvoState state)
		{
            ISellableInventoryItemEntryMvoState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<ISellableInventoryItemEntryMvoState>(state);
            }
			CurrentSession.SaveOrUpdate (s);

			var saveable = s as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
            CurrentSession.Flush();
		}

        //protected static void AddNotDeletedRestriction(ICriteria criteria)
        //{
        //    criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        //}

	}
}

