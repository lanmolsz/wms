package org.dddml.wms.domain.movementconfirmation;

import java.io.Serializable;
import org.dddml.wms.domain.*;

public class MovementConfirmationLineStateEventId implements Serializable
{
    private String movementConfirmationDocumentNumber;

    public String getMovementConfirmationDocumentNumber()
    {
        return this.movementConfirmationDocumentNumber;
    }

    public void setMovementConfirmationDocumentNumber(String movementConfirmationDocumentNumber)
    {
        this.movementConfirmationDocumentNumber = movementConfirmationDocumentNumber;
    }

    private String lineNumber;

    public String getLineNumber()
    {
        return this.lineNumber;
    }

    public void setLineNumber(String lineNumber)
    {
        this.lineNumber = lineNumber;
    }

    private Long movementConfirmationVersion;

    public Long getMovementConfirmationVersion()
    {
        return this.movementConfirmationVersion;
    }

    public void setMovementConfirmationVersion(Long movementConfirmationVersion)
    {
        this.movementConfirmationVersion = movementConfirmationVersion;
    }

    public MovementConfirmationLineStateEventId()
    {
    }

    public MovementConfirmationLineStateEventId(String movementConfirmationDocumentNumber, String lineNumber, Long movementConfirmationVersion)
    {
        this.movementConfirmationDocumentNumber = movementConfirmationDocumentNumber;
        this.lineNumber = lineNumber;
        this.movementConfirmationVersion = movementConfirmationVersion;
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

        MovementConfirmationLineStateEventId other = (MovementConfirmationLineStateEventId)obj;
        return true 
            && (movementConfirmationDocumentNumber == other.movementConfirmationDocumentNumber || (movementConfirmationDocumentNumber != null && movementConfirmationDocumentNumber.equals(other.movementConfirmationDocumentNumber)))
            && (lineNumber == other.lineNumber || (lineNumber != null && lineNumber.equals(other.lineNumber)))
            && (movementConfirmationVersion == other.movementConfirmationVersion || (movementConfirmationVersion != null && movementConfirmationVersion.equals(other.movementConfirmationVersion)))
            ;
    }

    @Override
    public int hashCode()
    {
        int hash = 0;
        if (this.movementConfirmationDocumentNumber != null) {
            hash += 13 * this.movementConfirmationDocumentNumber.hashCode();
        }
        if (this.lineNumber != null) {
            hash += 13 * this.lineNumber.hashCode();
        }
        if (this.movementConfirmationVersion != null) {
            hash += 13 * this.movementConfirmationVersion.hashCode();
        }
        return hash;
    }


    protected static final String[] FLATTENED_PROPERTY_NAMES = new String[]{
            "movementConfirmationDocumentNumber",
            "lineNumber",
            "movementConfirmationVersion",
    };

    protected static final String[] FLATTENED_PROPERTY_TYPES = new String[]{
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

