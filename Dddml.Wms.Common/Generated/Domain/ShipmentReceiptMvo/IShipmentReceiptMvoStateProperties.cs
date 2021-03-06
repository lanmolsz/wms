﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentReceiptMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentReceiptMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentReceiptMvo
{

	public interface IShipmentReceiptMvoStateProperties
	{
		ShipmentReceiptId ShipmentReceiptId { get; set; }

		string ProductId { get; set; }

		string AttributeSetInstanceId { get; set; }

		string LocatorId { get; set; }

		string ShipmentItemSeqId { get; set; }

		string ShipmentPackageSeqId { get; set; }

		string OrderId { get; set; }

		string OrderItemSeqId { get; set; }

		string ReturnId { get; set; }

		string ReturnItemSeqId { get; set; }

		string RejectionReasonId { get; set; }

		string DamageStatusId { get; set; }

		string DamageReasonId { get; set; }

		string ReceivedBy { get; set; }

		DateTime? DatetimeReceived { get; set; }

		string ItemDescription { get; set; }

		decimal? AcceptedQuantity { get; set; }

		decimal? RejectedQuantity { get; set; }

		decimal? DamagedQuantity { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

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

		long ShipmentVersion { get; set; }

		string ShipmentCreatedBy { get; set; }

		DateTime ShipmentCreatedAt { get; set; }

		string ShipmentUpdatedBy { get; set; }

		DateTime ShipmentUpdatedAt { get; set; }

		bool ShipmentActive { get; set; }

	}

}
