package org.dddml.wms.domain.attributeset;

import java.util.Date;
import org.dddml.wms.domain.*;

public interface AttributeUseStateDao
{
    AttributeUseState get(AttributeSetAttributeUseId id, boolean nullAllowed);

    void save(AttributeUseState state);

    Iterable<AttributeUseState> findByAttributeSetId(String attributeSetId);

    void delete(AttributeUseState state);
}


