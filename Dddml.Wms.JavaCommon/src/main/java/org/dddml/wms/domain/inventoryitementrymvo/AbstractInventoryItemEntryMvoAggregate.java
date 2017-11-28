package org.dddml.wms.domain.inventoryitementrymvo;

import java.util.*;
import org.dddml.wms.domain.inventoryitem.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public abstract class AbstractInventoryItemEntryMvoAggregate extends AbstractAggregate implements InventoryItemEntryMvoAggregate
{
    private InventoryItemEntryMvoState state;

    private List<Event> changes = new ArrayList<Event>();

    public AbstractInventoryItemEntryMvoAggregate(InventoryItemEntryMvoState state)
    {
        this.state = state;
    }

    public InventoryItemEntryMvoState getState() {
        return this.state;
    }

    public List<Event> getChanges() {
        return this.changes;
    }

    public void create(InventoryItemEntryMvoCommand.CreateInventoryItemEntryMvo c)
    {
        if (c.getInventoryItemVersion() == null) { c.setInventoryItemVersion(InventoryItemEntryMvoState.VERSION_NULL); }
        InventoryItemEntryMvoStateEvent e = map(c);
        apply(e);
    }

    public void mergePatch(InventoryItemEntryMvoCommand.MergePatchInventoryItemEntryMvo c)
    {
        InventoryItemEntryMvoStateEvent e = map(c);
        apply(e);
    }

    public void throwOnInvalidStateTransition(Command c)
    {
        if (this.state.getInventoryItemVersion() == null)
        {
            if (isCommandCreate((InventoryItemEntryMvoCommand)c))
            {
                return;
            }
            throw DomainError.named("premature", "Can't do anything to unexistent aggregate");
        }
        if (isCommandCreate((InventoryItemEntryMvoCommand)c))
            throw DomainError.named("rebirth", "Can't create aggregate that already exists");
    }

    protected void apply(Event e)
    {
        onApplying(e);
        state.mutate(e);
        changes.add(e);
    }

    protected InventoryItemEntryMvoStateEvent map(InventoryItemEntryMvoCommand.CreateInventoryItemEntryMvo c) {
        InventoryItemEntryMvoStateEventId stateEventId = new InventoryItemEntryMvoStateEventId(c.getInventoryItemEntryId(), c.getInventoryItemVersion());
        InventoryItemEntryMvoStateEvent.InventoryItemEntryMvoStateCreated e = newInventoryItemEntryMvoStateCreated(stateEventId);
        e.setQuantityOnHandVar(c.getQuantityOnHandVar());
        e.setQuantityReservedVar(c.getQuantityReservedVar());
        e.setQuantityOccupiedVar(c.getQuantityOccupiedVar());
        e.setQuantityVirtualVar(c.getQuantityVirtualVar());
        e.setEventVO(c.getEventVO());
        e.setVersion(c.getVersion());
        e.setActive(c.getActive());
        e.setInventoryItemQuantityOnHand(c.getInventoryItemQuantityOnHand());
        e.setInventoryItemQuantityReserved(c.getInventoryItemQuantityReserved());
        e.setInventoryItemQuantityOccupied(c.getInventoryItemQuantityOccupied());
        e.setInventoryItemQuantityVirtual(c.getInventoryItemQuantityVirtual());
        e.setInventoryItemCreatedBy(c.getInventoryItemCreatedBy());
        e.setInventoryItemCreatedAt(c.getInventoryItemCreatedAt());
        e.setInventoryItemUpdatedBy(c.getInventoryItemUpdatedBy());
        e.setInventoryItemUpdatedAt(c.getInventoryItemUpdatedAt());
        ((AbstractInventoryItemEntryMvoStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected InventoryItemEntryMvoStateEvent map(InventoryItemEntryMvoCommand.MergePatchInventoryItemEntryMvo c) {
        InventoryItemEntryMvoStateEventId stateEventId = new InventoryItemEntryMvoStateEventId(c.getInventoryItemEntryId(), c.getInventoryItemVersion());
        InventoryItemEntryMvoStateEvent.InventoryItemEntryMvoStateMergePatched e = newInventoryItemEntryMvoStateMergePatched(stateEventId);
        e.setQuantityOnHandVar(c.getQuantityOnHandVar());
        e.setQuantityReservedVar(c.getQuantityReservedVar());
        e.setQuantityOccupiedVar(c.getQuantityOccupiedVar());
        e.setQuantityVirtualVar(c.getQuantityVirtualVar());
        e.setEventVO(c.getEventVO());
        e.setVersion(c.getVersion());
        e.setActive(c.getActive());
        e.setInventoryItemQuantityOnHand(c.getInventoryItemQuantityOnHand());
        e.setInventoryItemQuantityReserved(c.getInventoryItemQuantityReserved());
        e.setInventoryItemQuantityOccupied(c.getInventoryItemQuantityOccupied());
        e.setInventoryItemQuantityVirtual(c.getInventoryItemQuantityVirtual());
        e.setInventoryItemCreatedBy(c.getInventoryItemCreatedBy());
        e.setInventoryItemCreatedAt(c.getInventoryItemCreatedAt());
        e.setInventoryItemUpdatedBy(c.getInventoryItemUpdatedBy());
        e.setInventoryItemUpdatedAt(c.getInventoryItemUpdatedAt());
        e.setIsPropertyQuantityOnHandVarRemoved(c.getIsPropertyQuantityOnHandVarRemoved());
        e.setIsPropertyQuantityReservedVarRemoved(c.getIsPropertyQuantityReservedVarRemoved());
        e.setIsPropertyQuantityOccupiedVarRemoved(c.getIsPropertyQuantityOccupiedVarRemoved());
        e.setIsPropertyQuantityVirtualVarRemoved(c.getIsPropertyQuantityVirtualVarRemoved());
        e.setIsPropertyEventVORemoved(c.getIsPropertyEventVORemoved());
        e.setIsPropertyVersionRemoved(c.getIsPropertyVersionRemoved());
        e.setIsPropertyActiveRemoved(c.getIsPropertyActiveRemoved());
        e.setIsPropertyInventoryItemQuantityOnHandRemoved(c.getIsPropertyInventoryItemQuantityOnHandRemoved());
        e.setIsPropertyInventoryItemQuantityReservedRemoved(c.getIsPropertyInventoryItemQuantityReservedRemoved());
        e.setIsPropertyInventoryItemQuantityOccupiedRemoved(c.getIsPropertyInventoryItemQuantityOccupiedRemoved());
        e.setIsPropertyInventoryItemQuantityVirtualRemoved(c.getIsPropertyInventoryItemQuantityVirtualRemoved());
        e.setIsPropertyInventoryItemCreatedByRemoved(c.getIsPropertyInventoryItemCreatedByRemoved());
        e.setIsPropertyInventoryItemCreatedAtRemoved(c.getIsPropertyInventoryItemCreatedAtRemoved());
        e.setIsPropertyInventoryItemUpdatedByRemoved(c.getIsPropertyInventoryItemUpdatedByRemoved());
        e.setIsPropertyInventoryItemUpdatedAtRemoved(c.getIsPropertyInventoryItemUpdatedAtRemoved());
        ((AbstractInventoryItemEntryMvoStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }


    private static boolean isCommandCreate(InventoryItemEntryMvoCommand c)
    {
        return ((c instanceof InventoryItemEntryMvoCommand.CreateInventoryItemEntryMvo) 
            && c.getInventoryItemVersion().equals(InventoryItemEntryMvoState.VERSION_NULL));
    }


    ////////////////////////

    protected InventoryItemEntryMvoStateEvent.InventoryItemEntryMvoStateCreated newInventoryItemEntryMvoStateCreated(String commandId, String requesterId) {
        InventoryItemEntryMvoStateEventId stateEventId = new InventoryItemEntryMvoStateEventId(this.state.getInventoryItemEntryId(), this.state.getInventoryItemVersion());
        InventoryItemEntryMvoStateEvent.InventoryItemEntryMvoStateCreated e = newInventoryItemEntryMvoStateCreated(stateEventId);
        ((AbstractInventoryItemEntryMvoStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected InventoryItemEntryMvoStateEvent.InventoryItemEntryMvoStateMergePatched newInventoryItemEntryMvoStateMergePatched(String commandId, String requesterId) {
        InventoryItemEntryMvoStateEventId stateEventId = new InventoryItemEntryMvoStateEventId(this.state.getInventoryItemEntryId(), this.state.getInventoryItemVersion());
        InventoryItemEntryMvoStateEvent.InventoryItemEntryMvoStateMergePatched e = newInventoryItemEntryMvoStateMergePatched(stateEventId);
        ((AbstractInventoryItemEntryMvoStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected InventoryItemEntryMvoStateEvent.InventoryItemEntryMvoStateCreated newInventoryItemEntryMvoStateCreated(InventoryItemEntryMvoStateEventId stateEventId) {
        return new AbstractInventoryItemEntryMvoStateEvent.SimpleInventoryItemEntryMvoStateCreated(stateEventId);
    }

    protected InventoryItemEntryMvoStateEvent.InventoryItemEntryMvoStateMergePatched newInventoryItemEntryMvoStateMergePatched(InventoryItemEntryMvoStateEventId stateEventId) {
        return new AbstractInventoryItemEntryMvoStateEvent.SimpleInventoryItemEntryMvoStateMergePatched(stateEventId);
    }


    public static class SimpleInventoryItemEntryMvoAggregate extends AbstractInventoryItemEntryMvoAggregate
    {
        public SimpleInventoryItemEntryMvoAggregate(InventoryItemEntryMvoState state) {
            super(state);
        }

    }

}
