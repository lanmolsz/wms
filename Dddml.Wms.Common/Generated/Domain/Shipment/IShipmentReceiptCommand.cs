﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{
	public interface IShipmentReceiptCommand : ICommand, ICommandDto
	{
		// Outer Id:

		string ShipmentId { get; set; }

		string ReceiptSeqId { get; set; }

	}


	public interface ICreateOrMergePatchOrRemoveShipmentReceipt : IShipmentReceiptCommand
	{

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

		bool? Active { get; set; }


	}

	public interface ICreateShipmentReceipt : ICreateOrMergePatchOrRemoveShipmentReceipt
	{
	}

	public interface IMergePatchShipmentReceipt : ICreateOrMergePatchOrRemoveShipmentReceipt
	{

		bool IsPropertyProductIdRemoved { get; set; }

		bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		bool IsPropertyLocatorIdRemoved { get; set; }

		bool IsPropertyShipmentItemSeqIdRemoved { get; set; }

		bool IsPropertyShipmentPackageSeqIdRemoved { get; set; }

		bool IsPropertyOrderIdRemoved { get; set; }

		bool IsPropertyOrderItemSeqIdRemoved { get; set; }

		bool IsPropertyReturnIdRemoved { get; set; }

		bool IsPropertyReturnItemSeqIdRemoved { get; set; }

		bool IsPropertyRejectionReasonIdRemoved { get; set; }

		bool IsPropertyDamageStatusIdRemoved { get; set; }

		bool IsPropertyDamageReasonIdRemoved { get; set; }

		bool IsPropertyReceivedByRemoved { get; set; }

		bool IsPropertyDatetimeReceivedRemoved { get; set; }

		bool IsPropertyItemDescriptionRemoved { get; set; }

		bool IsPropertyAcceptedQuantityRemoved { get; set; }

		bool IsPropertyRejectedQuantityRemoved { get; set; }

		bool IsPropertyDamagedQuantityRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRemoveShipmentReceipt : ICreateOrMergePatchOrRemoveShipmentReceipt
	{
	}


}

