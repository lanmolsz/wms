package org.dddml.wms.domain.attributesetinstance.hibernate;

import java.io.Serializable;
import java.util.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.AbstractHibernateEventStore;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.springframework.transaction.annotation.Transactional;
import org.dddml.wms.domain.attributesetinstance.*;
import java.util.function.Consumer;

public class HibernateAttributeSetInstanceEventStore implements EventStore {
    private SessionFactory sessionFactory;

    public SessionFactory getSessionFactory() { return this.sessionFactory; }

    public void setSessionFactory(SessionFactory sessionFactory) { this.sessionFactory = sessionFactory; }

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }

    @Transactional(readOnly = true)
    @Override
    public EventStream loadEventStream(EventStoreAggregateId aggregateId) {
        throw new UnsupportedOperationException();
    }

    @Transactional
    @Override
    public void appendEvents(EventStoreAggregateId aggregateId, long version, Collection<Event> events, Consumer<Collection<Event>> afterEventsAppended) {
        for (Event e : events) {
            if (e instanceof AbstractAttributeSetInstanceEvent.AbstractAttributeSetInstanceStateCreated) {
                AttributeSetInstanceState s = ((AbstractAttributeSetInstanceEvent.AbstractAttributeSetInstanceStateCreated)e).getAttributeSetInstanceState();
                getCurrentSession().save(s);
            } else {
                getCurrentSession().save(e);
            }
            if (e instanceof Saveable) {
                Saveable saveable = (Saveable) e;
                saveable.save();
            }
        }
        //System.out.println("####################################################");
        afterEventsAppended.accept(events);
        //System.out.println("####################################################");
    }

    @Transactional(readOnly = true)
    @Override
    public Event getEvent(Class eventType, EventStoreAggregateId eventStoreAggregateId, long version) {
        Class supportedEventType = AttributeSetInstanceEvent.AttributeSetInstanceStateCreated.class;
        if (!eventType.isAssignableFrom(supportedEventType)) {
            throw new UnsupportedOperationException();
        }
        return getEvent(eventStoreAggregateId, version);
    }

    @Transactional(readOnly = true)
    @Override
    public Event getEvent(EventStoreAggregateId eventStoreAggregateId, long version) {
        String idObj = (String) eventStoreAggregateId.getId();
        AttributeSetInstanceState state = getCurrentSession().get(AbstractAttributeSetInstanceState.class, idObj);
        return new AbstractAttributeSetInstanceEvent.SimpleAttributeSetInstanceStateCreated(state);
    }

    @Transactional(readOnly = true)
    @Override
    public EventStream loadEventStream(Class eventType, EventStoreAggregateId eventStoreAggregateId, long version) {
        Class supportedEventType = AttributeSetInstanceEvent.AttributeSetInstanceStateCreated.class;
        if (!eventType.isAssignableFrom(supportedEventType)) {
            throw new UnsupportedOperationException();
        }
        Event e = getEvent(eventStoreAggregateId, version);
        EventStream es = new EventStream();
        es.setEvents(e != null ? Collections.singletonList(e) : Collections.EMPTY_LIST);
        return es;
    }

}

