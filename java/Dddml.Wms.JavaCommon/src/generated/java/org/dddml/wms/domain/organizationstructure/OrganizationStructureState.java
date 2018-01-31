package org.dddml.wms.domain.organizationstructure;

import java.util.Set;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.organizationstructure.OrganizationStructureStateEvent.*;

public interface OrganizationStructureState
{
    Long VERSION_ZERO = 0L;

    Long VERSION_NULL = VERSION_ZERO - 1;

    OrganizationStructureId getId();

    void setId(OrganizationStructureId id);

    Long getVersion();

    void setVersion(Long version);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    String getUpdatedBy();

    void setUpdatedBy(String updatedBy);

    Date getUpdatedAt();

    void setUpdatedAt(Date updatedAt);

    Boolean getActive();

    void setActive(Boolean active);

    Boolean getDeleted();

    void setDeleted(Boolean deleted);


    boolean isStateUnsaved();

    boolean getForReapplying();


    void mutate(Event e);

    void when(OrganizationStructureStateEvent.OrganizationStructureStateCreated e);

    void when(OrganizationStructureStateEvent.OrganizationStructureStateMergePatched e);

    void when(OrganizationStructureStateEvent.OrganizationStructureStateDeleted e);
    
}

