package org.dddml.wms.domain;


public class InOutLineIdDto
{
	
    private InOutLineId value;

    public InOutLineIdDto()
    {
        this(new InOutLineId());
    }

    public InOutLineIdDto(InOutLineId value)
    {
        this.value = value;
    }

    public InOutLineId toInOutLineId()
    {
        return this.value;
    }

    public String getInOutDocumentNumber()
    {
        return this.value.getInOutDocumentNumber();
    }

    public void setInOutDocumentNumber(String inOutDocumentNumber)
    {
        this.value.setInOutDocumentNumber(inOutDocumentNumber);
    }

    public SkuIdDto getSkuId()
    {
        return new SkuIdDto(this.value.getSkuId());
    }

    public void setSkuId(SkuIdDto skuId)
    {
        this.value.setSkuId(skuId.toSkuId());
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

        InOutLineIdDto other = (InOutLineIdDto)obj;
        return value.equals(other.value);
    }

    @Override
    public int hashCode()
    {
        return value.hashCode();
    }

}

