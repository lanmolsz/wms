package org.dddml.wms.domain.orderitemmvo;

import java.util.*;
import org.dddml.wms.domain.order.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class OrderItemMvoStateEventDtoConverter {

    public OrderItemMvoStateEventDto toOrderItemMvoStateEventDto(AbstractOrderItemMvoStateEvent stateEvent) {
        if (stateEvent instanceof AbstractOrderItemMvoStateEvent.AbstractOrderItemMvoStateCreated) {
            OrderItemMvoStateEvent.OrderItemMvoStateCreated e = (OrderItemMvoStateEvent.OrderItemMvoStateCreated) stateEvent;
            return toOrderItemMvoStateCreatedDto(e);
        } else if (stateEvent instanceof AbstractOrderItemMvoStateEvent.AbstractOrderItemMvoStateMergePatched) {
            OrderItemMvoStateEvent.OrderItemMvoStateMergePatched e = (OrderItemMvoStateEvent.OrderItemMvoStateMergePatched) stateEvent;
            return toOrderItemMvoStateMergePatchedDto(e);
        }

        throw DomainError.named("invalidStateEventType", String.format("Invalid state event type: %1$s", stateEvent.getStateEventType()));
    }

    public OrderItemMvoStateEventDto.OrderItemMvoStateCreatedDto toOrderItemMvoStateCreatedDto(OrderItemMvoStateEvent.OrderItemMvoStateCreated e) {
        OrderItemMvoStateEventDto.OrderItemMvoStateCreatedDto dto = new OrderItemMvoStateEventDto.OrderItemMvoStateCreatedDto();
        dto.setStateEventId(e.getStateEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setProductId(e.getProductId());
        dto.setExternalProductId(e.getExternalProductId());
        dto.setQuantity(e.getQuantity());
        dto.setCancelQuantity(e.getCancelQuantity());
        dto.setSelectedAmount(e.getSelectedAmount());
        dto.setExternalId(e.getExternalId());
        dto.setOrderItemTypeId(e.getOrderItemTypeId());
        dto.setOrderItemGroupSeqId(e.getOrderItemGroupSeqId());
        dto.setIsItemGroupPrimary(e.getIsItemGroupPrimary());
        dto.setFromInventoryItemId(e.getFromInventoryItemId());
        dto.setIsPromo(e.getIsPromo());
        dto.setQuoteId(e.getQuoteId());
        dto.setQuoteItemSeqId(e.getQuoteItemSeqId());
        dto.setShoppingListId(e.getShoppingListId());
        dto.setShoppingListItemSeqId(e.getShoppingListItemSeqId());
        dto.setUnitPrice(e.getUnitPrice());
        dto.setUnitListPrice(e.getUnitListPrice());
        dto.setUnitAverageCost(e.getUnitAverageCost());
        dto.setUnitRecurringPrice(e.getUnitRecurringPrice());
        dto.setIsModifiedPrice(e.getIsModifiedPrice());
        dto.setRecurringFreqUomId(e.getRecurringFreqUomId());
        dto.setItemDescription(e.getItemDescription());
        dto.setComments(e.getComments());
        dto.setCorrespondingPoId(e.getCorrespondingPoId());
        dto.setStatusId(e.getStatusId());
        dto.setSyncStatusId(e.getSyncStatusId());
        dto.setEstimatedShipDate(e.getEstimatedShipDate());
        dto.setEstimatedDeliveryDate(e.getEstimatedDeliveryDate());
        dto.setAutoCancelDate(e.getAutoCancelDate());
        dto.setDontCancelSetDate(e.getDontCancelSetDate());
        dto.setDontCancelSetBy(e.getDontCancelSetBy());
        dto.setShipBeforeDate(e.getShipBeforeDate());
        dto.setShipAfterDate(e.getShipAfterDate());
        dto.setCancelBackOrderDate(e.getCancelBackOrderDate());
        dto.setOverrideGlAccountId(e.getOverrideGlAccountId());
        dto.setVersion(e.getVersion());
        dto.setActive(e.getActive());
        dto.setOrderOrderTypeId(e.getOrderOrderTypeId());
        dto.setOrderOrderName(e.getOrderOrderName());
        dto.setOrderExternalId(e.getOrderExternalId());
        dto.setOrderSalesChannelEnumId(e.getOrderSalesChannelEnumId());
        dto.setOrderOrderDate(e.getOrderOrderDate());
        dto.setOrderPriority(e.getOrderPriority());
        dto.setOrderEntryDate(e.getOrderEntryDate());
        dto.setOrderPickSheetPrintedDate(e.getOrderPickSheetPrintedDate());
        dto.setOrderStatusId(e.getOrderStatusId());
        dto.setOrderCurrencyUom(e.getOrderCurrencyUom());
        dto.setOrderSyncStatusId(e.getOrderSyncStatusId());
        dto.setOrderBillingAccountId(e.getOrderBillingAccountId());
        dto.setOrderOriginFacilityId(e.getOrderOriginFacilityId());
        dto.setOrderWebSiteId(e.getOrderWebSiteId());
        dto.setOrderProductStoreId(e.getOrderProductStoreId());
        dto.setOrderTerminalId(e.getOrderTerminalId());
        dto.setOrderTransactionId(e.getOrderTransactionId());
        dto.setOrderAutoOrderShoppingListId(e.getOrderAutoOrderShoppingListId());
        dto.setOrderNeedsInventoryIssuance(e.getOrderNeedsInventoryIssuance());
        dto.setOrderIsRushOrder(e.getOrderIsRushOrder());
        dto.setOrderInternalCode(e.getOrderInternalCode());
        dto.setOrderRemainingSubTotal(e.getOrderRemainingSubTotal());
        dto.setOrderGrandTotal(e.getOrderGrandTotal());
        dto.setOrderInvoicePerShipment(e.getOrderInvoicePerShipment());
        dto.setOrderCreatedBy(e.getOrderCreatedBy());
        dto.setOrderCreatedAt(e.getOrderCreatedAt());
        dto.setOrderUpdatedBy(e.getOrderUpdatedBy());
        dto.setOrderUpdatedAt(e.getOrderUpdatedAt());
        dto.setOrderActive(e.getOrderActive());
        return dto;
    }

    public OrderItemMvoStateEventDto.OrderItemMvoStateMergePatchedDto toOrderItemMvoStateMergePatchedDto(OrderItemMvoStateEvent.OrderItemMvoStateMergePatched e) {
        OrderItemMvoStateEventDto.OrderItemMvoStateMergePatchedDto dto = new OrderItemMvoStateEventDto.OrderItemMvoStateMergePatchedDto();
        dto.setStateEventId(e.getStateEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setProductId(e.getProductId());
        dto.setExternalProductId(e.getExternalProductId());
        dto.setQuantity(e.getQuantity());
        dto.setCancelQuantity(e.getCancelQuantity());
        dto.setSelectedAmount(e.getSelectedAmount());
        dto.setExternalId(e.getExternalId());
        dto.setOrderItemTypeId(e.getOrderItemTypeId());
        dto.setOrderItemGroupSeqId(e.getOrderItemGroupSeqId());
        dto.setIsItemGroupPrimary(e.getIsItemGroupPrimary());
        dto.setFromInventoryItemId(e.getFromInventoryItemId());
        dto.setIsPromo(e.getIsPromo());
        dto.setQuoteId(e.getQuoteId());
        dto.setQuoteItemSeqId(e.getQuoteItemSeqId());
        dto.setShoppingListId(e.getShoppingListId());
        dto.setShoppingListItemSeqId(e.getShoppingListItemSeqId());
        dto.setUnitPrice(e.getUnitPrice());
        dto.setUnitListPrice(e.getUnitListPrice());
        dto.setUnitAverageCost(e.getUnitAverageCost());
        dto.setUnitRecurringPrice(e.getUnitRecurringPrice());
        dto.setIsModifiedPrice(e.getIsModifiedPrice());
        dto.setRecurringFreqUomId(e.getRecurringFreqUomId());
        dto.setItemDescription(e.getItemDescription());
        dto.setComments(e.getComments());
        dto.setCorrespondingPoId(e.getCorrespondingPoId());
        dto.setStatusId(e.getStatusId());
        dto.setSyncStatusId(e.getSyncStatusId());
        dto.setEstimatedShipDate(e.getEstimatedShipDate());
        dto.setEstimatedDeliveryDate(e.getEstimatedDeliveryDate());
        dto.setAutoCancelDate(e.getAutoCancelDate());
        dto.setDontCancelSetDate(e.getDontCancelSetDate());
        dto.setDontCancelSetBy(e.getDontCancelSetBy());
        dto.setShipBeforeDate(e.getShipBeforeDate());
        dto.setShipAfterDate(e.getShipAfterDate());
        dto.setCancelBackOrderDate(e.getCancelBackOrderDate());
        dto.setOverrideGlAccountId(e.getOverrideGlAccountId());
        dto.setVersion(e.getVersion());
        dto.setActive(e.getActive());
        dto.setOrderOrderTypeId(e.getOrderOrderTypeId());
        dto.setOrderOrderName(e.getOrderOrderName());
        dto.setOrderExternalId(e.getOrderExternalId());
        dto.setOrderSalesChannelEnumId(e.getOrderSalesChannelEnumId());
        dto.setOrderOrderDate(e.getOrderOrderDate());
        dto.setOrderPriority(e.getOrderPriority());
        dto.setOrderEntryDate(e.getOrderEntryDate());
        dto.setOrderPickSheetPrintedDate(e.getOrderPickSheetPrintedDate());
        dto.setOrderStatusId(e.getOrderStatusId());
        dto.setOrderCurrencyUom(e.getOrderCurrencyUom());
        dto.setOrderSyncStatusId(e.getOrderSyncStatusId());
        dto.setOrderBillingAccountId(e.getOrderBillingAccountId());
        dto.setOrderOriginFacilityId(e.getOrderOriginFacilityId());
        dto.setOrderWebSiteId(e.getOrderWebSiteId());
        dto.setOrderProductStoreId(e.getOrderProductStoreId());
        dto.setOrderTerminalId(e.getOrderTerminalId());
        dto.setOrderTransactionId(e.getOrderTransactionId());
        dto.setOrderAutoOrderShoppingListId(e.getOrderAutoOrderShoppingListId());
        dto.setOrderNeedsInventoryIssuance(e.getOrderNeedsInventoryIssuance());
        dto.setOrderIsRushOrder(e.getOrderIsRushOrder());
        dto.setOrderInternalCode(e.getOrderInternalCode());
        dto.setOrderRemainingSubTotal(e.getOrderRemainingSubTotal());
        dto.setOrderGrandTotal(e.getOrderGrandTotal());
        dto.setOrderInvoicePerShipment(e.getOrderInvoicePerShipment());
        dto.setOrderCreatedBy(e.getOrderCreatedBy());
        dto.setOrderCreatedAt(e.getOrderCreatedAt());
        dto.setOrderUpdatedBy(e.getOrderUpdatedBy());
        dto.setOrderUpdatedAt(e.getOrderUpdatedAt());
        dto.setOrderActive(e.getOrderActive());
        dto.setIsPropertyProductIdRemoved(e.getIsPropertyProductIdRemoved());
        dto.setIsPropertyExternalProductIdRemoved(e.getIsPropertyExternalProductIdRemoved());
        dto.setIsPropertyQuantityRemoved(e.getIsPropertyQuantityRemoved());
        dto.setIsPropertyCancelQuantityRemoved(e.getIsPropertyCancelQuantityRemoved());
        dto.setIsPropertySelectedAmountRemoved(e.getIsPropertySelectedAmountRemoved());
        dto.setIsPropertyExternalIdRemoved(e.getIsPropertyExternalIdRemoved());
        dto.setIsPropertyOrderItemTypeIdRemoved(e.getIsPropertyOrderItemTypeIdRemoved());
        dto.setIsPropertyOrderItemGroupSeqIdRemoved(e.getIsPropertyOrderItemGroupSeqIdRemoved());
        dto.setIsPropertyIsItemGroupPrimaryRemoved(e.getIsPropertyIsItemGroupPrimaryRemoved());
        dto.setIsPropertyFromInventoryItemIdRemoved(e.getIsPropertyFromInventoryItemIdRemoved());
        dto.setIsPropertyIsPromoRemoved(e.getIsPropertyIsPromoRemoved());
        dto.setIsPropertyQuoteIdRemoved(e.getIsPropertyQuoteIdRemoved());
        dto.setIsPropertyQuoteItemSeqIdRemoved(e.getIsPropertyQuoteItemSeqIdRemoved());
        dto.setIsPropertyShoppingListIdRemoved(e.getIsPropertyShoppingListIdRemoved());
        dto.setIsPropertyShoppingListItemSeqIdRemoved(e.getIsPropertyShoppingListItemSeqIdRemoved());
        dto.setIsPropertyUnitPriceRemoved(e.getIsPropertyUnitPriceRemoved());
        dto.setIsPropertyUnitListPriceRemoved(e.getIsPropertyUnitListPriceRemoved());
        dto.setIsPropertyUnitAverageCostRemoved(e.getIsPropertyUnitAverageCostRemoved());
        dto.setIsPropertyUnitRecurringPriceRemoved(e.getIsPropertyUnitRecurringPriceRemoved());
        dto.setIsPropertyIsModifiedPriceRemoved(e.getIsPropertyIsModifiedPriceRemoved());
        dto.setIsPropertyRecurringFreqUomIdRemoved(e.getIsPropertyRecurringFreqUomIdRemoved());
        dto.setIsPropertyItemDescriptionRemoved(e.getIsPropertyItemDescriptionRemoved());
        dto.setIsPropertyCommentsRemoved(e.getIsPropertyCommentsRemoved());
        dto.setIsPropertyCorrespondingPoIdRemoved(e.getIsPropertyCorrespondingPoIdRemoved());
        dto.setIsPropertyStatusIdRemoved(e.getIsPropertyStatusIdRemoved());
        dto.setIsPropertySyncStatusIdRemoved(e.getIsPropertySyncStatusIdRemoved());
        dto.setIsPropertyEstimatedShipDateRemoved(e.getIsPropertyEstimatedShipDateRemoved());
        dto.setIsPropertyEstimatedDeliveryDateRemoved(e.getIsPropertyEstimatedDeliveryDateRemoved());
        dto.setIsPropertyAutoCancelDateRemoved(e.getIsPropertyAutoCancelDateRemoved());
        dto.setIsPropertyDontCancelSetDateRemoved(e.getIsPropertyDontCancelSetDateRemoved());
        dto.setIsPropertyDontCancelSetByRemoved(e.getIsPropertyDontCancelSetByRemoved());
        dto.setIsPropertyShipBeforeDateRemoved(e.getIsPropertyShipBeforeDateRemoved());
        dto.setIsPropertyShipAfterDateRemoved(e.getIsPropertyShipAfterDateRemoved());
        dto.setIsPropertyCancelBackOrderDateRemoved(e.getIsPropertyCancelBackOrderDateRemoved());
        dto.setIsPropertyOverrideGlAccountIdRemoved(e.getIsPropertyOverrideGlAccountIdRemoved());
        dto.setIsPropertyVersionRemoved(e.getIsPropertyVersionRemoved());
        dto.setIsPropertyActiveRemoved(e.getIsPropertyActiveRemoved());
        dto.setIsPropertyOrderOrderTypeIdRemoved(e.getIsPropertyOrderOrderTypeIdRemoved());
        dto.setIsPropertyOrderOrderNameRemoved(e.getIsPropertyOrderOrderNameRemoved());
        dto.setIsPropertyOrderExternalIdRemoved(e.getIsPropertyOrderExternalIdRemoved());
        dto.setIsPropertyOrderSalesChannelEnumIdRemoved(e.getIsPropertyOrderSalesChannelEnumIdRemoved());
        dto.setIsPropertyOrderOrderDateRemoved(e.getIsPropertyOrderOrderDateRemoved());
        dto.setIsPropertyOrderPriorityRemoved(e.getIsPropertyOrderPriorityRemoved());
        dto.setIsPropertyOrderEntryDateRemoved(e.getIsPropertyOrderEntryDateRemoved());
        dto.setIsPropertyOrderPickSheetPrintedDateRemoved(e.getIsPropertyOrderPickSheetPrintedDateRemoved());
        dto.setIsPropertyOrderStatusIdRemoved(e.getIsPropertyOrderStatusIdRemoved());
        dto.setIsPropertyOrderCurrencyUomRemoved(e.getIsPropertyOrderCurrencyUomRemoved());
        dto.setIsPropertyOrderSyncStatusIdRemoved(e.getIsPropertyOrderSyncStatusIdRemoved());
        dto.setIsPropertyOrderBillingAccountIdRemoved(e.getIsPropertyOrderBillingAccountIdRemoved());
        dto.setIsPropertyOrderOriginFacilityIdRemoved(e.getIsPropertyOrderOriginFacilityIdRemoved());
        dto.setIsPropertyOrderWebSiteIdRemoved(e.getIsPropertyOrderWebSiteIdRemoved());
        dto.setIsPropertyOrderProductStoreIdRemoved(e.getIsPropertyOrderProductStoreIdRemoved());
        dto.setIsPropertyOrderTerminalIdRemoved(e.getIsPropertyOrderTerminalIdRemoved());
        dto.setIsPropertyOrderTransactionIdRemoved(e.getIsPropertyOrderTransactionIdRemoved());
        dto.setIsPropertyOrderAutoOrderShoppingListIdRemoved(e.getIsPropertyOrderAutoOrderShoppingListIdRemoved());
        dto.setIsPropertyOrderNeedsInventoryIssuanceRemoved(e.getIsPropertyOrderNeedsInventoryIssuanceRemoved());
        dto.setIsPropertyOrderIsRushOrderRemoved(e.getIsPropertyOrderIsRushOrderRemoved());
        dto.setIsPropertyOrderInternalCodeRemoved(e.getIsPropertyOrderInternalCodeRemoved());
        dto.setIsPropertyOrderRemainingSubTotalRemoved(e.getIsPropertyOrderRemainingSubTotalRemoved());
        dto.setIsPropertyOrderGrandTotalRemoved(e.getIsPropertyOrderGrandTotalRemoved());
        dto.setIsPropertyOrderInvoicePerShipmentRemoved(e.getIsPropertyOrderInvoicePerShipmentRemoved());
        dto.setIsPropertyOrderCreatedByRemoved(e.getIsPropertyOrderCreatedByRemoved());
        dto.setIsPropertyOrderCreatedAtRemoved(e.getIsPropertyOrderCreatedAtRemoved());
        dto.setIsPropertyOrderUpdatedByRemoved(e.getIsPropertyOrderUpdatedByRemoved());
        dto.setIsPropertyOrderUpdatedAtRemoved(e.getIsPropertyOrderUpdatedAtRemoved());
        dto.setIsPropertyOrderActiveRemoved(e.getIsPropertyOrderActiveRemoved());
        return dto;
    }


}

