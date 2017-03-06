package org.dddml.wms.domain.attributesetinstanceextensionfieldmvo;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import org.dddml.wms.domain.attributesetinstanceextensionfieldgroup.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.Command;

public interface AttributeSetInstanceExtensionFieldMvoApplicationService
{
    void when(AttributeSetInstanceExtensionFieldMvoCommand.CreateAttributeSetInstanceExtensionFieldMvo c);

    void when(AttributeSetInstanceExtensionFieldMvoCommand.MergePatchAttributeSetInstanceExtensionFieldMvo c);

    void when(AttributeSetInstanceExtensionFieldMvoCommand.DeleteAttributeSetInstanceExtensionFieldMvo c);

    AttributeSetInstanceExtensionFieldMvoState get(AttributeSetInstanceExtensionFieldId id);

    Iterable<AttributeSetInstanceExtensionFieldMvoState> getAll(Integer firstResult, Integer maxResults);

    Iterable<AttributeSetInstanceExtensionFieldMvoState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<AttributeSetInstanceExtensionFieldMvoState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<AttributeSetInstanceExtensionFieldMvoState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

    AttributeSetInstanceExtensionFieldMvoStateEvent getStateEvent(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId, long version);

    AttributeSetInstanceExtensionFieldMvoState getHistoryState(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId, long version);

}

