﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSupplierProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SupplierProduct;

namespace Dddml.Wms.Domain.SupplierProduct
{

	public static partial class SupplierProductStateInterfaceExtension
	{

        public static ISupplierProductCommand ToCreateOrMergePatchSupplierProduct<TCreateSupplierProduct, TMergePatchSupplierProduct>(this ISupplierProductState state)
            where TCreateSupplierProduct : ICreateSupplierProduct, new()
            where TMergePatchSupplierProduct : IMergePatchSupplierProduct, new()
        {
            bool bUnsaved = ((ISupplierProductState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateSupplierProduct<TCreateSupplierProduct>();
            }
            else 
            {
                return state.ToMergePatchSupplierProduct<TMergePatchSupplierProduct>();
            }
        }

        public static TDeleteSupplierProduct ToDeleteSupplierProduct<TDeleteSupplierProduct>(this ISupplierProductState state)
            where TDeleteSupplierProduct : IDeleteSupplierProduct, new()
        {
            var cmd = new TDeleteSupplierProduct();
            cmd.SupplierProductId = state.SupplierProductId;
            cmd.Version = ((ISupplierProductStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchSupplierProduct ToMergePatchSupplierProduct<TMergePatchSupplierProduct>(this ISupplierProductState state)
            where TMergePatchSupplierProduct : IMergePatchSupplierProduct, new()
        {
            var cmd = new TMergePatchSupplierProduct();

            cmd.Version = ((ISupplierProductStateProperties)state).Version;

            cmd.SupplierProductId = state.SupplierProductId;
            cmd.AvailableThruDate = state.AvailableThruDate;
            cmd.SupplierPrefOrderId = state.SupplierPrefOrderId;
            cmd.SupplierRatingTypeId = state.SupplierRatingTypeId;
            cmd.StandardLeadTimeDays = state.StandardLeadTimeDays;
            cmd.ManufacturingLeadTimeDays = state.ManufacturingLeadTimeDays;
            cmd.DeliveryLeadTimeDays = state.DeliveryLeadTimeDays;
            cmd.QuantityUomId = state.QuantityUomId;
            cmd.LastPrice = state.LastPrice;
            cmd.ShippingPrice = state.ShippingPrice;
            cmd.ExternalProductName = state.ExternalProductName;
            cmd.ExternalProductId = state.ExternalProductId;
            cmd.CanDropShip = state.CanDropShip;
            cmd.Comments = state.Comments;
            cmd.Active = ((ISupplierProductStateProperties)state).Active;
            
            if (state.AvailableThruDate == null) { cmd.IsPropertyAvailableThruDateRemoved = true; }
            if (state.SupplierPrefOrderId == null) { cmd.IsPropertySupplierPrefOrderIdRemoved = true; }
            if (state.SupplierRatingTypeId == null) { cmd.IsPropertySupplierRatingTypeIdRemoved = true; }
            if (state.StandardLeadTimeDays == null) { cmd.IsPropertyStandardLeadTimeDaysRemoved = true; }
            if (state.ManufacturingLeadTimeDays == null) { cmd.IsPropertyManufacturingLeadTimeDaysRemoved = true; }
            if (state.DeliveryLeadTimeDays == null) { cmd.IsPropertyDeliveryLeadTimeDaysRemoved = true; }
            if (state.QuantityUomId == null) { cmd.IsPropertyQuantityUomIdRemoved = true; }
            if (state.LastPrice == null) { cmd.IsPropertyLastPriceRemoved = true; }
            if (state.ShippingPrice == null) { cmd.IsPropertyShippingPriceRemoved = true; }
            if (state.ExternalProductName == null) { cmd.IsPropertyExternalProductNameRemoved = true; }
            if (state.ExternalProductId == null) { cmd.IsPropertyExternalProductIdRemoved = true; }
            if (state.Comments == null) { cmd.IsPropertyCommentsRemoved = true; }
            return cmd;
        }

        public static TCreateSupplierProduct ToCreateSupplierProduct<TCreateSupplierProduct>(this ISupplierProductState state)
            where TCreateSupplierProduct : ICreateSupplierProduct, new()
        {
            var cmd = new TCreateSupplierProduct();

            cmd.Version = ((ISupplierProductStateProperties)state).Version;

            cmd.SupplierProductId = state.SupplierProductId;
            cmd.AvailableThruDate = state.AvailableThruDate;
            cmd.SupplierPrefOrderId = state.SupplierPrefOrderId;
            cmd.SupplierRatingTypeId = state.SupplierRatingTypeId;
            cmd.StandardLeadTimeDays = state.StandardLeadTimeDays;
            cmd.ManufacturingLeadTimeDays = state.ManufacturingLeadTimeDays;
            cmd.DeliveryLeadTimeDays = state.DeliveryLeadTimeDays;
            cmd.QuantityUomId = state.QuantityUomId;
            cmd.LastPrice = state.LastPrice;
            cmd.ShippingPrice = state.ShippingPrice;
            cmd.ExternalProductName = state.ExternalProductName;
            cmd.ExternalProductId = state.ExternalProductId;
            cmd.CanDropShip = state.CanDropShip;
            cmd.Comments = state.Comments;
            cmd.Active = ((ISupplierProductStateProperties)state).Active;
            return cmd;
        }
		

	}

}

