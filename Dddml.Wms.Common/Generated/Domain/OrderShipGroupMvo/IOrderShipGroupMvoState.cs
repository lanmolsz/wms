﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipGroupMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipGroupMvo;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.OrderShipGroupMvo
{
	public interface IOrderShipGroupMvoState : IOrderShipGroupMvoStateProperties, 
		IGlobalIdentity<OrderShipGroupId>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IOrderShipGroupMvoStateCreated e);

		void When(IOrderShipGroupMvoStateMergePatched e);

		void When(IOrderShipGroupMvoStateDeleted e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}

}

