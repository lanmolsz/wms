package org.dddml.wms.domain.ordershipgroupmvo;

import java.io.Serializable;
import org.dddml.wms.domain.order.OrderShipGroupId;
import org.dddml.wms.domain.order.*;
import org.dddml.wms.domain.*;

public class OrderShipGroupMvoEventId implements Serializable
{
    private OrderShipGroupId orderShipGroupId = new OrderShipGroupId();

    public OrderShipGroupId getOrderShipGroupId()
    {
        return this.orderShipGroupId;
    }

    public void setOrderShipGroupId(OrderShipGroupId orderShipGroupId)
    {
        this.orderShipGroupId = orderShipGroupId;
    }

    private Long orderVersion;

    public Long getOrderVersion()
    {
        return this.orderVersion;
    }

    public void setOrderVersion(Long orderVersion)
    {
        this.orderVersion = orderVersion;
    }

    protected String getOrderShipGroupIdOrderId()
    {
        return getOrderShipGroupId().getOrderId();
    }

    protected void setOrderShipGroupIdOrderId(String orderShipGroupIdOrderId)
    {
        getOrderShipGroupId().setOrderId(orderShipGroupIdOrderId);
    }

    protected Long getOrderShipGroupIdShipGroupSeqId()
    {
        return getOrderShipGroupId().getShipGroupSeqId();
    }

    protected void setOrderShipGroupIdShipGroupSeqId(Long orderShipGroupIdShipGroupSeqId)
    {
        getOrderShipGroupId().setShipGroupSeqId(orderShipGroupIdShipGroupSeqId);
    }

    public OrderShipGroupMvoEventId()
    {
    }

    public OrderShipGroupMvoEventId(OrderShipGroupId orderShipGroupId, Long orderVersion)
    {
        this.orderShipGroupId = orderShipGroupId;
        this.orderVersion = orderVersion;
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

        OrderShipGroupMvoEventId other = (OrderShipGroupMvoEventId)obj;
        return true 
            && (orderShipGroupId == other.orderShipGroupId || (orderShipGroupId != null && orderShipGroupId.equals(other.orderShipGroupId)))
            && (orderVersion == other.orderVersion || (orderVersion != null && orderVersion.equals(other.orderVersion)))
            ;
    }

    @Override
    public int hashCode()
    {
        int hash = 0;
        if (this.orderShipGroupId != null) {
            hash += 13 * this.orderShipGroupId.hashCode();
        }
        if (this.orderVersion != null) {
            hash += 13 * this.orderVersion.hashCode();
        }
        return hash;
    }


    protected static final String[] FLATTENED_PROPERTY_NAMES = new String[]{
            "orderShipGroupIdOrderId",
            "orderShipGroupIdShipGroupSeqId",
            "orderVersion",
    };

    protected static final String[] FLATTENED_PROPERTY_TYPES = new String[]{
            "String",
            "Long",
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

