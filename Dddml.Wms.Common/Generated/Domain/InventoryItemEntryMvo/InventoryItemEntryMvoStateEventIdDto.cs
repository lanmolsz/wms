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

	public class InventoryItemEntryMvoStateEventIdDto
	{

		public InventoryItemEntryMvoStateEventIdDto()
		{
		}

        public virtual InventoryItemEntryMvoStateEventId ToInventoryItemEntryMvoStateEventId()
        {
            InventoryItemEntryMvoStateEventId v = new InventoryItemEntryMvoStateEventId();
            v.InventoryItemEntryId = this.InventoryItemEntryId.ToInventoryItemEntryId();
            v.InventoryItemVersion = this.InventoryItemVersion;
            return v;
        }

		private InventoryItemEntryIdDto _inventoryItemEntryId = new InventoryItemEntryIdDto();

		public virtual InventoryItemEntryIdDto InventoryItemEntryId { 
			get { return this._inventoryItemEntryId; } 
			set { this._inventoryItemEntryId = value; } 
		}

		public virtual long InventoryItemVersion { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemEntryMvoStateEventIdDto other = obj as InventoryItemEntryMvoStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InventoryItemEntryId, other.InventoryItemEntryId)
				&& Object.Equals (this.InventoryItemVersion, other.InventoryItemVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InventoryItemEntryId != null) {
				hash += 13 * this.InventoryItemEntryId.GetHashCode ();
			}
			if (this.InventoryItemVersion != null) {
				hash += 13 * this.InventoryItemVersion.GetHashCode ();
			}
			return hash;
		}

	}

}

