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

	public interface IInventoryPostingRuleStateProperties
	{
		string InventoryPostingRuleId { get; set; }

		InventoryItemId Trigger { get; set; }

		InventoryItemId Output { get; set; }

		string TriggerAccountName { get; set; }

		string OutputAccountName { get; set; }

		bool IsOutputNegated { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

	}

}
