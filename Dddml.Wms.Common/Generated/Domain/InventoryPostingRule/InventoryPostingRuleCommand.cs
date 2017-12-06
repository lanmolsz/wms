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

	public abstract class InventoryPostingRuleCommandBase : IInventoryPostingRuleCommand
	{
		public virtual string InventoryPostingRuleId { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.InventoryPostingRuleId;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual InventoryItemId TriggerInventoryItemId { get; set; }

		public virtual InventoryItemId OutputInventoryItemId { get; set; }

		public virtual string TriggerAccountName { get; set; }

		public virtual string OutputAccountName { get; set; }

		public virtual bool? IsOutputNegated { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateInventoryPostingRule : InventoryPostingRuleCommandBase, ICreateInventoryPostingRule
	{
		
		public CreateInventoryPostingRule ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchInventoryPostingRule :InventoryPostingRuleCommandBase, IMergePatchInventoryPostingRule
	{

		public virtual bool IsPropertyTriggerInventoryItemIdRemoved { get; set; }

		public virtual bool IsPropertyOutputInventoryItemIdRemoved { get; set; }

		public virtual bool IsPropertyTriggerAccountNameRemoved { get; set; }

		public virtual bool IsPropertyOutputAccountNameRemoved { get; set; }

		public virtual bool IsPropertyIsOutputNegatedRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchInventoryPostingRule ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteInventoryPostingRule : InventoryPostingRuleCommandBase, IDeleteInventoryPostingRule
	{
		public DeleteInventoryPostingRule ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class InventoryPostingRuleCommands
    {
    }

}
