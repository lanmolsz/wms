package org.dddml.wms.domain.shipmentitemmvo.hibernate;

import java.io.Serializable;
import java.util.*;
import org.dddml.wms.domain.shipment.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.AbstractHibernateEventStore;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.springframework.transaction.annotation.Transactional;
import org.dddml.wms.domain.shipmentitemmvo.*;

public class HibernateShipmentItemMvoEventStore extends AbstractHibernateEventStore
{
    @Override
    protected Serializable getEventId(EventStoreAggregateId eventStoreAggregateId, long version)
    {
        return new ShipmentItemMvoEventId((ShipmentItemId) eventStoreAggregateId.getId(), version);
    }

    @Override
    protected Class getSupportedEventType()
    {
        return AbstractShipmentItemMvoEvent.class;
    }

    @Transactional(readOnly = true)
    @Override
    public EventStream loadEventStream(Class eventType, EventStoreAggregateId eventStoreAggregateId, long version) {
        Class supportedEventType = AbstractShipmentItemMvoEvent.class;
        if (!eventType.isAssignableFrom(supportedEventType)) {
            throw new UnsupportedOperationException();
        }
        ShipmentItemId idObj = (ShipmentItemId) eventStoreAggregateId.getId();
        Criteria criteria = getCurrentSession().createCriteria(AbstractShipmentItemMvoEvent.class);
        criteria.add(Restrictions.eq("shipmentItemMvoEventId.shipmentItemIdShipmentId", idObj.getShipmentId()));
        criteria.add(Restrictions.eq("shipmentItemMvoEventId.shipmentItemIdShipmentItemSeqId", idObj.getShipmentItemSeqId()));
        criteria.add(Restrictions.le("shipmentItemMvoEventId.shipmentVersion", version));
        criteria.addOrder(Order.asc("shipmentItemMvoEventId.shipmentVersion"));
        List es = criteria.list();
        for (Object e : es) {
            ((AbstractShipmentItemMvoEvent) e).setEventReadOnly(true);
        }
        EventStream eventStream = new EventStream();
        if (es.size() > 0) {
            eventStream.setSteamVersion(((AbstractShipmentItemMvoEvent) es.get(es.size() - 1)).getShipmentItemMvoEventId().getShipmentVersion());
        } else {
            //todo?
        }
        eventStream.setEvents(es);
        return eventStream;
    }

}

