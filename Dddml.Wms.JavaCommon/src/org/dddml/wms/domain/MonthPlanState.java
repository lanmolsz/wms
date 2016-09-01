package org.dddml.wms.domain;

import java.util.Set;
import java.util.Date;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.MonthPlanStateEvent.*;

public interface MonthPlanState
{
    Long VERSION_ZERO = 0L;

    Long VERSION_NULL = VERSION_ZERO - 1;

    MonthPlanId getMonthPlanId();

    void setMonthPlanId(MonthPlanId monthPlanId);

    Integer getMonth();

    void setMonth(Integer month);

    String getDescription();

    void setDescription(String description);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    String getUpdatedBy();

    void setUpdatedBy(String updatedBy);

    Long getVersion();

    void setVersion(Long version);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    Date getUpdatedAt();

    void setUpdatedAt(Date updatedAt);

    Boolean getActive();

    void setActive(Boolean active);

    Boolean getDeleted();

    void setDeleted(Boolean deleted);

    PersonalName getPersonalName();

    void setPersonalName(PersonalName personalName);

    Integer getYear();

    void setYear(Integer year);


    boolean isStateUnsaved();

    DayPlanStates getDayPlans();


    void mutate(Event e);

    void when(MonthPlanStateCreated e);

    void when(MonthPlanStateMergePatched e);

    void when(MonthPlanStateRemoved e);
    
}

