﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateItemIssuanceMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ItemIssuanceMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ItemIssuanceMvo
{

	public class ItemIssuanceMvoEventId
	{

		private ShipmentItemIssuanceId _shipmentItemIssuanceId = new ShipmentItemIssuanceId();

		public virtual ShipmentItemIssuanceId ShipmentItemIssuanceId { 
			get { return this._shipmentItemIssuanceId; } 
			set { _shipmentItemIssuanceId = value; } 
		}

		private long _shipmentVersion;

		public virtual long ShipmentVersion { 
			get { return this._shipmentVersion; } 
			set { _shipmentVersion = value; } 
		}


        #region  Flattened Properties


		protected internal virtual string ShipmentItemIssuanceIdShipmentId {
			get { return ShipmentItemIssuanceId.ShipmentId; }
			set { ShipmentItemIssuanceId.ShipmentId = value; }
		}

		protected internal virtual string ShipmentItemIssuanceIdItemIssuanceSeqId {
			get { return ShipmentItemIssuanceId.ItemIssuanceSeqId; }
			set { ShipmentItemIssuanceId.ItemIssuanceSeqId = value; }
		}

        #endregion

		public ItemIssuanceMvoEventId ()
		{
		}

		public ItemIssuanceMvoEventId (ShipmentItemIssuanceId shipmentItemIssuanceId, long shipmentVersion)
		{
			this._shipmentItemIssuanceId = shipmentItemIssuanceId;
			this._shipmentVersion = shipmentVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			ItemIssuanceMvoEventId other = obj as ItemIssuanceMvoEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ShipmentItemIssuanceId, other.ShipmentItemIssuanceId)
				&& Object.Equals (this.ShipmentVersion, other.ShipmentVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ShipmentItemIssuanceId != null) {
				hash += 13 * this.ShipmentItemIssuanceId.GetHashCode ();
			}
			if (this.ShipmentVersion != null) {
				hash += 13 * this.ShipmentVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(ItemIssuanceMvoEventId obj1, ItemIssuanceMvoEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(ItemIssuanceMvoEventId obj1, ItemIssuanceMvoEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "ShipmentItemIssuanceId: " + this.ShipmentItemIssuanceId + ", "
                + "ShipmentVersion: " + this.ShipmentVersion + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "ShipmentItemIssuanceIdShipmentId", "ShipmentItemIssuanceIdItemIssuanceSeqId", "ShipmentVersion" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static ItemIssuanceMvoEventId()
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

