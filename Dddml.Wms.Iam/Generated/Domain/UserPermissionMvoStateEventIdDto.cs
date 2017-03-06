﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserPermissionMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserPermissionMvo
{

	public class UserPermissionMvoStateEventIdDto
	{

		public UserPermissionMvoStateEventIdDto()
		{
		}

        public virtual UserPermissionMvoStateEventId ToUserPermissionMvoStateEventId()
        {
            UserPermissionMvoStateEventId v = new UserPermissionMvoStateEventId();
            v.UserPermissionId = this.UserPermissionId.ToUserPermissionId();
            v.UserVersion = this.UserVersion;
            return v;
        }

		private UserPermissionIdDto _userPermissionId = new UserPermissionIdDto();

		public virtual UserPermissionIdDto UserPermissionId { 
			get { return this._userPermissionId; } 
			set { this._userPermissionId = value; } 
		}

		public virtual long UserVersion { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserPermissionMvoStateEventIdDto other = obj as UserPermissionMvoStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.UserPermissionId, other.UserPermissionId)
				&& Object.Equals (this.UserVersion, other.UserVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.UserPermissionId != null) {
				hash += 13 * this.UserPermissionId.GetHashCode ();
			}
			if (this.UserVersion != null) {
				hash += 13 * this.UserVersion.GetHashCode ();
			}
			return hash;
		}

	}

}


