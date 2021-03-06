﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Uom;

namespace Dddml.Wms.Domain.Uom
{
	public interface IUomState : IUomStateProperties, 
		IGlobalIdentity<string>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IUomStateCreated e);

		void When(IUomStateMergePatched e);

		void When(IUomStateDeleted e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}

}

