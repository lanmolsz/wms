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

	public abstract class OrderItemMvoStateProperties : IOrderItemMvoStateProperties
	{
		public virtual OrderItemId OrderItemId { get; set; }

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

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

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

		public virtual long OrderVersion { get; set; }

		public virtual string OrderCreatedBy { get; set; }

		public virtual DateTime OrderCreatedAt { get; set; }

		public virtual string OrderUpdatedBy { get; set; }

		public virtual DateTime OrderUpdatedAt { get; set; }

		public virtual bool OrderActive { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
