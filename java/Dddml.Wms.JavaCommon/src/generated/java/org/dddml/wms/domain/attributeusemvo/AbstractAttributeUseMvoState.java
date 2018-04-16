package org.dddml.wms.domain.attributeusemvo;

import java.util.*;
import org.dddml.wms.domain.attributeset.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.attributeusemvo.AttributeUseMvoEvent.*;

public abstract class AbstractAttributeUseMvoState implements AttributeUseMvoState
{

    private AttributeSetAttributeUseId attributeSetAttributeUseId;

    public AttributeSetAttributeUseId getAttributeSetAttributeUseId()
    {
        return this.attributeSetAttributeUseId;
    }

    public void setAttributeSetAttributeUseId(AttributeSetAttributeUseId attributeSetAttributeUseId)
    {
        this.attributeSetAttributeUseId = attributeSetAttributeUseId;
    }

    private Integer sequenceNumber;

    public Integer getSequenceNumber()
    {
        return this.sequenceNumber;
    }

    public void setSequenceNumber(Integer sequenceNumber)
    {
        this.sequenceNumber = sequenceNumber;
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

    private String attributeSetAttributeSetName;

    public String getAttributeSetAttributeSetName()
    {
        return this.attributeSetAttributeSetName;
    }

    public void setAttributeSetAttributeSetName(String attributeSetAttributeSetName)
    {
        this.attributeSetAttributeSetName = attributeSetAttributeSetName;
    }

    private String attributeSetOrganizationId;

    public String getAttributeSetOrganizationId()
    {
        return this.attributeSetOrganizationId;
    }

    public void setAttributeSetOrganizationId(String attributeSetOrganizationId)
    {
        this.attributeSetOrganizationId = attributeSetOrganizationId;
    }

    private String attributeSetDescription;

    public String getAttributeSetDescription()
    {
        return this.attributeSetDescription;
    }

    public void setAttributeSetDescription(String attributeSetDescription)
    {
        this.attributeSetDescription = attributeSetDescription;
    }

    private String attributeSetReferenceId;

    public String getAttributeSetReferenceId()
    {
        return this.attributeSetReferenceId;
    }

    public void setAttributeSetReferenceId(String attributeSetReferenceId)
    {
        this.attributeSetReferenceId = attributeSetReferenceId;
    }

    private Boolean attributeSetIsInstanceAttributeSet;

    public Boolean getAttributeSetIsInstanceAttributeSet()
    {
        return this.attributeSetIsInstanceAttributeSet;
    }

    public void setAttributeSetIsInstanceAttributeSet(Boolean attributeSetIsInstanceAttributeSet)
    {
        this.attributeSetIsInstanceAttributeSet = attributeSetIsInstanceAttributeSet;
    }

    private Boolean attributeSetIsMandatory;

    public Boolean getAttributeSetIsMandatory()
    {
        return this.attributeSetIsMandatory;
    }

    public void setAttributeSetIsMandatory(Boolean attributeSetIsMandatory)
    {
        this.attributeSetIsMandatory = attributeSetIsMandatory;
    }

    private Long attributeSetVersion;

    public Long getAttributeSetVersion()
    {
        return this.attributeSetVersion;
    }

    public void setAttributeSetVersion(Long attributeSetVersion)
    {
        this.attributeSetVersion = attributeSetVersion;
    }

    private String attributeSetCreatedBy;

    public String getAttributeSetCreatedBy()
    {
        return this.attributeSetCreatedBy;
    }

    public void setAttributeSetCreatedBy(String attributeSetCreatedBy)
    {
        this.attributeSetCreatedBy = attributeSetCreatedBy;
    }

    private Date attributeSetCreatedAt;

    public Date getAttributeSetCreatedAt()
    {
        return this.attributeSetCreatedAt;
    }

    public void setAttributeSetCreatedAt(Date attributeSetCreatedAt)
    {
        this.attributeSetCreatedAt = attributeSetCreatedAt;
    }

    private String attributeSetUpdatedBy;

    public String getAttributeSetUpdatedBy()
    {
        return this.attributeSetUpdatedBy;
    }

    public void setAttributeSetUpdatedBy(String attributeSetUpdatedBy)
    {
        this.attributeSetUpdatedBy = attributeSetUpdatedBy;
    }

    private Date attributeSetUpdatedAt;

    public Date getAttributeSetUpdatedAt()
    {
        return this.attributeSetUpdatedAt;
    }

    public void setAttributeSetUpdatedAt(Date attributeSetUpdatedAt)
    {
        this.attributeSetUpdatedAt = attributeSetUpdatedAt;
    }

    private Boolean attributeSetActive;

    public Boolean getAttributeSetActive()
    {
        return this.attributeSetActive;
    }

    public void setAttributeSetActive(Boolean attributeSetActive)
    {
        this.attributeSetActive = attributeSetActive;
    }

    private Boolean attributeSetDeleted;

    public Boolean getAttributeSetDeleted()
    {
        return this.attributeSetDeleted;
    }

    public void setAttributeSetDeleted(Boolean attributeSetDeleted)
    {
        this.attributeSetDeleted = attributeSetDeleted;
    }

    public boolean isStateUnsaved() 
    {
        return this.getAttributeSetVersion() == null;
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

    public AbstractAttributeUseMvoState(List<Event> events) {
        this(true);
        if (events != null && events.size() > 0) {
            this.setAttributeSetAttributeUseId(((AttributeUseMvoEvent) events.get(0)).getAttributeUseMvoEventId().getAttributeSetAttributeUseId());
            for (Event e : events) {
                mutate(e);
                this.setAttributeSetVersion(this.getAttributeSetVersion() + 1);
            }
        }
    }


    public AbstractAttributeUseMvoState() {
        this(false);
    }

    public AbstractAttributeUseMvoState(boolean forReapplying) {
        this.forReapplying = forReapplying;

        initializeProperties();
    }
    
    protected void initializeProperties() {
    }


    public void mutate(Event e) {
        setStateReadOnly(false);
        if (e instanceof AttributeUseMvoStateCreated) {
            when((AttributeUseMvoStateCreated) e);
        } else if (e instanceof AttributeUseMvoStateMergePatched) {
            when((AttributeUseMvoStateMergePatched) e);
        } else if (e instanceof AttributeUseMvoStateDeleted) {
            when((AttributeUseMvoStateDeleted) e);
        } else {
            throw new UnsupportedOperationException(String.format("Unsupported event type: %1$s", e.getClass().getName()));
        }
    }

    public void when(AttributeUseMvoStateCreated e)
    {
        throwOnWrongEvent(e);

        this.setSequenceNumber(e.getSequenceNumber());
        this.setVersion(e.getVersion());
        this.setActive(e.getActive());
        this.setAttributeSetAttributeSetName(e.getAttributeSetAttributeSetName());
        this.setAttributeSetOrganizationId(e.getAttributeSetOrganizationId());
        this.setAttributeSetDescription(e.getAttributeSetDescription());
        this.setAttributeSetReferenceId(e.getAttributeSetReferenceId());
        this.setAttributeSetIsInstanceAttributeSet(e.getAttributeSetIsInstanceAttributeSet());
        this.setAttributeSetIsMandatory(e.getAttributeSetIsMandatory());
        this.setAttributeSetCreatedBy(e.getAttributeSetCreatedBy());
        this.setAttributeSetCreatedAt(e.getAttributeSetCreatedAt());
        this.setAttributeSetUpdatedBy(e.getAttributeSetUpdatedBy());
        this.setAttributeSetUpdatedAt(e.getAttributeSetUpdatedAt());
        this.setAttributeSetActive(e.getAttributeSetActive());
        this.setAttributeSetDeleted(e.getAttributeSetDeleted());

        this.setDeleted(false);

        this.setCreatedBy(e.getCreatedBy());
        this.setCreatedAt(e.getCreatedAt());

    }

    public void when(AttributeUseMvoStateMergePatched e)
    {
        throwOnWrongEvent(e);

        if (e.getSequenceNumber() == null)
        {
            if (e.getIsPropertySequenceNumberRemoved() != null && e.getIsPropertySequenceNumberRemoved())
            {
                this.setSequenceNumber(null);
            }
        }
        else
        {
            this.setSequenceNumber(e.getSequenceNumber());
        }
        if (e.getVersion() == null)
        {
            if (e.getIsPropertyVersionRemoved() != null && e.getIsPropertyVersionRemoved())
            {
                this.setVersion(null);
            }
        }
        else
        {
            this.setVersion(e.getVersion());
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
        if (e.getAttributeSetAttributeSetName() == null)
        {
            if (e.getIsPropertyAttributeSetAttributeSetNameRemoved() != null && e.getIsPropertyAttributeSetAttributeSetNameRemoved())
            {
                this.setAttributeSetAttributeSetName(null);
            }
        }
        else
        {
            this.setAttributeSetAttributeSetName(e.getAttributeSetAttributeSetName());
        }
        if (e.getAttributeSetOrganizationId() == null)
        {
            if (e.getIsPropertyAttributeSetOrganizationIdRemoved() != null && e.getIsPropertyAttributeSetOrganizationIdRemoved())
            {
                this.setAttributeSetOrganizationId(null);
            }
        }
        else
        {
            this.setAttributeSetOrganizationId(e.getAttributeSetOrganizationId());
        }
        if (e.getAttributeSetDescription() == null)
        {
            if (e.getIsPropertyAttributeSetDescriptionRemoved() != null && e.getIsPropertyAttributeSetDescriptionRemoved())
            {
                this.setAttributeSetDescription(null);
            }
        }
        else
        {
            this.setAttributeSetDescription(e.getAttributeSetDescription());
        }
        if (e.getAttributeSetReferenceId() == null)
        {
            if (e.getIsPropertyAttributeSetReferenceIdRemoved() != null && e.getIsPropertyAttributeSetReferenceIdRemoved())
            {
                this.setAttributeSetReferenceId(null);
            }
        }
        else
        {
            this.setAttributeSetReferenceId(e.getAttributeSetReferenceId());
        }
        if (e.getAttributeSetIsInstanceAttributeSet() == null)
        {
            if (e.getIsPropertyAttributeSetIsInstanceAttributeSetRemoved() != null && e.getIsPropertyAttributeSetIsInstanceAttributeSetRemoved())
            {
                this.setAttributeSetIsInstanceAttributeSet(null);
            }
        }
        else
        {
            this.setAttributeSetIsInstanceAttributeSet(e.getAttributeSetIsInstanceAttributeSet());
        }
        if (e.getAttributeSetIsMandatory() == null)
        {
            if (e.getIsPropertyAttributeSetIsMandatoryRemoved() != null && e.getIsPropertyAttributeSetIsMandatoryRemoved())
            {
                this.setAttributeSetIsMandatory(null);
            }
        }
        else
        {
            this.setAttributeSetIsMandatory(e.getAttributeSetIsMandatory());
        }
        if (e.getAttributeSetCreatedBy() == null)
        {
            if (e.getIsPropertyAttributeSetCreatedByRemoved() != null && e.getIsPropertyAttributeSetCreatedByRemoved())
            {
                this.setAttributeSetCreatedBy(null);
            }
        }
        else
        {
            this.setAttributeSetCreatedBy(e.getAttributeSetCreatedBy());
        }
        if (e.getAttributeSetCreatedAt() == null)
        {
            if (e.getIsPropertyAttributeSetCreatedAtRemoved() != null && e.getIsPropertyAttributeSetCreatedAtRemoved())
            {
                this.setAttributeSetCreatedAt(null);
            }
        }
        else
        {
            this.setAttributeSetCreatedAt(e.getAttributeSetCreatedAt());
        }
        if (e.getAttributeSetUpdatedBy() == null)
        {
            if (e.getIsPropertyAttributeSetUpdatedByRemoved() != null && e.getIsPropertyAttributeSetUpdatedByRemoved())
            {
                this.setAttributeSetUpdatedBy(null);
            }
        }
        else
        {
            this.setAttributeSetUpdatedBy(e.getAttributeSetUpdatedBy());
        }
        if (e.getAttributeSetUpdatedAt() == null)
        {
            if (e.getIsPropertyAttributeSetUpdatedAtRemoved() != null && e.getIsPropertyAttributeSetUpdatedAtRemoved())
            {
                this.setAttributeSetUpdatedAt(null);
            }
        }
        else
        {
            this.setAttributeSetUpdatedAt(e.getAttributeSetUpdatedAt());
        }
        if (e.getAttributeSetActive() == null)
        {
            if (e.getIsPropertyAttributeSetActiveRemoved() != null && e.getIsPropertyAttributeSetActiveRemoved())
            {
                this.setAttributeSetActive(null);
            }
        }
        else
        {
            this.setAttributeSetActive(e.getAttributeSetActive());
        }
        if (e.getAttributeSetDeleted() == null)
        {
            if (e.getIsPropertyAttributeSetDeletedRemoved() != null && e.getIsPropertyAttributeSetDeletedRemoved())
            {
                this.setAttributeSetDeleted(null);
            }
        }
        else
        {
            this.setAttributeSetDeleted(e.getAttributeSetDeleted());
        }

        this.setUpdatedBy(e.getCreatedBy());
        this.setUpdatedAt(e.getCreatedAt());

    }

    public void when(AttributeUseMvoStateDeleted e)
    {
        throwOnWrongEvent(e);

        this.setDeleted(true);
        this.setUpdatedBy(e.getCreatedBy());
        this.setUpdatedAt(e.getCreatedAt());

    }

    public void save()
    {
    }

    protected void throwOnWrongEvent(AttributeUseMvoEvent event)
    {
        AttributeSetAttributeUseId stateEntityId = this.getAttributeSetAttributeUseId(); // Aggregate Id
        AttributeSetAttributeUseId eventEntityId = event.getAttributeUseMvoEventId().getAttributeSetAttributeUseId(); // EntityBase.Aggregate.GetEventIdPropertyIdName();
        if (!stateEntityId.equals(eventEntityId))
        {
            throw DomainError.named("mutateWrongEntity", "Entity Id %1$s in state but entity id %2$s in event", stateEntityId, eventEntityId);
        }

        Long stateVersion = this.getAttributeSetVersion();
        Long eventVersion = event.getAttributeUseMvoEventId().getAttributeSetVersion();// Aggregate Version
        if (eventVersion == null) {
            throw new NullPointerException("event.getAttributeUseMvoEventId().getAttributeSetVersion() == null");
        }
        if (!(stateVersion == null && eventVersion.equals(AttributeUseMvoState.VERSION_NULL)) && !eventVersion.equals(stateVersion))
        {
            throw DomainError.named("concurrencyConflict", "Conflict between state version (%1$s) and event version (%2$s)", stateVersion, eventVersion);
        }

    }

    public static class SimpleAttributeUseMvoState extends AbstractAttributeUseMvoState
    {

        public SimpleAttributeUseMvoState() {
        }

        public SimpleAttributeUseMvoState(boolean forReapplying) {
            super(forReapplying);
        }

        public SimpleAttributeUseMvoState(List<Event> events) {
            super(events);
        }

    }


}

