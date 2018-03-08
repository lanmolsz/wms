package org.dddml.wms.domain.ordershipment;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public abstract class AbstractOrderShipmentAggregate extends AbstractAggregate implements OrderShipmentAggregate
{
    private OrderShipmentState state;

    private List<Event> changes = new ArrayList<Event>();

    public AbstractOrderShipmentAggregate(OrderShipmentState state)
    {
        this.state = state;
    }

    public OrderShipmentState getState() {
        return this.state;
    }

    public List<Event> getChanges() {
        return this.changes;
    }

    public void create(OrderShipmentCommand.CreateOrderShipment c)
    {
        if (c.getVersion() == null) { c.setVersion(OrderShipmentState.VERSION_NULL); }
        OrderShipmentStateEvent e = map(c);
        apply(e);
    }

    public void mergePatch(OrderShipmentCommand.MergePatchOrderShipment c)
    {
        OrderShipmentStateEvent e = map(c);
        apply(e);
    }

    public void throwOnInvalidStateTransition(Command c) {
        OrderShipmentCommand.throwOnInvalidStateTransition(this.state, c);
    }

    protected void apply(Event e)
    {
        onApplying(e);
        state.mutate(e);
        changes.add(e);
    }

    protected OrderShipmentStateEvent map(OrderShipmentCommand.CreateOrderShipment c) {
        OrderShipmentEventId stateEventId = new OrderShipmentEventId(c.getOrderShipmentId(), c.getVersion());
        OrderShipmentStateEvent.OrderShipmentStateCreated e = newOrderShipmentStateCreated(stateEventId);
        e.setQuantity(c.getQuantity());
        e.setActive(c.getActive());
        ((AbstractOrderShipmentStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected OrderShipmentStateEvent map(OrderShipmentCommand.MergePatchOrderShipment c) {
        OrderShipmentEventId stateEventId = new OrderShipmentEventId(c.getOrderShipmentId(), c.getVersion());
        OrderShipmentStateEvent.OrderShipmentStateMergePatched e = newOrderShipmentStateMergePatched(stateEventId);
        e.setQuantity(c.getQuantity());
        e.setActive(c.getActive());
        e.setIsPropertyQuantityRemoved(c.getIsPropertyQuantityRemoved());
        e.setIsPropertyActiveRemoved(c.getIsPropertyActiveRemoved());
        ((AbstractOrderShipmentStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }


    ////////////////////////

    protected OrderShipmentStateEvent.OrderShipmentStateCreated newOrderShipmentStateCreated(Long version, String commandId, String requesterId) {
        OrderShipmentEventId stateEventId = new OrderShipmentEventId(this.state.getOrderShipmentId(), version);
        OrderShipmentStateEvent.OrderShipmentStateCreated e = newOrderShipmentStateCreated(stateEventId);
        ((AbstractOrderShipmentStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected OrderShipmentStateEvent.OrderShipmentStateMergePatched newOrderShipmentStateMergePatched(Long version, String commandId, String requesterId) {
        OrderShipmentEventId stateEventId = new OrderShipmentEventId(this.state.getOrderShipmentId(), version);
        OrderShipmentStateEvent.OrderShipmentStateMergePatched e = newOrderShipmentStateMergePatched(stateEventId);
        ((AbstractOrderShipmentStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected OrderShipmentStateEvent.OrderShipmentStateCreated newOrderShipmentStateCreated(OrderShipmentEventId stateEventId) {
        return new AbstractOrderShipmentStateEvent.SimpleOrderShipmentStateCreated(stateEventId);
    }

    protected OrderShipmentStateEvent.OrderShipmentStateMergePatched newOrderShipmentStateMergePatched(OrderShipmentEventId stateEventId) {
        return new AbstractOrderShipmentStateEvent.SimpleOrderShipmentStateMergePatched(stateEventId);
    }

    public static class SimpleOrderShipmentAggregate extends AbstractOrderShipmentAggregate
    {
        public SimpleOrderShipmentAggregate(OrderShipmentState state) {
            super(state);
        }

    }

}

