package org.dddml.wms.domain.sellableinventoryitementrymvo;

import java.util.*;
import org.dddml.wms.domain.sellableinventoryitem.*;
import java.math.BigDecimal;
import org.dddml.wms.domain.inventoryprtriggered.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;

public interface SellableInventoryItemEntryMvoEvent extends Event
{
    SellableInventoryItemEntryMvoEventId getSellableInventoryItemEntryMvoEventId();

    boolean getEventReadOnly();

    void setEventReadOnly(boolean readOnly);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    String getCommandId();

    void setCommandId(String commandId);

    interface SellableInventoryItemEntryMvoStateEvent extends SellableInventoryItemEntryMvoEvent {
        BigDecimal getSellableQuantity();

        void setSellableQuantity(BigDecimal sellableQuantity);

        InventoryPRTriggeredId getSourceEventId();

        void setSourceEventId(InventoryPRTriggeredId sourceEventId);

        Long getVersion();

        void setVersion(Long version);

        BigDecimal getSellableInventoryItemSellableQuantity();

        void setSellableInventoryItemSellableQuantity(BigDecimal sellableInventoryItemSellableQuantity);

        String getSellableInventoryItemCreatedBy();

        void setSellableInventoryItemCreatedBy(String sellableInventoryItemCreatedBy);

        Date getSellableInventoryItemCreatedAt();

        void setSellableInventoryItemCreatedAt(Date sellableInventoryItemCreatedAt);

        String getSellableInventoryItemUpdatedBy();

        void setSellableInventoryItemUpdatedBy(String sellableInventoryItemUpdatedBy);

        Date getSellableInventoryItemUpdatedAt();

        void setSellableInventoryItemUpdatedAt(Date sellableInventoryItemUpdatedAt);

    }

    interface SellableInventoryItemEntryMvoStateCreated extends SellableInventoryItemEntryMvoStateEvent
    {
    
    }


    interface SellableInventoryItemEntryMvoStateMergePatched extends SellableInventoryItemEntryMvoStateEvent
    {
        Boolean getIsPropertySellableQuantityRemoved();

        void setIsPropertySellableQuantityRemoved(Boolean removed);

        Boolean getIsPropertySourceEventIdRemoved();

        void setIsPropertySourceEventIdRemoved(Boolean removed);

        Boolean getIsPropertyVersionRemoved();

        void setIsPropertyVersionRemoved(Boolean removed);

        Boolean getIsPropertySellableInventoryItemSellableQuantityRemoved();

        void setIsPropertySellableInventoryItemSellableQuantityRemoved(Boolean removed);

        Boolean getIsPropertySellableInventoryItemCreatedByRemoved();

        void setIsPropertySellableInventoryItemCreatedByRemoved(Boolean removed);

        Boolean getIsPropertySellableInventoryItemCreatedAtRemoved();

        void setIsPropertySellableInventoryItemCreatedAtRemoved(Boolean removed);

        Boolean getIsPropertySellableInventoryItemUpdatedByRemoved();

        void setIsPropertySellableInventoryItemUpdatedByRemoved(Boolean removed);

        Boolean getIsPropertySellableInventoryItemUpdatedAtRemoved();

        void setIsPropertySellableInventoryItemUpdatedAtRemoved(Boolean removed);


    }


}

