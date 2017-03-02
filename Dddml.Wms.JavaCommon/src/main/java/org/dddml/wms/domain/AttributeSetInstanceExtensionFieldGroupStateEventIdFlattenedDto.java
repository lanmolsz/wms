package org.dddml.wms.domain;

import org.dddml.wms.domain.*;
import java.util.HashMap;
import java.util.Map;

public class AttributeSetInstanceExtensionFieldGroupStateEventIdFlattenedDto
{


    public static final String[] propertyNames = new String[]{
            "id",
            "version",
        };

    public static final String[] propertyTypes = new String[]{
            "String",
            "Long",
        };

    public static final Map<String, String> propertyTypeMap;

    static {
        propertyTypeMap = new HashMap<String, String>();
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyTypeMap.put(propertyNames[i], propertyTypes[i]);
        }
    }
	
    private AttributeSetInstanceExtensionFieldGroupStateEventIdDto value;

    public AttributeSetInstanceExtensionFieldGroupStateEventIdFlattenedDto()
    {
        this(new AttributeSetInstanceExtensionFieldGroupStateEventIdDto());
    }

    public AttributeSetInstanceExtensionFieldGroupStateEventIdFlattenedDto(AttributeSetInstanceExtensionFieldGroupStateEventIdDto value)
    {
        this.value = value;
    }

    public AttributeSetInstanceExtensionFieldGroupStateEventIdDto toAttributeSetInstanceExtensionFieldGroupStateEventIdDto()
    {
        return this.value;
    }

    public AttributeSetInstanceExtensionFieldGroupStateEventId toAttributeSetInstanceExtensionFieldGroupStateEventId()
    {
        return this.value.toAttributeSetInstanceExtensionFieldGroupStateEventId();
    }

    public String getId()
    {
        return this.value.getId();
    }

    public void setId(String id)
    {
        this.value.setId(id);
    }

    public Long getVersion()
    {
        return this.value.getVersion();
    }

    public void setVersion(Long version)
    {
        this.value.setVersion(version);
    }


    @Override
    public boolean equals(Object obj)
    {
        if (obj == this) {
            return true;
        }
        if (obj == null || obj.getClass() != this.getClass()) {
            return false;
        }

        AttributeSetInstanceExtensionFieldGroupStateEventIdFlattenedDto other = (AttributeSetInstanceExtensionFieldGroupStateEventIdFlattenedDto)obj;
        return value.equals(other.value);
    }

    @Override
    public int hashCode()
    {
        return value.hashCode();
    }

}

