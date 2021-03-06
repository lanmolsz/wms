package org.dddml.wms.domain.partyrole;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;

public interface PartyRoleEvent extends Event
{
    PartyRoleEventId getPartyRoleEventId();

    boolean getEventReadOnly();

    void setEventReadOnly(boolean readOnly);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    String getCommandId();

    void setCommandId(String commandId);

    interface PartyRoleStateEvent extends PartyRoleEvent {
        Boolean getActive();

        void setActive(Boolean active);

    }

    interface PartyRoleStateCreated extends PartyRoleStateEvent
    {
    
    }


    interface PartyRoleStateMergePatched extends PartyRoleStateEvent
    {
        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);


    }

    interface PartyRoleStateDeleted extends PartyRoleStateEvent
    {
    }


}

