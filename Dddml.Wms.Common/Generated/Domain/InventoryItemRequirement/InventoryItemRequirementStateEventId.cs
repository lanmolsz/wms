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

	public class InventoryItemRequirementStateEventId
	{

		private InventoryItemId _inventoryItemRequirementId = new InventoryItemId();

		public virtual InventoryItemId InventoryItemRequirementId { 
			get { return this._inventoryItemRequirementId; } 
			internal set { _inventoryItemRequirementId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			internal set { _version = value; } 
		}


        #region  Flattened Properties


		public virtual string InventoryItemRequirementIdProductId {
			get { return InventoryItemRequirementId.ProductId; }
			internal set { InventoryItemRequirementId.ProductId = value; }
		}

		public virtual string InventoryItemRequirementIdLocatorId {
			get { return InventoryItemRequirementId.LocatorId; }
			internal set { InventoryItemRequirementId.LocatorId = value; }
		}

		public virtual string InventoryItemRequirementIdAttributeSetInstanceId {
			get { return InventoryItemRequirementId.AttributeSetInstanceId; }
			internal set { InventoryItemRequirementId.AttributeSetInstanceId = value; }
		}

        #endregion

		internal InventoryItemRequirementStateEventId ()
		{
		}

		public InventoryItemRequirementStateEventId (InventoryItemId inventoryItemRequirementId, long version)
		{
			this._inventoryItemRequirementId = inventoryItemRequirementId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemRequirementStateEventId other = obj as InventoryItemRequirementStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InventoryItemRequirementId, other.InventoryItemRequirementId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InventoryItemRequirementId != null) {
				hash += 13 * this.InventoryItemRequirementId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(InventoryItemRequirementStateEventId obj1, InventoryItemRequirementStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InventoryItemRequirementStateEventId obj1, InventoryItemRequirementStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "InventoryItemRequirementId: " + this.InventoryItemRequirementId + ", "
                + "Version: " + this.Version + ", "
                ;
        }
	}

}


