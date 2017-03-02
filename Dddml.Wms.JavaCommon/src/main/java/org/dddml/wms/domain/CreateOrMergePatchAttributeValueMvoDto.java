package org.dddml.wms.domain;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchAttributeValueMvoDto extends AbstractAttributeValueMvoCommandDto
{
    private String name;

    public String getName()
    {
        return this.name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    private String description;

    public String getDescription()
    {
        return this.description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    private String referenceId;

    public String getReferenceId()
    {
        return this.referenceId;
    }

    public void setReferenceId(String referenceId)
    {
        this.referenceId = referenceId;
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

    private String attributeName;

    public String getAttributeName()
    {
        return this.attributeName;
    }

    public void setAttributeName(String attributeName)
    {
        this.attributeName = attributeName;
    }

    private String attributeOrganizationId;

    public String getAttributeOrganizationId()
    {
        return this.attributeOrganizationId;
    }

    public void setAttributeOrganizationId(String attributeOrganizationId)
    {
        this.attributeOrganizationId = attributeOrganizationId;
    }

    private String attributeDescription;

    public String getAttributeDescription()
    {
        return this.attributeDescription;
    }

    public void setAttributeDescription(String attributeDescription)
    {
        this.attributeDescription = attributeDescription;
    }

    private Boolean attributeIsMandatory;

    public Boolean getAttributeIsMandatory()
    {
        return this.attributeIsMandatory;
    }

    public void setAttributeIsMandatory(Boolean attributeIsMandatory)
    {
        this.attributeIsMandatory = attributeIsMandatory;
    }

    private Boolean attributeIsInstanceAttribute;

    public Boolean getAttributeIsInstanceAttribute()
    {
        return this.attributeIsInstanceAttribute;
    }

    public void setAttributeIsInstanceAttribute(Boolean attributeIsInstanceAttribute)
    {
        this.attributeIsInstanceAttribute = attributeIsInstanceAttribute;
    }

    private String attributeAttributeValueType;

    public String getAttributeAttributeValueType()
    {
        return this.attributeAttributeValueType;
    }

    public void setAttributeAttributeValueType(String attributeAttributeValueType)
    {
        this.attributeAttributeValueType = attributeAttributeValueType;
    }

    private Integer attributeAttributeValueLength;

    public Integer getAttributeAttributeValueLength()
    {
        return this.attributeAttributeValueLength;
    }

    public void setAttributeAttributeValueLength(Integer attributeAttributeValueLength)
    {
        this.attributeAttributeValueLength = attributeAttributeValueLength;
    }

    private Boolean attributeIsList;

    public Boolean getAttributeIsList()
    {
        return this.attributeIsList;
    }

    public void setAttributeIsList(Boolean attributeIsList)
    {
        this.attributeIsList = attributeIsList;
    }

    private String attributeFieldName;

    public String getAttributeFieldName()
    {
        return this.attributeFieldName;
    }

    public void setAttributeFieldName(String attributeFieldName)
    {
        this.attributeFieldName = attributeFieldName;
    }

    private String attributeReferenceId;

    public String getAttributeReferenceId()
    {
        return this.attributeReferenceId;
    }

    public void setAttributeReferenceId(String attributeReferenceId)
    {
        this.attributeReferenceId = attributeReferenceId;
    }

    private String attributeCreatedBy;

    public String getAttributeCreatedBy()
    {
        return this.attributeCreatedBy;
    }

    public void setAttributeCreatedBy(String attributeCreatedBy)
    {
        this.attributeCreatedBy = attributeCreatedBy;
    }

    private Date attributeCreatedAt;

    public Date getAttributeCreatedAt()
    {
        return this.attributeCreatedAt;
    }

    public void setAttributeCreatedAt(Date attributeCreatedAt)
    {
        this.attributeCreatedAt = attributeCreatedAt;
    }

    private String attributeUpdatedBy;

    public String getAttributeUpdatedBy()
    {
        return this.attributeUpdatedBy;
    }

    public void setAttributeUpdatedBy(String attributeUpdatedBy)
    {
        this.attributeUpdatedBy = attributeUpdatedBy;
    }

    private Date attributeUpdatedAt;

    public Date getAttributeUpdatedAt()
    {
        return this.attributeUpdatedAt;
    }

    public void setAttributeUpdatedAt(Date attributeUpdatedAt)
    {
        this.attributeUpdatedAt = attributeUpdatedAt;
    }

    private Boolean attributeActive;

    public Boolean getAttributeActive()
    {
        return this.attributeActive;
    }

    public void setAttributeActive(Boolean attributeActive)
    {
        this.attributeActive = attributeActive;
    }

    private Boolean attributeDeleted;

    public Boolean getAttributeDeleted()
    {
        return this.attributeDeleted;
    }

    public void setAttributeDeleted(Boolean attributeDeleted)
    {
        this.attributeDeleted = attributeDeleted;
    }

    private Boolean isPropertyNameRemoved;

    public Boolean getIsPropertyNameRemoved()
    {
        return this.isPropertyNameRemoved;
    }

    public void setIsPropertyNameRemoved(Boolean removed)
    {
        this.isPropertyNameRemoved = removed;
    }

    private Boolean isPropertyDescriptionRemoved;

    public Boolean getIsPropertyDescriptionRemoved()
    {
        return this.isPropertyDescriptionRemoved;
    }

    public void setIsPropertyDescriptionRemoved(Boolean removed)
    {
        this.isPropertyDescriptionRemoved = removed;
    }

    private Boolean isPropertyReferenceIdRemoved;

    public Boolean getIsPropertyReferenceIdRemoved()
    {
        return this.isPropertyReferenceIdRemoved;
    }

    public void setIsPropertyReferenceIdRemoved(Boolean removed)
    {
        this.isPropertyReferenceIdRemoved = removed;
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

    private Boolean isPropertyAttributeNameRemoved;

    public Boolean getIsPropertyAttributeNameRemoved()
    {
        return this.isPropertyAttributeNameRemoved;
    }

    public void setIsPropertyAttributeNameRemoved(Boolean removed)
    {
        this.isPropertyAttributeNameRemoved = removed;
    }

    private Boolean isPropertyAttributeOrganizationIdRemoved;

    public Boolean getIsPropertyAttributeOrganizationIdRemoved()
    {
        return this.isPropertyAttributeOrganizationIdRemoved;
    }

    public void setIsPropertyAttributeOrganizationIdRemoved(Boolean removed)
    {
        this.isPropertyAttributeOrganizationIdRemoved = removed;
    }

    private Boolean isPropertyAttributeDescriptionRemoved;

    public Boolean getIsPropertyAttributeDescriptionRemoved()
    {
        return this.isPropertyAttributeDescriptionRemoved;
    }

    public void setIsPropertyAttributeDescriptionRemoved(Boolean removed)
    {
        this.isPropertyAttributeDescriptionRemoved = removed;
    }

    private Boolean isPropertyAttributeIsMandatoryRemoved;

    public Boolean getIsPropertyAttributeIsMandatoryRemoved()
    {
        return this.isPropertyAttributeIsMandatoryRemoved;
    }

    public void setIsPropertyAttributeIsMandatoryRemoved(Boolean removed)
    {
        this.isPropertyAttributeIsMandatoryRemoved = removed;
    }

    private Boolean isPropertyAttributeIsInstanceAttributeRemoved;

    public Boolean getIsPropertyAttributeIsInstanceAttributeRemoved()
    {
        return this.isPropertyAttributeIsInstanceAttributeRemoved;
    }

    public void setIsPropertyAttributeIsInstanceAttributeRemoved(Boolean removed)
    {
        this.isPropertyAttributeIsInstanceAttributeRemoved = removed;
    }

    private Boolean isPropertyAttributeAttributeValueTypeRemoved;

    public Boolean getIsPropertyAttributeAttributeValueTypeRemoved()
    {
        return this.isPropertyAttributeAttributeValueTypeRemoved;
    }

    public void setIsPropertyAttributeAttributeValueTypeRemoved(Boolean removed)
    {
        this.isPropertyAttributeAttributeValueTypeRemoved = removed;
    }

    private Boolean isPropertyAttributeAttributeValueLengthRemoved;

    public Boolean getIsPropertyAttributeAttributeValueLengthRemoved()
    {
        return this.isPropertyAttributeAttributeValueLengthRemoved;
    }

    public void setIsPropertyAttributeAttributeValueLengthRemoved(Boolean removed)
    {
        this.isPropertyAttributeAttributeValueLengthRemoved = removed;
    }

    private Boolean isPropertyAttributeIsListRemoved;

    public Boolean getIsPropertyAttributeIsListRemoved()
    {
        return this.isPropertyAttributeIsListRemoved;
    }

    public void setIsPropertyAttributeIsListRemoved(Boolean removed)
    {
        this.isPropertyAttributeIsListRemoved = removed;
    }

    private Boolean isPropertyAttributeFieldNameRemoved;

    public Boolean getIsPropertyAttributeFieldNameRemoved()
    {
        return this.isPropertyAttributeFieldNameRemoved;
    }

    public void setIsPropertyAttributeFieldNameRemoved(Boolean removed)
    {
        this.isPropertyAttributeFieldNameRemoved = removed;
    }

    private Boolean isPropertyAttributeReferenceIdRemoved;

    public Boolean getIsPropertyAttributeReferenceIdRemoved()
    {
        return this.isPropertyAttributeReferenceIdRemoved;
    }

    public void setIsPropertyAttributeReferenceIdRemoved(Boolean removed)
    {
        this.isPropertyAttributeReferenceIdRemoved = removed;
    }

    private Boolean isPropertyAttributeCreatedByRemoved;

    public Boolean getIsPropertyAttributeCreatedByRemoved()
    {
        return this.isPropertyAttributeCreatedByRemoved;
    }

    public void setIsPropertyAttributeCreatedByRemoved(Boolean removed)
    {
        this.isPropertyAttributeCreatedByRemoved = removed;
    }

    private Boolean isPropertyAttributeCreatedAtRemoved;

    public Boolean getIsPropertyAttributeCreatedAtRemoved()
    {
        return this.isPropertyAttributeCreatedAtRemoved;
    }

    public void setIsPropertyAttributeCreatedAtRemoved(Boolean removed)
    {
        this.isPropertyAttributeCreatedAtRemoved = removed;
    }

    private Boolean isPropertyAttributeUpdatedByRemoved;

    public Boolean getIsPropertyAttributeUpdatedByRemoved()
    {
        return this.isPropertyAttributeUpdatedByRemoved;
    }

    public void setIsPropertyAttributeUpdatedByRemoved(Boolean removed)
    {
        this.isPropertyAttributeUpdatedByRemoved = removed;
    }

    private Boolean isPropertyAttributeUpdatedAtRemoved;

    public Boolean getIsPropertyAttributeUpdatedAtRemoved()
    {
        return this.isPropertyAttributeUpdatedAtRemoved;
    }

    public void setIsPropertyAttributeUpdatedAtRemoved(Boolean removed)
    {
        this.isPropertyAttributeUpdatedAtRemoved = removed;
    }

    private Boolean isPropertyAttributeActiveRemoved;

    public Boolean getIsPropertyAttributeActiveRemoved()
    {
        return this.isPropertyAttributeActiveRemoved;
    }

    public void setIsPropertyAttributeActiveRemoved(Boolean removed)
    {
        this.isPropertyAttributeActiveRemoved = removed;
    }

    private Boolean isPropertyAttributeDeletedRemoved;

    public Boolean getIsPropertyAttributeDeletedRemoved()
    {
        return this.isPropertyAttributeDeletedRemoved;
    }

    public void setIsPropertyAttributeDeletedRemoved(Boolean removed)
    {
        this.isPropertyAttributeDeletedRemoved = removed;
    }

    public void copyTo(AbstractAttributeValueMvoCommand.AbstractCreateOrMergePatchAttributeValueMvo command)
    {
        ((AbstractAttributeValueMvoCommandDto) this).copyTo(command);
        command.setName(this.getName());
        command.setDescription(this.getDescription());
        command.setReferenceId(this.getReferenceId());
        command.setVersion(this.getVersion());
        command.setActive(this.getActive());
        command.setAttributeName(this.getAttributeName());
        command.setAttributeOrganizationId(this.getAttributeOrganizationId());
        command.setAttributeDescription(this.getAttributeDescription());
        command.setAttributeIsMandatory(this.getAttributeIsMandatory());
        command.setAttributeIsInstanceAttribute(this.getAttributeIsInstanceAttribute());
        command.setAttributeAttributeValueType(this.getAttributeAttributeValueType());
        command.setAttributeAttributeValueLength(this.getAttributeAttributeValueLength());
        command.setAttributeIsList(this.getAttributeIsList());
        command.setAttributeFieldName(this.getAttributeFieldName());
        command.setAttributeReferenceId(this.getAttributeReferenceId());
        command.setAttributeCreatedBy(this.getAttributeCreatedBy());
        command.setAttributeCreatedAt(this.getAttributeCreatedAt());
        command.setAttributeUpdatedBy(this.getAttributeUpdatedBy());
        command.setAttributeUpdatedAt(this.getAttributeUpdatedAt());
        command.setAttributeActive(this.getAttributeActive());
        command.setAttributeDeleted(this.getAttributeDeleted());
    }

    public AttributeValueMvoCommand toCommand()
    {
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractAttributeValueMvoCommand.SimpleCreateAttributeValueMvo command = new AbstractAttributeValueMvoCommand.SimpleCreateAttributeValueMvo();
            copyTo((AbstractAttributeValueMvoCommand.AbstractCreateAttributeValueMvo) command);
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractAttributeValueMvoCommand.SimpleMergePatchAttributeValueMvo command = new AbstractAttributeValueMvoCommand.SimpleMergePatchAttributeValueMvo();
            copyTo((AbstractAttributeValueMvoCommand.SimpleMergePatchAttributeValueMvo) command);
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractAttributeValueMvoCommand.AbstractCreateAttributeValueMvo command)
    {
        copyTo((AbstractAttributeValueMvoCommand.AbstractCreateOrMergePatchAttributeValueMvo) command);
    }

    public void copyTo(AbstractAttributeValueMvoCommand.AbstractMergePatchAttributeValueMvo command)
    {
        copyTo((AbstractAttributeValueMvoCommand.AbstractCreateOrMergePatchAttributeValueMvo) command);
        command.setIsPropertyNameRemoved(this.getIsPropertyNameRemoved());
        command.setIsPropertyDescriptionRemoved(this.getIsPropertyDescriptionRemoved());
        command.setIsPropertyReferenceIdRemoved(this.getIsPropertyReferenceIdRemoved());
        command.setIsPropertyVersionRemoved(this.getIsPropertyVersionRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
        command.setIsPropertyAttributeNameRemoved(this.getIsPropertyAttributeNameRemoved());
        command.setIsPropertyAttributeOrganizationIdRemoved(this.getIsPropertyAttributeOrganizationIdRemoved());
        command.setIsPropertyAttributeDescriptionRemoved(this.getIsPropertyAttributeDescriptionRemoved());
        command.setIsPropertyAttributeIsMandatoryRemoved(this.getIsPropertyAttributeIsMandatoryRemoved());
        command.setIsPropertyAttributeIsInstanceAttributeRemoved(this.getIsPropertyAttributeIsInstanceAttributeRemoved());
        command.setIsPropertyAttributeAttributeValueTypeRemoved(this.getIsPropertyAttributeAttributeValueTypeRemoved());
        command.setIsPropertyAttributeAttributeValueLengthRemoved(this.getIsPropertyAttributeAttributeValueLengthRemoved());
        command.setIsPropertyAttributeIsListRemoved(this.getIsPropertyAttributeIsListRemoved());
        command.setIsPropertyAttributeFieldNameRemoved(this.getIsPropertyAttributeFieldNameRemoved());
        command.setIsPropertyAttributeReferenceIdRemoved(this.getIsPropertyAttributeReferenceIdRemoved());
        command.setIsPropertyAttributeCreatedByRemoved(this.getIsPropertyAttributeCreatedByRemoved());
        command.setIsPropertyAttributeCreatedAtRemoved(this.getIsPropertyAttributeCreatedAtRemoved());
        command.setIsPropertyAttributeUpdatedByRemoved(this.getIsPropertyAttributeUpdatedByRemoved());
        command.setIsPropertyAttributeUpdatedAtRemoved(this.getIsPropertyAttributeUpdatedAtRemoved());
        command.setIsPropertyAttributeActiveRemoved(this.getIsPropertyAttributeActiveRemoved());
        command.setIsPropertyAttributeDeletedRemoved(this.getIsPropertyAttributeDeletedRemoved());
    }

    public static class CreateAttributeValueMvoDto extends CreateOrMergePatchAttributeValueMvoDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public AttributeValueMvoCommand.CreateAttributeValueMvo toCreateAttributeValueMvo()
        {
            return (AttributeValueMvoCommand.CreateAttributeValueMvo) toCommand();
        }

    }

    public static class MergePatchAttributeValueMvoDto extends CreateOrMergePatchAttributeValueMvoDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public AttributeValueMvoCommand.MergePatchAttributeValueMvo toMergePatchAttributeValueMvo()
        {
            return (AttributeValueMvoCommand.MergePatchAttributeValueMvo) toCommand();
        }

    }

}

