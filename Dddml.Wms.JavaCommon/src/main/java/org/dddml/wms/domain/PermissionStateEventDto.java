package org.dddml.wms.domain;

import java.util.Date;
import org.dddml.wms.domain.AbstractStateEvent;

public class PermissionStateEventDto extends AbstractStateEvent
{

    private PermissionStateEventIdDto stateEventId;

    PermissionStateEventIdDto getStateEventId() {
        if (stateEventId == null) { stateEventId = new PermissionStateEventIdDto(); }
        return this.stateEventId;
    }

    void setStateEventId(PermissionStateEventIdDto stateEventId) {
        this.stateEventId = stateEventId;
    }

    public String getPermissionId() {
        return getStateEventId().getPermissionId();
    }

    public void setPermissionId(String permissionId) {
        getStateEventId().setPermissionId(permissionId);
    }

    public Long getVersion() {
        return getStateEventId().getVersion();
    }
    
    public void getVersion(Long version) {
        getStateEventId().setVersion(version);
    }

    private String name;

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        this.name = name;
    }

    private String parentPermissionId;

    public String getParentPermissionId() {
        return this.parentPermissionId;
    }

    public void setParentPermissionId(String parentPermissionId) {
        this.parentPermissionId = parentPermissionId;
    }

    private String description;

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    private Boolean active;

    public Boolean getActive() {
        return this.active;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }

    private String createdBy;

    public String getCreatedBy() {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy) {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt() {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt) {
        this.createdAt = createdAt;
    }

    private Boolean isPropertyNameRemoved;

    public Boolean getIsPropertyNameRemoved() {
        return this.isPropertyNameRemoved;
    }

    public void setIsPropertyNameRemoved(Boolean removed) {
        this.isPropertyNameRemoved = removed;
    }

    private Boolean isPropertyParentPermissionIdRemoved;

    public Boolean getIsPropertyParentPermissionIdRemoved() {
        return this.isPropertyParentPermissionIdRemoved;
    }

    public void setIsPropertyParentPermissionIdRemoved(Boolean removed) {
        this.isPropertyParentPermissionIdRemoved = removed;
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


	public static class PermissionStateCreatedDto extends PermissionStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class PermissionStateMergePatchedDto extends PermissionStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class PermissionStateDeletedDto extends PermissionStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_DELETED;
        }

	}


}

