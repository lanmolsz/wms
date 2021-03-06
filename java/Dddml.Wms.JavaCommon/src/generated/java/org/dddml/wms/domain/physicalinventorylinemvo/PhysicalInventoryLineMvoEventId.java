package org.dddml.wms.domain.physicalinventorylinemvo;

import java.io.Serializable;
import org.dddml.wms.domain.physicalinventory.PhysicalInventoryLineId;
import org.dddml.wms.domain.physicalinventory.*;
import org.dddml.wms.domain.*;

public class PhysicalInventoryLineMvoEventId implements Serializable
{
    private PhysicalInventoryLineId physicalInventoryLineId = new PhysicalInventoryLineId();

    public PhysicalInventoryLineId getPhysicalInventoryLineId()
    {
        return this.physicalInventoryLineId;
    }

    public void setPhysicalInventoryLineId(PhysicalInventoryLineId physicalInventoryLineId)
    {
        this.physicalInventoryLineId = physicalInventoryLineId;
    }

    private Long physicalInventoryVersion;

    public Long getPhysicalInventoryVersion()
    {
        return this.physicalInventoryVersion;
    }

    public void setPhysicalInventoryVersion(Long physicalInventoryVersion)
    {
        this.physicalInventoryVersion = physicalInventoryVersion;
    }

    protected String getPhysicalInventoryLineIdPhysicalInventoryDocumentNumber()
    {
        return getPhysicalInventoryLineId().getPhysicalInventoryDocumentNumber();
    }

    protected void setPhysicalInventoryLineIdPhysicalInventoryDocumentNumber(String physicalInventoryLineIdPhysicalInventoryDocumentNumber)
    {
        getPhysicalInventoryLineId().setPhysicalInventoryDocumentNumber(physicalInventoryLineIdPhysicalInventoryDocumentNumber);
    }

    protected String getPhysicalInventoryLineIdInventoryItemIdProductId()
    {
        return getPhysicalInventoryLineId().getInventoryItemId().getProductId();
    }

    protected void setPhysicalInventoryLineIdInventoryItemIdProductId(String physicalInventoryLineIdInventoryItemIdProductId)
    {
        getPhysicalInventoryLineId().getInventoryItemId().setProductId(physicalInventoryLineIdInventoryItemIdProductId);
    }

    protected String getPhysicalInventoryLineIdInventoryItemIdLocatorId()
    {
        return getPhysicalInventoryLineId().getInventoryItemId().getLocatorId();
    }

    protected void setPhysicalInventoryLineIdInventoryItemIdLocatorId(String physicalInventoryLineIdInventoryItemIdLocatorId)
    {
        getPhysicalInventoryLineId().getInventoryItemId().setLocatorId(physicalInventoryLineIdInventoryItemIdLocatorId);
    }

    protected String getPhysicalInventoryLineIdInventoryItemIdAttributeSetInstanceId()
    {
        return getPhysicalInventoryLineId().getInventoryItemId().getAttributeSetInstanceId();
    }

    protected void setPhysicalInventoryLineIdInventoryItemIdAttributeSetInstanceId(String physicalInventoryLineIdInventoryItemIdAttributeSetInstanceId)
    {
        getPhysicalInventoryLineId().getInventoryItemId().setAttributeSetInstanceId(physicalInventoryLineIdInventoryItemIdAttributeSetInstanceId);
    }

    public PhysicalInventoryLineMvoEventId()
    {
    }

    public PhysicalInventoryLineMvoEventId(PhysicalInventoryLineId physicalInventoryLineId, Long physicalInventoryVersion)
    {
        this.physicalInventoryLineId = physicalInventoryLineId;
        this.physicalInventoryVersion = physicalInventoryVersion;
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

        PhysicalInventoryLineMvoEventId other = (PhysicalInventoryLineMvoEventId)obj;
        return true 
            && (physicalInventoryLineId == other.physicalInventoryLineId || (physicalInventoryLineId != null && physicalInventoryLineId.equals(other.physicalInventoryLineId)))
            && (physicalInventoryVersion == other.physicalInventoryVersion || (physicalInventoryVersion != null && physicalInventoryVersion.equals(other.physicalInventoryVersion)))
            ;
    }

    @Override
    public int hashCode()
    {
        int hash = 0;
        if (this.physicalInventoryLineId != null) {
            hash += 13 * this.physicalInventoryLineId.hashCode();
        }
        if (this.physicalInventoryVersion != null) {
            hash += 13 * this.physicalInventoryVersion.hashCode();
        }
        return hash;
    }


    protected static final String[] FLATTENED_PROPERTY_NAMES = new String[]{
            "physicalInventoryLineIdPhysicalInventoryDocumentNumber",
            "physicalInventoryLineIdInventoryItemIdProductId",
            "physicalInventoryLineIdInventoryItemIdLocatorId",
            "physicalInventoryLineIdInventoryItemIdAttributeSetInstanceId",
            "physicalInventoryVersion",
    };

    protected static final String[] FLATTENED_PROPERTY_TYPES = new String[]{
            "String",
            "String",
            "String",
            "String",
            "Long",
    };

    protected static final java.util.Map<String, String> FLATTENED_PROPERTY_TYPE_MAP;

    static {
        java.util.Map<String, String> m = new java.util.HashMap<String, String>();
        for (int i = 0; i < FLATTENED_PROPERTY_NAMES.length; i++) {
            m.put(FLATTENED_PROPERTY_NAMES[i], FLATTENED_PROPERTY_TYPES[i]);
        }
        FLATTENED_PROPERTY_TYPE_MAP = m;
    }

    protected void forEachFlattenedProperty(java.util.function.BiConsumer<String, Object> consumer) {
        for (int i = 0; i < FLATTENED_PROPERTY_NAMES.length; i++) {
            String pn = FLATTENED_PROPERTY_NAMES[i];
            if (Character.isLowerCase(pn.charAt(0))) {
                pn = Character.toUpperCase(pn.charAt(0)) + pn.substring(1);
            }
            java.lang.reflect.Method m = null;
            try {
                m = this.getClass().getDeclaredMethod("get" + pn, new Class[0]);
            } catch (NoSuchMethodException e) {
                try {
                    m = this.getClass().getMethod("get" + pn, new Class[0]);
                } catch (NoSuchMethodException e1) {
                    throw new RuntimeException(e);
                }
            }
            Object pv = null;
            try {
                pv = m.invoke(this);
            } catch (IllegalAccessException | java.lang.reflect.InvocationTargetException e) {
                throw new RuntimeException(e);
            }
            consumer.accept(pn, pv);
        }
    }

    protected void setFlattenedPropertyValues(Object... values) {
        for (int i = 0; i < FLATTENED_PROPERTY_NAMES.length; i++) {
            String pn = FLATTENED_PROPERTY_NAMES[i];
            if (Character.isLowerCase(pn.charAt(0))) {
                pn = Character.toUpperCase(pn.charAt(0)) + pn.substring(1);
            }
            Object v = values[i];
            Class propCls = v == null ? Object.class : v.getClass();
            java.lang.reflect.Method setterMethod = null;
            if (v == null) {
                setterMethod = getNullValueSetterMethod(pn);
            }
            if (setterMethod == null) {
                try {
                    setterMethod = this.getClass().getDeclaredMethod("set" + pn, new Class[]{propCls});
                } catch (NoSuchMethodException e) {
                    try {
                        setterMethod = this.getClass().getMethod("set" + pn, new Class[]{propCls});
                    } catch (NoSuchMethodException e1) {
                        throw new RuntimeException(e1);
                    }
                }
            }
            try {
                setterMethod.invoke(this, v);
            } catch (IllegalAccessException | java.lang.reflect.InvocationTargetException e) {
                throw new RuntimeException(e);
            }
        }
    }

    private java.lang.reflect.Method getNullValueSetterMethod(String pascalPropName) {
        java.lang.reflect.Method m;
        final String methodName = "set" + pascalPropName;
        m = java.util.Arrays.stream(this.getClass().getDeclaredMethods())
                .filter(me -> me.getName().equals(methodName) && me.getParameterCount() == 1)
                .findFirst().orElse(null);
        if (m == null) {
            m = java.util.Arrays.stream(this.getClass().getMethods())
                    .filter(me -> me.getName().equals(methodName) && me.getParameterCount() == 1)
                    .findFirst().orElse(null);
        }
        return m;
    }

}

