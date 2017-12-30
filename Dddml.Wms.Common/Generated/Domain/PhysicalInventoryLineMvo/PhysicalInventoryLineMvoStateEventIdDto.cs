﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventoryLineMvo;
using Dddml.Wms.Domain.PhysicalInventory;

namespace Dddml.Wms.Domain.PhysicalInventoryLineMvo
{

	public class PhysicalInventoryLineMvoStateEventIdDto
	{

		public PhysicalInventoryLineMvoStateEventIdDto()
		{
		}

        public virtual PhysicalInventoryLineMvoStateEventId ToPhysicalInventoryLineMvoStateEventId()
        {
            PhysicalInventoryLineMvoStateEventId v = new PhysicalInventoryLineMvoStateEventId();
            v.PhysicalInventoryLineId = this.PhysicalInventoryLineId.ToPhysicalInventoryLineId();
            v.PhysicalInventoryVersion = this.PhysicalInventoryVersion;
            return v;
        }

		private PhysicalInventoryLineIdDto _physicalInventoryLineId = new PhysicalInventoryLineIdDto();

		public virtual PhysicalInventoryLineIdDto PhysicalInventoryLineId { 
			get { return this._physicalInventoryLineId; } 
			set { this._physicalInventoryLineId = value; } 
		}

		public virtual long PhysicalInventoryVersion { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			PhysicalInventoryLineMvoStateEventIdDto other = obj as PhysicalInventoryLineMvoStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.PhysicalInventoryLineId, other.PhysicalInventoryLineId)
				&& Object.Equals (this.PhysicalInventoryVersion, other.PhysicalInventoryVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.PhysicalInventoryLineId != null) {
				hash += 13 * this.PhysicalInventoryLineId.GetHashCode ();
			}
			if (this.PhysicalInventoryVersion != null) {
				hash += 13 * this.PhysicalInventoryVersion.GetHashCode ();
			}
			return hash;
		}

	}

}

