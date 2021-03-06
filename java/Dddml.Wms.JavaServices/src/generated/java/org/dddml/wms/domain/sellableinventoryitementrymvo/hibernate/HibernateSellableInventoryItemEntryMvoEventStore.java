package org.dddml.wms.domain.sellableinventoryitementrymvo.hibernate;

import java.io.Serializable;
import java.util.*;
import org.dddml.wms.domain.sellableinventoryitem.*;
import java.math.BigDecimal;
import org.dddml.wms.domain.inventoryprtriggered.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.AbstractHibernateEventStore;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.springframework.transaction.annotation.Transactional;
import org.dddml.wms.domain.sellableinventoryitementrymvo.*;

public class HibernateSellableInventoryItemEntryMvoEventStore extends AbstractHibernateEventStore
{
    @Override
    protected Serializable getEventId(EventStoreAggregateId eventStoreAggregateId, long version)
    {
        return new SellableInventoryItemEntryMvoEventId((SellableInventoryItemEntryId) eventStoreAggregateId.getId(), version);
    }

    @Override
    protected Class getSupportedEventType()
    {
        return AbstractSellableInventoryItemEntryMvoEvent.class;
    }

    @Transactional(readOnly = true)
    @Override
    public EventStream loadEventStream(Class eventType, EventStoreAggregateId eventStoreAggregateId, long version) {
        Class supportedEventType = AbstractSellableInventoryItemEntryMvoEvent.class;
        if (!eventType.isAssignableFrom(supportedEventType)) {
            throw new UnsupportedOperationException();
        }
        SellableInventoryItemEntryId idObj = (SellableInventoryItemEntryId) eventStoreAggregateId.getId();
        Criteria criteria = getCurrentSession().createCriteria(AbstractSellableInventoryItemEntryMvoEvent.class);
        criteria.add(Restrictions.eq("sellableInventoryItemEntryMvoEventId.sellableInventoryItemEntryIdSellableInventoryItemIdProductId", idObj.getSellableInventoryItemId().getProductId()));
        criteria.add(Restrictions.eq("sellableInventoryItemEntryMvoEventId.sellableInventoryItemEntryIdSellableInventoryItemIdLocatorId", idObj.getSellableInventoryItemId().getLocatorId()));
        criteria.add(Restrictions.eq("sellableInventoryItemEntryMvoEventId.sellableInventoryItemEntryIdSellableInventoryItemIdAttributeSetInstanceId", idObj.getSellableInventoryItemId().getAttributeSetInstanceId()));
        criteria.add(Restrictions.eq("sellableInventoryItemEntryMvoEventId.sellableInventoryItemEntryIdEntrySeqId", idObj.getEntrySeqId()));
        criteria.add(Restrictions.le("sellableInventoryItemEntryMvoEventId.sellableInventoryItemVersion", version));
        criteria.addOrder(Order.asc("sellableInventoryItemEntryMvoEventId.sellableInventoryItemVersion"));
        List es = criteria.list();
        for (Object e : es) {
            ((AbstractSellableInventoryItemEntryMvoEvent) e).setEventReadOnly(true);
        }
        EventStream eventStream = new EventStream();
        if (es.size() > 0) {
            eventStream.setSteamVersion(((AbstractSellableInventoryItemEntryMvoEvent) es.get(es.size() - 1)).getSellableInventoryItemEntryMvoEventId().getSellableInventoryItemVersion());
        } else {
            //todo?
        }
        eventStream.setEvents(es);
        return eventStream;
    }

}

