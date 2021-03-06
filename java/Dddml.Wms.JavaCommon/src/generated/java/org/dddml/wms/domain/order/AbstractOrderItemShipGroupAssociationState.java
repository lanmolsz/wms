package org.dddml.wms.domain.order;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.order.OrderItemShipGroupAssociationEvent.*;

public abstract class AbstractOrderItemShipGroupAssociationState implements OrderItemShipGroupAssociationState
{

    private OrderItemShipGroupAssociationId orderItemShipGroupAssociationId = new OrderItemShipGroupAssociationId();

    public OrderItemShipGroupAssociationId getOrderItemShipGroupAssociationId() {
        return this.orderItemShipGroupAssociationId;
    }

    public void setOrderItemShipGroupAssociationId(OrderItemShipGroupAssociationId orderItemShipGroupAssociationId) {
        this.orderItemShipGroupAssociationId = orderItemShipGroupAssociationId;
    }

    public String getOrderId() {
        return this.getOrderItemShipGroupAssociationId().getOrderId();
    }
        
    public void setOrderId(String orderId) {
        this.getOrderItemShipGroupAssociationId().setOrderId(orderId);
    }

    public Long getOrderShipGroupShipGroupSeqId() {
        return this.getOrderItemShipGroupAssociationId().getOrderShipGroupShipGroupSeqId();
    }
        
    public void setOrderShipGroupShipGroupSeqId(Long orderShipGroupShipGroupSeqId) {
        this.getOrderItemShipGroupAssociationId().setOrderShipGroupShipGroupSeqId(orderShipGroupShipGroupSeqId);
    }

    public String getOrderItemSeqId() {
        return this.getOrderItemShipGroupAssociationId().getOrderItemSeqId();
    }
        
    public void setOrderItemSeqId(String orderItemSeqId) {
        this.getOrderItemShipGroupAssociationId().setOrderItemSeqId(orderItemSeqId);
    }

    private java.math.BigDecimal quantity;

    public java.math.BigDecimal getQuantity()
    {
        return this.quantity;
    }

    public void setQuantity(java.math.BigDecimal quantity)
    {
        this.quantity = quantity;
    }

    private java.math.BigDecimal cancelQuantity;

    public java.math.BigDecimal getCancelQuantity()
    {
        return this.cancelQuantity;
    }

    public void setCancelQuantity(java.math.BigDecimal cancelQuantity)
    {
        this.cancelQuantity = cancelQuantity;
    }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }

    private String createdBy;

    public String getCreatedBy()
    {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy)
    {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt()
    {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt)
    {
        this.createdAt = createdAt;
    }

    private String updatedBy;

    public String getUpdatedBy()
    {
        return this.updatedBy;
    }

    public void setUpdatedBy(String updatedBy)
    {
        this.updatedBy = updatedBy;
    }

    private Date updatedAt;

    public Date getUpdatedAt()
    {
        return this.updatedAt;
    }

    public void setUpdatedAt(Date updatedAt)
    {
        this.updatedAt = updatedAt;
    }

    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private Boolean deleted;

    public Boolean getDeleted()
    {
        return this.deleted;
    }

    public void setDeleted(Boolean deleted)
    {
        this.deleted = deleted;
    }

    public boolean isStateUnsaved() 
    {
        return this.getVersion() == null;
    }

    private Boolean stateReadOnly;

    public Boolean getStateReadOnly() { return this.stateReadOnly; }

    public void setStateReadOnly(Boolean readOnly) { this.stateReadOnly = readOnly; }

    private boolean forReapplying;

    public boolean getForReapplying() {
        return forReapplying;
    }

    public void setForReapplying(boolean forReapplying) {
        this.forReapplying = forReapplying;
    }


    public AbstractOrderItemShipGroupAssociationState() {
        this(false);
    }

    public AbstractOrderItemShipGroupAssociationState(boolean forReapplying) {
        this.forReapplying = forReapplying;

        initializeProperties();
    }
    
    protected void initializeProperties() {
    }


    public void mutate(Event e) {
        setStateReadOnly(false);
        if (e instanceof OrderItemShipGroupAssociationStateCreated) {
            when((OrderItemShipGroupAssociationStateCreated) e);
        } else if (e instanceof OrderItemShipGroupAssociationStateMergePatched) {
            when((OrderItemShipGroupAssociationStateMergePatched) e);
        } else if (e instanceof OrderItemShipGroupAssociationStateRemoved) {
            when((OrderItemShipGroupAssociationStateRemoved) e);
        } else {
            throw new UnsupportedOperationException(String.format("Unsupported event type: %1$s", e.getClass().getName()));
        }
    }

    public void when(OrderItemShipGroupAssociationStateCreated e)
    {
        throwOnWrongEvent(e);

        this.setQuantity(e.getQuantity());
        this.setCancelQuantity(e.getCancelQuantity());
        this.setActive(e.getActive());

        this.setDeleted(false);

        this.setCreatedBy(e.getCreatedBy());
        this.setCreatedAt(e.getCreatedAt());

    }

    public void when(OrderItemShipGroupAssociationStateMergePatched e)
    {
        throwOnWrongEvent(e);

        if (e.getQuantity() == null)
        {
            if (e.getIsPropertyQuantityRemoved() != null && e.getIsPropertyQuantityRemoved())
            {
                this.setQuantity(null);
            }
        }
        else
        {
            this.setQuantity(e.getQuantity());
        }
        if (e.getCancelQuantity() == null)
        {
            if (e.getIsPropertyCancelQuantityRemoved() != null && e.getIsPropertyCancelQuantityRemoved())
            {
                this.setCancelQuantity(null);
            }
        }
        else
        {
            this.setCancelQuantity(e.getCancelQuantity());
        }
        if (e.getActive() == null)
        {
            if (e.getIsPropertyActiveRemoved() != null && e.getIsPropertyActiveRemoved())
            {
                this.setActive(null);
            }
        }
        else
        {
            this.setActive(e.getActive());
        }

        this.setUpdatedBy(e.getCreatedBy());
        this.setUpdatedAt(e.getCreatedAt());

    }

    public void when(OrderItemShipGroupAssociationStateRemoved e)
    {
        throwOnWrongEvent(e);

        this.setDeleted(true);
        this.setUpdatedBy(e.getCreatedBy());
        this.setUpdatedAt(e.getCreatedAt());

    }

    public void save()
    {
    }

    protected void throwOnWrongEvent(OrderItemShipGroupAssociationEvent event)
    {
        String stateEntityIdOrderId = this.getOrderItemShipGroupAssociationId().getOrderId();
        String eventEntityIdOrderId = event.getOrderItemShipGroupAssociationEventId().getOrderId();
        if (!stateEntityIdOrderId.equals(eventEntityIdOrderId))
        {
            throw DomainError.named("mutateWrongEntity", "Entity Id OrderId %1$s in state but entity id OrderId %2$s in event", stateEntityIdOrderId, eventEntityIdOrderId);
        }

        Long stateEntityIdOrderShipGroupShipGroupSeqId = this.getOrderItemShipGroupAssociationId().getOrderShipGroupShipGroupSeqId();
        Long eventEntityIdOrderShipGroupShipGroupSeqId = event.getOrderItemShipGroupAssociationEventId().getOrderShipGroupShipGroupSeqId();
        if (!stateEntityIdOrderShipGroupShipGroupSeqId.equals(eventEntityIdOrderShipGroupShipGroupSeqId))
        {
            throw DomainError.named("mutateWrongEntity", "Entity Id OrderShipGroupShipGroupSeqId %1$s in state but entity id OrderShipGroupShipGroupSeqId %2$s in event", stateEntityIdOrderShipGroupShipGroupSeqId, eventEntityIdOrderShipGroupShipGroupSeqId);
        }

        String stateEntityIdOrderItemSeqId = this.getOrderItemShipGroupAssociationId().getOrderItemSeqId();
        String eventEntityIdOrderItemSeqId = event.getOrderItemShipGroupAssociationEventId().getOrderItemSeqId();
        if (!stateEntityIdOrderItemSeqId.equals(eventEntityIdOrderItemSeqId))
        {
            throw DomainError.named("mutateWrongEntity", "Entity Id OrderItemSeqId %1$s in state but entity id OrderItemSeqId %2$s in event", stateEntityIdOrderItemSeqId, eventEntityIdOrderItemSeqId);
        }

        if (getForReapplying()) { return; }

        OrderItemShipGroupAssociationStateEvent stateEvent = event instanceof OrderItemShipGroupAssociationStateEvent ? (OrderItemShipGroupAssociationStateEvent)event : null;
        if (stateEvent == null) { return; }

        Long stateVersion = this.getVersion();
        Long stateEventStateVersion = stateEvent.getVersion();
        //if (stateEventStateVersion == null) {
        stateEventStateVersion = stateVersion == null ? OrderItemShipGroupAssociationState.VERSION_NULL : stateVersion;
        stateEvent.setVersion(stateEventStateVersion);
        //}
        //if (!(stateVersion == null && stateEventStateVersion.equals(OrderItemShipGroupAssociationState.VERSION_NULL)) && !stateEventStateVersion.equals(stateVersion))
        //{
        //    throw DomainError.named("concurrencyConflict", "Conflict between stateVersion (%1$s) and stateEventStateVersion (%2$s)", stateVersion, stateEventStateVersion);
        //}

    }

    public static class SimpleOrderItemShipGroupAssociationState extends AbstractOrderItemShipGroupAssociationState
    {

        public SimpleOrderItemShipGroupAssociationState() {
        }

        public SimpleOrderItemShipGroupAssociationState(boolean forReapplying) {
            super(forReapplying);
        }

    }


}

