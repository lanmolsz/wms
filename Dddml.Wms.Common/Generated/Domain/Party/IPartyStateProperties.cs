﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePartyDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Party;

namespace Dddml.Wms.Domain.Party
{

	public interface IPartyStateProperties
	{
		string PartyId { get; set; }

		string PartyTypeId { get; set; }

		string PrimaryRoleTypeId { get; set; }

		string OrganizationName { get; set; }

		string Description { get; set; }

		string Type { get; set; }

		bool IsSummary { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

	}

}
