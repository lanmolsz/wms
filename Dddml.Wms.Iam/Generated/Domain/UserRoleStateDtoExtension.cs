﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

	public static partial class UserRoleStateDtoExtension
	{

        public static IUserRoleCommand ToCreateOrMergePatchUserRole(this UserRoleStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchUserRole<CreateUserRoleDto, MergePatchUserRoleDto>();
        }

        public static RemoveUserRoleDto ToRemoveUserRole(this UserRoleStateDtoWrapper state)
        {
            return state.ToRemoveUserRole<RemoveUserRoleDto>();
        }

        public static MergePatchUserRoleDto ToMergePatchUserRole(this UserRoleStateDtoWrapper state)
        {
            return state.ToMergePatchUserRole<MergePatchUserRoleDto>();
        }

        public static CreateUserRoleDto ToCreateUserRole(this UserRoleStateDtoWrapper state)
        {
            return state.ToCreateUserRole<CreateUserRoleDto>();
        }
		

	}

}

