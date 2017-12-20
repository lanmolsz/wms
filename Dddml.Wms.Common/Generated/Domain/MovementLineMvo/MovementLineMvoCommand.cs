﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementLineMvo;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.MovementLineMvo
{

	public abstract class MovementLineMvoCommandBase : IMovementLineMvoCommand
	{
		public virtual MovementLineId MovementLineId { get; set; }


		MovementLineId IAggregateCommand<MovementLineId, long>.AggregateId
		{
			get
			{
				return this.MovementLineId;
			}
		}


		long IAggregateCommand<MovementLineId, long>.AggregateVersion
		{
			get
			{
				return this.MovementVersion;
			}
		}

		public virtual long MovementVersion { get; set; }

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

		public virtual decimal? MovementQuantity { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string LocatorIdFrom { get; set; }

		public virtual string LocatorIdTo { get; set; }

		public virtual string AttributeSetInstanceIdFrom { get; set; }

		public virtual string AttributeSetInstanceIdTo { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string ReversalLineNumber { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string MovementDocumentTypeId { get; set; }

		public virtual string DocumentAction { get; set; }

		public virtual string MovementDescription { get; set; }

		public virtual string MovementCreatedBy { get; set; }

		public virtual DateTime? MovementCreatedAt { get; set; }

		public virtual string MovementUpdatedBy { get; set; }

		public virtual DateTime? MovementUpdatedAt { get; set; }

		public virtual bool? MovementActive { get; set; }

		public virtual bool? MovementDeleted { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateMovementLineMvo : MovementLineMvoCommandBase, ICreateMovementLineMvo
	{
		
		public CreateMovementLineMvo ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchMovementLineMvo :MovementLineMvoCommandBase, IMergePatchMovementLineMvo
	{

		public virtual bool IsPropertyMovementQuantityRemoved { get; set; }

		public virtual bool IsPropertyProductIdRemoved { get; set; }

		public virtual bool IsPropertyLocatorIdFromRemoved { get; set; }

		public virtual bool IsPropertyLocatorIdToRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetInstanceIdFromRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetInstanceIdToRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyReversalLineNumberRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyMovementDocumentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyMovementDescriptionRemoved { get; set; }

		public virtual bool IsPropertyMovementCreatedByRemoved { get; set; }

		public virtual bool IsPropertyMovementCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyMovementUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyMovementUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyMovementActiveRemoved { get; set; }

		public virtual bool IsPropertyMovementDeletedRemoved { get; set; }


		public MergePatchMovementLineMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteMovementLineMvo : MovementLineMvoCommandBase, IDeleteMovementLineMvo
	{
		public DeleteMovementLineMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class MovementLineMvoCommands
    {
    }

}
