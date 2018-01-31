package org.dddml.wms.domain.locator;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;

public interface LocatorStateQueryRepository
{
    LocatorState get(String id);

    Iterable<LocatorState> getAll(Integer firstResult, Integer maxResults);
    
    Iterable<LocatorState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<LocatorState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    LocatorState getFirst(Iterable<Map.Entry<String, Object>> filter, List<String> orders);

    LocatorState getFirst(Map.Entry<String, Object> keyValue, List<String> orders);

    Iterable<LocatorState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

}

