﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Audience;

namespace Dddml.Wms.Domain.Audience
{

	public class AudienceStateEventId
	{

		private string _clientId;

		public virtual string ClientId { 
			get { return this._clientId; } 
			internal set { _clientId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			internal set { _version = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal AudienceStateEventId ()
		{
		}

		public AudienceStateEventId (string clientId, long version)
		{
			this._clientId = clientId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AudienceStateEventId other = obj as AudienceStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ClientId, other.ClientId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ClientId != null) {
				hash += 13 * this.ClientId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(AudienceStateEventId obj1, AudienceStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(AudienceStateEventId obj1, AudienceStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}


