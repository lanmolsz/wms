﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.PhysicalInventory
{

	public interface IPhysicalInventoryStateProperties
	{
		string DocumentNumber { get; set; }

		string DocumentStatusId { get; set; }

		string WarehouseId { get; set; }

		string LocatorIdPattern { get; set; }

		string ProductIdPattern { get; set; }

		bool Posted { get; set; }

		bool Processed { get; set; }

		string Processing { get; set; }

		string DocumentTypeId { get; set; }

		DateTime? MovementDate { get; set; }

		string Description { get; set; }

		bool IsApproved { get; set; }

		decimal ApprovalAmount { get; set; }

		bool IsQuantityUpdated { get; set; }

		string ReversalDocumentNumber { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

	}

}
