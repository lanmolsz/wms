package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;

public final class MonthPlanMvoFilteringProperties
{

    private MonthPlanMvoFilteringProperties()
    {
    }

    public static final String[] propertyNames = new String[] {
            "description",
            "createdBy",
            "updatedBy",
            "version",
            "createdAt",
            "updatedAt",
            "active",
            "deleted",
            "yearPlanDescription",
            "yearPlanCreatedBy",
            "yearPlanUpdatedBy",
            "yearPlanVersion",
            "yearPlanCreatedAt",
            "yearPlanUpdatedAt",
            "yearPlanActive",
            "yearPlanDeleted",
            "personBirthDate",
            "personEmail",
            "personCreatedBy",
            "personUpdatedBy",
            "personVersion",
            "personCreatedAt",
            "personUpdatedAt",
            "personActive",
            "personDeleted",
            "monthPlanId.personalNameFirstName",
            "monthPlanId.personalNameLastName",
            "monthPlanId.year",
            "monthPlanId.month",
            "personLoves.firstName",
            "personLoves.lastName",
            "personEmergencyContact.personalNameFirstName",
            "personEmergencyContact.personalNameLastName",
            "personEmergencyContact.phoneNumber",
            "personEmergencyContact.address",
    };

    public static final String[] propertyTypes = new String[] {
            "String",
            "String",
            "String",
            "Long",
            "Date",
            "Date",
            "Boolean",
            "Boolean",
            "String",
            "String",
            "String",
            "Long",
            "Date",
            "Date",
            "Boolean",
            "Boolean",
            "Date",
            "String",
            "String",
            "String",
            "Long",
            "Date",
            "Date",
            "Boolean",
            "Boolean",
            "String",
            "String",
            "Integer",
            "Integer",
            "String",
            "String",
            "String",
            "String",
            "String",
            "String",
    };

    public static final Map<String, String> propertyTypeMap;

    static {
        propertyTypeMap = new HashMap<String, String>();
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyTypeMap.put(propertyNames[i], propertyTypes[i]);
        }
    }

}

