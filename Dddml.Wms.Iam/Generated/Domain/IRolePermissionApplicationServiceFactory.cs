﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RolePermission;

namespace Dddml.Wms.Domain.RolePermission
{

    public partial interface IRolePermissionApplicationServiceFactory
    {

        IRolePermissionApplicationService RolePermissionApplicationService { get; }

        ICreateRolePermission NewCreateRolePermission();

        IMergePatchRolePermission NewMergePatchRolePermission();

        IDeleteRolePermission NewDeleteRolePermission();
    }


}

