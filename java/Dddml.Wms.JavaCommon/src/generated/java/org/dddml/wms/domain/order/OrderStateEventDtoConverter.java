package org.dddml.wms.domain.order;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.partyrole.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class OrderStateEventDtoConverter {

    public OrderStateEventDto toOrderStateEventDto(AbstractOrderEvent stateEvent) {
        if (stateEvent instanceof AbstractOrderEvent.AbstractOrderStateCreated) {
            OrderEvent.OrderStateCreated e = (OrderEvent.OrderStateCreated) stateEvent;
            return toOrderStateCreatedDto(e);
        } else if (stateEvent instanceof AbstractOrderEvent.AbstractOrderStateMergePatched) {
            OrderEvent.OrderStateMergePatched e = (OrderEvent.OrderStateMergePatched) stateEvent;
            return toOrderStateMergePatchedDto(e);
        }

        throw DomainError.named("invalidEventType", String.format("Invalid state event type: %1$s", stateEvent.getEventType()));
    }

    public OrderStateEventDto.OrderStateCreatedDto toOrderStateCreatedDto(OrderEvent.OrderStateCreated e) {
        OrderStateEventDto.OrderStateCreatedDto dto = new OrderStateEventDto.OrderStateCreatedDto();
        dto.setOrderEventId(e.getOrderEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setOrderTypeId(e.getOrderTypeId());
        dto.setOrderName(e.getOrderName());
        dto.setExternalId(e.getExternalId());
        dto.setSalesChannelEnumId(e.getSalesChannelEnumId());
        dto.setOrderDate(e.getOrderDate());
        dto.setPriority(e.getPriority());
        dto.setEntryDate(e.getEntryDate());
        dto.setPickSheetPrintedDate(e.getPickSheetPrintedDate());
        dto.setStatusId(e.getStatusId());
        dto.setCurrencyUom(e.getCurrencyUom());
        dto.setSyncStatusId(e.getSyncStatusId());
        dto.setBillingAccountId(e.getBillingAccountId());
        dto.setOriginFacilityId(e.getOriginFacilityId());
        dto.setWebSiteId(e.getWebSiteId());
        dto.setProductStoreId(e.getProductStoreId());
        dto.setTerminalId(e.getTerminalId());
        dto.setTransactionId(e.getTransactionId());
        dto.setAutoOrderShoppingListId(e.getAutoOrderShoppingListId());
        dto.setNeedsInventoryIssuance(e.getNeedsInventoryIssuance());
        dto.setIsRushOrder(e.getIsRushOrder());
        dto.setInternalCode(e.getInternalCode());
        dto.setRemainingSubTotal(e.getRemainingSubTotal());
        dto.setGrandTotal(e.getGrandTotal());
        dto.setInvoicePerShipment(e.getInvoicePerShipment());
        dto.setActive(e.getActive());
        List<OrderRoleStateEventDto.OrderRoleStateCreatedDto> orderRoleEvents = new ArrayList<>();
        for (OrderRoleEvent.OrderRoleStateCreated ee : e.getOrderRoleEvents()) {
            OrderRoleStateEventDto.OrderRoleStateCreatedDto eeDto = getOrderRoleStateEventDtoConverter().toOrderRoleStateCreatedDto(ee);
            orderRoleEvents.add(eeDto);
        }
        dto.setOrderRoleEvents(orderRoleEvents.toArray(new OrderRoleStateEventDto.OrderRoleStateCreatedDto[0]));

        List<OrderItemStateEventDto.OrderItemStateCreatedDto> orderItemEvents = new ArrayList<>();
        for (OrderItemEvent.OrderItemStateCreated ee : e.getOrderItemEvents()) {
            OrderItemStateEventDto.OrderItemStateCreatedDto eeDto = getOrderItemStateEventDtoConverter().toOrderItemStateCreatedDto(ee);
            orderItemEvents.add(eeDto);
        }
        dto.setOrderItemEvents(orderItemEvents.toArray(new OrderItemStateEventDto.OrderItemStateCreatedDto[0]));

        List<OrderShipGroupStateEventDto.OrderShipGroupStateCreatedDto> orderShipGroupEvents = new ArrayList<>();
        for (OrderShipGroupEvent.OrderShipGroupStateCreated ee : e.getOrderShipGroupEvents()) {
            OrderShipGroupStateEventDto.OrderShipGroupStateCreatedDto eeDto = getOrderShipGroupStateEventDtoConverter().toOrderShipGroupStateCreatedDto(ee);
            orderShipGroupEvents.add(eeDto);
        }
        dto.setOrderShipGroupEvents(orderShipGroupEvents.toArray(new OrderShipGroupStateEventDto.OrderShipGroupStateCreatedDto[0]));

        return dto;
    }

    public OrderStateEventDto.OrderStateMergePatchedDto toOrderStateMergePatchedDto(OrderEvent.OrderStateMergePatched e) {
        OrderStateEventDto.OrderStateMergePatchedDto dto = new OrderStateEventDto.OrderStateMergePatchedDto();
        dto.setOrderEventId(e.getOrderEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setOrderTypeId(e.getOrderTypeId());
        dto.setOrderName(e.getOrderName());
        dto.setExternalId(e.getExternalId());
        dto.setSalesChannelEnumId(e.getSalesChannelEnumId());
        dto.setOrderDate(e.getOrderDate());
        dto.setPriority(e.getPriority());
        dto.setEntryDate(e.getEntryDate());
        dto.setPickSheetPrintedDate(e.getPickSheetPrintedDate());
        dto.setStatusId(e.getStatusId());
        dto.setCurrencyUom(e.getCurrencyUom());
        dto.setSyncStatusId(e.getSyncStatusId());
        dto.setBillingAccountId(e.getBillingAccountId());
        dto.setOriginFacilityId(e.getOriginFacilityId());
        dto.setWebSiteId(e.getWebSiteId());
        dto.setProductStoreId(e.getProductStoreId());
        dto.setTerminalId(e.getTerminalId());
        dto.setTransactionId(e.getTransactionId());
        dto.setAutoOrderShoppingListId(e.getAutoOrderShoppingListId());
        dto.setNeedsInventoryIssuance(e.getNeedsInventoryIssuance());
        dto.setIsRushOrder(e.getIsRushOrder());
        dto.setInternalCode(e.getInternalCode());
        dto.setRemainingSubTotal(e.getRemainingSubTotal());
        dto.setGrandTotal(e.getGrandTotal());
        dto.setInvoicePerShipment(e.getInvoicePerShipment());
        dto.setActive(e.getActive());
        dto.setIsPropertyOrderTypeIdRemoved(e.getIsPropertyOrderTypeIdRemoved());
        dto.setIsPropertyOrderNameRemoved(e.getIsPropertyOrderNameRemoved());
        dto.setIsPropertyExternalIdRemoved(e.getIsPropertyExternalIdRemoved());
        dto.setIsPropertySalesChannelEnumIdRemoved(e.getIsPropertySalesChannelEnumIdRemoved());
        dto.setIsPropertyOrderDateRemoved(e.getIsPropertyOrderDateRemoved());
        dto.setIsPropertyPriorityRemoved(e.getIsPropertyPriorityRemoved());
        dto.setIsPropertyEntryDateRemoved(e.getIsPropertyEntryDateRemoved());
        dto.setIsPropertyPickSheetPrintedDateRemoved(e.getIsPropertyPickSheetPrintedDateRemoved());
        dto.setIsPropertyStatusIdRemoved(e.getIsPropertyStatusIdRemoved());
        dto.setIsPropertyCurrencyUomRemoved(e.getIsPropertyCurrencyUomRemoved());
        dto.setIsPropertySyncStatusIdRemoved(e.getIsPropertySyncStatusIdRemoved());
        dto.setIsPropertyBillingAccountIdRemoved(e.getIsPropertyBillingAccountIdRemoved());
        dto.setIsPropertyOriginFacilityIdRemoved(e.getIsPropertyOriginFacilityIdRemoved());
        dto.setIsPropertyWebSiteIdRemoved(e.getIsPropertyWebSiteIdRemoved());
        dto.setIsPropertyProductStoreIdRemoved(e.getIsPropertyProductStoreIdRemoved());
        dto.setIsPropertyTerminalIdRemoved(e.getIsPropertyTerminalIdRemoved());
        dto.setIsPropertyTransactionIdRemoved(e.getIsPropertyTransactionIdRemoved());
        dto.setIsPropertyAutoOrderShoppingListIdRemoved(e.getIsPropertyAutoOrderShoppingListIdRemoved());
        dto.setIsPropertyNeedsInventoryIssuanceRemoved(e.getIsPropertyNeedsInventoryIssuanceRemoved());
        dto.setIsPropertyIsRushOrderRemoved(e.getIsPropertyIsRushOrderRemoved());
        dto.setIsPropertyInternalCodeRemoved(e.getIsPropertyInternalCodeRemoved());
        dto.setIsPropertyRemainingSubTotalRemoved(e.getIsPropertyRemainingSubTotalRemoved());
        dto.setIsPropertyGrandTotalRemoved(e.getIsPropertyGrandTotalRemoved());
        dto.setIsPropertyInvoicePerShipmentRemoved(e.getIsPropertyInvoicePerShipmentRemoved());
        dto.setIsPropertyActiveRemoved(e.getIsPropertyActiveRemoved());
        List<OrderRoleStateEventDto> orderRoleEvents = new ArrayList<>();
        for (OrderRoleEvent ee : e.getOrderRoleEvents()) {
            OrderRoleStateEventDto eeDto = getOrderRoleStateEventDtoConverter().toOrderRoleStateEventDto((AbstractOrderRoleEvent) ee);
            orderRoleEvents.add(eeDto);
        }
        dto.setOrderRoleEvents(orderRoleEvents.toArray(new OrderRoleStateEventDto[0]));

        List<OrderItemStateEventDto> orderItemEvents = new ArrayList<>();
        for (OrderItemEvent ee : e.getOrderItemEvents()) {
            OrderItemStateEventDto eeDto = getOrderItemStateEventDtoConverter().toOrderItemStateEventDto((AbstractOrderItemEvent) ee);
            orderItemEvents.add(eeDto);
        }
        dto.setOrderItemEvents(orderItemEvents.toArray(new OrderItemStateEventDto[0]));

        List<OrderShipGroupStateEventDto> orderShipGroupEvents = new ArrayList<>();
        for (OrderShipGroupEvent ee : e.getOrderShipGroupEvents()) {
            OrderShipGroupStateEventDto eeDto = getOrderShipGroupStateEventDtoConverter().toOrderShipGroupStateEventDto((AbstractOrderShipGroupEvent) ee);
            orderShipGroupEvents.add(eeDto);
        }
        dto.setOrderShipGroupEvents(orderShipGroupEvents.toArray(new OrderShipGroupStateEventDto[0]));

        return dto;
    }


    protected OrderRoleStateEventDtoConverter getOrderRoleStateEventDtoConverter() {
        return new OrderRoleStateEventDtoConverter();
    }

    protected OrderItemStateEventDtoConverter getOrderItemStateEventDtoConverter() {
        return new OrderItemStateEventDtoConverter();
    }

    protected OrderShipGroupStateEventDtoConverter getOrderShipGroupStateEventDtoConverter() {
        return new OrderShipGroupStateEventDtoConverter();
    }

}

