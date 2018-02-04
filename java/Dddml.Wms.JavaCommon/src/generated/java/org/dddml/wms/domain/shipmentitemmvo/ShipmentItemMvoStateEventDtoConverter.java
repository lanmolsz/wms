package org.dddml.wms.domain.shipmentitemmvo;

import java.util.*;
import org.dddml.wms.domain.shipment.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class ShipmentItemMvoStateEventDtoConverter {

    public ShipmentItemMvoStateEventDto toShipmentItemMvoStateEventDto(AbstractShipmentItemMvoStateEvent stateEvent) {
        if (stateEvent instanceof AbstractShipmentItemMvoStateEvent.AbstractShipmentItemMvoStateCreated) {
            ShipmentItemMvoStateEvent.ShipmentItemMvoStateCreated e = (ShipmentItemMvoStateEvent.ShipmentItemMvoStateCreated) stateEvent;
            return toShipmentItemMvoStateCreatedDto(e);
        } else if (stateEvent instanceof AbstractShipmentItemMvoStateEvent.AbstractShipmentItemMvoStateMergePatched) {
            ShipmentItemMvoStateEvent.ShipmentItemMvoStateMergePatched e = (ShipmentItemMvoStateEvent.ShipmentItemMvoStateMergePatched) stateEvent;
            return toShipmentItemMvoStateMergePatchedDto(e);
        }

        throw DomainError.named("invalidStateEventType", String.format("Invalid state event type: %1$s", stateEvent.getStateEventType()));
    }

    public ShipmentItemMvoStateEventDto.ShipmentItemMvoStateCreatedDto toShipmentItemMvoStateCreatedDto(ShipmentItemMvoStateEvent.ShipmentItemMvoStateCreated e) {
        ShipmentItemMvoStateEventDto.ShipmentItemMvoStateCreatedDto dto = new ShipmentItemMvoStateEventDto.ShipmentItemMvoStateCreatedDto();
        dto.setStateEventId(new ShipmentItemMvoStateEventIdDtoWrapper(e.getStateEventId()));
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setProductId(e.getProductId());
        dto.setAttributeSetInstanceId(e.getAttributeSetInstanceId());
        dto.setQuantity(e.getQuantity());
        dto.setTargetQuantity(e.getTargetQuantity());
        dto.setShipmentContentDescription(e.getShipmentContentDescription());
        dto.setVersion(e.getVersion());
        dto.setActive(e.getActive());
        dto.setShipmentShipmentTypeId(e.getShipmentShipmentTypeId());
        dto.setShipmentStatusId(e.getShipmentStatusId());
        dto.setShipmentPrimaryOrderId(e.getShipmentPrimaryOrderId());
        dto.setShipmentPrimaryReturnId(e.getShipmentPrimaryReturnId());
        dto.setShipmentPicklistBinId(e.getShipmentPicklistBinId());
        dto.setShipmentEstimatedReadyDate(e.getShipmentEstimatedReadyDate());
        dto.setShipmentEstimatedShipDate(e.getShipmentEstimatedShipDate());
        dto.setShipmentEstimatedShipWorkEffId(e.getShipmentEstimatedShipWorkEffId());
        dto.setShipmentEstimatedArrivalDate(e.getShipmentEstimatedArrivalDate());
        dto.setShipmentEstimatedArrivalWorkEffId(e.getShipmentEstimatedArrivalWorkEffId());
        dto.setShipmentLatestCancelDate(e.getShipmentLatestCancelDate());
        dto.setShipmentEstimatedShipCost(e.getShipmentEstimatedShipCost());
        dto.setShipmentCurrencyUomId(e.getShipmentCurrencyUomId());
        dto.setShipmentHandlingInstructions(e.getShipmentHandlingInstructions());
        dto.setShipmentOriginFacilityId(e.getShipmentOriginFacilityId());
        dto.setShipmentDestinationFacilityId(e.getShipmentDestinationFacilityId());
        dto.setShipmentOriginContactMechId(e.getShipmentOriginContactMechId());
        dto.setShipmentOriginTelecomNumberId(e.getShipmentOriginTelecomNumberId());
        dto.setShipmentDestinationContactMechId(e.getShipmentDestinationContactMechId());
        dto.setShipmentDestinationTelecomNumberId(e.getShipmentDestinationTelecomNumberId());
        dto.setShipmentPartyIdTo(e.getShipmentPartyIdTo());
        dto.setShipmentPartyIdFrom(e.getShipmentPartyIdFrom());
        dto.setShipmentAdditionalShippingCharge(e.getShipmentAdditionalShippingCharge());
        dto.setShipmentAddtlShippingChargeDesc(e.getShipmentAddtlShippingChargeDesc());
        dto.setShipmentShipperId(e.getShipmentShipperId());
        dto.setShipmentCreatedBy(e.getShipmentCreatedBy());
        dto.setShipmentCreatedAt(e.getShipmentCreatedAt());
        dto.setShipmentUpdatedBy(e.getShipmentUpdatedBy());
        dto.setShipmentUpdatedAt(e.getShipmentUpdatedAt());
        dto.setShipmentActive(e.getShipmentActive());
        return dto;
    }

    public ShipmentItemMvoStateEventDto.ShipmentItemMvoStateMergePatchedDto toShipmentItemMvoStateMergePatchedDto(ShipmentItemMvoStateEvent.ShipmentItemMvoStateMergePatched e) {
        ShipmentItemMvoStateEventDto.ShipmentItemMvoStateMergePatchedDto dto = new ShipmentItemMvoStateEventDto.ShipmentItemMvoStateMergePatchedDto();
        dto.setStateEventId(new ShipmentItemMvoStateEventIdDtoWrapper(e.getStateEventId()));
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setProductId(e.getProductId());
        dto.setAttributeSetInstanceId(e.getAttributeSetInstanceId());
        dto.setQuantity(e.getQuantity());
        dto.setTargetQuantity(e.getTargetQuantity());
        dto.setShipmentContentDescription(e.getShipmentContentDescription());
        dto.setVersion(e.getVersion());
        dto.setActive(e.getActive());
        dto.setShipmentShipmentTypeId(e.getShipmentShipmentTypeId());
        dto.setShipmentStatusId(e.getShipmentStatusId());
        dto.setShipmentPrimaryOrderId(e.getShipmentPrimaryOrderId());
        dto.setShipmentPrimaryReturnId(e.getShipmentPrimaryReturnId());
        dto.setShipmentPicklistBinId(e.getShipmentPicklistBinId());
        dto.setShipmentEstimatedReadyDate(e.getShipmentEstimatedReadyDate());
        dto.setShipmentEstimatedShipDate(e.getShipmentEstimatedShipDate());
        dto.setShipmentEstimatedShipWorkEffId(e.getShipmentEstimatedShipWorkEffId());
        dto.setShipmentEstimatedArrivalDate(e.getShipmentEstimatedArrivalDate());
        dto.setShipmentEstimatedArrivalWorkEffId(e.getShipmentEstimatedArrivalWorkEffId());
        dto.setShipmentLatestCancelDate(e.getShipmentLatestCancelDate());
        dto.setShipmentEstimatedShipCost(e.getShipmentEstimatedShipCost());
        dto.setShipmentCurrencyUomId(e.getShipmentCurrencyUomId());
        dto.setShipmentHandlingInstructions(e.getShipmentHandlingInstructions());
        dto.setShipmentOriginFacilityId(e.getShipmentOriginFacilityId());
        dto.setShipmentDestinationFacilityId(e.getShipmentDestinationFacilityId());
        dto.setShipmentOriginContactMechId(e.getShipmentOriginContactMechId());
        dto.setShipmentOriginTelecomNumberId(e.getShipmentOriginTelecomNumberId());
        dto.setShipmentDestinationContactMechId(e.getShipmentDestinationContactMechId());
        dto.setShipmentDestinationTelecomNumberId(e.getShipmentDestinationTelecomNumberId());
        dto.setShipmentPartyIdTo(e.getShipmentPartyIdTo());
        dto.setShipmentPartyIdFrom(e.getShipmentPartyIdFrom());
        dto.setShipmentAdditionalShippingCharge(e.getShipmentAdditionalShippingCharge());
        dto.setShipmentAddtlShippingChargeDesc(e.getShipmentAddtlShippingChargeDesc());
        dto.setShipmentShipperId(e.getShipmentShipperId());
        dto.setShipmentCreatedBy(e.getShipmentCreatedBy());
        dto.setShipmentCreatedAt(e.getShipmentCreatedAt());
        dto.setShipmentUpdatedBy(e.getShipmentUpdatedBy());
        dto.setShipmentUpdatedAt(e.getShipmentUpdatedAt());
        dto.setShipmentActive(e.getShipmentActive());
        dto.setIsPropertyProductIdRemoved(e.getIsPropertyProductIdRemoved());
        dto.setIsPropertyAttributeSetInstanceIdRemoved(e.getIsPropertyAttributeSetInstanceIdRemoved());
        dto.setIsPropertyQuantityRemoved(e.getIsPropertyQuantityRemoved());
        dto.setIsPropertyTargetQuantityRemoved(e.getIsPropertyTargetQuantityRemoved());
        dto.setIsPropertyShipmentContentDescriptionRemoved(e.getIsPropertyShipmentContentDescriptionRemoved());
        dto.setIsPropertyVersionRemoved(e.getIsPropertyVersionRemoved());
        dto.setIsPropertyActiveRemoved(e.getIsPropertyActiveRemoved());
        dto.setIsPropertyShipmentShipmentTypeIdRemoved(e.getIsPropertyShipmentShipmentTypeIdRemoved());
        dto.setIsPropertyShipmentStatusIdRemoved(e.getIsPropertyShipmentStatusIdRemoved());
        dto.setIsPropertyShipmentPrimaryOrderIdRemoved(e.getIsPropertyShipmentPrimaryOrderIdRemoved());
        dto.setIsPropertyShipmentPrimaryReturnIdRemoved(e.getIsPropertyShipmentPrimaryReturnIdRemoved());
        dto.setIsPropertyShipmentPicklistBinIdRemoved(e.getIsPropertyShipmentPicklistBinIdRemoved());
        dto.setIsPropertyShipmentEstimatedReadyDateRemoved(e.getIsPropertyShipmentEstimatedReadyDateRemoved());
        dto.setIsPropertyShipmentEstimatedShipDateRemoved(e.getIsPropertyShipmentEstimatedShipDateRemoved());
        dto.setIsPropertyShipmentEstimatedShipWorkEffIdRemoved(e.getIsPropertyShipmentEstimatedShipWorkEffIdRemoved());
        dto.setIsPropertyShipmentEstimatedArrivalDateRemoved(e.getIsPropertyShipmentEstimatedArrivalDateRemoved());
        dto.setIsPropertyShipmentEstimatedArrivalWorkEffIdRemoved(e.getIsPropertyShipmentEstimatedArrivalWorkEffIdRemoved());
        dto.setIsPropertyShipmentLatestCancelDateRemoved(e.getIsPropertyShipmentLatestCancelDateRemoved());
        dto.setIsPropertyShipmentEstimatedShipCostRemoved(e.getIsPropertyShipmentEstimatedShipCostRemoved());
        dto.setIsPropertyShipmentCurrencyUomIdRemoved(e.getIsPropertyShipmentCurrencyUomIdRemoved());
        dto.setIsPropertyShipmentHandlingInstructionsRemoved(e.getIsPropertyShipmentHandlingInstructionsRemoved());
        dto.setIsPropertyShipmentOriginFacilityIdRemoved(e.getIsPropertyShipmentOriginFacilityIdRemoved());
        dto.setIsPropertyShipmentDestinationFacilityIdRemoved(e.getIsPropertyShipmentDestinationFacilityIdRemoved());
        dto.setIsPropertyShipmentOriginContactMechIdRemoved(e.getIsPropertyShipmentOriginContactMechIdRemoved());
        dto.setIsPropertyShipmentOriginTelecomNumberIdRemoved(e.getIsPropertyShipmentOriginTelecomNumberIdRemoved());
        dto.setIsPropertyShipmentDestinationContactMechIdRemoved(e.getIsPropertyShipmentDestinationContactMechIdRemoved());
        dto.setIsPropertyShipmentDestinationTelecomNumberIdRemoved(e.getIsPropertyShipmentDestinationTelecomNumberIdRemoved());
        dto.setIsPropertyShipmentPartyIdToRemoved(e.getIsPropertyShipmentPartyIdToRemoved());
        dto.setIsPropertyShipmentPartyIdFromRemoved(e.getIsPropertyShipmentPartyIdFromRemoved());
        dto.setIsPropertyShipmentAdditionalShippingChargeRemoved(e.getIsPropertyShipmentAdditionalShippingChargeRemoved());
        dto.setIsPropertyShipmentAddtlShippingChargeDescRemoved(e.getIsPropertyShipmentAddtlShippingChargeDescRemoved());
        dto.setIsPropertyShipmentShipperIdRemoved(e.getIsPropertyShipmentShipperIdRemoved());
        dto.setIsPropertyShipmentCreatedByRemoved(e.getIsPropertyShipmentCreatedByRemoved());
        dto.setIsPropertyShipmentCreatedAtRemoved(e.getIsPropertyShipmentCreatedAtRemoved());
        dto.setIsPropertyShipmentUpdatedByRemoved(e.getIsPropertyShipmentUpdatedByRemoved());
        dto.setIsPropertyShipmentUpdatedAtRemoved(e.getIsPropertyShipmentUpdatedAtRemoved());
        dto.setIsPropertyShipmentActiveRemoved(e.getIsPropertyShipmentActiveRemoved());
        return dto;
    }


}
