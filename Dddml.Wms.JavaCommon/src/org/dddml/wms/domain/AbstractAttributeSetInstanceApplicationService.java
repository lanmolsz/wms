package org.dddml.wms.domain;

import java.util.*;
import java.util.function.Consumer;
import org.dddml.support.criterion.Criterion;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.*;

public abstract class AbstractAttributeSetInstanceApplicationService implements AttributeSetInstanceApplicationService
{

    private EventStore eventStore;

    protected EventStore getEventStore()
    {
        return eventStore;
    }

    private AttributeSetInstanceStateRepository stateRepository;

    protected AttributeSetInstanceStateRepository getStateRepository()
    {
        return stateRepository;
    }

    public AbstractAttributeSetInstanceApplicationService(EventStore eventStore, AttributeSetInstanceStateRepository stateRepository)
    {
        this.eventStore = eventStore;
        this.stateRepository = stateRepository;
    }

    public void when(AttributeSetInstanceCommand.CreateAttributeSetInstance c) {
        update(c, ar -> ar.create(c));
    }

    public void when(AttributeSetInstanceCommand.MergePatchAttributeSetInstance c) {
        update(c, ar -> ar.mergePatch(c));
    }

    public void when(AttributeSetInstanceCommand.DeleteAttributeSetInstance c) {
        update(c, ar -> ar.delete(c));
    }

    public AttributeSetInstanceState get(String id) {

        AttributeSetInstanceState state = getStateRepository().get(id, true);
        return state;
    }

    public Iterable<AttributeSetInstanceState> getAll(Integer firstResult, Integer maxResults) {
        return getStateRepository().getAll(firstResult, maxResults);
    }

    public Iterable<AttributeSetInstanceState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<AttributeSetInstanceState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<AttributeSetInstanceState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().getByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
    }

    public long getCount(Iterable<Map.Entry<String, Object>> filter) {
        return getStateRepository().getCount(filter);
    }

    public long getCount(Criterion filter) {
        return getStateRepository().getCount(filter);
    }

    public AttributeSetInstanceStateEvent getStateEvent(String attributeSetInstanceId, long version) {
        AttributeSetInstanceStateEvent e = (AttributeSetInstanceStateEvent)getEventStore().getStateEvent(toEventStoreAggregateId(attributeSetInstanceId), version);
        if (e != null)
        { e.setStateEventReadOnly(true); }
        return e;
    }


    public AttributeSetInstanceAggregate getAttributeSetInstanceAggregate(AttributeSetInstanceState state)
    {
        return new AbstractAttributeSetInstanceAggregate.SimpleAttributeSetInstanceAggregate(state);
    }

    public EventStoreAggregateId toEventStoreAggregateId(String aggregateId)
    {
        return new EventStoreAggregateId.SimpleEventStoreAggregateId(aggregateId);
    }

    protected void update(AttributeSetInstanceCommand c, Consumer<AttributeSetInstanceAggregate> action)
    {
        String aggregateId = c.getAttributeSetInstanceId();
        AttributeSetInstanceState state = getStateRepository().get(aggregateId);
        AttributeSetInstanceAggregate aggregate = getAttributeSetInstanceAggregate(state);

        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);

        boolean repeated = isRepeatedCommand(c, eventStoreAggregateId, state);
        if (repeated) { return; }

        aggregate.throwOnInvalidStateTransition(c);
        action.accept(aggregate);
        getEventStore().appendEvents(eventStoreAggregateId, c.getVersion(), // State version may be null!
            aggregate.getChanges(), (events) -> { getStateRepository().save(state); });
        
    }

    protected boolean isRepeatedCommand(AttributeSetInstanceCommand command, EventStoreAggregateId eventStoreAggregateId, AttributeSetInstanceState state)
    {
        boolean repeated = false;
        if (command.getVersion() == null) { command.setVersion(AttributeSetInstanceState.VERSION_NULL); }
        if (state.getVersion() != null && state.getVersion() > command.getVersion())
        {
            Event lastEvent = getEventStore().findLastEvent(AbstractAttributeSetInstanceStateEvent.class, eventStoreAggregateId, command.getVersion());
            if (lastEvent != null && lastEvent instanceof AbstractStateEvent
               && command.getCommandId() != null && command.getCommandId().equals(((AbstractStateEvent) lastEvent).getCommandId()))
            {
                repeated = true;
            }
        }
        return repeated;
    }

    public static class SimpleAttributeSetInstanceApplicationService extends AbstractAttributeSetInstanceApplicationService 
    {
        public SimpleAttributeSetInstanceApplicationService(EventStore eventStore, AttributeSetInstanceStateRepository stateRepository)
        {
            super(eventStore, stateRepository);
        }

    }

}

