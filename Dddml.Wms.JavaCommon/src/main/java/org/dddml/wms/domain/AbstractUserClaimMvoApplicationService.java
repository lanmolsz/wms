package org.dddml.wms.domain;

import java.util.*;
import java.util.function.Consumer;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.*;

public abstract class AbstractUserClaimMvoApplicationService implements UserClaimMvoApplicationService
{

    private EventStore eventStore;

    protected EventStore getEventStore()
    {
        return eventStore;
    }

    private UserClaimMvoStateRepository stateRepository;

    protected UserClaimMvoStateRepository getStateRepository()
    {
        return stateRepository;
    }

    public AbstractUserClaimMvoApplicationService(EventStore eventStore, UserClaimMvoStateRepository stateRepository)
    {
        this.eventStore = eventStore;
        this.stateRepository = stateRepository;
    }

    public void when(UserClaimMvoCommand.CreateUserClaimMvo c) {
        update(c, ar -> ar.create(c));
    }

    public void when(UserClaimMvoCommand.MergePatchUserClaimMvo c) {
        update(c, ar -> ar.mergePatch(c));
    }

    public void when(UserClaimMvoCommand.DeleteUserClaimMvo c) {
        update(c, ar -> ar.delete(c));
    }

    public UserClaimMvoState get(UserClaimId id) {
        UserClaimMvoState state = getStateRepository().get(id, true);
        return state;
    }

    public Iterable<UserClaimMvoState> getAll(Integer firstResult, Integer maxResults) {
        return getStateRepository().getAll(firstResult, maxResults);
    }

    public Iterable<UserClaimMvoState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<UserClaimMvoState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<UserClaimMvoState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().getByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
    }

    public long getCount(Iterable<Map.Entry<String, Object>> filter) {
        return getStateRepository().getCount(filter);
    }

    public long getCount(Criterion filter) {
        return getStateRepository().getCount(filter);
    }

    public UserClaimMvoStateEvent getStateEvent(UserClaimId userClaimId, long version) {
        UserClaimMvoStateEvent e = (UserClaimMvoStateEvent)getEventStore().getStateEvent(toEventStoreAggregateId(userClaimId), version);
        if (e != null)
        { e.setStateEventReadOnly(true); }
        else if (version == -1)
        {
            return getStateEvent(userClaimId, 0);
        }
        return e;
    }

    public UserClaimMvoState getHistoryState(UserClaimId userClaimId, long version) {
        EventStream eventStream = getEventStore().loadEventStream(AbstractUserClaimMvoStateEvent.class, toEventStoreAggregateId(userClaimId), version - 1);
        return new AbstractUserClaimMvoState.SimpleUserClaimMvoState(eventStream.getEvents());
    }


    public UserClaimMvoAggregate getUserClaimMvoAggregate(UserClaimMvoState state)
    {
        return new AbstractUserClaimMvoAggregate.SimpleUserClaimMvoAggregate(state);
    }

    public EventStoreAggregateId toEventStoreAggregateId(UserClaimId aggregateId)
    {
        return new EventStoreAggregateId.SimpleEventStoreAggregateId(aggregateId);
    }

    protected void update(UserClaimMvoCommand c, Consumer<UserClaimMvoAggregate> action)
    {
        UserClaimId aggregateId = c.getUserClaimId();
        UserClaimMvoState state = getStateRepository().get(aggregateId);
        UserClaimMvoAggregate aggregate = getUserClaimMvoAggregate(state);

        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);

        boolean repeated = isRepeatedCommand(c, eventStoreAggregateId, state);
        if (repeated) { return; }

        aggregate.throwOnInvalidStateTransition(c);
        action.accept(aggregate);
        getEventStore().appendEvents(eventStoreAggregateId, c.getUserVersion(), // State version may be null!
            aggregate.getChanges(), (events) -> { getStateRepository().save(state); });

    }

    protected boolean isRepeatedCommand(UserClaimMvoCommand command, EventStoreAggregateId eventStoreAggregateId, UserClaimMvoState state)
    {
        boolean repeated = false;
        if (command.getUserVersion() == null) { command.setUserVersion(UserClaimMvoState.VERSION_NULL); }
        if (state.getUserVersion() != null && state.getUserVersion() > command.getUserVersion())
        {
            Event lastEvent = getEventStore().findLastEvent(AbstractUserClaimMvoStateEvent.class, eventStoreAggregateId, command.getUserVersion());
            if (lastEvent != null && lastEvent instanceof AbstractStateEvent
               && command.getCommandId() != null && command.getCommandId().equals(((AbstractStateEvent) lastEvent).getCommandId()))
            {
                repeated = true;
            }
        }
        return repeated;
    }

    public static class SimpleUserClaimMvoApplicationService extends AbstractUserClaimMvoApplicationService 
    {
        public SimpleUserClaimMvoApplicationService(EventStore eventStore, UserClaimMvoStateRepository stateRepository)
        {
            super(eventStore, stateRepository);
        }
    }

}

