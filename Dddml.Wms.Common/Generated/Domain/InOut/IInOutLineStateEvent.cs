﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{
	public interface IInOutLineStateEvent : IEvent, IStateEventDto, IGlobalIdentity<InOutLineEventId>, ICreated<string>
	{
		InOutLineEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		string LocatorId { get; set; }

		string ProductId { get; set; }

		string AttributeSetInstanceId { get; set; }

		string Description { get; set; }

		string QuantityUomId { get; set; }

		decimal? MovementQuantity { get; set; }

		decimal? PickedQuantity { get; set; }

		bool? IsInvoiced { get; set; }

		bool? Processed { get; set; }

		string RmaLineNumber { get; set; }

		string ReversalLineNumber { get; set; }

		bool? Active { get; set; }

		// Outer Id:
		//string InOutDocumentNumber { get; set; }

	}

	public interface IInOutLineStateCreated : IInOutLineStateEvent//, IInOutLineStateProperties
	{
	
	}


	public interface IInOutLineStateMergePatched : IInOutLineStateEvent//, IInOutLineStateProperties
	{
		bool IsPropertyLocatorIdRemoved { get; set; }

		bool IsPropertyProductIdRemoved { get; set; }

		bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyQuantityUomIdRemoved { get; set; }

		bool IsPropertyMovementQuantityRemoved { get; set; }

		bool IsPropertyPickedQuantityRemoved { get; set; }

		bool IsPropertyIsInvoicedRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyRmaLineNumberRemoved { get; set; }

		bool IsPropertyReversalLineNumberRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IInOutLineStateRemoved : IInOutLineStateEvent
	{
	}


}

