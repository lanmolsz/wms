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
	public interface IMovementConfirmationStateEvent : IEvent, IStateEventDto, IGlobalIdentity<MovementConfirmationStateEventId>, ICreated<string>
	{
		MovementConfirmationStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string DocumentStatusId { get; set; }

		string MovementDocumentNumber { get; set; }

		bool? IsApproved { get; set; }

		decimal? ApprovalAmount { get; set; }

		bool? Processed { get; set; }

		string Processing { get; set; }

		string DocumentTypeId { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }

	}

	public interface IMovementConfirmationStateCreated : IMovementConfirmationStateEvent//, IMovementConfirmationStateProperties
	{
		IEnumerable<IMovementConfirmationLineStateCreated> MovementConfirmationLineEvents { get; }
		
		void AddMovementConfirmationLineEvent(IMovementConfirmationLineStateCreated e);

		IMovementConfirmationLineStateCreated NewMovementConfirmationLineStateCreated(string lineNumber);

	
	}


	public interface IMovementConfirmationStateMergePatched : IMovementConfirmationStateEvent//, IMovementConfirmationStateProperties
	{
		bool IsPropertyDocumentStatusIdRemoved { get; set; }

		bool IsPropertyMovementDocumentNumberRemoved { get; set; }

		bool IsPropertyIsApprovedRemoved { get; set; }

		bool IsPropertyApprovalAmountRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyProcessingRemoved { get; set; }

		bool IsPropertyDocumentTypeIdRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		IEnumerable<IMovementConfirmationLineStateEvent> MovementConfirmationLineEvents { get; }
		
		void AddMovementConfirmationLineEvent(IMovementConfirmationLineStateEvent e);

		IMovementConfirmationLineStateCreated NewMovementConfirmationLineStateCreated(string lineNumber);

		IMovementConfirmationLineStateMergePatched NewMovementConfirmationLineStateMergePatched(string lineNumber);

		IMovementConfirmationLineStateRemoved NewMovementConfirmationLineStateRemoved(string lineNumber);


	}

	public interface IMovementConfirmationStateDeleted : IMovementConfirmationStateEvent
	{
		IEnumerable<IMovementConfirmationLineStateRemoved> MovementConfirmationLineEvents { get; }
		
		void AddMovementConfirmationLineEvent(IMovementConfirmationLineStateRemoved e);
		
		IMovementConfirmationLineStateRemoved NewMovementConfirmationLineStateRemoved(string lineNumber);

	}


}

