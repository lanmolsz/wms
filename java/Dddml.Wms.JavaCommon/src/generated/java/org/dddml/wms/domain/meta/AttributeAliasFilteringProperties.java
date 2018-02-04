package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;

public final class AttributeAliasFilteringProperties
{

    private AttributeAliasFilteringProperties()
    {
    }

    public static final String[] propertyNames = new String[] {
            "code",
            "name",
            "version",
            "createdBy",
            "createdAt",
            "updatedBy",
            "updatedAt",
            "active",
            "deleted",
            "attributeId",
            "attributeAliasId.attributeId",
            "attributeAliasId.code",
    };

    public static final String[] propertyTypes = new String[] {
            "String",
            "String",
            "Long",
            "String",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
            "String",
            "String",
            "String",
    };

    public static final Map<String, String> propertyTypeMap;

    public static final Map<String, String> aliasMap;

    static {
        propertyTypeMap = new HashMap<String, String>();
        initPropertyTypeMap();
        aliasMap = new HashMap<String, String>();
        initAliasMap();
    }

    private static  void initAliasMap() {
        aliasMap.put("code", "attributeAliasId.code");
        aliasMap.put("Code", "attributeAliasId.code");
        aliasMap.put("name", "name");
        aliasMap.put("Name", "name");
        aliasMap.put("version", "version");
        aliasMap.put("Version", "version");
        aliasMap.put("createdBy", "createdBy");
        aliasMap.put("CreatedBy", "createdBy");
        aliasMap.put("createdAt", "createdAt");
        aliasMap.put("CreatedAt", "createdAt");
        aliasMap.put("updatedBy", "updatedBy");
        aliasMap.put("UpdatedBy", "updatedBy");
        aliasMap.put("updatedAt", "updatedAt");
        aliasMap.put("UpdatedAt", "updatedAt");
        aliasMap.put("active", "active");
        aliasMap.put("Active", "active");
        aliasMap.put("deleted", "deleted");
        aliasMap.put("Deleted", "deleted");
        aliasMap.put("attributeId", "attributeAliasId.attributeId");
        aliasMap.put("AttributeId", "attributeAliasId.attributeId");
        aliasMap.put("attributeAliasId.attributeId", "attributeAliasId.attributeId");
        aliasMap.put("AttributeAliasId.AttributeId", "attributeAliasId.attributeId");
        aliasMap.put("attributeAliasId.code", "attributeAliasId.code");
        aliasMap.put("AttributeAliasId.Code", "attributeAliasId.code");
    }

    private static void initPropertyTypeMap() {
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyTypeMap.put(propertyNames[i], propertyTypes[i]);
        }
    }

}
