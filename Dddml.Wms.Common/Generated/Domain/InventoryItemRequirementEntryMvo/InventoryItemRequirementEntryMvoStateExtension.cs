﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirementEntryMvo;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirementEntryMvo
{

	public static partial class InventoryItemRequirementEntryMvoStateExtension
	{

        public static IInventoryItemRequirementEntryMvoCommand ToCreateOrMergePatchInventoryItemRequirementEntryMvo(this InventoryItemRequirementEntryMvoState state)
        {
            return state.ToCreateOrMergePatchInventoryItemRequirementEntryMvo<CreateInventoryItemRequirementEntryMvo, MergePatchInventoryItemRequirementEntryMvo>();
        }

        public static DeleteInventoryItemRequirementEntryMvo ToDeleteInventoryItemRequirementEntryMvo(this InventoryItemRequirementEntryMvoState state)
        {
            return state.ToDeleteInventoryItemRequirementEntryMvo<DeleteInventoryItemRequirementEntryMvo>();
        }

        public static MergePatchInventoryItemRequirementEntryMvo ToMergePatchInventoryItemRequirementEntryMvo(this InventoryItemRequirementEntryMvoState state)
        {
            return state.ToMergePatchInventoryItemRequirementEntryMvo<MergePatchInventoryItemRequirementEntryMvo>();
        }

        public static CreateInventoryItemRequirementEntryMvo ToCreateInventoryItemRequirementEntryMvo(this InventoryItemRequirementEntryMvoState state)
        {
            return state.ToCreateInventoryItemRequirementEntryMvo<CreateInventoryItemRequirementEntryMvo>();
        }
		

	}

}

