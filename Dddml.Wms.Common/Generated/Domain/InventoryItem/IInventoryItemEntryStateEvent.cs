﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{
	public interface IInventoryItemEntryStateEvent : IEvent, IStateEventDto, IGlobalIdentity<InventoryItemEntryEventId>, ICreated<string>
	{
		InventoryItemEntryEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		decimal? OnHandQuantity { get; set; }

		decimal? InTransitQuantity { get; set; }

		decimal? ReservedQuantity { get; set; }

		decimal? OccupiedQuantity { get; set; }

		decimal? VirtualQuantity { get; set; }

		InventoryItemSourceInfo Source { get; set; }

		// Outer Id:
		//InventoryItemId InventoryItemId { get; set; }

	}

	public interface IInventoryItemEntryStateCreated : IInventoryItemEntryStateEvent//, IInventoryItemEntryStateProperties
	{
	
	}

}

