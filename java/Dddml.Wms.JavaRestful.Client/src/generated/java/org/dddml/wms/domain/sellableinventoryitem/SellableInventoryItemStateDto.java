package org.dddml.wms.domain.sellableinventoryitem;

import java.util.*;
import org.dddml.wms.domain.inventoryitem.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.inventoryprtriggered.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;


public class SellableInventoryItemStateDto
{

    private InventoryItemId sellableInventoryItemId;

    public InventoryItemId getSellableInventoryItemId()
    {
        return this.sellableInventoryItemId;
    }

    public void setSellableInventoryItemId(InventoryItemId sellableInventoryItemId)
    {
        this.sellableInventoryItemId = sellableInventoryItemId;
    }

    private BigDecimal sellableQuantity;

    public BigDecimal getSellableQuantity()
    {
        return this.sellableQuantity;
    }

    public void setSellableQuantity(BigDecimal sellableQuantity)
    {
        this.sellableQuantity = sellableQuantity;
    }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }

    private String createdBy;

    public String getCreatedBy()
    {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy)
    {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt()
    {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt)
    {
        this.createdAt = createdAt;
    }

    private String updatedBy;

    public String getUpdatedBy()
    {
        return this.updatedBy;
    }

    public void setUpdatedBy(String updatedBy)
    {
        this.updatedBy = updatedBy;
    }

    private Date updatedAt;

    public Date getUpdatedAt()
    {
        return this.updatedAt;
    }

    public void setUpdatedAt(Date updatedAt)
    {
        this.updatedAt = updatedAt;
    }

    private SellableInventoryItemEntryStateDto[] entries;

    public SellableInventoryItemEntryStateDto[] getEntries()
    {
        return this.entries;
    }	

    public void setEntries(SellableInventoryItemEntryStateDto[] entries)
    {
        this.entries = entries;
    }

}

