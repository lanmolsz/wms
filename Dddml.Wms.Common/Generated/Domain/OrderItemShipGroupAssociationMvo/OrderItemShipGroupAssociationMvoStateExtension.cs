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

namespace Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo
{

	public static partial class OrderItemShipGroupAssociationMvoStateExtension
	{

        public static IOrderItemShipGroupAssociationMvoCommand ToCreateOrMergePatchOrderItemShipGroupAssociationMvo(this OrderItemShipGroupAssociationMvoState state)
        {
            return state.ToCreateOrMergePatchOrderItemShipGroupAssociationMvo<CreateOrderItemShipGroupAssociationMvo, MergePatchOrderItemShipGroupAssociationMvo>();
        }

        public static DeleteOrderItemShipGroupAssociationMvo ToDeleteOrderItemShipGroupAssociationMvo(this OrderItemShipGroupAssociationMvoState state)
        {
            return state.ToDeleteOrderItemShipGroupAssociationMvo<DeleteOrderItemShipGroupAssociationMvo>();
        }

        public static MergePatchOrderItemShipGroupAssociationMvo ToMergePatchOrderItemShipGroupAssociationMvo(this OrderItemShipGroupAssociationMvoState state)
        {
            return state.ToMergePatchOrderItemShipGroupAssociationMvo<MergePatchOrderItemShipGroupAssociationMvo>();
        }

        public static CreateOrderItemShipGroupAssociationMvo ToCreateOrderItemShipGroupAssociationMvo(this OrderItemShipGroupAssociationMvoState state)
        {
            return state.ToCreateOrderItemShipGroupAssociationMvo<CreateOrderItemShipGroupAssociationMvo>();
        }
		

	}

}
