﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.Order.NHibernate
{

	public partial class NHibernateOrderStateRepository : IOrderStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "OrderId", "OrderTypeId", "OrderName", "ExternalId", "SalesChannelEnumId", "OrderDate", "Priority", "EntryDate", "PickSheetPrintedDate", "StatusId", "CurrencyUom", "SyncStatusId", "BillingAccountId", "OriginFacilityId", "WebSiteId", "ProductStoreId", "TerminalId", "TransactionId", "AutoOrderShoppingListId", "NeedsInventoryIssuance", "IsRushOrder", "InternalCode", "RemainingSubTotal", "GrandTotal", "InvoicePerShipment", "OrderItems", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateOrderStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IOrderState Get(string id, bool nullAllowed)
		{
			IOrderState state = CurrentSession.Get<OrderState> (id);
			if (!nullAllowed && state == null) {
				state = new OrderState ();
				(state as OrderState).OrderId = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IOrderState>(state, new Type[] { typeof(ISaveable) }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(IOrderState state)
		{
            IOrderState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IOrderState>(state);
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

