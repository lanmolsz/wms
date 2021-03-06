package org.dddml.wms.domain.shipmentreceiptmvo;

import java.util.*;
import org.dddml.wms.domain.shipment.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class ShipmentReceiptMvoStateEventDtoConverter {

    public ShipmentReceiptMvoStateEventDto toShipmentReceiptMvoStateEventDto(AbstractShipmentReceiptMvoEvent stateEvent) {
        if (stateEvent instanceof AbstractShipmentReceiptMvoEvent.AbstractShipmentReceiptMvoStateCreated) {
            ShipmentReceiptMvoEvent.ShipmentReceiptMvoStateCreated e = (ShipmentReceiptMvoEvent.ShipmentReceiptMvoStateCreated) stateEvent;
            return toShipmentReceiptMvoStateCreatedDto(e);
        } else if (stateEvent instanceof AbstractShipmentReceiptMvoEvent.AbstractShipmentReceiptMvoStateMergePatched) {
            ShipmentReceiptMvoEvent.ShipmentReceiptMvoStateMergePatched e = (ShipmentReceiptMvoEvent.ShipmentReceiptMvoStateMergePatched) stateEvent;
            return toShipmentReceiptMvoStateMergePatchedDto(e);
        }

        throw DomainError.named("invalidEventType", String.format("Invalid state event type: %1$s", stateEvent.getEventType()));
    }

    public ShipmentReceiptMvoStateEventDto.ShipmentReceiptMvoStateCreatedDto toShipmentReceiptMvoStateCreatedDto(ShipmentReceiptMvoEvent.ShipmentReceiptMvoStateCreated e) {
        ShipmentReceiptMvoStateEventDto.ShipmentReceiptMvoStateCreatedDto dto = new ShipmentReceiptMvoStateEventDto.ShipmentReceiptMvoStateCreatedDto();
        dto.setShipmentReceiptMvoEventId(e.getShipmentReceiptMvoEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setProductId(e.getProductId());
        dto.setAttributeSetInstanceId(e.getAttributeSetInstanceId());
        dto.setLocatorId(e.getLocatorId());
        dto.setShipmentItemSeqId(e.getShipmentItemSeqId());
        dto.setShipmentPackageSeqId(e.getShipmentPackageSeqId());
        dto.setOrderId(e.getOrderId());
        dto.setOrderItemSeqId(e.getOrderItemSeqId());
        dto.setReturnId(e.getReturnId());
        dto.setReturnItemSeqId(e.getReturnItemSeqId());
        dto.setRejectionReasonId(e.getRejectionReasonId());
        dto.setDamageStatusId(e.getDamageStatusId());
        dto.setDamageReasonId(e.getDamageReasonId());
        dto.setReceivedBy(e.getReceivedBy());
        dto.setDatetimeReceived(e.getDatetimeReceived());
        dto.setItemDescription(e.getItemDescription());
        dto.setAcceptedQuantity(e.getAcceptedQuantity());
        dto.setRejectedQuantity(e.getRejectedQuantity());
        dto.setDamagedQuantity(e.getDamagedQuantity());
        dto.setVersion(e.getVersion());
        dto.setActive(e.getActive());
        dto.setShipmentShipmentTypeId(e.getShipmentShipmentTypeId());
        dto.setShipmentStatusId(e.getShipmentStatusId());
        dto.setShipmentPrimaryOrderId(e.getShipmentPrimaryOrderId());
        dto.setShipmentPrimaryReturnId(e.getShipmentPrimaryReturnId());
        dto.setShipmentPrimaryShipGroupSeqId(e.getShipmentPrimaryShipGroupSeqId());
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
        dto.setShipmentCreatedBy(e.getShipmentCreatedBy());
        dto.setShipmentCreatedAt(e.getShipmentCreatedAt());
        dto.setShipmentUpdatedBy(e.getShipmentUpdatedBy());
        dto.setShipmentUpdatedAt(e.getShipmentUpdatedAt());
        dto.setShipmentActive(e.getShipmentActive());
        return dto;
    }

    public ShipmentReceiptMvoStateEventDto.ShipmentReceiptMvoStateMergePatchedDto toShipmentReceiptMvoStateMergePatchedDto(ShipmentReceiptMvoEvent.ShipmentReceiptMvoStateMergePatched e) {
        ShipmentReceiptMvoStateEventDto.ShipmentReceiptMvoStateMergePatchedDto dto = new ShipmentReceiptMvoStateEventDto.ShipmentReceiptMvoStateMergePatchedDto();
        dto.setShipmentReceiptMvoEventId(e.getShipmentReceiptMvoEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setProductId(e.getProductId());
        dto.setAttributeSetInstanceId(e.getAttributeSetInstanceId());
        dto.setLocatorId(e.getLocatorId());
        dto.setShipmentItemSeqId(e.getShipmentItemSeqId());
        dto.setShipmentPackageSeqId(e.getShipmentPackageSeqId());
        dto.setOrderId(e.getOrderId());
        dto.setOrderItemSeqId(e.getOrderItemSeqId());
        dto.setReturnId(e.getReturnId());
        dto.setReturnItemSeqId(e.getReturnItemSeqId());
        dto.setRejectionReasonId(e.getRejectionReasonId());
        dto.setDamageStatusId(e.getDamageStatusId());
        dto.setDamageReasonId(e.getDamageReasonId());
        dto.setReceivedBy(e.getReceivedBy());
        dto.setDatetimeReceived(e.getDatetimeReceived());
        dto.setItemDescription(e.getItemDescription());
        dto.setAcceptedQuantity(e.getAcceptedQuantity());
        dto.setRejectedQuantity(e.getRejectedQuantity());
        dto.setDamagedQuantity(e.getDamagedQuantity());
        dto.setVersion(e.getVersion());
        dto.setActive(e.getActive());
        dto.setShipmentShipmentTypeId(e.getShipmentShipmentTypeId());
        dto.setShipmentStatusId(e.getShipmentStatusId());
        dto.setShipmentPrimaryOrderId(e.getShipmentPrimaryOrderId());
        dto.setShipmentPrimaryReturnId(e.getShipmentPrimaryReturnId());
        dto.setShipmentPrimaryShipGroupSeqId(e.getShipmentPrimaryShipGroupSeqId());
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
        dto.setShipmentCreatedBy(e.getShipmentCreatedBy());
        dto.setShipmentCreatedAt(e.getShipmentCreatedAt());
        dto.setShipmentUpdatedBy(e.getShipmentUpdatedBy());
        dto.setShipmentUpdatedAt(e.getShipmentUpdatedAt());
        dto.setShipmentActive(e.getShipmentActive());
        dto.setIsPropertyProductIdRemoved(e.getIsPropertyProductIdRemoved());
        dto.setIsPropertyAttributeSetInstanceIdRemoved(e.getIsPropertyAttributeSetInstanceIdRemoved());
        dto.setIsPropertyLocatorIdRemoved(e.getIsPropertyLocatorIdRemoved());
        dto.setIsPropertyShipmentItemSeqIdRemoved(e.getIsPropertyShipmentItemSeqIdRemoved());
        dto.setIsPropertyShipmentPackageSeqIdRemoved(e.getIsPropertyShipmentPackageSeqIdRemoved());
        dto.setIsPropertyOrderIdRemoved(e.getIsPropertyOrderIdRemoved());
        dto.setIsPropertyOrderItemSeqIdRemoved(e.getIsPropertyOrderItemSeqIdRemoved());
        dto.setIsPropertyReturnIdRemoved(e.getIsPropertyReturnIdRemoved());
        dto.setIsPropertyReturnItemSeqIdRemoved(e.getIsPropertyReturnItemSeqIdRemoved());
        dto.setIsPropertyRejectionReasonIdRemoved(e.getIsPropertyRejectionReasonIdRemoved());
        dto.setIsPropertyDamageStatusIdRemoved(e.getIsPropertyDamageStatusIdRemoved());
        dto.setIsPropertyDamageReasonIdRemoved(e.getIsPropertyDamageReasonIdRemoved());
        dto.setIsPropertyReceivedByRemoved(e.getIsPropertyReceivedByRemoved());
        dto.setIsPropertyDatetimeReceivedRemoved(e.getIsPropertyDatetimeReceivedRemoved());
        dto.setIsPropertyItemDescriptionRemoved(e.getIsPropertyItemDescriptionRemoved());
        dto.setIsPropertyAcceptedQuantityRemoved(e.getIsPropertyAcceptedQuantityRemoved());
        dto.setIsPropertyRejectedQuantityRemoved(e.getIsPropertyRejectedQuantityRemoved());
        dto.setIsPropertyDamagedQuantityRemoved(e.getIsPropertyDamagedQuantityRemoved());
        dto.setIsPropertyVersionRemoved(e.getIsPropertyVersionRemoved());
        dto.setIsPropertyActiveRemoved(e.getIsPropertyActiveRemoved());
        dto.setIsPropertyShipmentShipmentTypeIdRemoved(e.getIsPropertyShipmentShipmentTypeIdRemoved());
        dto.setIsPropertyShipmentStatusIdRemoved(e.getIsPropertyShipmentStatusIdRemoved());
        dto.setIsPropertyShipmentPrimaryOrderIdRemoved(e.getIsPropertyShipmentPrimaryOrderIdRemoved());
        dto.setIsPropertyShipmentPrimaryReturnIdRemoved(e.getIsPropertyShipmentPrimaryReturnIdRemoved());
        dto.setIsPropertyShipmentPrimaryShipGroupSeqIdRemoved(e.getIsPropertyShipmentPrimaryShipGroupSeqIdRemoved());
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
        dto.setIsPropertyShipmentCreatedByRemoved(e.getIsPropertyShipmentCreatedByRemoved());
        dto.setIsPropertyShipmentCreatedAtRemoved(e.getIsPropertyShipmentCreatedAtRemoved());
        dto.setIsPropertyShipmentUpdatedByRemoved(e.getIsPropertyShipmentUpdatedByRemoved());
        dto.setIsPropertyShipmentUpdatedAtRemoved(e.getIsPropertyShipmentUpdatedAtRemoved());
        dto.setIsPropertyShipmentActiveRemoved(e.getIsPropertyShipmentActiveRemoved());
        return dto;
    }


}

