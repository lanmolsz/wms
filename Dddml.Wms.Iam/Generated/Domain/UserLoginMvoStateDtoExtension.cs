﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserLoginMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserLoginMvo
{

	public static partial class UserLoginMvoStateDtoExtension
	{

        public static IUserLoginMvoCommand ToCreateOrMergePatchUserLoginMvo(this UserLoginMvoStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchUserLoginMvo<CreateUserLoginMvoDto, MergePatchUserLoginMvoDto>();
        }

        public static DeleteUserLoginMvoDto ToDeleteUserLoginMvo(this UserLoginMvoStateDtoWrapper state)
        {
            return state.ToDeleteUserLoginMvo<DeleteUserLoginMvoDto>();
        }

        public static MergePatchUserLoginMvoDto ToMergePatchUserLoginMvo(this UserLoginMvoStateDtoWrapper state)
        {
            return state.ToMergePatchUserLoginMvo<MergePatchUserLoginMvoDto>();
        }

        public static CreateUserLoginMvoDto ToCreateUserLoginMvo(this UserLoginMvoStateDtoWrapper state)
        {
            return state.ToCreateUserLoginMvo<CreateUserLoginMvoDto>();
        }
		

	}

}

