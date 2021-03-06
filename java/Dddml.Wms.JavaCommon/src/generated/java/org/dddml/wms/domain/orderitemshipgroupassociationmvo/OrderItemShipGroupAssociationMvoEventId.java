package org.dddml.wms.domain.orderitemshipgroupassociationmvo;

import java.io.Serializable;
import org.dddml.wms.domain.order.OrderItemShipGroupAssociationId;
import org.dddml.wms.domain.order.*;
import org.dddml.wms.domain.*;

public class OrderItemShipGroupAssociationMvoEventId implements Serializable
{
    private OrderItemShipGroupAssociationId orderItemShipGroupAssociationId = new OrderItemShipGroupAssociationId();

    public OrderItemShipGroupAssociationId getOrderItemShipGroupAssociationId()
    {
        return this.orderItemShipGroupAssociationId;
    }

    public void setOrderItemShipGroupAssociationId(OrderItemShipGroupAssociationId orderItemShipGroupAssociationId)
    {
        this.orderItemShipGroupAssociationId = orderItemShipGroupAssociationId;
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

    protected String getOrderItemShipGroupAssociationIdOrderId()
    {
        return getOrderItemShipGroupAssociationId().getOrderId();
    }

    protected void setOrderItemShipGroupAssociationIdOrderId(String orderItemShipGroupAssociationIdOrderId)
    {
        getOrderItemShipGroupAssociationId().setOrderId(orderItemShipGroupAssociationIdOrderId);
    }

    protected Long getOrderItemShipGroupAssociationIdOrderShipGroupShipGroupSeqId()
    {
        return getOrderItemShipGroupAssociationId().getOrderShipGroupShipGroupSeqId();
    }

    protected void setOrderItemShipGroupAssociationIdOrderShipGroupShipGroupSeqId(Long orderItemShipGroupAssociationIdOrderShipGroupShipGroupSeqId)
    {
        getOrderItemShipGroupAssociationId().setOrderShipGroupShipGroupSeqId(orderItemShipGroupAssociationIdOrderShipGroupShipGroupSeqId);
    }

    protected String getOrderItemShipGroupAssociationIdOrderItemSeqId()
    {
        return getOrderItemShipGroupAssociationId().getOrderItemSeqId();
    }

    protected void setOrderItemShipGroupAssociationIdOrderItemSeqId(String orderItemShipGroupAssociationIdOrderItemSeqId)
    {
        getOrderItemShipGroupAssociationId().setOrderItemSeqId(orderItemShipGroupAssociationIdOrderItemSeqId);
    }

    public OrderItemShipGroupAssociationMvoEventId()
    {
    }

    public OrderItemShipGroupAssociationMvoEventId(OrderItemShipGroupAssociationId orderItemShipGroupAssociationId, Long orderVersion)
    {
        this.orderItemShipGroupAssociationId = orderItemShipGroupAssociationId;
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

        OrderItemShipGroupAssociationMvoEventId other = (OrderItemShipGroupAssociationMvoEventId)obj;
        return true 
            && (orderItemShipGroupAssociationId == other.orderItemShipGroupAssociationId || (orderItemShipGroupAssociationId != null && orderItemShipGroupAssociationId.equals(other.orderItemShipGroupAssociationId)))
            && (orderVersion == other.orderVersion || (orderVersion != null && orderVersion.equals(other.orderVersion)))
            ;
    }

    @Override
    public int hashCode()
    {
        int hash = 0;
        if (this.orderItemShipGroupAssociationId != null) {
            hash += 13 * this.orderItemShipGroupAssociationId.hashCode();
        }
        if (this.orderVersion != null) {
            hash += 13 * this.orderVersion.hashCode();
        }
        return hash;
    }


    protected static final String[] FLATTENED_PROPERTY_NAMES = new String[]{
            "orderItemShipGroupAssociationIdOrderId",
            "orderItemShipGroupAssociationIdOrderShipGroupShipGroupSeqId",
            "orderItemShipGroupAssociationIdOrderItemSeqId",
            "orderVersion",
    };

    protected static final String[] FLATTENED_PROPERTY_TYPES = new String[]{
            "String",
            "Long",
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

