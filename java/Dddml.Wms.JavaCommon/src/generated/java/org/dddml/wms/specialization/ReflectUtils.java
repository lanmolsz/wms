package org.dddml.wms.specialization;

import org.joda.money.Money;

import java.beans.BeanInfo;
import java.beans.IntrospectionException;
import java.beans.Introspector;
import java.beans.PropertyDescriptor;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.math.BigDecimal;
import java.util.*;
import java.util.function.BiFunction;

public class ReflectUtils {
    private ReflectUtils() {
    }

    public static Object getPropertyValue(String propertyName, Object obj) {
        Object val = null;
        String pn = toPascalCase(propertyName);
        try {
            val = obj.getClass().getMethod("get" + pn, new Class[0]).invoke(obj);
        } catch (IllegalAccessException | InvocationTargetException | NoSuchMethodException e) {
            throw new RuntimeException(e);// e.printStackTrace();
        }
        return val;
    }

    public static Class<?> getPropertyType(String propertyName, Object obj) {
        BeanInfo info = null;
        try {
            info = Introspector.getBeanInfo(obj.getClass());
        } catch (IntrospectionException e) {
            throw new RuntimeException(e);//e.printStackTrace();
        }
        Optional<PropertyDescriptor> pd =
                Arrays.stream(info.getPropertyDescriptors())
                        .filter(p -> Objects.equals(p.getName().toLowerCase(), propertyName.toLowerCase()))
                        .findFirst();
        if (pd.isPresent()) {
            return pd.get().getPropertyType();
        }
        throw new RuntimeException(String.format("Property %1$s is NOT present.", propertyName));
    }

    public static boolean trySetPropertyValue(String propertyName, Object obj, Object value,
                                              BiFunction<Object, Class<?>, Object> convert) {
        boolean throwOnError = false;
        return trySetPropertyValue(propertyName, obj, value, convert, throwOnError);
    }

    public static void setPropertyValue(String propertyName, Object obj, Object value) {
        boolean throwOnError = true;
        BiFunction<Object, Class<?>, Object> convert = (o, c) -> {
            //if (throwOnError) {
            //    throw new UnsupportedOperationException("Convert function is NOT definded.");
            //} else
            return o;
        };
        trySetPropertyValue(propertyName, obj, value, convert, throwOnError);
    }

    private static boolean trySetPropertyValue(String propertyName, Object obj, Object value,
                                               BiFunction<Object, Class<?>, Object> convert, boolean throwOnError) {
        String pascalName = toPascalCase(propertyName);
        Class propCls = value == null ? Object.class : value.getClass();
        Object targetPropVal = value;
        Method m = null;
        try {
            m = obj.getClass().getMethod("set" + pascalName, new Class[]{propCls});
        } catch (NoSuchMethodException e) {
            if (throwOnError) {
                throw new RuntimeException(e);// e.printStackTrace();
            } else {
                try {
                    Class<?> pt = getPropertyType(propertyName, obj);
                    m = obj.getClass().getMethod("set" + pascalName, new Class[]{pt});
                    targetPropVal = convert.apply(value, pt);
                } catch (NoSuchMethodException e1) {
                    if (throwOnError) {
                        throw new RuntimeException(e);// e.printStackTrace();
                    } else {
                        return false;
                    }
                } catch (Exception ex) {
                    if (throwOnError) {
                        throw new RuntimeException(e);// e.printStackTrace();
                    } // esle {}
                }
            }
        }
        if (m == null && throwOnError) {
            throw new RuntimeException(new NoSuchMethodException());
        }
        try {
            m.invoke(obj, new Object[]{targetPropVal});
            return true;
        } catch (IllegalAccessException | InvocationTargetException e) {
            if (throwOnError) {
                throw new RuntimeException(e);// e.printStackTrace();
            }
        }
        return false;
    }

    private static String toPascalCase(String propertyName) {
        String pn = propertyName;
        if (Character.isLowerCase(propertyName.charAt(0))) {
            pn = Character.toUpperCase(propertyName.charAt(0)) + propertyName.substring(1);
        }
        return pn;
    }

}
