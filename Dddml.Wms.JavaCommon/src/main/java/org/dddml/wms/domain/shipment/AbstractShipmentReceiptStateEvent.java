package org.dddml.wms.domain.shipment;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractStateEvent;

public abstract class AbstractShipmentReceiptStateEvent extends AbstractStateEvent implements ShipmentReceiptStateEvent 
{
    private ShipmentReceiptStateEventId stateEventId;

    public ShipmentReceiptStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(ShipmentReceiptStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }
    
    public String getReceiptSeqId() {
        return getStateEventId().getReceiptSeqId();
    }

    public void setReceiptSeqId(String receiptSeqId) {
        getStateEventId().setReceiptSeqId(receiptSeqId);
    }

    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }

    private String productId;

    public String getProductId()
    {
        return this.productId;
    }

    public void setProductId(String productId)
    {
        this.productId = productId;
    }

    private String shipmentItemSeqId;

    public String getShipmentItemSeqId()
    {
        return this.shipmentItemSeqId;
    }

    public void setShipmentItemSeqId(String shipmentItemSeqId)
    {
        this.shipmentItemSeqId = shipmentItemSeqId;
    }

    private String rejectionReasonId;

    public String getRejectionReasonId()
    {
        return this.rejectionReasonId;
    }

    public void setRejectionReasonId(String rejectionReasonId)
    {
        this.rejectionReasonId = rejectionReasonId;
    }

    private String damageStatusId;

    public String getDamageStatusId()
    {
        return this.damageStatusId;
    }

    public void setDamageStatusId(String damageStatusId)
    {
        this.damageStatusId = damageStatusId;
    }

    private String damageReasonId;

    public String getDamageReasonId()
    {
        return this.damageReasonId;
    }

    public void setDamageReasonId(String damageReasonId)
    {
        this.damageReasonId = damageReasonId;
    }

    private String itemDescription;

    public String getItemDescription()
    {
        return this.itemDescription;
    }

    public void setItemDescription(String itemDescription)
    {
        this.itemDescription = itemDescription;
    }

    private java.math.BigDecimal acceptedQuantity;

    public java.math.BigDecimal getAcceptedQuantity()
    {
        return this.acceptedQuantity;
    }

    public void setAcceptedQuantity(java.math.BigDecimal acceptedQuantity)
    {
        this.acceptedQuantity = acceptedQuantity;
    }

    private java.math.BigDecimal rejectedQuantity;

    public java.math.BigDecimal getRejectedQuantity()
    {
        return this.rejectedQuantity;
    }

    public void setRejectedQuantity(java.math.BigDecimal rejectedQuantity)
    {
        this.rejectedQuantity = rejectedQuantity;
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

    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }


    private String commandId;

    public String getCommandId() {
        return commandId;
    }

    public void setCommandId(String commandId) {
        this.commandId = commandId;
    }

    protected AbstractShipmentReceiptStateEvent() {
    }

    protected AbstractShipmentReceiptStateEvent(ShipmentReceiptStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractShipmentReceiptStateCreated extends AbstractShipmentReceiptStateEvent implements ShipmentReceiptStateEvent.ShipmentReceiptStateCreated
    {
        public AbstractShipmentReceiptStateCreated() {
            this(new ShipmentReceiptStateEventId());
        }

        public AbstractShipmentReceiptStateCreated(ShipmentReceiptStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


    public static abstract class AbstractShipmentReceiptStateMergePatched extends AbstractShipmentReceiptStateEvent implements ShipmentReceiptStateEvent.ShipmentReceiptStateMergePatched
    {
        public AbstractShipmentReceiptStateMergePatched() {
            this(new ShipmentReceiptStateEventId());
        }

        public AbstractShipmentReceiptStateMergePatched(ShipmentReceiptStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.MERGE_PATCHED;
        }

        private Boolean isPropertyProductIdRemoved;

        public Boolean getIsPropertyProductIdRemoved() {
            return this.isPropertyProductIdRemoved;
        }

        public void setIsPropertyProductIdRemoved(Boolean removed) {
            this.isPropertyProductIdRemoved = removed;
        }

        private Boolean isPropertyShipmentItemSeqIdRemoved;

        public Boolean getIsPropertyShipmentItemSeqIdRemoved() {
            return this.isPropertyShipmentItemSeqIdRemoved;
        }

        public void setIsPropertyShipmentItemSeqIdRemoved(Boolean removed) {
            this.isPropertyShipmentItemSeqIdRemoved = removed;
        }

        private Boolean isPropertyRejectionReasonIdRemoved;

        public Boolean getIsPropertyRejectionReasonIdRemoved() {
            return this.isPropertyRejectionReasonIdRemoved;
        }

        public void setIsPropertyRejectionReasonIdRemoved(Boolean removed) {
            this.isPropertyRejectionReasonIdRemoved = removed;
        }

        private Boolean isPropertyDamageStatusIdRemoved;

        public Boolean getIsPropertyDamageStatusIdRemoved() {
            return this.isPropertyDamageStatusIdRemoved;
        }

        public void setIsPropertyDamageStatusIdRemoved(Boolean removed) {
            this.isPropertyDamageStatusIdRemoved = removed;
        }

        private Boolean isPropertyDamageReasonIdRemoved;

        public Boolean getIsPropertyDamageReasonIdRemoved() {
            return this.isPropertyDamageReasonIdRemoved;
        }

        public void setIsPropertyDamageReasonIdRemoved(Boolean removed) {
            this.isPropertyDamageReasonIdRemoved = removed;
        }

        private Boolean isPropertyItemDescriptionRemoved;

        public Boolean getIsPropertyItemDescriptionRemoved() {
            return this.isPropertyItemDescriptionRemoved;
        }

        public void setIsPropertyItemDescriptionRemoved(Boolean removed) {
            this.isPropertyItemDescriptionRemoved = removed;
        }

        private Boolean isPropertyAcceptedQuantityRemoved;

        public Boolean getIsPropertyAcceptedQuantityRemoved() {
            return this.isPropertyAcceptedQuantityRemoved;
        }

        public void setIsPropertyAcceptedQuantityRemoved(Boolean removed) {
            this.isPropertyAcceptedQuantityRemoved = removed;
        }

        private Boolean isPropertyRejectedQuantityRemoved;

        public Boolean getIsPropertyRejectedQuantityRemoved() {
            return this.isPropertyRejectedQuantityRemoved;
        }

        public void setIsPropertyRejectedQuantityRemoved(Boolean removed) {
            this.isPropertyRejectedQuantityRemoved = removed;
        }

        private Boolean isPropertyActiveRemoved;

        public Boolean getIsPropertyActiveRemoved() {
            return this.isPropertyActiveRemoved;
        }

        public void setIsPropertyActiveRemoved(Boolean removed) {
            this.isPropertyActiveRemoved = removed;
        }

    }


    public static class SimpleShipmentReceiptStateCreated extends AbstractShipmentReceiptStateCreated
    {
        public SimpleShipmentReceiptStateCreated() {
        }

        public SimpleShipmentReceiptStateCreated(ShipmentReceiptStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleShipmentReceiptStateMergePatched extends AbstractShipmentReceiptStateMergePatched
    {
        public SimpleShipmentReceiptStateMergePatched() {
        }

        public SimpleShipmentReceiptStateMergePatched(ShipmentReceiptStateEventId stateEventId) {
            super(stateEventId);
        }
    }

}

