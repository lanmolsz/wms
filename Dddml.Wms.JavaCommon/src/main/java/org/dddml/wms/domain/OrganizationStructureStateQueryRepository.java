package org.dddml.wms.domain;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;

public interface OrganizationStructureStateQueryRepository
{
    OrganizationStructureState get(OrganizationStructureId id);

    Iterable<OrganizationStructureState> getAll(Integer firstResult, Integer maxResults);
    
    Iterable<OrganizationStructureState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<OrganizationStructureState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    OrganizationStructureState getFirst(Iterable<Map.Entry<String, Object>> filter, List<String> orders);

    OrganizationStructureState getFirst(Map.Entry<String, Object> keyValue, List<String> orders);

    Iterable<OrganizationStructureState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

}

