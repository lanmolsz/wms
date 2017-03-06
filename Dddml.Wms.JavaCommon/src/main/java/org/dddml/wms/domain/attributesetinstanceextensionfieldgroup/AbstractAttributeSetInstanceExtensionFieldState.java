package org.dddml.wms.domain.attributesetinstanceextensionfieldgroup;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.attributesetinstanceextensionfieldgroup.AttributeSetInstanceExtensionFieldStateEvent.*;

public abstract class AbstractAttributeSetInstanceExtensionFieldState implements AttributeSetInstanceExtensionFieldState
{

    private AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId = new AttributeSetInstanceExtensionFieldId();

    public AttributeSetInstanceExtensionFieldId getAttributeSetInstanceExtensionFieldId() {
        return this.attributeSetInstanceExtensionFieldId;
    }

    public void setAttributeSetInstanceExtensionFieldId(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId) {
        this.attributeSetInstanceExtensionFieldId = attributeSetInstanceExtensionFieldId;
    }

    public String getGroupId() {
        return this.getAttributeSetInstanceExtensionFieldId().getGroupId();
    }
        
    public void setGroupId(String groupId) {
        this.getAttributeSetInstanceExtensionFieldId().setGroupId(groupId);
    }

    public String getIndex() {
        return this.getAttributeSetInstanceExtensionFieldId().getIndex();
    }
        
    public void setIndex(String index) {
        this.getAttributeSetInstanceExtensionFieldId().setIndex(index);
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

    private String type;

    public String getType()
    {
        return this.type;
    }

    public void setType(String type)
    {
        this.type = type;
    }

    private Integer length;

    public Integer getLength()
    {
        return this.length;
    }

    public void setLength(Integer length)
    {
        this.length = length;
    }

    private String alias;

    public String getAlias()
    {
        return this.alias;
    }

    public void setAlias(String alias)
    {
        this.alias = alias;
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


    public AbstractAttributeSetInstanceExtensionFieldState() {
        this(false);
    }

    public AbstractAttributeSetInstanceExtensionFieldState(boolean forReapplying) {
        this.forReapplying = forReapplying;
        initializeProperties();
    }
    
    protected void initializeProperties() {
    }


    public void mutate(Event e) {
        setStateReadOnly(false);
        if (e instanceof AttributeSetInstanceExtensionFieldStateCreated) {
            when((AttributeSetInstanceExtensionFieldStateCreated) e);
        } else if (e instanceof AttributeSetInstanceExtensionFieldStateMergePatched) {
            when((AttributeSetInstanceExtensionFieldStateMergePatched) e);
        } else if (e instanceof AttributeSetInstanceExtensionFieldStateRemoved) {
            when((AttributeSetInstanceExtensionFieldStateRemoved) e);
        }
    }

    public void when(AttributeSetInstanceExtensionFieldStateCreated e)
    {
        throwOnWrongEvent(e);
        this.setName(e.getName());
        this.setType(e.getType());
        this.setLength(e.getLength());
        this.setAlias(e.getAlias());
        this.setDescription(e.getDescription());
        this.setActive(e.getActive());

        this.setDeleted(false);

        this.setCreatedBy(e.getCreatedBy());
        this.setCreatedAt(e.getCreatedAt());

    }

    public void when(AttributeSetInstanceExtensionFieldStateMergePatched e)
    {
        throwOnWrongEvent(e);

        if (e.getName() == null)
        {
            if (e.getIsPropertyNameRemoved() != null && e.getIsPropertyNameRemoved())
            {
                this.setName(null);
            }
        }
        else
        {
            this.setName(e.getName());
        }
        if (e.getType() == null)
        {
            if (e.getIsPropertyTypeRemoved() != null && e.getIsPropertyTypeRemoved())
            {
                this.setType(null);
            }
        }
        else
        {
            this.setType(e.getType());
        }
        if (e.getLength() == null)
        {
            if (e.getIsPropertyLengthRemoved() != null && e.getIsPropertyLengthRemoved())
            {
                this.setLength(null);
            }
        }
        else
        {
            this.setLength(e.getLength());
        }
        if (e.getAlias() == null)
        {
            if (e.getIsPropertyAliasRemoved() != null && e.getIsPropertyAliasRemoved())
            {
                this.setAlias(null);
            }
        }
        else
        {
            this.setAlias(e.getAlias());
        }
        if (e.getDescription() == null)
        {
            if (e.getIsPropertyDescriptionRemoved() != null && e.getIsPropertyDescriptionRemoved())
            {
                this.setDescription(null);
            }
        }
        else
        {
            this.setDescription(e.getDescription());
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

    public void when(AttributeSetInstanceExtensionFieldStateRemoved e)
    {
        throwOnWrongEvent(e);

        this.setDeleted(true);
        this.setUpdatedBy(e.getCreatedBy());
        this.setUpdatedAt(e.getCreatedAt());

    }

    public void save()
    {
    }

    protected void throwOnWrongEvent(AttributeSetInstanceExtensionFieldStateEvent stateEvent)
    {
        String stateEntityIdGroupId = this.getAttributeSetInstanceExtensionFieldId().getGroupId();
        String eventEntityIdGroupId = stateEvent.getStateEventId().getGroupId();
        if (!stateEntityIdGroupId.equals(eventEntityIdGroupId))
        {
            throw DomainError.named("mutateWrongEntity", "Entity Id GroupId %1$s in state but entity id GroupId %2$s in event", stateEntityIdGroupId, eventEntityIdGroupId);
        }

        String stateEntityIdIndex = this.getAttributeSetInstanceExtensionFieldId().getIndex();
        String eventEntityIdIndex = stateEvent.getStateEventId().getIndex();
        if (!stateEntityIdIndex.equals(eventEntityIdIndex))
        {
            throw DomainError.named("mutateWrongEntity", "Entity Id Index %1$s in state but entity id Index %2$s in event", stateEntityIdIndex, eventEntityIdIndex);
        }

        if (getForReapplying()) { return; }

        Long stateVersion = this.getVersion();
        Long eventVersion = stateEvent.getVersion();
        if (eventVersion == null) {
            eventVersion = stateVersion == null ? AttributeSetInstanceExtensionFieldState.VERSION_NULL : stateVersion;
            stateEvent.setVersion(eventVersion);
        }
        if (!(stateVersion == null && eventVersion.equals(AttributeSetInstanceExtensionFieldState.VERSION_NULL)) && !eventVersion.equals(stateVersion))
        {
            throw DomainError.named("concurrencyConflict", "Conflict between state version (%1$s) and event version (%2$s)", stateVersion, eventVersion);
        }

    }

    public static class SimpleAttributeSetInstanceExtensionFieldState extends AbstractAttributeSetInstanceExtensionFieldState
    {

        public SimpleAttributeSetInstanceExtensionFieldState() {
        }

        public SimpleAttributeSetInstanceExtensionFieldState(boolean forReapplying) {
            super(forReapplying);
        }

    }


}

