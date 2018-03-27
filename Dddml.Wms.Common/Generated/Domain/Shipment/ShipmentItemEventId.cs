﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{

	public class ShipmentItemEventId
	{

		private string _shipmentId;

		public virtual string ShipmentId { 
			get { return this._shipmentId; } 
			set { _shipmentId = value; } 
		}

		private string _shipmentItemSeqId;

		public virtual string ShipmentItemSeqId { 
			get { return this._shipmentItemSeqId; } 
			set { _shipmentItemSeqId = value; } 
		}

		private long _shipmentVersion;

		public virtual long ShipmentVersion { 
			get { return this._shipmentVersion; } 
			set { _shipmentVersion = value; } 
		}


        #region  Flattened Properties


        #endregion

		public ShipmentItemEventId ()
		{
		}

		public ShipmentItemEventId (string shipmentId, string shipmentItemSeqId, long shipmentVersion)
		{
			this._shipmentId = shipmentId;
			this._shipmentItemSeqId = shipmentItemSeqId;
			this._shipmentVersion = shipmentVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			ShipmentItemEventId other = obj as ShipmentItemEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ShipmentId, other.ShipmentId)
				&& Object.Equals (this.ShipmentItemSeqId, other.ShipmentItemSeqId)
				&& Object.Equals (this.ShipmentVersion, other.ShipmentVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ShipmentId != null) {
				hash += 13 * this.ShipmentId.GetHashCode ();
			}
			if (this.ShipmentItemSeqId != null) {
				hash += 13 * this.ShipmentItemSeqId.GetHashCode ();
			}
			if (this.ShipmentVersion != null) {
				hash += 13 * this.ShipmentVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(ShipmentItemEventId obj1, ShipmentItemEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(ShipmentItemEventId obj1, ShipmentItemEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "ShipmentId: " + this.ShipmentId + ", "
                + "ShipmentItemSeqId: " + this.ShipmentItemSeqId + ", "
                + "ShipmentVersion: " + this.ShipmentVersion + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "ShipmentId", "ShipmentItemSeqId", "ShipmentVersion" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static ShipmentItemEventId()
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

