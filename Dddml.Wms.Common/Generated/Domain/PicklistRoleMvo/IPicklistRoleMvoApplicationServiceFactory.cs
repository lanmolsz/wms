﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistRoleMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistRoleMvo;
using Dddml.Wms.Domain.Picklist;

namespace Dddml.Wms.Domain.PicklistRoleMvo
{

    public partial interface IPicklistRoleMvoApplicationServiceFactory
    {

        IPicklistRoleMvoApplicationService PicklistRoleMvoApplicationService { get; }

        ICreatePicklistRoleMvo NewCreatePicklistRoleMvo();

        IMergePatchPicklistRoleMvo NewMergePatchPicklistRoleMvo();

        IDeletePicklistRoleMvo NewDeletePicklistRoleMvo();
    }


}
