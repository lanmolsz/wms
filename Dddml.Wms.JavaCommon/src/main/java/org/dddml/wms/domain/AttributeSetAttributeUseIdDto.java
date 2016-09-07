package org.dddml.wms.domain;


public class AttributeSetAttributeUseIdDto
{
	
    private AttributeSetAttributeUseId value;

    public AttributeSetAttributeUseIdDto()
    {
        this(new AttributeSetAttributeUseId());
    }

    public AttributeSetAttributeUseIdDto(AttributeSetAttributeUseId value)
    {
        this.value = value;
    }

    public AttributeSetAttributeUseId toAttributeSetAttributeUseId()
    {
        return this.value;
    }

    public String getAttributeSetId()
    {
        return this.value.getAttributeSetId();
    }

    public void setAttributeSetId(String attributeSetId)
    {
        this.value.setAttributeSetId(attributeSetId);
    }

    public String getAttributeId()
    {
        return this.value.getAttributeId();
    }

    public void setAttributeId(String attributeId)
    {
        this.value.setAttributeId(attributeId);
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

        AttributeSetAttributeUseIdDto other = (AttributeSetAttributeUseIdDto)obj;
        return value.equals(other.value);
    }

    @Override
    public int hashCode()
    {
        return value.hashCode();
    }

}

