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

	public abstract class InventoryItemRequirementEntryMvoCommandBase : IInventoryItemRequirementEntryMvoCommand
	{
		public virtual InventoryItemRequirementEntryId InventoryItemRequirementEntryId { get; set; }


		InventoryItemRequirementEntryId IAggregateCommand<InventoryItemRequirementEntryId, long>.AggregateId
		{
			get
			{
				return this.InventoryItemRequirementEntryId;
			}
		}


		long IAggregateCommand<InventoryItemRequirementEntryId, long>.AggregateVersion
		{
			get
			{
				return this.InventoryItemRequirementVersion;
			}
		}

		public virtual long InventoryItemRequirementVersion { get; set; }

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

		public virtual decimal? Quantity { get; set; }

		public virtual InventoryPRTriggeredId SourceEventId { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual decimal? InventoryItemRequirementQuantity { get; set; }

		public virtual string InventoryItemRequirementCreatedBy { get; set; }

		public virtual DateTime? InventoryItemRequirementCreatedAt { get; set; }

		public virtual string InventoryItemRequirementUpdatedBy { get; set; }

		public virtual DateTime? InventoryItemRequirementUpdatedAt { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateInventoryItemRequirementEntryMvo : InventoryItemRequirementEntryMvoCommandBase, ICreateInventoryItemRequirementEntryMvo
	{
		
		public CreateInventoryItemRequirementEntryMvo ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchInventoryItemRequirementEntryMvo :InventoryItemRequirementEntryMvoCommandBase, IMergePatchInventoryItemRequirementEntryMvo
	{

		public virtual bool IsPropertyQuantityRemoved { get; set; }

		public virtual bool IsPropertySourceEventIdRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyInventoryItemRequirementQuantityRemoved { get; set; }

		public virtual bool IsPropertyInventoryItemRequirementCreatedByRemoved { get; set; }

		public virtual bool IsPropertyInventoryItemRequirementCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyInventoryItemRequirementUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyInventoryItemRequirementUpdatedAtRemoved { get; set; }


		public MergePatchInventoryItemRequirementEntryMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteInventoryItemRequirementEntryMvo : InventoryItemRequirementEntryMvoCommandBase, IDeleteInventoryItemRequirementEntryMvo
	{
		public DeleteInventoryItemRequirementEntryMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class InventoryItemRequirementEntryMvoCommands
    {
    }

}
