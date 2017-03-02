package org.dddml.wms.domain;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchAttributeSetInstanceExtensionFieldMvoDto extends AbstractAttributeSetInstanceExtensionFieldMvoCommandDto
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

    private String type;

    public String getType()
    {
        return this.type;
    }

    public void setType(String type)
    {
        this.type = type;
    }

    private Integer length;

    public Integer getLength()
    {
        return this.length;
    }

    public void setLength(Integer length)
    {
        this.length = length;
    }

    private String alias;

    public String getAlias()
    {
        return this.alias;
    }

    public void setAlias(String alias)
    {
        this.alias = alias;
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

    private String attrSetInstEFGroupFieldType;

    public String getAttrSetInstEFGroupFieldType()
    {
        return this.attrSetInstEFGroupFieldType;
    }

    public void setAttrSetInstEFGroupFieldType(String attrSetInstEFGroupFieldType)
    {
        this.attrSetInstEFGroupFieldType = attrSetInstEFGroupFieldType;
    }

    private Integer attrSetInstEFGroupFieldLength;

    public Integer getAttrSetInstEFGroupFieldLength()
    {
        return this.attrSetInstEFGroupFieldLength;
    }

    public void setAttrSetInstEFGroupFieldLength(Integer attrSetInstEFGroupFieldLength)
    {
        this.attrSetInstEFGroupFieldLength = attrSetInstEFGroupFieldLength;
    }

    private Integer attrSetInstEFGroupFieldCount;

    public Integer getAttrSetInstEFGroupFieldCount()
    {
        return this.attrSetInstEFGroupFieldCount;
    }

    public void setAttrSetInstEFGroupFieldCount(Integer attrSetInstEFGroupFieldCount)
    {
        this.attrSetInstEFGroupFieldCount = attrSetInstEFGroupFieldCount;
    }

    private String attrSetInstEFGroupNameFormat;

    public String getAttrSetInstEFGroupNameFormat()
    {
        return this.attrSetInstEFGroupNameFormat;
    }

    public void setAttrSetInstEFGroupNameFormat(String attrSetInstEFGroupNameFormat)
    {
        this.attrSetInstEFGroupNameFormat = attrSetInstEFGroupNameFormat;
    }

    private String attrSetInstEFGroupDescription;

    public String getAttrSetInstEFGroupDescription()
    {
        return this.attrSetInstEFGroupDescription;
    }

    public void setAttrSetInstEFGroupDescription(String attrSetInstEFGroupDescription)
    {
        this.attrSetInstEFGroupDescription = attrSetInstEFGroupDescription;
    }

    private String attrSetInstEFGroupCreatedBy;

    public String getAttrSetInstEFGroupCreatedBy()
    {
        return this.attrSetInstEFGroupCreatedBy;
    }

    public void setAttrSetInstEFGroupCreatedBy(String attrSetInstEFGroupCreatedBy)
    {
        this.attrSetInstEFGroupCreatedBy = attrSetInstEFGroupCreatedBy;
    }

    private Date attrSetInstEFGroupCreatedAt;

    public Date getAttrSetInstEFGroupCreatedAt()
    {
        return this.attrSetInstEFGroupCreatedAt;
    }

    public void setAttrSetInstEFGroupCreatedAt(Date attrSetInstEFGroupCreatedAt)
    {
        this.attrSetInstEFGroupCreatedAt = attrSetInstEFGroupCreatedAt;
    }

    private String attrSetInstEFGroupUpdatedBy;

    public String getAttrSetInstEFGroupUpdatedBy()
    {
        return this.attrSetInstEFGroupUpdatedBy;
    }

    public void setAttrSetInstEFGroupUpdatedBy(String attrSetInstEFGroupUpdatedBy)
    {
        this.attrSetInstEFGroupUpdatedBy = attrSetInstEFGroupUpdatedBy;
    }

    private Date attrSetInstEFGroupUpdatedAt;

    public Date getAttrSetInstEFGroupUpdatedAt()
    {
        return this.attrSetInstEFGroupUpdatedAt;
    }

    public void setAttrSetInstEFGroupUpdatedAt(Date attrSetInstEFGroupUpdatedAt)
    {
        this.attrSetInstEFGroupUpdatedAt = attrSetInstEFGroupUpdatedAt;
    }

    private Boolean attrSetInstEFGroupActive;

    public Boolean getAttrSetInstEFGroupActive()
    {
        return this.attrSetInstEFGroupActive;
    }

    public void setAttrSetInstEFGroupActive(Boolean attrSetInstEFGroupActive)
    {
        this.attrSetInstEFGroupActive = attrSetInstEFGroupActive;
    }

    private Boolean attrSetInstEFGroupDeleted;

    public Boolean getAttrSetInstEFGroupDeleted()
    {
        return this.attrSetInstEFGroupDeleted;
    }

    public void setAttrSetInstEFGroupDeleted(Boolean attrSetInstEFGroupDeleted)
    {
        this.attrSetInstEFGroupDeleted = attrSetInstEFGroupDeleted;
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

    private Boolean isPropertyTypeRemoved;

    public Boolean getIsPropertyTypeRemoved()
    {
        return this.isPropertyTypeRemoved;
    }

    public void setIsPropertyTypeRemoved(Boolean removed)
    {
        this.isPropertyTypeRemoved = removed;
    }

    private Boolean isPropertyLengthRemoved;

    public Boolean getIsPropertyLengthRemoved()
    {
        return this.isPropertyLengthRemoved;
    }

    public void setIsPropertyLengthRemoved(Boolean removed)
    {
        this.isPropertyLengthRemoved = removed;
    }

    private Boolean isPropertyAliasRemoved;

    public Boolean getIsPropertyAliasRemoved()
    {
        return this.isPropertyAliasRemoved;
    }

    public void setIsPropertyAliasRemoved(Boolean removed)
    {
        this.isPropertyAliasRemoved = removed;
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

    private Boolean isPropertyAttrSetInstEFGroupFieldTypeRemoved;

    public Boolean getIsPropertyAttrSetInstEFGroupFieldTypeRemoved()
    {
        return this.isPropertyAttrSetInstEFGroupFieldTypeRemoved;
    }

    public void setIsPropertyAttrSetInstEFGroupFieldTypeRemoved(Boolean removed)
    {
        this.isPropertyAttrSetInstEFGroupFieldTypeRemoved = removed;
    }

    private Boolean isPropertyAttrSetInstEFGroupFieldLengthRemoved;

    public Boolean getIsPropertyAttrSetInstEFGroupFieldLengthRemoved()
    {
        return this.isPropertyAttrSetInstEFGroupFieldLengthRemoved;
    }

    public void setIsPropertyAttrSetInstEFGroupFieldLengthRemoved(Boolean removed)
    {
        this.isPropertyAttrSetInstEFGroupFieldLengthRemoved = removed;
    }

    private Boolean isPropertyAttrSetInstEFGroupFieldCountRemoved;

    public Boolean getIsPropertyAttrSetInstEFGroupFieldCountRemoved()
    {
        return this.isPropertyAttrSetInstEFGroupFieldCountRemoved;
    }

    public void setIsPropertyAttrSetInstEFGroupFieldCountRemoved(Boolean removed)
    {
        this.isPropertyAttrSetInstEFGroupFieldCountRemoved = removed;
    }

    private Boolean isPropertyAttrSetInstEFGroupNameFormatRemoved;

    public Boolean getIsPropertyAttrSetInstEFGroupNameFormatRemoved()
    {
        return this.isPropertyAttrSetInstEFGroupNameFormatRemoved;
    }

    public void setIsPropertyAttrSetInstEFGroupNameFormatRemoved(Boolean removed)
    {
        this.isPropertyAttrSetInstEFGroupNameFormatRemoved = removed;
    }

    private Boolean isPropertyAttrSetInstEFGroupDescriptionRemoved;

    public Boolean getIsPropertyAttrSetInstEFGroupDescriptionRemoved()
    {
        return this.isPropertyAttrSetInstEFGroupDescriptionRemoved;
    }

    public void setIsPropertyAttrSetInstEFGroupDescriptionRemoved(Boolean removed)
    {
        this.isPropertyAttrSetInstEFGroupDescriptionRemoved = removed;
    }

    private Boolean isPropertyAttrSetInstEFGroupCreatedByRemoved;

    public Boolean getIsPropertyAttrSetInstEFGroupCreatedByRemoved()
    {
        return this.isPropertyAttrSetInstEFGroupCreatedByRemoved;
    }

    public void setIsPropertyAttrSetInstEFGroupCreatedByRemoved(Boolean removed)
    {
        this.isPropertyAttrSetInstEFGroupCreatedByRemoved = removed;
    }

    private Boolean isPropertyAttrSetInstEFGroupCreatedAtRemoved;

    public Boolean getIsPropertyAttrSetInstEFGroupCreatedAtRemoved()
    {
        return this.isPropertyAttrSetInstEFGroupCreatedAtRemoved;
    }

    public void setIsPropertyAttrSetInstEFGroupCreatedAtRemoved(Boolean removed)
    {
        this.isPropertyAttrSetInstEFGroupCreatedAtRemoved = removed;
    }

    private Boolean isPropertyAttrSetInstEFGroupUpdatedByRemoved;

    public Boolean getIsPropertyAttrSetInstEFGroupUpdatedByRemoved()
    {
        return this.isPropertyAttrSetInstEFGroupUpdatedByRemoved;
    }

    public void setIsPropertyAttrSetInstEFGroupUpdatedByRemoved(Boolean removed)
    {
        this.isPropertyAttrSetInstEFGroupUpdatedByRemoved = removed;
    }

    private Boolean isPropertyAttrSetInstEFGroupUpdatedAtRemoved;

    public Boolean getIsPropertyAttrSetInstEFGroupUpdatedAtRemoved()
    {
        return this.isPropertyAttrSetInstEFGroupUpdatedAtRemoved;
    }

    public void setIsPropertyAttrSetInstEFGroupUpdatedAtRemoved(Boolean removed)
    {
        this.isPropertyAttrSetInstEFGroupUpdatedAtRemoved = removed;
    }

    private Boolean isPropertyAttrSetInstEFGroupActiveRemoved;

    public Boolean getIsPropertyAttrSetInstEFGroupActiveRemoved()
    {
        return this.isPropertyAttrSetInstEFGroupActiveRemoved;
    }

    public void setIsPropertyAttrSetInstEFGroupActiveRemoved(Boolean removed)
    {
        this.isPropertyAttrSetInstEFGroupActiveRemoved = removed;
    }

    private Boolean isPropertyAttrSetInstEFGroupDeletedRemoved;

    public Boolean getIsPropertyAttrSetInstEFGroupDeletedRemoved()
    {
        return this.isPropertyAttrSetInstEFGroupDeletedRemoved;
    }

    public void setIsPropertyAttrSetInstEFGroupDeletedRemoved(Boolean removed)
    {
        this.isPropertyAttrSetInstEFGroupDeletedRemoved = removed;
    }

    public void copyTo(AbstractAttributeSetInstanceExtensionFieldMvoCommand.AbstractCreateOrMergePatchAttributeSetInstanceExtensionFieldMvo command)
    {
        ((AbstractAttributeSetInstanceExtensionFieldMvoCommandDto) this).copyTo(command);
        command.setName(this.getName());
        command.setType(this.getType());
        command.setLength(this.getLength());
        command.setAlias(this.getAlias());
        command.setDescription(this.getDescription());
        command.setVersion(this.getVersion());
        command.setActive(this.getActive());
        command.setAttrSetInstEFGroupFieldType(this.getAttrSetInstEFGroupFieldType());
        command.setAttrSetInstEFGroupFieldLength(this.getAttrSetInstEFGroupFieldLength());
        command.setAttrSetInstEFGroupFieldCount(this.getAttrSetInstEFGroupFieldCount());
        command.setAttrSetInstEFGroupNameFormat(this.getAttrSetInstEFGroupNameFormat());
        command.setAttrSetInstEFGroupDescription(this.getAttrSetInstEFGroupDescription());
        command.setAttrSetInstEFGroupCreatedBy(this.getAttrSetInstEFGroupCreatedBy());
        command.setAttrSetInstEFGroupCreatedAt(this.getAttrSetInstEFGroupCreatedAt());
        command.setAttrSetInstEFGroupUpdatedBy(this.getAttrSetInstEFGroupUpdatedBy());
        command.setAttrSetInstEFGroupUpdatedAt(this.getAttrSetInstEFGroupUpdatedAt());
        command.setAttrSetInstEFGroupActive(this.getAttrSetInstEFGroupActive());
        command.setAttrSetInstEFGroupDeleted(this.getAttrSetInstEFGroupDeleted());
    }

    public AttributeSetInstanceExtensionFieldMvoCommand toCommand()
    {
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractAttributeSetInstanceExtensionFieldMvoCommand.SimpleCreateAttributeSetInstanceExtensionFieldMvo command = new AbstractAttributeSetInstanceExtensionFieldMvoCommand.SimpleCreateAttributeSetInstanceExtensionFieldMvo();
            copyTo((AbstractAttributeSetInstanceExtensionFieldMvoCommand.AbstractCreateAttributeSetInstanceExtensionFieldMvo) command);
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractAttributeSetInstanceExtensionFieldMvoCommand.SimpleMergePatchAttributeSetInstanceExtensionFieldMvo command = new AbstractAttributeSetInstanceExtensionFieldMvoCommand.SimpleMergePatchAttributeSetInstanceExtensionFieldMvo();
            copyTo((AbstractAttributeSetInstanceExtensionFieldMvoCommand.SimpleMergePatchAttributeSetInstanceExtensionFieldMvo) command);
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractAttributeSetInstanceExtensionFieldMvoCommand.AbstractCreateAttributeSetInstanceExtensionFieldMvo command)
    {
        copyTo((AbstractAttributeSetInstanceExtensionFieldMvoCommand.AbstractCreateOrMergePatchAttributeSetInstanceExtensionFieldMvo) command);
    }

    public void copyTo(AbstractAttributeSetInstanceExtensionFieldMvoCommand.AbstractMergePatchAttributeSetInstanceExtensionFieldMvo command)
    {
        copyTo((AbstractAttributeSetInstanceExtensionFieldMvoCommand.AbstractCreateOrMergePatchAttributeSetInstanceExtensionFieldMvo) command);
        command.setIsPropertyNameRemoved(this.getIsPropertyNameRemoved());
        command.setIsPropertyTypeRemoved(this.getIsPropertyTypeRemoved());
        command.setIsPropertyLengthRemoved(this.getIsPropertyLengthRemoved());
        command.setIsPropertyAliasRemoved(this.getIsPropertyAliasRemoved());
        command.setIsPropertyDescriptionRemoved(this.getIsPropertyDescriptionRemoved());
        command.setIsPropertyVersionRemoved(this.getIsPropertyVersionRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
        command.setIsPropertyAttrSetInstEFGroupFieldTypeRemoved(this.getIsPropertyAttrSetInstEFGroupFieldTypeRemoved());
        command.setIsPropertyAttrSetInstEFGroupFieldLengthRemoved(this.getIsPropertyAttrSetInstEFGroupFieldLengthRemoved());
        command.setIsPropertyAttrSetInstEFGroupFieldCountRemoved(this.getIsPropertyAttrSetInstEFGroupFieldCountRemoved());
        command.setIsPropertyAttrSetInstEFGroupNameFormatRemoved(this.getIsPropertyAttrSetInstEFGroupNameFormatRemoved());
        command.setIsPropertyAttrSetInstEFGroupDescriptionRemoved(this.getIsPropertyAttrSetInstEFGroupDescriptionRemoved());
        command.setIsPropertyAttrSetInstEFGroupCreatedByRemoved(this.getIsPropertyAttrSetInstEFGroupCreatedByRemoved());
        command.setIsPropertyAttrSetInstEFGroupCreatedAtRemoved(this.getIsPropertyAttrSetInstEFGroupCreatedAtRemoved());
        command.setIsPropertyAttrSetInstEFGroupUpdatedByRemoved(this.getIsPropertyAttrSetInstEFGroupUpdatedByRemoved());
        command.setIsPropertyAttrSetInstEFGroupUpdatedAtRemoved(this.getIsPropertyAttrSetInstEFGroupUpdatedAtRemoved());
        command.setIsPropertyAttrSetInstEFGroupActiveRemoved(this.getIsPropertyAttrSetInstEFGroupActiveRemoved());
        command.setIsPropertyAttrSetInstEFGroupDeletedRemoved(this.getIsPropertyAttrSetInstEFGroupDeletedRemoved());
    }

    public static class CreateAttributeSetInstanceExtensionFieldMvoDto extends CreateOrMergePatchAttributeSetInstanceExtensionFieldMvoDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public AttributeSetInstanceExtensionFieldMvoCommand.CreateAttributeSetInstanceExtensionFieldMvo toCreateAttributeSetInstanceExtensionFieldMvo()
        {
            return (AttributeSetInstanceExtensionFieldMvoCommand.CreateAttributeSetInstanceExtensionFieldMvo) toCommand();
        }

    }

    public static class MergePatchAttributeSetInstanceExtensionFieldMvoDto extends CreateOrMergePatchAttributeSetInstanceExtensionFieldMvoDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public AttributeSetInstanceExtensionFieldMvoCommand.MergePatchAttributeSetInstanceExtensionFieldMvo toMergePatchAttributeSetInstanceExtensionFieldMvo()
        {
            return (AttributeSetInstanceExtensionFieldMvoCommand.MergePatchAttributeSetInstanceExtensionFieldMvo) toCommand();
        }

    }

}

