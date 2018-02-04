package org.dddml.wms.domain.uom;

import org.dddml.wms.domain.*;
import java.util.*;
import org.dddml.wms.specialization.*;

public class UomStateEventIdFlattenedDtoFormatter extends AbstractIdFlattenedDtoFormatter<UomStateEventIdFlattenedDto>
{


    @Override
    protected UomStateEventIdFlattenedDto newDto() {
        return new UomStateEventIdFlattenedDto();
    }

    @Override
    protected String[] getFieldNames() {
        return UomStateEventIdFlattenedDto.propertyNames;
    }

    @Override
    protected void setFieldStringValue(UomStateEventIdFlattenedDto dto, String fieldName, String fieldValue) {
        Class clazz = getFieldClass(fieldName);
        Object objVal = ApplicationContext.current.getTypeConverter().convertFromString(clazz, fieldValue);
        if ("uomId".equals(fieldName)) {
            dto.setUomId((String) objVal);
            return;
        }
        if ("version".equals(fieldName)) {
            dto.setVersion((Long) objVal);
            return;
        }
    }

    @Override
    protected String getFieldStringValue(UomStateEventIdFlattenedDto dto, String fieldName) {
        Class clazz = getFieldClass(fieldName);
        if ("uomId".equals(fieldName)) {
            Object objVal = dto.getUomId();
            String strVal = ApplicationContext.current.getTypeConverter().convertToString(clazz, objVal);
            return strVal;
        }
        if ("version".equals(fieldName)) {
            Object objVal = dto.getVersion();
            String strVal = ApplicationContext.current.getTypeConverter().convertToString(clazz, objVal);
            return strVal;
        }
        return null;
    }

    protected Class getFieldClass(String fieldName) {
        String type = UomStateEventIdFlattenedDto.propertyTypeMap.get(fieldName);
        if(type == null) {
            throw new IllegalArgumentException(String.format("The field name \"%1$s\" is NOT right.", fieldName));
        }
        Class clazz = org.dddml.wms.domain.meta.BoundedContextMetadata.CLASS_MAP.get(type);
        if (clazz == null) {
            throw new RuntimeException("ERROR! CANNOT get the class from CLASS_MAP!");
        }
        return clazz;
    }

}
