﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmation
{

	public abstract class MovementConfirmationLineCommandBase : IMovementConfirmationLineCommand
	{
		public virtual string LineNumber { get; set; }


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

		public virtual string MovementLineNumber { get; set; }

		public virtual decimal? TargetQuantity { get; set; }

		public virtual decimal? ConfirmedQuantity { get; set; }

		public virtual decimal? DifferenceQuantity { get; set; }

		public virtual decimal? ScrappedQuantity { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual bool? Active { get; set; }

		// Outer Id:

		public virtual string MovementConfirmationDocumentNumber { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateMovementConfirmationLine : MovementConfirmationLineCommandBase, ICreateMovementConfirmationLine
	{
		
		public CreateMovementConfirmationLine ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchMovementConfirmationLine :MovementConfirmationLineCommandBase, IMergePatchMovementConfirmationLine
	{

		public virtual bool IsPropertyMovementLineNumberRemoved { get; set; }

		public virtual bool IsPropertyTargetQuantityRemoved { get; set; }

		public virtual bool IsPropertyConfirmedQuantityRemoved { get; set; }

		public virtual bool IsPropertyDifferenceQuantityRemoved { get; set; }

		public virtual bool IsPropertyScrappedQuantityRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchMovementConfirmationLine ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class RemoveMovementConfirmationLine : MovementConfirmationLineCommandBase, IRemoveMovementConfirmationLine
	{
		public RemoveMovementConfirmationLine ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Remove;
        }
	}

}
