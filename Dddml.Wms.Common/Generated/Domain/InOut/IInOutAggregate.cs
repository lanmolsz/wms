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

	public partial interface IInOutAggregate : IGlobalIdentity<string>
	{
		IInOutState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateInOut c);

		void MergePatch (IMergePatchInOut c);

		void Complete(long version, string commandId, string requesterId);

		void Close(long version, string commandId, string requesterId);

		void Void(long version, string commandId, string requesterId);

		void Reverse(long version, string commandId, string requesterId);

		void AddLine(string lineNumber, string locatorId, string productId, IDictionary<string, object> attributeSetInstance, string description, string quantityUomId, decimal movementQuantity, long version, string commandId, string requesterId);

		void DocumentAction(string value, long version, string commandId, string requesterId);


	}

}

