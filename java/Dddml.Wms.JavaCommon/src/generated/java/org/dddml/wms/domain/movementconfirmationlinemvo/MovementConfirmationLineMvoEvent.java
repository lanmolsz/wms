package org.dddml.wms.domain.movementconfirmationlinemvo;

import java.util.*;
import org.dddml.wms.domain.movementconfirmation.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;

public interface MovementConfirmationLineMvoEvent extends Event
{
    MovementConfirmationLineMvoEventId getMovementConfirmationLineMvoEventId();

    boolean getEventReadOnly();

    void setEventReadOnly(boolean readOnly);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    String getCommandId();

    void setCommandId(String commandId);

    interface MovementConfirmationLineMvoStateEvent extends MovementConfirmationLineMvoEvent {
        String getMovementLineNumber();

        void setMovementLineNumber(String movementLineNumber);

        BigDecimal getTargetQuantity();

        void setTargetQuantity(BigDecimal targetQuantity);

        BigDecimal getConfirmedQuantity();

        void setConfirmedQuantity(BigDecimal confirmedQuantity);

        BigDecimal getDifferenceQuantity();

        void setDifferenceQuantity(BigDecimal differenceQuantity);

        BigDecimal getScrappedQuantity();

        void setScrappedQuantity(BigDecimal scrappedQuantity);

        String getDescription();

        void setDescription(String description);

        Boolean getProcessed();

        void setProcessed(Boolean processed);

        Long getVersion();

        void setVersion(Long version);

        Boolean getActive();

        void setActive(Boolean active);

        String getMovementConfirmationDocumentStatusId();

        void setMovementConfirmationDocumentStatusId(String movementConfirmationDocumentStatusId);

        String getMovementConfirmationMovementDocumentNumber();

        void setMovementConfirmationMovementDocumentNumber(String movementConfirmationMovementDocumentNumber);

        Boolean getMovementConfirmationIsApproved();

        void setMovementConfirmationIsApproved(Boolean movementConfirmationIsApproved);

        BigDecimal getMovementConfirmationApprovalAmount();

        void setMovementConfirmationApprovalAmount(BigDecimal movementConfirmationApprovalAmount);

        Boolean getMovementConfirmationProcessed();

        void setMovementConfirmationProcessed(Boolean movementConfirmationProcessed);

        String getMovementConfirmationProcessing();

        void setMovementConfirmationProcessing(String movementConfirmationProcessing);

        String getMovementConfirmationDocumentTypeId();

        void setMovementConfirmationDocumentTypeId(String movementConfirmationDocumentTypeId);

        String getMovementConfirmationDescription();

        void setMovementConfirmationDescription(String movementConfirmationDescription);

        String getMovementConfirmationCreatedBy();

        void setMovementConfirmationCreatedBy(String movementConfirmationCreatedBy);

        Date getMovementConfirmationCreatedAt();

        void setMovementConfirmationCreatedAt(Date movementConfirmationCreatedAt);

        String getMovementConfirmationUpdatedBy();

        void setMovementConfirmationUpdatedBy(String movementConfirmationUpdatedBy);

        Date getMovementConfirmationUpdatedAt();

        void setMovementConfirmationUpdatedAt(Date movementConfirmationUpdatedAt);

        Boolean getMovementConfirmationActive();

        void setMovementConfirmationActive(Boolean movementConfirmationActive);

        Boolean getMovementConfirmationDeleted();

        void setMovementConfirmationDeleted(Boolean movementConfirmationDeleted);

    }

    interface MovementConfirmationLineMvoStateCreated extends MovementConfirmationLineMvoStateEvent
    {
    
    }


    interface MovementConfirmationLineMvoStateMergePatched extends MovementConfirmationLineMvoStateEvent
    {
        Boolean getIsPropertyMovementLineNumberRemoved();

        void setIsPropertyMovementLineNumberRemoved(Boolean removed);

        Boolean getIsPropertyTargetQuantityRemoved();

        void setIsPropertyTargetQuantityRemoved(Boolean removed);

        Boolean getIsPropertyConfirmedQuantityRemoved();

        void setIsPropertyConfirmedQuantityRemoved(Boolean removed);

        Boolean getIsPropertyDifferenceQuantityRemoved();

        void setIsPropertyDifferenceQuantityRemoved(Boolean removed);

        Boolean getIsPropertyScrappedQuantityRemoved();

        void setIsPropertyScrappedQuantityRemoved(Boolean removed);

        Boolean getIsPropertyDescriptionRemoved();

        void setIsPropertyDescriptionRemoved(Boolean removed);

        Boolean getIsPropertyProcessedRemoved();

        void setIsPropertyProcessedRemoved(Boolean removed);

        Boolean getIsPropertyVersionRemoved();

        void setIsPropertyVersionRemoved(Boolean removed);

        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationDocumentStatusIdRemoved();

        void setIsPropertyMovementConfirmationDocumentStatusIdRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationMovementDocumentNumberRemoved();

        void setIsPropertyMovementConfirmationMovementDocumentNumberRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationIsApprovedRemoved();

        void setIsPropertyMovementConfirmationIsApprovedRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationApprovalAmountRemoved();

        void setIsPropertyMovementConfirmationApprovalAmountRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationProcessedRemoved();

        void setIsPropertyMovementConfirmationProcessedRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationProcessingRemoved();

        void setIsPropertyMovementConfirmationProcessingRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationDocumentTypeIdRemoved();

        void setIsPropertyMovementConfirmationDocumentTypeIdRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationDescriptionRemoved();

        void setIsPropertyMovementConfirmationDescriptionRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationCreatedByRemoved();

        void setIsPropertyMovementConfirmationCreatedByRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationCreatedAtRemoved();

        void setIsPropertyMovementConfirmationCreatedAtRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationUpdatedByRemoved();

        void setIsPropertyMovementConfirmationUpdatedByRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationUpdatedAtRemoved();

        void setIsPropertyMovementConfirmationUpdatedAtRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationActiveRemoved();

        void setIsPropertyMovementConfirmationActiveRemoved(Boolean removed);

        Boolean getIsPropertyMovementConfirmationDeletedRemoved();

        void setIsPropertyMovementConfirmationDeletedRemoved(Boolean removed);


    }

    interface MovementConfirmationLineMvoStateDeleted extends MovementConfirmationLineMvoStateEvent
    {
    }


}

