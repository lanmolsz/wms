package org.dddml.wms.domain.picklist;

import org.dddml.wms.domain.partyrole.*;
import java.util.Date;
import org.dddml.wms.domain.*;

public interface PicklistRoleEventDao
{
    void save(PicklistRoleEvent e);

    Iterable<PicklistRoleEvent> findByPicklistEventId(PicklistEventId picklistEventId);

}

