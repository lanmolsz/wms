﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemMvo;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.OrderItemMvo.NHibernate
{

	public partial class NHibernateOrderItemMvoStateQueryRepository : IOrderItemMvoStateQueryRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "OrderItemId", "ProductId", "ExternalProductId", "Quantity", "CancelQuantity", "SelectedAmount", "ExternalId", "OrderItemTypeId", "OrderItemGroupSeqId", "IsItemGroupPrimary", "FromInventoryItemId", "IsPromo", "QuoteId", "QuoteItemSeqId", "ShoppingListId", "ShoppingListItemSeqId", "UnitPrice", "UnitListPrice", "UnitAverageCost", "UnitRecurringPrice", "IsModifiedPrice", "RecurringFreqUomId", "ItemDescription", "Comments", "CorrespondingPoId", "StatusId", "SyncStatusId", "EstimatedShipDate", "EstimatedDeliveryDate", "AutoCancelDate", "DontCancelSetDate", "DontCancelSetBy", "ShipBeforeDate", "ShipAfterDate", "CancelBackOrderDate", "OverrideGlAccountId", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "OrderOrderTypeId", "OrderOrderName", "OrderExternalId", "OrderSalesChannelEnumId", "OrderOrderDate", "OrderPriority", "OrderEntryDate", "OrderPickSheetPrintedDate", "OrderStatusId", "OrderCurrencyUom", "OrderSyncStatusId", "OrderBillingAccountId", "OrderOriginFacilityId", "OrderWebSiteId", "OrderProductStoreId", "OrderTerminalId", "OrderTransactionId", "OrderAutoOrderShoppingListId", "OrderNeedsInventoryIssuance", "OrderIsRushOrder", "OrderInternalCode", "OrderRemainingSubTotal", "OrderGrandTotal", "OrderInvoicePerShipment", "OrderOrderItems", "OrderVersion", "OrderCreatedBy", "OrderCreatedAt", "OrderUpdatedBy", "OrderUpdatedAt", "OrderActive" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateOrderItemMvoStateQueryRepository ()
		{
		}

		[Transaction (ReadOnly = true)]
		public IOrderItemMvoState Get(OrderItemId id)
		{
			IOrderItemMvoState state = CurrentSession.Get<OrderItemMvoState>(id);
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IOrderItemMvoState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

        [Transaction(ReadOnly = true)]
        public IEnumerable<IOrderItemMvoState> GetAll(int firstResult, int maxResults)
        {
            var criteria = CurrentSession.CreateCriteria<OrderItemMvoState>();
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<OrderItemMvoState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrderItemMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<OrderItemMvoState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<OrderItemMvoState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrderItemMvoState> Get(Dddml.Support.Criterion.ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<OrderItemMvoState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<OrderItemMvoState>();
        }


        [Transaction(ReadOnly = true)]
        public virtual IOrderItemMvoState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null)
        {
            var list = (IList<OrderItemMvoState>)Get(filter, orders, 0, 1);
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        [Transaction(ReadOnly = true)]
        public virtual IOrderItemMvoState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null)
        {
            return GetFirst(new KeyValuePair<string, object>[] { keyValue }, orders);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrderItemMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var filter = new KeyValuePair<string, object>[] { new KeyValuePair<string, object>(propertyName, propertyValue) };
            return Get(filter, orders, firstResult, maxResults);
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
        {
            var criteria = CurrentSession.CreateCriteria<OrderItemMvoState>();
            criteria.SetProjection(Projections.RowCountInt64());
            NHibernateUtils.CriteriaAddFilter(criteria, filter);
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(Dddml.Support.Criterion.ICriterion filter)
        {
            var criteria = CurrentSession.CreateCriteria<OrderItemMvoState>();
            criteria.SetProjection(Projections.RowCountInt64());
            if (filter != null)
            {
                NHibernateICriterion hc = CriterionUtils.ToNHibernateCriterion(filter);
                criteria.Add(hc);
            }
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }


        protected static void AddNotDeletedRestriction(ICriteria criteria)
        {
        }

	}
}

