﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{
	public interface IInOutStateEvent : IEvent, IStateEventDto, IGlobalIdentity<InOutStateEventId>, ICreated<string>
	{
		InOutStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string DocumentStatusId { get; set; }

		bool? Posted { get; set; }

		bool? Processed { get; set; }

		string Processing { get; set; }

		string DocumentTypeId { get; set; }

		string Description { get; set; }

		string OrderId { get; set; }

		DateTime? DateOrdered { get; set; }

		bool? IsPrinted { get; set; }

		string MovementTypeId { get; set; }

		DateTime? MovementDate { get; set; }

		string BusinessPartnerId { get; set; }

		string WarehouseId { get; set; }

		string POReference { get; set; }

		string ShipperId { get; set; }

		DateTime? DatePrinted { get; set; }

		string SalesRepresentativeId { get; set; }

		int? NumberOfPackages { get; set; }

		DateTime? PickDate { get; set; }

		DateTime? ShipDate { get; set; }

		string TrackingNumber { get; set; }

		DateTime? DateReceived { get; set; }

		bool? IsInTransit { get; set; }

		bool? IsApproved { get; set; }

		bool? IsInDispute { get; set; }

		string RmaDocumentNumber { get; set; }

		string ReversalDocumentNumber { get; set; }

		bool? Active { get; set; }

	}

	public interface IInOutStateCreated : IInOutStateEvent//, IInOutStateProperties
	{
		IEnumerable<IInOutLineStateCreated> InOutLineEvents { get; }
		
		void AddInOutLineEvent(IInOutLineStateCreated e);

		IInOutLineStateCreated NewInOutLineStateCreated(string lineNumber);

	
	}


	public interface IInOutStateMergePatched : IInOutStateEvent//, IInOutStateProperties
	{
		bool IsPropertyDocumentStatusIdRemoved { get; set; }

		bool IsPropertyPostedRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyProcessingRemoved { get; set; }

		bool IsPropertyDocumentTypeIdRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyOrderIdRemoved { get; set; }

		bool IsPropertyDateOrderedRemoved { get; set; }

		bool IsPropertyIsPrintedRemoved { get; set; }

		bool IsPropertyMovementTypeIdRemoved { get; set; }

		bool IsPropertyMovementDateRemoved { get; set; }

		bool IsPropertyBusinessPartnerIdRemoved { get; set; }

		bool IsPropertyWarehouseIdRemoved { get; set; }

		bool IsPropertyPOReferenceRemoved { get; set; }

		bool IsPropertyShipperIdRemoved { get; set; }

		bool IsPropertyDatePrintedRemoved { get; set; }

		bool IsPropertySalesRepresentativeIdRemoved { get; set; }

		bool IsPropertyNumberOfPackagesRemoved { get; set; }

		bool IsPropertyPickDateRemoved { get; set; }

		bool IsPropertyShipDateRemoved { get; set; }

		bool IsPropertyTrackingNumberRemoved { get; set; }

		bool IsPropertyDateReceivedRemoved { get; set; }

		bool IsPropertyIsInTransitRemoved { get; set; }

		bool IsPropertyIsApprovedRemoved { get; set; }

		bool IsPropertyIsInDisputeRemoved { get; set; }

		bool IsPropertyRmaDocumentNumberRemoved { get; set; }

		bool IsPropertyReversalDocumentNumberRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		IEnumerable<IInOutLineStateEvent> InOutLineEvents { get; }
		
		void AddInOutLineEvent(IInOutLineStateEvent e);

		IInOutLineStateCreated NewInOutLineStateCreated(string lineNumber);

		IInOutLineStateMergePatched NewInOutLineStateMergePatched(string lineNumber);

		IInOutLineStateRemoved NewInOutLineStateRemoved(string lineNumber);


	}

	public interface IInOutStateDeleted : IInOutStateEvent
	{
		IEnumerable<IInOutLineStateRemoved> InOutLineEvents { get; }
		
		void AddInOutLineEvent(IInOutLineStateRemoved e);
		
		IInOutLineStateRemoved NewInOutLineStateRemoved(string lineNumber);

	}


}

