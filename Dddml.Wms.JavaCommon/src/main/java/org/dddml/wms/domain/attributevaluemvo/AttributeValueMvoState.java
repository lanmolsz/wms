package org.dddml.wms.domain.attributevaluemvo;

import java.util.Set;
import org.dddml.wms.domain.attribute.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.attributevaluemvo.AttributeValueMvoStateEvent.*;

public interface AttributeValueMvoState
{
    Long VERSION_ZERO = 0L;

    Long VERSION_NULL = VERSION_ZERO - 1;

    AttributeValueId getAttributeValueId();

    void setAttributeValueId(AttributeValueId attributeValueId);

    String getAttributeValueName();

    void setAttributeValueName(String attributeValueName);

    String getDescription();

    void setDescription(String description);

    String getReferenceId();

    void setReferenceId(String referenceId);

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

    String getAttributeAttributeName();

    void setAttributeAttributeName(String attributeAttributeName);

    String getAttributeOrganizationId();

    void setAttributeOrganizationId(String attributeOrganizationId);

    String getAttributeDescription();

    void setAttributeDescription(String attributeDescription);

    Boolean getAttributeIsMandatory();

    void setAttributeIsMandatory(Boolean attributeIsMandatory);

    String getAttributeAttributeValueType();

    void setAttributeAttributeValueType(String attributeAttributeValueType);

    Integer getAttributeAttributeValueLength();

    void setAttributeAttributeValueLength(Integer attributeAttributeValueLength);

    Boolean getAttributeIsList();

    void setAttributeIsList(Boolean attributeIsList);

    String getAttributeFieldName();

    void setAttributeFieldName(String attributeFieldName);

    String getAttributeReferenceId();

    void setAttributeReferenceId(String attributeReferenceId);

    Long getAttributeVersion();

    void setAttributeVersion(Long attributeVersion);

    String getAttributeCreatedBy();

    void setAttributeCreatedBy(String attributeCreatedBy);

    Date getAttributeCreatedAt();

    void setAttributeCreatedAt(Date attributeCreatedAt);

    String getAttributeUpdatedBy();

    void setAttributeUpdatedBy(String attributeUpdatedBy);

    Date getAttributeUpdatedAt();

    void setAttributeUpdatedAt(Date attributeUpdatedAt);

    Boolean getAttributeActive();

    void setAttributeActive(Boolean attributeActive);

    Boolean getAttributeDeleted();

    void setAttributeDeleted(Boolean attributeDeleted);


    boolean isStateUnsaved();

    boolean getForReapplying();


    void mutate(Event e);

    void when(AttributeValueMvoStateEvent.AttributeValueMvoStateCreated e);

    void when(AttributeValueMvoStateEvent.AttributeValueMvoStateMergePatched e);

    void when(AttributeValueMvoStateEvent.AttributeValueMvoStateDeleted e);
    
}

