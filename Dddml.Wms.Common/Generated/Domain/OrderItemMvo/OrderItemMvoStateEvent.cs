﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemMvo;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.OrderItemMvo
{

	public abstract class OrderItemMvoStateEventBase : IOrderItemMvoStateEvent
	{

		public virtual OrderItemMvoEventId StateEventId { get; set; }

        public virtual OrderItemId OrderItemId
        {
            get { return StateEventId.OrderItemId; }
            set { StateEventId.OrderItemId = value; }
        }

		public virtual string ProductId { get; set; }

		public virtual string ExternalProductId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual decimal? CancelQuantity { get; set; }

		public virtual decimal? SelectedAmount { get; set; }

		public virtual string ExternalId { get; set; }

		public virtual string OrderItemTypeId { get; set; }

		public virtual string OrderItemGroupSeqId { get; set; }

		public virtual string IsItemGroupPrimary { get; set; }

		public virtual string FromInventoryItemId { get; set; }

		public virtual string IsPromo { get; set; }

		public virtual string QuoteId { get; set; }

		public virtual string QuoteItemSeqId { get; set; }

		public virtual string ShoppingListId { get; set; }

		public virtual string ShoppingListItemSeqId { get; set; }

		public virtual decimal? UnitPrice { get; set; }

		public virtual decimal? UnitListPrice { get; set; }

		public virtual decimal? UnitAverageCost { get; set; }

		public virtual decimal? UnitRecurringPrice { get; set; }

		public virtual string IsModifiedPrice { get; set; }

		public virtual string RecurringFreqUomId { get; set; }

		public virtual string ItemDescription { get; set; }

		public virtual string Comments { get; set; }

		public virtual string CorrespondingPoId { get; set; }

		public virtual string StatusId { get; set; }

		public virtual string SyncStatusId { get; set; }

		public virtual DateTime? EstimatedShipDate { get; set; }

		public virtual DateTime? EstimatedDeliveryDate { get; set; }

		public virtual DateTime? AutoCancelDate { get; set; }

		public virtual DateTime? DontCancelSetDate { get; set; }

		public virtual string DontCancelSetBy { get; set; }

		public virtual DateTime? ShipBeforeDate { get; set; }

		public virtual DateTime? ShipAfterDate { get; set; }

		public virtual DateTime? CancelBackOrderDate { get; set; }

		public virtual string OverrideGlAccountId { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string OrderOrderTypeId { get; set; }

		public virtual string OrderOrderName { get; set; }

		public virtual string OrderExternalId { get; set; }

		public virtual string OrderSalesChannelEnumId { get; set; }

		public virtual DateTime? OrderOrderDate { get; set; }

		public virtual string OrderPriority { get; set; }

		public virtual DateTime? OrderEntryDate { get; set; }

		public virtual DateTime? OrderPickSheetPrintedDate { get; set; }

		public virtual string OrderStatusId { get; set; }

		public virtual string OrderCurrencyUom { get; set; }

		public virtual string OrderSyncStatusId { get; set; }

		public virtual string OrderBillingAccountId { get; set; }

		public virtual string OrderOriginFacilityId { get; set; }

		public virtual string OrderWebSiteId { get; set; }

		public virtual string OrderProductStoreId { get; set; }

		public virtual string OrderTerminalId { get; set; }

		public virtual string OrderTransactionId { get; set; }

		public virtual string OrderAutoOrderShoppingListId { get; set; }

		public virtual string OrderNeedsInventoryIssuance { get; set; }

		public virtual string OrderIsRushOrder { get; set; }

		public virtual string OrderInternalCode { get; set; }

		public virtual decimal? OrderRemainingSubTotal { get; set; }

		public virtual decimal? OrderGrandTotal { get; set; }

		public virtual string OrderInvoicePerShipment { get; set; }

		public virtual string OrderCreatedBy { get; set; }

		public virtual DateTime? OrderCreatedAt { get; set; }

		public virtual string OrderUpdatedBy { get; set; }

		public virtual DateTime? OrderUpdatedAt { get; set; }

		public virtual bool? OrderActive { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		OrderItemMvoEventId IGlobalIdentity<OrderItemMvoEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IOrderItemMvoStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}

        protected OrderItemMvoStateEventBase()
        {
        }

        protected OrderItemMvoStateEventBase(OrderItemMvoEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class OrderItemMvoStateCreated : OrderItemMvoStateEventBase, IOrderItemMvoStateCreated
	{
		public OrderItemMvoStateCreated () : this(new OrderItemMvoEventId())
		{
		}

		public OrderItemMvoStateCreated (OrderItemMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class OrderItemMvoStateMergePatched : OrderItemMvoStateEventBase, IOrderItemMvoStateMergePatched
	{
		public virtual bool IsPropertyProductIdRemoved { get; set; }

		public virtual bool IsPropertyExternalProductIdRemoved { get; set; }

		public virtual bool IsPropertyQuantityRemoved { get; set; }

		public virtual bool IsPropertyCancelQuantityRemoved { get; set; }

		public virtual bool IsPropertySelectedAmountRemoved { get; set; }

		public virtual bool IsPropertyExternalIdRemoved { get; set; }

		public virtual bool IsPropertyOrderItemTypeIdRemoved { get; set; }

		public virtual bool IsPropertyOrderItemGroupSeqIdRemoved { get; set; }

		public virtual bool IsPropertyIsItemGroupPrimaryRemoved { get; set; }

		public virtual bool IsPropertyFromInventoryItemIdRemoved { get; set; }

		public virtual bool IsPropertyIsPromoRemoved { get; set; }

		public virtual bool IsPropertyQuoteIdRemoved { get; set; }

		public virtual bool IsPropertyQuoteItemSeqIdRemoved { get; set; }

		public virtual bool IsPropertyShoppingListIdRemoved { get; set; }

		public virtual bool IsPropertyShoppingListItemSeqIdRemoved { get; set; }

		public virtual bool IsPropertyUnitPriceRemoved { get; set; }

		public virtual bool IsPropertyUnitListPriceRemoved { get; set; }

		public virtual bool IsPropertyUnitAverageCostRemoved { get; set; }

		public virtual bool IsPropertyUnitRecurringPriceRemoved { get; set; }

		public virtual bool IsPropertyIsModifiedPriceRemoved { get; set; }

		public virtual bool IsPropertyRecurringFreqUomIdRemoved { get; set; }

		public virtual bool IsPropertyItemDescriptionRemoved { get; set; }

		public virtual bool IsPropertyCommentsRemoved { get; set; }

		public virtual bool IsPropertyCorrespondingPoIdRemoved { get; set; }

		public virtual bool IsPropertyStatusIdRemoved { get; set; }

		public virtual bool IsPropertySyncStatusIdRemoved { get; set; }

		public virtual bool IsPropertyEstimatedShipDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedDeliveryDateRemoved { get; set; }

		public virtual bool IsPropertyAutoCancelDateRemoved { get; set; }

		public virtual bool IsPropertyDontCancelSetDateRemoved { get; set; }

		public virtual bool IsPropertyDontCancelSetByRemoved { get; set; }

		public virtual bool IsPropertyShipBeforeDateRemoved { get; set; }

		public virtual bool IsPropertyShipAfterDateRemoved { get; set; }

		public virtual bool IsPropertyCancelBackOrderDateRemoved { get; set; }

		public virtual bool IsPropertyOverrideGlAccountIdRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyOrderOrderTypeIdRemoved { get; set; }

		public virtual bool IsPropertyOrderOrderNameRemoved { get; set; }

		public virtual bool IsPropertyOrderExternalIdRemoved { get; set; }

		public virtual bool IsPropertyOrderSalesChannelEnumIdRemoved { get; set; }

		public virtual bool IsPropertyOrderOrderDateRemoved { get; set; }

		public virtual bool IsPropertyOrderPriorityRemoved { get; set; }

		public virtual bool IsPropertyOrderEntryDateRemoved { get; set; }

		public virtual bool IsPropertyOrderPickSheetPrintedDateRemoved { get; set; }

		public virtual bool IsPropertyOrderStatusIdRemoved { get; set; }

		public virtual bool IsPropertyOrderCurrencyUomRemoved { get; set; }

		public virtual bool IsPropertyOrderSyncStatusIdRemoved { get; set; }

		public virtual bool IsPropertyOrderBillingAccountIdRemoved { get; set; }

		public virtual bool IsPropertyOrderOriginFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyOrderWebSiteIdRemoved { get; set; }

		public virtual bool IsPropertyOrderProductStoreIdRemoved { get; set; }

		public virtual bool IsPropertyOrderTerminalIdRemoved { get; set; }

		public virtual bool IsPropertyOrderTransactionIdRemoved { get; set; }

		public virtual bool IsPropertyOrderAutoOrderShoppingListIdRemoved { get; set; }

		public virtual bool IsPropertyOrderNeedsInventoryIssuanceRemoved { get; set; }

		public virtual bool IsPropertyOrderIsRushOrderRemoved { get; set; }

		public virtual bool IsPropertyOrderInternalCodeRemoved { get; set; }

		public virtual bool IsPropertyOrderRemainingSubTotalRemoved { get; set; }

		public virtual bool IsPropertyOrderGrandTotalRemoved { get; set; }

		public virtual bool IsPropertyOrderInvoicePerShipmentRemoved { get; set; }

		public virtual bool IsPropertyOrderCreatedByRemoved { get; set; }

		public virtual bool IsPropertyOrderCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyOrderUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyOrderUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyOrderActiveRemoved { get; set; }


		public OrderItemMvoStateMergePatched ()
		{
		}

		public OrderItemMvoStateMergePatched (OrderItemMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}

