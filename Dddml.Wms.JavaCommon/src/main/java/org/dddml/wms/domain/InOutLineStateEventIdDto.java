package org.dddml.wms.domain;


public class InOutLineStateEventIdDto
{
	
    private InOutLineStateEventId value;

    public InOutLineStateEventIdDto()
    {
        this(new InOutLineStateEventId());
    }

    public InOutLineStateEventIdDto(InOutLineStateEventId value)
    {
        this.value = value;
    }

    public InOutLineStateEventId toInOutLineStateEventId()
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

    public Long getInOutVersion()
    {
        return this.value.getInOutVersion();
    }

    public void setInOutVersion(Long inOutVersion)
    {
        this.value.setInOutVersion(inOutVersion);
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

        InOutLineStateEventIdDto other = (InOutLineStateEventIdDto)obj;
        return value.equals(other.value);
    }

    @Override
    public int hashCode()
    {
        return value.hashCode();
    }

}

