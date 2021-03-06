package org.dddml.wms.domain.inventoryprtriggered;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractInventoryPRTriggeredCommandDto extends AbstractCommand
{
    private InventoryPRTriggeredId inventoryPRTriggeredId;

    public InventoryPRTriggeredId getInventoryPRTriggeredId()
    {
        return this.inventoryPRTriggeredId;
    }

    public void setInventoryPRTriggeredId(InventoryPRTriggeredId inventoryPRTriggeredId)
    {
        this.inventoryPRTriggeredId = inventoryPRTriggeredId;
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


}
