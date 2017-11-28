﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{

	public abstract class InventoryItemStateProperties : IInventoryItemStateProperties
	{
		public virtual InventoryItemId InventoryItemId { get; set; }

		public virtual decimal QuantityOnHand { get; set; }

		public virtual decimal QuantityReserved { get; set; }

		public virtual decimal QuantityOccupied { get; set; }

		public virtual decimal QuantityVirtual { get; set; }

		public virtual long Version { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}