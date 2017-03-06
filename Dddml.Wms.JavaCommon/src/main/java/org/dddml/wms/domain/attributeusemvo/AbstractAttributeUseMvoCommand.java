package org.dddml.wms.domain.attributeusemvo;

import java.util.*;
import org.dddml.wms.domain.attributeset.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractAttributeUseMvoCommand extends AbstractCommand implements AttributeUseMvoCommand
{
    private AttributeSetAttributeUseId attributeSetAttributeUseId;

    public AttributeSetAttributeUseId getAttributeSetAttributeUseId()
    {
        return this.attributeSetAttributeUseId;
    }

    public void setAttributeSetAttributeUseId(AttributeSetAttributeUseId attributeSetAttributeUseId)
    {
        this.attributeSetAttributeUseId = attributeSetAttributeUseId;
    }

    private Long attributeSetVersion;

    public Long getAttributeSetVersion()
    {
        return this.attributeSetVersion;
    }

    public void setAttributeSetVersion(Long attributeSetVersion)
    {
        this.attributeSetVersion = attributeSetVersion;
    }


    public static abstract class AbstractCreateOrMergePatchAttributeUseMvo extends AbstractAttributeUseMvoCommand implements CreateOrMergePatchAttributeUseMvo
    {
        private Integer sequenceNumber;

        public Integer getSequenceNumber()
        {
            return this.sequenceNumber;
        }

        public void setSequenceNumber(Integer sequenceNumber)
        {
            this.sequenceNumber = sequenceNumber;
        }

        private Long version;

        public Long getVersion()
        {
            return this.version;
        }

        public void setVersion(Long version)
        {
            this.version = version;
        }

        private Boolean active;

        public Boolean getActive()
        {
            return this.active;
        }

        public void setActive(Boolean active)
        {
            this.active = active;
        }

        private String attributeSetName;

        public String getAttributeSetName()
        {
            return this.attributeSetName;
        }

        public void setAttributeSetName(String attributeSetName)
        {
            this.attributeSetName = attributeSetName;
        }

        private String attributeSetOrganizationId;

        public String getAttributeSetOrganizationId()
        {
            return this.attributeSetOrganizationId;
        }

        public void setAttributeSetOrganizationId(String attributeSetOrganizationId)
        {
            this.attributeSetOrganizationId = attributeSetOrganizationId;
        }

        private String attributeSetDescription;

        public String getAttributeSetDescription()
        {
            return this.attributeSetDescription;
        }

        public void setAttributeSetDescription(String attributeSetDescription)
        {
            this.attributeSetDescription = attributeSetDescription;
        }

        private String attributeSetSerialNumberAttributeId;

        public String getAttributeSetSerialNumberAttributeId()
        {
            return this.attributeSetSerialNumberAttributeId;
        }

        public void setAttributeSetSerialNumberAttributeId(String attributeSetSerialNumberAttributeId)
        {
            this.attributeSetSerialNumberAttributeId = attributeSetSerialNumberAttributeId;
        }

        private String attributeSetLotAttributeId;

        public String getAttributeSetLotAttributeId()
        {
            return this.attributeSetLotAttributeId;
        }

        public void setAttributeSetLotAttributeId(String attributeSetLotAttributeId)
        {
            this.attributeSetLotAttributeId = attributeSetLotAttributeId;
        }

        private String attributeSetReferenceId;

        public String getAttributeSetReferenceId()
        {
            return this.attributeSetReferenceId;
        }

        public void setAttributeSetReferenceId(String attributeSetReferenceId)
        {
            this.attributeSetReferenceId = attributeSetReferenceId;
        }

        private String attributeSetCreatedBy;

        public String getAttributeSetCreatedBy()
        {
            return this.attributeSetCreatedBy;
        }

        public void setAttributeSetCreatedBy(String attributeSetCreatedBy)
        {
            this.attributeSetCreatedBy = attributeSetCreatedBy;
        }

        private Date attributeSetCreatedAt;

        public Date getAttributeSetCreatedAt()
        {
            return this.attributeSetCreatedAt;
        }

        public void setAttributeSetCreatedAt(Date attributeSetCreatedAt)
        {
            this.attributeSetCreatedAt = attributeSetCreatedAt;
        }

        private String attributeSetUpdatedBy;

        public String getAttributeSetUpdatedBy()
        {
            return this.attributeSetUpdatedBy;
        }

        public void setAttributeSetUpdatedBy(String attributeSetUpdatedBy)
        {
            this.attributeSetUpdatedBy = attributeSetUpdatedBy;
        }

        private Date attributeSetUpdatedAt;

        public Date getAttributeSetUpdatedAt()
        {
            return this.attributeSetUpdatedAt;
        }

        public void setAttributeSetUpdatedAt(Date attributeSetUpdatedAt)
        {
            this.attributeSetUpdatedAt = attributeSetUpdatedAt;
        }

        private Boolean attributeSetActive;

        public Boolean getAttributeSetActive()
        {
            return this.attributeSetActive;
        }

        public void setAttributeSetActive(Boolean attributeSetActive)
        {
            this.attributeSetActive = attributeSetActive;
        }

        private Boolean attributeSetDeleted;

        public Boolean getAttributeSetDeleted()
        {
            return this.attributeSetDeleted;
        }

        public void setAttributeSetDeleted(Boolean attributeSetDeleted)
        {
            this.attributeSetDeleted = attributeSetDeleted;
        }

    }

    public static abstract class AbstractCreateAttributeUseMvo extends AbstractCreateOrMergePatchAttributeUseMvo implements CreateAttributeUseMvo
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }

    }

    public static abstract class AbstractMergePatchAttributeUseMvo extends AbstractCreateOrMergePatchAttributeUseMvo implements MergePatchAttributeUseMvo
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }

        private Boolean isPropertySequenceNumberRemoved;

        public Boolean getIsPropertySequenceNumberRemoved()
        {
            return this.isPropertySequenceNumberRemoved;
        }

        public void setIsPropertySequenceNumberRemoved(Boolean removed)
        {
            this.isPropertySequenceNumberRemoved = removed;
        }

        private Boolean isPropertyVersionRemoved;

        public Boolean getIsPropertyVersionRemoved()
        {
            return this.isPropertyVersionRemoved;
        }

        public void setIsPropertyVersionRemoved(Boolean removed)
        {
            this.isPropertyVersionRemoved = removed;
        }

        private Boolean isPropertyActiveRemoved;

        public Boolean getIsPropertyActiveRemoved()
        {
            return this.isPropertyActiveRemoved;
        }

        public void setIsPropertyActiveRemoved(Boolean removed)
        {
            this.isPropertyActiveRemoved = removed;
        }

        private Boolean isPropertyAttributeSetNameRemoved;

        public Boolean getIsPropertyAttributeSetNameRemoved()
        {
            return this.isPropertyAttributeSetNameRemoved;
        }

        public void setIsPropertyAttributeSetNameRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetNameRemoved = removed;
        }

        private Boolean isPropertyAttributeSetOrganizationIdRemoved;

        public Boolean getIsPropertyAttributeSetOrganizationIdRemoved()
        {
            return this.isPropertyAttributeSetOrganizationIdRemoved;
        }

        public void setIsPropertyAttributeSetOrganizationIdRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetOrganizationIdRemoved = removed;
        }

        private Boolean isPropertyAttributeSetDescriptionRemoved;

        public Boolean getIsPropertyAttributeSetDescriptionRemoved()
        {
            return this.isPropertyAttributeSetDescriptionRemoved;
        }

        public void setIsPropertyAttributeSetDescriptionRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetDescriptionRemoved = removed;
        }

        private Boolean isPropertyAttributeSetSerialNumberAttributeIdRemoved;

        public Boolean getIsPropertyAttributeSetSerialNumberAttributeIdRemoved()
        {
            return this.isPropertyAttributeSetSerialNumberAttributeIdRemoved;
        }

        public void setIsPropertyAttributeSetSerialNumberAttributeIdRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetSerialNumberAttributeIdRemoved = removed;
        }

        private Boolean isPropertyAttributeSetLotAttributeIdRemoved;

        public Boolean getIsPropertyAttributeSetLotAttributeIdRemoved()
        {
            return this.isPropertyAttributeSetLotAttributeIdRemoved;
        }

        public void setIsPropertyAttributeSetLotAttributeIdRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetLotAttributeIdRemoved = removed;
        }

        private Boolean isPropertyAttributeSetReferenceIdRemoved;

        public Boolean getIsPropertyAttributeSetReferenceIdRemoved()
        {
            return this.isPropertyAttributeSetReferenceIdRemoved;
        }

        public void setIsPropertyAttributeSetReferenceIdRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetReferenceIdRemoved = removed;
        }

        private Boolean isPropertyAttributeSetCreatedByRemoved;

        public Boolean getIsPropertyAttributeSetCreatedByRemoved()
        {
            return this.isPropertyAttributeSetCreatedByRemoved;
        }

        public void setIsPropertyAttributeSetCreatedByRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetCreatedByRemoved = removed;
        }

        private Boolean isPropertyAttributeSetCreatedAtRemoved;

        public Boolean getIsPropertyAttributeSetCreatedAtRemoved()
        {
            return this.isPropertyAttributeSetCreatedAtRemoved;
        }

        public void setIsPropertyAttributeSetCreatedAtRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetCreatedAtRemoved = removed;
        }

        private Boolean isPropertyAttributeSetUpdatedByRemoved;

        public Boolean getIsPropertyAttributeSetUpdatedByRemoved()
        {
            return this.isPropertyAttributeSetUpdatedByRemoved;
        }

        public void setIsPropertyAttributeSetUpdatedByRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetUpdatedByRemoved = removed;
        }

        private Boolean isPropertyAttributeSetUpdatedAtRemoved;

        public Boolean getIsPropertyAttributeSetUpdatedAtRemoved()
        {
            return this.isPropertyAttributeSetUpdatedAtRemoved;
        }

        public void setIsPropertyAttributeSetUpdatedAtRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetUpdatedAtRemoved = removed;
        }

        private Boolean isPropertyAttributeSetActiveRemoved;

        public Boolean getIsPropertyAttributeSetActiveRemoved()
        {
            return this.isPropertyAttributeSetActiveRemoved;
        }

        public void setIsPropertyAttributeSetActiveRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetActiveRemoved = removed;
        }

        private Boolean isPropertyAttributeSetDeletedRemoved;

        public Boolean getIsPropertyAttributeSetDeletedRemoved()
        {
            return this.isPropertyAttributeSetDeletedRemoved;
        }

        public void setIsPropertyAttributeSetDeletedRemoved(Boolean removed)
        {
            this.isPropertyAttributeSetDeletedRemoved = removed;
        }

    }

    public static class SimpleCreateAttributeUseMvo extends AbstractCreateAttributeUseMvo
    {
    }

    public static class SimpleMergePatchAttributeUseMvo extends AbstractMergePatchAttributeUseMvo
    {
    }

	public static class SimpleDeleteAttributeUseMvo extends AbstractAttributeUseMvoCommand implements DeleteAttributeUseMvo
	{
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_DELETE;
        }
	}


}

