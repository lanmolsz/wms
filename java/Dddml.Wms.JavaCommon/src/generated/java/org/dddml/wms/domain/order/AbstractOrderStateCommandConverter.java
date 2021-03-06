package org.dddml.wms.domain.order;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.partyrole.*;
import org.dddml.wms.domain.*;

public abstract class AbstractOrderStateCommandConverter<TCreateOrder extends OrderCommand.CreateOrder, TMergePatchOrder extends OrderCommand.MergePatchOrder, TDeleteOrder extends OrderCommand.DeleteOrder, TCreateOrderRole extends OrderRoleCommand.CreateOrderRole, TMergePatchOrderRole extends OrderRoleCommand.MergePatchOrderRole, TRemoveOrderRole extends OrderRoleCommand.RemoveOrderRole, TCreateOrderItem extends OrderItemCommand.CreateOrderItem, TMergePatchOrderItem extends OrderItemCommand.MergePatchOrderItem, TRemoveOrderItem extends OrderItemCommand.RemoveOrderItem, TCreateOrderShipGroup extends OrderShipGroupCommand.CreateOrderShipGroup, TMergePatchOrderShipGroup extends OrderShipGroupCommand.MergePatchOrderShipGroup, TRemoveOrderShipGroup extends OrderShipGroupCommand.RemoveOrderShipGroup, TCreateOrderItemShipGroupAssociation extends OrderItemShipGroupAssociationCommand.CreateOrderItemShipGroupAssociation, TMergePatchOrderItemShipGroupAssociation extends OrderItemShipGroupAssociationCommand.MergePatchOrderItemShipGroupAssociation, TRemoveOrderItemShipGroupAssociation extends OrderItemShipGroupAssociationCommand.RemoveOrderItemShipGroupAssociation>
{
    public OrderCommand toCreateOrMergePatchOrder(OrderState state)
    {
        //where TCreateOrder : ICreateOrder, new()
        //where TMergePatchOrder : IMergePatchOrder, new()
        boolean bUnsaved = state.isStateUnsaved();
        if (bUnsaved)
        {
            return toCreateOrder(state);
        }
        else 
        {
            return toMergePatchOrder(state);
        }
    }

    public TDeleteOrder toDeleteOrder(OrderState state) //where TDeleteOrder : IDeleteOrder, new()
    {
        TDeleteOrder cmd = newDeleteOrder();
        cmd.setOrderId(state.getOrderId());
        cmd.setVersion(state.getVersion());

        return cmd;
    }

    public TMergePatchOrder toMergePatchOrder(OrderState state) //where TMergePatchOrder : IMergePatchOrder, new()
    {
        TMergePatchOrder cmd = newMergePatchOrder();

        cmd.setVersion(state.getVersion());

        cmd.setOrderId(state.getOrderId());
        cmd.setOrderTypeId(state.getOrderTypeId());
        cmd.setOrderName(state.getOrderName());
        cmd.setExternalId(state.getExternalId());
        cmd.setSalesChannelEnumId(state.getSalesChannelEnumId());
        cmd.setOrderDate(state.getOrderDate());
        cmd.setPriority(state.getPriority());
        cmd.setEntryDate(state.getEntryDate());
        cmd.setPickSheetPrintedDate(state.getPickSheetPrintedDate());
        cmd.setStatusId(state.getStatusId());
        cmd.setCurrencyUom(state.getCurrencyUom());
        cmd.setSyncStatusId(state.getSyncStatusId());
        cmd.setBillingAccountId(state.getBillingAccountId());
        cmd.setOriginFacilityId(state.getOriginFacilityId());
        cmd.setWebSiteId(state.getWebSiteId());
        cmd.setProductStoreId(state.getProductStoreId());
        cmd.setTerminalId(state.getTerminalId());
        cmd.setTransactionId(state.getTransactionId());
        cmd.setAutoOrderShoppingListId(state.getAutoOrderShoppingListId());
        cmd.setNeedsInventoryIssuance(state.getNeedsInventoryIssuance());
        cmd.setIsRushOrder(state.getIsRushOrder());
        cmd.setInternalCode(state.getInternalCode());
        cmd.setRemainingSubTotal(state.getRemainingSubTotal());
        cmd.setGrandTotal(state.getGrandTotal());
        cmd.setInvoicePerShipment(state.getInvoicePerShipment());
        cmd.setActive(state.getActive());
            
        if (state.getOrderTypeId() == null) { cmd.setIsPropertyOrderTypeIdRemoved(true); }
        if (state.getOrderName() == null) { cmd.setIsPropertyOrderNameRemoved(true); }
        if (state.getExternalId() == null) { cmd.setIsPropertyExternalIdRemoved(true); }
        if (state.getSalesChannelEnumId() == null) { cmd.setIsPropertySalesChannelEnumIdRemoved(true); }
        if (state.getOrderDate() == null) { cmd.setIsPropertyOrderDateRemoved(true); }
        if (state.getPriority() == null) { cmd.setIsPropertyPriorityRemoved(true); }
        if (state.getEntryDate() == null) { cmd.setIsPropertyEntryDateRemoved(true); }
        if (state.getPickSheetPrintedDate() == null) { cmd.setIsPropertyPickSheetPrintedDateRemoved(true); }
        if (state.getStatusId() == null) { cmd.setIsPropertyStatusIdRemoved(true); }
        if (state.getCurrencyUom() == null) { cmd.setIsPropertyCurrencyUomRemoved(true); }
        if (state.getSyncStatusId() == null) { cmd.setIsPropertySyncStatusIdRemoved(true); }
        if (state.getBillingAccountId() == null) { cmd.setIsPropertyBillingAccountIdRemoved(true); }
        if (state.getOriginFacilityId() == null) { cmd.setIsPropertyOriginFacilityIdRemoved(true); }
        if (state.getWebSiteId() == null) { cmd.setIsPropertyWebSiteIdRemoved(true); }
        if (state.getProductStoreId() == null) { cmd.setIsPropertyProductStoreIdRemoved(true); }
        if (state.getTerminalId() == null) { cmd.setIsPropertyTerminalIdRemoved(true); }
        if (state.getTransactionId() == null) { cmd.setIsPropertyTransactionIdRemoved(true); }
        if (state.getAutoOrderShoppingListId() == null) { cmd.setIsPropertyAutoOrderShoppingListIdRemoved(true); }
        if (state.getNeedsInventoryIssuance() == null) { cmd.setIsPropertyNeedsInventoryIssuanceRemoved(true); }
        if (state.getIsRushOrder() == null) { cmd.setIsPropertyIsRushOrderRemoved(true); }
        if (state.getInternalCode() == null) { cmd.setIsPropertyInternalCodeRemoved(true); }
        if (state.getRemainingSubTotal() == null) { cmd.setIsPropertyRemainingSubTotalRemoved(true); }
        if (state.getGrandTotal() == null) { cmd.setIsPropertyGrandTotalRemoved(true); }
        if (state.getInvoicePerShipment() == null) { cmd.setIsPropertyInvoicePerShipmentRemoved(true); }
        if (state.getActive() == null) { cmd.setIsPropertyActiveRemoved(true); }
        for (OrderRoleState d : state.getOrderRoles())
        {
            OrderRoleCommand c = getOrderRoleStateCommandConverter().toCreateOrMergePatchOrderRole(d);
            cmd.getOrderRoleCommands().add(c);
        }
        for (OrderItemState d : state.getOrderItems())
        {
            OrderItemCommand c = getOrderItemStateCommandConverter().toCreateOrMergePatchOrderItem(d);
            cmd.getOrderItemCommands().add(c);
        }
        for (OrderShipGroupState d : state.getOrderShipGroups())
        {
            OrderShipGroupCommand c = getOrderShipGroupStateCommandConverter().toCreateOrMergePatchOrderShipGroup(d);
            cmd.getOrderShipGroupCommands().add(c);
        }
        return cmd;
    }

    public TCreateOrder toCreateOrder(OrderState state) //where TCreateOrder : ICreateOrder, new()
    {
        TCreateOrder cmd = newCreateOrder();

        cmd.setVersion(state.getVersion());
        cmd.setOrderId(state.getOrderId());
        cmd.setOrderTypeId(state.getOrderTypeId());
        cmd.setOrderName(state.getOrderName());
        cmd.setExternalId(state.getExternalId());
        cmd.setSalesChannelEnumId(state.getSalesChannelEnumId());
        cmd.setOrderDate(state.getOrderDate());
        cmd.setPriority(state.getPriority());
        cmd.setEntryDate(state.getEntryDate());
        cmd.setPickSheetPrintedDate(state.getPickSheetPrintedDate());
        cmd.setStatusId(state.getStatusId());
        cmd.setCurrencyUom(state.getCurrencyUom());
        cmd.setSyncStatusId(state.getSyncStatusId());
        cmd.setBillingAccountId(state.getBillingAccountId());
        cmd.setOriginFacilityId(state.getOriginFacilityId());
        cmd.setWebSiteId(state.getWebSiteId());
        cmd.setProductStoreId(state.getProductStoreId());
        cmd.setTerminalId(state.getTerminalId());
        cmd.setTransactionId(state.getTransactionId());
        cmd.setAutoOrderShoppingListId(state.getAutoOrderShoppingListId());
        cmd.setNeedsInventoryIssuance(state.getNeedsInventoryIssuance());
        cmd.setIsRushOrder(state.getIsRushOrder());
        cmd.setInternalCode(state.getInternalCode());
        cmd.setRemainingSubTotal(state.getRemainingSubTotal());
        cmd.setGrandTotal(state.getGrandTotal());
        cmd.setInvoicePerShipment(state.getInvoicePerShipment());
        cmd.setActive(state.getActive());
        for (OrderRoleState d : state.getOrderRoles())
        {
            OrderRoleCommand.CreateOrderRole c = getOrderRoleStateCommandConverter().toCreateOrderRole(d);
            cmd.getOrderRoles().add(c);
        }
        for (OrderItemState d : state.getOrderItems())
        {
            OrderItemCommand.CreateOrderItem c = getOrderItemStateCommandConverter().toCreateOrderItem(d);
            cmd.getOrderItems().add(c);
        }
        for (OrderShipGroupState d : state.getOrderShipGroups())
        {
            OrderShipGroupCommand.CreateOrderShipGroup c = getOrderShipGroupStateCommandConverter().toCreateOrderShipGroup(d);
            cmd.getOrderShipGroups().add(c);
        }
        return cmd;
    }

    protected abstract AbstractOrderRoleStateCommandConverter<TCreateOrderRole, TMergePatchOrderRole, TRemoveOrderRole>
        getOrderRoleStateCommandConverter();

    protected abstract AbstractOrderItemStateCommandConverter<TCreateOrderItem, TMergePatchOrderItem, TRemoveOrderItem>
        getOrderItemStateCommandConverter();

    protected abstract AbstractOrderShipGroupStateCommandConverter<TCreateOrderShipGroup, TMergePatchOrderShipGroup, TRemoveOrderShipGroup, TCreateOrderItemShipGroupAssociation, TMergePatchOrderItemShipGroupAssociation, TRemoveOrderItemShipGroupAssociation>
        getOrderShipGroupStateCommandConverter();

    protected abstract TCreateOrder newCreateOrder();

    protected abstract TMergePatchOrder newMergePatchOrder(); 

    protected abstract TDeleteOrder newDeleteOrder();

    public static class SimpleOrderStateCommandConverter extends AbstractOrderStateCommandConverter<AbstractOrderCommand.SimpleCreateOrder, AbstractOrderCommand.SimpleMergePatchOrder, AbstractOrderCommand.SimpleDeleteOrder, AbstractOrderRoleCommand.SimpleCreateOrderRole, AbstractOrderRoleCommand.SimpleMergePatchOrderRole, AbstractOrderRoleCommand.SimpleRemoveOrderRole, AbstractOrderItemCommand.SimpleCreateOrderItem, AbstractOrderItemCommand.SimpleMergePatchOrderItem, AbstractOrderItemCommand.SimpleRemoveOrderItem, AbstractOrderShipGroupCommand.SimpleCreateOrderShipGroup, AbstractOrderShipGroupCommand.SimpleMergePatchOrderShipGroup, AbstractOrderShipGroupCommand.SimpleRemoveOrderShipGroup, AbstractOrderItemShipGroupAssociationCommand.SimpleCreateOrderItemShipGroupAssociation, AbstractOrderItemShipGroupAssociationCommand.SimpleMergePatchOrderItemShipGroupAssociation, AbstractOrderItemShipGroupAssociationCommand.SimpleRemoveOrderItemShipGroupAssociation>
    {
        @Override
        protected AbstractOrderCommand.SimpleCreateOrder newCreateOrder() {
            return new AbstractOrderCommand.SimpleCreateOrder();
        }

        @Override
        protected AbstractOrderCommand.SimpleMergePatchOrder newMergePatchOrder() {
            return new AbstractOrderCommand.SimpleMergePatchOrder();
        }

        @Override
        protected AbstractOrderCommand.SimpleDeleteOrder newDeleteOrder() {
            return new AbstractOrderCommand.SimpleDeleteOrder();
        }

        @Override
        protected AbstractOrderRoleStateCommandConverter<AbstractOrderRoleCommand.SimpleCreateOrderRole, AbstractOrderRoleCommand.SimpleMergePatchOrderRole, AbstractOrderRoleCommand.SimpleRemoveOrderRole> getOrderRoleStateCommandConverter()
        {
            return new AbstractOrderRoleStateCommandConverter.SimpleOrderRoleStateCommandConverter();
        }

        @Override
        protected AbstractOrderItemStateCommandConverter<AbstractOrderItemCommand.SimpleCreateOrderItem, AbstractOrderItemCommand.SimpleMergePatchOrderItem, AbstractOrderItemCommand.SimpleRemoveOrderItem> getOrderItemStateCommandConverter()
        {
            return new AbstractOrderItemStateCommandConverter.SimpleOrderItemStateCommandConverter();
        }

        @Override
        protected AbstractOrderShipGroupStateCommandConverter<AbstractOrderShipGroupCommand.SimpleCreateOrderShipGroup, AbstractOrderShipGroupCommand.SimpleMergePatchOrderShipGroup, AbstractOrderShipGroupCommand.SimpleRemoveOrderShipGroup, AbstractOrderItemShipGroupAssociationCommand.SimpleCreateOrderItemShipGroupAssociation, AbstractOrderItemShipGroupAssociationCommand.SimpleMergePatchOrderItemShipGroupAssociation, AbstractOrderItemShipGroupAssociationCommand.SimpleRemoveOrderItemShipGroupAssociation> getOrderShipGroupStateCommandConverter()
        {
            return new AbstractOrderShipGroupStateCommandConverter.SimpleOrderShipGroupStateCommandConverter();
        }


    }

}

