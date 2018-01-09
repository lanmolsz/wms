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

	public class InventoryItemEntryMvoStateEventId
	{

		private InventoryItemEntryId _inventoryItemEntryId = new InventoryItemEntryId();

		public virtual InventoryItemEntryId InventoryItemEntryId { 
			get { return this._inventoryItemEntryId; } 
			internal set { _inventoryItemEntryId = value; } 
		}

		private long _inventoryItemVersion;

		public virtual long InventoryItemVersion { 
			get { return this._inventoryItemVersion; } 
			internal set { _inventoryItemVersion = value; } 
		}


        #region  Flattened Properties


		public virtual string InventoryItemEntryIdInventoryItemIdProductId {
			get { return InventoryItemEntryId.InventoryItemId.ProductId; }
			internal set { InventoryItemEntryId.InventoryItemId.ProductId = value; }
		}

		public virtual string InventoryItemEntryIdInventoryItemIdLocatorId {
			get { return InventoryItemEntryId.InventoryItemId.LocatorId; }
			internal set { InventoryItemEntryId.InventoryItemId.LocatorId = value; }
		}

		public virtual string InventoryItemEntryIdInventoryItemIdAttributeSetInstanceId {
			get { return InventoryItemEntryId.InventoryItemId.AttributeSetInstanceId; }
			internal set { InventoryItemEntryId.InventoryItemId.AttributeSetInstanceId = value; }
		}

		public virtual long InventoryItemEntryIdEntrySeqId {
			get { return InventoryItemEntryId.EntrySeqId; }
			internal set { InventoryItemEntryId.EntrySeqId = value; }
		}

        #endregion

		internal InventoryItemEntryMvoStateEventId ()
		{
		}

		public InventoryItemEntryMvoStateEventId (InventoryItemEntryId inventoryItemEntryId, long inventoryItemVersion)
		{
			this._inventoryItemEntryId = inventoryItemEntryId;
			this._inventoryItemVersion = inventoryItemVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemEntryMvoStateEventId other = obj as InventoryItemEntryMvoStateEventId;
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

        public static bool operator ==(InventoryItemEntryMvoStateEventId obj1, InventoryItemEntryMvoStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InventoryItemEntryMvoStateEventId obj1, InventoryItemEntryMvoStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "InventoryItemEntryId: " + this.InventoryItemEntryId + ", "
                + "InventoryItemVersion: " + this.InventoryItemVersion + ", "
                ;
        }
	}

}


