﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstance;

namespace Dddml.Wms.Domain.AttributeSetInstance
{

	public class AttributeSetInstanceStateEventId
	{

		private string _attributeSetInstanceId;

		public virtual string AttributeSetInstanceId { 
			get { return this._attributeSetInstanceId; } 
			internal set { _attributeSetInstanceId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			internal set { _version = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal AttributeSetInstanceStateEventId ()
		{
		}

		public AttributeSetInstanceStateEventId (string attributeSetInstanceId, long version)
		{
			this._attributeSetInstanceId = attributeSetInstanceId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeSetInstanceStateEventId other = obj as AttributeSetInstanceStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeSetInstanceId, other.AttributeSetInstanceId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeSetInstanceId != null) {
				hash += 13 * this.AttributeSetInstanceId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(AttributeSetInstanceStateEventId obj1, AttributeSetInstanceStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(AttributeSetInstanceStateEventId obj1, AttributeSetInstanceStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "AttributeSetInstanceId: " + this.AttributeSetInstanceId + ", "
                + "Version: " + this.Version + ", "
                ;
        }
	}

}


