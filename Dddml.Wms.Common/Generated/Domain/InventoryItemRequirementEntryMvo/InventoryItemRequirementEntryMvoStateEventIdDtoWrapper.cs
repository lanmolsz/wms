﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirementEntryMvo;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirementEntryMvo
{

	public class InventoryItemRequirementEntryMvoStateEventIdDtoWrapper : InventoryItemRequirementEntryMvoStateEventIdDto
	{

        private InventoryItemRequirementEntryMvoStateEventId _value = new InventoryItemRequirementEntryMvoStateEventId();

		public InventoryItemRequirementEntryMvoStateEventIdDtoWrapper()
		{
		}

		public InventoryItemRequirementEntryMvoStateEventIdDtoWrapper(InventoryItemRequirementEntryMvoStateEventId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override InventoryItemRequirementEntryMvoStateEventId ToInventoryItemRequirementEntryMvoStateEventId()
        {
            return this._value;
        }

		public override InventoryItemRequirementEntryIdDto InventoryItemRequirementEntryId { 
			get { return new InventoryItemRequirementEntryIdDtoWrapper(_value.InventoryItemRequirementEntryId); } 
			set { _value.InventoryItemRequirementEntryId = value.ToInventoryItemRequirementEntryId(); } 
		}

		public override long InventoryItemRequirementVersion { 
			get { return _value.InventoryItemRequirementVersion; } 
			set { _value.InventoryItemRequirementVersion = value; } 
		}


	}

}

