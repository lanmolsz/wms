﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGroupAssociationMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo;
using Dddml.Wms.Domain.Order;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo
{
	public partial interface IOrderItemShipGroupAssociationMvoStateRepository
	{

        IOrderItemShipGroupAssociationMvoState Get(OrderItemShipGroupAssociationId id, bool nullAllowed);
        
        void Save(IOrderItemShipGroupAssociationMvoState state);
        
	}

}

