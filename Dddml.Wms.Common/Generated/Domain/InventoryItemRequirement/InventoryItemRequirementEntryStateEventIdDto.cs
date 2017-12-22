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

	public class InventoryItemRequirementEntryStateEventIdDto
	{

		public InventoryItemRequirementEntryStateEventIdDto()
		{
		}

        public virtual InventoryItemRequirementEntryStateEventId ToInventoryItemRequirementEntryStateEventId()
        {
            InventoryItemRequirementEntryStateEventId v = new InventoryItemRequirementEntryStateEventId();
            v.InventoryItemRequirementId = this.InventoryItemRequirementId.ToInventoryItemId();
            v.EntrySeqId = this.EntrySeqId;
            v.InventoryItemRequirementVersion = this.InventoryItemRequirementVersion;
            return v;
        }

		private InventoryItemIdDto _inventoryItemRequirementId = new InventoryItemIdDto();

		public virtual InventoryItemIdDto InventoryItemRequirementId { 
			get { return this._inventoryItemRequirementId; } 
			set { this._inventoryItemRequirementId = value; } 
		}

		public virtual long EntrySeqId { 
			get;
			set;
		}

		public virtual long InventoryItemRequirementVersion { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemRequirementEntryStateEventIdDto other = obj as InventoryItemRequirementEntryStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InventoryItemRequirementId, other.InventoryItemRequirementId)
				&& Object.Equals (this.EntrySeqId, other.EntrySeqId)
				&& Object.Equals (this.InventoryItemRequirementVersion, other.InventoryItemRequirementVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InventoryItemRequirementId != null) {
				hash += 13 * this.InventoryItemRequirementId.GetHashCode ();
			}
			if (this.EntrySeqId != null) {
				hash += 13 * this.EntrySeqId.GetHashCode ();
			}
			if (this.InventoryItemRequirementVersion != null) {
				hash += 13 * this.InventoryItemRequirementVersion.GetHashCode ();
			}
			return hash;
		}

	}

}

