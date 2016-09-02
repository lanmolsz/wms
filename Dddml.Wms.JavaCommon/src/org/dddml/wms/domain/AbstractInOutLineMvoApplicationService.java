package org.dddml.wms.domain;

import java.util.*;
import java.util.function.Consumer;
import org.dddml.support.criterion.Criterion;
import java.math.BigDecimal;
import java.util.Date;
import org.joda.money.Money;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.*;

public abstract class AbstractInOutLineMvoApplicationService implements InOutLineMvoApplicationService
{

    private EventStore eventStore;

    protected EventStore getEventStore()
    {
        return eventStore;
    }

    private InOutLineMvoStateRepository stateRepository;

    protected InOutLineMvoStateRepository getStateRepository()
    {
        return stateRepository;
    }

    public AbstractInOutLineMvoApplicationService(EventStore eventStore, InOutLineMvoStateRepository stateRepository)
    {
        this.eventStore = eventStore;
        this.stateRepository = stateRepository;
    }

    public void when(InOutLineMvoCommand.CreateInOutLineMvo c) {
        update(c, ar -> ar.create(c));
    }

    public void when(InOutLineMvoCommand.MergePatchInOutLineMvo c) {
        update(c, ar -> ar.mergePatch(c));
    }

    public void when(InOutLineMvoCommand.DeleteInOutLineMvo c) {
        update(c, ar -> ar.delete(c));
    }

    public InOutLineMvoState get(InOutLineId id) {

        InOutLineMvoState state = getStateRepository().get(id, true);
        return state;
    }

    public Iterable<InOutLineMvoState> getAll(Integer firstResult, Integer maxResults) {
        return getStateRepository().getAll(firstResult, maxResults);
    }

    public Iterable<InOutLineMvoState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<InOutLineMvoState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<InOutLineMvoState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().getByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
    }

    public long getCount(Iterable<Map.Entry<String, Object>> filter) {
        return getStateRepository().getCount(filter);
    }

    public long getCount(Criterion filter) {
        return getStateRepository().getCount(filter);
    }

    public InOutLineMvoStateEvent getStateEvent(InOutLineId inOutLineId, long version) {
        InOutLineMvoStateEvent e = (InOutLineMvoStateEvent)getEventStore().getStateEvent(toEventStoreAggregateId(inOutLineId), version);
        if (e != null)
        { e.setStateEventReadOnly(true); }
        else if (version == -1)
        {
            return getStateEvent(inOutLineId, 0);
        }
        return e;
    }


    public InOutLineMvoAggregate getInOutLineMvoAggregate(InOutLineMvoState state)
    {
        return new AbstractInOutLineMvoAggregate.SimpleInOutLineMvoAggregate(state);
    }

    public EventStoreAggregateId toEventStoreAggregateId(InOutLineId aggregateId)
    {
        return new EventStoreAggregateId.SimpleEventStoreAggregateId(aggregateId);
    }

    protected void update(InOutLineMvoCommand c, Consumer<InOutLineMvoAggregate> action)
    {
        InOutLineId aggregateId = c.getInOutLineId();
        InOutLineMvoState state = getStateRepository().get(aggregateId);
        InOutLineMvoAggregate aggregate = getInOutLineMvoAggregate(state);

        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);

        boolean repeated = isRepeatedCommand(c, eventStoreAggregateId, state);
        if (repeated) { return; }

        aggregate.throwOnInvalidStateTransition(c);
        action.accept(aggregate);
        getEventStore().appendEvents(eventStoreAggregateId, c.getInOutVersion(), // State version may be null!
            aggregate.getChanges(), (events) -> { getStateRepository().save(state); });
        
    }

    protected boolean isRepeatedCommand(InOutLineMvoCommand command, EventStoreAggregateId eventStoreAggregateId, InOutLineMvoState state)
    {
        boolean repeated = false;
        if (command.getInOutVersion() == null) { command.setInOutVersion(InOutLineMvoState.VERSION_NULL); }
        if (state.getInOutVersion() != null && state.getInOutVersion() > command.getInOutVersion())
        {
            Event lastEvent = getEventStore().findLastEvent(AbstractInOutLineMvoStateEvent.class, eventStoreAggregateId, command.getInOutVersion());
            if (lastEvent != null && lastEvent instanceof AbstractStateEvent
               && command.getCommandId() != null && command.getCommandId().equals(((AbstractStateEvent) lastEvent).getCommandId()))
            {
                repeated = true;
            }
        }
        return repeated;
    }

    public static class SimpleInOutLineMvoApplicationService extends AbstractInOutLineMvoApplicationService 
    {
        public SimpleInOutLineMvoApplicationService(EventStore eventStore, InOutLineMvoStateRepository stateRepository)
        {
            super(eventStore, stateRepository);
        }

    }

}

