﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Permission;

namespace Dddml.Wms.Domain.Permission
{

	public class PermissionStateEventIdDto
	{

		public PermissionStateEventIdDto()
		{
		}

        public virtual PermissionStateEventId ToPermissionStateEventId()
        {
            PermissionStateEventId v = new PermissionStateEventId();
            v.PermissionId = this.PermissionId;
            v.Version = this.Version;
            return v;
        }

		public virtual string PermissionId { 
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

			PermissionStateEventIdDto other = obj as PermissionStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.PermissionId, other.PermissionId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.PermissionId != null) {
				hash += 13 * this.PermissionId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

	}

}


