package org.dddml.wms.domain.attributealiasmvo;

import java.util.*;
import org.dddml.wms.domain.attribute.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.attributealiasmvo.AttributeAliasMvoEvent.*;

public abstract class AbstractAttributeAliasMvoState implements AttributeAliasMvoState
{

    private AttributeAliasId attributeAliasId;

    public AttributeAliasId getAttributeAliasId()
    {
        return this.attributeAliasId;
    }

    public void setAttributeAliasId(AttributeAliasId attributeAliasId)
    {
        this.attributeAliasId = attributeAliasId;
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

    private String attributeAttributeName;

    public String getAttributeAttributeName()
    {
        return this.attributeAttributeName;
    }

    public void setAttributeAttributeName(String attributeAttributeName)
    {
        this.attributeAttributeName = attributeAttributeName;
    }

    private String attributeOrganizationId;

    public String getAttributeOrganizationId()
    {
        return this.attributeOrganizationId;
    }

    public void setAttributeOrganizationId(String attributeOrganizationId)
    {
        this.attributeOrganizationId = attributeOrganizationId;
    }

    private String attributeDescription;

    public String getAttributeDescription()
    {
        return this.attributeDescription;
    }

    public void setAttributeDescription(String attributeDescription)
    {
        this.attributeDescription = attributeDescription;
    }

    private Boolean attributeIsMandatory;

    public Boolean getAttributeIsMandatory()
    {
        return this.attributeIsMandatory;
    }

    public void setAttributeIsMandatory(Boolean attributeIsMandatory)
    {
        this.attributeIsMandatory = attributeIsMandatory;
    }

    private String attributeAttributeValueType;

    public String getAttributeAttributeValueType()
    {
        return this.attributeAttributeValueType;
    }

    public void setAttributeAttributeValueType(String attributeAttributeValueType)
    {
        this.attributeAttributeValueType = attributeAttributeValueType;
    }

    private Integer attributeAttributeValueLength;

    public Integer getAttributeAttributeValueLength()
    {
        return this.attributeAttributeValueLength;
    }

    public void setAttributeAttributeValueLength(Integer attributeAttributeValueLength)
    {
        this.attributeAttributeValueLength = attributeAttributeValueLength;
    }

    private Boolean attributeIsList;

    public Boolean getAttributeIsList()
    {
        return this.attributeIsList;
    }

    public void setAttributeIsList(Boolean attributeIsList)
    {
        this.attributeIsList = attributeIsList;
    }

    private String attributeFieldName;

    public String getAttributeFieldName()
    {
        return this.attributeFieldName;
    }

    public void setAttributeFieldName(String attributeFieldName)
    {
        this.attributeFieldName = attributeFieldName;
    }

    private String attributeReferenceId;

    public String getAttributeReferenceId()
    {
        return this.attributeReferenceId;
    }

    public void setAttributeReferenceId(String attributeReferenceId)
    {
        this.attributeReferenceId = attributeReferenceId;
    }

    private Long attributeVersion;

    public Long getAttributeVersion()
    {
        return this.attributeVersion;
    }

    public void setAttributeVersion(Long attributeVersion)
    {
        this.attributeVersion = attributeVersion;
    }

    private String attributeCreatedBy;

    public String getAttributeCreatedBy()
    {
        return this.attributeCreatedBy;
    }

    public void setAttributeCreatedBy(String attributeCreatedBy)
    {
        this.attributeCreatedBy = attributeCreatedBy;
    }

    private Date attributeCreatedAt;

    public Date getAttributeCreatedAt()
    {
        return this.attributeCreatedAt;
    }

    public void setAttributeCreatedAt(Date attributeCreatedAt)
    {
        this.attributeCreatedAt = attributeCreatedAt;
    }

    private String attributeUpdatedBy;

    public String getAttributeUpdatedBy()
    {
        return this.attributeUpdatedBy;
    }

    public void setAttributeUpdatedBy(String attributeUpdatedBy)
    {
        this.attributeUpdatedBy = attributeUpdatedBy;
    }

    private Date attributeUpdatedAt;

    public Date getAttributeUpdatedAt()
    {
        return this.attributeUpdatedAt;
    }

    public void setAttributeUpdatedAt(Date attributeUpdatedAt)
    {
        this.attributeUpdatedAt = attributeUpdatedAt;
    }

    private Boolean attributeActive;

    public Boolean getAttributeActive()
    {
        return this.attributeActive;
    }

    public void setAttributeActive(Boolean attributeActive)
    {
        this.attributeActive = attributeActive;
    }

    private Boolean attributeDeleted;

    public Boolean getAttributeDeleted()
    {
        return this.attributeDeleted;
    }

    public void setAttributeDeleted(Boolean attributeDeleted)
    {
        this.attributeDeleted = attributeDeleted;
    }

    public boolean isStateUnsaved() 
    {
        return this.getAttributeVersion() == null;
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

    public AbstractAttributeAliasMvoState(List<Event> events) {
        this(true);
        if (events != null && events.size() > 0) {
            this.setAttributeAliasId(((AttributeAliasMvoEvent) events.get(0)).getAttributeAliasMvoEventId().getAttributeAliasId());
            for (Event e : events) {
                mutate(e);
                this.setAttributeVersion(this.getAttributeVersion() + 1);
            }
        }
    }


    public AbstractAttributeAliasMvoState() {
        this(false);
    }

    public AbstractAttributeAliasMvoState(boolean forReapplying) {
        this.forReapplying = forReapplying;

        initializeProperties();
    }
    
    protected void initializeProperties() {
    }


    public void mutate(Event e) {
        setStateReadOnly(false);
        if (e instanceof AttributeAliasMvoStateCreated) {
            when((AttributeAliasMvoStateCreated) e);
        } else if (e instanceof AttributeAliasMvoStateMergePatched) {
            when((AttributeAliasMvoStateMergePatched) e);
        } else if (e instanceof AttributeAliasMvoStateDeleted) {
            when((AttributeAliasMvoStateDeleted) e);
        } else {
            throw new UnsupportedOperationException(String.format("Unsupported event type: %1$s", e.getClass().getName()));
        }
    }

    public void when(AttributeAliasMvoStateCreated e)
    {
        throwOnWrongEvent(e);

        this.setName(e.getName());
        this.setVersion(e.getVersion());
        this.setActive(e.getActive());
        this.setAttributeAttributeName(e.getAttributeAttributeName());
        this.setAttributeOrganizationId(e.getAttributeOrganizationId());
        this.setAttributeDescription(e.getAttributeDescription());
        this.setAttributeIsMandatory(e.getAttributeIsMandatory());
        this.setAttributeAttributeValueType(e.getAttributeAttributeValueType());
        this.setAttributeAttributeValueLength(e.getAttributeAttributeValueLength());
        this.setAttributeIsList(e.getAttributeIsList());
        this.setAttributeFieldName(e.getAttributeFieldName());
        this.setAttributeReferenceId(e.getAttributeReferenceId());
        this.setAttributeCreatedBy(e.getAttributeCreatedBy());
        this.setAttributeCreatedAt(e.getAttributeCreatedAt());
        this.setAttributeUpdatedBy(e.getAttributeUpdatedBy());
        this.setAttributeUpdatedAt(e.getAttributeUpdatedAt());
        this.setAttributeActive(e.getAttributeActive());
        this.setAttributeDeleted(e.getAttributeDeleted());

        this.setDeleted(false);

        this.setCreatedBy(e.getCreatedBy());
        this.setCreatedAt(e.getCreatedAt());

    }

    public void when(AttributeAliasMvoStateMergePatched e)
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
        if (e.getAttributeAttributeName() == null)
        {
            if (e.getIsPropertyAttributeAttributeNameRemoved() != null && e.getIsPropertyAttributeAttributeNameRemoved())
            {
                this.setAttributeAttributeName(null);
            }
        }
        else
        {
            this.setAttributeAttributeName(e.getAttributeAttributeName());
        }
        if (e.getAttributeOrganizationId() == null)
        {
            if (e.getIsPropertyAttributeOrganizationIdRemoved() != null && e.getIsPropertyAttributeOrganizationIdRemoved())
            {
                this.setAttributeOrganizationId(null);
            }
        }
        else
        {
            this.setAttributeOrganizationId(e.getAttributeOrganizationId());
        }
        if (e.getAttributeDescription() == null)
        {
            if (e.getIsPropertyAttributeDescriptionRemoved() != null && e.getIsPropertyAttributeDescriptionRemoved())
            {
                this.setAttributeDescription(null);
            }
        }
        else
        {
            this.setAttributeDescription(e.getAttributeDescription());
        }
        if (e.getAttributeIsMandatory() == null)
        {
            if (e.getIsPropertyAttributeIsMandatoryRemoved() != null && e.getIsPropertyAttributeIsMandatoryRemoved())
            {
                this.setAttributeIsMandatory(null);
            }
        }
        else
        {
            this.setAttributeIsMandatory(e.getAttributeIsMandatory());
        }
        if (e.getAttributeAttributeValueType() == null)
        {
            if (e.getIsPropertyAttributeAttributeValueTypeRemoved() != null && e.getIsPropertyAttributeAttributeValueTypeRemoved())
            {
                this.setAttributeAttributeValueType(null);
            }
        }
        else
        {
            this.setAttributeAttributeValueType(e.getAttributeAttributeValueType());
        }
        if (e.getAttributeAttributeValueLength() == null)
        {
            if (e.getIsPropertyAttributeAttributeValueLengthRemoved() != null && e.getIsPropertyAttributeAttributeValueLengthRemoved())
            {
                this.setAttributeAttributeValueLength(null);
            }
        }
        else
        {
            this.setAttributeAttributeValueLength(e.getAttributeAttributeValueLength());
        }
        if (e.getAttributeIsList() == null)
        {
            if (e.getIsPropertyAttributeIsListRemoved() != null && e.getIsPropertyAttributeIsListRemoved())
            {
                this.setAttributeIsList(null);
            }
        }
        else
        {
            this.setAttributeIsList(e.getAttributeIsList());
        }
        if (e.getAttributeFieldName() == null)
        {
            if (e.getIsPropertyAttributeFieldNameRemoved() != null && e.getIsPropertyAttributeFieldNameRemoved())
            {
                this.setAttributeFieldName(null);
            }
        }
        else
        {
            this.setAttributeFieldName(e.getAttributeFieldName());
        }
        if (e.getAttributeReferenceId() == null)
        {
            if (e.getIsPropertyAttributeReferenceIdRemoved() != null && e.getIsPropertyAttributeReferenceIdRemoved())
            {
                this.setAttributeReferenceId(null);
            }
        }
        else
        {
            this.setAttributeReferenceId(e.getAttributeReferenceId());
        }
        if (e.getAttributeCreatedBy() == null)
        {
            if (e.getIsPropertyAttributeCreatedByRemoved() != null && e.getIsPropertyAttributeCreatedByRemoved())
            {
                this.setAttributeCreatedBy(null);
            }
        }
        else
        {
            this.setAttributeCreatedBy(e.getAttributeCreatedBy());
        }
        if (e.getAttributeCreatedAt() == null)
        {
            if (e.getIsPropertyAttributeCreatedAtRemoved() != null && e.getIsPropertyAttributeCreatedAtRemoved())
            {
                this.setAttributeCreatedAt(null);
            }
        }
        else
        {
            this.setAttributeCreatedAt(e.getAttributeCreatedAt());
        }
        if (e.getAttributeUpdatedBy() == null)
        {
            if (e.getIsPropertyAttributeUpdatedByRemoved() != null && e.getIsPropertyAttributeUpdatedByRemoved())
            {
                this.setAttributeUpdatedBy(null);
            }
        }
        else
        {
            this.setAttributeUpdatedBy(e.getAttributeUpdatedBy());
        }
        if (e.getAttributeUpdatedAt() == null)
        {
            if (e.getIsPropertyAttributeUpdatedAtRemoved() != null && e.getIsPropertyAttributeUpdatedAtRemoved())
            {
                this.setAttributeUpdatedAt(null);
            }
        }
        else
        {
            this.setAttributeUpdatedAt(e.getAttributeUpdatedAt());
        }
        if (e.getAttributeActive() == null)
        {
            if (e.getIsPropertyAttributeActiveRemoved() != null && e.getIsPropertyAttributeActiveRemoved())
            {
                this.setAttributeActive(null);
            }
        }
        else
        {
            this.setAttributeActive(e.getAttributeActive());
        }
        if (e.getAttributeDeleted() == null)
        {
            if (e.getIsPropertyAttributeDeletedRemoved() != null && e.getIsPropertyAttributeDeletedRemoved())
            {
                this.setAttributeDeleted(null);
            }
        }
        else
        {
            this.setAttributeDeleted(e.getAttributeDeleted());
        }

        this.setUpdatedBy(e.getCreatedBy());
        this.setUpdatedAt(e.getCreatedAt());

    }

    public void when(AttributeAliasMvoStateDeleted e)
    {
        throwOnWrongEvent(e);

        this.setDeleted(true);
        this.setUpdatedBy(e.getCreatedBy());
        this.setUpdatedAt(e.getCreatedAt());

    }

    public void save()
    {
    }

    protected void throwOnWrongEvent(AttributeAliasMvoEvent event)
    {
        AttributeAliasId stateEntityId = this.getAttributeAliasId(); // Aggregate Id
        AttributeAliasId eventEntityId = event.getAttributeAliasMvoEventId().getAttributeAliasId(); // EntityBase.Aggregate.GetEventIdPropertyIdName();
        if (!stateEntityId.equals(eventEntityId))
        {
            throw DomainError.named("mutateWrongEntity", "Entity Id %1$s in state but entity id %2$s in event", stateEntityId, eventEntityId);
        }

        Long stateVersion = this.getAttributeVersion();
        Long eventVersion = event.getAttributeAliasMvoEventId().getAttributeVersion();// Aggregate Version
        if (eventVersion == null) {
            throw new NullPointerException("event.getAttributeAliasMvoEventId().getAttributeVersion() == null");
        }
        if (!(stateVersion == null && eventVersion.equals(AttributeAliasMvoState.VERSION_NULL)) && !eventVersion.equals(stateVersion))
        {
            throw DomainError.named("concurrencyConflict", "Conflict between state version (%1$s) and event version (%2$s)", stateVersion, eventVersion);
        }

    }

    public static class SimpleAttributeAliasMvoState extends AbstractAttributeAliasMvoState
    {

        public SimpleAttributeAliasMvoState() {
        }

        public SimpleAttributeAliasMvoState(boolean forReapplying) {
            super(forReapplying);
        }

        public SimpleAttributeAliasMvoState(List<Event> events) {
            super(events);
        }

    }


}

