package org.dddml.wms.domain.attributevaluemvo;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import org.dddml.wms.domain.attribute.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.Command;

public interface AttributeValueMvoApplicationService
{
    void when(AttributeValueMvoCommand.CreateAttributeValueMvo c);

    void when(AttributeValueMvoCommand.MergePatchAttributeValueMvo c);

    void when(AttributeValueMvoCommand.DeleteAttributeValueMvo c);

    AttributeValueMvoState get(AttributeValueId id);

    Iterable<AttributeValueMvoState> getAll(Integer firstResult, Integer maxResults);

    Iterable<AttributeValueMvoState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<AttributeValueMvoState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<AttributeValueMvoState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

    AttributeValueMvoStateEvent getStateEvent(AttributeValueId attributeValueId, long version);

    AttributeValueMvoState getHistoryState(AttributeValueId attributeValueId, long version);

}

