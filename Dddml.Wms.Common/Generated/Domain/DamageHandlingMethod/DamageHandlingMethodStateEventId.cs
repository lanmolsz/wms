﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageHandlingMethodDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageHandlingMethod;

namespace Dddml.Wms.Domain.DamageHandlingMethod
{

	public class DamageHandlingMethodStateEventId
	{

		private string _damageHandlingMethodId;

		public virtual string DamageHandlingMethodId { 
			get { return this._damageHandlingMethodId; } 
			internal set { _damageHandlingMethodId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			internal set { _version = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal DamageHandlingMethodStateEventId ()
		{
		}

		public DamageHandlingMethodStateEventId (string damageHandlingMethodId, long version)
		{
			this._damageHandlingMethodId = damageHandlingMethodId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			DamageHandlingMethodStateEventId other = obj as DamageHandlingMethodStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.DamageHandlingMethodId, other.DamageHandlingMethodId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.DamageHandlingMethodId != null) {
				hash += 13 * this.DamageHandlingMethodId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(DamageHandlingMethodStateEventId obj1, DamageHandlingMethodStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(DamageHandlingMethodStateEventId obj1, DamageHandlingMethodStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "DamageHandlingMethodId: " + this.DamageHandlingMethodId + ", "
                + "Version: " + this.Version + ", "
                ;
        }
	}

}

