package org.dddml.wms.domain.movement;

import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractStateEvent;

public class MovementConfirmationLineStateEventDto extends AbstractStateEvent
{

    private MovementConfirmationLineStateEventIdDto stateEventId;

    MovementConfirmationLineStateEventIdDto getStateEventId() {
        if (stateEventId == null) { stateEventId = new MovementConfirmationLineStateEventIdDto(); }
        return this.stateEventId;
    }

    void setStateEventId(MovementConfirmationLineStateEventIdDto stateEventId) {
        this.stateEventId = stateEventId;
    }

    public String getLineNumber() {
        return getStateEventId().getLineNumber();
    }

    public void setLineNumber(String lineNumber) {
        getStateEventId().setLineNumber(lineNumber);
    }

    private BigDecimal targetQuantity;

    public BigDecimal getTargetQuantity() {
        return this.targetQuantity;
    }

    public void setTargetQuantity(BigDecimal targetQuantity) {
        this.targetQuantity = targetQuantity;
    }

    private BigDecimal confirmedQuantity;

    public BigDecimal getConfirmedQuantity() {
        return this.confirmedQuantity;
    }

    public void setConfirmedQuantity(BigDecimal confirmedQuantity) {
        this.confirmedQuantity = confirmedQuantity;
    }

    private BigDecimal differenceQuantity;

    public BigDecimal getDifferenceQuantity() {
        return this.differenceQuantity;
    }

    public void setDifferenceQuantity(BigDecimal differenceQuantity) {
        this.differenceQuantity = differenceQuantity;
    }

    private BigDecimal scrappedQuantity;

    public BigDecimal getScrappedQuantity() {
        return this.scrappedQuantity;
    }

    public void setScrappedQuantity(BigDecimal scrappedQuantity) {
        this.scrappedQuantity = scrappedQuantity;
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

    private Long version;

    public Long getVersion() {
        return this.version;
    }

    public void setVersion(Long version) {
        this.version = version;
    }

    private Boolean isPropertyTargetQuantityRemoved;

    public Boolean getIsPropertyTargetQuantityRemoved() {
        return this.isPropertyTargetQuantityRemoved;
    }

    public void setIsPropertyTargetQuantityRemoved(Boolean removed) {
        this.isPropertyTargetQuantityRemoved = removed;
    }

    private Boolean isPropertyConfirmedQuantityRemoved;

    public Boolean getIsPropertyConfirmedQuantityRemoved() {
        return this.isPropertyConfirmedQuantityRemoved;
    }

    public void setIsPropertyConfirmedQuantityRemoved(Boolean removed) {
        this.isPropertyConfirmedQuantityRemoved = removed;
    }

    private Boolean isPropertyDifferenceQuantityRemoved;

    public Boolean getIsPropertyDifferenceQuantityRemoved() {
        return this.isPropertyDifferenceQuantityRemoved;
    }

    public void setIsPropertyDifferenceQuantityRemoved(Boolean removed) {
        this.isPropertyDifferenceQuantityRemoved = removed;
    }

    private Boolean isPropertyScrappedQuantityRemoved;

    public Boolean getIsPropertyScrappedQuantityRemoved() {
        return this.isPropertyScrappedQuantityRemoved;
    }

    public void setIsPropertyScrappedQuantityRemoved(Boolean removed) {
        this.isPropertyScrappedQuantityRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved() {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed) {
        this.isPropertyActiveRemoved = removed;
    }


	public static class MovementConfirmationLineStateCreatedDto extends MovementConfirmationLineStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class MovementConfirmationLineStateMergePatchedDto extends MovementConfirmationLineStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class MovementConfirmationLineStateRemovedDto extends MovementConfirmationLineStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_REMOVED;
        }

	}


}

