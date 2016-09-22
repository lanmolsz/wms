package org.dddml.wms.domain;

import java.util.*;
import java.util.Date;
import org.dddml.wms.specialization.*;


public class AttributeValueMvoStateDto
{

    private AttributeValueIdDto attributeValueId;

    public AttributeValueIdDto getAttributeValueId()
    {
        return this.attributeValueId;
    }

    public void setAttributeValueId(AttributeValueIdDto attributeValueId)
    {
        this.attributeValueId = attributeValueId;
    }

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

    private Long attributeVersion;

    public Long getAttributeVersion()
    {
        return this.attributeVersion;
    }

    public void setAttributeVersion(Long attributeVersion)
    {
        this.attributeVersion = attributeVersion;
    }

    private String createdBy;

    public String getCreatedBy()
    {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy)
    {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt()
    {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt)
    {
        this.createdAt = createdAt;
    }

    private String updatedBy;

    public String getUpdatedBy()
    {
        return this.updatedBy;
    }

    public void setUpdatedBy(String updatedBy)
    {
        this.updatedBy = updatedBy;
    }

    private Date updatedAt;

    public Date getUpdatedAt()
    {
        return this.updatedAt;
    }

    public void setUpdatedAt(Date updatedAt)
    {
        this.updatedAt = updatedAt;
    }


    public static class DtoConverter extends AbstractStateDtoConverter
    {
        public static Collection<String> collectionFieldNames = Arrays.asList(new String[]{});

        @Override
        protected boolean isCollectionField(String fieldName) {
            return CollectionUtils.collectionContainsIgnoringCase(collectionFieldNames, fieldName);
        }

        public AttributeValueMvoStateDto[] toAttributeValueMvoStateDtoArray(Iterable<AttributeValueMvoState> states) 
        {
            ArrayList<AttributeValueMvoStateDto> stateDtos = new ArrayList();
            for (AttributeValueMvoState s : states) {
                AttributeValueMvoStateDto dto = toAttributeValueMvoStateDto(s);
                stateDtos.add(dto);
            }
            return stateDtos.toArray(new AttributeValueMvoStateDto[0]);
        }

        public AttributeValueMvoStateDto toAttributeValueMvoStateDto(AttributeValueMvoState state)
        {
            AttributeValueMvoStateDto dto = new AttributeValueMvoStateDto();
            if (returnedFieldsContains("AttributeValueId")) {
                dto.setAttributeValueId((state.getAttributeValueId() == null) ? null : new AttributeValueIdDtoWrapper(state.getAttributeValueId()));
            }
            if (returnedFieldsContains("Name")) {
                dto.setName(state.getName());
            }
            if (returnedFieldsContains("Description")) {
                dto.setDescription(state.getDescription());
            }
            if (returnedFieldsContains("ReferenceId")) {
                dto.setReferenceId(state.getReferenceId());
            }
            if (returnedFieldsContains("Version")) {
                dto.setVersion(state.getVersion());
            }
            if (returnedFieldsContains("Active")) {
                dto.setActive(state.getActive());
            }
            if (returnedFieldsContains("AttributeName")) {
                dto.setAttributeName(state.getAttributeName());
            }
            if (returnedFieldsContains("AttributeOrganizationId")) {
                dto.setAttributeOrganizationId(state.getAttributeOrganizationId());
            }
            if (returnedFieldsContains("AttributeDescription")) {
                dto.setAttributeDescription(state.getAttributeDescription());
            }
            if (returnedFieldsContains("AttributeIsMandatory")) {
                dto.setAttributeIsMandatory(state.getAttributeIsMandatory());
            }
            if (returnedFieldsContains("AttributeIsInstanceAttribute")) {
                dto.setAttributeIsInstanceAttribute(state.getAttributeIsInstanceAttribute());
            }
            if (returnedFieldsContains("AttributeAttributeValueType")) {
                dto.setAttributeAttributeValueType(state.getAttributeAttributeValueType());
            }
            if (returnedFieldsContains("AttributeAttributeValueLength")) {
                dto.setAttributeAttributeValueLength(state.getAttributeAttributeValueLength());
            }
            if (returnedFieldsContains("AttributeIsList")) {
                dto.setAttributeIsList(state.getAttributeIsList());
            }
            if (returnedFieldsContains("AttributeFieldName")) {
                dto.setAttributeFieldName(state.getAttributeFieldName());
            }
            if (returnedFieldsContains("AttributeReferenceId")) {
                dto.setAttributeReferenceId(state.getAttributeReferenceId());
            }
            if (returnedFieldsContains("AttributeCreatedBy")) {
                dto.setAttributeCreatedBy(state.getAttributeCreatedBy());
            }
            if (returnedFieldsContains("AttributeCreatedAt")) {
                dto.setAttributeCreatedAt(state.getAttributeCreatedAt());
            }
            if (returnedFieldsContains("AttributeUpdatedBy")) {
                dto.setAttributeUpdatedBy(state.getAttributeUpdatedBy());
            }
            if (returnedFieldsContains("AttributeUpdatedAt")) {
                dto.setAttributeUpdatedAt(state.getAttributeUpdatedAt());
            }
            if (returnedFieldsContains("AttributeActive")) {
                dto.setAttributeActive(state.getAttributeActive());
            }
            if (returnedFieldsContains("AttributeDeleted")) {
                dto.setAttributeDeleted(state.getAttributeDeleted());
            }
            if (returnedFieldsContains("AttributeVersion")) {
                dto.setAttributeVersion(state.getAttributeVersion());
            }
            if (returnedFieldsContains("CreatedBy")) {
                dto.setCreatedBy(state.getCreatedBy());
            }
            if (returnedFieldsContains("CreatedAt")) {
                dto.setCreatedAt(state.getCreatedAt());
            }
            if (returnedFieldsContains("UpdatedBy")) {
                dto.setUpdatedBy(state.getUpdatedBy());
            }
            if (returnedFieldsContains("UpdatedAt")) {
                dto.setUpdatedAt(state.getUpdatedAt());
            }
            return dto;
        }

    }
}

