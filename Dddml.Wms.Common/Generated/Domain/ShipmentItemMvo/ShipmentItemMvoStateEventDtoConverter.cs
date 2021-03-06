﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItemMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentItemMvo
{

    public class ShipmentItemMvoStateEventDtoConverter
    {
        public virtual ShipmentItemMvoStateCreatedOrMergePatchedOrDeletedDto ToShipmentItemMvoStateEventDto(IShipmentItemMvoEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (IShipmentItemMvoStateCreated)stateEvent;
                return ToShipmentItemMvoStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (IShipmentItemMvoStateMergePatched)stateEvent;
                return ToShipmentItemMvoStateMergePatchedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual ShipmentItemMvoStateCreatedDto ToShipmentItemMvoStateCreatedDto(IShipmentItemMvoStateCreated e)
        {
            var dto = new ShipmentItemMvoStateCreatedDto();
            dto.ShipmentItemMvoEventId = e.ShipmentItemMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ProductId = e.ProductId;
            dto.AttributeSetInstanceId = e.AttributeSetInstanceId;
            dto.Quantity = e.Quantity;
            dto.ShipmentContentDescription = e.ShipmentContentDescription;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.ShipmentShipmentTypeId = e.ShipmentShipmentTypeId;
            dto.ShipmentStatusId = e.ShipmentStatusId;
            dto.ShipmentPrimaryOrderId = e.ShipmentPrimaryOrderId;
            dto.ShipmentPrimaryReturnId = e.ShipmentPrimaryReturnId;
            dto.ShipmentPrimaryShipGroupSeqId = e.ShipmentPrimaryShipGroupSeqId;
            dto.ShipmentPicklistBinId = e.ShipmentPicklistBinId;
            dto.ShipmentEstimatedReadyDate = e.ShipmentEstimatedReadyDate;
            dto.ShipmentEstimatedShipDate = e.ShipmentEstimatedShipDate;
            dto.ShipmentEstimatedShipWorkEffId = e.ShipmentEstimatedShipWorkEffId;
            dto.ShipmentEstimatedArrivalDate = e.ShipmentEstimatedArrivalDate;
            dto.ShipmentEstimatedArrivalWorkEffId = e.ShipmentEstimatedArrivalWorkEffId;
            dto.ShipmentLatestCancelDate = e.ShipmentLatestCancelDate;
            dto.ShipmentEstimatedShipCost = e.ShipmentEstimatedShipCost;
            dto.ShipmentCurrencyUomId = e.ShipmentCurrencyUomId;
            dto.ShipmentHandlingInstructions = e.ShipmentHandlingInstructions;
            dto.ShipmentOriginFacilityId = e.ShipmentOriginFacilityId;
            dto.ShipmentDestinationFacilityId = e.ShipmentDestinationFacilityId;
            dto.ShipmentOriginContactMechId = e.ShipmentOriginContactMechId;
            dto.ShipmentOriginTelecomNumberId = e.ShipmentOriginTelecomNumberId;
            dto.ShipmentDestinationContactMechId = e.ShipmentDestinationContactMechId;
            dto.ShipmentDestinationTelecomNumberId = e.ShipmentDestinationTelecomNumberId;
            dto.ShipmentPartyIdTo = e.ShipmentPartyIdTo;
            dto.ShipmentPartyIdFrom = e.ShipmentPartyIdFrom;
            dto.ShipmentAdditionalShippingCharge = e.ShipmentAdditionalShippingCharge;
            dto.ShipmentAddtlShippingChargeDesc = e.ShipmentAddtlShippingChargeDesc;
            dto.ShipmentCreatedBy = e.ShipmentCreatedBy;
            dto.ShipmentCreatedAt = e.ShipmentCreatedAt;
            dto.ShipmentUpdatedBy = e.ShipmentUpdatedBy;
            dto.ShipmentUpdatedAt = e.ShipmentUpdatedAt;
            dto.ShipmentActive = e.ShipmentActive;
            return dto;
        }

        public virtual ShipmentItemMvoStateMergePatchedDto ToShipmentItemMvoStateMergePatchedDto(IShipmentItemMvoStateMergePatched e)
        {
            var dto = new ShipmentItemMvoStateMergePatchedDto();
            dto.ShipmentItemMvoEventId = e.ShipmentItemMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ProductId = e.ProductId;
            dto.AttributeSetInstanceId = e.AttributeSetInstanceId;
            dto.Quantity = e.Quantity;
            dto.ShipmentContentDescription = e.ShipmentContentDescription;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.ShipmentShipmentTypeId = e.ShipmentShipmentTypeId;
            dto.ShipmentStatusId = e.ShipmentStatusId;
            dto.ShipmentPrimaryOrderId = e.ShipmentPrimaryOrderId;
            dto.ShipmentPrimaryReturnId = e.ShipmentPrimaryReturnId;
            dto.ShipmentPrimaryShipGroupSeqId = e.ShipmentPrimaryShipGroupSeqId;
            dto.ShipmentPicklistBinId = e.ShipmentPicklistBinId;
            dto.ShipmentEstimatedReadyDate = e.ShipmentEstimatedReadyDate;
            dto.ShipmentEstimatedShipDate = e.ShipmentEstimatedShipDate;
            dto.ShipmentEstimatedShipWorkEffId = e.ShipmentEstimatedShipWorkEffId;
            dto.ShipmentEstimatedArrivalDate = e.ShipmentEstimatedArrivalDate;
            dto.ShipmentEstimatedArrivalWorkEffId = e.ShipmentEstimatedArrivalWorkEffId;
            dto.ShipmentLatestCancelDate = e.ShipmentLatestCancelDate;
            dto.ShipmentEstimatedShipCost = e.ShipmentEstimatedShipCost;
            dto.ShipmentCurrencyUomId = e.ShipmentCurrencyUomId;
            dto.ShipmentHandlingInstructions = e.ShipmentHandlingInstructions;
            dto.ShipmentOriginFacilityId = e.ShipmentOriginFacilityId;
            dto.ShipmentDestinationFacilityId = e.ShipmentDestinationFacilityId;
            dto.ShipmentOriginContactMechId = e.ShipmentOriginContactMechId;
            dto.ShipmentOriginTelecomNumberId = e.ShipmentOriginTelecomNumberId;
            dto.ShipmentDestinationContactMechId = e.ShipmentDestinationContactMechId;
            dto.ShipmentDestinationTelecomNumberId = e.ShipmentDestinationTelecomNumberId;
            dto.ShipmentPartyIdTo = e.ShipmentPartyIdTo;
            dto.ShipmentPartyIdFrom = e.ShipmentPartyIdFrom;
            dto.ShipmentAdditionalShippingCharge = e.ShipmentAdditionalShippingCharge;
            dto.ShipmentAddtlShippingChargeDesc = e.ShipmentAddtlShippingChargeDesc;
            dto.ShipmentCreatedBy = e.ShipmentCreatedBy;
            dto.ShipmentCreatedAt = e.ShipmentCreatedAt;
            dto.ShipmentUpdatedBy = e.ShipmentUpdatedBy;
            dto.ShipmentUpdatedAt = e.ShipmentUpdatedAt;
            dto.ShipmentActive = e.ShipmentActive;
            dto.IsPropertyProductIdRemoved = e.IsPropertyProductIdRemoved;
            dto.IsPropertyAttributeSetInstanceIdRemoved = e.IsPropertyAttributeSetInstanceIdRemoved;
            dto.IsPropertyQuantityRemoved = e.IsPropertyQuantityRemoved;
            dto.IsPropertyShipmentContentDescriptionRemoved = e.IsPropertyShipmentContentDescriptionRemoved;
            dto.IsPropertyVersionRemoved = e.IsPropertyVersionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;
            dto.IsPropertyShipmentShipmentTypeIdRemoved = e.IsPropertyShipmentShipmentTypeIdRemoved;
            dto.IsPropertyShipmentStatusIdRemoved = e.IsPropertyShipmentStatusIdRemoved;
            dto.IsPropertyShipmentPrimaryOrderIdRemoved = e.IsPropertyShipmentPrimaryOrderIdRemoved;
            dto.IsPropertyShipmentPrimaryReturnIdRemoved = e.IsPropertyShipmentPrimaryReturnIdRemoved;
            dto.IsPropertyShipmentPrimaryShipGroupSeqIdRemoved = e.IsPropertyShipmentPrimaryShipGroupSeqIdRemoved;
            dto.IsPropertyShipmentPicklistBinIdRemoved = e.IsPropertyShipmentPicklistBinIdRemoved;
            dto.IsPropertyShipmentEstimatedReadyDateRemoved = e.IsPropertyShipmentEstimatedReadyDateRemoved;
            dto.IsPropertyShipmentEstimatedShipDateRemoved = e.IsPropertyShipmentEstimatedShipDateRemoved;
            dto.IsPropertyShipmentEstimatedShipWorkEffIdRemoved = e.IsPropertyShipmentEstimatedShipWorkEffIdRemoved;
            dto.IsPropertyShipmentEstimatedArrivalDateRemoved = e.IsPropertyShipmentEstimatedArrivalDateRemoved;
            dto.IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved = e.IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved;
            dto.IsPropertyShipmentLatestCancelDateRemoved = e.IsPropertyShipmentLatestCancelDateRemoved;
            dto.IsPropertyShipmentEstimatedShipCostRemoved = e.IsPropertyShipmentEstimatedShipCostRemoved;
            dto.IsPropertyShipmentCurrencyUomIdRemoved = e.IsPropertyShipmentCurrencyUomIdRemoved;
            dto.IsPropertyShipmentHandlingInstructionsRemoved = e.IsPropertyShipmentHandlingInstructionsRemoved;
            dto.IsPropertyShipmentOriginFacilityIdRemoved = e.IsPropertyShipmentOriginFacilityIdRemoved;
            dto.IsPropertyShipmentDestinationFacilityIdRemoved = e.IsPropertyShipmentDestinationFacilityIdRemoved;
            dto.IsPropertyShipmentOriginContactMechIdRemoved = e.IsPropertyShipmentOriginContactMechIdRemoved;
            dto.IsPropertyShipmentOriginTelecomNumberIdRemoved = e.IsPropertyShipmentOriginTelecomNumberIdRemoved;
            dto.IsPropertyShipmentDestinationContactMechIdRemoved = e.IsPropertyShipmentDestinationContactMechIdRemoved;
            dto.IsPropertyShipmentDestinationTelecomNumberIdRemoved = e.IsPropertyShipmentDestinationTelecomNumberIdRemoved;
            dto.IsPropertyShipmentPartyIdToRemoved = e.IsPropertyShipmentPartyIdToRemoved;
            dto.IsPropertyShipmentPartyIdFromRemoved = e.IsPropertyShipmentPartyIdFromRemoved;
            dto.IsPropertyShipmentAdditionalShippingChargeRemoved = e.IsPropertyShipmentAdditionalShippingChargeRemoved;
            dto.IsPropertyShipmentAddtlShippingChargeDescRemoved = e.IsPropertyShipmentAddtlShippingChargeDescRemoved;
            dto.IsPropertyShipmentCreatedByRemoved = e.IsPropertyShipmentCreatedByRemoved;
            dto.IsPropertyShipmentCreatedAtRemoved = e.IsPropertyShipmentCreatedAtRemoved;
            dto.IsPropertyShipmentUpdatedByRemoved = e.IsPropertyShipmentUpdatedByRemoved;
            dto.IsPropertyShipmentUpdatedAtRemoved = e.IsPropertyShipmentUpdatedAtRemoved;
            dto.IsPropertyShipmentActiveRemoved = e.IsPropertyShipmentActiveRemoved;

            return dto;
        }



    }


}

