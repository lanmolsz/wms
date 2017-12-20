package org.dddml.wms.domain.movement;

import java.util.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class MovementLineStateEventDtoConverter {

    public MovementLineStateEventDto toMovementLineStateEventDto(AbstractMovementLineStateEvent stateEvent) {
        if (stateEvent instanceof AbstractMovementLineStateEvent.AbstractMovementLineStateCreated) {
            MovementLineStateEvent.MovementLineStateCreated e = (MovementLineStateEvent.MovementLineStateCreated) stateEvent;
            return toMovementLineStateCreatedDto(e);
        } else if (stateEvent instanceof AbstractMovementLineStateEvent.AbstractMovementLineStateMergePatched) {
            MovementLineStateEvent.MovementLineStateMergePatched e = (MovementLineStateEvent.MovementLineStateMergePatched) stateEvent;
            return toMovementLineStateMergePatchedDto(e);
        } else if (stateEvent instanceof AbstractMovementLineStateEvent.AbstractMovementLineStateRemoved) {
            MovementLineStateEvent.MovementLineStateRemoved e = (MovementLineStateEvent.MovementLineStateRemoved) stateEvent;
            return toMovementLineStateRemovedDto(e);
        }

        throw DomainError.named("invalidStateEventType", String.format("Invalid state event type: %1$s", stateEvent.getStateEventType()));
    }

    public MovementLineStateEventDto.MovementLineStateCreatedDto toMovementLineStateCreatedDto(MovementLineStateEvent.MovementLineStateCreated e) {
        MovementLineStateEventDto.MovementLineStateCreatedDto dto = new MovementLineStateEventDto.MovementLineStateCreatedDto();
        dto.setStateEventId(new MovementLineStateEventIdDtoWrapper(e.getStateEventId()));
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setVersion(e.getVersion());
        dto.setCommandId(e.getCommandId());
        dto.setMovementQuantity(e.getMovementQuantity());
        dto.setProductId(e.getProductId());
        dto.setLocatorIdFrom(e.getLocatorIdFrom());
        dto.setLocatorIdTo(e.getLocatorIdTo());
        dto.setAttributeSetInstanceIdFrom(e.getAttributeSetInstanceIdFrom());
        dto.setAttributeSetInstanceIdTo(e.getAttributeSetInstanceIdTo());
        dto.setProcessed(e.getProcessed());
        dto.setReversalLineNumber(e.getReversalLineNumber());
        dto.setActive(e.getActive());
        return dto;
    }

    public MovementLineStateEventDto.MovementLineStateMergePatchedDto toMovementLineStateMergePatchedDto(MovementLineStateEvent.MovementLineStateMergePatched e) {
        MovementLineStateEventDto.MovementLineStateMergePatchedDto dto = new MovementLineStateEventDto.MovementLineStateMergePatchedDto();
        dto.setStateEventId(new MovementLineStateEventIdDtoWrapper(e.getStateEventId()));
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setVersion(e.getVersion());
        dto.setCommandId(e.getCommandId());
        dto.setMovementQuantity(e.getMovementQuantity());
        dto.setProductId(e.getProductId());
        dto.setLocatorIdFrom(e.getLocatorIdFrom());
        dto.setLocatorIdTo(e.getLocatorIdTo());
        dto.setAttributeSetInstanceIdFrom(e.getAttributeSetInstanceIdFrom());
        dto.setAttributeSetInstanceIdTo(e.getAttributeSetInstanceIdTo());
        dto.setProcessed(e.getProcessed());
        dto.setReversalLineNumber(e.getReversalLineNumber());
        dto.setActive(e.getActive());
        dto.setIsPropertyMovementQuantityRemoved(e.getIsPropertyMovementQuantityRemoved());
        dto.setIsPropertyProductIdRemoved(e.getIsPropertyProductIdRemoved());
        dto.setIsPropertyLocatorIdFromRemoved(e.getIsPropertyLocatorIdFromRemoved());
        dto.setIsPropertyLocatorIdToRemoved(e.getIsPropertyLocatorIdToRemoved());
        dto.setIsPropertyAttributeSetInstanceIdFromRemoved(e.getIsPropertyAttributeSetInstanceIdFromRemoved());
        dto.setIsPropertyAttributeSetInstanceIdToRemoved(e.getIsPropertyAttributeSetInstanceIdToRemoved());
        dto.setIsPropertyProcessedRemoved(e.getIsPropertyProcessedRemoved());
        dto.setIsPropertyReversalLineNumberRemoved(e.getIsPropertyReversalLineNumberRemoved());
        dto.setIsPropertyActiveRemoved(e.getIsPropertyActiveRemoved());
        return dto;
    }


    public MovementLineStateEventDto.MovementLineStateRemovedDto toMovementLineStateRemovedDto(MovementLineStateEvent.MovementLineStateRemoved e) {
        MovementLineStateEventDto.MovementLineStateRemovedDto dto = new MovementLineStateEventDto.MovementLineStateRemovedDto();
        dto.setStateEventId(new MovementLineStateEventIdDtoWrapper(e.getStateEventId()));
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setVersion(e.getVersion());
        dto.setCommandId(e.getCommandId());
        return dto;
    }

}

