package org.dddml.wms.domain.orderrolemvo;

import java.util.Set;
import org.dddml.wms.domain.order.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.orderrolemvo.OrderRoleMvoEvent.*;

public interface OrderRoleMvoState
{
    Long VERSION_ZERO = 0L;

    Long VERSION_NULL = VERSION_ZERO - 1;

    OrderRoleId getOrderRoleId();

    void setOrderRoleId(OrderRoleId orderRoleId);

    Long getVersion();

    void setVersion(Long version);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    String getUpdatedBy();

    void setUpdatedBy(String updatedBy);

    Date getUpdatedAt();

    void setUpdatedAt(Date updatedAt);

    Boolean getActive();

    void setActive(Boolean active);

    Boolean getDeleted();

    void setDeleted(Boolean deleted);

    String getOrderOrderTypeId();

    void setOrderOrderTypeId(String orderOrderTypeId);

    String getOrderOrderName();

    void setOrderOrderName(String orderOrderName);

    String getOrderExternalId();

    void setOrderExternalId(String orderExternalId);

    String getOrderSalesChannelEnumId();

    void setOrderSalesChannelEnumId(String orderSalesChannelEnumId);

    java.sql.Timestamp getOrderOrderDate();

    void setOrderOrderDate(java.sql.Timestamp orderOrderDate);

    String getOrderPriority();

    void setOrderPriority(String orderPriority);

    java.sql.Timestamp getOrderEntryDate();

    void setOrderEntryDate(java.sql.Timestamp orderEntryDate);

    java.sql.Timestamp getOrderPickSheetPrintedDate();

    void setOrderPickSheetPrintedDate(java.sql.Timestamp orderPickSheetPrintedDate);

    String getOrderStatusId();

    void setOrderStatusId(String orderStatusId);

    String getOrderCurrencyUom();

    void setOrderCurrencyUom(String orderCurrencyUom);

    String getOrderSyncStatusId();

    void setOrderSyncStatusId(String orderSyncStatusId);

    String getOrderBillingAccountId();

    void setOrderBillingAccountId(String orderBillingAccountId);

    String getOrderOriginFacilityId();

    void setOrderOriginFacilityId(String orderOriginFacilityId);

    String getOrderWebSiteId();

    void setOrderWebSiteId(String orderWebSiteId);

    String getOrderProductStoreId();

    void setOrderProductStoreId(String orderProductStoreId);

    String getOrderTerminalId();

    void setOrderTerminalId(String orderTerminalId);

    String getOrderTransactionId();

    void setOrderTransactionId(String orderTransactionId);

    String getOrderAutoOrderShoppingListId();

    void setOrderAutoOrderShoppingListId(String orderAutoOrderShoppingListId);

    String getOrderNeedsInventoryIssuance();

    void setOrderNeedsInventoryIssuance(String orderNeedsInventoryIssuance);

    String getOrderIsRushOrder();

    void setOrderIsRushOrder(String orderIsRushOrder);

    String getOrderInternalCode();

    void setOrderInternalCode(String orderInternalCode);

    java.math.BigDecimal getOrderRemainingSubTotal();

    void setOrderRemainingSubTotal(java.math.BigDecimal orderRemainingSubTotal);

    java.math.BigDecimal getOrderGrandTotal();

    void setOrderGrandTotal(java.math.BigDecimal orderGrandTotal);

    String getOrderInvoicePerShipment();

    void setOrderInvoicePerShipment(String orderInvoicePerShipment);

    Long getOrderVersion();

    void setOrderVersion(Long orderVersion);

    String getOrderCreatedBy();

    void setOrderCreatedBy(String orderCreatedBy);

    Date getOrderCreatedAt();

    void setOrderCreatedAt(Date orderCreatedAt);

    String getOrderUpdatedBy();

    void setOrderUpdatedBy(String orderUpdatedBy);

    Date getOrderUpdatedAt();

    void setOrderUpdatedAt(Date orderUpdatedAt);

    Boolean getOrderActive();

    void setOrderActive(Boolean orderActive);


    boolean isStateUnsaved();

    boolean getForReapplying();


    void mutate(Event e);

    void when(OrderRoleMvoEvent.OrderRoleMvoStateCreated e);

    void when(OrderRoleMvoEvent.OrderRoleMvoStateMergePatched e);

    void when(OrderRoleMvoEvent.OrderRoleMvoStateDeleted e);
    
}

