package org.dddml.wms.domain.inventoryitemrequiremententrymvo;

import org.dddml.wms.domain.inventoryitemrequirement.*;
import java.math.BigDecimal;
import org.dddml.wms.domain.inventoryprtriggered.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractInventoryItemRequirementEntryMvoCommandDto extends AbstractCommand
{
    private InventoryItemRequirementEntryIdDto inventoryItemRequirementEntryId;

    public InventoryItemRequirementEntryIdDto getInventoryItemRequirementEntryId()
    {
        return this.inventoryItemRequirementEntryId;
    }

    public void setInventoryItemRequirementEntryId(InventoryItemRequirementEntryIdDto inventoryItemRequirementEntryId)
    {
        this.inventoryItemRequirementEntryId = inventoryItemRequirementEntryId;
    }

    private Long inventoryItemRequirementVersion;

    public Long getInventoryItemRequirementVersion()
    {
        return this.inventoryItemRequirementVersion;
    }

    public void setInventoryItemRequirementVersion(Long inventoryItemRequirementVersion)
    {
        this.inventoryItemRequirementVersion = inventoryItemRequirementVersion;
    }


    public void copyTo(AbstractInventoryItemRequirementEntryMvoCommand command)
    {
        command.setInventoryItemRequirementEntryId((this.getInventoryItemRequirementEntryId() == null) ? null : this.getInventoryItemRequirementEntryId().toInventoryItemRequirementEntryId());
        command.setInventoryItemRequirementVersion(this.getInventoryItemRequirementVersion());
        
        command.setRequesterId(this.getRequesterId());
        command.setCommandId(this.getCommandId());
    }

}
