package org.dddml.wms.restful.resource;

import java.util.*;
import javax.servlet.http.*;
import javax.validation.constraints.*;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import org.dddml.support.criterion.*;
import org.dddml.wms.domain.sellableinventoryitem.*;
import java.math.BigDecimal;
import org.dddml.wms.domain.inventoryprtriggered.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.sellableinventoryitementrymvo.*;
import org.dddml.wms.domain.meta.*;

import com.alibaba.fastjson.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.dddml.support.criterion.TypeConverter;

@RequestMapping(path = "SellableInventoryItemEntryMvos", produces = MediaType.APPLICATION_JSON_VALUE)
@RestController
public class SellableInventoryItemEntryMvoResource {


    @Autowired
    private SellableInventoryItemEntryMvoApplicationService sellableInventoryItemEntryMvoApplicationService;


    @GetMapping
    public SellableInventoryItemEntryMvoStateDto[] getAll( HttpServletRequest request,
                                   @RequestParam(value = "sort", required = false) String sort,
                                   @RequestParam(value = "fields", required = false) String fields,
                                   @RequestParam(value = "firstResult", defaultValue = "0") Integer firstResult,
                                   @RequestParam(value = "maxResults", defaultValue = "2147483647") Integer maxResults,
                                   @RequestParam(value = "filter", required = false) String filter) {
        if (firstResult < 0) { firstResult = 0; }
        if (maxResults == null || maxResults < 1) { maxResults = Integer.MAX_VALUE; }
        try {

            Iterable<SellableInventoryItemEntryMvoState> states = null; 
            if (!StringHelper.isNullOrEmpty(filter)) {
                states = sellableInventoryItemEntryMvoApplicationService.get(
                        CriterionDto.toSubclass(
                                JSON.parseObject(filter, CriterionDto.class),
                                getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (SellableInventoryItemEntryMvoMetadata.aliasMap.containsKey(n) ? SellableInventoryItemEntryMvoMetadata.aliasMap.get(n) : n)),
                        SellableInventoryItemEntryMvoResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            } else {
                states = sellableInventoryItemEntryMvoApplicationService.get(
                        SellableInventoryItemEntryMvoResourceUtils.getQueryFilterMap(request.getParameterMap()),
                        SellableInventoryItemEntryMvoResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            }

            SellableInventoryItemEntryMvoStateDto.DtoConverter dtoConverter = new SellableInventoryItemEntryMvoStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toSellableInventoryItemEntryMvoStateDtoArray(states);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}")
    public SellableInventoryItemEntryMvoStateDto get(@PathVariable("id") String id, @RequestParam(value = "fields", required = false) String fields) {
        try {
            SellableInventoryItemEntryId idObj = SellableInventoryItemEntryMvoResourceUtils.parseIdString(id);
            SellableInventoryItemEntryMvoState state = sellableInventoryItemEntryMvoApplicationService.get(idObj);
            if (state == null) { return null; }

            SellableInventoryItemEntryMvoStateDto.DtoConverter dtoConverter = new SellableInventoryItemEntryMvoStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toSellableInventoryItemEntryMvoStateDto(state);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_count")
    public long getCount( HttpServletRequest request,
                         @RequestParam(value = "filter", required = false) String filter) {
        try {
            long count = 0;
            if (!StringHelper.isNullOrEmpty(filter)) {
                count = sellableInventoryItemEntryMvoApplicationService.getCount(CriterionDto.toSubclass(JSONObject.parseObject(filter, CriterionDto.class),
                        getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (SellableInventoryItemEntryMvoMetadata.aliasMap.containsKey(n) ? SellableInventoryItemEntryMvoMetadata.aliasMap.get(n) : n)));
            } else {
                count = sellableInventoryItemEntryMvoApplicationService.getCount(SellableInventoryItemEntryMvoResourceUtils.getQueryFilterMap(request.getParameterMap()));
            }
            return count;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PostMapping
    public SellableInventoryItemEntryId post(@RequestBody CreateOrMergePatchSellableInventoryItemEntryMvoDto.CreateSellableInventoryItemEntryMvoDto value,  HttpServletResponse response) {
        try {
            SellableInventoryItemEntryMvoCommand.CreateSellableInventoryItemEntryMvo cmd = value.toCreateSellableInventoryItemEntryMvo();
            if (cmd.getSellableInventoryItemEntryId() == null) {
                throw DomainError.named("nullId", "Aggregate Id in cmd is null, aggregate name: %1$s.", "SellableInventoryItemEntryMvo");
            }
            sellableInventoryItemEntryMvoApplicationService.when(cmd);

            response.setStatus(HttpServletResponse.SC_CREATED);
            return cmd.getSellableInventoryItemEntryId();
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}")
    public void put(@PathVariable("id") String id, @RequestBody CreateOrMergePatchSellableInventoryItemEntryMvoDto value) {
        try {
            if (value.getSellableInventoryItemVersion() != null) {
                value.setCommandType(Command.COMMAND_TYPE_MERGE_PATCH);
                SellableInventoryItemEntryMvoCommand.MergePatchSellableInventoryItemEntryMvo cmd = (SellableInventoryItemEntryMvoCommand.MergePatchSellableInventoryItemEntryMvo) value.toCommand();
                SellableInventoryItemEntryMvoResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
                sellableInventoryItemEntryMvoApplicationService.when(cmd);
                return;
            }

            value.setCommandType(Command.COMMAND_TYPE_CREATE);
            SellableInventoryItemEntryMvoCommand.CreateSellableInventoryItemEntryMvo cmd = (SellableInventoryItemEntryMvoCommand.CreateSellableInventoryItemEntryMvo) value.toCommand();
            SellableInventoryItemEntryMvoResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            sellableInventoryItemEntryMvoApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PatchMapping("{id}")
    public void patch(@PathVariable("id") String id, @RequestBody CreateOrMergePatchSellableInventoryItemEntryMvoDto.MergePatchSellableInventoryItemEntryMvoDto value) {
        try {

            SellableInventoryItemEntryMvoCommand.MergePatchSellableInventoryItemEntryMvo cmd = value.toMergePatchSellableInventoryItemEntryMvo();
            SellableInventoryItemEntryMvoResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            sellableInventoryItemEntryMvoApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_metadata/filteringFields")
    public List<PropertyMetadataDto> getMetadataFilteringFields() {
        try {

            List<PropertyMetadataDto> filtering = new ArrayList<>();
            SellableInventoryItemEntryMvoMetadata.propertyTypeMap.forEach((key, value) -> {
                filtering.add(new PropertyMetadataDto(key, value, true));
            });
            return filtering;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_stateEvents/{version}")
    public SellableInventoryItemEntryMvoStateEventDto getStateEvent(@PathVariable("id") String id, @PathVariable("version") long version) {
        try {

            SellableInventoryItemEntryId idObj = SellableInventoryItemEntryMvoResourceUtils.parseIdString(id);
            SellableInventoryItemEntryMvoStateEventDtoConverter dtoConverter = getSellableInventoryItemEntryMvoStateEventDtoConverter();
            return dtoConverter.toSellableInventoryItemEntryMvoStateEventDto((AbstractSellableInventoryItemEntryMvoEvent) sellableInventoryItemEntryMvoApplicationService.getEvent(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_historyStates/{version}")
    public SellableInventoryItemEntryMvoStateDto getHistoryState(@PathVariable("id") String id, @PathVariable("version") long version, @RequestParam(value = "fields", required = false) String fields) {
        try {

            SellableInventoryItemEntryId idObj = SellableInventoryItemEntryMvoResourceUtils.parseIdString(id);
            SellableInventoryItemEntryMvoStateDto.DtoConverter dtoConverter = new SellableInventoryItemEntryMvoStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toSellableInventoryItemEntryMvoStateDto(sellableInventoryItemEntryMvoApplicationService.getHistoryState(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    protected  SellableInventoryItemEntryMvoStateEventDtoConverter getSellableInventoryItemEntryMvoStateEventDtoConverter() {
        return new SellableInventoryItemEntryMvoStateEventDtoConverter();
    }

    protected String getQueryOrderSeparator() {
        return ",";
    }

    protected TypeConverter getCriterionTypeConverter() {
        return new DefaultTypeConverter();
    }

    protected PropertyTypeResolver getPropertyTypeResolver() {
        return new SellableInventoryItemEntryMvoPropertyTypeResolver();
    }

    // ////////////////////////////////

    private class SellableInventoryItemEntryMvoPropertyTypeResolver implements PropertyTypeResolver {
        @Override
        public Class resolveTypeByPropertyName(String propertyName) {
            return SellableInventoryItemEntryMvoResourceUtils.getFilterPropertyType(propertyName);
        }
    }

 
    public static class SellableInventoryItemEntryMvoResourceUtils {

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

        public static void setNullIdOrThrowOnInconsistentIds(String id, SellableInventoryItemEntryMvoCommand value) {
            SellableInventoryItemEntryId idObj = parseIdString(id);
            if (value.getSellableInventoryItemEntryId() == null) {
                value.setSellableInventoryItemEntryId(idObj);
            } else if (!value.getSellableInventoryItemEntryId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, value.getSellableInventoryItemEntryId());
            }
        }
    

        public static SellableInventoryItemEntryId parseIdString(String idString) {
            TextFormatter<SellableInventoryItemEntryId> formatter =
                    new AbstractValueObjectTextFormatter<SellableInventoryItemEntryId>(SellableInventoryItemEntryId.class) {
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
            if (SellableInventoryItemEntryMvoMetadata.aliasMap.containsKey(fieldName)) {
                return SellableInventoryItemEntryMvoMetadata.aliasMap.get(fieldName);
            }
            return null;
        }

        public static Class getFilterPropertyType(String propertyName) {
            if (SellableInventoryItemEntryMvoMetadata.propertyTypeMap.containsKey(propertyName)) {
                String propertyType = SellableInventoryItemEntryMvoMetadata.propertyTypeMap.get(propertyName);
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

        public static SellableInventoryItemEntryMvoStateDto[] toSellableInventoryItemEntryMvoStateDtoArray(Iterable<SellableInventoryItemEntryId> ids) {
            List<SellableInventoryItemEntryMvoStateDto> states = new ArrayList<>();
            ids.forEach(id -> {
                SellableInventoryItemEntryMvoStateDto dto = new SellableInventoryItemEntryMvoStateDto();
                dto.setSellableInventoryItemEntryId(id);
                states.add(dto);
            });
            return states.toArray(new SellableInventoryItemEntryMvoStateDto[0]);
        }

    }

}

