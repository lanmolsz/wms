package org.dddml.wms.domain.attribute;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class AttributeStateEventDtoConverter {

    public AttributeStateEventDto toAttributeStateEventDto(AbstractAttributeEvent stateEvent) {
        if (stateEvent instanceof AbstractAttributeEvent.AbstractAttributeStateCreated) {
            AttributeEvent.AttributeStateCreated e = (AttributeEvent.AttributeStateCreated) stateEvent;
            return toAttributeStateCreatedDto(e);
        } else if (stateEvent instanceof AbstractAttributeEvent.AbstractAttributeStateMergePatched) {
            AttributeEvent.AttributeStateMergePatched e = (AttributeEvent.AttributeStateMergePatched) stateEvent;
            return toAttributeStateMergePatchedDto(e);
        } else if (stateEvent instanceof AbstractAttributeEvent.AbstractAttributeStateDeleted) {
            AttributeEvent.AttributeStateDeleted e = (AttributeEvent.AttributeStateDeleted) stateEvent;
            return toAttributeStateDeletedDto(e);
        }

        throw DomainError.named("invalidEventType", String.format("Invalid state event type: %1$s", stateEvent.getEventType()));
    }

    public AttributeStateEventDto.AttributeStateCreatedDto toAttributeStateCreatedDto(AttributeEvent.AttributeStateCreated e) {
        AttributeStateEventDto.AttributeStateCreatedDto dto = new AttributeStateEventDto.AttributeStateCreatedDto();
        dto.setAttributeEventId(e.getAttributeEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setAttributeName(e.getAttributeName());
        dto.setOrganizationId(e.getOrganizationId());
        dto.setDescription(e.getDescription());
        dto.setIsMandatory(e.getIsMandatory());
        dto.setAttributeValueType(e.getAttributeValueType());
        dto.setAttributeValueLength(e.getAttributeValueLength());
        dto.setIsList(e.getIsList());
        dto.setFieldName(e.getFieldName());
        dto.setReferenceId(e.getReferenceId());
        dto.setActive(e.getActive());
        List<AttributeValueStateEventDto.AttributeValueStateCreatedDto> attributeValueEvents = new ArrayList<>();
        for (AttributeValueEvent.AttributeValueStateCreated ee : e.getAttributeValueEvents()) {
            AttributeValueStateEventDto.AttributeValueStateCreatedDto eeDto = getAttributeValueStateEventDtoConverter().toAttributeValueStateCreatedDto(ee);
            attributeValueEvents.add(eeDto);
        }
        dto.setAttributeValueEvents(attributeValueEvents.toArray(new AttributeValueStateEventDto.AttributeValueStateCreatedDto[0]));

        List<AttributeAliasStateEventDto.AttributeAliasStateCreatedDto> attributeAliasEvents = new ArrayList<>();
        for (AttributeAliasEvent.AttributeAliasStateCreated ee : e.getAttributeAliasEvents()) {
            AttributeAliasStateEventDto.AttributeAliasStateCreatedDto eeDto = getAttributeAliasStateEventDtoConverter().toAttributeAliasStateCreatedDto(ee);
            attributeAliasEvents.add(eeDto);
        }
        dto.setAttributeAliasEvents(attributeAliasEvents.toArray(new AttributeAliasStateEventDto.AttributeAliasStateCreatedDto[0]));

        return dto;
    }

    public AttributeStateEventDto.AttributeStateMergePatchedDto toAttributeStateMergePatchedDto(AttributeEvent.AttributeStateMergePatched e) {
        AttributeStateEventDto.AttributeStateMergePatchedDto dto = new AttributeStateEventDto.AttributeStateMergePatchedDto();
        dto.setAttributeEventId(e.getAttributeEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setAttributeName(e.getAttributeName());
        dto.setOrganizationId(e.getOrganizationId());
        dto.setDescription(e.getDescription());
        dto.setIsMandatory(e.getIsMandatory());
        dto.setAttributeValueType(e.getAttributeValueType());
        dto.setAttributeValueLength(e.getAttributeValueLength());
        dto.setIsList(e.getIsList());
        dto.setFieldName(e.getFieldName());
        dto.setReferenceId(e.getReferenceId());
        dto.setActive(e.getActive());
        dto.setIsPropertyAttributeNameRemoved(e.getIsPropertyAttributeNameRemoved());
        dto.setIsPropertyOrganizationIdRemoved(e.getIsPropertyOrganizationIdRemoved());
        dto.setIsPropertyDescriptionRemoved(e.getIsPropertyDescriptionRemoved());
        dto.setIsPropertyIsMandatoryRemoved(e.getIsPropertyIsMandatoryRemoved());
        dto.setIsPropertyAttributeValueTypeRemoved(e.getIsPropertyAttributeValueTypeRemoved());
        dto.setIsPropertyAttributeValueLengthRemoved(e.getIsPropertyAttributeValueLengthRemoved());
        dto.setIsPropertyIsListRemoved(e.getIsPropertyIsListRemoved());
        dto.setIsPropertyFieldNameRemoved(e.getIsPropertyFieldNameRemoved());
        dto.setIsPropertyReferenceIdRemoved(e.getIsPropertyReferenceIdRemoved());
        dto.setIsPropertyActiveRemoved(e.getIsPropertyActiveRemoved());
        List<AttributeValueStateEventDto> attributeValueEvents = new ArrayList<>();
        for (AttributeValueEvent ee : e.getAttributeValueEvents()) {
            AttributeValueStateEventDto eeDto = getAttributeValueStateEventDtoConverter().toAttributeValueStateEventDto((AbstractAttributeValueEvent) ee);
            attributeValueEvents.add(eeDto);
        }
        dto.setAttributeValueEvents(attributeValueEvents.toArray(new AttributeValueStateEventDto[0]));

        List<AttributeAliasStateEventDto> attributeAliasEvents = new ArrayList<>();
        for (AttributeAliasEvent ee : e.getAttributeAliasEvents()) {
            AttributeAliasStateEventDto eeDto = getAttributeAliasStateEventDtoConverter().toAttributeAliasStateEventDto((AbstractAttributeAliasEvent) ee);
            attributeAliasEvents.add(eeDto);
        }
        dto.setAttributeAliasEvents(attributeAliasEvents.toArray(new AttributeAliasStateEventDto[0]));

        return dto;
    }


    public AttributeStateEventDto.AttributeStateDeletedDto toAttributeStateDeletedDto(AttributeEvent.AttributeStateDeleted e) {
        AttributeStateEventDto.AttributeStateDeletedDto dto = new AttributeStateEventDto.AttributeStateDeletedDto();
        dto.setAttributeEventId(e.getAttributeEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        List<AttributeValueStateEventDto.AttributeValueStateRemovedDto> attributeValueEvents = new ArrayList<>();
        for (AttributeValueEvent.AttributeValueStateRemoved ee : e.getAttributeValueEvents()) {
            AttributeValueStateEventDto.AttributeValueStateRemovedDto eeDto = getAttributeValueStateEventDtoConverter().toAttributeValueStateRemovedDto(ee);
            attributeValueEvents.add(eeDto);
        }
        dto.setAttributeValueEvents(attributeValueEvents.toArray(new AttributeValueStateEventDto.AttributeValueStateRemovedDto[0]));

        List<AttributeAliasStateEventDto.AttributeAliasStateRemovedDto> attributeAliasEvents = new ArrayList<>();
        for (AttributeAliasEvent.AttributeAliasStateRemoved ee : e.getAttributeAliasEvents()) {
            AttributeAliasStateEventDto.AttributeAliasStateRemovedDto eeDto = getAttributeAliasStateEventDtoConverter().toAttributeAliasStateRemovedDto(ee);
            attributeAliasEvents.add(eeDto);
        }
        dto.setAttributeAliasEvents(attributeAliasEvents.toArray(new AttributeAliasStateEventDto.AttributeAliasStateRemovedDto[0]));

        return dto;
    }

    protected AttributeValueStateEventDtoConverter getAttributeValueStateEventDtoConverter() {
        return new AttributeValueStateEventDtoConverter();
    }

    protected AttributeAliasStateEventDtoConverter getAttributeAliasStateEventDtoConverter() {
        return new AttributeAliasStateEventDtoConverter();
    }

}

