package org.dddml.wms.domain;

import java.util.*;
import java.util.Date;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.UserPermissionStateEvent.*;

public abstract class AbstractUserPermissionState implements UserPermissionState
{

    private UserPermissionId userPermissionId = new UserPermissionId();

    public UserPermissionId getUserPermissionId() {
        return this.userPermissionId;
    }

    public void setUserPermissionId(UserPermissionId userPermissionId) {
        this.userPermissionId = userPermissionId;
    }

    public String getUserId() {
        return this.getUserPermissionId().getUserId();
    }
        
    public void setUserId(String userId) {
        this.getUserPermissionId().setUserId(userId);
    }

    public String getPermissionId() {
        return this.getUserPermissionId().getPermissionId();
    }
        
    public void setPermissionId(String permissionId) {
        this.getUserPermissionId().setPermissionId(permissionId);
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


    public AbstractUserPermissionState() {
        this(false);
    }

    public AbstractUserPermissionState(boolean forReapplying) {
        this.forReapplying = forReapplying;
        initializeProperties();
    }
    
    protected void initializeProperties() {
    }


    public void mutate(Event e) {
        setStateReadOnly(false);
        if (e instanceof UserPermissionStateCreated) {
            when((UserPermissionStateCreated) e);
        } else if (e instanceof UserPermissionStateMergePatched) {
            when((UserPermissionStateMergePatched) e);
        } else if (e instanceof UserPermissionStateRemoved) {
            when((UserPermissionStateRemoved) e);
        }
    }

    public void when(UserPermissionStateCreated e)
    {
        throwOnWrongEvent(e);
        this.setActive(e.getActive());

        this.setDeleted(false);

        this.setCreatedBy(e.getCreatedBy());
        this.setCreatedAt(e.getCreatedAt());

    }

    public void when(UserPermissionStateMergePatched e)
    {
        throwOnWrongEvent(e);

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

    public void when(UserPermissionStateRemoved e)
    {
        throwOnWrongEvent(e);

        this.setDeleted(true);
        this.setUpdatedBy(e.getCreatedBy());
        this.setUpdatedAt(e.getCreatedAt());

    }

    public void save()
    {
    }

    protected void throwOnWrongEvent(UserPermissionStateEvent stateEvent)
    {
        String stateEntityIdUserId = this.getUserPermissionId().getUserId();
        String eventEntityIdUserId = stateEvent.getStateEventId().getUserId();
        if (!stateEntityIdUserId.equals(eventEntityIdUserId))
        {
            throw DomainError.named("mutateWrongEntity", "Entity Id UserId %1$s in state but entity id UserId %2$s in event", stateEntityIdUserId, eventEntityIdUserId);
        }

        String stateEntityIdPermissionId = this.getUserPermissionId().getPermissionId();
        String eventEntityIdPermissionId = stateEvent.getStateEventId().getPermissionId();
        if (!stateEntityIdPermissionId.equals(eventEntityIdPermissionId))
        {
            throw DomainError.named("mutateWrongEntity", "Entity Id PermissionId %1$s in state but entity id PermissionId %2$s in event", stateEntityIdPermissionId, eventEntityIdPermissionId);
        }

        if (getForReapplying()) { return; }

        Long stateVersion = this.getVersion();
        Long eventVersion = stateEvent.getVersion();
        if (eventVersion == null) {
            eventVersion = stateVersion == null ? UserPermissionState.VERSION_NULL : stateVersion;
            stateEvent.setVersion(eventVersion);
        }
        if (!(stateVersion == null && eventVersion.equals(UserPermissionState.VERSION_NULL)) && !eventVersion.equals(stateVersion))
        {
            throw DomainError.named("concurrencyConflict", "Conflict between state version (%1$s) and event version (%2$s)", stateVersion, eventVersion);
        }

    }

    public static class SimpleUserPermissionState extends AbstractUserPermissionState
    {

        public SimpleUserPermissionState() {
        }

        public SimpleUserPermissionState(boolean forReapplying) {
            super(forReapplying);
        }

    }


}

