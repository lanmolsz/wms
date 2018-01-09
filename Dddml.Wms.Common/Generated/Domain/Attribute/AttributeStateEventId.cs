﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{

	public class AttributeStateEventId
	{

		private string _attributeId;

		public virtual string AttributeId { 
			get { return this._attributeId; } 
			internal set { _attributeId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			internal set { _version = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal AttributeStateEventId ()
		{
		}

		public AttributeStateEventId (string attributeId, long version)
		{
			this._attributeId = attributeId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeStateEventId other = obj as AttributeStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeId, other.AttributeId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeId != null) {
				hash += 13 * this.AttributeId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(AttributeStateEventId obj1, AttributeStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(AttributeStateEventId obj1, AttributeStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "AttributeId: " + this.AttributeId + ", "
                + "Version: " + this.Version + ", "
                ;
        }
	}

}


