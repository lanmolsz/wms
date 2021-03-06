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
	public interface IMovementLineMvoState : IMovementLineMvoStateProperties, 
		IGlobalIdentity<MovementLineId>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IMovementLineMvoStateCreated e);

		void When(IMovementLineMvoStateMergePatched e);

		void When(IMovementLineMvoStateDeleted e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}

}

