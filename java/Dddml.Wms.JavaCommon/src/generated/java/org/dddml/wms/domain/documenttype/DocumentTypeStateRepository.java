package org.dddml.wms.domain.documenttype;

import java.util.*;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;

public interface DocumentTypeStateRepository
{
    DocumentTypeState get(String id, boolean nullAllowed);

    void save(DocumentTypeState state);

}

