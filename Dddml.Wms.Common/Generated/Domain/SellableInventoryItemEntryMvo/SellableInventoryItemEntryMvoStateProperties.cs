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

	public abstract class SellableInventoryItemEntryMvoStateProperties : ISellableInventoryItemEntryMvoStateProperties
	{
		public virtual SellableInventoryItemEntryId SellableInventoryItemEntryId { get; set; }

		public virtual decimal SellableQuantity { get; set; }

		public virtual InventoryPRTriggeredId SourceEventId { get; set; }

		public virtual long Version { get; set; }

		public virtual decimal SellableInventoryItemSellableQuantity { get; set; }

		public virtual long SellableInventoryItemVersion { get; set; }

		public virtual string SellableInventoryItemCreatedBy { get; set; }

		public virtual DateTime SellableInventoryItemCreatedAt { get; set; }

		public virtual string SellableInventoryItemUpdatedBy { get; set; }

		public virtual DateTime SellableInventoryItemUpdatedAt { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
