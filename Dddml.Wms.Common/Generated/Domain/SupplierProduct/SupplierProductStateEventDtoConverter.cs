﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSupplierProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SupplierProduct;

namespace Dddml.Wms.Domain.SupplierProduct
{

    public class SupplierProductStateEventDtoConverter
    {
        public virtual SupplierProductStateCreatedOrMergePatchedOrDeletedDto ToSupplierProductStateEventDto(ISupplierProductEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (ISupplierProductStateCreated)stateEvent;
                return ToSupplierProductStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (ISupplierProductStateMergePatched)stateEvent;
                return ToSupplierProductStateMergePatchedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual SupplierProductStateCreatedDto ToSupplierProductStateCreatedDto(ISupplierProductStateCreated e)
        {
            var dto = new SupplierProductStateCreatedDto();
            dto.SupplierProductEventId = e.SupplierProductEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.AvailableThruDate = e.AvailableThruDate;
            dto.SupplierPrefOrderId = e.SupplierPrefOrderId;
            dto.SupplierRatingTypeId = e.SupplierRatingTypeId;
            dto.StandardLeadTimeDays = e.StandardLeadTimeDays;
            dto.ManufacturingLeadTimeDays = e.ManufacturingLeadTimeDays;
            dto.DeliveryLeadTimeDays = e.DeliveryLeadTimeDays;
            dto.QuantityUomId = e.QuantityUomId;
            dto.LastPrice = e.LastPrice;
            dto.ShippingPrice = e.ShippingPrice;
            dto.ExternalProductName = e.ExternalProductName;
            dto.ExternalProductId = e.ExternalProductId;
            dto.CanDropShip = e.CanDropShip;
            dto.Comments = e.Comments;
            dto.Active = e.Active;
            return dto;
        }

        public virtual SupplierProductStateMergePatchedDto ToSupplierProductStateMergePatchedDto(ISupplierProductStateMergePatched e)
        {
            var dto = new SupplierProductStateMergePatchedDto();
            dto.SupplierProductEventId = e.SupplierProductEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.AvailableThruDate = e.AvailableThruDate;
            dto.SupplierPrefOrderId = e.SupplierPrefOrderId;
            dto.SupplierRatingTypeId = e.SupplierRatingTypeId;
            dto.StandardLeadTimeDays = e.StandardLeadTimeDays;
            dto.ManufacturingLeadTimeDays = e.ManufacturingLeadTimeDays;
            dto.DeliveryLeadTimeDays = e.DeliveryLeadTimeDays;
            dto.QuantityUomId = e.QuantityUomId;
            dto.LastPrice = e.LastPrice;
            dto.ShippingPrice = e.ShippingPrice;
            dto.ExternalProductName = e.ExternalProductName;
            dto.ExternalProductId = e.ExternalProductId;
            dto.CanDropShip = e.CanDropShip;
            dto.Comments = e.Comments;
            dto.Active = e.Active;
            dto.IsPropertyAvailableThruDateRemoved = e.IsPropertyAvailableThruDateRemoved;
            dto.IsPropertySupplierPrefOrderIdRemoved = e.IsPropertySupplierPrefOrderIdRemoved;
            dto.IsPropertySupplierRatingTypeIdRemoved = e.IsPropertySupplierRatingTypeIdRemoved;
            dto.IsPropertyStandardLeadTimeDaysRemoved = e.IsPropertyStandardLeadTimeDaysRemoved;
            dto.IsPropertyManufacturingLeadTimeDaysRemoved = e.IsPropertyManufacturingLeadTimeDaysRemoved;
            dto.IsPropertyDeliveryLeadTimeDaysRemoved = e.IsPropertyDeliveryLeadTimeDaysRemoved;
            dto.IsPropertyQuantityUomIdRemoved = e.IsPropertyQuantityUomIdRemoved;
            dto.IsPropertyLastPriceRemoved = e.IsPropertyLastPriceRemoved;
            dto.IsPropertyShippingPriceRemoved = e.IsPropertyShippingPriceRemoved;
            dto.IsPropertyExternalProductNameRemoved = e.IsPropertyExternalProductNameRemoved;
            dto.IsPropertyExternalProductIdRemoved = e.IsPropertyExternalProductIdRemoved;
            dto.IsPropertyCanDropShipRemoved = e.IsPropertyCanDropShipRemoved;
            dto.IsPropertyCommentsRemoved = e.IsPropertyCommentsRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }



    }


}

