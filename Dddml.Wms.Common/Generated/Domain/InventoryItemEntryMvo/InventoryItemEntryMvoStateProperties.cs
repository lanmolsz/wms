﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEntryMvo;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItemEntryMvo
{

	public abstract class InventoryItemEntryMvoStateProperties : IInventoryItemEntryMvoStateProperties
	{
		public virtual InventoryItemEntryId InventoryItemEntryId { get; set; }

		public virtual decimal OnHandQuantity { get; set; }

		public virtual decimal InTransitQuantity { get; set; }

		public virtual decimal ReservedQuantity { get; set; }

		public virtual decimal OccupiedQuantity { get; set; }

		public virtual decimal VirtualQuantity { get; set; }

		public virtual InventoryItemSourceInfo Source { get; set; }

		public virtual long Version { get; set; }

		public virtual decimal InventoryItemOnHandQuantity { get; set; }

		public virtual decimal InventoryItemInTransitQuantity { get; set; }

		public virtual decimal InventoryItemReservedQuantity { get; set; }

		public virtual decimal InventoryItemOccupiedQuantity { get; set; }

		public virtual decimal InventoryItemVirtualQuantity { get; set; }

		public virtual long InventoryItemVersion { get; set; }

		public virtual string InventoryItemCreatedBy { get; set; }

		public virtual DateTime InventoryItemCreatedAt { get; set; }

		public virtual string InventoryItemUpdatedBy { get; set; }

		public virtual DateTime InventoryItemUpdatedAt { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
