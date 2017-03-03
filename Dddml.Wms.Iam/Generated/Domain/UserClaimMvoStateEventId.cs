﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public class UserClaimMvoStateEventId
	{

		private UserClaimId _userClaimId = new UserClaimId();

		public virtual UserClaimId UserClaimId { 
			get { return this._userClaimId; } 
			internal set { _userClaimId = value; } 
		}

		private long _userVersion;

		public virtual long UserVersion { 
			get { return this._userVersion; } 
			internal set { _userVersion = value; } 
		}


        #region  Flattened Properties


		public virtual string UserClaimIdUserId {
			get { return UserClaimId.UserId; }
			internal set { UserClaimId.UserId = value; }
		}

		public virtual int UserClaimIdClaimId {
			get { return UserClaimId.ClaimId; }
			internal set { UserClaimId.ClaimId = value; }
		}

        #endregion

		internal UserClaimMvoStateEventId ()
		{
		}

		public UserClaimMvoStateEventId (UserClaimId userClaimId, long userVersion)
		{
			this._userClaimId = userClaimId;
			this._userVersion = userVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserClaimMvoStateEventId other = obj as UserClaimMvoStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.UserClaimId, other.UserClaimId)
				&& Object.Equals (this.UserVersion, other.UserVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.UserClaimId != null) {
				hash += 13 * this.UserClaimId.GetHashCode ();
			}
			if (this.UserVersion != null) {
				hash += 13 * this.UserVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(UserClaimMvoStateEventId obj1, UserClaimMvoStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(UserClaimMvoStateEventId obj1, UserClaimMvoStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}

