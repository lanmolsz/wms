package org.dddml.wms.domain.contactmech;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;

public interface ContactMechStateQueryRepository
{
    ContactMechState get(String id);

    Iterable<ContactMechState> getAll(Integer firstResult, Integer maxResults);
    
    Iterable<ContactMechState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<ContactMechState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    ContactMechState getFirst(Iterable<Map.Entry<String, Object>> filter, List<String> orders);

    ContactMechState getFirst(Map.Entry<String, Object> keyValue, List<String> orders);

    Iterable<ContactMechState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

}

