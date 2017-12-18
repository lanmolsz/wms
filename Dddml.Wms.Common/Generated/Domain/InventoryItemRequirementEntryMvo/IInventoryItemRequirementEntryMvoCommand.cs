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
	public interface IInventoryItemRequirementEntryMvoCommand : IAggregateCommand<InventoryItemRequirementEntryId, long>, ICommandDto
	{
		long InventoryItemRequirementVersion { get; set; }

		InventoryItemRequirementEntryId InventoryItemRequirementEntryId { get; set; }

	}


	public interface ICreateOrMergePatchOrDeleteInventoryItemRequirementEntryMvo : IInventoryItemRequirementEntryMvoCommand
	{

		decimal? Quantity { get; set; }

		InventoryPRTriggeredId SourceEventId { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		decimal? InventoryItemRequirementQuantity { get; set; }

		string InventoryItemRequirementCreatedBy { get; set; }

		DateTime? InventoryItemRequirementCreatedAt { get; set; }

		string InventoryItemRequirementUpdatedBy { get; set; }

		DateTime? InventoryItemRequirementUpdatedAt { get; set; }


	}

	public interface ICreateInventoryItemRequirementEntryMvo : ICreateOrMergePatchOrDeleteInventoryItemRequirementEntryMvo
	{
	}

	public interface IMergePatchInventoryItemRequirementEntryMvo : ICreateOrMergePatchOrDeleteInventoryItemRequirementEntryMvo
	{

		bool IsPropertyQuantityRemoved { get; set; }

		bool IsPropertySourceEventIdRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyInventoryItemRequirementQuantityRemoved { get; set; }

		bool IsPropertyInventoryItemRequirementCreatedByRemoved { get; set; }

		bool IsPropertyInventoryItemRequirementCreatedAtRemoved { get; set; }

		bool IsPropertyInventoryItemRequirementUpdatedByRemoved { get; set; }

		bool IsPropertyInventoryItemRequirementUpdatedAtRemoved { get; set; }


	}

	public interface IDeleteInventoryItemRequirementEntryMvo : ICreateOrMergePatchOrDeleteInventoryItemRequirementEntryMvo
	{
	}


}

