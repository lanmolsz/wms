package org.dddml.wms.domain.picklistitemmvo;

import java.util.*;
import org.dddml.wms.domain.picklistbin.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractPicklistItemMvoCommand extends AbstractCommand implements PicklistItemMvoCommand
{
    private PicklistBinPicklistItemId picklistBinPicklistItemId;

    public PicklistBinPicklistItemId getPicklistBinPicklistItemId()
    {
        return this.picklistBinPicklistItemId;
    }

    public void setPicklistBinPicklistItemId(PicklistBinPicklistItemId picklistBinPicklistItemId)
    {
        this.picklistBinPicklistItemId = picklistBinPicklistItemId;
    }

    private Long picklistBinVersion;

    public Long getPicklistBinVersion()
    {
        return this.picklistBinVersion;
    }

    public void setPicklistBinVersion(Long picklistBinVersion)
    {
        this.picklistBinVersion = picklistBinVersion;
    }


    public static abstract class AbstractCreateOrMergePatchPicklistItemMvo extends AbstractPicklistItemMvoCommand implements CreateOrMergePatchPicklistItemMvo
    {
        private String itemStatusId;

        public String getItemStatusId()
        {
            return this.itemStatusId;
        }

        public void setItemStatusId(String itemStatusId)
        {
            this.itemStatusId = itemStatusId;
        }

        private java.math.BigDecimal quantity;

        public java.math.BigDecimal getQuantity()
        {
            return this.quantity;
        }

        public void setQuantity(java.math.BigDecimal quantity)
        {
            this.quantity = quantity;
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

        private String picklistBinPicklistId;

        public String getPicklistBinPicklistId()
        {
            return this.picklistBinPicklistId;
        }

        public void setPicklistBinPicklistId(String picklistBinPicklistId)
        {
            this.picklistBinPicklistId = picklistBinPicklistId;
        }

        private Long picklistBinBinLocationNumber;

        public Long getPicklistBinBinLocationNumber()
        {
            return this.picklistBinBinLocationNumber;
        }

        public void setPicklistBinBinLocationNumber(Long picklistBinBinLocationNumber)
        {
            this.picklistBinBinLocationNumber = picklistBinBinLocationNumber;
        }

        private String picklistBinPrimaryOrderId;

        public String getPicklistBinPrimaryOrderId()
        {
            return this.picklistBinPrimaryOrderId;
        }

        public void setPicklistBinPrimaryOrderId(String picklistBinPrimaryOrderId)
        {
            this.picklistBinPrimaryOrderId = picklistBinPrimaryOrderId;
        }

        private Long picklistBinPrimaryShipGroupSeqId;

        public Long getPicklistBinPrimaryShipGroupSeqId()
        {
            return this.picklistBinPrimaryShipGroupSeqId;
        }

        public void setPicklistBinPrimaryShipGroupSeqId(Long picklistBinPrimaryShipGroupSeqId)
        {
            this.picklistBinPrimaryShipGroupSeqId = picklistBinPrimaryShipGroupSeqId;
        }

        private String picklistBinCreatedBy;

        public String getPicklistBinCreatedBy()
        {
            return this.picklistBinCreatedBy;
        }

        public void setPicklistBinCreatedBy(String picklistBinCreatedBy)
        {
            this.picklistBinCreatedBy = picklistBinCreatedBy;
        }

        private Date picklistBinCreatedAt;

        public Date getPicklistBinCreatedAt()
        {
            return this.picklistBinCreatedAt;
        }

        public void setPicklistBinCreatedAt(Date picklistBinCreatedAt)
        {
            this.picklistBinCreatedAt = picklistBinCreatedAt;
        }

        private String picklistBinUpdatedBy;

        public String getPicklistBinUpdatedBy()
        {
            return this.picklistBinUpdatedBy;
        }

        public void setPicklistBinUpdatedBy(String picklistBinUpdatedBy)
        {
            this.picklistBinUpdatedBy = picklistBinUpdatedBy;
        }

        private Date picklistBinUpdatedAt;

        public Date getPicklistBinUpdatedAt()
        {
            return this.picklistBinUpdatedAt;
        }

        public void setPicklistBinUpdatedAt(Date picklistBinUpdatedAt)
        {
            this.picklistBinUpdatedAt = picklistBinUpdatedAt;
        }

        private Boolean picklistBinActive;

        public Boolean getPicklistBinActive()
        {
            return this.picklistBinActive;
        }

        public void setPicklistBinActive(Boolean picklistBinActive)
        {
            this.picklistBinActive = picklistBinActive;
        }

        private Boolean picklistBinDeleted;

        public Boolean getPicklistBinDeleted()
        {
            return this.picklistBinDeleted;
        }

        public void setPicklistBinDeleted(Boolean picklistBinDeleted)
        {
            this.picklistBinDeleted = picklistBinDeleted;
        }

    }

    public static abstract class AbstractCreatePicklistItemMvo extends AbstractCreateOrMergePatchPicklistItemMvo implements CreatePicklistItemMvo
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }

    }

    public static abstract class AbstractMergePatchPicklistItemMvo extends AbstractCreateOrMergePatchPicklistItemMvo implements MergePatchPicklistItemMvo
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }

        private Boolean isPropertyItemStatusIdRemoved;

        public Boolean getIsPropertyItemStatusIdRemoved()
        {
            return this.isPropertyItemStatusIdRemoved;
        }

        public void setIsPropertyItemStatusIdRemoved(Boolean removed)
        {
            this.isPropertyItemStatusIdRemoved = removed;
        }

        private Boolean isPropertyQuantityRemoved;

        public Boolean getIsPropertyQuantityRemoved()
        {
            return this.isPropertyQuantityRemoved;
        }

        public void setIsPropertyQuantityRemoved(Boolean removed)
        {
            this.isPropertyQuantityRemoved = removed;
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

        private Boolean isPropertyPicklistBinPicklistIdRemoved;

        public Boolean getIsPropertyPicklistBinPicklistIdRemoved()
        {
            return this.isPropertyPicklistBinPicklistIdRemoved;
        }

        public void setIsPropertyPicklistBinPicklistIdRemoved(Boolean removed)
        {
            this.isPropertyPicklistBinPicklistIdRemoved = removed;
        }

        private Boolean isPropertyPicklistBinBinLocationNumberRemoved;

        public Boolean getIsPropertyPicklistBinBinLocationNumberRemoved()
        {
            return this.isPropertyPicklistBinBinLocationNumberRemoved;
        }

        public void setIsPropertyPicklistBinBinLocationNumberRemoved(Boolean removed)
        {
            this.isPropertyPicklistBinBinLocationNumberRemoved = removed;
        }

        private Boolean isPropertyPicklistBinPrimaryOrderIdRemoved;

        public Boolean getIsPropertyPicklistBinPrimaryOrderIdRemoved()
        {
            return this.isPropertyPicklistBinPrimaryOrderIdRemoved;
        }

        public void setIsPropertyPicklistBinPrimaryOrderIdRemoved(Boolean removed)
        {
            this.isPropertyPicklistBinPrimaryOrderIdRemoved = removed;
        }

        private Boolean isPropertyPicklistBinPrimaryShipGroupSeqIdRemoved;

        public Boolean getIsPropertyPicklistBinPrimaryShipGroupSeqIdRemoved()
        {
            return this.isPropertyPicklistBinPrimaryShipGroupSeqIdRemoved;
        }

        public void setIsPropertyPicklistBinPrimaryShipGroupSeqIdRemoved(Boolean removed)
        {
            this.isPropertyPicklistBinPrimaryShipGroupSeqIdRemoved = removed;
        }

        private Boolean isPropertyPicklistBinCreatedByRemoved;

        public Boolean getIsPropertyPicklistBinCreatedByRemoved()
        {
            return this.isPropertyPicklistBinCreatedByRemoved;
        }

        public void setIsPropertyPicklistBinCreatedByRemoved(Boolean removed)
        {
            this.isPropertyPicklistBinCreatedByRemoved = removed;
        }

        private Boolean isPropertyPicklistBinCreatedAtRemoved;

        public Boolean getIsPropertyPicklistBinCreatedAtRemoved()
        {
            return this.isPropertyPicklistBinCreatedAtRemoved;
        }

        public void setIsPropertyPicklistBinCreatedAtRemoved(Boolean removed)
        {
            this.isPropertyPicklistBinCreatedAtRemoved = removed;
        }

        private Boolean isPropertyPicklistBinUpdatedByRemoved;

        public Boolean getIsPropertyPicklistBinUpdatedByRemoved()
        {
            return this.isPropertyPicklistBinUpdatedByRemoved;
        }

        public void setIsPropertyPicklistBinUpdatedByRemoved(Boolean removed)
        {
            this.isPropertyPicklistBinUpdatedByRemoved = removed;
        }

        private Boolean isPropertyPicklistBinUpdatedAtRemoved;

        public Boolean getIsPropertyPicklistBinUpdatedAtRemoved()
        {
            return this.isPropertyPicklistBinUpdatedAtRemoved;
        }

        public void setIsPropertyPicklistBinUpdatedAtRemoved(Boolean removed)
        {
            this.isPropertyPicklistBinUpdatedAtRemoved = removed;
        }

        private Boolean isPropertyPicklistBinActiveRemoved;

        public Boolean getIsPropertyPicklistBinActiveRemoved()
        {
            return this.isPropertyPicklistBinActiveRemoved;
        }

        public void setIsPropertyPicklistBinActiveRemoved(Boolean removed)
        {
            this.isPropertyPicklistBinActiveRemoved = removed;
        }

        private Boolean isPropertyPicklistBinDeletedRemoved;

        public Boolean getIsPropertyPicklistBinDeletedRemoved()
        {
            return this.isPropertyPicklistBinDeletedRemoved;
        }

        public void setIsPropertyPicklistBinDeletedRemoved(Boolean removed)
        {
            this.isPropertyPicklistBinDeletedRemoved = removed;
        }

    }

    public static class SimpleCreatePicklistItemMvo extends AbstractCreatePicklistItemMvo
    {
    }

    
    public static class SimpleMergePatchPicklistItemMvo extends AbstractMergePatchPicklistItemMvo
    {
    }

    
	public static class SimpleDeletePicklistItemMvo extends AbstractPicklistItemMvoCommand implements DeletePicklistItemMvo
	{
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_DELETE;
        }
	}

    

}

