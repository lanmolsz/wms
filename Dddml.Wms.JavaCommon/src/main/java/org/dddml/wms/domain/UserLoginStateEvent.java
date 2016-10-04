package org.dddml.wms.domain;

import java.util.*;
import java.util.Date;
import org.dddml.wms.specialization.Event;

public interface UserLoginStateEvent extends Event
{
    UserLoginStateEventId getStateEventId();

    boolean getStateEventReadOnly();

    void setStateEventReadOnly(boolean readOnly);

    Long getVersion();

    void setVersion(Long version);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    Boolean getActive();

    void setActive(Boolean active);

    String getUserId();

    void setUserId(String userId);

    String getCommandId();

    void setCommandId(String commandId);

    interface UserLoginStateCreated extends UserLoginStateEvent
    {
    
    }


    interface UserLoginStateMergePatched extends UserLoginStateEvent
    {
        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);


    }

    interface UserLoginStateRemoved extends UserLoginStateEvent
    {
    }


}

