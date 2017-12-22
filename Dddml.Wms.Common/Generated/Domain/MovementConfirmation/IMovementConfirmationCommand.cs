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
	public interface IMovementConfirmationCommand : IAggregateCommand<string, long>, ICommandDto
	{
		long Version { get; set; }

		string DocumentNumber { get; set; }

	}


	public interface ICreateOrMergePatchOrDeleteMovementConfirmation : IMovementConfirmationCommand
	{

		string DocumentTypeId { get; set; }

		string DocumentAction { get; set; }

		string MovementDocumentNumber { get; set; }

		bool? IsApproved { get; set; }

		decimal? ApprovalAmount { get; set; }

		string Processing { get; set; }

		bool? Processed { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateMovementConfirmation : ICreateOrMergePatchOrDeleteMovementConfirmation
	{
        ICreateMovementConfirmationLineCommands MovementConfirmationLines { get; }

        ICreateMovementConfirmationLine NewCreateMovementConfirmationLine();

	}

	public interface IMergePatchMovementConfirmation : ICreateOrMergePatchOrDeleteMovementConfirmation
	{

		bool IsPropertyDocumentTypeIdRemoved { get; set; }

		bool IsPropertyMovementDocumentNumberRemoved { get; set; }

		bool IsPropertyIsApprovedRemoved { get; set; }

		bool IsPropertyApprovalAmountRemoved { get; set; }

		bool IsPropertyProcessingRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

        IMovementConfirmationLineCommands MovementConfirmationLineCommands { get; }

        ICreateMovementConfirmationLine NewCreateMovementConfirmationLine();

        IMergePatchMovementConfirmationLine NewMergePatchMovementConfirmationLine();

        IRemoveMovementConfirmationLine NewRemoveMovementConfirmationLine();


	}

	public interface IDeleteMovementConfirmation : ICreateOrMergePatchOrDeleteMovementConfirmation
	{
	}

    public interface ICreateMovementConfirmationLineCommands : IEnumerable<ICreateMovementConfirmationLine>
    {
        void Add(ICreateMovementConfirmationLine c);

        void Remove(ICreateMovementConfirmationLine c);

        void Clear();

    }

    public interface IMovementConfirmationLineCommands : IEnumerable<IMovementConfirmationLineCommand>
    {
        void Add(IMovementConfirmationLineCommand c);

        void Remove(IMovementConfirmationLineCommand c);

        void Clear();

    }


}
