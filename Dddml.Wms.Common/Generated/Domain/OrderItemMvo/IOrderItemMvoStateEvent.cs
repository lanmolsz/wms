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
	public interface IOrderItemMvoStateEvent : IEvent, IStateEventDto, IGlobalIdentity<OrderItemMvoStateEventId>, ICreated<string>
	{
		OrderItemMvoStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string ProductId { get; set; }

		string ExternalProductId { get; set; }

		decimal? Quantity { get; set; }

		decimal? CancelQuantity { get; set; }

		decimal? SelectedAmount { get; set; }

		string ExternalId { get; set; }

		string OrderItemTypeId { get; set; }

		string OrderItemGroupSeqId { get; set; }

		string IsItemGroupPrimary { get; set; }

		string FromInventoryItemId { get; set; }

		string IsPromo { get; set; }

		string QuoteId { get; set; }

		string QuoteItemSeqId { get; set; }

		string ShoppingListId { get; set; }

		string ShoppingListItemSeqId { get; set; }

		decimal? UnitPrice { get; set; }

		decimal? UnitListPrice { get; set; }

		decimal? UnitAverageCost { get; set; }

		decimal? UnitRecurringPrice { get; set; }

		string IsModifiedPrice { get; set; }

		string RecurringFreqUomId { get; set; }

		string ItemDescription { get; set; }

		string Comments { get; set; }

		string CorrespondingPoId { get; set; }

		string StatusId { get; set; }

		string SyncStatusId { get; set; }

		DateTime? EstimatedShipDate { get; set; }

		DateTime? EstimatedDeliveryDate { get; set; }

		DateTime? AutoCancelDate { get; set; }

		DateTime? DontCancelSetDate { get; set; }

		string DontCancelSetBy { get; set; }

		DateTime? ShipBeforeDate { get; set; }

		DateTime? ShipAfterDate { get; set; }

		DateTime? CancelBackOrderDate { get; set; }

		string OverrideGlAccountId { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		string OrderOrderTypeId { get; set; }

		string OrderOrderName { get; set; }

		string OrderExternalId { get; set; }

		string OrderSalesChannelEnumId { get; set; }

		DateTime? OrderOrderDate { get; set; }

		string OrderPriority { get; set; }

		DateTime? OrderEntryDate { get; set; }

		DateTime? OrderPickSheetPrintedDate { get; set; }

		string OrderStatusId { get; set; }

		string OrderCurrencyUom { get; set; }

		string OrderSyncStatusId { get; set; }

		string OrderBillingAccountId { get; set; }

		string OrderOriginFacilityId { get; set; }

		string OrderWebSiteId { get; set; }

		string OrderProductStoreId { get; set; }

		string OrderTerminalId { get; set; }

		string OrderTransactionId { get; set; }

		string OrderAutoOrderShoppingListId { get; set; }

		string OrderNeedsInventoryIssuance { get; set; }

		string OrderIsRushOrder { get; set; }

		string OrderInternalCode { get; set; }

		decimal? OrderRemainingSubTotal { get; set; }

		decimal? OrderGrandTotal { get; set; }

		string OrderInvoicePerShipment { get; set; }

		string OrderCreatedBy { get; set; }

		DateTime? OrderCreatedAt { get; set; }

		string OrderUpdatedBy { get; set; }

		DateTime? OrderUpdatedAt { get; set; }

		bool? OrderActive { get; set; }

	}

	public interface IOrderItemMvoStateCreated : IOrderItemMvoStateEvent//, IOrderItemMvoStateProperties
	{
	
	}


	public interface IOrderItemMvoStateMergePatched : IOrderItemMvoStateEvent//, IOrderItemMvoStateProperties
	{
		bool IsPropertyProductIdRemoved { get; set; }

		bool IsPropertyExternalProductIdRemoved { get; set; }

		bool IsPropertyQuantityRemoved { get; set; }

		bool IsPropertyCancelQuantityRemoved { get; set; }

		bool IsPropertySelectedAmountRemoved { get; set; }

		bool IsPropertyExternalIdRemoved { get; set; }

		bool IsPropertyOrderItemTypeIdRemoved { get; set; }

		bool IsPropertyOrderItemGroupSeqIdRemoved { get; set; }

		bool IsPropertyIsItemGroupPrimaryRemoved { get; set; }

		bool IsPropertyFromInventoryItemIdRemoved { get; set; }

		bool IsPropertyIsPromoRemoved { get; set; }

		bool IsPropertyQuoteIdRemoved { get; set; }

		bool IsPropertyQuoteItemSeqIdRemoved { get; set; }

		bool IsPropertyShoppingListIdRemoved { get; set; }

		bool IsPropertyShoppingListItemSeqIdRemoved { get; set; }

		bool IsPropertyUnitPriceRemoved { get; set; }

		bool IsPropertyUnitListPriceRemoved { get; set; }

		bool IsPropertyUnitAverageCostRemoved { get; set; }

		bool IsPropertyUnitRecurringPriceRemoved { get; set; }

		bool IsPropertyIsModifiedPriceRemoved { get; set; }

		bool IsPropertyRecurringFreqUomIdRemoved { get; set; }

		bool IsPropertyItemDescriptionRemoved { get; set; }

		bool IsPropertyCommentsRemoved { get; set; }

		bool IsPropertyCorrespondingPoIdRemoved { get; set; }

		bool IsPropertyStatusIdRemoved { get; set; }

		bool IsPropertySyncStatusIdRemoved { get; set; }

		bool IsPropertyEstimatedShipDateRemoved { get; set; }

		bool IsPropertyEstimatedDeliveryDateRemoved { get; set; }

		bool IsPropertyAutoCancelDateRemoved { get; set; }

		bool IsPropertyDontCancelSetDateRemoved { get; set; }

		bool IsPropertyDontCancelSetByRemoved { get; set; }

		bool IsPropertyShipBeforeDateRemoved { get; set; }

		bool IsPropertyShipAfterDateRemoved { get; set; }

		bool IsPropertyCancelBackOrderDateRemoved { get; set; }

		bool IsPropertyOverrideGlAccountIdRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyOrderOrderTypeIdRemoved { get; set; }

		bool IsPropertyOrderOrderNameRemoved { get; set; }

		bool IsPropertyOrderExternalIdRemoved { get; set; }

		bool IsPropertyOrderSalesChannelEnumIdRemoved { get; set; }

		bool IsPropertyOrderOrderDateRemoved { get; set; }

		bool IsPropertyOrderPriorityRemoved { get; set; }

		bool IsPropertyOrderEntryDateRemoved { get; set; }

		bool IsPropertyOrderPickSheetPrintedDateRemoved { get; set; }

		bool IsPropertyOrderStatusIdRemoved { get; set; }

		bool IsPropertyOrderCurrencyUomRemoved { get; set; }

		bool IsPropertyOrderSyncStatusIdRemoved { get; set; }

		bool IsPropertyOrderBillingAccountIdRemoved { get; set; }

		bool IsPropertyOrderOriginFacilityIdRemoved { get; set; }

		bool IsPropertyOrderWebSiteIdRemoved { get; set; }

		bool IsPropertyOrderProductStoreIdRemoved { get; set; }

		bool IsPropertyOrderTerminalIdRemoved { get; set; }

		bool IsPropertyOrderTransactionIdRemoved { get; set; }

		bool IsPropertyOrderAutoOrderShoppingListIdRemoved { get; set; }

		bool IsPropertyOrderNeedsInventoryIssuanceRemoved { get; set; }

		bool IsPropertyOrderIsRushOrderRemoved { get; set; }

		bool IsPropertyOrderInternalCodeRemoved { get; set; }

		bool IsPropertyOrderRemainingSubTotalRemoved { get; set; }

		bool IsPropertyOrderGrandTotalRemoved { get; set; }

		bool IsPropertyOrderInvoicePerShipmentRemoved { get; set; }

		bool IsPropertyOrderCreatedByRemoved { get; set; }

		bool IsPropertyOrderCreatedAtRemoved { get; set; }

		bool IsPropertyOrderUpdatedByRemoved { get; set; }

		bool IsPropertyOrderUpdatedAtRemoved { get; set; }

		bool IsPropertyOrderActiveRemoved { get; set; }


	}

	public interface IOrderItemMvoStateDeleted : IOrderItemMvoStateEvent
	{
	}


}
