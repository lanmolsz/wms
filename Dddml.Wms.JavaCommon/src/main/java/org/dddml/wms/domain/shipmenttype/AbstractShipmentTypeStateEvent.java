package org.dddml.wms.domain.shipmenttype;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractStateEvent;

public abstract class AbstractShipmentTypeStateEvent extends AbstractStateEvent implements ShipmentTypeStateEvent 
{
    private ShipmentTypeStateEventId stateEventId;

    public ShipmentTypeStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(ShipmentTypeStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }
    
    public String getShipmentTypeId() {
        return getStateEventId().getShipmentTypeId();
    }

    public void setShipmentTypeId(String shipmentTypeId) {
        getStateEventId().setShipmentTypeId(shipmentTypeId);
    }

    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

    private String parentTypeId;

    public String getParentTypeId()
    {
        return this.parentTypeId;
    }

    public void setParentTypeId(String parentTypeId)
    {
        this.parentTypeId = parentTypeId;
    }

    private String hasTable;

    public String getHasTable()
    {
        return this.hasTable;
    }

    public void setHasTable(String hasTable)
    {
        this.hasTable = hasTable;
    }

    private String description;

    public String getDescription()
    {
        return this.description;
    }

    public void setDescription(String description)
    {
        this.description = description;
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

    protected AbstractShipmentTypeStateEvent() {
    }

    protected AbstractShipmentTypeStateEvent(ShipmentTypeStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractShipmentTypeStateCreated extends AbstractShipmentTypeStateEvent implements ShipmentTypeStateEvent.ShipmentTypeStateCreated
    {
        public AbstractShipmentTypeStateCreated() {
            this(new ShipmentTypeStateEventId());
        }

        public AbstractShipmentTypeStateCreated(ShipmentTypeStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


    public static abstract class AbstractShipmentTypeStateMergePatched extends AbstractShipmentTypeStateEvent implements ShipmentTypeStateEvent.ShipmentTypeStateMergePatched
    {
        public AbstractShipmentTypeStateMergePatched() {
            this(new ShipmentTypeStateEventId());
        }

        public AbstractShipmentTypeStateMergePatched(ShipmentTypeStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.MERGE_PATCHED;
        }

        private Boolean isPropertyParentTypeIdRemoved;

        public Boolean getIsPropertyParentTypeIdRemoved() {
            return this.isPropertyParentTypeIdRemoved;
        }

        public void setIsPropertyParentTypeIdRemoved(Boolean removed) {
            this.isPropertyParentTypeIdRemoved = removed;
        }

        private Boolean isPropertyHasTableRemoved;

        public Boolean getIsPropertyHasTableRemoved() {
            return this.isPropertyHasTableRemoved;
        }

        public void setIsPropertyHasTableRemoved(Boolean removed) {
            this.isPropertyHasTableRemoved = removed;
        }

        private Boolean isPropertyDescriptionRemoved;

        public Boolean getIsPropertyDescriptionRemoved() {
            return this.isPropertyDescriptionRemoved;
        }

        public void setIsPropertyDescriptionRemoved(Boolean removed) {
            this.isPropertyDescriptionRemoved = removed;
        }

        private Boolean isPropertyActiveRemoved;

        public Boolean getIsPropertyActiveRemoved() {
            return this.isPropertyActiveRemoved;
        }

        public void setIsPropertyActiveRemoved(Boolean removed) {
            this.isPropertyActiveRemoved = removed;
        }

    }


    public static class SimpleShipmentTypeStateCreated extends AbstractShipmentTypeStateCreated
    {
        public SimpleShipmentTypeStateCreated() {
        }

        public SimpleShipmentTypeStateCreated(ShipmentTypeStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleShipmentTypeStateMergePatched extends AbstractShipmentTypeStateMergePatched
    {
        public SimpleShipmentTypeStateMergePatched() {
        }

        public SimpleShipmentTypeStateMergePatched(ShipmentTypeStateEventId stateEventId) {
            super(stateEventId);
        }
    }

}

