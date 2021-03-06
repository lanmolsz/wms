﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public static partial class OrderShipGroupStateExtension
	{

        public static IOrderShipGroupCommand ToCreateOrMergePatchOrderShipGroup(this OrderShipGroupState state)
        {
            return state.ToCreateOrMergePatchOrderShipGroup<CreateOrderShipGroup, MergePatchOrderShipGroup, CreateOrderItemShipGroupAssociation, MergePatchOrderItemShipGroupAssociation>();
        }

        public static RemoveOrderShipGroup ToRemoveOrderShipGroup(this OrderShipGroupState state)
        {
            return state.ToRemoveOrderShipGroup<RemoveOrderShipGroup>();
        }

        public static MergePatchOrderShipGroup ToMergePatchOrderShipGroup(this OrderShipGroupState state)
        {
            return state.ToMergePatchOrderShipGroup<MergePatchOrderShipGroup, CreateOrderItemShipGroupAssociation, MergePatchOrderItemShipGroupAssociation>();
        }

        public static CreateOrderShipGroup ToCreateOrderShipGroup(this OrderShipGroupState state)
        {
            return state.ToCreateOrderShipGroup<CreateOrderShipGroup, CreateOrderItemShipGroupAssociation>();
        }
		

	}

}

