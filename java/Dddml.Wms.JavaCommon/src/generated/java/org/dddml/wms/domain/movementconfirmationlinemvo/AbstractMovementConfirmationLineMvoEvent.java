package org.dddml.wms.domain.movementconfirmationlinemvo;

import java.util.*;
import org.dddml.wms.domain.movementconfirmation.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractEvent;

public abstract class AbstractMovementConfirmationLineMvoEvent extends AbstractEvent implements MovementConfirmationLineMvoEvent 
{
    private MovementConfirmationLineMvoEventId movementConfirmationLineMvoEventId;

    public MovementConfirmationLineMvoEventId getMovementConfirmationLineMvoEventId() {
        return this.movementConfirmationLineMvoEventId;
    }

    public void setMovementConfirmationLineMvoEventId(MovementConfirmationLineMvoEventId eventId) {
        this.movementConfirmationLineMvoEventId = eventId;
    }
    
    public MovementConfirmationLineId getMovementConfirmationLineId() {
        return getMovementConfirmationLineMvoEventId().getMovementConfirmationLineId();
    }

    public void setMovementConfirmationLineId(MovementConfirmationLineId movementConfirmationLineId) {
        getMovementConfirmationLineMvoEventId().setMovementConfirmationLineId(movementConfirmationLineId);
    }

    private boolean stateEventReadOnly;

    public boolean getEventReadOnly() { return this.stateEventReadOnly; }

    public void setEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

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


    private String commandId;

    public String getCommandId() {
        return commandId;
    }

    public void setCommandId(String commandId) {
        this.commandId = commandId;
    }

    protected AbstractMovementConfirmationLineMvoEvent() {
    }

    protected AbstractMovementConfirmationLineMvoEvent(MovementConfirmationLineMvoEventId eventId) {
        this.movementConfirmationLineMvoEventId = eventId;
    }


    public abstract String getEventType();


    public static abstract class AbstractMovementConfirmationLineMvoStateEvent extends AbstractMovementConfirmationLineMvoEvent implements MovementConfirmationLineMvoEvent.MovementConfirmationLineMvoStateEvent {
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

        private Boolean active;

        public Boolean getActive()
        {
            return this.active;
        }

        public void setActive(Boolean active)
        {
            this.active = active;
        }

        private String movementConfirmationDocumentStatusId;

        public String getMovementConfirmationDocumentStatusId()
        {
            return this.movementConfirmationDocumentStatusId;
        }

        public void setMovementConfirmationDocumentStatusId(String movementConfirmationDocumentStatusId)
        {
            this.movementConfirmationDocumentStatusId = movementConfirmationDocumentStatusId;
        }

        private String movementConfirmationMovementDocumentNumber;

        public String getMovementConfirmationMovementDocumentNumber()
        {
            return this.movementConfirmationMovementDocumentNumber;
        }

        public void setMovementConfirmationMovementDocumentNumber(String movementConfirmationMovementDocumentNumber)
        {
            this.movementConfirmationMovementDocumentNumber = movementConfirmationMovementDocumentNumber;
        }

        private Boolean movementConfirmationIsApproved;

        public Boolean getMovementConfirmationIsApproved()
        {
            return this.movementConfirmationIsApproved;
        }

        public void setMovementConfirmationIsApproved(Boolean movementConfirmationIsApproved)
        {
            this.movementConfirmationIsApproved = movementConfirmationIsApproved;
        }

        private BigDecimal movementConfirmationApprovalAmount;

        public BigDecimal getMovementConfirmationApprovalAmount()
        {
            return this.movementConfirmationApprovalAmount;
        }

        public void setMovementConfirmationApprovalAmount(BigDecimal movementConfirmationApprovalAmount)
        {
            this.movementConfirmationApprovalAmount = movementConfirmationApprovalAmount;
        }

        private Boolean movementConfirmationProcessed;

        public Boolean getMovementConfirmationProcessed()
        {
            return this.movementConfirmationProcessed;
        }

        public void setMovementConfirmationProcessed(Boolean movementConfirmationProcessed)
        {
            this.movementConfirmationProcessed = movementConfirmationProcessed;
        }

        private String movementConfirmationProcessing;

        public String getMovementConfirmationProcessing()
        {
            return this.movementConfirmationProcessing;
        }

        public void setMovementConfirmationProcessing(String movementConfirmationProcessing)
        {
            this.movementConfirmationProcessing = movementConfirmationProcessing;
        }

        private String movementConfirmationDocumentTypeId;

        public String getMovementConfirmationDocumentTypeId()
        {
            return this.movementConfirmationDocumentTypeId;
        }

        public void setMovementConfirmationDocumentTypeId(String movementConfirmationDocumentTypeId)
        {
            this.movementConfirmationDocumentTypeId = movementConfirmationDocumentTypeId;
        }

        private String movementConfirmationDescription;

        public String getMovementConfirmationDescription()
        {
            return this.movementConfirmationDescription;
        }

        public void setMovementConfirmationDescription(String movementConfirmationDescription)
        {
            this.movementConfirmationDescription = movementConfirmationDescription;
        }

        private String movementConfirmationCreatedBy;

        public String getMovementConfirmationCreatedBy()
        {
            return this.movementConfirmationCreatedBy;
        }

        public void setMovementConfirmationCreatedBy(String movementConfirmationCreatedBy)
        {
            this.movementConfirmationCreatedBy = movementConfirmationCreatedBy;
        }

        private Date movementConfirmationCreatedAt;

        public Date getMovementConfirmationCreatedAt()
        {
            return this.movementConfirmationCreatedAt;
        }

        public void setMovementConfirmationCreatedAt(Date movementConfirmationCreatedAt)
        {
            this.movementConfirmationCreatedAt = movementConfirmationCreatedAt;
        }

        private String movementConfirmationUpdatedBy;

        public String getMovementConfirmationUpdatedBy()
        {
            return this.movementConfirmationUpdatedBy;
        }

        public void setMovementConfirmationUpdatedBy(String movementConfirmationUpdatedBy)
        {
            this.movementConfirmationUpdatedBy = movementConfirmationUpdatedBy;
        }

        private Date movementConfirmationUpdatedAt;

        public Date getMovementConfirmationUpdatedAt()
        {
            return this.movementConfirmationUpdatedAt;
        }

        public void setMovementConfirmationUpdatedAt(Date movementConfirmationUpdatedAt)
        {
            this.movementConfirmationUpdatedAt = movementConfirmationUpdatedAt;
        }

        private Boolean movementConfirmationActive;

        public Boolean getMovementConfirmationActive()
        {
            return this.movementConfirmationActive;
        }

        public void setMovementConfirmationActive(Boolean movementConfirmationActive)
        {
            this.movementConfirmationActive = movementConfirmationActive;
        }

        private Boolean movementConfirmationDeleted;

        public Boolean getMovementConfirmationDeleted()
        {
            return this.movementConfirmationDeleted;
        }

        public void setMovementConfirmationDeleted(Boolean movementConfirmationDeleted)
        {
            this.movementConfirmationDeleted = movementConfirmationDeleted;
        }

        protected AbstractMovementConfirmationLineMvoStateEvent(MovementConfirmationLineMvoEventId eventId) {
            super(eventId);
        }
    }

    public static abstract class AbstractMovementConfirmationLineMvoStateCreated extends AbstractMovementConfirmationLineMvoStateEvent implements MovementConfirmationLineMvoEvent.MovementConfirmationLineMvoStateCreated
    {
        public AbstractMovementConfirmationLineMvoStateCreated() {
            this(new MovementConfirmationLineMvoEventId());
        }

        public AbstractMovementConfirmationLineMvoStateCreated(MovementConfirmationLineMvoEventId eventId) {
            super(eventId);
        }

        public String getEventType() {
            return StateEventType.CREATED;
        }

    }


    public static abstract class AbstractMovementConfirmationLineMvoStateMergePatched extends AbstractMovementConfirmationLineMvoStateEvent implements MovementConfirmationLineMvoEvent.MovementConfirmationLineMvoStateMergePatched
    {
        public AbstractMovementConfirmationLineMvoStateMergePatched() {
            this(new MovementConfirmationLineMvoEventId());
        }

        public AbstractMovementConfirmationLineMvoStateMergePatched(MovementConfirmationLineMvoEventId eventId) {
            super(eventId);
        }

        public String getEventType() {
            return StateEventType.MERGE_PATCHED;
        }

        private Boolean isPropertyMovementLineNumberRemoved;

        public Boolean getIsPropertyMovementLineNumberRemoved() {
            return this.isPropertyMovementLineNumberRemoved;
        }

        public void setIsPropertyMovementLineNumberRemoved(Boolean removed) {
            this.isPropertyMovementLineNumberRemoved = removed;
        }

        private Boolean isPropertyTargetQuantityRemoved;

        public Boolean getIsPropertyTargetQuantityRemoved() {
            return this.isPropertyTargetQuantityRemoved;
        }

        public void setIsPropertyTargetQuantityRemoved(Boolean removed) {
            this.isPropertyTargetQuantityRemoved = removed;
        }

        private Boolean isPropertyConfirmedQuantityRemoved;

        public Boolean getIsPropertyConfirmedQuantityRemoved() {
            return this.isPropertyConfirmedQuantityRemoved;
        }

        public void setIsPropertyConfirmedQuantityRemoved(Boolean removed) {
            this.isPropertyConfirmedQuantityRemoved = removed;
        }

        private Boolean isPropertyDifferenceQuantityRemoved;

        public Boolean getIsPropertyDifferenceQuantityRemoved() {
            return this.isPropertyDifferenceQuantityRemoved;
        }

        public void setIsPropertyDifferenceQuantityRemoved(Boolean removed) {
            this.isPropertyDifferenceQuantityRemoved = removed;
        }

        private Boolean isPropertyScrappedQuantityRemoved;

        public Boolean getIsPropertyScrappedQuantityRemoved() {
            return this.isPropertyScrappedQuantityRemoved;
        }

        public void setIsPropertyScrappedQuantityRemoved(Boolean removed) {
            this.isPropertyScrappedQuantityRemoved = removed;
        }

        private Boolean isPropertyDescriptionRemoved;

        public Boolean getIsPropertyDescriptionRemoved() {
            return this.isPropertyDescriptionRemoved;
        }

        public void setIsPropertyDescriptionRemoved(Boolean removed) {
            this.isPropertyDescriptionRemoved = removed;
        }

        private Boolean isPropertyProcessedRemoved;

        public Boolean getIsPropertyProcessedRemoved() {
            return this.isPropertyProcessedRemoved;
        }

        public void setIsPropertyProcessedRemoved(Boolean removed) {
            this.isPropertyProcessedRemoved = removed;
        }

        private Boolean isPropertyVersionRemoved;

        public Boolean getIsPropertyVersionRemoved() {
            return this.isPropertyVersionRemoved;
        }

        public void setIsPropertyVersionRemoved(Boolean removed) {
            this.isPropertyVersionRemoved = removed;
        }

        private Boolean isPropertyActiveRemoved;

        public Boolean getIsPropertyActiveRemoved() {
            return this.isPropertyActiveRemoved;
        }

        public void setIsPropertyActiveRemoved(Boolean removed) {
            this.isPropertyActiveRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationDocumentStatusIdRemoved;

        public Boolean getIsPropertyMovementConfirmationDocumentStatusIdRemoved() {
            return this.isPropertyMovementConfirmationDocumentStatusIdRemoved;
        }

        public void setIsPropertyMovementConfirmationDocumentStatusIdRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationDocumentStatusIdRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationMovementDocumentNumberRemoved;

        public Boolean getIsPropertyMovementConfirmationMovementDocumentNumberRemoved() {
            return this.isPropertyMovementConfirmationMovementDocumentNumberRemoved;
        }

        public void setIsPropertyMovementConfirmationMovementDocumentNumberRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationMovementDocumentNumberRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationIsApprovedRemoved;

        public Boolean getIsPropertyMovementConfirmationIsApprovedRemoved() {
            return this.isPropertyMovementConfirmationIsApprovedRemoved;
        }

        public void setIsPropertyMovementConfirmationIsApprovedRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationIsApprovedRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationApprovalAmountRemoved;

        public Boolean getIsPropertyMovementConfirmationApprovalAmountRemoved() {
            return this.isPropertyMovementConfirmationApprovalAmountRemoved;
        }

        public void setIsPropertyMovementConfirmationApprovalAmountRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationApprovalAmountRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationProcessedRemoved;

        public Boolean getIsPropertyMovementConfirmationProcessedRemoved() {
            return this.isPropertyMovementConfirmationProcessedRemoved;
        }

        public void setIsPropertyMovementConfirmationProcessedRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationProcessedRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationProcessingRemoved;

        public Boolean getIsPropertyMovementConfirmationProcessingRemoved() {
            return this.isPropertyMovementConfirmationProcessingRemoved;
        }

        public void setIsPropertyMovementConfirmationProcessingRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationProcessingRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationDocumentTypeIdRemoved;

        public Boolean getIsPropertyMovementConfirmationDocumentTypeIdRemoved() {
            return this.isPropertyMovementConfirmationDocumentTypeIdRemoved;
        }

        public void setIsPropertyMovementConfirmationDocumentTypeIdRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationDocumentTypeIdRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationDescriptionRemoved;

        public Boolean getIsPropertyMovementConfirmationDescriptionRemoved() {
            return this.isPropertyMovementConfirmationDescriptionRemoved;
        }

        public void setIsPropertyMovementConfirmationDescriptionRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationDescriptionRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationCreatedByRemoved;

        public Boolean getIsPropertyMovementConfirmationCreatedByRemoved() {
            return this.isPropertyMovementConfirmationCreatedByRemoved;
        }

        public void setIsPropertyMovementConfirmationCreatedByRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationCreatedByRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationCreatedAtRemoved;

        public Boolean getIsPropertyMovementConfirmationCreatedAtRemoved() {
            return this.isPropertyMovementConfirmationCreatedAtRemoved;
        }

        public void setIsPropertyMovementConfirmationCreatedAtRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationCreatedAtRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationUpdatedByRemoved;

        public Boolean getIsPropertyMovementConfirmationUpdatedByRemoved() {
            return this.isPropertyMovementConfirmationUpdatedByRemoved;
        }

        public void setIsPropertyMovementConfirmationUpdatedByRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationUpdatedByRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationUpdatedAtRemoved;

        public Boolean getIsPropertyMovementConfirmationUpdatedAtRemoved() {
            return this.isPropertyMovementConfirmationUpdatedAtRemoved;
        }

        public void setIsPropertyMovementConfirmationUpdatedAtRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationUpdatedAtRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationActiveRemoved;

        public Boolean getIsPropertyMovementConfirmationActiveRemoved() {
            return this.isPropertyMovementConfirmationActiveRemoved;
        }

        public void setIsPropertyMovementConfirmationActiveRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationActiveRemoved = removed;
        }

        private Boolean isPropertyMovementConfirmationDeletedRemoved;

        public Boolean getIsPropertyMovementConfirmationDeletedRemoved() {
            return this.isPropertyMovementConfirmationDeletedRemoved;
        }

        public void setIsPropertyMovementConfirmationDeletedRemoved(Boolean removed) {
            this.isPropertyMovementConfirmationDeletedRemoved = removed;
        }

    }


    public static abstract class AbstractMovementConfirmationLineMvoStateDeleted extends AbstractMovementConfirmationLineMvoStateEvent implements MovementConfirmationLineMvoEvent.MovementConfirmationLineMvoStateDeleted
    {
        public AbstractMovementConfirmationLineMvoStateDeleted() {
            this(new MovementConfirmationLineMvoEventId());
        }

        public AbstractMovementConfirmationLineMvoStateDeleted(MovementConfirmationLineMvoEventId eventId) {
            super(eventId);
        }

        public String getEventType() {
            return StateEventType.DELETED;
        }

    }
    public static class SimpleMovementConfirmationLineMvoStateCreated extends AbstractMovementConfirmationLineMvoStateCreated
    {
        public SimpleMovementConfirmationLineMvoStateCreated() {
        }

        public SimpleMovementConfirmationLineMvoStateCreated(MovementConfirmationLineMvoEventId eventId) {
            super(eventId);
        }
    }

    public static class SimpleMovementConfirmationLineMvoStateMergePatched extends AbstractMovementConfirmationLineMvoStateMergePatched
    {
        public SimpleMovementConfirmationLineMvoStateMergePatched() {
        }

        public SimpleMovementConfirmationLineMvoStateMergePatched(MovementConfirmationLineMvoEventId eventId) {
            super(eventId);
        }
    }

    public static class SimpleMovementConfirmationLineMvoStateDeleted extends AbstractMovementConfirmationLineMvoStateDeleted
    {
        public SimpleMovementConfirmationLineMvoStateDeleted() {
        }

        public SimpleMovementConfirmationLineMvoStateDeleted(MovementConfirmationLineMvoEventId eventId) {
            super(eventId);
        }
    }

}

