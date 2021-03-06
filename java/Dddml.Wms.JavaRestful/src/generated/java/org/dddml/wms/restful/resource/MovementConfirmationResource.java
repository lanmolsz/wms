package org.dddml.wms.restful.resource;

import java.util.*;
import javax.servlet.http.*;
import javax.validation.constraints.*;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import org.dddml.support.criterion.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.movementconfirmation.*;
import org.dddml.wms.domain.meta.*;

import com.alibaba.fastjson.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.dddml.support.criterion.TypeConverter;

@RequestMapping(path = "MovementConfirmations", produces = MediaType.APPLICATION_JSON_VALUE)
@RestController
public class MovementConfirmationResource {


    @Autowired
    private MovementConfirmationApplicationService movementConfirmationApplicationService;


    @GetMapping
    public MovementConfirmationStateDto[] getAll( HttpServletRequest request,
                                   @RequestParam(value = "sort", required = false) String sort,
                                   @RequestParam(value = "fields", required = false) String fields,
                                   @RequestParam(value = "firstResult", defaultValue = "0") Integer firstResult,
                                   @RequestParam(value = "maxResults", defaultValue = "2147483647") Integer maxResults,
                                   @RequestParam(value = "filter", required = false) String filter) {
        if (firstResult < 0) { firstResult = 0; }
        if (maxResults == null || maxResults < 1) { maxResults = Integer.MAX_VALUE; }
        try {

            Iterable<MovementConfirmationState> states = null; 
            if (!StringHelper.isNullOrEmpty(filter)) {
                states = movementConfirmationApplicationService.get(
                        CriterionDto.toSubclass(
                                JSON.parseObject(filter, CriterionDto.class),
                                getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (MovementConfirmationMetadata.aliasMap.containsKey(n) ? MovementConfirmationMetadata.aliasMap.get(n) : n)),
                        MovementConfirmationResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            } else {
                states = movementConfirmationApplicationService.get(
                        MovementConfirmationResourceUtils.getQueryFilterMap(request.getParameterMap()),
                        MovementConfirmationResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            }

            MovementConfirmationStateDto.DtoConverter dtoConverter = new MovementConfirmationStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toMovementConfirmationStateDtoArray(states);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}")
    public MovementConfirmationStateDto get(@PathVariable("id") String id, @RequestParam(value = "fields", required = false) String fields) {
        try {
            String idObj = id;
            MovementConfirmationState state = movementConfirmationApplicationService.get(idObj);
            if (state == null) { return null; }

            MovementConfirmationStateDto.DtoConverter dtoConverter = new MovementConfirmationStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toMovementConfirmationStateDto(state);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_count")
    public long getCount( HttpServletRequest request,
                         @RequestParam(value = "filter", required = false) String filter) {
        try {
            long count = 0;
            if (!StringHelper.isNullOrEmpty(filter)) {
                count = movementConfirmationApplicationService.getCount(CriterionDto.toSubclass(JSONObject.parseObject(filter, CriterionDto.class),
                        getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (MovementConfirmationMetadata.aliasMap.containsKey(n) ? MovementConfirmationMetadata.aliasMap.get(n) : n)));
            } else {
                count = movementConfirmationApplicationService.getCount(MovementConfirmationResourceUtils.getQueryFilterMap(request.getParameterMap()));
            }
            return count;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PostMapping
    public String post(@RequestBody CreateOrMergePatchMovementConfirmationDto.CreateMovementConfirmationDto value,  HttpServletResponse response) {
        try {
            MovementConfirmationCommand.CreateMovementConfirmation cmd = value.toCreateMovementConfirmation();
            if (cmd.getDocumentNumber() == null) {
                throw DomainError.named("nullId", "Aggregate Id in cmd is null, aggregate name: %1$s.", "MovementConfirmation");
            }
            movementConfirmationApplicationService.when(cmd);

            response.setStatus(HttpServletResponse.SC_CREATED);
            return cmd.getDocumentNumber();
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}")
    public void put(@PathVariable("id") String id, @RequestBody CreateOrMergePatchMovementConfirmationDto value) {
        try {
            if (value.getVersion() != null) {
                value.setCommandType(Command.COMMAND_TYPE_MERGE_PATCH);
                MovementConfirmationCommand.MergePatchMovementConfirmation cmd = (MovementConfirmationCommand.MergePatchMovementConfirmation) value.toCommand();
                MovementConfirmationResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
                movementConfirmationApplicationService.when(cmd);
                return;
            }

            value.setCommandType(Command.COMMAND_TYPE_CREATE);
            MovementConfirmationCommand.CreateMovementConfirmation cmd = (MovementConfirmationCommand.CreateMovementConfirmation) value.toCommand();
            MovementConfirmationResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            movementConfirmationApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PatchMapping("{id}")
    public void patch(@PathVariable("id") String id, @RequestBody CreateOrMergePatchMovementConfirmationDto.MergePatchMovementConfirmationDto value) {
        try {

            MovementConfirmationCommand.MergePatchMovementConfirmation cmd = value.toMergePatchMovementConfirmation();
            MovementConfirmationResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            movementConfirmationApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @DeleteMapping("{id}")
    public void delete(@PathVariable("id") String id,
                       @NotNull @RequestParam(value = "commandId", required = false) String commandId,
                       @NotNull @RequestParam(value = "version", required = false) @Min(value = -1) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId) {
        try {

            MovementConfirmationCommand.DeleteMovementConfirmation deleteCmd = new AbstractMovementConfirmationCommand.SimpleDeleteMovementConfirmation();

            deleteCmd.setCommandId(commandId);
            deleteCmd.setRequesterId(requesterId);
            deleteCmd.setVersion(version);
            MovementConfirmationResourceUtils.setNullIdOrThrowOnInconsistentIds(id, deleteCmd);
            movementConfirmationApplicationService.when(deleteCmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}/_commands/DocumentAction")
    public void documentAction(@PathVariable("id") String id, @RequestBody MovementConfirmationCommandDtos.DocumentActionRequestContent content) {
        try {

            MovementConfirmationCommands.DocumentAction cmd = content.toDocumentAction();
            String idObj = id;
            if (cmd.getDocumentNumber() == null) {
                cmd.setDocumentNumber(idObj);
            } else if (!cmd.getDocumentNumber().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, cmd.getDocumentNumber());
            }
            movementConfirmationApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_metadata/filteringFields")
    public List<PropertyMetadataDto> getMetadataFilteringFields() {
        try {

            List<PropertyMetadataDto> filtering = new ArrayList<>();
            MovementConfirmationMetadata.propertyTypeMap.forEach((key, value) -> {
                filtering.add(new PropertyMetadataDto(key, value, true));
            });
            return filtering;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_stateEvents/{version}")
    public MovementConfirmationStateEventDto getStateEvent(@PathVariable("id") String id, @PathVariable("version") long version) {
        try {

            String idObj = id;
            MovementConfirmationStateEventDtoConverter dtoConverter = getMovementConfirmationStateEventDtoConverter();
            return dtoConverter.toMovementConfirmationStateEventDto((AbstractMovementConfirmationEvent) movementConfirmationApplicationService.getEvent(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_historyStates/{version}")
    public MovementConfirmationStateDto getHistoryState(@PathVariable("id") String id, @PathVariable("version") long version, @RequestParam(value = "fields", required = false) String fields) {
        try {

            String idObj = id;
            MovementConfirmationStateDto.DtoConverter dtoConverter = new MovementConfirmationStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toMovementConfirmationStateDto(movementConfirmationApplicationService.getHistoryState(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{movementConfirmationDocumentNumber}/MovementConfirmationLines/{lineNumber}")
    public MovementConfirmationLineStateDto getMovementConfirmationLine(@PathVariable("movementConfirmationDocumentNumber") String movementConfirmationDocumentNumber, @PathVariable("lineNumber") String lineNumber) {
        try {

            MovementConfirmationLineState state = movementConfirmationApplicationService.getMovementConfirmationLine(movementConfirmationDocumentNumber, lineNumber);
            if (state == null) { return null; }
            MovementConfirmationLineStateDto.DtoConverter dtoConverter = new MovementConfirmationLineStateDto.DtoConverter();
            MovementConfirmationLineStateDto stateDto = dtoConverter.toMovementConfirmationLineStateDto(state);
            dtoConverter.setAllFieldsReturned(true);
            return stateDto;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{movementConfirmationDocumentNumber}/MovementConfirmationLines/")
    public MovementConfirmationLineStateDto[] getMovementConfirmationLines(@PathVariable("movementConfirmationDocumentNumber") String movementConfirmationDocumentNumber) {
        try {
            Iterable<MovementConfirmationLineState> states = movementConfirmationApplicationService.getMovementConfirmationLines(movementConfirmationDocumentNumber);
            if (states == null) { return null; }
            MovementConfirmationLineStateDto.DtoConverter dtoConverter = new MovementConfirmationLineStateDto.DtoConverter();
            dtoConverter.setAllFieldsReturned(true);
            return dtoConverter.toMovementConfirmationLineStateDtoArray(states);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    protected  MovementConfirmationStateEventDtoConverter getMovementConfirmationStateEventDtoConverter() {
        return new MovementConfirmationStateEventDtoConverter();
    }

    protected String getQueryOrderSeparator() {
        return ",";
    }

    protected TypeConverter getCriterionTypeConverter() {
        return new DefaultTypeConverter();
    }

    protected PropertyTypeResolver getPropertyTypeResolver() {
        return new MovementConfirmationPropertyTypeResolver();
    }

    // ////////////////////////////////

    private class MovementConfirmationPropertyTypeResolver implements PropertyTypeResolver {
        @Override
        public Class resolveTypeByPropertyName(String propertyName) {
            return MovementConfirmationResourceUtils.getFilterPropertyType(propertyName);
        }
    }

 
    public static class MovementConfirmationResourceUtils {

        public static List<String> getQueryOrders(String str, String separator) {
            List<String> orders = new ArrayList<>();
            if (StringHelper.isNullOrEmpty(str)) {
                return orders;
            }
            String[] splits = str.split(separator);
            for (String item : splits) {
                if (!StringHelper.isNullOrEmpty(item)) {
                    orders.add(item);
                }
            }
            return orders;
        }

        public static void setNullIdOrThrowOnInconsistentIds(String id, MovementConfirmationCommand value) {
            String idObj = id;
            if (value.getDocumentNumber() == null) {
                value.setDocumentNumber(idObj);
            } else if (!value.getDocumentNumber().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, value.getDocumentNumber());
            }
        }
    


        public static String getFilterPropertyName(String fieldName) {
            if ("sort".equalsIgnoreCase(fieldName)
                    || "firstResult".equalsIgnoreCase(fieldName)
                    || "maxResults".equalsIgnoreCase(fieldName)
                    || "fields".equalsIgnoreCase(fieldName)) {
                return null;
            }
            if (MovementConfirmationMetadata.aliasMap.containsKey(fieldName)) {
                return MovementConfirmationMetadata.aliasMap.get(fieldName);
            }
            return null;
        }

        public static Class getFilterPropertyType(String propertyName) {
            if (MovementConfirmationMetadata.propertyTypeMap.containsKey(propertyName)) {
                String propertyType = MovementConfirmationMetadata.propertyTypeMap.get(propertyName);
                if (!StringHelper.isNullOrEmpty(propertyType)) {
                    if (org.dddml.wms.domain.meta.BoundedContextMetadata.CLASS_MAP.containsKey(propertyType)) {
                        return org.dddml.wms.domain.meta.BoundedContextMetadata.CLASS_MAP.get(propertyType);
                    }
                }
            }
            return String.class;
        }

        public static Iterable<Map.Entry<String, Object>> getQueryFilterMap(Map<String, String[]> queryNameValuePairs) {
            Map<String, Object> filter = new HashMap<>();
            queryNameValuePairs.forEach((key, values) -> {
                if (values.length > 0) {
                    String pName = getFilterPropertyName(key);
                    if (!StringHelper.isNullOrEmpty(pName)) {
                        Class pClass = getFilterPropertyType(pName);
                        filter.put(pName, ApplicationContext.current.getTypeConverter().convertFromString(pClass, values[0]));
                    }
                }
            });
            return filter.entrySet();
        }

        public static MovementConfirmationStateDto[] toMovementConfirmationStateDtoArray(Iterable<String> ids) {
            List<MovementConfirmationStateDto> states = new ArrayList<>();
            ids.forEach(id -> {
                MovementConfirmationStateDto dto = new MovementConfirmationStateDto();
                dto.setDocumentNumber(id);
                states.add(dto);
            });
            return states.toArray(new MovementConfirmationStateDto[0]);
        }

    }

}

