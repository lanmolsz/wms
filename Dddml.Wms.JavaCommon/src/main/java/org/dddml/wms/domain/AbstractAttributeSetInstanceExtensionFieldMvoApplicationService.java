package org.dddml.wms.domain;

import java.util.*;
import java.util.function.Consumer;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public abstract class AbstractAttributeSetInstanceExtensionFieldMvoApplicationService implements AttributeSetInstanceExtensionFieldMvoApplicationService
{

    private EventStore eventStore;

    protected EventStore getEventStore()
    {
        return eventStore;
    }

    private AttributeSetInstanceExtensionFieldMvoStateRepository stateRepository;

    protected AttributeSetInstanceExtensionFieldMvoStateRepository getStateRepository() {
        return stateRepository;
    }

    private AttributeSetInstanceExtensionFieldMvoStateQueryRepository stateQueryRepository;

    protected AttributeSetInstanceExtensionFieldMvoStateQueryRepository getStateQueryRepository() {
        return stateQueryRepository;
    }

    public AbstractAttributeSetInstanceExtensionFieldMvoApplicationService(EventStore eventStore, AttributeSetInstanceExtensionFieldMvoStateRepository stateRepository, AttributeSetInstanceExtensionFieldMvoStateQueryRepository stateQueryRepository) {
        this.eventStore = eventStore;
        this.stateRepository = stateRepository;
        this.stateQueryRepository = stateQueryRepository;
    }

    public void when(AttributeSetInstanceExtensionFieldMvoCommand.CreateAttributeSetInstanceExtensionFieldMvo c) {
        update(c, ar -> ar.create(c));
    }

    public void when(AttributeSetInstanceExtensionFieldMvoCommand.MergePatchAttributeSetInstanceExtensionFieldMvo c) {
        update(c, ar -> ar.mergePatch(c));
    }

    public void when(AttributeSetInstanceExtensionFieldMvoCommand.DeleteAttributeSetInstanceExtensionFieldMvo c) {
        update(c, ar -> ar.delete(c));
    }

    public AttributeSetInstanceExtensionFieldMvoState get(AttributeSetInstanceExtensionFieldId id) {
        AttributeSetInstanceExtensionFieldMvoState state = getStateRepository().get(id, true);
        return state;
    }

    public Iterable<AttributeSetInstanceExtensionFieldMvoState> getAll(Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().getAll(firstResult, maxResults);
    }

    public Iterable<AttributeSetInstanceExtensionFieldMvoState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<AttributeSetInstanceExtensionFieldMvoState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<AttributeSetInstanceExtensionFieldMvoState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().getByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
    }

    public long getCount(Iterable<Map.Entry<String, Object>> filter) {
        return getStateQueryRepository().getCount(filter);
    }

    public long getCount(Criterion filter) {
        return getStateQueryRepository().getCount(filter);
    }

    public AttributeSetInstanceExtensionFieldMvoStateEvent getStateEvent(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId, long version) {
        AttributeSetInstanceExtensionFieldMvoStateEvent e = (AttributeSetInstanceExtensionFieldMvoStateEvent)getEventStore().getStateEvent(toEventStoreAggregateId(attributeSetInstanceExtensionFieldId), version);
        if (e != null)
        { e.setStateEventReadOnly(true); }
        else if (version == -1)
        {
            return getStateEvent(attributeSetInstanceExtensionFieldId, 0);
        }
        return e;
    }

    public AttributeSetInstanceExtensionFieldMvoState getHistoryState(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId, long version) {
        EventStream eventStream = getEventStore().loadEventStream(AbstractAttributeSetInstanceExtensionFieldMvoStateEvent.class, toEventStoreAggregateId(attributeSetInstanceExtensionFieldId), version - 1);
        return new AbstractAttributeSetInstanceExtensionFieldMvoState.SimpleAttributeSetInstanceExtensionFieldMvoState(eventStream.getEvents());
    }


    public AttributeSetInstanceExtensionFieldMvoAggregate getAttributeSetInstanceExtensionFieldMvoAggregate(AttributeSetInstanceExtensionFieldMvoState state)
    {
        return new AbstractAttributeSetInstanceExtensionFieldMvoAggregate.SimpleAttributeSetInstanceExtensionFieldMvoAggregate(state);
    }

    public EventStoreAggregateId toEventStoreAggregateId(AttributeSetInstanceExtensionFieldId aggregateId)
    {
        return new EventStoreAggregateId.SimpleEventStoreAggregateId(aggregateId);
    }

    protected void update(AttributeSetInstanceExtensionFieldMvoCommand c, Consumer<AttributeSetInstanceExtensionFieldMvoAggregate> action)
    {
        AttributeSetInstanceExtensionFieldId aggregateId = c.getAttributeSetInstanceExtensionFieldId();
        AttributeSetInstanceExtensionFieldMvoState state = getStateRepository().get(aggregateId, false);
        AttributeSetInstanceExtensionFieldMvoAggregate aggregate = getAttributeSetInstanceExtensionFieldMvoAggregate(state);

        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);

        boolean repeated = isRepeatedCommand(c, eventStoreAggregateId, state);
        if (repeated) { return; }

        aggregate.throwOnInvalidStateTransition(c);
        action.accept(aggregate);
        getEventStore().appendEvents(eventStoreAggregateId, c.getAttrSetInstEFGroupVersion(), // State version may be null!
            aggregate.getChanges(), (events) -> { getStateRepository().save(state); });

    }

    protected boolean isRepeatedCommand(AttributeSetInstanceExtensionFieldMvoCommand command, EventStoreAggregateId eventStoreAggregateId, AttributeSetInstanceExtensionFieldMvoState state)
    {
        boolean repeated = false;
        if (command.getAttrSetInstEFGroupVersion() == null) { command.setAttrSetInstEFGroupVersion(AttributeSetInstanceExtensionFieldMvoState.VERSION_NULL); }
        if (state.getAttrSetInstEFGroupVersion() != null && state.getAttrSetInstEFGroupVersion() > command.getAttrSetInstEFGroupVersion())
        {
            Event lastEvent = getEventStore().findLastEvent(AbstractAttributeSetInstanceExtensionFieldMvoStateEvent.class, eventStoreAggregateId, command.getAttrSetInstEFGroupVersion());
            if (lastEvent != null && lastEvent instanceof AbstractStateEvent
               && command.getCommandId() != null && command.getCommandId().equals(((AbstractStateEvent) lastEvent).getCommandId()))
            {
                repeated = true;
            }
        }
        return repeated;
    }

    public static class SimpleAttributeSetInstanceExtensionFieldMvoApplicationService extends AbstractAttributeSetInstanceExtensionFieldMvoApplicationService 
    {
        public SimpleAttributeSetInstanceExtensionFieldMvoApplicationService(EventStore eventStore, AttributeSetInstanceExtensionFieldMvoStateRepository stateRepository, AttributeSetInstanceExtensionFieldMvoStateQueryRepository stateQueryRepository)
        {
            super(eventStore, stateRepository, stateQueryRepository);
        }
    }

}

