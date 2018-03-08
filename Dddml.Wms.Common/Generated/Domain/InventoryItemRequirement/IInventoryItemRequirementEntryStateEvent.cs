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
	public interface IInventoryItemRequirementEntryStateEvent : IEvent, IStateEventDto, IGlobalIdentity<InventoryItemRequirementEntryEventId>, ICreated<string>
	{
		InventoryItemRequirementEntryEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		decimal? Quantity { get; set; }

		InventoryPRTriggeredId SourceEventId { get; set; }

		// Outer Id:
		//InventoryItemId InventoryItemRequirementId { get; set; }

	}

	public interface IInventoryItemRequirementEntryStateCreated : IInventoryItemRequirementEntryStateEvent//, IInventoryItemRequirementEntryStateProperties
	{
	
	}

}

