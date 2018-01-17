package org.dddml.wms.domain.documenttype;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractStateEvent;

public class DocumentTypeStateEventDto extends AbstractStateEvent
{

    private DocumentTypeStateEventIdDto stateEventId;

    DocumentTypeStateEventIdDto getStateEventId() {
        if (stateEventId == null) { stateEventId = new DocumentTypeStateEventIdDto(); }
        return this.stateEventId;
    }

    void setStateEventId(DocumentTypeStateEventIdDto stateEventId) {
        this.stateEventId = stateEventId;
    }

    public String getDocumentTypeId() {
        return getStateEventId().getDocumentTypeId();
    }

    public void setDocumentTypeId(String documentTypeId) {
        getStateEventId().setDocumentTypeId(documentTypeId);
    }

    public Long getVersion() {
        return getStateEventId().getVersion();
    }
    
    public void getVersion(Long version) {
        getStateEventId().setVersion(version);
    }

    private String description;

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    private String parentDocumentTypeId;

    public String getParentDocumentTypeId() {
        return this.parentDocumentTypeId;
    }

    public void setParentDocumentTypeId(String parentDocumentTypeId) {
        this.parentDocumentTypeId = parentDocumentTypeId;
    }

    private Boolean active;

    public Boolean getActive() {
        return this.active;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }

    private String createdBy;

    public String getCreatedBy() {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy) {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt() {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt) {
        this.createdAt = createdAt;
    }

    private Boolean isPropertyDescriptionRemoved;

    public Boolean getIsPropertyDescriptionRemoved() {
        return this.isPropertyDescriptionRemoved;
    }

    public void setIsPropertyDescriptionRemoved(Boolean removed) {
        this.isPropertyDescriptionRemoved = removed;
    }

    private Boolean isPropertyParentDocumentTypeIdRemoved;

    public Boolean getIsPropertyParentDocumentTypeIdRemoved() {
        return this.isPropertyParentDocumentTypeIdRemoved;
    }

    public void setIsPropertyParentDocumentTypeIdRemoved(Boolean removed) {
        this.isPropertyParentDocumentTypeIdRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved() {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed) {
        this.isPropertyActiveRemoved = removed;
    }


	public static class DocumentTypeStateCreatedDto extends DocumentTypeStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class DocumentTypeStateMergePatchedDto extends DocumentTypeStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class DocumentTypeStateDeletedDto extends DocumentTypeStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_DELETED;
        }

	}


}
