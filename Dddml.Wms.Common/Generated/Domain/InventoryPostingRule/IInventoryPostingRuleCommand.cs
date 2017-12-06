﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryPostingRuleDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryPostingRule;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryPostingRule
{
	public interface IInventoryPostingRuleCommand : IAggregateCommand<string, long>, ICommandDto
	{
		long Version { get; set; }

		string InventoryPostingRuleId { get; set; }

	}


	public interface ICreateOrMergePatchOrDeleteInventoryPostingRule : IInventoryPostingRuleCommand
	{

		InventoryItemId TriggerInventoryItemId { get; set; }

		InventoryItemId OutputInventoryItemId { get; set; }

		string TriggerAccountName { get; set; }

		string OutputAccountName { get; set; }

		bool? IsOutputNegated { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateInventoryPostingRule : ICreateOrMergePatchOrDeleteInventoryPostingRule
	{
	}

	public interface IMergePatchInventoryPostingRule : ICreateOrMergePatchOrDeleteInventoryPostingRule
	{

		bool IsPropertyTriggerInventoryItemIdRemoved { get; set; }

		bool IsPropertyOutputInventoryItemIdRemoved { get; set; }

		bool IsPropertyTriggerAccountNameRemoved { get; set; }

		bool IsPropertyOutputAccountNameRemoved { get; set; }

		bool IsPropertyIsOutputNegatedRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IDeleteInventoryPostingRule : ICreateOrMergePatchOrDeleteInventoryPostingRule
	{
	}


}

