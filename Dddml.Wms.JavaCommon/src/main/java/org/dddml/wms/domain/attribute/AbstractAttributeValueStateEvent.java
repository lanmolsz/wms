package org.dddml.wms.domain.attribute;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractStateEvent;

public abstract class AbstractAttributeValueStateEvent extends AbstractStateEvent implements AttributeValueStateEvent 
{
    private AttributeValueStateEventId stateEventId;

    public AttributeValueStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(AttributeValueStateEventId stateEventId) {
        this.stateEventId = stateEventId;
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

    private String name;

    public String getName()
    {
        return this.name;
    }

    public void setName(String name)
    {
        this.name = name;
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

    private String referenceId;

    public String getReferenceId()
    {
        return this.referenceId;
    }

    public void setReferenceId(String referenceId)
    {
        this.referenceId = referenceId;
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

    protected AbstractAttributeValueStateEvent() {
    }

    protected AbstractAttributeValueStateEvent(AttributeValueStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractAttributeValueStateCreated extends AbstractAttributeValueStateEvent implements AttributeValueStateEvent.AttributeValueStateCreated
    {
        public AbstractAttributeValueStateCreated() {
        }

        public AbstractAttributeValueStateCreated(AttributeValueStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


    public static abstract class AbstractAttributeValueStateMergePatched extends AbstractAttributeValueStateEvent implements AttributeValueStateEvent.AttributeValueStateMergePatched
    {
        public AbstractAttributeValueStateMergePatched() {
        }

        public AbstractAttributeValueStateMergePatched(AttributeValueStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.MERGE_PATCHED;
        }

        private Boolean isPropertyNameRemoved;

        public Boolean getIsPropertyNameRemoved() {
            return this.isPropertyNameRemoved;
        }

        public void setIsPropertyNameRemoved(Boolean removed) {
            this.isPropertyNameRemoved = removed;
        }

        private Boolean isPropertyDescriptionRemoved;

        public Boolean getIsPropertyDescriptionRemoved() {
            return this.isPropertyDescriptionRemoved;
        }

        public void setIsPropertyDescriptionRemoved(Boolean removed) {
            this.isPropertyDescriptionRemoved = removed;
        }

        private Boolean isPropertyReferenceIdRemoved;

        public Boolean getIsPropertyReferenceIdRemoved() {
            return this.isPropertyReferenceIdRemoved;
        }

        public void setIsPropertyReferenceIdRemoved(Boolean removed) {
            this.isPropertyReferenceIdRemoved = removed;
        }

        private Boolean isPropertyActiveRemoved;

        public Boolean getIsPropertyActiveRemoved() {
            return this.isPropertyActiveRemoved;
        }

        public void setIsPropertyActiveRemoved(Boolean removed) {
            this.isPropertyActiveRemoved = removed;
        }

    }


    public static abstract class AbstractAttributeValueStateRemoved extends AbstractAttributeValueStateEvent implements AttributeValueStateEvent.AttributeValueStateRemoved
    {
        public AbstractAttributeValueStateRemoved() {
        }

        public AbstractAttributeValueStateRemoved(AttributeValueStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.REMOVED;
        }

    }
    public static class SimpleAttributeValueStateCreated extends AbstractAttributeValueStateCreated
    {
        public SimpleAttributeValueStateCreated() {
        }

        public SimpleAttributeValueStateCreated(AttributeValueStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleAttributeValueStateMergePatched extends AbstractAttributeValueStateMergePatched
    {
        public SimpleAttributeValueStateMergePatched() {
        }

        public SimpleAttributeValueStateMergePatched(AttributeValueStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleAttributeValueStateRemoved extends AbstractAttributeValueStateRemoved
    {
        public SimpleAttributeValueStateRemoved() {
        }

        public SimpleAttributeValueStateRemoved(AttributeValueStateEventId stateEventId) {
            super(stateEventId);
        }
    }

}

