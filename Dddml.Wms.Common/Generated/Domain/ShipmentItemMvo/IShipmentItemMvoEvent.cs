﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItemMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentItemMvo
{
	public interface IShipmentItemMvoEvent : IEvent, IEventDto, IGlobalIdentity<ShipmentItemMvoEventId>, ICreated<string>
	{
		ShipmentItemMvoEventId ShipmentItemMvoEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface IShipmentItemMvoStateEvent : IShipmentItemMvoEvent
    {
		string ProductId { get; set; }

		string AttributeSetInstanceId { get; set; }

		decimal? Quantity { get; set; }

		string ShipmentContentDescription { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		string ShipmentShipmentTypeId { get; set; }

		string ShipmentStatusId { get; set; }

		string ShipmentPrimaryOrderId { get; set; }

		string ShipmentPrimaryReturnId { get; set; }

		long? ShipmentPrimaryShipGroupSeqId { get; set; }

		string ShipmentPicklistBinId { get; set; }

		DateTime? ShipmentEstimatedReadyDate { get; set; }

		DateTime? ShipmentEstimatedShipDate { get; set; }

		string ShipmentEstimatedShipWorkEffId { get; set; }

		DateTime? ShipmentEstimatedArrivalDate { get; set; }

		string ShipmentEstimatedArrivalWorkEffId { get; set; }

		DateTime? ShipmentLatestCancelDate { get; set; }

		decimal? ShipmentEstimatedShipCost { get; set; }

		string ShipmentCurrencyUomId { get; set; }

		string ShipmentHandlingInstructions { get; set; }

		string ShipmentOriginFacilityId { get; set; }

		string ShipmentDestinationFacilityId { get; set; }

		string ShipmentOriginContactMechId { get; set; }

		string ShipmentOriginTelecomNumberId { get; set; }

		string ShipmentDestinationContactMechId { get; set; }

		string ShipmentDestinationTelecomNumberId { get; set; }

		string ShipmentPartyIdTo { get; set; }

		string ShipmentPartyIdFrom { get; set; }

		decimal? ShipmentAdditionalShippingCharge { get; set; }

		string ShipmentAddtlShippingChargeDesc { get; set; }

		string ShipmentCreatedBy { get; set; }

		DateTime? ShipmentCreatedAt { get; set; }

		string ShipmentUpdatedBy { get; set; }

		DateTime? ShipmentUpdatedAt { get; set; }

		bool? ShipmentActive { get; set; }

    }
   
	public interface IShipmentItemMvoStateCreated : IShipmentItemMvoStateEvent
	{
	
	}


	public interface IShipmentItemMvoStateMergePatched : IShipmentItemMvoStateEvent
	{
		bool IsPropertyProductIdRemoved { get; set; }

		bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		bool IsPropertyQuantityRemoved { get; set; }

		bool IsPropertyShipmentContentDescriptionRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyShipmentShipmentTypeIdRemoved { get; set; }

		bool IsPropertyShipmentStatusIdRemoved { get; set; }

		bool IsPropertyShipmentPrimaryOrderIdRemoved { get; set; }

		bool IsPropertyShipmentPrimaryReturnIdRemoved { get; set; }

		bool IsPropertyShipmentPrimaryShipGroupSeqIdRemoved { get; set; }

		bool IsPropertyShipmentPicklistBinIdRemoved { get; set; }

		bool IsPropertyShipmentEstimatedReadyDateRemoved { get; set; }

		bool IsPropertyShipmentEstimatedShipDateRemoved { get; set; }

		bool IsPropertyShipmentEstimatedShipWorkEffIdRemoved { get; set; }

		bool IsPropertyShipmentEstimatedArrivalDateRemoved { get; set; }

		bool IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved { get; set; }

		bool IsPropertyShipmentLatestCancelDateRemoved { get; set; }

		bool IsPropertyShipmentEstimatedShipCostRemoved { get; set; }

		bool IsPropertyShipmentCurrencyUomIdRemoved { get; set; }

		bool IsPropertyShipmentHandlingInstructionsRemoved { get; set; }

		bool IsPropertyShipmentOriginFacilityIdRemoved { get; set; }

		bool IsPropertyShipmentDestinationFacilityIdRemoved { get; set; }

		bool IsPropertyShipmentOriginContactMechIdRemoved { get; set; }

		bool IsPropertyShipmentOriginTelecomNumberIdRemoved { get; set; }

		bool IsPropertyShipmentDestinationContactMechIdRemoved { get; set; }

		bool IsPropertyShipmentDestinationTelecomNumberIdRemoved { get; set; }

		bool IsPropertyShipmentPartyIdToRemoved { get; set; }

		bool IsPropertyShipmentPartyIdFromRemoved { get; set; }

		bool IsPropertyShipmentAdditionalShippingChargeRemoved { get; set; }

		bool IsPropertyShipmentAddtlShippingChargeDescRemoved { get; set; }

		bool IsPropertyShipmentCreatedByRemoved { get; set; }

		bool IsPropertyShipmentCreatedAtRemoved { get; set; }

		bool IsPropertyShipmentUpdatedByRemoved { get; set; }

		bool IsPropertyShipmentUpdatedAtRemoved { get; set; }

		bool IsPropertyShipmentActiveRemoved { get; set; }


	}


}

