﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderHeaderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderHeader;

namespace Dddml.Wms.Domain.OrderHeader
{

	public class OrderHeaderStateEventId
	{

		private string _orderId;

		public virtual string OrderId { 
			get { return this._orderId; } 
			internal set { _orderId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			internal set { _version = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal OrderHeaderStateEventId ()
		{
		}

		public OrderHeaderStateEventId (string orderId, long version)
		{
			this._orderId = orderId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			OrderHeaderStateEventId other = obj as OrderHeaderStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.OrderId, other.OrderId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.OrderId != null) {
				hash += 13 * this.OrderId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(OrderHeaderStateEventId obj1, OrderHeaderStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(OrderHeaderStateEventId obj1, OrderHeaderStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}


