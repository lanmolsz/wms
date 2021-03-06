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
	public interface IMovementConfirmationLineState : IMovementConfirmationLineStateProperties, 
		IGlobalIdentity<MovementConfirmationLineId>, 
		ILocalIdentity<string>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IEntityVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IMovementConfirmationLineStateCreated e);

		void When(IMovementConfirmationLineStateMergePatched e);

		void When(IMovementConfirmationLineStateRemoved e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}

}

