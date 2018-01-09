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

	public class InventoryItemId
	{

		private string _productId;

		public virtual string ProductId { 
			get { return this._productId; } 
			internal set { _productId = value; } 
		}

		private string _locatorId;

		public virtual string LocatorId { 
			get { return this._locatorId; } 
			internal set { _locatorId = value; } 
		}

		private string _attributeSetInstanceId;

		public virtual string AttributeSetInstanceId { 
			get { return this._attributeSetInstanceId; } 
			internal set { _attributeSetInstanceId = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal InventoryItemId ()
		{
		}

		public InventoryItemId (string productId, string locatorId, string attributeSetInstanceId)
		{
			this._productId = productId;
			this._locatorId = locatorId;
			this._attributeSetInstanceId = attributeSetInstanceId;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemId other = obj as InventoryItemId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ProductId, other.ProductId)
				&& Object.Equals (this.LocatorId, other.LocatorId)
				&& Object.Equals (this.AttributeSetInstanceId, other.AttributeSetInstanceId)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ProductId != null) {
				hash += 13 * this.ProductId.GetHashCode ();
			}
			if (this.LocatorId != null) {
				hash += 13 * this.LocatorId.GetHashCode ();
			}
			if (this.AttributeSetInstanceId != null) {
				hash += 13 * this.AttributeSetInstanceId.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(InventoryItemId obj1, InventoryItemId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InventoryItemId obj1, InventoryItemId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "ProductId: " + this.ProductId + ", "
                + "LocatorId: " + this.LocatorId + ", "
                + "AttributeSetInstanceId: " + this.AttributeSetInstanceId + ", "
                ;
        }
	}

}


