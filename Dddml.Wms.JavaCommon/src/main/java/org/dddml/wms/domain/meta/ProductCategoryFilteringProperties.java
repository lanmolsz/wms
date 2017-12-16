package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;

public final class ProductCategoryFilteringProperties
{

    private ProductCategoryFilteringProperties()
    {
    }

    public static final String[] propertyNames = new String[] {
            "productCategoryId",
            "productCategoryTypeId",
            "primaryParentCategoryId",
            "categoryName",
            "description",
            "categoryImageUrl",
            "detailScreen",
            "showInSelect",
            "version",
            "createdBy",
            "createdAt",
            "updatedBy",
            "updatedAt",
            "active",
            "deleted",
    };

    public static final String[] propertyTypes = new String[] {
            "String",
            "String",
            "String",
            "String",
            "String",
            "String",
            "String",
            "Boolean",
            "Long",
            "String",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
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
        aliasMap.put("productCategoryId", "productCategoryId");
        aliasMap.put("ProductCategoryId", "productCategoryId");
        aliasMap.put("productCategoryTypeId", "productCategoryTypeId");
        aliasMap.put("ProductCategoryTypeId", "productCategoryTypeId");
        aliasMap.put("primaryParentCategoryId", "primaryParentCategoryId");
        aliasMap.put("PrimaryParentCategoryId", "primaryParentCategoryId");
        aliasMap.put("categoryName", "categoryName");
        aliasMap.put("CategoryName", "categoryName");
        aliasMap.put("description", "description");
        aliasMap.put("Description", "description");
        aliasMap.put("categoryImageUrl", "categoryImageUrl");
        aliasMap.put("CategoryImageUrl", "categoryImageUrl");
        aliasMap.put("detailScreen", "detailScreen");
        aliasMap.put("DetailScreen", "detailScreen");
        aliasMap.put("showInSelect", "showInSelect");
        aliasMap.put("ShowInSelect", "showInSelect");
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
    }

    private static void initPropertyTypeMap() {
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyTypeMap.put(propertyNames[i], propertyTypes[i]);
        }
    }

}

