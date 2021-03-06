package org.dddml.wms.domain.inventoryitem;

import java.util.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;

public abstract class AbstractInventoryItemEntryStateCommandConverter<TCreateInventoryItemEntry extends InventoryItemEntryCommand.CreateInventoryItemEntry>
{
    public InventoryItemEntryCommand toCreateOrMergePatchInventoryItemEntry(InventoryItemEntryState state)
    {
        //where TCreateInventoryItemEntry : ICreateInventoryItemEntry, new()
        //where TMergePatchInventoryItemEntry : IMergePatchInventoryItemEntry, new()
        boolean bUnsaved = state.isStateUnsaved();
        if (bUnsaved)
        {
            return toCreateInventoryItemEntry(state);
        }
        else 
        {
            return null;
        }
    }

    public TCreateInventoryItemEntry toCreateInventoryItemEntry(InventoryItemEntryState state) //where TCreateInventoryItemEntry : ICreateInventoryItemEntry, new()
    {
        TCreateInventoryItemEntry cmd = newCreateInventoryItemEntry();

        cmd.setEntrySeqId(state.getEntrySeqId());
        cmd.setOnHandQuantity(state.getOnHandQuantity());
        cmd.setInTransitQuantity(state.getInTransitQuantity());
        cmd.setReservedQuantity(state.getReservedQuantity());
        cmd.setOccupiedQuantity(state.getOccupiedQuantity());
        cmd.setVirtualQuantity(state.getVirtualQuantity());
        cmd.setSource(state.getSource());
        cmd.setInventoryItemId(state.getInventoryItemId());
        return cmd;
    }

    protected abstract TCreateInventoryItemEntry newCreateInventoryItemEntry();

    public static class SimpleInventoryItemEntryStateCommandConverter extends AbstractInventoryItemEntryStateCommandConverter<AbstractInventoryItemEntryCommand.SimpleCreateInventoryItemEntry>
    {
        @Override
        protected AbstractInventoryItemEntryCommand.SimpleCreateInventoryItemEntry newCreateInventoryItemEntry() {
            return new AbstractInventoryItemEntryCommand.SimpleCreateInventoryItemEntry();
        }


    }

}

