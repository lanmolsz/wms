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

	public interface IPicklistStateProperties
	{
		string PicklistId { get; set; }

		string Description { get; set; }

		string FacilityId { get; set; }

		string ShipmentMethodTypeId { get; set; }

		string StatusId { get; set; }

		DateTime? PicklistDate { get; set; }

		long? PickwaveId { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

	}

}
