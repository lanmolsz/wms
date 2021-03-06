﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.PhysicalInventory
{

	public abstract class PhysicalInventoryLineStateProperties : IPhysicalInventoryLineStateProperties
	{
		public virtual InventoryItemId InventoryItemId { get; set; }

		public virtual decimal BookQuantity { get; set; }

		public virtual decimal CountedQuantity { get; set; }

		public virtual bool Processed { get; set; }

		public virtual string LineNumber { get; set; }

		public virtual long ReversalLineNumber { get; set; }

		public virtual string Description { get; set; }

		public virtual long Version { get; set; }

		// Outer Id:

		public virtual string PhysicalInventoryDocumentNumber { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
