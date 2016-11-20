package org.dddml.wms.domain;

import java.util.*;
import java.util.function.Consumer;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.*;

public abstract class AbstractUserPermissionMvoApplicationService implements UserPermissionMvoApplicationService
{

    private EventStore eventStore;

    protected EventStore getEventStore()
    {
        return eventStore;
    }

    private UserPermissionMvoStateRepository stateRepository;

    protected UserPermissionMvoStateRepository getStateRepository()
    {
        return stateRepository;
    }

    public AbstractUserPermissionMvoApplicationService(EventStore eventStore, UserPermissionMvoStateRepository stateRepository)
    {
        this.eventStore = eventStore;
        this.stateRepository = stateRepository;
    }

    public void when(UserPermissionMvoCommand.CreateUserPermissionMvo c) {
        update(c, ar -> ar.create(c));
    }

    public void when(UserPermissionMvoCommand.MergePatchUserPermissionMvo c) {
        update(c, ar -> ar.mergePatch(c));
    }

    public void when(UserPermissionMvoCommand.DeleteUserPermissionMvo c) {
        update(c, ar -> ar.delete(c));
    }

    public UserPermissionMvoState get(UserPermissionId id) {
        UserPermissionMvoState state = getStateRepository().get(id, true);
        return state;
    }

    public Iterable<UserPermissionMvoState> getAll(Integer firstResult, Integer maxResults) {
        return getStateRepository().getAll(firstResult, maxResults);
    }

    public Iterable<UserPermissionMvoState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<UserPermissionMvoState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<UserPermissionMvoState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().getByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
    }

    public long getCount(Iterable<Map.Entry<String, Object>> filter) {
        return getStateRepository().getCount(filter);
    }

    public long getCount(Criterion filter) {
        return getStateRepository().getCount(filter);
    }

    public UserPermissionMvoStateEvent getStateEvent(UserPermissionId userPermissionId, long version) {
        UserPermissionMvoStateEvent e = (UserPermissionMvoStateEvent)getEventStore().getStateEvent(toEventStoreAggregateId(userPermissionId), version);
        if (e != null)
        { e.setStateEventReadOnly(true); }
        else if (version == -1)
        {
            return getStateEvent(userPermissionId, 0);
        }
        return e;
    }

    public UserPermissionMvoState getHistoryState(UserPermissionId userPermissionId, long version) {
        EventStream eventStream = getEventStore().loadEventStream(AbstractUserPermissionMvoStateEvent.class, toEventStoreAggregateId(userPermissionId), version - 1);
        return new AbstractUserPermissionMvoState.SimpleUserPermissionMvoState(eventStream.getEvents());
    }


    public UserPermissionMvoAggregate getUserPermissionMvoAggregate(UserPermissionMvoState state)
    {
        return new AbstractUserPermissionMvoAggregate.SimpleUserPermissionMvoAggregate(state);
    }

    public EventStoreAggregateId toEventStoreAggregateId(UserPermissionId aggregateId)
    {
        return new EventStoreAggregateId.SimpleEventStoreAggregateId(aggregateId);
    }

    protected void update(UserPermissionMvoCommand c, Consumer<UserPermissionMvoAggregate> action)
    {
        UserPermissionId aggregateId = c.getUserPermissionId();
        UserPermissionMvoState state = getStateRepository().get(aggregateId);
        UserPermissionMvoAggregate aggregate = getUserPermissionMvoAggregate(state);

        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);

        boolean repeated = isRepeatedCommand(c, eventStoreAggregateId, state);
        if (repeated) { return; }

        aggregate.throwOnInvalidStateTransition(c);
        action.accept(aggregate);
        getEventStore().appendEvents(eventStoreAggregateId, c.getUserVersion(), // State version may be null!
            aggregate.getChanges(), (events) -> { getStateRepository().save(state); });
        
    }

    protected boolean isRepeatedCommand(UserPermissionMvoCommand command, EventStoreAggregateId eventStoreAggregateId, UserPermissionMvoState state)
    {
        boolean repeated = false;
        if (command.getUserVersion() == null) { command.setUserVersion(UserPermissionMvoState.VERSION_NULL); }
        if (state.getUserVersion() != null && state.getUserVersion() > command.getUserVersion())
        {
            Event lastEvent = getEventStore().findLastEvent(AbstractUserPermissionMvoStateEvent.class, eventStoreAggregateId, command.getUserVersion());
            if (lastEvent != null && lastEvent instanceof AbstractStateEvent
               && command.getCommandId() != null && command.getCommandId().equals(((AbstractStateEvent) lastEvent).getCommandId()))
            {
                repeated = true;
            }
        }
        return repeated;
    }

    public static class SimpleUserPermissionMvoApplicationService extends AbstractUserPermissionMvoApplicationService 
    {
        public SimpleUserPermissionMvoApplicationService(EventStore eventStore, UserPermissionMvoStateRepository stateRepository)
        {
            super(eventStore, stateRepository);
        }
    }

}

