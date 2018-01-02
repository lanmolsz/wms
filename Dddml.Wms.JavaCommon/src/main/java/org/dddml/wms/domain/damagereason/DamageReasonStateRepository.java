package org.dddml.wms.domain.damagereason;

import java.util.*;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;

public interface DamageReasonStateRepository
{
    DamageReasonState get(String id, boolean nullAllowed);

    void save(DamageReasonState state);

}

