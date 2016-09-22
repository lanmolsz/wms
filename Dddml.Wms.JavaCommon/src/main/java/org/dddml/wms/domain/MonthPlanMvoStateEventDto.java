package org.dddml.wms.domain;

import java.util.Date;
import org.dddml.wms.domain.AbstractStateEvent;

public class MonthPlanMvoStateEventDto extends AbstractStateEvent
{
    private String stateEventType;

    public String getStateEventType() {
        return this.stateEventType;
    }

    public void setStateEventType(String type) {
        this.stateEventType = type;
    }

    private MonthPlanMvoStateEventIdDto stateEventId;

    MonthPlanMvoStateEventIdDto getStateEventId() {
        if (stateEventId == null) { stateEventId = new MonthPlanMvoStateEventIdDto(); }
        return this.stateEventId;
    }

    void setStateEventId(MonthPlanMvoStateEventIdDto stateEventId) {
        this.stateEventId = stateEventId;
    }
    public MonthPlanIdDto getMonthPlanId() {
        return getStateEventId().getMonthPlanId();
    }

    public void setMonthPlanId(MonthPlanIdDto monthPlanId) {
        getStateEventId().setMonthPlanId(monthPlanId);
    }

    public Long getPersonVersion() {
        return getStateEventId().getPersonVersion();
    }
    
    public void getPersonVersion(Long personVersion) {
        getStateEventId().setPersonVersion(personVersion);
    }

    private String description;

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    private Long version;

    public Long getVersion() {
        return this.version;
    }

    public void setVersion(Long version) {
        this.version = version;
    }

    private Boolean active;

    public Boolean getActive() {
        return this.active;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }

    private String yearPlanDescription;

    public String getYearPlanDescription() {
        return this.yearPlanDescription;
    }

    public void setYearPlanDescription(String yearPlanDescription) {
        this.yearPlanDescription = yearPlanDescription;
    }

    private String yearPlanCreatedBy;

    public String getYearPlanCreatedBy() {
        return this.yearPlanCreatedBy;
    }

    public void setYearPlanCreatedBy(String yearPlanCreatedBy) {
        this.yearPlanCreatedBy = yearPlanCreatedBy;
    }

    private String yearPlanUpdatedBy;

    public String getYearPlanUpdatedBy() {
        return this.yearPlanUpdatedBy;
    }

    public void setYearPlanUpdatedBy(String yearPlanUpdatedBy) {
        this.yearPlanUpdatedBy = yearPlanUpdatedBy;
    }

    private Long yearPlanVersion;

    public Long getYearPlanVersion() {
        return this.yearPlanVersion;
    }

    public void setYearPlanVersion(Long yearPlanVersion) {
        this.yearPlanVersion = yearPlanVersion;
    }

    private Date yearPlanCreatedAt;

    public Date getYearPlanCreatedAt() {
        return this.yearPlanCreatedAt;
    }

    public void setYearPlanCreatedAt(Date yearPlanCreatedAt) {
        this.yearPlanCreatedAt = yearPlanCreatedAt;
    }

    private Date yearPlanUpdatedAt;

    public Date getYearPlanUpdatedAt() {
        return this.yearPlanUpdatedAt;
    }

    public void setYearPlanUpdatedAt(Date yearPlanUpdatedAt) {
        this.yearPlanUpdatedAt = yearPlanUpdatedAt;
    }

    private Boolean yearPlanActive;

    public Boolean getYearPlanActive() {
        return this.yearPlanActive;
    }

    public void setYearPlanActive(Boolean yearPlanActive) {
        this.yearPlanActive = yearPlanActive;
    }

    private Boolean yearPlanDeleted;

    public Boolean getYearPlanDeleted() {
        return this.yearPlanDeleted;
    }

    public void setYearPlanDeleted(Boolean yearPlanDeleted) {
        this.yearPlanDeleted = yearPlanDeleted;
    }

    private Date personBirthDate;

    public Date getPersonBirthDate() {
        return this.personBirthDate;
    }

    public void setPersonBirthDate(Date personBirthDate) {
        this.personBirthDate = personBirthDate;
    }

    private PersonalNameDto personLoves = new PersonalNameDto();

    public PersonalNameDto getPersonLoves() {
        return this.personLoves;
    }

    public void setPersonLoves(PersonalNameDto personLoves) {
        this.personLoves = personLoves;
    }

    private ContactDto personEmergencyContact = new ContactDto();

    public ContactDto getPersonEmergencyContact() {
        return this.personEmergencyContact;
    }

    public void setPersonEmergencyContact(ContactDto personEmergencyContact) {
        this.personEmergencyContact = personEmergencyContact;
    }

    private String personCreatedBy;

    public String getPersonCreatedBy() {
        return this.personCreatedBy;
    }

    public void setPersonCreatedBy(String personCreatedBy) {
        this.personCreatedBy = personCreatedBy;
    }

    private String personUpdatedBy;

    public String getPersonUpdatedBy() {
        return this.personUpdatedBy;
    }

    public void setPersonUpdatedBy(String personUpdatedBy) {
        this.personUpdatedBy = personUpdatedBy;
    }

    private Date personCreatedAt;

    public Date getPersonCreatedAt() {
        return this.personCreatedAt;
    }

    public void setPersonCreatedAt(Date personCreatedAt) {
        this.personCreatedAt = personCreatedAt;
    }

    private Date personUpdatedAt;

    public Date getPersonUpdatedAt() {
        return this.personUpdatedAt;
    }

    public void setPersonUpdatedAt(Date personUpdatedAt) {
        this.personUpdatedAt = personUpdatedAt;
    }

    private Boolean personActive;

    public Boolean getPersonActive() {
        return this.personActive;
    }

    public void setPersonActive(Boolean personActive) {
        this.personActive = personActive;
    }

    private Boolean personDeleted;

    public Boolean getPersonDeleted() {
        return this.personDeleted;
    }

    public void setPersonDeleted(Boolean personDeleted) {
        this.personDeleted = personDeleted;
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

    private String commandId;

    public String getCommandId() {
        return commandId;
    }

    public void setCommandId(String commandId) {
        this.commandId = commandId;
    }

    private Boolean isPropertyDescriptionRemoved;

    public Boolean getIsPropertyDescriptionRemoved() {
        return this.isPropertyDescriptionRemoved;
    }

    public void setIsPropertyDescriptionRemoved(Boolean removed) {
        this.isPropertyDescriptionRemoved = removed;
    }

    private Boolean isPropertyVersionRemoved;

    public Boolean getIsPropertyVersionRemoved() {
        return this.isPropertyVersionRemoved;
    }

    public void setIsPropertyVersionRemoved(Boolean removed) {
        this.isPropertyVersionRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved() {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed) {
        this.isPropertyActiveRemoved = removed;
    }

    private Boolean isPropertyYearPlanDescriptionRemoved;

    public Boolean getIsPropertyYearPlanDescriptionRemoved() {
        return this.isPropertyYearPlanDescriptionRemoved;
    }

    public void setIsPropertyYearPlanDescriptionRemoved(Boolean removed) {
        this.isPropertyYearPlanDescriptionRemoved = removed;
    }

    private Boolean isPropertyYearPlanCreatedByRemoved;

    public Boolean getIsPropertyYearPlanCreatedByRemoved() {
        return this.isPropertyYearPlanCreatedByRemoved;
    }

    public void setIsPropertyYearPlanCreatedByRemoved(Boolean removed) {
        this.isPropertyYearPlanCreatedByRemoved = removed;
    }

    private Boolean isPropertyYearPlanUpdatedByRemoved;

    public Boolean getIsPropertyYearPlanUpdatedByRemoved() {
        return this.isPropertyYearPlanUpdatedByRemoved;
    }

    public void setIsPropertyYearPlanUpdatedByRemoved(Boolean removed) {
        this.isPropertyYearPlanUpdatedByRemoved = removed;
    }

    private Boolean isPropertyYearPlanVersionRemoved;

    public Boolean getIsPropertyYearPlanVersionRemoved() {
        return this.isPropertyYearPlanVersionRemoved;
    }

    public void setIsPropertyYearPlanVersionRemoved(Boolean removed) {
        this.isPropertyYearPlanVersionRemoved = removed;
    }

    private Boolean isPropertyYearPlanCreatedAtRemoved;

    public Boolean getIsPropertyYearPlanCreatedAtRemoved() {
        return this.isPropertyYearPlanCreatedAtRemoved;
    }

    public void setIsPropertyYearPlanCreatedAtRemoved(Boolean removed) {
        this.isPropertyYearPlanCreatedAtRemoved = removed;
    }

    private Boolean isPropertyYearPlanUpdatedAtRemoved;

    public Boolean getIsPropertyYearPlanUpdatedAtRemoved() {
        return this.isPropertyYearPlanUpdatedAtRemoved;
    }

    public void setIsPropertyYearPlanUpdatedAtRemoved(Boolean removed) {
        this.isPropertyYearPlanUpdatedAtRemoved = removed;
    }

    private Boolean isPropertyYearPlanActiveRemoved;

    public Boolean getIsPropertyYearPlanActiveRemoved() {
        return this.isPropertyYearPlanActiveRemoved;
    }

    public void setIsPropertyYearPlanActiveRemoved(Boolean removed) {
        this.isPropertyYearPlanActiveRemoved = removed;
    }

    private Boolean isPropertyYearPlanDeletedRemoved;

    public Boolean getIsPropertyYearPlanDeletedRemoved() {
        return this.isPropertyYearPlanDeletedRemoved;
    }

    public void setIsPropertyYearPlanDeletedRemoved(Boolean removed) {
        this.isPropertyYearPlanDeletedRemoved = removed;
    }

    private Boolean isPropertyPersonBirthDateRemoved;

    public Boolean getIsPropertyPersonBirthDateRemoved() {
        return this.isPropertyPersonBirthDateRemoved;
    }

    public void setIsPropertyPersonBirthDateRemoved(Boolean removed) {
        this.isPropertyPersonBirthDateRemoved = removed;
    }

    private Boolean isPropertyPersonLovesRemoved;

    public Boolean getIsPropertyPersonLovesRemoved() {
        return this.isPropertyPersonLovesRemoved;
    }

    public void setIsPropertyPersonLovesRemoved(Boolean removed) {
        this.isPropertyPersonLovesRemoved = removed;
    }

    private Boolean isPropertyPersonEmergencyContactRemoved;

    public Boolean getIsPropertyPersonEmergencyContactRemoved() {
        return this.isPropertyPersonEmergencyContactRemoved;
    }

    public void setIsPropertyPersonEmergencyContactRemoved(Boolean removed) {
        this.isPropertyPersonEmergencyContactRemoved = removed;
    }

    private Boolean isPropertyPersonCreatedByRemoved;

    public Boolean getIsPropertyPersonCreatedByRemoved() {
        return this.isPropertyPersonCreatedByRemoved;
    }

    public void setIsPropertyPersonCreatedByRemoved(Boolean removed) {
        this.isPropertyPersonCreatedByRemoved = removed;
    }

    private Boolean isPropertyPersonUpdatedByRemoved;

    public Boolean getIsPropertyPersonUpdatedByRemoved() {
        return this.isPropertyPersonUpdatedByRemoved;
    }

    public void setIsPropertyPersonUpdatedByRemoved(Boolean removed) {
        this.isPropertyPersonUpdatedByRemoved = removed;
    }

    private Boolean isPropertyPersonCreatedAtRemoved;

    public Boolean getIsPropertyPersonCreatedAtRemoved() {
        return this.isPropertyPersonCreatedAtRemoved;
    }

    public void setIsPropertyPersonCreatedAtRemoved(Boolean removed) {
        this.isPropertyPersonCreatedAtRemoved = removed;
    }

    private Boolean isPropertyPersonUpdatedAtRemoved;

    public Boolean getIsPropertyPersonUpdatedAtRemoved() {
        return this.isPropertyPersonUpdatedAtRemoved;
    }

    public void setIsPropertyPersonUpdatedAtRemoved(Boolean removed) {
        this.isPropertyPersonUpdatedAtRemoved = removed;
    }

    private Boolean isPropertyPersonActiveRemoved;

    public Boolean getIsPropertyPersonActiveRemoved() {
        return this.isPropertyPersonActiveRemoved;
    }

    public void setIsPropertyPersonActiveRemoved(Boolean removed) {
        this.isPropertyPersonActiveRemoved = removed;
    }

    private Boolean isPropertyPersonDeletedRemoved;

    public Boolean getIsPropertyPersonDeletedRemoved() {
        return this.isPropertyPersonDeletedRemoved;
    }

    public void setIsPropertyPersonDeletedRemoved(Boolean removed) {
        this.isPropertyPersonDeletedRemoved = removed;
    }


	public static class MonthPlanMvoStateCreatedDto extends MonthPlanMvoStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class MonthPlanMvoStateMergePatchedDto extends MonthPlanMvoStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public class MonthPlanMvoStateDeletedDto extends MonthPlanMvoStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_DELETED;
        }

	}


}

