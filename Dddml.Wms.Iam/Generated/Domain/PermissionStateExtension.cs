﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Permission;

namespace Dddml.Wms.Domain.Permission
{

	public static partial class PermissionStateExtension
	{

        public static IPermissionCommand ToCreateOrMergePatchPermission(this PermissionState state)
        {
            return state.ToCreateOrMergePatchPermission<CreatePermission, MergePatchPermission>();
        }

        public static DeletePermission ToDeletePermission(this PermissionState state)
        {
            return state.ToDeletePermission<DeletePermission>();
        }

        public static MergePatchPermission ToMergePatchPermission(this PermissionState state)
        {
            return state.ToMergePatchPermission<MergePatchPermission>();
        }

        public static CreatePermission ToCreatePermission(this PermissionState state)
        {
            return state.ToCreatePermission<CreatePermission>();
        }
		

	}

}

