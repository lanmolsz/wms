package org.dddml.wms.domain.movementconfirmation;

import java.util.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.movementconfirmation.MovementConfirmationLineStateEvent.*;

public abstract class AbstractMovementConfirmationLineState implements MovementConfirmationLineState
{

    private MovementConfirmationLineId movementConfirmationLineId = new MovementConfirmationLineId();

    public MovementConfirmationLineId getMovementConfirmationLineId() {
        return this.movementConfirmationLineId;
    }

    public void setMovementConfirmationLineId(MovementConfirmationLineId movementConfirmationLineId) {
        this.movementConfirmationLineId = movementConfirmationLineId;
    }

    public String getMovementConfirmationDocumentNumber() {
        return this.getMovementConfirmationLineId().getMovementConfirmationDocumentNumber();
    }
        
    public void setMovementConfirmationDocumentNumber(String movementConfirmationDocumentNumber) {
        this.getMovementConfirmationLineId().setMovementConfirmationDocumentNumber(movementConfirmationDocumentNumber);
    }

    public String getLineNumber() {
        return this.getMovementConfirmationLineId().getLineNumber();
    }
        
    public void setLineNumber(String lineNumber) {
        this.getMovementConfirmationLineId().setLineNumber(lineNumber);
    }

    private String movementLineNumber;

    public String getMovementLineNumber()
    {
        return this.movementLineNumber;
    }

    public void setMovementLineNumber(String movementLineNumber)
    {
        this.movementLineNumber = movementLineNumber;
    }

    private BigDecimal targetQuantity;

    public BigDecimal getTargetQuantity()
    {
        return this.targetQuantity;
    }

    public void setTargetQuantity(BigDecimal targetQuantity)
    {
        this.targetQuantity = targetQuantity;
    }

    private BigDecimal confirmedQuantity;

    public BigDecimal getConfirmedQuantity()
    {
        return this.confirmedQuantity;
    }

    public void setConfirmedQuantity(BigDecimal confirmedQuantity)
    {
        this.confirmedQuantity = confirmedQuantity;
    }

    private BigDecimal differenceQuantity;

    public BigDecimal getDifferenceQuantity()
    {
        return this.differenceQuantity;
    }

    public void setDifferenceQuantity(BigDecimal differenceQuantity)
    {
        this.differenceQuantity = differenceQuantity;
    }

    private BigDecimal scrappedQuantity;

    public BigDecimal getScrappedQuantity()
    {
        return this.scrappedQuantity;
    }

    public void setScrappedQuantity(BigDecimal scrappedQuantity)
    {
        this.scrappedQuantity = scrappedQuantity;
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

    private Boolean processed;

    public Boolean getProcessed()
    {
        return this.processed;
    }

    public void setProcessed(Boolean processed)
    {
        this.processed = processed;
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


    public AbstractMovementConfirmationLineState() {
        this(false);
    }

    public AbstractMovementConfirmationLineState(boolean forReapplying) {
        this.forReapplying = forReapplying;

        initializeProperties();
    }
    
    protected void initializeProperties() {
    }


    public void mutate(Event e) {
        setStateReadOnly(false);
        if (e instanceof MovementConfirmationLineStateCreated) {
            when((MovementConfirmationLineStateCreated) e);
        } else if (e instanceof MovementConfirmationLineStateMergePatched) {
            when((MovementConfirmationLineStateMergePatched) e);
        } else if (e instanceof MovementConfirmationLineStateRemoved) {
            when((MovementConfirmationLineStateRemoved) e);
        } else {
            throw new UnsupportedOperationException(String.format("Unsupported event type: %1$s", e.getClass().getName()));
        }
        if (!(getTargetQuantity() .add (getDifferenceQuantity()) .equals (getConfirmedQuantity() .add (getScrappedQuantity())))) {
            throw DomainError.named("constraintViolated", "Violated validation logic: %1$s", "getTargetQuantity() .add (getDifferenceQuantity()) .equals (getConfirmedQuantity() .add (getScrappedQuantity()))");
        }
    }

    public void when(MovementConfirmationLineStateCreated e)
    {
        throwOnWrongEvent(e);

        this.setMovementLineNumber(e.getMovementLineNumber());
        this.setTargetQuantity(e.getTargetQuantity());
        this.setConfirmedQuantity(e.getConfirmedQuantity());
        this.setDifferenceQuantity(e.getDifferenceQuantity());
        this.setScrappedQuantity(e.getScrappedQuantity());
        this.setDescription(e.getDescription());
        this.setProcessed(e.getProcessed());
        this.setActive(e.getActive());

        this.setDeleted(false);

        this.setCreatedBy(e.getCreatedBy());
        this.setCreatedAt(e.getCreatedAt());

    }

    public void when(MovementConfirmationLineStateMergePatched e)
    {
        throwOnWrongEvent(e);

        if (e.getMovementLineNumber() == null)
        {
            if (e.getIsPropertyMovementLineNumberRemoved() != null && e.getIsPropertyMovementLineNumberRemoved())
            {
                this.setMovementLineNumber(null);
            }
        }
        else
        {
            this.setMovementLineNumber(e.getMovementLineNumber());
        }
        if (e.getTargetQuantity() == null)
        {
            if (e.getIsPropertyTargetQuantityRemoved() != null && e.getIsPropertyTargetQuantityRemoved())
            {
                this.setTargetQuantity(null);
            }
        }
        else
        {
            this.setTargetQuantity(e.getTargetQuantity());
        }
        if (e.getConfirmedQuantity() == null)
        {
            if (e.getIsPropertyConfirmedQuantityRemoved() != null && e.getIsPropertyConfirmedQuantityRemoved())
            {
                this.setConfirmedQuantity(null);
            }
        }
        else
        {
            this.setConfirmedQuantity(e.getConfirmedQuantity());
        }
        if (e.getDifferenceQuantity() == null)
        {
            if (e.getIsPropertyDifferenceQuantityRemoved() != null && e.getIsPropertyDifferenceQuantityRemoved())
            {
                this.setDifferenceQuantity(null);
            }
        }
        else
        {
            this.setDifferenceQuantity(e.getDifferenceQuantity());
        }
        if (e.getScrappedQuantity() == null)
        {
            if (e.getIsPropertyScrappedQuantityRemoved() != null && e.getIsPropertyScrappedQuantityRemoved())
            {
                this.setScrappedQuantity(null);
            }
        }
        else
        {
            this.setScrappedQuantity(e.getScrappedQuantity());
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
        if (e.getProcessed() == null)
        {
            if (e.getIsPropertyProcessedRemoved() != null && e.getIsPropertyProcessedRemoved())
            {
                this.setProcessed(null);
            }
        }
        else
        {
            this.setProcessed(e.getProcessed());
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

    public void when(MovementConfirmationLineStateRemoved e)
    {
        throwOnWrongEvent(e);

        this.setDeleted(true);
        this.setUpdatedBy(e.getCreatedBy());
        this.setUpdatedAt(e.getCreatedAt());

    }

    public void save()
    {
    }

    protected void throwOnWrongEvent(MovementConfirmationLineStateEvent stateEvent)
    {
        String stateEntityIdMovementConfirmationDocumentNumber = this.getMovementConfirmationLineId().getMovementConfirmationDocumentNumber();
        String eventEntityIdMovementConfirmationDocumentNumber = stateEvent.getStateEventId().getMovementConfirmationDocumentNumber();
        if (!stateEntityIdMovementConfirmationDocumentNumber.equals(eventEntityIdMovementConfirmationDocumentNumber))
        {
            throw DomainError.named("mutateWrongEntity", "Entity Id MovementConfirmationDocumentNumber %1$s in state but entity id MovementConfirmationDocumentNumber %2$s in event", stateEntityIdMovementConfirmationDocumentNumber, eventEntityIdMovementConfirmationDocumentNumber);
        }

        String stateEntityIdLineNumber = this.getMovementConfirmationLineId().getLineNumber();
        String eventEntityIdLineNumber = stateEvent.getStateEventId().getLineNumber();
        if (!stateEntityIdLineNumber.equals(eventEntityIdLineNumber))
        {
            throw DomainError.named("mutateWrongEntity", "Entity Id LineNumber %1$s in state but entity id LineNumber %2$s in event", stateEntityIdLineNumber, eventEntityIdLineNumber);
        }

        if (getForReapplying()) { return; }

        Long stateVersion = this.getVersion();
        Long eventVersion = stateEvent.getVersion();
        if (eventVersion == null) {
            eventVersion = stateVersion == null ? MovementConfirmationLineState.VERSION_NULL : stateVersion;
            stateEvent.setVersion(eventVersion);
        }
        if (!(stateVersion == null && eventVersion.equals(MovementConfirmationLineState.VERSION_NULL)) && !(eventVersion.compareTo(stateVersion) >= 0))
        {
            throw DomainError.named("concurrencyConflict", "Conflict between state version (%1$s) and event version (%2$s)", stateVersion, eventVersion);
        }

    }

    public static class SimpleMovementConfirmationLineState extends AbstractMovementConfirmationLineState
    {

        public SimpleMovementConfirmationLineState() {
        }

        public SimpleMovementConfirmationLineState(boolean forReapplying) {
            super(forReapplying);
        }

    }


}

