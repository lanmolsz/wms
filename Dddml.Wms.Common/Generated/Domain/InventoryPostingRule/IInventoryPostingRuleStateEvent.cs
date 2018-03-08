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
	public interface IInventoryPostingRuleStateEvent : IEvent, IStateEventDto, IGlobalIdentity<InventoryPostingRuleEventId>, ICreated<string>
	{
		InventoryPostingRuleEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		InventoryItemId TriggerInventoryItemId { get; set; }

		InventoryItemId OutputInventoryItemId { get; set; }

		string TriggerAccountName { get; set; }

		string OutputAccountName { get; set; }

		bool? IsOutputNegated { get; set; }

		bool? Active { get; set; }

	}

	public interface IInventoryPostingRuleStateCreated : IInventoryPostingRuleStateEvent//, IInventoryPostingRuleStateProperties
	{
	
	}


	public interface IInventoryPostingRuleStateMergePatched : IInventoryPostingRuleStateEvent//, IInventoryPostingRuleStateProperties
	{
		bool IsPropertyTriggerInventoryItemIdRemoved { get; set; }

		bool IsPropertyOutputInventoryItemIdRemoved { get; set; }

		bool IsPropertyTriggerAccountNameRemoved { get; set; }

		bool IsPropertyOutputAccountNameRemoved { get; set; }

		bool IsPropertyIsOutputNegatedRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IInventoryPostingRuleStateDeleted : IInventoryPostingRuleStateEvent
	{
	}


}

