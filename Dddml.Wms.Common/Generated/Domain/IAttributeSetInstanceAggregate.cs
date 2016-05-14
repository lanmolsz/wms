﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public partial interface IAttributeSetInstanceAggregate : IGlobalIdentity<string>
	{
		IAttributeSetInstanceState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateAttributeSetInstance c);

		void MergePatch (IMergePatchAttributeSetInstance c);

		void Delete (IDeleteAttributeSetInstance c);

	   
	}

}

