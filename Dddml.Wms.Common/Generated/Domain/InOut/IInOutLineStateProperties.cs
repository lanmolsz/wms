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

	public interface IInOutLineStateProperties
	{
		string LineNumber { get; set; }

		string LocatorId { get; set; }

		string ProductId { get; set; }

		string AttributeSetInstanceId { get; set; }

		string Description { get; set; }

		string UomId { get; set; }

		decimal MovementQuantity { get; set; }

		decimal PickedQuantity { get; set; }

		bool IsInvoiced { get; set; }

		bool Processed { get; set; }

		long RmaLineNumber { get; set; }

		long ReversalLineNumber { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

		// Outer Id:

		string InOutDocumentNumber { get; set; }

	}

}
