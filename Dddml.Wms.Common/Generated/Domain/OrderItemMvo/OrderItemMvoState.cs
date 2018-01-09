﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemMvo;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.OrderItemMvo
{

	public partial class OrderItemMvoState : OrderItemMvoStateProperties, IOrderItemMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		#region IIdentity implementation

		OrderItemId IGlobalIdentity<OrderItemId>.GlobalId
		{
			get
			{
				return this.OrderItemId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion


		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.OrderVersion;
			}
		}


		#endregion

        bool IOrderItemMvoState.IsUnsaved
        {
            get { return this.OrderVersion == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public OrderItemMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.OrderItemId = ((IOrderItemMvoStateEvent)events.First()).StateEventId.OrderItemId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.OrderVersion += 1;
                }
            }
        }

        public OrderItemMvoState() : this(false)
        {
        }

        public OrderItemMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IOrderItemMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.ProductId = e.ProductId;

			this.ExternalProductId = e.ExternalProductId;

			this.Quantity = e.Quantity;

			this.CancelQuantity = e.CancelQuantity;

			this.SelectedAmount = e.SelectedAmount;

			this.ExternalId = e.ExternalId;

			this.OrderItemTypeId = e.OrderItemTypeId;

			this.OrderItemGroupSeqId = e.OrderItemGroupSeqId;

			this.IsItemGroupPrimary = e.IsItemGroupPrimary;

			this.FromInventoryItemId = e.FromInventoryItemId;

			this.IsPromo = e.IsPromo;

			this.QuoteId = e.QuoteId;

			this.QuoteItemSeqId = e.QuoteItemSeqId;

			this.ShoppingListId = e.ShoppingListId;

			this.ShoppingListItemSeqId = e.ShoppingListItemSeqId;

			this.UnitPrice = e.UnitPrice;

			this.UnitListPrice = e.UnitListPrice;

			this.UnitAverageCost = e.UnitAverageCost;

			this.UnitRecurringPrice = e.UnitRecurringPrice;

			this.IsModifiedPrice = e.IsModifiedPrice;

			this.RecurringFreqUomId = e.RecurringFreqUomId;

			this.ItemDescription = e.ItemDescription;

			this.Comments = e.Comments;

			this.CorrespondingPoId = e.CorrespondingPoId;

			this.StatusId = e.StatusId;

			this.SyncStatusId = e.SyncStatusId;

			this.EstimatedShipDate = e.EstimatedShipDate;

			this.EstimatedDeliveryDate = e.EstimatedDeliveryDate;

			this.AutoCancelDate = e.AutoCancelDate;

			this.DontCancelSetDate = e.DontCancelSetDate;

			this.DontCancelSetBy = e.DontCancelSetBy;

			this.ShipBeforeDate = e.ShipBeforeDate;

			this.ShipAfterDate = e.ShipAfterDate;

			this.CancelBackOrderDate = e.CancelBackOrderDate;

			this.OverrideGlAccountId = e.OverrideGlAccountId;

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.OrderOrderTypeId = e.OrderOrderTypeId;

			this.OrderOrderName = e.OrderOrderName;

			this.OrderExternalId = e.OrderExternalId;

			this.OrderSalesChannelEnumId = e.OrderSalesChannelEnumId;

			this.OrderOrderDate = e.OrderOrderDate;

			this.OrderPriority = e.OrderPriority;

			this.OrderEntryDate = e.OrderEntryDate;

			this.OrderPickSheetPrintedDate = e.OrderPickSheetPrintedDate;

			this.OrderStatusId = e.OrderStatusId;

			this.OrderCurrencyUom = e.OrderCurrencyUom;

			this.OrderSyncStatusId = e.OrderSyncStatusId;

			this.OrderBillingAccountId = e.OrderBillingAccountId;

			this.OrderOriginFacilityId = e.OrderOriginFacilityId;

			this.OrderWebSiteId = e.OrderWebSiteId;

			this.OrderProductStoreId = e.OrderProductStoreId;

			this.OrderTerminalId = e.OrderTerminalId;

			this.OrderTransactionId = e.OrderTransactionId;

			this.OrderAutoOrderShoppingListId = e.OrderAutoOrderShoppingListId;

			this.OrderNeedsInventoryIssuance = e.OrderNeedsInventoryIssuance;

			this.OrderIsRushOrder = e.OrderIsRushOrder;

			this.OrderInternalCode = e.OrderInternalCode;

			this.OrderRemainingSubTotal = e.OrderRemainingSubTotal;

			this.OrderGrandTotal = e.OrderGrandTotal;

			this.OrderInvoicePerShipment = e.OrderInvoicePerShipment;

			this.OrderCreatedBy = e.OrderCreatedBy;

            this.OrderCreatedAt = (e.OrderCreatedAt != null && e.OrderCreatedAt.HasValue) ? e.OrderCreatedAt.Value : default(DateTime);

			this.OrderUpdatedBy = e.OrderUpdatedBy;

            this.OrderUpdatedAt = (e.OrderUpdatedAt != null && e.OrderUpdatedAt.HasValue) ? e.OrderUpdatedAt.Value : default(DateTime);

            this.OrderActive = (e.OrderActive != null && e.OrderActive.HasValue) ? e.OrderActive.Value : default(bool);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IOrderItemMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.ProductId == null)
			{
				if (e.IsPropertyProductIdRemoved)
				{
					this.ProductId = default(string);
				}
			}
			else
			{
				this.ProductId = e.ProductId;
			}

			if (e.ExternalProductId == null)
			{
				if (e.IsPropertyExternalProductIdRemoved)
				{
					this.ExternalProductId = default(string);
				}
			}
			else
			{
				this.ExternalProductId = e.ExternalProductId;
			}

			if (e.Quantity == null)
			{
				if (e.IsPropertyQuantityRemoved)
				{
					this.Quantity = default(decimal?);
				}
			}
			else
			{
				this.Quantity = e.Quantity;
			}

			if (e.CancelQuantity == null)
			{
				if (e.IsPropertyCancelQuantityRemoved)
				{
					this.CancelQuantity = default(decimal?);
				}
			}
			else
			{
				this.CancelQuantity = e.CancelQuantity;
			}

			if (e.SelectedAmount == null)
			{
				if (e.IsPropertySelectedAmountRemoved)
				{
					this.SelectedAmount = default(decimal?);
				}
			}
			else
			{
				this.SelectedAmount = e.SelectedAmount;
			}

			if (e.ExternalId == null)
			{
				if (e.IsPropertyExternalIdRemoved)
				{
					this.ExternalId = default(string);
				}
			}
			else
			{
				this.ExternalId = e.ExternalId;
			}

			if (e.OrderItemTypeId == null)
			{
				if (e.IsPropertyOrderItemTypeIdRemoved)
				{
					this.OrderItemTypeId = default(string);
				}
			}
			else
			{
				this.OrderItemTypeId = e.OrderItemTypeId;
			}

			if (e.OrderItemGroupSeqId == null)
			{
				if (e.IsPropertyOrderItemGroupSeqIdRemoved)
				{
					this.OrderItemGroupSeqId = default(string);
				}
			}
			else
			{
				this.OrderItemGroupSeqId = e.OrderItemGroupSeqId;
			}

			if (e.IsItemGroupPrimary == null)
			{
				if (e.IsPropertyIsItemGroupPrimaryRemoved)
				{
					this.IsItemGroupPrimary = default(string);
				}
			}
			else
			{
				this.IsItemGroupPrimary = e.IsItemGroupPrimary;
			}

			if (e.FromInventoryItemId == null)
			{
				if (e.IsPropertyFromInventoryItemIdRemoved)
				{
					this.FromInventoryItemId = default(string);
				}
			}
			else
			{
				this.FromInventoryItemId = e.FromInventoryItemId;
			}

			if (e.IsPromo == null)
			{
				if (e.IsPropertyIsPromoRemoved)
				{
					this.IsPromo = default(string);
				}
			}
			else
			{
				this.IsPromo = e.IsPromo;
			}

			if (e.QuoteId == null)
			{
				if (e.IsPropertyQuoteIdRemoved)
				{
					this.QuoteId = default(string);
				}
			}
			else
			{
				this.QuoteId = e.QuoteId;
			}

			if (e.QuoteItemSeqId == null)
			{
				if (e.IsPropertyQuoteItemSeqIdRemoved)
				{
					this.QuoteItemSeqId = default(string);
				}
			}
			else
			{
				this.QuoteItemSeqId = e.QuoteItemSeqId;
			}

			if (e.ShoppingListId == null)
			{
				if (e.IsPropertyShoppingListIdRemoved)
				{
					this.ShoppingListId = default(string);
				}
			}
			else
			{
				this.ShoppingListId = e.ShoppingListId;
			}

			if (e.ShoppingListItemSeqId == null)
			{
				if (e.IsPropertyShoppingListItemSeqIdRemoved)
				{
					this.ShoppingListItemSeqId = default(string);
				}
			}
			else
			{
				this.ShoppingListItemSeqId = e.ShoppingListItemSeqId;
			}

			if (e.UnitPrice == null)
			{
				if (e.IsPropertyUnitPriceRemoved)
				{
					this.UnitPrice = default(decimal?);
				}
			}
			else
			{
				this.UnitPrice = e.UnitPrice;
			}

			if (e.UnitListPrice == null)
			{
				if (e.IsPropertyUnitListPriceRemoved)
				{
					this.UnitListPrice = default(decimal?);
				}
			}
			else
			{
				this.UnitListPrice = e.UnitListPrice;
			}

			if (e.UnitAverageCost == null)
			{
				if (e.IsPropertyUnitAverageCostRemoved)
				{
					this.UnitAverageCost = default(decimal?);
				}
			}
			else
			{
				this.UnitAverageCost = e.UnitAverageCost;
			}

			if (e.UnitRecurringPrice == null)
			{
				if (e.IsPropertyUnitRecurringPriceRemoved)
				{
					this.UnitRecurringPrice = default(decimal?);
				}
			}
			else
			{
				this.UnitRecurringPrice = e.UnitRecurringPrice;
			}

			if (e.IsModifiedPrice == null)
			{
				if (e.IsPropertyIsModifiedPriceRemoved)
				{
					this.IsModifiedPrice = default(string);
				}
			}
			else
			{
				this.IsModifiedPrice = e.IsModifiedPrice;
			}

			if (e.RecurringFreqUomId == null)
			{
				if (e.IsPropertyRecurringFreqUomIdRemoved)
				{
					this.RecurringFreqUomId = default(string);
				}
			}
			else
			{
				this.RecurringFreqUomId = e.RecurringFreqUomId;
			}

			if (e.ItemDescription == null)
			{
				if (e.IsPropertyItemDescriptionRemoved)
				{
					this.ItemDescription = default(string);
				}
			}
			else
			{
				this.ItemDescription = e.ItemDescription;
			}

			if (e.Comments == null)
			{
				if (e.IsPropertyCommentsRemoved)
				{
					this.Comments = default(string);
				}
			}
			else
			{
				this.Comments = e.Comments;
			}

			if (e.CorrespondingPoId == null)
			{
				if (e.IsPropertyCorrespondingPoIdRemoved)
				{
					this.CorrespondingPoId = default(string);
				}
			}
			else
			{
				this.CorrespondingPoId = e.CorrespondingPoId;
			}

			if (e.StatusId == null)
			{
				if (e.IsPropertyStatusIdRemoved)
				{
					this.StatusId = default(string);
				}
			}
			else
			{
				this.StatusId = e.StatusId;
			}

			if (e.SyncStatusId == null)
			{
				if (e.IsPropertySyncStatusIdRemoved)
				{
					this.SyncStatusId = default(string);
				}
			}
			else
			{
				this.SyncStatusId = e.SyncStatusId;
			}

			if (e.EstimatedShipDate == null)
			{
				if (e.IsPropertyEstimatedShipDateRemoved)
				{
					this.EstimatedShipDate = default(DateTime?);
				}
			}
			else
			{
				this.EstimatedShipDate = e.EstimatedShipDate;
			}

			if (e.EstimatedDeliveryDate == null)
			{
				if (e.IsPropertyEstimatedDeliveryDateRemoved)
				{
					this.EstimatedDeliveryDate = default(DateTime?);
				}
			}
			else
			{
				this.EstimatedDeliveryDate = e.EstimatedDeliveryDate;
			}

			if (e.AutoCancelDate == null)
			{
				if (e.IsPropertyAutoCancelDateRemoved)
				{
					this.AutoCancelDate = default(DateTime?);
				}
			}
			else
			{
				this.AutoCancelDate = e.AutoCancelDate;
			}

			if (e.DontCancelSetDate == null)
			{
				if (e.IsPropertyDontCancelSetDateRemoved)
				{
					this.DontCancelSetDate = default(DateTime?);
				}
			}
			else
			{
				this.DontCancelSetDate = e.DontCancelSetDate;
			}

			if (e.DontCancelSetBy == null)
			{
				if (e.IsPropertyDontCancelSetByRemoved)
				{
					this.DontCancelSetBy = default(string);
				}
			}
			else
			{
				this.DontCancelSetBy = e.DontCancelSetBy;
			}

			if (e.ShipBeforeDate == null)
			{
				if (e.IsPropertyShipBeforeDateRemoved)
				{
					this.ShipBeforeDate = default(DateTime?);
				}
			}
			else
			{
				this.ShipBeforeDate = e.ShipBeforeDate;
			}

			if (e.ShipAfterDate == null)
			{
				if (e.IsPropertyShipAfterDateRemoved)
				{
					this.ShipAfterDate = default(DateTime?);
				}
			}
			else
			{
				this.ShipAfterDate = e.ShipAfterDate;
			}

			if (e.CancelBackOrderDate == null)
			{
				if (e.IsPropertyCancelBackOrderDateRemoved)
				{
					this.CancelBackOrderDate = default(DateTime?);
				}
			}
			else
			{
				this.CancelBackOrderDate = e.CancelBackOrderDate;
			}

			if (e.OverrideGlAccountId == null)
			{
				if (e.IsPropertyOverrideGlAccountIdRemoved)
				{
					this.OverrideGlAccountId = default(string);
				}
			}
			else
			{
				this.OverrideGlAccountId = e.OverrideGlAccountId;
			}

			if (e.Version == null)
			{
				if (e.IsPropertyVersionRemoved)
				{
					this.Version = default(long);
				}
			}
			else
			{
				this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}

			if (e.OrderOrderTypeId == null)
			{
				if (e.IsPropertyOrderOrderTypeIdRemoved)
				{
					this.OrderOrderTypeId = default(string);
				}
			}
			else
			{
				this.OrderOrderTypeId = e.OrderOrderTypeId;
			}

			if (e.OrderOrderName == null)
			{
				if (e.IsPropertyOrderOrderNameRemoved)
				{
					this.OrderOrderName = default(string);
				}
			}
			else
			{
				this.OrderOrderName = e.OrderOrderName;
			}

			if (e.OrderExternalId == null)
			{
				if (e.IsPropertyOrderExternalIdRemoved)
				{
					this.OrderExternalId = default(string);
				}
			}
			else
			{
				this.OrderExternalId = e.OrderExternalId;
			}

			if (e.OrderSalesChannelEnumId == null)
			{
				if (e.IsPropertyOrderSalesChannelEnumIdRemoved)
				{
					this.OrderSalesChannelEnumId = default(string);
				}
			}
			else
			{
				this.OrderSalesChannelEnumId = e.OrderSalesChannelEnumId;
			}

			if (e.OrderOrderDate == null)
			{
				if (e.IsPropertyOrderOrderDateRemoved)
				{
					this.OrderOrderDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderOrderDate = e.OrderOrderDate;
			}

			if (e.OrderPriority == null)
			{
				if (e.IsPropertyOrderPriorityRemoved)
				{
					this.OrderPriority = default(string);
				}
			}
			else
			{
				this.OrderPriority = e.OrderPriority;
			}

			if (e.OrderEntryDate == null)
			{
				if (e.IsPropertyOrderEntryDateRemoved)
				{
					this.OrderEntryDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderEntryDate = e.OrderEntryDate;
			}

			if (e.OrderPickSheetPrintedDate == null)
			{
				if (e.IsPropertyOrderPickSheetPrintedDateRemoved)
				{
					this.OrderPickSheetPrintedDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderPickSheetPrintedDate = e.OrderPickSheetPrintedDate;
			}

			if (e.OrderStatusId == null)
			{
				if (e.IsPropertyOrderStatusIdRemoved)
				{
					this.OrderStatusId = default(string);
				}
			}
			else
			{
				this.OrderStatusId = e.OrderStatusId;
			}

			if (e.OrderCurrencyUom == null)
			{
				if (e.IsPropertyOrderCurrencyUomRemoved)
				{
					this.OrderCurrencyUom = default(string);
				}
			}
			else
			{
				this.OrderCurrencyUom = e.OrderCurrencyUom;
			}

			if (e.OrderSyncStatusId == null)
			{
				if (e.IsPropertyOrderSyncStatusIdRemoved)
				{
					this.OrderSyncStatusId = default(string);
				}
			}
			else
			{
				this.OrderSyncStatusId = e.OrderSyncStatusId;
			}

			if (e.OrderBillingAccountId == null)
			{
				if (e.IsPropertyOrderBillingAccountIdRemoved)
				{
					this.OrderBillingAccountId = default(string);
				}
			}
			else
			{
				this.OrderBillingAccountId = e.OrderBillingAccountId;
			}

			if (e.OrderOriginFacilityId == null)
			{
				if (e.IsPropertyOrderOriginFacilityIdRemoved)
				{
					this.OrderOriginFacilityId = default(string);
				}
			}
			else
			{
				this.OrderOriginFacilityId = e.OrderOriginFacilityId;
			}

			if (e.OrderWebSiteId == null)
			{
				if (e.IsPropertyOrderWebSiteIdRemoved)
				{
					this.OrderWebSiteId = default(string);
				}
			}
			else
			{
				this.OrderWebSiteId = e.OrderWebSiteId;
			}

			if (e.OrderProductStoreId == null)
			{
				if (e.IsPropertyOrderProductStoreIdRemoved)
				{
					this.OrderProductStoreId = default(string);
				}
			}
			else
			{
				this.OrderProductStoreId = e.OrderProductStoreId;
			}

			if (e.OrderTerminalId == null)
			{
				if (e.IsPropertyOrderTerminalIdRemoved)
				{
					this.OrderTerminalId = default(string);
				}
			}
			else
			{
				this.OrderTerminalId = e.OrderTerminalId;
			}

			if (e.OrderTransactionId == null)
			{
				if (e.IsPropertyOrderTransactionIdRemoved)
				{
					this.OrderTransactionId = default(string);
				}
			}
			else
			{
				this.OrderTransactionId = e.OrderTransactionId;
			}

			if (e.OrderAutoOrderShoppingListId == null)
			{
				if (e.IsPropertyOrderAutoOrderShoppingListIdRemoved)
				{
					this.OrderAutoOrderShoppingListId = default(string);
				}
			}
			else
			{
				this.OrderAutoOrderShoppingListId = e.OrderAutoOrderShoppingListId;
			}

			if (e.OrderNeedsInventoryIssuance == null)
			{
				if (e.IsPropertyOrderNeedsInventoryIssuanceRemoved)
				{
					this.OrderNeedsInventoryIssuance = default(string);
				}
			}
			else
			{
				this.OrderNeedsInventoryIssuance = e.OrderNeedsInventoryIssuance;
			}

			if (e.OrderIsRushOrder == null)
			{
				if (e.IsPropertyOrderIsRushOrderRemoved)
				{
					this.OrderIsRushOrder = default(string);
				}
			}
			else
			{
				this.OrderIsRushOrder = e.OrderIsRushOrder;
			}

			if (e.OrderInternalCode == null)
			{
				if (e.IsPropertyOrderInternalCodeRemoved)
				{
					this.OrderInternalCode = default(string);
				}
			}
			else
			{
				this.OrderInternalCode = e.OrderInternalCode;
			}

			if (e.OrderRemainingSubTotal == null)
			{
				if (e.IsPropertyOrderRemainingSubTotalRemoved)
				{
					this.OrderRemainingSubTotal = default(decimal?);
				}
			}
			else
			{
				this.OrderRemainingSubTotal = e.OrderRemainingSubTotal;
			}

			if (e.OrderGrandTotal == null)
			{
				if (e.IsPropertyOrderGrandTotalRemoved)
				{
					this.OrderGrandTotal = default(decimal?);
				}
			}
			else
			{
				this.OrderGrandTotal = e.OrderGrandTotal;
			}

			if (e.OrderInvoicePerShipment == null)
			{
				if (e.IsPropertyOrderInvoicePerShipmentRemoved)
				{
					this.OrderInvoicePerShipment = default(string);
				}
			}
			else
			{
				this.OrderInvoicePerShipment = e.OrderInvoicePerShipment;
			}

			if (e.OrderCreatedBy == null)
			{
				if (e.IsPropertyOrderCreatedByRemoved)
				{
					this.OrderCreatedBy = default(string);
				}
			}
			else
			{
				this.OrderCreatedBy = e.OrderCreatedBy;
			}

			if (e.OrderCreatedAt == null)
			{
				if (e.IsPropertyOrderCreatedAtRemoved)
				{
					this.OrderCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.OrderCreatedAt = (e.OrderCreatedAt != null && e.OrderCreatedAt.HasValue) ? e.OrderCreatedAt.Value : default(DateTime);
			}

			if (e.OrderUpdatedBy == null)
			{
				if (e.IsPropertyOrderUpdatedByRemoved)
				{
					this.OrderUpdatedBy = default(string);
				}
			}
			else
			{
				this.OrderUpdatedBy = e.OrderUpdatedBy;
			}

			if (e.OrderUpdatedAt == null)
			{
				if (e.IsPropertyOrderUpdatedAtRemoved)
				{
					this.OrderUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.OrderUpdatedAt = (e.OrderUpdatedAt != null && e.OrderUpdatedAt.HasValue) ? e.OrderUpdatedAt.Value : default(DateTime);
			}

			if (e.OrderActive == null)
			{
				if (e.IsPropertyOrderActiveRemoved)
				{
					this.OrderActive = default(bool);
				}
			}
			else
			{
				this.OrderActive = (e.OrderActive != null && e.OrderActive.HasValue) ? e.OrderActive.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IOrderItemMvoStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("OrderItemMvo|");

            var stateEntityId = this.OrderItemId; // Aggregate Id
            var eventEntityId = stateEvent.StateEventId.OrderItemId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.OrderVersion;
            var eventVersion = stateEvent.StateEventId.OrderVersion;
            if (stateVersion > eventVersion)//!=
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

