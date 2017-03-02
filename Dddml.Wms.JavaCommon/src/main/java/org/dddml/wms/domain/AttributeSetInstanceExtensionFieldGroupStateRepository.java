package org.dddml.wms.domain;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;

public interface AttributeSetInstanceExtensionFieldGroupStateRepository
{
    AttributeSetInstanceExtensionFieldGroupState get(String id);

    AttributeSetInstanceExtensionFieldGroupState get(String id, boolean nullAllowed);

    Iterable<AttributeSetInstanceExtensionFieldGroupState> getAll(Integer firstResult, Integer maxResults);
    
    void save(AttributeSetInstanceExtensionFieldGroupState state);
    
    Iterable<AttributeSetInstanceExtensionFieldGroupState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<AttributeSetInstanceExtensionFieldGroupState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    AttributeSetInstanceExtensionFieldGroupState getFirst(Iterable<Map.Entry<String, Object>> filter, List<String> orders);

    AttributeSetInstanceExtensionFieldGroupState getFirst(Map.Entry<String, Object> keyValue, List<String> orders);

    Iterable<AttributeSetInstanceExtensionFieldGroupState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

    AttributeSetInstanceExtensionFieldState getAttributeSetInstanceExtensionField(String groupId, String index);

}

