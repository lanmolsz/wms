﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItemEntryMvo;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItemEntryMvo
{

	public static partial class SellableInventoryItemEntryMvoStateInterfaceExtension
	{

        public static ISellableInventoryItemEntryMvoCommand ToCreateOrMergePatchSellableInventoryItemEntryMvo<TCreateSellableInventoryItemEntryMvo, TMergePatchSellableInventoryItemEntryMvo>(this ISellableInventoryItemEntryMvoState state)
            where TCreateSellableInventoryItemEntryMvo : ICreateSellableInventoryItemEntryMvo, new()
            where TMergePatchSellableInventoryItemEntryMvo : IMergePatchSellableInventoryItemEntryMvo, new()
        {
            bool bUnsaved = ((ISellableInventoryItemEntryMvoState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateSellableInventoryItemEntryMvo<TCreateSellableInventoryItemEntryMvo>();
            }
            else 
            {
                return state.ToMergePatchSellableInventoryItemEntryMvo<TMergePatchSellableInventoryItemEntryMvo>();
            }
        }

        public static TDeleteSellableInventoryItemEntryMvo ToDeleteSellableInventoryItemEntryMvo<TDeleteSellableInventoryItemEntryMvo>(this ISellableInventoryItemEntryMvoState state)
            where TDeleteSellableInventoryItemEntryMvo : IDeleteSellableInventoryItemEntryMvo, new()
        {
            var cmd = new TDeleteSellableInventoryItemEntryMvo();
            cmd.SellableInventoryItemEntryId = state.SellableInventoryItemEntryId;
            cmd.SellableInventoryItemVersion = ((ISellableInventoryItemEntryMvoStateProperties)state).SellableInventoryItemVersion;

            return cmd;
        }

        public static TMergePatchSellableInventoryItemEntryMvo ToMergePatchSellableInventoryItemEntryMvo<TMergePatchSellableInventoryItemEntryMvo>(this ISellableInventoryItemEntryMvoState state)
            where TMergePatchSellableInventoryItemEntryMvo : IMergePatchSellableInventoryItemEntryMvo, new()
        {
            var cmd = new TMergePatchSellableInventoryItemEntryMvo();

            cmd.SellableInventoryItemVersion = ((ISellableInventoryItemEntryMvoStateProperties)state).SellableInventoryItemVersion;

            cmd.SellableInventoryItemEntryId = state.SellableInventoryItemEntryId;
            cmd.SellableQuantity = state.SellableQuantity;
            cmd.SourceEventId = state.SourceEventId;
            cmd.Version = ((ISellableInventoryItemEntryMvoStateProperties)state).Version;
            cmd.SellableInventoryItemSellableQuantity = state.SellableInventoryItemSellableQuantity;
            cmd.SellableInventoryItemCreatedBy = state.SellableInventoryItemCreatedBy;
            cmd.SellableInventoryItemCreatedAt = state.SellableInventoryItemCreatedAt;
            cmd.SellableInventoryItemUpdatedBy = state.SellableInventoryItemUpdatedBy;
            cmd.SellableInventoryItemUpdatedAt = state.SellableInventoryItemUpdatedAt;
            
            if (state.SourceEventId == null) { cmd.IsPropertySourceEventIdRemoved = true; }
            if (state.SellableInventoryItemCreatedBy == null) { cmd.IsPropertySellableInventoryItemCreatedByRemoved = true; }
            if (state.SellableInventoryItemUpdatedBy == null) { cmd.IsPropertySellableInventoryItemUpdatedByRemoved = true; }
            return cmd;
        }

        public static TCreateSellableInventoryItemEntryMvo ToCreateSellableInventoryItemEntryMvo<TCreateSellableInventoryItemEntryMvo>(this ISellableInventoryItemEntryMvoState state)
            where TCreateSellableInventoryItemEntryMvo : ICreateSellableInventoryItemEntryMvo, new()
        {
            var cmd = new TCreateSellableInventoryItemEntryMvo();

            cmd.SellableInventoryItemVersion = ((ISellableInventoryItemEntryMvoStateProperties)state).SellableInventoryItemVersion;

            cmd.SellableInventoryItemEntryId = state.SellableInventoryItemEntryId;
            cmd.SellableQuantity = state.SellableQuantity;
            cmd.SourceEventId = state.SourceEventId;
            cmd.Version = ((ISellableInventoryItemEntryMvoStateProperties)state).Version;
            cmd.SellableInventoryItemSellableQuantity = state.SellableInventoryItemSellableQuantity;
            cmd.SellableInventoryItemCreatedBy = state.SellableInventoryItemCreatedBy;
            cmd.SellableInventoryItemCreatedAt = state.SellableInventoryItemCreatedAt;
            cmd.SellableInventoryItemUpdatedBy = state.SellableInventoryItemUpdatedBy;
            cmd.SellableInventoryItemUpdatedAt = state.SellableInventoryItemUpdatedAt;
            return cmd;
        }
		

	}

}

