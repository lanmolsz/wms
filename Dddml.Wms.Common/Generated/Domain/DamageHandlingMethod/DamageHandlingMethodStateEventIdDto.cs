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

	public class DamageHandlingMethodStateEventIdDto
	{

		public DamageHandlingMethodStateEventIdDto()
		{
		}

        public virtual DamageHandlingMethodStateEventId ToDamageHandlingMethodStateEventId()
        {
            DamageHandlingMethodStateEventId v = new DamageHandlingMethodStateEventId();
            v.DamageHandlingMethodId = this.DamageHandlingMethodId;
            v.Version = this.Version;
            return v;
        }

		public virtual string DamageHandlingMethodId { 
			get;
			set;
		}

		public virtual long Version { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			DamageHandlingMethodStateEventIdDto other = obj as DamageHandlingMethodStateEventIdDto;
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

	}

}


