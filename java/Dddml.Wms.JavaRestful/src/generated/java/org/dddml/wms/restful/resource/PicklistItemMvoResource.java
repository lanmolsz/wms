package org.dddml.wms.restful.resource;

import java.util.*;
import javax.servlet.http.*;
import javax.validation.constraints.*;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import org.dddml.support.criterion.*;
import org.dddml.wms.domain.picklistbin.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.picklistitemmvo.*;
import org.dddml.wms.domain.meta.*;

import com.alibaba.fastjson.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.dddml.support.criterion.TypeConverter;

@RequestMapping(path = "PicklistItemMvos", produces = MediaType.APPLICATION_JSON_VALUE)
@RestController
public class PicklistItemMvoResource {


    @Autowired
    private PicklistItemMvoApplicationService picklistItemMvoApplicationService;


    @GetMapping
    public PicklistItemMvoStateDto[] getAll( HttpServletRequest request,
                                   @RequestParam(value = "sort", required = false) String sort,
                                   @RequestParam(value = "fields", required = false) String fields,
                                   @RequestParam(value = "firstResult", defaultValue = "0") Integer firstResult,
                                   @RequestParam(value = "maxResults", defaultValue = "2147483647") Integer maxResults,
                                   @RequestParam(value = "filter", required = false) String filter) {
        if (firstResult < 0) { firstResult = 0; }
        if (maxResults == null || maxResults < 1) { maxResults = Integer.MAX_VALUE; }
        try {

            Iterable<PicklistItemMvoState> states = null; 
            if (!StringHelper.isNullOrEmpty(filter)) {
                states = picklistItemMvoApplicationService.get(
                        CriterionDto.toSubclass(
                                JSON.parseObject(filter, CriterionDto.class),
                                getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (PicklistItemMvoMetadata.aliasMap.containsKey(n) ? PicklistItemMvoMetadata.aliasMap.get(n) : n)),
                        PicklistItemMvoResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            } else {
                states = picklistItemMvoApplicationService.get(
                        PicklistItemMvoResourceUtils.getQueryFilterMap(request.getParameterMap()),
                        PicklistItemMvoResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            }

            PicklistItemMvoStateDto.DtoConverter dtoConverter = new PicklistItemMvoStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toPicklistItemMvoStateDtoArray(states);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}")
    public PicklistItemMvoStateDto get(@PathVariable("id") String id, @RequestParam(value = "fields", required = false) String fields) {
        try {
            PicklistBinPicklistItemId idObj = PicklistItemMvoResourceUtils.parseIdString(id);
            PicklistItemMvoState state = picklistItemMvoApplicationService.get(idObj);
            if (state == null) { return null; }

            PicklistItemMvoStateDto.DtoConverter dtoConverter = new PicklistItemMvoStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toPicklistItemMvoStateDto(state);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_count")
    public long getCount( HttpServletRequest request,
                         @RequestParam(value = "filter", required = false) String filter) {
        try {
            long count = 0;
            if (!StringHelper.isNullOrEmpty(filter)) {
                count = picklistItemMvoApplicationService.getCount(CriterionDto.toSubclass(JSONObject.parseObject(filter, CriterionDto.class),
                        getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (PicklistItemMvoMetadata.aliasMap.containsKey(n) ? PicklistItemMvoMetadata.aliasMap.get(n) : n)));
            } else {
                count = picklistItemMvoApplicationService.getCount(PicklistItemMvoResourceUtils.getQueryFilterMap(request.getParameterMap()));
            }
            return count;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PostMapping
    public PicklistBinPicklistItemId post(@RequestBody CreateOrMergePatchPicklistItemMvoDto.CreatePicklistItemMvoDto value,  HttpServletResponse response) {
        try {
            PicklistItemMvoCommand.CreatePicklistItemMvo cmd = value.toCreatePicklistItemMvo();
            if (cmd.getPicklistBinPicklistItemId() == null) {
                throw DomainError.named("nullId", "Aggregate Id in cmd is null, aggregate name: %1$s.", "PicklistItemMvo");
            }
            picklistItemMvoApplicationService.when(cmd);

            response.setStatus(HttpServletResponse.SC_CREATED);
            return cmd.getPicklistBinPicklistItemId();
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}")
    public void put(@PathVariable("id") String id, @RequestBody CreateOrMergePatchPicklistItemMvoDto value) {
        try {
            if (value.getPicklistBinVersion() != null) {
                value.setCommandType(Command.COMMAND_TYPE_MERGE_PATCH);
                PicklistItemMvoCommand.MergePatchPicklistItemMvo cmd = (PicklistItemMvoCommand.MergePatchPicklistItemMvo) value.toCommand();
                PicklistItemMvoResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
                picklistItemMvoApplicationService.when(cmd);
                return;
            }

            value.setCommandType(Command.COMMAND_TYPE_CREATE);
            PicklistItemMvoCommand.CreatePicklistItemMvo cmd = (PicklistItemMvoCommand.CreatePicklistItemMvo) value.toCommand();
            PicklistItemMvoResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            picklistItemMvoApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PatchMapping("{id}")
    public void patch(@PathVariable("id") String id, @RequestBody CreateOrMergePatchPicklistItemMvoDto.MergePatchPicklistItemMvoDto value) {
        try {

            PicklistItemMvoCommand.MergePatchPicklistItemMvo cmd = value.toMergePatchPicklistItemMvo();
            PicklistItemMvoResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            picklistItemMvoApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @DeleteMapping("{id}")
    public void delete(@PathVariable("id") String id,
                       @NotNull @RequestParam(value = "commandId", required = false) String commandId,
                       @NotNull @RequestParam(value = "version", required = false) @Min(value = -1) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId) {
        try {

            PicklistItemMvoCommand.DeletePicklistItemMvo deleteCmd = new AbstractPicklistItemMvoCommand.SimpleDeletePicklistItemMvo();

            deleteCmd.setCommandId(commandId);
            deleteCmd.setRequesterId(requesterId);
            deleteCmd.setPicklistBinVersion(version);
            PicklistItemMvoResourceUtils.setNullIdOrThrowOnInconsistentIds(id, deleteCmd);
            picklistItemMvoApplicationService.when(deleteCmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_metadata/filteringFields")
    public List<PropertyMetadataDto> getMetadataFilteringFields() {
        try {

            List<PropertyMetadataDto> filtering = new ArrayList<>();
            PicklistItemMvoMetadata.propertyTypeMap.forEach((key, value) -> {
                filtering.add(new PropertyMetadataDto(key, value, true));
            });
            return filtering;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_stateEvents/{version}")
    public PicklistItemMvoStateEventDto getStateEvent(@PathVariable("id") String id, @PathVariable("version") long version) {
        try {

            PicklistBinPicklistItemId idObj = PicklistItemMvoResourceUtils.parseIdString(id);
            PicklistItemMvoStateEventDtoConverter dtoConverter = getPicklistItemMvoStateEventDtoConverter();
            return dtoConverter.toPicklistItemMvoStateEventDto((AbstractPicklistItemMvoEvent) picklistItemMvoApplicationService.getEvent(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_historyStates/{version}")
    public PicklistItemMvoStateDto getHistoryState(@PathVariable("id") String id, @PathVariable("version") long version, @RequestParam(value = "fields", required = false) String fields) {
        try {

            PicklistBinPicklistItemId idObj = PicklistItemMvoResourceUtils.parseIdString(id);
            PicklistItemMvoStateDto.DtoConverter dtoConverter = new PicklistItemMvoStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toPicklistItemMvoStateDto(picklistItemMvoApplicationService.getHistoryState(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    protected  PicklistItemMvoStateEventDtoConverter getPicklistItemMvoStateEventDtoConverter() {
        return new PicklistItemMvoStateEventDtoConverter();
    }

    protected String getQueryOrderSeparator() {
        return ",";
    }

    protected TypeConverter getCriterionTypeConverter() {
        return new DefaultTypeConverter();
    }

    protected PropertyTypeResolver getPropertyTypeResolver() {
        return new PicklistItemMvoPropertyTypeResolver();
    }

    // ////////////////////////////////

    private class PicklistItemMvoPropertyTypeResolver implements PropertyTypeResolver {
        @Override
        public Class resolveTypeByPropertyName(String propertyName) {
            return PicklistItemMvoResourceUtils.getFilterPropertyType(propertyName);
        }
    }

 
    public static class PicklistItemMvoResourceUtils {

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

        public static void setNullIdOrThrowOnInconsistentIds(String id, PicklistItemMvoCommand value) {
            PicklistBinPicklistItemId idObj = parseIdString(id);
            if (value.getPicklistBinPicklistItemId() == null) {
                value.setPicklistBinPicklistItemId(idObj);
            } else if (!value.getPicklistBinPicklistItemId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, value.getPicklistBinPicklistItemId());
            }
        }
    

        public static PicklistBinPicklistItemId parseIdString(String idString) {
            TextFormatter<PicklistBinPicklistItemId> formatter =
                    new AbstractValueObjectTextFormatter<PicklistBinPicklistItemId>(PicklistBinPicklistItemId.class) {
                        @Override
                        protected Class<?> getClassByTypeName(String type) {
                            return BoundedContextMetadata.CLASS_MAP.get(type);
                        }
                    };
            return formatter.parse(idString);
        }


        public static String getFilterPropertyName(String fieldName) {
            if ("sort".equalsIgnoreCase(fieldName)
                    || "firstResult".equalsIgnoreCase(fieldName)
                    || "maxResults".equalsIgnoreCase(fieldName)
                    || "fields".equalsIgnoreCase(fieldName)) {
                return null;
            }
            if (PicklistItemMvoMetadata.aliasMap.containsKey(fieldName)) {
                return PicklistItemMvoMetadata.aliasMap.get(fieldName);
            }
            return null;
        }

        public static Class getFilterPropertyType(String propertyName) {
            if (PicklistItemMvoMetadata.propertyTypeMap.containsKey(propertyName)) {
                String propertyType = PicklistItemMvoMetadata.propertyTypeMap.get(propertyName);
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

        public static PicklistItemMvoStateDto[] toPicklistItemMvoStateDtoArray(Iterable<PicklistBinPicklistItemId> ids) {
            List<PicklistItemMvoStateDto> states = new ArrayList<>();
            ids.forEach(id -> {
                PicklistItemMvoStateDto dto = new PicklistItemMvoStateDto();
                dto.setPicklistBinPicklistItemId(id);
                states.add(dto);
            });
            return states.toArray(new PicklistItemMvoStateDto[0]);
        }

    }

}

