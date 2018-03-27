﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Picklist
{

	public class PicklistRoleEventId
	{

		private string _picklistId;

		public virtual string PicklistId { 
			get { return this._picklistId; } 
			set { _picklistId = value; } 
		}

		private PartyRoleId _partyRoleId = new PartyRoleId();

		public virtual PartyRoleId PartyRoleId { 
			get { return this._partyRoleId; } 
			set { _partyRoleId = value; } 
		}

		private long _picklistVersion;

		public virtual long PicklistVersion { 
			get { return this._picklistVersion; } 
			set { _picklistVersion = value; } 
		}


        #region  Flattened Properties


		protected internal virtual string PartyRoleIdPartyId {
			get { return PartyRoleId.PartyId; }
			set { PartyRoleId.PartyId = value; }
		}

		protected internal virtual string PartyRoleIdRoleTypeId {
			get { return PartyRoleId.RoleTypeId; }
			set { PartyRoleId.RoleTypeId = value; }
		}

        #endregion

		public PicklistRoleEventId ()
		{
		}

		public PicklistRoleEventId (string picklistId, PartyRoleId partyRoleId, long picklistVersion)
		{
			this._picklistId = picklistId;
			this._partyRoleId = partyRoleId;
			this._picklistVersion = picklistVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			PicklistRoleEventId other = obj as PicklistRoleEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.PicklistId, other.PicklistId)
				&& Object.Equals (this.PartyRoleId, other.PartyRoleId)
				&& Object.Equals (this.PicklistVersion, other.PicklistVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.PicklistId != null) {
				hash += 13 * this.PicklistId.GetHashCode ();
			}
			if (this.PartyRoleId != null) {
				hash += 13 * this.PartyRoleId.GetHashCode ();
			}
			if (this.PicklistVersion != null) {
				hash += 13 * this.PicklistVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(PicklistRoleEventId obj1, PicklistRoleEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(PicklistRoleEventId obj1, PicklistRoleEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "PicklistId: " + this.PicklistId + ", "
                + "PartyRoleId: " + this.PartyRoleId + ", "
                + "PicklistVersion: " + this.PicklistVersion + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "PicklistId", "PartyRoleIdPartyId", "PartyRoleIdRoleTypeId", "PicklistVersion" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static PicklistRoleEventId()
        {
            var dict = new Dictionary<string, Type>();
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                dict.Add(FlattenedPropertyNames[i], FlattenedPropertyTypes[i]);
            }
            FlattenedPropertyTypeDictionary = dict;
        }

        protected internal void ForEachFlattenedProperty(Action<string, object> act)
        {
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                string pn = FlattenedPropertyNames[i];
                if (Char.IsLower(pn[0])) { pn = Char.ToUpper(pn[0]) + pn.Substring(1); }
                var m = this.GetType().GetProperty(pn, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                object pv = m.GetValue(this);
                act(pn, pv);
            }
        }

        protected internal void SetFlattenedPropertyValues(params object[] values)
        {
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                string pn = FlattenedPropertyNames[i];
                if (Char.IsLower(pn[0])) { pn = Char.ToUpper(pn[0]) + pn.Substring(1); }
                var v = values[i];
                var m = this.GetType().GetProperty(pn, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                m.SetValue(this, v);
            }
        }
	}

}

