﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.Movement
{
	public interface IMovementConfirmationLineCommand : ICommand, ICommandDto
	{
		// Outer Id:

		string MovementDocumentNumber { get; set; }

		string LineNumber { get; set; }

	}


	public interface ICreateOrMergePatchOrRemoveMovementConfirmationLine : IMovementConfirmationLineCommand
	{

		decimal? TargetQuantity { get; set; }

		decimal? ConfirmedQuantity { get; set; }

		decimal? DifferenceQuantity { get; set; }

		decimal? ScrappedQuantity { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateMovementConfirmationLine : ICreateOrMergePatchOrRemoveMovementConfirmationLine
	{
	}

	public interface IMergePatchMovementConfirmationLine : ICreateOrMergePatchOrRemoveMovementConfirmationLine
	{

		bool IsPropertyTargetQuantityRemoved { get; set; }

		bool IsPropertyConfirmedQuantityRemoved { get; set; }

		bool IsPropertyDifferenceQuantityRemoved { get; set; }

		bool IsPropertyScrappedQuantityRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRemoveMovementConfirmationLine : ICreateOrMergePatchOrRemoveMovementConfirmationLine
	{
	}


}

