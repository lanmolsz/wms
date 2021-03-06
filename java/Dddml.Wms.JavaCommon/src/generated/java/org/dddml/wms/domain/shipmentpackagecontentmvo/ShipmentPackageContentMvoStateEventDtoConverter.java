package org.dddml.wms.domain.shipmentpackagecontentmvo;

import java.util.*;
import org.dddml.wms.domain.shipmentpackage.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class ShipmentPackageContentMvoStateEventDtoConverter {

    public ShipmentPackageContentMvoStateEventDto toShipmentPackageContentMvoStateEventDto(AbstractShipmentPackageContentMvoEvent stateEvent) {
        if (stateEvent instanceof AbstractShipmentPackageContentMvoEvent.AbstractShipmentPackageContentMvoStateCreated) {
            ShipmentPackageContentMvoEvent.ShipmentPackageContentMvoStateCreated e = (ShipmentPackageContentMvoEvent.ShipmentPackageContentMvoStateCreated) stateEvent;
            return toShipmentPackageContentMvoStateCreatedDto(e);
        } else if (stateEvent instanceof AbstractShipmentPackageContentMvoEvent.AbstractShipmentPackageContentMvoStateMergePatched) {
            ShipmentPackageContentMvoEvent.ShipmentPackageContentMvoStateMergePatched e = (ShipmentPackageContentMvoEvent.ShipmentPackageContentMvoStateMergePatched) stateEvent;
            return toShipmentPackageContentMvoStateMergePatchedDto(e);
        } else if (stateEvent instanceof AbstractShipmentPackageContentMvoEvent.AbstractShipmentPackageContentMvoStateDeleted) {
            ShipmentPackageContentMvoEvent.ShipmentPackageContentMvoStateDeleted e = (ShipmentPackageContentMvoEvent.ShipmentPackageContentMvoStateDeleted) stateEvent;
            return toShipmentPackageContentMvoStateDeletedDto(e);
        }

        throw DomainError.named("invalidEventType", String.format("Invalid state event type: %1$s", stateEvent.getEventType()));
    }

    public ShipmentPackageContentMvoStateEventDto.ShipmentPackageContentMvoStateCreatedDto toShipmentPackageContentMvoStateCreatedDto(ShipmentPackageContentMvoEvent.ShipmentPackageContentMvoStateCreated e) {
        ShipmentPackageContentMvoStateEventDto.ShipmentPackageContentMvoStateCreatedDto dto = new ShipmentPackageContentMvoStateEventDto.ShipmentPackageContentMvoStateCreatedDto();
        dto.setShipmentPackageContentMvoEventId(e.getShipmentPackageContentMvoEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setQuantity(e.getQuantity());
        dto.setSubProductId(e.getSubProductId());
        dto.setSubProductQuantity(e.getSubProductQuantity());
        dto.setVersion(e.getVersion());
        dto.setActive(e.getActive());
        dto.setShipmentPackageShipmentBoxTypeId(e.getShipmentPackageShipmentBoxTypeId());
        dto.setShipmentPackageDateCreated(e.getShipmentPackageDateCreated());
        dto.setShipmentPackageBoxLength(e.getShipmentPackageBoxLength());
        dto.setShipmentPackageBoxHeight(e.getShipmentPackageBoxHeight());
        dto.setShipmentPackageBoxWidth(e.getShipmentPackageBoxWidth());
        dto.setShipmentPackageDimensionUomId(e.getShipmentPackageDimensionUomId());
        dto.setShipmentPackageWeight(e.getShipmentPackageWeight());
        dto.setShipmentPackageWeightUomId(e.getShipmentPackageWeightUomId());
        dto.setShipmentPackageInsuredValue(e.getShipmentPackageInsuredValue());
        dto.setShipmentPackageCreatedBy(e.getShipmentPackageCreatedBy());
        dto.setShipmentPackageCreatedAt(e.getShipmentPackageCreatedAt());
        dto.setShipmentPackageUpdatedBy(e.getShipmentPackageUpdatedBy());
        dto.setShipmentPackageUpdatedAt(e.getShipmentPackageUpdatedAt());
        dto.setShipmentPackageActive(e.getShipmentPackageActive());
        dto.setShipmentPackageDeleted(e.getShipmentPackageDeleted());
        return dto;
    }

    public ShipmentPackageContentMvoStateEventDto.ShipmentPackageContentMvoStateMergePatchedDto toShipmentPackageContentMvoStateMergePatchedDto(ShipmentPackageContentMvoEvent.ShipmentPackageContentMvoStateMergePatched e) {
        ShipmentPackageContentMvoStateEventDto.ShipmentPackageContentMvoStateMergePatchedDto dto = new ShipmentPackageContentMvoStateEventDto.ShipmentPackageContentMvoStateMergePatchedDto();
        dto.setShipmentPackageContentMvoEventId(e.getShipmentPackageContentMvoEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setQuantity(e.getQuantity());
        dto.setSubProductId(e.getSubProductId());
        dto.setSubProductQuantity(e.getSubProductQuantity());
        dto.setVersion(e.getVersion());
        dto.setActive(e.getActive());
        dto.setShipmentPackageShipmentBoxTypeId(e.getShipmentPackageShipmentBoxTypeId());
        dto.setShipmentPackageDateCreated(e.getShipmentPackageDateCreated());
        dto.setShipmentPackageBoxLength(e.getShipmentPackageBoxLength());
        dto.setShipmentPackageBoxHeight(e.getShipmentPackageBoxHeight());
        dto.setShipmentPackageBoxWidth(e.getShipmentPackageBoxWidth());
        dto.setShipmentPackageDimensionUomId(e.getShipmentPackageDimensionUomId());
        dto.setShipmentPackageWeight(e.getShipmentPackageWeight());
        dto.setShipmentPackageWeightUomId(e.getShipmentPackageWeightUomId());
        dto.setShipmentPackageInsuredValue(e.getShipmentPackageInsuredValue());
        dto.setShipmentPackageCreatedBy(e.getShipmentPackageCreatedBy());
        dto.setShipmentPackageCreatedAt(e.getShipmentPackageCreatedAt());
        dto.setShipmentPackageUpdatedBy(e.getShipmentPackageUpdatedBy());
        dto.setShipmentPackageUpdatedAt(e.getShipmentPackageUpdatedAt());
        dto.setShipmentPackageActive(e.getShipmentPackageActive());
        dto.setShipmentPackageDeleted(e.getShipmentPackageDeleted());
        dto.setIsPropertyQuantityRemoved(e.getIsPropertyQuantityRemoved());
        dto.setIsPropertySubProductIdRemoved(e.getIsPropertySubProductIdRemoved());
        dto.setIsPropertySubProductQuantityRemoved(e.getIsPropertySubProductQuantityRemoved());
        dto.setIsPropertyVersionRemoved(e.getIsPropertyVersionRemoved());
        dto.setIsPropertyActiveRemoved(e.getIsPropertyActiveRemoved());
        dto.setIsPropertyShipmentPackageShipmentBoxTypeIdRemoved(e.getIsPropertyShipmentPackageShipmentBoxTypeIdRemoved());
        dto.setIsPropertyShipmentPackageDateCreatedRemoved(e.getIsPropertyShipmentPackageDateCreatedRemoved());
        dto.setIsPropertyShipmentPackageBoxLengthRemoved(e.getIsPropertyShipmentPackageBoxLengthRemoved());
        dto.setIsPropertyShipmentPackageBoxHeightRemoved(e.getIsPropertyShipmentPackageBoxHeightRemoved());
        dto.setIsPropertyShipmentPackageBoxWidthRemoved(e.getIsPropertyShipmentPackageBoxWidthRemoved());
        dto.setIsPropertyShipmentPackageDimensionUomIdRemoved(e.getIsPropertyShipmentPackageDimensionUomIdRemoved());
        dto.setIsPropertyShipmentPackageWeightRemoved(e.getIsPropertyShipmentPackageWeightRemoved());
        dto.setIsPropertyShipmentPackageWeightUomIdRemoved(e.getIsPropertyShipmentPackageWeightUomIdRemoved());
        dto.setIsPropertyShipmentPackageInsuredValueRemoved(e.getIsPropertyShipmentPackageInsuredValueRemoved());
        dto.setIsPropertyShipmentPackageCreatedByRemoved(e.getIsPropertyShipmentPackageCreatedByRemoved());
        dto.setIsPropertyShipmentPackageCreatedAtRemoved(e.getIsPropertyShipmentPackageCreatedAtRemoved());
        dto.setIsPropertyShipmentPackageUpdatedByRemoved(e.getIsPropertyShipmentPackageUpdatedByRemoved());
        dto.setIsPropertyShipmentPackageUpdatedAtRemoved(e.getIsPropertyShipmentPackageUpdatedAtRemoved());
        dto.setIsPropertyShipmentPackageActiveRemoved(e.getIsPropertyShipmentPackageActiveRemoved());
        dto.setIsPropertyShipmentPackageDeletedRemoved(e.getIsPropertyShipmentPackageDeletedRemoved());
        return dto;
    }


    public ShipmentPackageContentMvoStateEventDto.ShipmentPackageContentMvoStateDeletedDto toShipmentPackageContentMvoStateDeletedDto(ShipmentPackageContentMvoEvent.ShipmentPackageContentMvoStateDeleted e) {
        ShipmentPackageContentMvoStateEventDto.ShipmentPackageContentMvoStateDeletedDto dto = new ShipmentPackageContentMvoStateEventDto.ShipmentPackageContentMvoStateDeletedDto();
        dto.setShipmentPackageContentMvoEventId(e.getShipmentPackageContentMvoEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        return dto;
    }

}

