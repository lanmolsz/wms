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

	public static partial class SellableInventoryItemEntryMvoStateDtoExtension
	{

        public static ISellableInventoryItemEntryMvoCommand ToCreateOrMergePatchSellableInventoryItemEntryMvo(this SellableInventoryItemEntryMvoStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchSellableInventoryItemEntryMvo<CreateSellableInventoryItemEntryMvoDto, MergePatchSellableInventoryItemEntryMvoDto>();
        }

        public static DeleteSellableInventoryItemEntryMvoDto ToDeleteSellableInventoryItemEntryMvo(this SellableInventoryItemEntryMvoStateDtoWrapper state)
        {
            return state.ToDeleteSellableInventoryItemEntryMvo<DeleteSellableInventoryItemEntryMvoDto>();
        }

        public static MergePatchSellableInventoryItemEntryMvoDto ToMergePatchSellableInventoryItemEntryMvo(this SellableInventoryItemEntryMvoStateDtoWrapper state)
        {
            return state.ToMergePatchSellableInventoryItemEntryMvo<MergePatchSellableInventoryItemEntryMvoDto>();
        }

        public static CreateSellableInventoryItemEntryMvoDto ToCreateSellableInventoryItemEntryMvo(this SellableInventoryItemEntryMvoStateDtoWrapper state)
        {
            return state.ToCreateSellableInventoryItemEntryMvo<CreateSellableInventoryItemEntryMvoDto>();
        }
		

	}

}
