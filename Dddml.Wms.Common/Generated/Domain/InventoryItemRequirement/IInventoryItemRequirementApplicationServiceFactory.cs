﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirement
{

    public partial interface IInventoryItemRequirementApplicationServiceFactory
    {

        IInventoryItemRequirementApplicationService InventoryItemRequirementApplicationService { get; }

        ICreateInventoryItemRequirement NewCreateInventoryItemRequirement();

        IMergePatchInventoryItemRequirement NewMergePatchInventoryItemRequirement();

        IDeleteInventoryItemRequirement NewDeleteInventoryItemRequirement();
    }


}

