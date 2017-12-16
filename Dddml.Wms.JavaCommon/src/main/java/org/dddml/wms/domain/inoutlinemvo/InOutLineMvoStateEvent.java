package org.dddml.wms.domain.inoutlinemvo;

import java.util.*;
import org.dddml.wms.domain.inout.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;

public interface InOutLineMvoStateEvent extends Event
{
    InOutLineMvoStateEventId getStateEventId();

    boolean getStateEventReadOnly();

    void setStateEventReadOnly(boolean readOnly);

    String getLocatorId();

    void setLocatorId(String locatorId);

    String getProductId();

    void setProductId(String productId);

    String getAttributeSetInstanceId();

    void setAttributeSetInstanceId(String attributeSetInstanceId);

    String getDescription();

    void setDescription(String description);

    String getUomId();

    void setUomId(String uomId);

    BigDecimal getMovementQuantity();

    void setMovementQuantity(BigDecimal movementQuantity);

    BigDecimal getConfirmedQuantity();

    void setConfirmedQuantity(BigDecimal confirmedQuantity);

    BigDecimal getScrappedQuantity();

    void setScrappedQuantity(BigDecimal scrappedQuantity);

    BigDecimal getTargetQuantity();

    void setTargetQuantity(BigDecimal targetQuantity);

    BigDecimal getPickedQuantity();

    void setPickedQuantity(BigDecimal pickedQuantity);

    Boolean getIsInvoiced();

    void setIsInvoiced(Boolean isInvoiced);

    Boolean getProcessed();

    void setProcessed(Boolean processed);

    BigDecimal getQuantityEntered();

    void setQuantityEntered(BigDecimal quantityEntered);

    Long getRmaLineNumber();

    void setRmaLineNumber(Long rmaLineNumber);

    Long getReversalLineNumber();

    void setReversalLineNumber(Long reversalLineNumber);

    Long getVersion();

    void setVersion(Long version);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    Boolean getActive();

    void setActive(Boolean active);

    String getInOutDocumentStatus();

    void setInOutDocumentStatus(String inOutDocumentStatus);

    Boolean getInOutPosted();

    void setInOutPosted(Boolean inOutPosted);

    Boolean getInOutProcessing();

    void setInOutProcessing(Boolean inOutProcessing);

    Boolean getInOutProcessed();

    void setInOutProcessed(Boolean inOutProcessed);

    String getInOutDocumentTypeId();

    void setInOutDocumentTypeId(String inOutDocumentTypeId);

    String getInOutDescription();

    void setInOutDescription(String inOutDescription);

    String getInOutOrderId();

    void setInOutOrderId(String inOutOrderId);

    Date getInOutDateOrdered();

    void setInOutDateOrdered(Date inOutDateOrdered);

    Boolean getInOutIsPrinted();

    void setInOutIsPrinted(Boolean inOutIsPrinted);

    String getInOutMovementTypeId();

    void setInOutMovementTypeId(String inOutMovementTypeId);

    Date getInOutMovementDate();

    void setInOutMovementDate(Date inOutMovementDate);

    String getInOutBusinessPartnerId();

    void setInOutBusinessPartnerId(String inOutBusinessPartnerId);

    String getInOutWarehouseId();

    void setInOutWarehouseId(String inOutWarehouseId);

    String getInOutPOReference();

    void setInOutPOReference(String inOutPOReference);

    String getInOutShipperId();

    void setInOutShipperId(String inOutShipperId);

    Date getInOutDatePrinted();

    void setInOutDatePrinted(Date inOutDatePrinted);

    String getInOutSalesRepresentative();

    void setInOutSalesRepresentative(String inOutSalesRepresentative);

    Integer getInOutNumberOfPackages();

    void setInOutNumberOfPackages(Integer inOutNumberOfPackages);

    Date getInOutPickDate();

    void setInOutPickDate(Date inOutPickDate);

    Date getInOutShipDate();

    void setInOutShipDate(Date inOutShipDate);

    String getInOutTrackingNumber();

    void setInOutTrackingNumber(String inOutTrackingNumber);

    Date getInOutDateReceived();

    void setInOutDateReceived(Date inOutDateReceived);

    Boolean getInOutIsInTransit();

    void setInOutIsInTransit(Boolean inOutIsInTransit);

    Boolean getInOutIsApproved();

    void setInOutIsApproved(Boolean inOutIsApproved);

    Boolean getInOutIsInDispute();

    void setInOutIsInDispute(Boolean inOutIsInDispute);

    String getInOutRmaNumber();

    void setInOutRmaNumber(String inOutRmaNumber);

    String getInOutReversalNumber();

    void setInOutReversalNumber(String inOutReversalNumber);

    String getInOutCreatedBy();

    void setInOutCreatedBy(String inOutCreatedBy);

    Date getInOutCreatedAt();

    void setInOutCreatedAt(Date inOutCreatedAt);

    String getInOutUpdatedBy();

    void setInOutUpdatedBy(String inOutUpdatedBy);

    Date getInOutUpdatedAt();

    void setInOutUpdatedAt(Date inOutUpdatedAt);

    Boolean getInOutActive();

    void setInOutActive(Boolean inOutActive);

    Boolean getInOutDeleted();

    void setInOutDeleted(Boolean inOutDeleted);

    String getCommandId();

    void setCommandId(String commandId);

    interface InOutLineMvoStateCreated extends InOutLineMvoStateEvent
    {
    
    }


    interface InOutLineMvoStateMergePatched extends InOutLineMvoStateEvent
    {
        Boolean getIsPropertyLocatorIdRemoved();

        void setIsPropertyLocatorIdRemoved(Boolean removed);

        Boolean getIsPropertyProductIdRemoved();

        void setIsPropertyProductIdRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetInstanceIdRemoved();

        void setIsPropertyAttributeSetInstanceIdRemoved(Boolean removed);

        Boolean getIsPropertyDescriptionRemoved();

        void setIsPropertyDescriptionRemoved(Boolean removed);

        Boolean getIsPropertyUomIdRemoved();

        void setIsPropertyUomIdRemoved(Boolean removed);

        Boolean getIsPropertyMovementQuantityRemoved();

        void setIsPropertyMovementQuantityRemoved(Boolean removed);

        Boolean getIsPropertyConfirmedQuantityRemoved();

        void setIsPropertyConfirmedQuantityRemoved(Boolean removed);

        Boolean getIsPropertyScrappedQuantityRemoved();

        void setIsPropertyScrappedQuantityRemoved(Boolean removed);

        Boolean getIsPropertyTargetQuantityRemoved();

        void setIsPropertyTargetQuantityRemoved(Boolean removed);

        Boolean getIsPropertyPickedQuantityRemoved();

        void setIsPropertyPickedQuantityRemoved(Boolean removed);

        Boolean getIsPropertyIsInvoicedRemoved();

        void setIsPropertyIsInvoicedRemoved(Boolean removed);

        Boolean getIsPropertyProcessedRemoved();

        void setIsPropertyProcessedRemoved(Boolean removed);

        Boolean getIsPropertyQuantityEnteredRemoved();

        void setIsPropertyQuantityEnteredRemoved(Boolean removed);

        Boolean getIsPropertyRmaLineNumberRemoved();

        void setIsPropertyRmaLineNumberRemoved(Boolean removed);

        Boolean getIsPropertyReversalLineNumberRemoved();

        void setIsPropertyReversalLineNumberRemoved(Boolean removed);

        Boolean getIsPropertyVersionRemoved();

        void setIsPropertyVersionRemoved(Boolean removed);

        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);

        Boolean getIsPropertyInOutDocumentStatusRemoved();

        void setIsPropertyInOutDocumentStatusRemoved(Boolean removed);

        Boolean getIsPropertyInOutPostedRemoved();

        void setIsPropertyInOutPostedRemoved(Boolean removed);

        Boolean getIsPropertyInOutProcessingRemoved();

        void setIsPropertyInOutProcessingRemoved(Boolean removed);

        Boolean getIsPropertyInOutProcessedRemoved();

        void setIsPropertyInOutProcessedRemoved(Boolean removed);

        Boolean getIsPropertyInOutDocumentTypeIdRemoved();

        void setIsPropertyInOutDocumentTypeIdRemoved(Boolean removed);

        Boolean getIsPropertyInOutDescriptionRemoved();

        void setIsPropertyInOutDescriptionRemoved(Boolean removed);

        Boolean getIsPropertyInOutOrderIdRemoved();

        void setIsPropertyInOutOrderIdRemoved(Boolean removed);

        Boolean getIsPropertyInOutDateOrderedRemoved();

        void setIsPropertyInOutDateOrderedRemoved(Boolean removed);

        Boolean getIsPropertyInOutIsPrintedRemoved();

        void setIsPropertyInOutIsPrintedRemoved(Boolean removed);

        Boolean getIsPropertyInOutMovementTypeIdRemoved();

        void setIsPropertyInOutMovementTypeIdRemoved(Boolean removed);

        Boolean getIsPropertyInOutMovementDateRemoved();

        void setIsPropertyInOutMovementDateRemoved(Boolean removed);

        Boolean getIsPropertyInOutBusinessPartnerIdRemoved();

        void setIsPropertyInOutBusinessPartnerIdRemoved(Boolean removed);

        Boolean getIsPropertyInOutWarehouseIdRemoved();

        void setIsPropertyInOutWarehouseIdRemoved(Boolean removed);

        Boolean getIsPropertyInOutPOReferenceRemoved();

        void setIsPropertyInOutPOReferenceRemoved(Boolean removed);

        Boolean getIsPropertyInOutShipperIdRemoved();

        void setIsPropertyInOutShipperIdRemoved(Boolean removed);

        Boolean getIsPropertyInOutDatePrintedRemoved();

        void setIsPropertyInOutDatePrintedRemoved(Boolean removed);

        Boolean getIsPropertyInOutSalesRepresentativeRemoved();

        void setIsPropertyInOutSalesRepresentativeRemoved(Boolean removed);

        Boolean getIsPropertyInOutNumberOfPackagesRemoved();

        void setIsPropertyInOutNumberOfPackagesRemoved(Boolean removed);

        Boolean getIsPropertyInOutPickDateRemoved();

        void setIsPropertyInOutPickDateRemoved(Boolean removed);

        Boolean getIsPropertyInOutShipDateRemoved();

        void setIsPropertyInOutShipDateRemoved(Boolean removed);

        Boolean getIsPropertyInOutTrackingNumberRemoved();

        void setIsPropertyInOutTrackingNumberRemoved(Boolean removed);

        Boolean getIsPropertyInOutDateReceivedRemoved();

        void setIsPropertyInOutDateReceivedRemoved(Boolean removed);

        Boolean getIsPropertyInOutIsInTransitRemoved();

        void setIsPropertyInOutIsInTransitRemoved(Boolean removed);

        Boolean getIsPropertyInOutIsApprovedRemoved();

        void setIsPropertyInOutIsApprovedRemoved(Boolean removed);

        Boolean getIsPropertyInOutIsInDisputeRemoved();

        void setIsPropertyInOutIsInDisputeRemoved(Boolean removed);

        Boolean getIsPropertyInOutRmaNumberRemoved();

        void setIsPropertyInOutRmaNumberRemoved(Boolean removed);

        Boolean getIsPropertyInOutReversalNumberRemoved();

        void setIsPropertyInOutReversalNumberRemoved(Boolean removed);

        Boolean getIsPropertyInOutCreatedByRemoved();

        void setIsPropertyInOutCreatedByRemoved(Boolean removed);

        Boolean getIsPropertyInOutCreatedAtRemoved();

        void setIsPropertyInOutCreatedAtRemoved(Boolean removed);

        Boolean getIsPropertyInOutUpdatedByRemoved();

        void setIsPropertyInOutUpdatedByRemoved(Boolean removed);

        Boolean getIsPropertyInOutUpdatedAtRemoved();

        void setIsPropertyInOutUpdatedAtRemoved(Boolean removed);

        Boolean getIsPropertyInOutActiveRemoved();

        void setIsPropertyInOutActiveRemoved(Boolean removed);

        Boolean getIsPropertyInOutDeletedRemoved();

        void setIsPropertyInOutDeletedRemoved(Boolean removed);


    }

    interface InOutLineMvoStateDeleted extends InOutLineMvoStateEvent
    {
    }


}

