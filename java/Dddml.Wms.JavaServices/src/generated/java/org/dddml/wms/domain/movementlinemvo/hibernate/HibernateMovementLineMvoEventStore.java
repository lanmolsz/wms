package org.dddml.wms.domain.movementlinemvo.hibernate;

import java.io.Serializable;
import java.util.*;
import org.dddml.wms.domain.movement.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.AbstractHibernateEventStore;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.springframework.transaction.annotation.Transactional;
import org.dddml.wms.domain.movementlinemvo.*;

public class HibernateMovementLineMvoEventStore extends AbstractHibernateEventStore
{
    @Override
    protected Serializable getEventId(EventStoreAggregateId eventStoreAggregateId, long version)
    {
        return new MovementLineMvoEventId((MovementLineId) eventStoreAggregateId.getId(), version);
    }

    @Override
    protected Class getSupportedStateEventType()
    {
        return AbstractMovementLineMvoStateEvent.class;
    }

    @Transactional(readOnly = true)
    @Override
    public EventStream loadEventStream(Class eventType, EventStoreAggregateId eventStoreAggregateId, long version) {
        Class supportedEventType = AbstractMovementLineMvoStateEvent.class;
        if (!eventType.isAssignableFrom(supportedEventType)) {
            throw new UnsupportedOperationException();
        }
        MovementLineId idObj = (MovementLineId) eventStoreAggregateId.getId();
        Criteria criteria = getCurrentSession().createCriteria(AbstractMovementLineMvoStateEvent.class);
        criteria.add(Restrictions.eq("stateEventId.movementLineIdMovementDocumentNumber", idObj.getMovementDocumentNumber()));
        criteria.add(Restrictions.eq("stateEventId.movementLineIdLineNumber", idObj.getLineNumber()));
        criteria.add(Restrictions.le("stateEventId.movementVersion", version));
        criteria.addOrder(Order.asc("stateEventId.movementVersion"));
        List es = criteria.list();
        for (Object e : es) {
            ((AbstractMovementLineMvoStateEvent) e).setStateEventReadOnly(true);
        }
        EventStream eventStream = new EventStream();
        if (es.size() > 0) {
            eventStream.setSteamVersion(((AbstractMovementLineMvoStateEvent) es.get(es.size() - 1)).getStateEventId().getMovementVersion());
        } else {
            //todo?
        }
        eventStream.setEvents(es);
        return eventStream;
    }

}

