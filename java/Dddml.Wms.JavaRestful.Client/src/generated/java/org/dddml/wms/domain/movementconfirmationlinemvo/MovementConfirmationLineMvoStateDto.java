package org.dddml.wms.domain.movementconfirmationlinemvo;

import java.util.*;
import org.dddml.wms.domain.movementconfirmation.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;


public class MovementConfirmationLineMvoStateDto
{

    private MovementConfirmationLineId movementConfirmationLineId;

    public MovementConfirmationLineId getMovementConfirmationLineId()
    {
        return this.movementConfirmationLineId;
    }

    public void setMovementConfirmationLineId(MovementConfirmationLineId movementConfirmationLineId)
    {
        this.movementConfirmationLineId = movementConfirmationLineId;
    }

    private String movementLineNumber;

    public String getMovementLineNumber()
    {
        return this.movementLineNumber;
    }

    public void setMovementLineNumber(String movementLineNumber)
    {
        this.movementLineNumber = movementLineNumber;
    }

    private BigDecimal targetQuantity;

    public BigDecimal getTargetQuantity()
    {
        return this.targetQuantity;
    }

    public void setTargetQuantity(BigDecimal targetQuantity)
    {
        this.targetQuantity = targetQuantity;
    }

    private BigDecimal confirmedQuantity;

    public BigDecimal getConfirmedQuantity()
    {
        return this.confirmedQuantity;
    }

    public void setConfirmedQuantity(BigDecimal confirmedQuantity)
    {
        this.confirmedQuantity = confirmedQuantity;
    }

    private BigDecimal differenceQuantity;

    public BigDecimal getDifferenceQuantity()
    {
        return this.differenceQuantity;
    }

    public void setDifferenceQuantity(BigDecimal differenceQuantity)
    {
        this.differenceQuantity = differenceQuantity;
    }

    private BigDecimal scrappedQuantity;

    public BigDecimal getScrappedQuantity()
    {
        return this.scrappedQuantity;
    }

    public void setScrappedQuantity(BigDecimal scrappedQuantity)
    {
        this.scrappedQuantity = scrappedQuantity;
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

    private Boolean processed;

    public Boolean getProcessed()
    {
        return this.processed;
    }

    public void setProcessed(Boolean processed)
    {
        this.processed = processed;
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

    private String movementConfirmationDocumentStatusId;

    public String getMovementConfirmationDocumentStatusId()
    {
        return this.movementConfirmationDocumentStatusId;
    }

    public void setMovementConfirmationDocumentStatusId(String movementConfirmationDocumentStatusId)
    {
        this.movementConfirmationDocumentStatusId = movementConfirmationDocumentStatusId;
    }

    private String movementConfirmationMovementDocumentNumber;

    public String getMovementConfirmationMovementDocumentNumber()
    {
        return this.movementConfirmationMovementDocumentNumber;
    }

    public void setMovementConfirmationMovementDocumentNumber(String movementConfirmationMovementDocumentNumber)
    {
        this.movementConfirmationMovementDocumentNumber = movementConfirmationMovementDocumentNumber;
    }

    private Boolean movementConfirmationIsApproved;

    public Boolean getMovementConfirmationIsApproved()
    {
        return this.movementConfirmationIsApproved;
    }

    public void setMovementConfirmationIsApproved(Boolean movementConfirmationIsApproved)
    {
        this.movementConfirmationIsApproved = movementConfirmationIsApproved;
    }

    private BigDecimal movementConfirmationApprovalAmount;

    public BigDecimal getMovementConfirmationApprovalAmount()
    {
        return this.movementConfirmationApprovalAmount;
    }

    public void setMovementConfirmationApprovalAmount(BigDecimal movementConfirmationApprovalAmount)
    {
        this.movementConfirmationApprovalAmount = movementConfirmationApprovalAmount;
    }

    private Boolean movementConfirmationProcessed;

    public Boolean getMovementConfirmationProcessed()
    {
        return this.movementConfirmationProcessed;
    }

    public void setMovementConfirmationProcessed(Boolean movementConfirmationProcessed)
    {
        this.movementConfirmationProcessed = movementConfirmationProcessed;
    }

    private String movementConfirmationProcessing;

    public String getMovementConfirmationProcessing()
    {
        return this.movementConfirmationProcessing;
    }

    public void setMovementConfirmationProcessing(String movementConfirmationProcessing)
    {
        this.movementConfirmationProcessing = movementConfirmationProcessing;
    }

    private String movementConfirmationDocumentTypeId;

    public String getMovementConfirmationDocumentTypeId()
    {
        return this.movementConfirmationDocumentTypeId;
    }

    public void setMovementConfirmationDocumentTypeId(String movementConfirmationDocumentTypeId)
    {
        this.movementConfirmationDocumentTypeId = movementConfirmationDocumentTypeId;
    }

    private String movementConfirmationDescription;

    public String getMovementConfirmationDescription()
    {
        return this.movementConfirmationDescription;
    }

    public void setMovementConfirmationDescription(String movementConfirmationDescription)
    {
        this.movementConfirmationDescription = movementConfirmationDescription;
    }

    private String movementConfirmationCreatedBy;

    public String getMovementConfirmationCreatedBy()
    {
        return this.movementConfirmationCreatedBy;
    }

    public void setMovementConfirmationCreatedBy(String movementConfirmationCreatedBy)
    {
        this.movementConfirmationCreatedBy = movementConfirmationCreatedBy;
    }

    private Date movementConfirmationCreatedAt;

    public Date getMovementConfirmationCreatedAt()
    {
        return this.movementConfirmationCreatedAt;
    }

    public void setMovementConfirmationCreatedAt(Date movementConfirmationCreatedAt)
    {
        this.movementConfirmationCreatedAt = movementConfirmationCreatedAt;
    }

    private String movementConfirmationUpdatedBy;

    public String getMovementConfirmationUpdatedBy()
    {
        return this.movementConfirmationUpdatedBy;
    }

    public void setMovementConfirmationUpdatedBy(String movementConfirmationUpdatedBy)
    {
        this.movementConfirmationUpdatedBy = movementConfirmationUpdatedBy;
    }

    private Date movementConfirmationUpdatedAt;

    public Date getMovementConfirmationUpdatedAt()
    {
        return this.movementConfirmationUpdatedAt;
    }

    public void setMovementConfirmationUpdatedAt(Date movementConfirmationUpdatedAt)
    {
        this.movementConfirmationUpdatedAt = movementConfirmationUpdatedAt;
    }

    private Boolean movementConfirmationActive;

    public Boolean getMovementConfirmationActive()
    {
        return this.movementConfirmationActive;
    }

    public void setMovementConfirmationActive(Boolean movementConfirmationActive)
    {
        this.movementConfirmationActive = movementConfirmationActive;
    }

    private Boolean movementConfirmationDeleted;

    public Boolean getMovementConfirmationDeleted()
    {
        return this.movementConfirmationDeleted;
    }

    public void setMovementConfirmationDeleted(Boolean movementConfirmationDeleted)
    {
        this.movementConfirmationDeleted = movementConfirmationDeleted;
    }

    private Long movementConfirmationVersion;

    public Long getMovementConfirmationVersion()
    {
        return this.movementConfirmationVersion;
    }

    public void setMovementConfirmationVersion(Long movementConfirmationVersion)
    {
        this.movementConfirmationVersion = movementConfirmationVersion;
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

}

