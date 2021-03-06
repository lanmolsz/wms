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
import org.dddml.wms.domain.inventoryprtriggered.*;
import org.dddml.wms.domain.meta.*;

import com.alibaba.fastjson.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.dddml.support.criterion.TypeConverter;

@RequestMapping(path = "InventoryPRTriggereds", produces = MediaType.APPLICATION_JSON_VALUE)
@RestController
public class InventoryPRTriggeredResource {


    @Autowired
    private InventoryPRTriggeredApplicationService inventoryPRTriggeredApplicationService;


    @GetMapping
    public InventoryPRTriggeredStateDto[] getAll( HttpServletRequest request,
                                   @RequestParam(value = "sort", required = false) String sort,
                                   @RequestParam(value = "fields", required = false) String fields,
                                   @RequestParam(value = "firstResult", defaultValue = "0") Integer firstResult,
                                   @RequestParam(value = "maxResults", defaultValue = "2147483647") Integer maxResults,
                                   @RequestParam(value = "filter", required = false) String filter) {
        if (firstResult < 0) { firstResult = 0; }
        if (maxResults == null || maxResults < 1) { maxResults = Integer.MAX_VALUE; }
        try {

            Iterable<InventoryPRTriggeredState> states = null; 
            if (!StringHelper.isNullOrEmpty(filter)) {
                states = inventoryPRTriggeredApplicationService.get(
                        CriterionDto.toSubclass(
                                JSON.parseObject(filter, CriterionDto.class),
                                getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (InventoryPRTriggeredMetadata.aliasMap.containsKey(n) ? InventoryPRTriggeredMetadata.aliasMap.get(n) : n)),
                        InventoryPRTriggeredResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            } else {
                states = inventoryPRTriggeredApplicationService.get(
                        InventoryPRTriggeredResourceUtils.getQueryFilterMap(request.getParameterMap()),
                        InventoryPRTriggeredResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            }

            InventoryPRTriggeredStateDto.DtoConverter dtoConverter = new InventoryPRTriggeredStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toInventoryPRTriggeredStateDtoArray(states);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}")
    public InventoryPRTriggeredStateDto get(@PathVariable("id") String id, @RequestParam(value = "fields", required = false) String fields) {
        try {
            InventoryPRTriggeredId idObj = InventoryPRTriggeredResourceUtils.parseIdString(id);
            InventoryPRTriggeredState state = inventoryPRTriggeredApplicationService.get(idObj);
            if (state == null) { return null; }

            InventoryPRTriggeredStateDto.DtoConverter dtoConverter = new InventoryPRTriggeredStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toInventoryPRTriggeredStateDto(state);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_count")
    public long getCount( HttpServletRequest request,
                         @RequestParam(value = "filter", required = false) String filter) {
        try {
            long count = 0;
            if (!StringHelper.isNullOrEmpty(filter)) {
                count = inventoryPRTriggeredApplicationService.getCount(CriterionDto.toSubclass(JSONObject.parseObject(filter, CriterionDto.class),
                        getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (InventoryPRTriggeredMetadata.aliasMap.containsKey(n) ? InventoryPRTriggeredMetadata.aliasMap.get(n) : n)));
            } else {
                count = inventoryPRTriggeredApplicationService.getCount(InventoryPRTriggeredResourceUtils.getQueryFilterMap(request.getParameterMap()));
            }
            return count;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PostMapping
    public InventoryPRTriggeredId post(@RequestBody CreateOrMergePatchInventoryPRTriggeredDto.CreateInventoryPRTriggeredDto value,  HttpServletResponse response) {
        try {
            InventoryPRTriggeredCommand.CreateInventoryPRTriggered cmd = value.toCreateInventoryPRTriggered();
            if (cmd.getInventoryPRTriggeredId() == null) {
                throw DomainError.named("nullId", "Aggregate Id in cmd is null, aggregate name: %1$s.", "InventoryPRTriggered");
            }
            inventoryPRTriggeredApplicationService.when(cmd);

            response.setStatus(HttpServletResponse.SC_CREATED);
            return cmd.getInventoryPRTriggeredId();
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}")
    public void put(@PathVariable("id") String id, @RequestBody CreateOrMergePatchInventoryPRTriggeredDto value) {
        try {
            if (value.getVersion() != null) {
                value.setCommandType(Command.COMMAND_TYPE_MERGE_PATCH);
                InventoryPRTriggeredCommand.MergePatchInventoryPRTriggered cmd = (InventoryPRTriggeredCommand.MergePatchInventoryPRTriggered) value.toCommand();
                InventoryPRTriggeredResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
                inventoryPRTriggeredApplicationService.when(cmd);
                return;
            }

            value.setCommandType(Command.COMMAND_TYPE_CREATE);
            InventoryPRTriggeredCommand.CreateInventoryPRTriggered cmd = (InventoryPRTriggeredCommand.CreateInventoryPRTriggered) value.toCommand();
            InventoryPRTriggeredResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            inventoryPRTriggeredApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PatchMapping("{id}")
    public void patch(@PathVariable("id") String id, @RequestBody CreateOrMergePatchInventoryPRTriggeredDto.MergePatchInventoryPRTriggeredDto value) {
        try {

            InventoryPRTriggeredCommand.MergePatchInventoryPRTriggered cmd = value.toMergePatchInventoryPRTriggered();
            InventoryPRTriggeredResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            inventoryPRTriggeredApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_metadata/filteringFields")
    public List<PropertyMetadataDto> getMetadataFilteringFields() {
        try {

            List<PropertyMetadataDto> filtering = new ArrayList<>();
            InventoryPRTriggeredMetadata.propertyTypeMap.forEach((key, value) -> {
                filtering.add(new PropertyMetadataDto(key, value, true));
            });
            return filtering;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    protected  InventoryPRTriggeredStateEventDtoConverter getInventoryPRTriggeredStateEventDtoConverter() {
        return new InventoryPRTriggeredStateEventDtoConverter();
    }

    protected String getQueryOrderSeparator() {
        return ",";
    }

    protected TypeConverter getCriterionTypeConverter() {
        return new DefaultTypeConverter();
    }

    protected PropertyTypeResolver getPropertyTypeResolver() {
        return new InventoryPRTriggeredPropertyTypeResolver();
    }

    // ////////////////////////////////

    private class InventoryPRTriggeredPropertyTypeResolver implements PropertyTypeResolver {
        @Override
        public Class resolveTypeByPropertyName(String propertyName) {
            return InventoryPRTriggeredResourceUtils.getFilterPropertyType(propertyName);
        }
    }

 
    public static class InventoryPRTriggeredResourceUtils {

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

        public static void setNullIdOrThrowOnInconsistentIds(String id, InventoryPRTriggeredCommand value) {
            InventoryPRTriggeredId idObj = parseIdString(id);
            if (value.getInventoryPRTriggeredId() == null) {
                value.setInventoryPRTriggeredId(idObj);
            } else if (!value.getInventoryPRTriggeredId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, value.getInventoryPRTriggeredId());
            }
        }
    

        public static InventoryPRTriggeredId parseIdString(String idString) {
            TextFormatter<InventoryPRTriggeredId> formatter =
                    new AbstractValueObjectTextFormatter<InventoryPRTriggeredId>(InventoryPRTriggeredId.class) {
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
            if (InventoryPRTriggeredMetadata.aliasMap.containsKey(fieldName)) {
                return InventoryPRTriggeredMetadata.aliasMap.get(fieldName);
            }
            return null;
        }

        public static Class getFilterPropertyType(String propertyName) {
            if (InventoryPRTriggeredMetadata.propertyTypeMap.containsKey(propertyName)) {
                String propertyType = InventoryPRTriggeredMetadata.propertyTypeMap.get(propertyName);
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

        public static InventoryPRTriggeredStateDto[] toInventoryPRTriggeredStateDtoArray(Iterable<InventoryPRTriggeredId> ids) {
            List<InventoryPRTriggeredStateDto> states = new ArrayList<>();
            ids.forEach(id -> {
                InventoryPRTriggeredStateDto dto = new InventoryPRTriggeredStateDto();
                dto.setInventoryPRTriggeredId(id);
                states.add(dto);
            });
            return states.toArray(new InventoryPRTriggeredStateDto[0]);
        }

    }

}

