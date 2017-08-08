package org.dddml.wms.domain.organizationstructuretype;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractStateEvent;

public abstract class AbstractOrganizationStructureTypeStateEvent extends AbstractStateEvent implements OrganizationStructureTypeStateEvent 
{
    private OrganizationStructureTypeStateEventId stateEventId;

    public OrganizationStructureTypeStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(OrganizationStructureTypeStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }
    
    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

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

    protected AbstractOrganizationStructureTypeStateEvent() {
    }

    protected AbstractOrganizationStructureTypeStateEvent(OrganizationStructureTypeStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractOrganizationStructureTypeStateCreated extends AbstractOrganizationStructureTypeStateEvent implements OrganizationStructureTypeStateEvent.OrganizationStructureTypeStateCreated
    {
        public AbstractOrganizationStructureTypeStateCreated() {
        }

        public AbstractOrganizationStructureTypeStateCreated(OrganizationStructureTypeStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


    public static abstract class AbstractOrganizationStructureTypeStateMergePatched extends AbstractOrganizationStructureTypeStateEvent implements OrganizationStructureTypeStateEvent.OrganizationStructureTypeStateMergePatched
    {
        public AbstractOrganizationStructureTypeStateMergePatched() {
        }

        public AbstractOrganizationStructureTypeStateMergePatched(OrganizationStructureTypeStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.MERGE_PATCHED;
        }

        private Boolean isPropertyActiveRemoved;

        public Boolean getIsPropertyActiveRemoved() {
            return this.isPropertyActiveRemoved;
        }

        public void setIsPropertyActiveRemoved(Boolean removed) {
            this.isPropertyActiveRemoved = removed;
        }

    }


    public static abstract class AbstractOrganizationStructureTypeStateDeleted extends AbstractOrganizationStructureTypeStateEvent implements OrganizationStructureTypeStateEvent.OrganizationStructureTypeStateDeleted
    {
        public AbstractOrganizationStructureTypeStateDeleted() {
        }

        public AbstractOrganizationStructureTypeStateDeleted(OrganizationStructureTypeStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.DELETED;
        }

    }
    public static class SimpleOrganizationStructureTypeStateCreated extends AbstractOrganizationStructureTypeStateCreated
    {
        public SimpleOrganizationStructureTypeStateCreated() {
        }

        public SimpleOrganizationStructureTypeStateCreated(OrganizationStructureTypeStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleOrganizationStructureTypeStateMergePatched extends AbstractOrganizationStructureTypeStateMergePatched
    {
        public SimpleOrganizationStructureTypeStateMergePatched() {
        }

        public SimpleOrganizationStructureTypeStateMergePatched(OrganizationStructureTypeStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleOrganizationStructureTypeStateDeleted extends AbstractOrganizationStructureTypeStateDeleted
    {
        public SimpleOrganizationStructureTypeStateDeleted() {
        }

        public SimpleOrganizationStructureTypeStateDeleted(OrganizationStructureTypeStateEventId stateEventId) {
            super(stateEventId);
        }
    }

}

