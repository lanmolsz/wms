﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmationLineMvo;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.MovementConfirmationLineMvo
{

	public partial interface IMovementConfirmationLineMvoAggregate : IGlobalIdentity<MovementConfirmationLineId>
	{
		IMovementConfirmationLineMvoState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateMovementConfirmationLineMvo c);

		void MergePatch (IMergePatchMovementConfirmationLineMvo c);

		void Delete (IDeleteMovementConfirmationLineMvo c);


	}

}

