﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItem;

namespace Dddml.Wms.Domain.OrderItem
{

	public static partial class OrderItemStateInterfaceExtension
	{

        public static IOrderItemCommand ToCreateOrMergePatchOrderItem<TCreateOrderItem, TMergePatchOrderItem>(this IOrderItemState state)
            where TCreateOrderItem : ICreateOrderItem, new()
            where TMergePatchOrderItem : IMergePatchOrderItem, new()
        {
            bool bUnsaved = ((IOrderItemState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateOrderItem<TCreateOrderItem>();
            }
            else 
            {
                return state.ToMergePatchOrderItem<TMergePatchOrderItem>();
            }
        }

        public static TDeleteOrderItem ToDeleteOrderItem<TDeleteOrderItem>(this IOrderItemState state)
            where TDeleteOrderItem : IDeleteOrderItem, new()
        {
            var cmd = new TDeleteOrderItem();
            cmd.OrderItemId = state.OrderItemId;
            cmd.Version = ((IOrderItemStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchOrderItem ToMergePatchOrderItem<TMergePatchOrderItem>(this IOrderItemState state)
            where TMergePatchOrderItem : IMergePatchOrderItem, new()
        {
            var cmd = new TMergePatchOrderItem();

            cmd.Version = ((IOrderItemStateProperties)state).Version;

            cmd.OrderItemId = state.OrderItemId;
            cmd.ProductId = state.ProductId;
            cmd.ExternalProductId = state.ExternalProductId;
            cmd.Quantity = state.Quantity;
            cmd.CancelQuantity = state.CancelQuantity;
            cmd.SelectedAmount = state.SelectedAmount;
            cmd.ExternalId = state.ExternalId;
            cmd.OrderItemTypeId = state.OrderItemTypeId;
            cmd.OrderItemGroupSeqId = state.OrderItemGroupSeqId;
            cmd.IsItemGroupPrimary = state.IsItemGroupPrimary;
            cmd.FromInventoryItemId = state.FromInventoryItemId;
            cmd.IsPromo = state.IsPromo;
            cmd.QuoteId = state.QuoteId;
            cmd.QuoteItemSeqId = state.QuoteItemSeqId;
            cmd.ShoppingListId = state.ShoppingListId;
            cmd.ShoppingListItemSeqId = state.ShoppingListItemSeqId;
            cmd.UnitPrice = state.UnitPrice;
            cmd.UnitListPrice = state.UnitListPrice;
            cmd.UnitAverageCost = state.UnitAverageCost;
            cmd.UnitRecurringPrice = state.UnitRecurringPrice;
            cmd.IsModifiedPrice = state.IsModifiedPrice;
            cmd.RecurringFreqUomId = state.RecurringFreqUomId;
            cmd.ItemDescription = state.ItemDescription;
            cmd.Comments = state.Comments;
            cmd.CorrespondingPoId = state.CorrespondingPoId;
            cmd.SyncStatusId = state.SyncStatusId;
            cmd.EstimatedShipDate = state.EstimatedShipDate;
            cmd.EstimatedDeliveryDate = state.EstimatedDeliveryDate;
            cmd.AutoCancelDate = state.AutoCancelDate;
            cmd.DontCancelSetDate = state.DontCancelSetDate;
            cmd.DontCancelSetBy = state.DontCancelSetBy;
            cmd.ShipBeforeDate = state.ShipBeforeDate;
            cmd.ShipAfterDate = state.ShipAfterDate;
            cmd.CancelBackOrderDate = state.CancelBackOrderDate;
            cmd.OverrideGlAccountId = state.OverrideGlAccountId;
            cmd.Active = ((IOrderItemStateProperties)state).Active;
            
            if (state.ProductId == null) { cmd.IsPropertyProductIdRemoved = true; }
            if (state.ExternalProductId == null) { cmd.IsPropertyExternalProductIdRemoved = true; }
            if (state.Quantity == null) { cmd.IsPropertyQuantityRemoved = true; }
            if (state.CancelQuantity == null) { cmd.IsPropertyCancelQuantityRemoved = true; }
            if (state.SelectedAmount == null) { cmd.IsPropertySelectedAmountRemoved = true; }
            if (state.ExternalId == null) { cmd.IsPropertyExternalIdRemoved = true; }
            if (state.OrderItemTypeId == null) { cmd.IsPropertyOrderItemTypeIdRemoved = true; }
            if (state.OrderItemGroupSeqId == null) { cmd.IsPropertyOrderItemGroupSeqIdRemoved = true; }
            if (state.IsItemGroupPrimary == null) { cmd.IsPropertyIsItemGroupPrimaryRemoved = true; }
            if (state.FromInventoryItemId == null) { cmd.IsPropertyFromInventoryItemIdRemoved = true; }
            if (state.IsPromo == null) { cmd.IsPropertyIsPromoRemoved = true; }
            if (state.QuoteId == null) { cmd.IsPropertyQuoteIdRemoved = true; }
            if (state.QuoteItemSeqId == null) { cmd.IsPropertyQuoteItemSeqIdRemoved = true; }
            if (state.ShoppingListId == null) { cmd.IsPropertyShoppingListIdRemoved = true; }
            if (state.ShoppingListItemSeqId == null) { cmd.IsPropertyShoppingListItemSeqIdRemoved = true; }
            if (state.UnitPrice == null) { cmd.IsPropertyUnitPriceRemoved = true; }
            if (state.UnitListPrice == null) { cmd.IsPropertyUnitListPriceRemoved = true; }
            if (state.UnitAverageCost == null) { cmd.IsPropertyUnitAverageCostRemoved = true; }
            if (state.UnitRecurringPrice == null) { cmd.IsPropertyUnitRecurringPriceRemoved = true; }
            if (state.IsModifiedPrice == null) { cmd.IsPropertyIsModifiedPriceRemoved = true; }
            if (state.RecurringFreqUomId == null) { cmd.IsPropertyRecurringFreqUomIdRemoved = true; }
            if (state.ItemDescription == null) { cmd.IsPropertyItemDescriptionRemoved = true; }
            if (state.Comments == null) { cmd.IsPropertyCommentsRemoved = true; }
            if (state.CorrespondingPoId == null) { cmd.IsPropertyCorrespondingPoIdRemoved = true; }
            if (state.SyncStatusId == null) { cmd.IsPropertySyncStatusIdRemoved = true; }
            if (state.EstimatedShipDate == null) { cmd.IsPropertyEstimatedShipDateRemoved = true; }
            if (state.EstimatedDeliveryDate == null) { cmd.IsPropertyEstimatedDeliveryDateRemoved = true; }
            if (state.AutoCancelDate == null) { cmd.IsPropertyAutoCancelDateRemoved = true; }
            if (state.DontCancelSetDate == null) { cmd.IsPropertyDontCancelSetDateRemoved = true; }
            if (state.DontCancelSetBy == null) { cmd.IsPropertyDontCancelSetByRemoved = true; }
            if (state.ShipBeforeDate == null) { cmd.IsPropertyShipBeforeDateRemoved = true; }
            if (state.ShipAfterDate == null) { cmd.IsPropertyShipAfterDateRemoved = true; }
            if (state.CancelBackOrderDate == null) { cmd.IsPropertyCancelBackOrderDateRemoved = true; }
            if (state.OverrideGlAccountId == null) { cmd.IsPropertyOverrideGlAccountIdRemoved = true; }
            return cmd;
        }

        public static TCreateOrderItem ToCreateOrderItem<TCreateOrderItem>(this IOrderItemState state)
            where TCreateOrderItem : ICreateOrderItem, new()
        {
            var cmd = new TCreateOrderItem();

            cmd.Version = ((IOrderItemStateProperties)state).Version;

            cmd.OrderItemId = state.OrderItemId;
            cmd.ProductId = state.ProductId;
            cmd.ExternalProductId = state.ExternalProductId;
            cmd.Quantity = state.Quantity;
            cmd.CancelQuantity = state.CancelQuantity;
            cmd.SelectedAmount = state.SelectedAmount;
            cmd.ExternalId = state.ExternalId;
            cmd.OrderItemTypeId = state.OrderItemTypeId;
            cmd.OrderItemGroupSeqId = state.OrderItemGroupSeqId;
            cmd.IsItemGroupPrimary = state.IsItemGroupPrimary;
            cmd.FromInventoryItemId = state.FromInventoryItemId;
            cmd.IsPromo = state.IsPromo;
            cmd.QuoteId = state.QuoteId;
            cmd.QuoteItemSeqId = state.QuoteItemSeqId;
            cmd.ShoppingListId = state.ShoppingListId;
            cmd.ShoppingListItemSeqId = state.ShoppingListItemSeqId;
            cmd.UnitPrice = state.UnitPrice;
            cmd.UnitListPrice = state.UnitListPrice;
            cmd.UnitAverageCost = state.UnitAverageCost;
            cmd.UnitRecurringPrice = state.UnitRecurringPrice;
            cmd.IsModifiedPrice = state.IsModifiedPrice;
            cmd.RecurringFreqUomId = state.RecurringFreqUomId;
            cmd.ItemDescription = state.ItemDescription;
            cmd.Comments = state.Comments;
            cmd.CorrespondingPoId = state.CorrespondingPoId;
            cmd.SyncStatusId = state.SyncStatusId;
            cmd.EstimatedShipDate = state.EstimatedShipDate;
            cmd.EstimatedDeliveryDate = state.EstimatedDeliveryDate;
            cmd.AutoCancelDate = state.AutoCancelDate;
            cmd.DontCancelSetDate = state.DontCancelSetDate;
            cmd.DontCancelSetBy = state.DontCancelSetBy;
            cmd.ShipBeforeDate = state.ShipBeforeDate;
            cmd.ShipAfterDate = state.ShipAfterDate;
            cmd.CancelBackOrderDate = state.CancelBackOrderDate;
            cmd.OverrideGlAccountId = state.OverrideGlAccountId;
            cmd.Active = ((IOrderItemStateProperties)state).Active;
            return cmd;
        }
		

	}

}

