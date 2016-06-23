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

	public class UserLoginMvoStateEventId
	{

		private UserLoginId _userLoginId = new UserLoginId();

		public virtual UserLoginId UserLoginId { 
			get { return this._userLoginId; } 
			internal set { _userLoginId = value; } 
		}

		private long _userVersion;

		public virtual long UserVersion { 
			get { return this._userVersion; } 
			internal set { _userVersion = value; } 
		}


        #region  Flattened Properties


		public virtual string UserLoginIdUserId {
			get { return UserLoginId.UserId; }
			internal set { UserLoginId.UserId = value; }
		}

		public virtual string UserLoginIdLoginKeyLoginProvider {
			get { return UserLoginId.LoginKey.LoginProvider; }
			internal set { UserLoginId.LoginKey.LoginProvider = value; }
		}

		public virtual string UserLoginIdLoginKeyProviderKey {
			get { return UserLoginId.LoginKey.ProviderKey; }
			internal set { UserLoginId.LoginKey.ProviderKey = value; }
		}

        #endregion

		internal UserLoginMvoStateEventId ()
		{
		}

		public UserLoginMvoStateEventId (UserLoginId userLoginId, long userVersion)
		{
			this._userLoginId = userLoginId;
			this._userVersion = userVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserLoginMvoStateEventId other = obj as UserLoginMvoStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.UserLoginId, other.UserLoginId)
				&& Object.Equals (this.UserVersion, other.UserVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.UserLoginId != null) {
				hash += 13 * this.UserLoginId.GetHashCode ();
			}
			if (this.UserVersion != null) {
				hash += 13 * this.UserVersion.GetHashCode ();
			}
			return hash;
		}

	}

}

