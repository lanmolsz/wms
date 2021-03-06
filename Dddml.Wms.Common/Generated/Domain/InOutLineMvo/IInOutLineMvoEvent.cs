﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOutLineMvo
{
	public interface IInOutLineMvoEvent : IEvent, IEventDto, IGlobalIdentity<InOutLineMvoEventId>, ICreated<string>
	{
		InOutLineMvoEventId InOutLineMvoEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface IInOutLineMvoStateEvent : IInOutLineMvoEvent
    {
		string LocatorId { get; set; }

		string ProductId { get; set; }

		string AttributeSetInstanceId { get; set; }

		string Description { get; set; }

		string QuantityUomId { get; set; }

		decimal? MovementQuantity { get; set; }

		decimal? PickedQuantity { get; set; }

		bool? IsInvoiced { get; set; }

		bool? Processed { get; set; }

		string RmaLineNumber { get; set; }

		string ReversalLineNumber { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		string InOutDocumentStatusId { get; set; }

		bool? InOutPosted { get; set; }

		bool? InOutProcessed { get; set; }

		string InOutProcessing { get; set; }

		string InOutDocumentTypeId { get; set; }

		string InOutDescription { get; set; }

		string InOutOrderId { get; set; }

		DateTime? InOutDateOrdered { get; set; }

		bool? InOutIsPrinted { get; set; }

		string InOutMovementTypeId { get; set; }

		DateTime? InOutMovementDate { get; set; }

		string InOutBusinessPartnerId { get; set; }

		string InOutWarehouseId { get; set; }

		string InOutPOReference { get; set; }

		decimal? InOutFreightAmount { get; set; }

		string InOutShipperId { get; set; }

		decimal? InOutChargeAmount { get; set; }

		DateTime? InOutDatePrinted { get; set; }

		string InOutCreatedFrom { get; set; }

		string InOutSalesRepresentativeId { get; set; }

		int? InOutNumberOfPackages { get; set; }

		DateTime? InOutPickDate { get; set; }

		DateTime? InOutShipDate { get; set; }

		string InOutTrackingNumber { get; set; }

		DateTime? InOutDateReceived { get; set; }

		bool? InOutIsInTransit { get; set; }

		bool? InOutIsApproved { get; set; }

		bool? InOutIsInDispute { get; set; }

		string InOutRmaDocumentNumber { get; set; }

		string InOutReversalDocumentNumber { get; set; }

		string InOutCreatedBy { get; set; }

		DateTime? InOutCreatedAt { get; set; }

		string InOutUpdatedBy { get; set; }

		DateTime? InOutUpdatedAt { get; set; }

		bool? InOutActive { get; set; }

    }
   
	public interface IInOutLineMvoStateCreated : IInOutLineMvoStateEvent
	{
	
	}


	public interface IInOutLineMvoStateMergePatched : IInOutLineMvoStateEvent
	{
		bool IsPropertyLocatorIdRemoved { get; set; }

		bool IsPropertyProductIdRemoved { get; set; }

		bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyQuantityUomIdRemoved { get; set; }

		bool IsPropertyMovementQuantityRemoved { get; set; }

		bool IsPropertyPickedQuantityRemoved { get; set; }

		bool IsPropertyIsInvoicedRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyRmaLineNumberRemoved { get; set; }

		bool IsPropertyReversalLineNumberRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyInOutDocumentStatusIdRemoved { get; set; }

		bool IsPropertyInOutPostedRemoved { get; set; }

		bool IsPropertyInOutProcessedRemoved { get; set; }

		bool IsPropertyInOutProcessingRemoved { get; set; }

		bool IsPropertyInOutDocumentTypeIdRemoved { get; set; }

		bool IsPropertyInOutDescriptionRemoved { get; set; }

		bool IsPropertyInOutOrderIdRemoved { get; set; }

		bool IsPropertyInOutDateOrderedRemoved { get; set; }

		bool IsPropertyInOutIsPrintedRemoved { get; set; }

		bool IsPropertyInOutMovementTypeIdRemoved { get; set; }

		bool IsPropertyInOutMovementDateRemoved { get; set; }

		bool IsPropertyInOutBusinessPartnerIdRemoved { get; set; }

		bool IsPropertyInOutWarehouseIdRemoved { get; set; }

		bool IsPropertyInOutPOReferenceRemoved { get; set; }

		bool IsPropertyInOutFreightAmountRemoved { get; set; }

		bool IsPropertyInOutShipperIdRemoved { get; set; }

		bool IsPropertyInOutChargeAmountRemoved { get; set; }

		bool IsPropertyInOutDatePrintedRemoved { get; set; }

		bool IsPropertyInOutCreatedFromRemoved { get; set; }

		bool IsPropertyInOutSalesRepresentativeIdRemoved { get; set; }

		bool IsPropertyInOutNumberOfPackagesRemoved { get; set; }

		bool IsPropertyInOutPickDateRemoved { get; set; }

		bool IsPropertyInOutShipDateRemoved { get; set; }

		bool IsPropertyInOutTrackingNumberRemoved { get; set; }

		bool IsPropertyInOutDateReceivedRemoved { get; set; }

		bool IsPropertyInOutIsInTransitRemoved { get; set; }

		bool IsPropertyInOutIsApprovedRemoved { get; set; }

		bool IsPropertyInOutIsInDisputeRemoved { get; set; }

		bool IsPropertyInOutRmaDocumentNumberRemoved { get; set; }

		bool IsPropertyInOutReversalDocumentNumberRemoved { get; set; }

		bool IsPropertyInOutCreatedByRemoved { get; set; }

		bool IsPropertyInOutCreatedAtRemoved { get; set; }

		bool IsPropertyInOutUpdatedByRemoved { get; set; }

		bool IsPropertyInOutUpdatedAtRemoved { get; set; }

		bool IsPropertyInOutActiveRemoved { get; set; }


	}

	public interface IInOutLineMvoStateDeleted : IInOutLineMvoStateEvent
	{
	}


}

