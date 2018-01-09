﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public class RolePermissionId
	{

		private string _roleId;

		public virtual string RoleId { 
			get { return this._roleId; } 
			internal set { _roleId = value; } 
		}

		private string _permissionId;

		public virtual string PermissionId { 
			get { return this._permissionId; } 
			internal set { _permissionId = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal RolePermissionId ()
		{
		}

		public RolePermissionId (string roleId, string permissionId)
		{
			this._roleId = roleId;
			this._permissionId = permissionId;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			RolePermissionId other = obj as RolePermissionId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.RoleId, other.RoleId)
				&& Object.Equals (this.PermissionId, other.PermissionId)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.RoleId != null) {
				hash += 13 * this.RoleId.GetHashCode ();
			}
			if (this.PermissionId != null) {
				hash += 13 * this.PermissionId.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(RolePermissionId obj1, RolePermissionId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(RolePermissionId obj1, RolePermissionId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "RoleId: " + this.RoleId + ", "
                + "PermissionId: " + this.PermissionId + ", "
                ;
        }
	}

}


