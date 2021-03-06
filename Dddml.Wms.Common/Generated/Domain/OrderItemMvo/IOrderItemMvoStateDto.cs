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

    public interface IOrderItemMvoStateDto
    {
        OrderItemId OrderItemId
        {
            get;
            set;
        }

        string ProductId
        {
            get;
            set;
        }

        string ExternalProductId
        {
            get;
            set;
        }

        decimal? Quantity
        {
            get;
            set;
        }

        decimal? CancelQuantity
        {
            get;
            set;
        }

        decimal? SelectedAmount
        {
            get;
            set;
        }

        string ExternalId
        {
            get;
            set;
        }

        string OrderItemTypeId
        {
            get;
            set;
        }

        string OrderItemGroupSeqId
        {
            get;
            set;
        }

        string IsItemGroupPrimary
        {
            get;
            set;
        }

        string FromInventoryItemId
        {
            get;
            set;
        }

        string IsPromo
        {
            get;
            set;
        }

        string QuoteId
        {
            get;
            set;
        }

        string QuoteItemSeqId
        {
            get;
            set;
        }

        string ShoppingListId
        {
            get;
            set;
        }

        string ShoppingListItemSeqId
        {
            get;
            set;
        }

        decimal? UnitPrice
        {
            get;
            set;
        }

        decimal? UnitListPrice
        {
            get;
            set;
        }

        decimal? UnitAverageCost
        {
            get;
            set;
        }

        decimal? UnitRecurringPrice
        {
            get;
            set;
        }

        string IsModifiedPrice
        {
            get;
            set;
        }

        string RecurringFreqUomId
        {
            get;
            set;
        }

        string ItemDescription
        {
            get;
            set;
        }

        string Comments
        {
            get;
            set;
        }

        string CorrespondingPoId
        {
            get;
            set;
        }

        string StatusId
        {
            get;
            set;
        }

        string SyncStatusId
        {
            get;
            set;
        }

        DateTime? EstimatedShipDate
        {
            get;
            set;
        }

        DateTime? EstimatedDeliveryDate
        {
            get;
            set;
        }

        DateTime? AutoCancelDate
        {
            get;
            set;
        }

        DateTime? DontCancelSetDate
        {
            get;
            set;
        }

        string DontCancelSetBy
        {
            get;
            set;
        }

        DateTime? ShipBeforeDate
        {
            get;
            set;
        }

        DateTime? ShipAfterDate
        {
            get;
            set;
        }

        DateTime? CancelBackOrderDate
        {
            get;
            set;
        }

        string OverrideGlAccountId
        {
            get;
            set;
        }

        long? Version
        {
            get;
            set;
        }

        bool? Active
        {
            get;
            set;
        }

        string OrderOrderTypeId
        {
            get;
            set;
        }

        string OrderOrderName
        {
            get;
            set;
        }

        string OrderExternalId
        {
            get;
            set;
        }

        string OrderSalesChannelEnumId
        {
            get;
            set;
        }

        DateTime? OrderOrderDate
        {
            get;
            set;
        }

        string OrderPriority
        {
            get;
            set;
        }

        DateTime? OrderEntryDate
        {
            get;
            set;
        }

        DateTime? OrderPickSheetPrintedDate
        {
            get;
            set;
        }

        string OrderStatusId
        {
            get;
            set;
        }

        string OrderCurrencyUom
        {
            get;
            set;
        }

        string OrderSyncStatusId
        {
            get;
            set;
        }

        string OrderBillingAccountId
        {
            get;
            set;
        }

        string OrderOriginFacilityId
        {
            get;
            set;
        }

        string OrderWebSiteId
        {
            get;
            set;
        }

        string OrderProductStoreId
        {
            get;
            set;
        }

        string OrderTerminalId
        {
            get;
            set;
        }

        string OrderTransactionId
        {
            get;
            set;
        }

        string OrderAutoOrderShoppingListId
        {
            get;
            set;
        }

        string OrderNeedsInventoryIssuance
        {
            get;
            set;
        }

        string OrderIsRushOrder
        {
            get;
            set;
        }

        string OrderInternalCode
        {
            get;
            set;
        }

        decimal? OrderRemainingSubTotal
        {
            get;
            set;
        }

        decimal? OrderGrandTotal
        {
            get;
            set;
        }

        string OrderInvoicePerShipment
        {
            get;
            set;
        }

        string OrderCreatedBy
        {
            get;
            set;
        }

        DateTime? OrderCreatedAt
        {
            get;
            set;
        }

        string OrderUpdatedBy
        {
            get;
            set;
        }

        DateTime? OrderUpdatedAt
        {
            get;
            set;
        }

        bool? OrderActive
        {
            get;
            set;
        }

        long? OrderVersion
        {
            get;
            set;
        }

        string CreatedBy
        {
            get;
            set;
        }

        DateTime? CreatedAt
        {
            get;
            set;
        }

        string UpdatedBy
        {
            get;
            set;
        }

        DateTime? UpdatedAt
        {
            get;
            set;
        }

        IOrderItemMvoState ToOrderItemMvoState();

    }

}

