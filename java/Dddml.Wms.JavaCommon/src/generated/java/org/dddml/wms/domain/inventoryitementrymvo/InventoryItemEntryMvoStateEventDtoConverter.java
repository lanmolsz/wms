package org.dddml.wms.domain.inventoryitementrymvo;

import java.util.*;
import org.dddml.wms.domain.inventoryitem.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class InventoryItemEntryMvoStateEventDtoConverter {

    public InventoryItemEntryMvoStateEventDto toInventoryItemEntryMvoStateEventDto(AbstractInventoryItemEntryMvoEvent stateEvent) {
        if (stateEvent instanceof AbstractInventoryItemEntryMvoEvent.AbstractInventoryItemEntryMvoStateCreated) {
            InventoryItemEntryMvoEvent.InventoryItemEntryMvoStateCreated e = (InventoryItemEntryMvoEvent.InventoryItemEntryMvoStateCreated) stateEvent;
            return toInventoryItemEntryMvoStateCreatedDto(e);
        } else if (stateEvent instanceof AbstractInventoryItemEntryMvoEvent.AbstractInventoryItemEntryMvoStateMergePatched) {
            InventoryItemEntryMvoEvent.InventoryItemEntryMvoStateMergePatched e = (InventoryItemEntryMvoEvent.InventoryItemEntryMvoStateMergePatched) stateEvent;
            return toInventoryItemEntryMvoStateMergePatchedDto(e);
        }

        throw DomainError.named("invalidEventType", String.format("Invalid state event type: %1$s", stateEvent.getEventType()));
    }

    public InventoryItemEntryMvoStateEventDto.InventoryItemEntryMvoStateCreatedDto toInventoryItemEntryMvoStateCreatedDto(InventoryItemEntryMvoEvent.InventoryItemEntryMvoStateCreated e) {
        InventoryItemEntryMvoStateEventDto.InventoryItemEntryMvoStateCreatedDto dto = new InventoryItemEntryMvoStateEventDto.InventoryItemEntryMvoStateCreatedDto();
        dto.setInventoryItemEntryMvoEventId(e.getInventoryItemEntryMvoEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setOnHandQuantity(e.getOnHandQuantity());
        dto.setInTransitQuantity(e.getInTransitQuantity());
        dto.setReservedQuantity(e.getReservedQuantity());
        dto.setOccupiedQuantity(e.getOccupiedQuantity());
        dto.setVirtualQuantity(e.getVirtualQuantity());
        dto.setSource(e.getSource());
        dto.setVersion(e.getVersion());
        dto.setInventoryItemOnHandQuantity(e.getInventoryItemOnHandQuantity());
        dto.setInventoryItemInTransitQuantity(e.getInventoryItemInTransitQuantity());
        dto.setInventoryItemReservedQuantity(e.getInventoryItemReservedQuantity());
        dto.setInventoryItemOccupiedQuantity(e.getInventoryItemOccupiedQuantity());
        dto.setInventoryItemVirtualQuantity(e.getInventoryItemVirtualQuantity());
        dto.setInventoryItemCreatedBy(e.getInventoryItemCreatedBy());
        dto.setInventoryItemCreatedAt(e.getInventoryItemCreatedAt());
        dto.setInventoryItemUpdatedBy(e.getInventoryItemUpdatedBy());
        dto.setInventoryItemUpdatedAt(e.getInventoryItemUpdatedAt());
        return dto;
    }

    public InventoryItemEntryMvoStateEventDto.InventoryItemEntryMvoStateMergePatchedDto toInventoryItemEntryMvoStateMergePatchedDto(InventoryItemEntryMvoEvent.InventoryItemEntryMvoStateMergePatched e) {
        InventoryItemEntryMvoStateEventDto.InventoryItemEntryMvoStateMergePatchedDto dto = new InventoryItemEntryMvoStateEventDto.InventoryItemEntryMvoStateMergePatchedDto();
        dto.setInventoryItemEntryMvoEventId(e.getInventoryItemEntryMvoEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setOnHandQuantity(e.getOnHandQuantity());
        dto.setInTransitQuantity(e.getInTransitQuantity());
        dto.setReservedQuantity(e.getReservedQuantity());
        dto.setOccupiedQuantity(e.getOccupiedQuantity());
        dto.setVirtualQuantity(e.getVirtualQuantity());
        dto.setSource(e.getSource());
        dto.setVersion(e.getVersion());
        dto.setInventoryItemOnHandQuantity(e.getInventoryItemOnHandQuantity());
        dto.setInventoryItemInTransitQuantity(e.getInventoryItemInTransitQuantity());
        dto.setInventoryItemReservedQuantity(e.getInventoryItemReservedQuantity());
        dto.setInventoryItemOccupiedQuantity(e.getInventoryItemOccupiedQuantity());
        dto.setInventoryItemVirtualQuantity(e.getInventoryItemVirtualQuantity());
        dto.setInventoryItemCreatedBy(e.getInventoryItemCreatedBy());
        dto.setInventoryItemCreatedAt(e.getInventoryItemCreatedAt());
        dto.setInventoryItemUpdatedBy(e.getInventoryItemUpdatedBy());
        dto.setInventoryItemUpdatedAt(e.getInventoryItemUpdatedAt());
        dto.setIsPropertyOnHandQuantityRemoved(e.getIsPropertyOnHandQuantityRemoved());
        dto.setIsPropertyInTransitQuantityRemoved(e.getIsPropertyInTransitQuantityRemoved());
        dto.setIsPropertyReservedQuantityRemoved(e.getIsPropertyReservedQuantityRemoved());
        dto.setIsPropertyOccupiedQuantityRemoved(e.getIsPropertyOccupiedQuantityRemoved());
        dto.setIsPropertyVirtualQuantityRemoved(e.getIsPropertyVirtualQuantityRemoved());
        dto.setIsPropertySourceRemoved(e.getIsPropertySourceRemoved());
        dto.setIsPropertyVersionRemoved(e.getIsPropertyVersionRemoved());
        dto.setIsPropertyInventoryItemOnHandQuantityRemoved(e.getIsPropertyInventoryItemOnHandQuantityRemoved());
        dto.setIsPropertyInventoryItemInTransitQuantityRemoved(e.getIsPropertyInventoryItemInTransitQuantityRemoved());
        dto.setIsPropertyInventoryItemReservedQuantityRemoved(e.getIsPropertyInventoryItemReservedQuantityRemoved());
        dto.setIsPropertyInventoryItemOccupiedQuantityRemoved(e.getIsPropertyInventoryItemOccupiedQuantityRemoved());
        dto.setIsPropertyInventoryItemVirtualQuantityRemoved(e.getIsPropertyInventoryItemVirtualQuantityRemoved());
        dto.setIsPropertyInventoryItemCreatedByRemoved(e.getIsPropertyInventoryItemCreatedByRemoved());
        dto.setIsPropertyInventoryItemCreatedAtRemoved(e.getIsPropertyInventoryItemCreatedAtRemoved());
        dto.setIsPropertyInventoryItemUpdatedByRemoved(e.getIsPropertyInventoryItemUpdatedByRemoved());
        dto.setIsPropertyInventoryItemUpdatedAtRemoved(e.getIsPropertyInventoryItemUpdatedAtRemoved());
        return dto;
    }


}

