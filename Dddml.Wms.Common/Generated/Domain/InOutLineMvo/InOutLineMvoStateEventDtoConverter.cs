﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOutLineMvo
{

    public class InOutLineMvoStateEventDtoConverter
    {
        public virtual InOutLineMvoStateCreatedOrMergePatchedOrDeletedDto ToInOutLineMvoStateEventDto(IInOutLineMvoStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IInOutLineMvoStateCreated)stateEvent;
                return ToInOutLineMvoStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IInOutLineMvoStateMergePatched)stateEvent;
                return ToInOutLineMvoStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IInOutLineMvoStateDeleted)stateEvent;
                return ToInOutLineMvoStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual InOutLineMvoStateCreatedDto ToInOutLineMvoStateCreatedDto(IInOutLineMvoStateCreated e)
        {
            var dto = new InOutLineMvoStateCreatedDto();
            dto.StateEventId = new InOutLineMvoStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.LocatorId = e.LocatorId;
            dto.ProductId = e.ProductId;
            dto.AttributeSetInstanceId = e.AttributeSetInstanceId;
            dto.Description = e.Description;
            dto.UomId = e.UomId;
            dto.MovementQuantity = e.MovementQuantity;
            dto.ConfirmedQuantity = e.ConfirmedQuantity;
            dto.ScrappedQuantity = e.ScrappedQuantity;
            dto.TargetQuantity = e.TargetQuantity;
            dto.PickedQuantity = e.PickedQuantity;
            dto.IsInvoiced = e.IsInvoiced;
            dto.Processed = e.Processed;
            dto.QuantityEntered = e.QuantityEntered;
            dto.RmaLineNumber = e.RmaLineNumber;
            dto.ReversalLineNumber = e.ReversalLineNumber;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.InOutDocumentStatusId = e.InOutDocumentStatusId;
            dto.InOutPosted = e.InOutPosted;
            dto.InOutProcessed = e.InOutProcessed;
            dto.InOutProcessing = e.InOutProcessing;
            dto.InOutDocumentTypeId = e.InOutDocumentTypeId;
            dto.InOutDescription = e.InOutDescription;
            dto.InOutOrderId = e.InOutOrderId;
            dto.InOutDateOrdered = e.InOutDateOrdered;
            dto.InOutIsPrinted = e.InOutIsPrinted;
            dto.InOutMovementTypeId = e.InOutMovementTypeId;
            dto.InOutMovementDate = e.InOutMovementDate;
            dto.InOutBusinessPartnerId = e.InOutBusinessPartnerId;
            dto.InOutWarehouseId = e.InOutWarehouseId;
            dto.InOutPOReference = e.InOutPOReference;
            dto.InOutShipperId = e.InOutShipperId;
            dto.InOutDatePrinted = e.InOutDatePrinted;
            dto.InOutSalesRepresentativeId = e.InOutSalesRepresentativeId;
            dto.InOutNumberOfPackages = e.InOutNumberOfPackages;
            dto.InOutPickDate = e.InOutPickDate;
            dto.InOutShipDate = e.InOutShipDate;
            dto.InOutTrackingNumber = e.InOutTrackingNumber;
            dto.InOutDateReceived = e.InOutDateReceived;
            dto.InOutIsInTransit = e.InOutIsInTransit;
            dto.InOutIsApproved = e.InOutIsApproved;
            dto.InOutIsInDispute = e.InOutIsInDispute;
            dto.InOutRmaDocumentNumber = e.InOutRmaDocumentNumber;
            dto.InOutReversalDocumentNumber = e.InOutReversalDocumentNumber;
            dto.InOutCreatedBy = e.InOutCreatedBy;
            dto.InOutCreatedAt = e.InOutCreatedAt;
            dto.InOutUpdatedBy = e.InOutUpdatedBy;
            dto.InOutUpdatedAt = e.InOutUpdatedAt;
            dto.InOutActive = e.InOutActive;
            dto.InOutDeleted = e.InOutDeleted;
            return dto;
        }

        public virtual InOutLineMvoStateMergePatchedDto ToInOutLineMvoStateMergePatchedDto(IInOutLineMvoStateMergePatched e)
        {
            var dto = new InOutLineMvoStateMergePatchedDto();
            dto.StateEventId = new InOutLineMvoStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.LocatorId = e.LocatorId;
            dto.ProductId = e.ProductId;
            dto.AttributeSetInstanceId = e.AttributeSetInstanceId;
            dto.Description = e.Description;
            dto.UomId = e.UomId;
            dto.MovementQuantity = e.MovementQuantity;
            dto.ConfirmedQuantity = e.ConfirmedQuantity;
            dto.ScrappedQuantity = e.ScrappedQuantity;
            dto.TargetQuantity = e.TargetQuantity;
            dto.PickedQuantity = e.PickedQuantity;
            dto.IsInvoiced = e.IsInvoiced;
            dto.Processed = e.Processed;
            dto.QuantityEntered = e.QuantityEntered;
            dto.RmaLineNumber = e.RmaLineNumber;
            dto.ReversalLineNumber = e.ReversalLineNumber;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.InOutDocumentStatusId = e.InOutDocumentStatusId;
            dto.InOutPosted = e.InOutPosted;
            dto.InOutProcessed = e.InOutProcessed;
            dto.InOutProcessing = e.InOutProcessing;
            dto.InOutDocumentTypeId = e.InOutDocumentTypeId;
            dto.InOutDescription = e.InOutDescription;
            dto.InOutOrderId = e.InOutOrderId;
            dto.InOutDateOrdered = e.InOutDateOrdered;
            dto.InOutIsPrinted = e.InOutIsPrinted;
            dto.InOutMovementTypeId = e.InOutMovementTypeId;
            dto.InOutMovementDate = e.InOutMovementDate;
            dto.InOutBusinessPartnerId = e.InOutBusinessPartnerId;
            dto.InOutWarehouseId = e.InOutWarehouseId;
            dto.InOutPOReference = e.InOutPOReference;
            dto.InOutShipperId = e.InOutShipperId;
            dto.InOutDatePrinted = e.InOutDatePrinted;
            dto.InOutSalesRepresentativeId = e.InOutSalesRepresentativeId;
            dto.InOutNumberOfPackages = e.InOutNumberOfPackages;
            dto.InOutPickDate = e.InOutPickDate;
            dto.InOutShipDate = e.InOutShipDate;
            dto.InOutTrackingNumber = e.InOutTrackingNumber;
            dto.InOutDateReceived = e.InOutDateReceived;
            dto.InOutIsInTransit = e.InOutIsInTransit;
            dto.InOutIsApproved = e.InOutIsApproved;
            dto.InOutIsInDispute = e.InOutIsInDispute;
            dto.InOutRmaDocumentNumber = e.InOutRmaDocumentNumber;
            dto.InOutReversalDocumentNumber = e.InOutReversalDocumentNumber;
            dto.InOutCreatedBy = e.InOutCreatedBy;
            dto.InOutCreatedAt = e.InOutCreatedAt;
            dto.InOutUpdatedBy = e.InOutUpdatedBy;
            dto.InOutUpdatedAt = e.InOutUpdatedAt;
            dto.InOutActive = e.InOutActive;
            dto.InOutDeleted = e.InOutDeleted;
            dto.IsPropertyLocatorIdRemoved = e.IsPropertyLocatorIdRemoved;
            dto.IsPropertyProductIdRemoved = e.IsPropertyProductIdRemoved;
            dto.IsPropertyAttributeSetInstanceIdRemoved = e.IsPropertyAttributeSetInstanceIdRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyUomIdRemoved = e.IsPropertyUomIdRemoved;
            dto.IsPropertyMovementQuantityRemoved = e.IsPropertyMovementQuantityRemoved;
            dto.IsPropertyConfirmedQuantityRemoved = e.IsPropertyConfirmedQuantityRemoved;
            dto.IsPropertyScrappedQuantityRemoved = e.IsPropertyScrappedQuantityRemoved;
            dto.IsPropertyTargetQuantityRemoved = e.IsPropertyTargetQuantityRemoved;
            dto.IsPropertyPickedQuantityRemoved = e.IsPropertyPickedQuantityRemoved;
            dto.IsPropertyIsInvoicedRemoved = e.IsPropertyIsInvoicedRemoved;
            dto.IsPropertyProcessedRemoved = e.IsPropertyProcessedRemoved;
            dto.IsPropertyQuantityEnteredRemoved = e.IsPropertyQuantityEnteredRemoved;
            dto.IsPropertyRmaLineNumberRemoved = e.IsPropertyRmaLineNumberRemoved;
            dto.IsPropertyReversalLineNumberRemoved = e.IsPropertyReversalLineNumberRemoved;
            dto.IsPropertyVersionRemoved = e.IsPropertyVersionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;
            dto.IsPropertyInOutDocumentStatusIdRemoved = e.IsPropertyInOutDocumentStatusIdRemoved;
            dto.IsPropertyInOutPostedRemoved = e.IsPropertyInOutPostedRemoved;
            dto.IsPropertyInOutProcessedRemoved = e.IsPropertyInOutProcessedRemoved;
            dto.IsPropertyInOutProcessingRemoved = e.IsPropertyInOutProcessingRemoved;
            dto.IsPropertyInOutDocumentTypeIdRemoved = e.IsPropertyInOutDocumentTypeIdRemoved;
            dto.IsPropertyInOutDescriptionRemoved = e.IsPropertyInOutDescriptionRemoved;
            dto.IsPropertyInOutOrderIdRemoved = e.IsPropertyInOutOrderIdRemoved;
            dto.IsPropertyInOutDateOrderedRemoved = e.IsPropertyInOutDateOrderedRemoved;
            dto.IsPropertyInOutIsPrintedRemoved = e.IsPropertyInOutIsPrintedRemoved;
            dto.IsPropertyInOutMovementTypeIdRemoved = e.IsPropertyInOutMovementTypeIdRemoved;
            dto.IsPropertyInOutMovementDateRemoved = e.IsPropertyInOutMovementDateRemoved;
            dto.IsPropertyInOutBusinessPartnerIdRemoved = e.IsPropertyInOutBusinessPartnerIdRemoved;
            dto.IsPropertyInOutWarehouseIdRemoved = e.IsPropertyInOutWarehouseIdRemoved;
            dto.IsPropertyInOutPOReferenceRemoved = e.IsPropertyInOutPOReferenceRemoved;
            dto.IsPropertyInOutShipperIdRemoved = e.IsPropertyInOutShipperIdRemoved;
            dto.IsPropertyInOutDatePrintedRemoved = e.IsPropertyInOutDatePrintedRemoved;
            dto.IsPropertyInOutSalesRepresentativeIdRemoved = e.IsPropertyInOutSalesRepresentativeIdRemoved;
            dto.IsPropertyInOutNumberOfPackagesRemoved = e.IsPropertyInOutNumberOfPackagesRemoved;
            dto.IsPropertyInOutPickDateRemoved = e.IsPropertyInOutPickDateRemoved;
            dto.IsPropertyInOutShipDateRemoved = e.IsPropertyInOutShipDateRemoved;
            dto.IsPropertyInOutTrackingNumberRemoved = e.IsPropertyInOutTrackingNumberRemoved;
            dto.IsPropertyInOutDateReceivedRemoved = e.IsPropertyInOutDateReceivedRemoved;
            dto.IsPropertyInOutIsInTransitRemoved = e.IsPropertyInOutIsInTransitRemoved;
            dto.IsPropertyInOutIsApprovedRemoved = e.IsPropertyInOutIsApprovedRemoved;
            dto.IsPropertyInOutIsInDisputeRemoved = e.IsPropertyInOutIsInDisputeRemoved;
            dto.IsPropertyInOutRmaDocumentNumberRemoved = e.IsPropertyInOutRmaDocumentNumberRemoved;
            dto.IsPropertyInOutReversalDocumentNumberRemoved = e.IsPropertyInOutReversalDocumentNumberRemoved;
            dto.IsPropertyInOutCreatedByRemoved = e.IsPropertyInOutCreatedByRemoved;
            dto.IsPropertyInOutCreatedAtRemoved = e.IsPropertyInOutCreatedAtRemoved;
            dto.IsPropertyInOutUpdatedByRemoved = e.IsPropertyInOutUpdatedByRemoved;
            dto.IsPropertyInOutUpdatedAtRemoved = e.IsPropertyInOutUpdatedAtRemoved;
            dto.IsPropertyInOutActiveRemoved = e.IsPropertyInOutActiveRemoved;
            dto.IsPropertyInOutDeletedRemoved = e.IsPropertyInOutDeletedRemoved;

            return dto;
        }


        public virtual InOutLineMvoStateDeletedDto ToInOutLineMvoStateDeletedDto(IInOutLineMvoStateDeleted e)
        {
            var dto = new InOutLineMvoStateDeletedDto();
            dto.StateEventId = new InOutLineMvoStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

