package org.dddml.wms.domain.attributeset;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;

public interface AttributeSetStateEvent extends Event
{
    AttributeSetStateEventId getStateEventId();

    boolean getStateEventReadOnly();

    void setStateEventReadOnly(boolean readOnly);

    String getAttributeSetName();

    void setAttributeSetName(String attributeSetName);

    String getOrganizationId();

    void setOrganizationId(String organizationId);

    String getDescription();

    void setDescription(String description);

    String getSerialNumberAttributeId();

    void setSerialNumberAttributeId(String serialNumberAttributeId);

    String getLotAttributeId();

    void setLotAttributeId(String lotAttributeId);

    String getReferenceId();

    void setReferenceId(String referenceId);

    Boolean getIsInstanceAttributeSet();

    void setIsInstanceAttributeSet(Boolean isInstanceAttributeSet);

    Boolean getIsMandatory();

    void setIsMandatory(Boolean isMandatory);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    Boolean getActive();

    void setActive(Boolean active);

    String getCommandId();

    void setCommandId(String commandId);

    interface AttributeSetStateCreated extends AttributeSetStateEvent
    {
        Iterable<AttributeUseStateEvent.AttributeUseStateCreated> getAttributeUseEvents();
        
        void addAttributeUseEvent(AttributeUseStateEvent.AttributeUseStateCreated e);

        AttributeUseStateEvent.AttributeUseStateCreated newAttributeUseStateCreated(String attributeId);

    
    }


    interface AttributeSetStateMergePatched extends AttributeSetStateEvent
    {
        Boolean getIsPropertyAttributeSetNameRemoved();

        void setIsPropertyAttributeSetNameRemoved(Boolean removed);

        Boolean getIsPropertyOrganizationIdRemoved();

        void setIsPropertyOrganizationIdRemoved(Boolean removed);

        Boolean getIsPropertyDescriptionRemoved();

        void setIsPropertyDescriptionRemoved(Boolean removed);

        Boolean getIsPropertySerialNumberAttributeIdRemoved();

        void setIsPropertySerialNumberAttributeIdRemoved(Boolean removed);

        Boolean getIsPropertyLotAttributeIdRemoved();

        void setIsPropertyLotAttributeIdRemoved(Boolean removed);

        Boolean getIsPropertyReferenceIdRemoved();

        void setIsPropertyReferenceIdRemoved(Boolean removed);

        Boolean getIsPropertyIsInstanceAttributeSetRemoved();

        void setIsPropertyIsInstanceAttributeSetRemoved(Boolean removed);

        Boolean getIsPropertyIsMandatoryRemoved();

        void setIsPropertyIsMandatoryRemoved(Boolean removed);

        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);

        Iterable<AttributeUseStateEvent> getAttributeUseEvents();
        
        void addAttributeUseEvent(AttributeUseStateEvent e);

        AttributeUseStateEvent.AttributeUseStateCreated newAttributeUseStateCreated(String attributeId);

        AttributeUseStateEvent.AttributeUseStateMergePatched newAttributeUseStateMergePatched(String attributeId);

        AttributeUseStateEvent.AttributeUseStateRemoved newAttributeUseStateRemoved(String attributeId);


    }

    interface AttributeSetStateDeleted extends AttributeSetStateEvent
    {
        Iterable<AttributeUseStateEvent.AttributeUseStateRemoved> getAttributeUseEvents();
        
        void addAttributeUseEvent(AttributeUseStateEvent.AttributeUseStateRemoved e);
        
        AttributeUseStateEvent.AttributeUseStateRemoved newAttributeUseStateRemoved(String attributeId);

    }


}

