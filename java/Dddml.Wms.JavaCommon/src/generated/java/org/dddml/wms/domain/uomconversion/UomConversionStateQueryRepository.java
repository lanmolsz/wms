package org.dddml.wms.domain.uomconversion;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;

public interface UomConversionStateQueryRepository
{
    UomConversionState get(UomConversionId id);

    Iterable<UomConversionState> getAll(Integer firstResult, Integer maxResults);
    
    Iterable<UomConversionState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<UomConversionState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    UomConversionState getFirst(Iterable<Map.Entry<String, Object>> filter, List<String> orders);

    UomConversionState getFirst(Map.Entry<String, Object> keyValue, List<String> orders);

    Iterable<UomConversionState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

}

