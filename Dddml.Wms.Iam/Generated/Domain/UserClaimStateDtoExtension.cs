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

	public static partial class UserClaimStateDtoExtension
	{

        public static IUserClaimCommand ToCreateOrMergePatchUserClaim(this UserClaimStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchUserClaim<CreateUserClaimDto, MergePatchUserClaimDto>();
        }

        public static RemoveUserClaimDto ToRemoveUserClaim(this UserClaimStateDtoWrapper state)
        {
            return state.ToRemoveUserClaim<RemoveUserClaimDto>();
        }

        public static MergePatchUserClaimDto ToMergePatchUserClaim(this UserClaimStateDtoWrapper state)
        {
            return state.ToMergePatchUserClaim<MergePatchUserClaimDto>();
        }

        public static CreateUserClaimDto ToCreateUserClaim(this UserClaimStateDtoWrapper state)
        {
            return state.ToCreateUserClaim<CreateUserClaimDto>();
        }
		

	}

}

