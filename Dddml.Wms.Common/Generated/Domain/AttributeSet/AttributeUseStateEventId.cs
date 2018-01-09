﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeSet
{

	public class AttributeUseStateEventId
	{

		private string _attributeSetId;

		public virtual string AttributeSetId { 
			get { return this._attributeSetId; } 
			internal set { _attributeSetId = value; } 
		}

		private string _attributeId;

		public virtual string AttributeId { 
			get { return this._attributeId; } 
			internal set { _attributeId = value; } 
		}

		private long _attributeSetVersion;

		public virtual long AttributeSetVersion { 
			get { return this._attributeSetVersion; } 
			internal set { _attributeSetVersion = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal AttributeUseStateEventId ()
		{
		}

		public AttributeUseStateEventId (string attributeSetId, string attributeId, long attributeSetVersion)
		{
			this._attributeSetId = attributeSetId;
			this._attributeId = attributeId;
			this._attributeSetVersion = attributeSetVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeUseStateEventId other = obj as AttributeUseStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeSetId, other.AttributeSetId)
				&& Object.Equals (this.AttributeId, other.AttributeId)
				&& Object.Equals (this.AttributeSetVersion, other.AttributeSetVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeSetId != null) {
				hash += 13 * this.AttributeSetId.GetHashCode ();
			}
			if (this.AttributeId != null) {
				hash += 13 * this.AttributeId.GetHashCode ();
			}
			if (this.AttributeSetVersion != null) {
				hash += 13 * this.AttributeSetVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(AttributeUseStateEventId obj1, AttributeUseStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(AttributeUseStateEventId obj1, AttributeUseStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "AttributeSetId: " + this.AttributeSetId + ", "
                + "AttributeId: " + this.AttributeId + ", "
                + "AttributeSetVersion: " + this.AttributeSetVersion + ", "
                ;
        }
	}

}


