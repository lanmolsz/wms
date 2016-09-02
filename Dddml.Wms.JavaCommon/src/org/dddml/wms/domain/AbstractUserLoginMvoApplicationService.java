package org.dddml.wms.domain;

import java.util.*;
import java.util.function.Consumer;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.*;

public abstract class AbstractUserLoginMvoApplicationService implements UserLoginMvoApplicationService
{

    private EventStore eventStore;

    protected EventStore getEventStore()
    {
        return eventStore;
    }

    private UserLoginMvoStateRepository stateRepository;

    protected UserLoginMvoStateRepository getStateRepository()
    {
        return stateRepository;
    }

    public AbstractUserLoginMvoApplicationService(EventStore eventStore, UserLoginMvoStateRepository stateRepository)
    {
        this.eventStore = eventStore;
        this.stateRepository = stateRepository;
    }

    public void when(UserLoginMvoCommand.CreateUserLoginMvo c) {
        update(c, ar -> ar.create(c));
    }

    public void when(UserLoginMvoCommand.MergePatchUserLoginMvo c) {
        update(c, ar -> ar.mergePatch(c));
    }

    public void when(UserLoginMvoCommand.DeleteUserLoginMvo c) {
        update(c, ar -> ar.delete(c));
    }

    public UserLoginMvoState get(UserLoginId id) {

        UserLoginMvoState state = getStateRepository().get(id, true);
        return state;
    }

    public Iterable<UserLoginMvoState> getAll(Integer firstResult, Integer maxResults) {
        return getStateRepository().getAll(firstResult, maxResults);
    }

    public Iterable<UserLoginMvoState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<UserLoginMvoState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<UserLoginMvoState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().getByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
    }

    public long getCount(Iterable<Map.Entry<String, Object>> filter) {
        return getStateRepository().getCount(filter);
    }

    public long getCount(Criterion filter) {
        return getStateRepository().getCount(filter);
    }

    public UserLoginMvoStateEvent getStateEvent(UserLoginId userLoginId, long version) {
        UserLoginMvoStateEvent e = (UserLoginMvoStateEvent)getEventStore().getStateEvent(toEventStoreAggregateId(userLoginId), version);
        if (e != null)
        { e.setStateEventReadOnly(true); }
        return e;
    }


    public UserLoginMvoAggregate getUserLoginMvoAggregate(UserLoginMvoState state)
    {
        return new AbstractUserLoginMvoAggregate.SimpleUserLoginMvoAggregate(state);
    }

    public EventStoreAggregateId toEventStoreAggregateId(UserLoginId aggregateId)
    {
        return new EventStoreAggregateId.SimpleEventStoreAggregateId(aggregateId);
    }

    protected void update(UserLoginMvoCommand c, Consumer<UserLoginMvoAggregate> action)
    {
        UserLoginId aggregateId = c.getUserLoginId();
        UserLoginMvoState state = getStateRepository().get(aggregateId);
        UserLoginMvoAggregate aggregate = getUserLoginMvoAggregate(state);

        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);

        boolean repeated = isRepeatedCommand(c, eventStoreAggregateId, state);
        if (repeated) { return; }

        aggregate.throwOnInvalidStateTransition(c);
        action.accept(aggregate);
        getEventStore().appendEvents(eventStoreAggregateId, c.getUserVersion(), // State version may be null!
            aggregate.getChanges(), (events) -> { getStateRepository().save(state); });
        
    }

    protected boolean isRepeatedCommand(UserLoginMvoCommand command, EventStoreAggregateId eventStoreAggregateId, UserLoginMvoState state)
    {
        boolean repeated = false;
        if (command.getUserVersion() == null) { command.setUserVersion(UserLoginMvoState.VERSION_NULL); }
        if (state.getUserVersion() != null && state.getUserVersion() > command.getUserVersion())
        {
            Event lastEvent = getEventStore().findLastEvent(AbstractUserLoginMvoStateEvent.class, eventStoreAggregateId, command.getUserVersion());
            if (lastEvent != null && lastEvent instanceof AbstractStateEvent
               && command.getCommandId() != null && command.getCommandId().equals(((AbstractStateEvent) lastEvent).getCommandId()))
            {
                repeated = true;
            }
        }
        return repeated;
    }

    public static class SimpleUserLoginMvoApplicationService extends AbstractUserLoginMvoApplicationService 
    {
        public SimpleUserLoginMvoApplicationService(EventStore eventStore, UserLoginMvoStateRepository stateRepository)
        {
            super(eventStore, stateRepository);
        }

    }

}

