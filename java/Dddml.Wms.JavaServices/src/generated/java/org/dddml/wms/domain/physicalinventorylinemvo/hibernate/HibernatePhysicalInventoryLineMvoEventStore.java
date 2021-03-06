package org.dddml.wms.domain.physicalinventorylinemvo.hibernate;

import java.io.Serializable;
import java.util.*;
import org.dddml.wms.domain.physicalinventory.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.AbstractHibernateEventStore;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.springframework.transaction.annotation.Transactional;
import org.dddml.wms.domain.physicalinventorylinemvo.*;

public class HibernatePhysicalInventoryLineMvoEventStore extends AbstractHibernateEventStore
{
    @Override
    protected Serializable getEventId(EventStoreAggregateId eventStoreAggregateId, long version)
    {
        return new PhysicalInventoryLineMvoEventId((PhysicalInventoryLineId) eventStoreAggregateId.getId(), version);
    }

    @Override
    protected Class getSupportedEventType()
    {
        return AbstractPhysicalInventoryLineMvoEvent.class;
    }

    @Transactional(readOnly = true)
    @Override
    public EventStream loadEventStream(Class eventType, EventStoreAggregateId eventStoreAggregateId, long version) {
        Class supportedEventType = AbstractPhysicalInventoryLineMvoEvent.class;
        if (!eventType.isAssignableFrom(supportedEventType)) {
            throw new UnsupportedOperationException();
        }
        PhysicalInventoryLineId idObj = (PhysicalInventoryLineId) eventStoreAggregateId.getId();
        Criteria criteria = getCurrentSession().createCriteria(AbstractPhysicalInventoryLineMvoEvent.class);
        criteria.add(Restrictions.eq("physicalInventoryLineMvoEventId.physicalInventoryLineIdPhysicalInventoryDocumentNumber", idObj.getPhysicalInventoryDocumentNumber()));
        criteria.add(Restrictions.eq("physicalInventoryLineMvoEventId.physicalInventoryLineIdInventoryItemIdProductId", idObj.getInventoryItemId().getProductId()));
        criteria.add(Restrictions.eq("physicalInventoryLineMvoEventId.physicalInventoryLineIdInventoryItemIdLocatorId", idObj.getInventoryItemId().getLocatorId()));
        criteria.add(Restrictions.eq("physicalInventoryLineMvoEventId.physicalInventoryLineIdInventoryItemIdAttributeSetInstanceId", idObj.getInventoryItemId().getAttributeSetInstanceId()));
        criteria.add(Restrictions.le("physicalInventoryLineMvoEventId.physicalInventoryVersion", version));
        criteria.addOrder(Order.asc("physicalInventoryLineMvoEventId.physicalInventoryVersion"));
        List es = criteria.list();
        for (Object e : es) {
            ((AbstractPhysicalInventoryLineMvoEvent) e).setEventReadOnly(true);
        }
        EventStream eventStream = new EventStream();
        if (es.size() > 0) {
            eventStream.setSteamVersion(((AbstractPhysicalInventoryLineMvoEvent) es.get(es.size() - 1)).getPhysicalInventoryLineMvoEventId().getPhysicalInventoryVersion());
        } else {
            //todo?
        }
        eventStream.setEvents(es);
        return eventStream;
    }

}

