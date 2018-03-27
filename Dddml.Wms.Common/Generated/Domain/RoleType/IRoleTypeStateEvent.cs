﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRoleTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RoleType;

namespace Dddml.Wms.Domain.RoleType
{
	public interface IRoleTypeStateEvent : IEvent, IStateEventDto, IGlobalIdentity<RoleTypeEventId>, ICreated<string>
	{
		RoleTypeEventId RoleTypeEventId { get; }

        bool ReadOnly { get; set; }

		string ParentTypeId { get; set; }

		string HasTable { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }

	}

	public interface IRoleTypeStateCreated : IRoleTypeStateEvent//, IRoleTypeStateProperties
	{
	
	}


	public interface IRoleTypeStateMergePatched : IRoleTypeStateEvent//, IRoleTypeStateProperties
	{
		bool IsPropertyParentTypeIdRemoved { get; set; }

		bool IsPropertyHasTableRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRoleTypeStateDeleted : IRoleTypeStateEvent
	{
	}


}
