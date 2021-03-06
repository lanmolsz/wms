package org.dddml.wms.restful.resource;

import java.util.*;
import javax.servlet.http.*;
import javax.validation.constraints.*;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import org.dddml.support.criterion.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.attribute.*;
import org.dddml.wms.domain.meta.*;

import com.alibaba.fastjson.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.dddml.support.criterion.TypeConverter;

@RequestMapping(path = "Attributes", produces = MediaType.APPLICATION_JSON_VALUE)
@RestController
public class AttributeResource {

    @Autowired
    private IdGenerator<String, ?, ?> attributeIdGenerator;


    @Autowired
    private AttributeApplicationService attributeApplicationService;


    @GetMapping
    public AttributeStateDto[] getAll( HttpServletRequest request,
                                   @RequestParam(value = "sort", required = false) String sort,
                                   @RequestParam(value = "fields", required = false) String fields,
                                   @RequestParam(value = "firstResult", defaultValue = "0") Integer firstResult,
                                   @RequestParam(value = "maxResults", defaultValue = "2147483647") Integer maxResults,
                                   @RequestParam(value = "filter", required = false) String filter) {
        if (firstResult < 0) { firstResult = 0; }
        if (maxResults == null || maxResults < 1) { maxResults = Integer.MAX_VALUE; }
        try {

            Iterable<AttributeState> states = null; 
            if (!StringHelper.isNullOrEmpty(filter)) {
                states = attributeApplicationService.get(
                        CriterionDto.toSubclass(
                                JSON.parseObject(filter, CriterionDto.class),
                                getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (AttributeMetadata.aliasMap.containsKey(n) ? AttributeMetadata.aliasMap.get(n) : n)),
                        AttributeResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            } else {
                states = attributeApplicationService.get(
                        AttributeResourceUtils.getQueryFilterMap(request.getParameterMap()),
                        AttributeResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            }

            AttributeStateDto.DtoConverter dtoConverter = new AttributeStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toAttributeStateDtoArray(states);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}")
    public AttributeStateDto get(@PathVariable("id") String id, @RequestParam(value = "fields", required = false) String fields) {
        try {
            String idObj = id;
            AttributeState state = attributeApplicationService.get(idObj);
            if (state == null) { return null; }

            AttributeStateDto.DtoConverter dtoConverter = new AttributeStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toAttributeStateDto(state);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @GetMapping("_nextId")
    public String getNextId() {
        try {
            return attributeIdGenerator.getNextId();
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_count")
    public long getCount( HttpServletRequest request,
                         @RequestParam(value = "filter", required = false) String filter) {
        try {
            long count = 0;
            if (!StringHelper.isNullOrEmpty(filter)) {
                count = attributeApplicationService.getCount(CriterionDto.toSubclass(JSONObject.parseObject(filter, CriterionDto.class),
                        getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (AttributeMetadata.aliasMap.containsKey(n) ? AttributeMetadata.aliasMap.get(n) : n)));
            } else {
                count = attributeApplicationService.getCount(AttributeResourceUtils.getQueryFilterMap(request.getParameterMap()));
            }
            return count;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PostMapping
    public String post(@RequestBody CreateOrMergePatchAttributeDto.CreateAttributeDto value,  HttpServletResponse response) {
        try {
            AttributeCommand.CreateAttribute cmd = value.toCreateAttribute();
            if (cmd.getAttributeId() == null) {
                throw DomainError.named("nullId", "Aggregate Id in cmd is null, aggregate name: %1$s.", "Attribute");
            }
            attributeApplicationService.when(cmd);

            response.setStatus(HttpServletResponse.SC_CREATED);
            return cmd.getAttributeId();
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}")
    public void put(@PathVariable("id") String id, @RequestBody CreateOrMergePatchAttributeDto value) {
        try {
            if (value.getVersion() != null) {
                value.setCommandType(Command.COMMAND_TYPE_MERGE_PATCH);
                AttributeCommand.MergePatchAttribute cmd = (AttributeCommand.MergePatchAttribute) value.toCommand();
                AttributeResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
                attributeApplicationService.when(cmd);
                return;
            }

            value.setCommandType(Command.COMMAND_TYPE_CREATE);
            AttributeCommand.CreateAttribute cmd = (AttributeCommand.CreateAttribute) value.toCommand();
            AttributeResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            attributeApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PatchMapping("{id}")
    public void patch(@PathVariable("id") String id, @RequestBody CreateOrMergePatchAttributeDto.MergePatchAttributeDto value) {
        try {

            AttributeCommand.MergePatchAttribute cmd = value.toMergePatchAttribute();
            AttributeResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            attributeApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @DeleteMapping("{id}")
    public void delete(@PathVariable("id") String id,
                       @NotNull @RequestParam(value = "commandId", required = false) String commandId,
                       @NotNull @RequestParam(value = "version", required = false) @Min(value = -1) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId) {
        try {

            AttributeCommand.DeleteAttribute deleteCmd = new AbstractAttributeCommand.SimpleDeleteAttribute();

            deleteCmd.setCommandId(commandId);
            deleteCmd.setRequesterId(requesterId);
            deleteCmd.setVersion(version);
            AttributeResourceUtils.setNullIdOrThrowOnInconsistentIds(id, deleteCmd);
            attributeApplicationService.when(deleteCmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_metadata/filteringFields")
    public List<PropertyMetadataDto> getMetadataFilteringFields() {
        try {

            List<PropertyMetadataDto> filtering = new ArrayList<>();
            AttributeMetadata.propertyTypeMap.forEach((key, value) -> {
                filtering.add(new PropertyMetadataDto(key, value, true));
            });
            return filtering;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_stateEvents/{version}")
    public AttributeStateEventDto getStateEvent(@PathVariable("id") String id, @PathVariable("version") long version) {
        try {

            String idObj = id;
            AttributeStateEventDtoConverter dtoConverter = getAttributeStateEventDtoConverter();
            return dtoConverter.toAttributeStateEventDto((AbstractAttributeEvent) attributeApplicationService.getEvent(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_historyStates/{version}")
    public AttributeStateDto getHistoryState(@PathVariable("id") String id, @PathVariable("version") long version, @RequestParam(value = "fields", required = false) String fields) {
        try {

            String idObj = id;
            AttributeStateDto.DtoConverter dtoConverter = new AttributeStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toAttributeStateDto(attributeApplicationService.getHistoryState(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{attributeId}/AttributeValues/{value}")
    public AttributeValueStateDto getAttributeValue(@PathVariable("attributeId") String attributeId, @PathVariable("value") String value) {
        try {

            AttributeValueState state = attributeApplicationService.getAttributeValue(attributeId, value);
            if (state == null) { return null; }
            AttributeValueStateDto.DtoConverter dtoConverter = new AttributeValueStateDto.DtoConverter();
            AttributeValueStateDto stateDto = dtoConverter.toAttributeValueStateDto(state);
            dtoConverter.setAllFieldsReturned(true);
            return stateDto;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{attributeId}/AttributeValues/")
    public AttributeValueStateDto[] getAttributeValues(@PathVariable("attributeId") String attributeId) {
        try {
            Iterable<AttributeValueState> states = attributeApplicationService.getAttributeValues(attributeId);
            if (states == null) { return null; }
            AttributeValueStateDto.DtoConverter dtoConverter = new AttributeValueStateDto.DtoConverter();
            dtoConverter.setAllFieldsReturned(true);
            return dtoConverter.toAttributeValueStateDtoArray(states);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{attributeId}/AttributeAlias/{code}")
    public AttributeAliasStateDto getAttributeAlias(@PathVariable("attributeId") String attributeId, @PathVariable("code") String code) {
        try {

            AttributeAliasState state = attributeApplicationService.getAttributeAlias(attributeId, code);
            if (state == null) { return null; }
            AttributeAliasStateDto.DtoConverter dtoConverter = new AttributeAliasStateDto.DtoConverter();
            AttributeAliasStateDto stateDto = dtoConverter.toAttributeAliasStateDto(state);
            dtoConverter.setAllFieldsReturned(true);
            return stateDto;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{attributeId}/AttributeAlias/")
    public AttributeAliasStateDto[] getAttributeAlias(@PathVariable("attributeId") String attributeId) {
        try {
            Iterable<AttributeAliasState> states = attributeApplicationService.getAttributeAlias(attributeId);
            if (states == null) { return null; }
            AttributeAliasStateDto.DtoConverter dtoConverter = new AttributeAliasStateDto.DtoConverter();
            dtoConverter.setAllFieldsReturned(true);
            return dtoConverter.toAttributeAliasStateDtoArray(states);
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    protected  AttributeStateEventDtoConverter getAttributeStateEventDtoConverter() {
        return new AttributeStateEventDtoConverter();
    }

    protected String getQueryOrderSeparator() {
        return ",";
    }

    protected TypeConverter getCriterionTypeConverter() {
        return new DefaultTypeConverter();
    }

    protected PropertyTypeResolver getPropertyTypeResolver() {
        return new AttributePropertyTypeResolver();
    }

    // ////////////////////////////////

    private class AttributePropertyTypeResolver implements PropertyTypeResolver {
        @Override
        public Class resolveTypeByPropertyName(String propertyName) {
            return AttributeResourceUtils.getFilterPropertyType(propertyName);
        }
    }

 
    public static class AttributeResourceUtils {

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

        public static void setNullIdOrThrowOnInconsistentIds(String id, AttributeCommand value) {
            String idObj = id;
            if (value.getAttributeId() == null) {
                value.setAttributeId(idObj);
            } else if (!value.getAttributeId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, value.getAttributeId());
            }
        }
    


        public static String getFilterPropertyName(String fieldName) {
            if ("sort".equalsIgnoreCase(fieldName)
                    || "firstResult".equalsIgnoreCase(fieldName)
                    || "maxResults".equalsIgnoreCase(fieldName)
                    || "fields".equalsIgnoreCase(fieldName)) {
                return null;
            }
            if (AttributeMetadata.aliasMap.containsKey(fieldName)) {
                return AttributeMetadata.aliasMap.get(fieldName);
            }
            return null;
        }

        public static Class getFilterPropertyType(String propertyName) {
            if (AttributeMetadata.propertyTypeMap.containsKey(propertyName)) {
                String propertyType = AttributeMetadata.propertyTypeMap.get(propertyName);
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

        public static AttributeStateDto[] toAttributeStateDtoArray(Iterable<String> ids) {
            List<AttributeStateDto> states = new ArrayList<>();
            ids.forEach(id -> {
                AttributeStateDto dto = new AttributeStateDto();
                dto.setAttributeId(id);
                states.add(dto);
            });
            return states.toArray(new AttributeStateDto[0]);
        }

    }

}

