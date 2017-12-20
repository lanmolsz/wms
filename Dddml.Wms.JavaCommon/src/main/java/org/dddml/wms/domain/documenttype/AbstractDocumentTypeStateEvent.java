package org.dddml.wms.domain.documenttype;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractStateEvent;

public abstract class AbstractDocumentTypeStateEvent extends AbstractStateEvent implements DocumentTypeStateEvent 
{
    private DocumentTypeStateEventId stateEventId;

    public DocumentTypeStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(DocumentTypeStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }
    
    public String getDocumentTypeId() {
        return getStateEventId().getDocumentTypeId();
    }

    public void setDocumentTypeId(String documentTypeId) {
        getStateEventId().setDocumentTypeId(documentTypeId);
    }

    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

    private String description;

    public String getDescription()
    {
        return this.description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    private String parentDocumentTypeId;

    public String getParentDocumentTypeId()
    {
        return this.parentDocumentTypeId;
    }

    public void setParentDocumentTypeId(String parentDocumentTypeId)
    {
        this.parentDocumentTypeId = parentDocumentTypeId;
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

    protected AbstractDocumentTypeStateEvent() {
    }

    protected AbstractDocumentTypeStateEvent(DocumentTypeStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractDocumentTypeStateCreated extends AbstractDocumentTypeStateEvent implements DocumentTypeStateEvent.DocumentTypeStateCreated
    {
        public AbstractDocumentTypeStateCreated() {
            this(new DocumentTypeStateEventId());
        }

        public AbstractDocumentTypeStateCreated(DocumentTypeStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


    public static abstract class AbstractDocumentTypeStateMergePatched extends AbstractDocumentTypeStateEvent implements DocumentTypeStateEvent.DocumentTypeStateMergePatched
    {
        public AbstractDocumentTypeStateMergePatched() {
            this(new DocumentTypeStateEventId());
        }

        public AbstractDocumentTypeStateMergePatched(DocumentTypeStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.MERGE_PATCHED;
        }

        private Boolean isPropertyDescriptionRemoved;

        public Boolean getIsPropertyDescriptionRemoved() {
            return this.isPropertyDescriptionRemoved;
        }

        public void setIsPropertyDescriptionRemoved(Boolean removed) {
            this.isPropertyDescriptionRemoved = removed;
        }

        private Boolean isPropertyParentDocumentTypeIdRemoved;

        public Boolean getIsPropertyParentDocumentTypeIdRemoved() {
            return this.isPropertyParentDocumentTypeIdRemoved;
        }

        public void setIsPropertyParentDocumentTypeIdRemoved(Boolean removed) {
            this.isPropertyParentDocumentTypeIdRemoved = removed;
        }

        private Boolean isPropertyActiveRemoved;

        public Boolean getIsPropertyActiveRemoved() {
            return this.isPropertyActiveRemoved;
        }

        public void setIsPropertyActiveRemoved(Boolean removed) {
            this.isPropertyActiveRemoved = removed;
        }

    }


    public static abstract class AbstractDocumentTypeStateDeleted extends AbstractDocumentTypeStateEvent implements DocumentTypeStateEvent.DocumentTypeStateDeleted
    {
        public AbstractDocumentTypeStateDeleted() {
            this(new DocumentTypeStateEventId());
        }

        public AbstractDocumentTypeStateDeleted(DocumentTypeStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.DELETED;
        }

    }
    public static class SimpleDocumentTypeStateCreated extends AbstractDocumentTypeStateCreated
    {
        public SimpleDocumentTypeStateCreated() {
        }

        public SimpleDocumentTypeStateCreated(DocumentTypeStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleDocumentTypeStateMergePatched extends AbstractDocumentTypeStateMergePatched
    {
        public SimpleDocumentTypeStateMergePatched() {
        }

        public SimpleDocumentTypeStateMergePatched(DocumentTypeStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleDocumentTypeStateDeleted extends AbstractDocumentTypeStateDeleted
    {
        public SimpleDocumentTypeStateDeleted() {
        }

        public SimpleDocumentTypeStateDeleted(DocumentTypeStateEventId stateEventId) {
            super(stateEventId);
        }
    }

}

