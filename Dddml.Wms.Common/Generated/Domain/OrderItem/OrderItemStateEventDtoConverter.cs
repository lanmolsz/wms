﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItem;

namespace Dddml.Wms.Domain.OrderItem
{

    public class OrderItemStateEventDtoConverter
    {
        public virtual OrderItemStateCreatedOrMergePatchedOrDeletedDto ToOrderItemStateEventDto(IOrderItemStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IOrderItemStateCreated)stateEvent;
                return ToOrderItemStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IOrderItemStateMergePatched)stateEvent;
                return ToOrderItemStateMergePatchedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual OrderItemStateCreatedDto ToOrderItemStateCreatedDto(IOrderItemStateCreated e)
        {
            var dto = new OrderItemStateCreatedDto();
            dto.StateEventId = new OrderItemStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ProductId = e.ProductId;
            dto.ExternalProductId = e.ExternalProductId;
            dto.Quantity = e.Quantity;
            dto.CancelQuantity = e.CancelQuantity;
            dto.SelectedAmount = e.SelectedAmount;
            dto.ExternalId = e.ExternalId;
            dto.OrderItemTypeId = e.OrderItemTypeId;
            dto.OrderItemGroupSeqId = e.OrderItemGroupSeqId;
            dto.IsItemGroupPrimary = e.IsItemGroupPrimary;
            dto.FromInventoryItemId = e.FromInventoryItemId;
            dto.IsPromo = e.IsPromo;
            dto.QuoteId = e.QuoteId;
            dto.QuoteItemSeqId = e.QuoteItemSeqId;
            dto.ShoppingListId = e.ShoppingListId;
            dto.ShoppingListItemSeqId = e.ShoppingListItemSeqId;
            dto.UnitPrice = e.UnitPrice;
            dto.UnitListPrice = e.UnitListPrice;
            dto.UnitAverageCost = e.UnitAverageCost;
            dto.UnitRecurringPrice = e.UnitRecurringPrice;
            dto.IsModifiedPrice = e.IsModifiedPrice;
            dto.RecurringFreqUomId = e.RecurringFreqUomId;
            dto.ItemDescription = e.ItemDescription;
            dto.Comments = e.Comments;
            dto.CorrespondingPoId = e.CorrespondingPoId;
            dto.SyncStatusId = e.SyncStatusId;
            dto.EstimatedShipDate = e.EstimatedShipDate;
            dto.EstimatedDeliveryDate = e.EstimatedDeliveryDate;
            dto.AutoCancelDate = e.AutoCancelDate;
            dto.DontCancelSetDate = e.DontCancelSetDate;
            dto.DontCancelSetBy = e.DontCancelSetBy;
            dto.ShipBeforeDate = e.ShipBeforeDate;
            dto.ShipAfterDate = e.ShipAfterDate;
            dto.CancelBackOrderDate = e.CancelBackOrderDate;
            dto.OverrideGlAccountId = e.OverrideGlAccountId;
            dto.Active = e.Active;
            return dto;
        }

        public virtual OrderItemStateMergePatchedDto ToOrderItemStateMergePatchedDto(IOrderItemStateMergePatched e)
        {
            var dto = new OrderItemStateMergePatchedDto();
            dto.StateEventId = new OrderItemStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ProductId = e.ProductId;
            dto.ExternalProductId = e.ExternalProductId;
            dto.Quantity = e.Quantity;
            dto.CancelQuantity = e.CancelQuantity;
            dto.SelectedAmount = e.SelectedAmount;
            dto.ExternalId = e.ExternalId;
            dto.OrderItemTypeId = e.OrderItemTypeId;
            dto.OrderItemGroupSeqId = e.OrderItemGroupSeqId;
            dto.IsItemGroupPrimary = e.IsItemGroupPrimary;
            dto.FromInventoryItemId = e.FromInventoryItemId;
            dto.IsPromo = e.IsPromo;
            dto.QuoteId = e.QuoteId;
            dto.QuoteItemSeqId = e.QuoteItemSeqId;
            dto.ShoppingListId = e.ShoppingListId;
            dto.ShoppingListItemSeqId = e.ShoppingListItemSeqId;
            dto.UnitPrice = e.UnitPrice;
            dto.UnitListPrice = e.UnitListPrice;
            dto.UnitAverageCost = e.UnitAverageCost;
            dto.UnitRecurringPrice = e.UnitRecurringPrice;
            dto.IsModifiedPrice = e.IsModifiedPrice;
            dto.RecurringFreqUomId = e.RecurringFreqUomId;
            dto.ItemDescription = e.ItemDescription;
            dto.Comments = e.Comments;
            dto.CorrespondingPoId = e.CorrespondingPoId;
            dto.SyncStatusId = e.SyncStatusId;
            dto.EstimatedShipDate = e.EstimatedShipDate;
            dto.EstimatedDeliveryDate = e.EstimatedDeliveryDate;
            dto.AutoCancelDate = e.AutoCancelDate;
            dto.DontCancelSetDate = e.DontCancelSetDate;
            dto.DontCancelSetBy = e.DontCancelSetBy;
            dto.ShipBeforeDate = e.ShipBeforeDate;
            dto.ShipAfterDate = e.ShipAfterDate;
            dto.CancelBackOrderDate = e.CancelBackOrderDate;
            dto.OverrideGlAccountId = e.OverrideGlAccountId;
            dto.Active = e.Active;
            dto.IsPropertyProductIdRemoved = e.IsPropertyProductIdRemoved;
            dto.IsPropertyExternalProductIdRemoved = e.IsPropertyExternalProductIdRemoved;
            dto.IsPropertyQuantityRemoved = e.IsPropertyQuantityRemoved;
            dto.IsPropertyCancelQuantityRemoved = e.IsPropertyCancelQuantityRemoved;
            dto.IsPropertySelectedAmountRemoved = e.IsPropertySelectedAmountRemoved;
            dto.IsPropertyExternalIdRemoved = e.IsPropertyExternalIdRemoved;
            dto.IsPropertyOrderItemTypeIdRemoved = e.IsPropertyOrderItemTypeIdRemoved;
            dto.IsPropertyOrderItemGroupSeqIdRemoved = e.IsPropertyOrderItemGroupSeqIdRemoved;
            dto.IsPropertyIsItemGroupPrimaryRemoved = e.IsPropertyIsItemGroupPrimaryRemoved;
            dto.IsPropertyFromInventoryItemIdRemoved = e.IsPropertyFromInventoryItemIdRemoved;
            dto.IsPropertyIsPromoRemoved = e.IsPropertyIsPromoRemoved;
            dto.IsPropertyQuoteIdRemoved = e.IsPropertyQuoteIdRemoved;
            dto.IsPropertyQuoteItemSeqIdRemoved = e.IsPropertyQuoteItemSeqIdRemoved;
            dto.IsPropertyShoppingListIdRemoved = e.IsPropertyShoppingListIdRemoved;
            dto.IsPropertyShoppingListItemSeqIdRemoved = e.IsPropertyShoppingListItemSeqIdRemoved;
            dto.IsPropertyUnitPriceRemoved = e.IsPropertyUnitPriceRemoved;
            dto.IsPropertyUnitListPriceRemoved = e.IsPropertyUnitListPriceRemoved;
            dto.IsPropertyUnitAverageCostRemoved = e.IsPropertyUnitAverageCostRemoved;
            dto.IsPropertyUnitRecurringPriceRemoved = e.IsPropertyUnitRecurringPriceRemoved;
            dto.IsPropertyIsModifiedPriceRemoved = e.IsPropertyIsModifiedPriceRemoved;
            dto.IsPropertyRecurringFreqUomIdRemoved = e.IsPropertyRecurringFreqUomIdRemoved;
            dto.IsPropertyItemDescriptionRemoved = e.IsPropertyItemDescriptionRemoved;
            dto.IsPropertyCommentsRemoved = e.IsPropertyCommentsRemoved;
            dto.IsPropertyCorrespondingPoIdRemoved = e.IsPropertyCorrespondingPoIdRemoved;
            dto.IsPropertySyncStatusIdRemoved = e.IsPropertySyncStatusIdRemoved;
            dto.IsPropertyEstimatedShipDateRemoved = e.IsPropertyEstimatedShipDateRemoved;
            dto.IsPropertyEstimatedDeliveryDateRemoved = e.IsPropertyEstimatedDeliveryDateRemoved;
            dto.IsPropertyAutoCancelDateRemoved = e.IsPropertyAutoCancelDateRemoved;
            dto.IsPropertyDontCancelSetDateRemoved = e.IsPropertyDontCancelSetDateRemoved;
            dto.IsPropertyDontCancelSetByRemoved = e.IsPropertyDontCancelSetByRemoved;
            dto.IsPropertyShipBeforeDateRemoved = e.IsPropertyShipBeforeDateRemoved;
            dto.IsPropertyShipAfterDateRemoved = e.IsPropertyShipAfterDateRemoved;
            dto.IsPropertyCancelBackOrderDateRemoved = e.IsPropertyCancelBackOrderDateRemoved;
            dto.IsPropertyOverrideGlAccountIdRemoved = e.IsPropertyOverrideGlAccountIdRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }



    }


}

