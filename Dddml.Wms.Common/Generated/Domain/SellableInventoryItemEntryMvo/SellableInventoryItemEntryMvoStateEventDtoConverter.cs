﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItemEntryMvo;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItemEntryMvo
{

    public class SellableInventoryItemEntryMvoStateEventDtoConverter
    {
        public virtual SellableInventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto ToSellableInventoryItemEntryMvoStateEventDto(ISellableInventoryItemEntryMvoStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (ISellableInventoryItemEntryMvoStateCreated)stateEvent;
                return ToSellableInventoryItemEntryMvoStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (ISellableInventoryItemEntryMvoStateMergePatched)stateEvent;
                return ToSellableInventoryItemEntryMvoStateMergePatchedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual SellableInventoryItemEntryMvoStateCreatedDto ToSellableInventoryItemEntryMvoStateCreatedDto(ISellableInventoryItemEntryMvoStateCreated e)
        {
            var dto = new SellableInventoryItemEntryMvoStateCreatedDto();
            dto.StateEventId = new SellableInventoryItemEntryMvoStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.QuantitySellable = e.QuantitySellable;
            dto.SourceEventId = (e.SourceEventId == null) ? null : new InventoryPRTriggeredIdDtoWrapper(e.SourceEventId);
            dto.Version = e.Version;
            dto.SellableInventoryItemQuantitySellable = e.SellableInventoryItemQuantitySellable;
            dto.SellableInventoryItemCreatedBy = e.SellableInventoryItemCreatedBy;
            dto.SellableInventoryItemCreatedAt = e.SellableInventoryItemCreatedAt;
            dto.SellableInventoryItemUpdatedBy = e.SellableInventoryItemUpdatedBy;
            dto.SellableInventoryItemUpdatedAt = e.SellableInventoryItemUpdatedAt;
            return dto;
        }

        public virtual SellableInventoryItemEntryMvoStateMergePatchedDto ToSellableInventoryItemEntryMvoStateMergePatchedDto(ISellableInventoryItemEntryMvoStateMergePatched e)
        {
            var dto = new SellableInventoryItemEntryMvoStateMergePatchedDto();
            dto.StateEventId = new SellableInventoryItemEntryMvoStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.QuantitySellable = e.QuantitySellable;
            dto.SourceEventId = (e.SourceEventId == null) ? null : new InventoryPRTriggeredIdDtoWrapper(e.SourceEventId);
            dto.Version = e.Version;
            dto.SellableInventoryItemQuantitySellable = e.SellableInventoryItemQuantitySellable;
            dto.SellableInventoryItemCreatedBy = e.SellableInventoryItemCreatedBy;
            dto.SellableInventoryItemCreatedAt = e.SellableInventoryItemCreatedAt;
            dto.SellableInventoryItemUpdatedBy = e.SellableInventoryItemUpdatedBy;
            dto.SellableInventoryItemUpdatedAt = e.SellableInventoryItemUpdatedAt;
            dto.IsPropertyQuantitySellableRemoved = e.IsPropertyQuantitySellableRemoved;
            dto.IsPropertySourceEventIdRemoved = e.IsPropertySourceEventIdRemoved;
            dto.IsPropertyVersionRemoved = e.IsPropertyVersionRemoved;
            dto.IsPropertySellableInventoryItemQuantitySellableRemoved = e.IsPropertySellableInventoryItemQuantitySellableRemoved;
            dto.IsPropertySellableInventoryItemCreatedByRemoved = e.IsPropertySellableInventoryItemCreatedByRemoved;
            dto.IsPropertySellableInventoryItemCreatedAtRemoved = e.IsPropertySellableInventoryItemCreatedAtRemoved;
            dto.IsPropertySellableInventoryItemUpdatedByRemoved = e.IsPropertySellableInventoryItemUpdatedByRemoved;
            dto.IsPropertySellableInventoryItemUpdatedAtRemoved = e.IsPropertySellableInventoryItemUpdatedAtRemoved;

            return dto;
        }



    }


}
