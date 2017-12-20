package org.dddml.wms.domain.movement;

import java.util.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class MovementConfirmationLineStateEventDtoConverter {

    public MovementConfirmationLineStateEventDto toMovementConfirmationLineStateEventDto(AbstractMovementConfirmationLineStateEvent stateEvent) {
        if (stateEvent instanceof AbstractMovementConfirmationLineStateEvent.AbstractMovementConfirmationLineStateCreated) {
            MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated e = (MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated) stateEvent;
            return toMovementConfirmationLineStateCreatedDto(e);
        } else if (stateEvent instanceof AbstractMovementConfirmationLineStateEvent.AbstractMovementConfirmationLineStateMergePatched) {
            MovementConfirmationLineStateEvent.MovementConfirmationLineStateMergePatched e = (MovementConfirmationLineStateEvent.MovementConfirmationLineStateMergePatched) stateEvent;
            return toMovementConfirmationLineStateMergePatchedDto(e);
        } else if (stateEvent instanceof AbstractMovementConfirmationLineStateEvent.AbstractMovementConfirmationLineStateRemoved) {
            MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved e = (MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved) stateEvent;
            return toMovementConfirmationLineStateRemovedDto(e);
        }

        throw DomainError.named("invalidStateEventType", String.format("Invalid state event type: %1$s", stateEvent.getStateEventType()));
    }

    public MovementConfirmationLineStateEventDto.MovementConfirmationLineStateCreatedDto toMovementConfirmationLineStateCreatedDto(MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated e) {
        MovementConfirmationLineStateEventDto.MovementConfirmationLineStateCreatedDto dto = new MovementConfirmationLineStateEventDto.MovementConfirmationLineStateCreatedDto();
        dto.setStateEventId(new MovementConfirmationLineStateEventIdDtoWrapper(e.getStateEventId()));
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setVersion(e.getVersion());
        dto.setCommandId(e.getCommandId());
        dto.setTargetQuantity(e.getTargetQuantity());
        dto.setConfirmedQuantity(e.getConfirmedQuantity());
        dto.setDifferenceQuantity(e.getDifferenceQuantity());
        dto.setScrappedQuantity(e.getScrappedQuantity());
        dto.setActive(e.getActive());
        return dto;
    }

    public MovementConfirmationLineStateEventDto.MovementConfirmationLineStateMergePatchedDto toMovementConfirmationLineStateMergePatchedDto(MovementConfirmationLineStateEvent.MovementConfirmationLineStateMergePatched e) {
        MovementConfirmationLineStateEventDto.MovementConfirmationLineStateMergePatchedDto dto = new MovementConfirmationLineStateEventDto.MovementConfirmationLineStateMergePatchedDto();
        dto.setStateEventId(new MovementConfirmationLineStateEventIdDtoWrapper(e.getStateEventId()));
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setVersion(e.getVersion());
        dto.setCommandId(e.getCommandId());
        dto.setTargetQuantity(e.getTargetQuantity());
        dto.setConfirmedQuantity(e.getConfirmedQuantity());
        dto.setDifferenceQuantity(e.getDifferenceQuantity());
        dto.setScrappedQuantity(e.getScrappedQuantity());
        dto.setActive(e.getActive());
        dto.setIsPropertyTargetQuantityRemoved(e.getIsPropertyTargetQuantityRemoved());
        dto.setIsPropertyConfirmedQuantityRemoved(e.getIsPropertyConfirmedQuantityRemoved());
        dto.setIsPropertyDifferenceQuantityRemoved(e.getIsPropertyDifferenceQuantityRemoved());
        dto.setIsPropertyScrappedQuantityRemoved(e.getIsPropertyScrappedQuantityRemoved());
        dto.setIsPropertyActiveRemoved(e.getIsPropertyActiveRemoved());
        return dto;
    }


    public MovementConfirmationLineStateEventDto.MovementConfirmationLineStateRemovedDto toMovementConfirmationLineStateRemovedDto(MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved e) {
        MovementConfirmationLineStateEventDto.MovementConfirmationLineStateRemovedDto dto = new MovementConfirmationLineStateEventDto.MovementConfirmationLineStateRemovedDto();
        dto.setStateEventId(new MovementConfirmationLineStateEventIdDtoWrapper(e.getStateEventId()));
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setVersion(e.getVersion());
        dto.setCommandId(e.getCommandId());
        return dto;
    }

}

