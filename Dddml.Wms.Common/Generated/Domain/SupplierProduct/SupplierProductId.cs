﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSupplierProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SupplierProduct;

namespace Dddml.Wms.Domain.SupplierProduct
{

	public class SupplierProductId
	{

		private string _productId;

		public virtual string ProductId { 
			get { return this._productId; } 
			set { _productId = value; } 
		}

		private string _partyId;

		public virtual string PartyId { 
			get { return this._partyId; } 
			set { _partyId = value; } 
		}

		private string _currencyUomId;

		public virtual string CurrencyUomId { 
			get { return this._currencyUomId; } 
			set { _currencyUomId = value; } 
		}

		private decimal? _minimumOrderQuantity;

		public virtual decimal? MinimumOrderQuantity { 
			get { return this._minimumOrderQuantity; } 
			set { _minimumOrderQuantity = value; } 
		}


        #region  Flattened Properties


        #endregion

		public SupplierProductId ()
		{
		}

		public SupplierProductId (string productId, string partyId, string currencyUomId, decimal? minimumOrderQuantity)
		{
			this._productId = productId;
			this._partyId = partyId;
			this._currencyUomId = currencyUomId;
			this._minimumOrderQuantity = minimumOrderQuantity;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			SupplierProductId other = obj as SupplierProductId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ProductId, other.ProductId)
				&& Object.Equals (this.PartyId, other.PartyId)
				&& Object.Equals (this.CurrencyUomId, other.CurrencyUomId)
				&& Object.Equals (this.MinimumOrderQuantity, other.MinimumOrderQuantity)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ProductId != null) {
				hash += 13 * this.ProductId.GetHashCode ();
			}
			if (this.PartyId != null) {
				hash += 13 * this.PartyId.GetHashCode ();
			}
			if (this.CurrencyUomId != null) {
				hash += 13 * this.CurrencyUomId.GetHashCode ();
			}
			if (this.MinimumOrderQuantity != null) {
				hash += 13 * this.MinimumOrderQuantity.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(SupplierProductId obj1, SupplierProductId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(SupplierProductId obj1, SupplierProductId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "ProductId: " + this.ProductId + ", "
                + "PartyId: " + this.PartyId + ", "
                + "CurrencyUomId: " + this.CurrencyUomId + ", "
                + "MinimumOrderQuantity: " + this.MinimumOrderQuantity + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "ProductId", "PartyId", "CurrencyUomId", "MinimumOrderQuantity" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(decimal?) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static SupplierProductId()
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


