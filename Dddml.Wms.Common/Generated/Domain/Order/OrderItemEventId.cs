﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public class OrderItemEventId
	{

		private string _orderId;

		public virtual string OrderId { 
			get { return this._orderId; } 
			set { _orderId = value; } 
		}

		private string _orderItemSeqId;

		public virtual string OrderItemSeqId { 
			get { return this._orderItemSeqId; } 
			set { _orderItemSeqId = value; } 
		}

		private long _orderVersion;

		public virtual long OrderVersion { 
			get { return this._orderVersion; } 
			set { _orderVersion = value; } 
		}


        #region  Flattened Properties


        #endregion

		public OrderItemEventId ()
		{
		}

		public OrderItemEventId (string orderId, string orderItemSeqId, long orderVersion)
		{
			this._orderId = orderId;
			this._orderItemSeqId = orderItemSeqId;
			this._orderVersion = orderVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			OrderItemEventId other = obj as OrderItemEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.OrderId, other.OrderId)
				&& Object.Equals (this.OrderItemSeqId, other.OrderItemSeqId)
				&& Object.Equals (this.OrderVersion, other.OrderVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.OrderId != null) {
				hash += 13 * this.OrderId.GetHashCode ();
			}
			if (this.OrderItemSeqId != null) {
				hash += 13 * this.OrderItemSeqId.GetHashCode ();
			}
			if (this.OrderVersion != null) {
				hash += 13 * this.OrderVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(OrderItemEventId obj1, OrderItemEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(OrderItemEventId obj1, OrderItemEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "OrderId: " + this.OrderId + ", "
                + "OrderItemSeqId: " + this.OrderItemSeqId + ", "
                + "OrderVersion: " + this.OrderVersion + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "OrderId", "OrderItemSeqId", "OrderVersion" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static OrderItemEventId()
        {
            var dict = new Dictionary<string, Type>();
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                dict.Add(FlattenedPropertyNames[i], FlattenedPropertyTypes[i]);
            }
            FlattenedPropertyTypeDictionary = dict;
        }

        protected internal void ForEachFlattenedProperty(Action<string, object> act)
        {
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                string pn = FlattenedPropertyNames[i];
                if (Char.IsLower(pn[0])) { pn = Char.ToUpper(pn[0]) + pn.Substring(1); }
                var m = this.GetType().GetProperty(pn, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                object pv = m.GetValue(this);
                act(pn, pv);
            }
        }

        protected internal void SetFlattenedPropertyValues(params object[] values)
        {
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                string pn = FlattenedPropertyNames[i];
                if (Char.IsLower(pn[0])) { pn = Char.ToUpper(pn[0]) + pn.Substring(1); }
                var v = values[i];
                var m = this.GetType().GetProperty(pn, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                m.SetValue(this, v);
            }
        }
	}

}


