﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirement
{

	public class InventoryItemRequirementEntryIdDtoWrapper : InventoryItemRequirementEntryIdDto
	{

        private InventoryItemRequirementEntryId _value = new InventoryItemRequirementEntryId();

		public InventoryItemRequirementEntryIdDtoWrapper()
		{
		}

		public InventoryItemRequirementEntryIdDtoWrapper(InventoryItemRequirementEntryId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override InventoryItemRequirementEntryId ToInventoryItemRequirementEntryId()
        {
            return this._value;
        }

		public override InventoryItemIdDto InventoryItemRequirementId { 
			get { return new InventoryItemIdDtoWrapper(_value.InventoryItemRequirementId); } 
			set { _value.InventoryItemRequirementId = value.ToInventoryItemId(); } 
		}

		public override long EntrySeqId { 
			get { return _value.EntrySeqId; } 
			set { _value.EntrySeqId = value; } 
		}


	}

}

