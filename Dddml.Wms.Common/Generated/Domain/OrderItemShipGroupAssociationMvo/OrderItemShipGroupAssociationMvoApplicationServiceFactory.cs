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

    public partial class OrderItemShipGroupAssociationMvoApplicationServiceFactory : IOrderItemShipGroupAssociationMvoApplicationServiceFactory
    {

        public virtual IOrderItemShipGroupAssociationMvoApplicationService OrderItemShipGroupAssociationMvoApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["OrderItemShipGroupAssociationMvoApplicationService"] as IOrderItemShipGroupAssociationMvoApplicationService;
		    }
        }

        public virtual ICreateOrderItemShipGroupAssociationMvo NewCreateOrderItemShipGroupAssociationMvo()
        {
		    return new CreateOrderItemShipGroupAssociationMvo();
        }

        public virtual IMergePatchOrderItemShipGroupAssociationMvo NewMergePatchOrderItemShipGroupAssociationMvo()
        {
            return new MergePatchOrderItemShipGroupAssociationMvo();
        }

        public virtual IDeleteOrderItemShipGroupAssociationMvo NewDeleteOrderItemShipGroupAssociationMvo()
        {
            return new DeleteOrderItemShipGroupAssociationMvo();
        }

    }


}
