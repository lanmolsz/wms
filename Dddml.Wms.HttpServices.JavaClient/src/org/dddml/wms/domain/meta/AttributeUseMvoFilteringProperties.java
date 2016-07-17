package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;

public final class AttributeUseMvoFilteringProperties
{

    private AttributeUseMvoFilteringProperties()
    {
    }

    public final static String[] propertyNames = new String[] {
            "SequenceNumber",
            "Version",
            "CreatedBy",
            "CreatedAt",
            "UpdatedBy",
            "UpdatedAt",
            "Active",
            "Deleted",
            "AttributeSetName",
            "AttributeSetOrganizationId",
            "AttributeSetDescription",
            "AttributeSetSerialNumberAttributeId",
            "AttributeSetLotAttributeId",
            "AttributeSetReferenceId",
            "AttributeSetVersion",
            "AttributeSetCreatedBy",
            "AttributeSetCreatedAt",
            "AttributeSetUpdatedBy",
            "AttributeSetUpdatedAt",
            "AttributeSetActive",
            "AttributeSetDeleted",
            "AttributeSetAttributeUseId.AttributeSetId",
            "AttributeSetAttributeUseId.AttributeId",
    };

    public final static String[] propertyTypes = new String[] {
            "Integer",
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
            "String",
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
    };

    public final static Map<String, String> propertyMap;

    static {
        propertyMap = new HashMap<String, String>();
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyMap.put(propertyNames[i], propertyTypes[i]);
        }
    }

}
