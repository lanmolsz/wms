﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryPostingRuleDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryPostingRule;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryPostingRule
{

	public class InventoryPostingRuleStateEventId
	{

		private string _inventoryPostingRuleId;

		public virtual string InventoryPostingRuleId { 
			get { return this._inventoryPostingRuleId; } 
			internal set { _inventoryPostingRuleId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			internal set { _version = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal InventoryPostingRuleStateEventId ()
		{
		}

		public InventoryPostingRuleStateEventId (string inventoryPostingRuleId, long version)
		{
			this._inventoryPostingRuleId = inventoryPostingRuleId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryPostingRuleStateEventId other = obj as InventoryPostingRuleStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InventoryPostingRuleId, other.InventoryPostingRuleId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InventoryPostingRuleId != null) {
				hash += 13 * this.InventoryPostingRuleId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(InventoryPostingRuleStateEventId obj1, InventoryPostingRuleStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InventoryPostingRuleStateEventId obj1, InventoryPostingRuleStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "InventoryPostingRuleId: " + this.InventoryPostingRuleId + ", "
                + "Version: " + this.Version + ", "
                ;
        }
	}

}


