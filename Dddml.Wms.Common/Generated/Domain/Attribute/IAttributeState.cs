﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{
	public interface IAttributeState : IAttributeStateProperties, 
		IGlobalIdentity<string>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IAttributeStateCreated e);

		void When(IAttributeStateMergePatched e);

		void When(IAttributeStateDeleted e);

		void Mutate(IEvent e);


		IAttributeValueStates AttributeValues { get; set; }


		IAttributeAliasStates Aliases { get; set; }


        bool IsUnsaved { get; }

	}
}

