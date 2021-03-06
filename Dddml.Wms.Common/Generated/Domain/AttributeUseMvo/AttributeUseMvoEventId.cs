﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeUseMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeUseMvo;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeUseMvo
{

	public class AttributeUseMvoEventId
	{

		private AttributeSetAttributeUseId _attributeSetAttributeUseId = new AttributeSetAttributeUseId();

		public virtual AttributeSetAttributeUseId AttributeSetAttributeUseId { 
			get { return this._attributeSetAttributeUseId; } 
			set { _attributeSetAttributeUseId = value; } 
		}

		private long _attributeSetVersion;

		public virtual long AttributeSetVersion { 
			get { return this._attributeSetVersion; } 
			set { _attributeSetVersion = value; } 
		}


        #region  Flattened Properties


		protected internal virtual string AttributeSetAttributeUseIdAttributeSetId {
			get { return AttributeSetAttributeUseId.AttributeSetId; }
			set { AttributeSetAttributeUseId.AttributeSetId = value; }
		}

		protected internal virtual string AttributeSetAttributeUseIdAttributeId {
			get { return AttributeSetAttributeUseId.AttributeId; }
			set { AttributeSetAttributeUseId.AttributeId = value; }
		}

        #endregion

		public AttributeUseMvoEventId ()
		{
		}

		public AttributeUseMvoEventId (AttributeSetAttributeUseId attributeSetAttributeUseId, long attributeSetVersion)
		{
			this._attributeSetAttributeUseId = attributeSetAttributeUseId;
			this._attributeSetVersion = attributeSetVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeUseMvoEventId other = obj as AttributeUseMvoEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeSetAttributeUseId, other.AttributeSetAttributeUseId)
				&& Object.Equals (this.AttributeSetVersion, other.AttributeSetVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeSetAttributeUseId != null) {
				hash += 13 * this.AttributeSetAttributeUseId.GetHashCode ();
			}
			if (this.AttributeSetVersion != null) {
				hash += 13 * this.AttributeSetVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(AttributeUseMvoEventId obj1, AttributeUseMvoEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(AttributeUseMvoEventId obj1, AttributeUseMvoEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "AttributeSetAttributeUseId: " + this.AttributeSetAttributeUseId + ", "
                + "AttributeSetVersion: " + this.AttributeSetVersion + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "AttributeSetAttributeUseIdAttributeSetId", "AttributeSetAttributeUseIdAttributeId", "AttributeSetVersion" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static AttributeUseMvoEventId()
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


