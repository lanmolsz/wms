package org.dddml.wms.domain.shipmentmethodtype;

import java.util.*;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;

public interface ShipmentMethodTypeStateRepository
{
    ShipmentMethodTypeState get(String id, boolean nullAllowed);

    void save(ShipmentMethodTypeState state);

}

