package org.dddml.wms.domain.attributesetinstanceextensionfieldgroup;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractStateEvent;

public abstract class AbstractAttributeSetInstanceExtensionFieldGroupStateEvent extends AbstractStateEvent implements AttributeSetInstanceExtensionFieldGroupStateEvent 
{
    private AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId;

    public AttributeSetInstanceExtensionFieldGroupStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }
    
    public String getId() {
        return getStateEventId().getId();
    }

    public void setId(String id) {
        getStateEventId().setId(id);
    }

    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

    private String fieldType;

    public String getFieldType()
    {
        return this.fieldType;
    }

    public void setFieldType(String fieldType)
    {
        this.fieldType = fieldType;
    }

    private Integer fieldLength;

    public Integer getFieldLength()
    {
        return this.fieldLength;
    }

    public void setFieldLength(Integer fieldLength)
    {
        this.fieldLength = fieldLength;
    }

    private Integer fieldCount;

    public Integer getFieldCount()
    {
        return this.fieldCount;
    }

    public void setFieldCount(Integer fieldCount)
    {
        this.fieldCount = fieldCount;
    }

    private String nameFormat;

    public String getNameFormat()
    {
        return this.nameFormat;
    }

    public void setNameFormat(String nameFormat)
    {
        this.nameFormat = nameFormat;
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

    protected AbstractAttributeSetInstanceExtensionFieldGroupStateEvent() {
    }

    protected AbstractAttributeSetInstanceExtensionFieldGroupStateEvent(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractAttributeSetInstanceExtensionFieldGroupStateCreated extends AbstractAttributeSetInstanceExtensionFieldGroupStateEvent implements AttributeSetInstanceExtensionFieldGroupStateEvent.AttributeSetInstanceExtensionFieldGroupStateCreated
    {
        public AbstractAttributeSetInstanceExtensionFieldGroupStateCreated() {
            this(new AttributeSetInstanceExtensionFieldGroupStateEventId());
        }

        public AbstractAttributeSetInstanceExtensionFieldGroupStateCreated(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


    public static abstract class AbstractAttributeSetInstanceExtensionFieldGroupStateMergePatched extends AbstractAttributeSetInstanceExtensionFieldGroupStateEvent implements AttributeSetInstanceExtensionFieldGroupStateEvent.AttributeSetInstanceExtensionFieldGroupStateMergePatched
    {
        public AbstractAttributeSetInstanceExtensionFieldGroupStateMergePatched() {
            this(new AttributeSetInstanceExtensionFieldGroupStateEventId());
        }

        public AbstractAttributeSetInstanceExtensionFieldGroupStateMergePatched(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.MERGE_PATCHED;
        }

        private Boolean isPropertyFieldTypeRemoved;

        public Boolean getIsPropertyFieldTypeRemoved() {
            return this.isPropertyFieldTypeRemoved;
        }

        public void setIsPropertyFieldTypeRemoved(Boolean removed) {
            this.isPropertyFieldTypeRemoved = removed;
        }

        private Boolean isPropertyFieldLengthRemoved;

        public Boolean getIsPropertyFieldLengthRemoved() {
            return this.isPropertyFieldLengthRemoved;
        }

        public void setIsPropertyFieldLengthRemoved(Boolean removed) {
            this.isPropertyFieldLengthRemoved = removed;
        }

        private Boolean isPropertyFieldCountRemoved;

        public Boolean getIsPropertyFieldCountRemoved() {
            return this.isPropertyFieldCountRemoved;
        }

        public void setIsPropertyFieldCountRemoved(Boolean removed) {
            this.isPropertyFieldCountRemoved = removed;
        }

        private Boolean isPropertyNameFormatRemoved;

        public Boolean getIsPropertyNameFormatRemoved() {
            return this.isPropertyNameFormatRemoved;
        }

        public void setIsPropertyNameFormatRemoved(Boolean removed) {
            this.isPropertyNameFormatRemoved = removed;
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


    public static abstract class AbstractAttributeSetInstanceExtensionFieldGroupStateDeleted extends AbstractAttributeSetInstanceExtensionFieldGroupStateEvent implements AttributeSetInstanceExtensionFieldGroupStateEvent.AttributeSetInstanceExtensionFieldGroupStateDeleted
    {
        public AbstractAttributeSetInstanceExtensionFieldGroupStateDeleted() {
            this(new AttributeSetInstanceExtensionFieldGroupStateEventId());
        }

        public AbstractAttributeSetInstanceExtensionFieldGroupStateDeleted(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.DELETED;
        }

    }
    public static class SimpleAttributeSetInstanceExtensionFieldGroupStateCreated extends AbstractAttributeSetInstanceExtensionFieldGroupStateCreated
    {
        public SimpleAttributeSetInstanceExtensionFieldGroupStateCreated() {
        }

        public SimpleAttributeSetInstanceExtensionFieldGroupStateCreated(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleAttributeSetInstanceExtensionFieldGroupStateMergePatched extends AbstractAttributeSetInstanceExtensionFieldGroupStateMergePatched
    {
        public SimpleAttributeSetInstanceExtensionFieldGroupStateMergePatched() {
        }

        public SimpleAttributeSetInstanceExtensionFieldGroupStateMergePatched(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleAttributeSetInstanceExtensionFieldGroupStateDeleted extends AbstractAttributeSetInstanceExtensionFieldGroupStateDeleted
    {
        public SimpleAttributeSetInstanceExtensionFieldGroupStateDeleted() {
        }

        public SimpleAttributeSetInstanceExtensionFieldGroupStateDeleted(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
            super(stateEventId);
        }
    }

}
