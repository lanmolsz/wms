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
	public interface ISupplierProductEvent : IEvent, IEventDto, IGlobalIdentity<SupplierProductEventId>, ICreated<string>
	{
		SupplierProductEventId SupplierProductEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface ISupplierProductStateEvent : ISupplierProductEvent
    {
		DateTime? AvailableThruDate { get; set; }

		string SupplierPrefOrderId { get; set; }

		string SupplierRatingTypeId { get; set; }

		decimal? StandardLeadTimeDays { get; set; }

		decimal? ManufacturingLeadTimeDays { get; set; }

		decimal? DeliveryLeadTimeDays { get; set; }

		string QuantityUomId { get; set; }

		decimal? LastPrice { get; set; }

		decimal? ShippingPrice { get; set; }

		string ExternalProductName { get; set; }

		string ExternalProductId { get; set; }

		bool? CanDropShip { get; set; }

		string Comments { get; set; }

		bool? Active { get; set; }

    }
   
	public interface ISupplierProductStateCreated : ISupplierProductStateEvent
	{
	
	}


	public interface ISupplierProductStateMergePatched : ISupplierProductStateEvent
	{
		bool IsPropertyAvailableThruDateRemoved { get; set; }

		bool IsPropertySupplierPrefOrderIdRemoved { get; set; }

		bool IsPropertySupplierRatingTypeIdRemoved { get; set; }

		bool IsPropertyStandardLeadTimeDaysRemoved { get; set; }

		bool IsPropertyManufacturingLeadTimeDaysRemoved { get; set; }

		bool IsPropertyDeliveryLeadTimeDaysRemoved { get; set; }

		bool IsPropertyQuantityUomIdRemoved { get; set; }

		bool IsPropertyLastPriceRemoved { get; set; }

		bool IsPropertyShippingPriceRemoved { get; set; }

		bool IsPropertyExternalProductNameRemoved { get; set; }

		bool IsPropertyExternalProductIdRemoved { get; set; }

		bool IsPropertyCanDropShipRemoved { get; set; }

		bool IsPropertyCommentsRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}


}

