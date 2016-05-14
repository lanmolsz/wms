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
	public interface IAttributeSetStateEvent : IEvent, IGlobalIdentity<AttributeSetStateEventId>, ICreated<string>
	{
		AttributeSetStateEventId StateEventId { get; }
	}

	public interface IAttributeSetStateCreated : IAttributeSetStateEvent, IAttributeSetStateProperties
	{
		IEnumerable<IAttributeUseStateCreated> AttributeUseEvents { get; }
		
		void AddAttributeUseEvent(IAttributeUseStateCreated e);

	
	}


	public interface IAttributeSetStateMergePatched : IAttributeSetStateEvent, IAttributeSetStateProperties
	{
		bool IsPropertyNameRemoved { get; }

		bool IsPropertyDescriptionRemoved { get; }

		bool IsPropertySerialNumberAttributeIdRemoved { get; }

		bool IsPropertyLotAttributeIdRemoved { get; }

		bool IsPropertyActiveRemoved { get; }

		IEnumerable<IAttributeUseStateEvent> AttributeUseEvents { get; }
		
		void AddAttributeUseEvent(IAttributeUseStateEvent e);


	}


	public interface IAttributeSetStateDeleted : IAttributeSetStateEvent
	{
	}


}

