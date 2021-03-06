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
	public interface IMovementConfirmationState : IMovementConfirmationStateProperties, 
		IGlobalIdentity<string>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IMovementConfirmationStateCreated e);

		void When(IMovementConfirmationStateMergePatched e);

		void When(IMovementConfirmationStateDeleted e);

		void Mutate(IEvent e);


		IMovementConfirmationLineStates MovementConfirmationLines { get; set; }


        bool IsUnsaved { get; }

	}

}

