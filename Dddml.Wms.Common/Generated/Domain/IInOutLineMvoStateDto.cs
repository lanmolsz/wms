﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{

    public interface IInOutLineMvoStateDto
    {

        InOutLineIdDto InOutLineId
        {
            get;
            set;
        }

        long? LineNumber
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        string LocatorId
        {
            get;
            set;
        }

        string Product
        {
            get;
            set;
        }

        string UomId
        {
            get;
            set;
        }

        decimal? MovementQuantity
        {
            get;
            set;
        }

        decimal? ConfirmedQuantity
        {
            get;
            set;
        }

        decimal? ScrappedQuantity
        {
            get;
            set;
        }

        decimal? TargetQuantity
        {
            get;
            set;
        }

        decimal? PickedQuantity
        {
            get;
            set;
        }

        bool? IsInvoiced
        {
            get;
            set;
        }

        string AttributeSetInstanceId
        {
            get;
            set;
        }

        bool? IsDescription
        {
            get;
            set;
        }

        bool? Processed
        {
            get;
            set;
        }

        decimal? QuantityEntered
        {
            get;
            set;
        }

        long? RmaLineNumber
        {
            get;
            set;
        }

        long? ReversalLineNumber
        {
            get;
            set;
        }

        long? Version
        {
            get;
            set;
        }

        bool? Active
        {
            get;
            set;
        }

        bool? InOutIsSOTransaction
        {
            get;
            set;
        }

        string InOutDocumentStatus
        {
            get;
            set;
        }

        bool? InOutPosted
        {
            get;
            set;
        }

        bool? InOutProcessing
        {
            get;
            set;
        }

        bool? InOutProcessed
        {
            get;
            set;
        }

        int? InOutDocumentType
        {
            get;
            set;
        }

        string InOutDescription
        {
            get;
            set;
        }

        string InOutOrderNumber
        {
            get;
            set;
        }

        DateTime? InOutDateOrdered
        {
            get;
            set;
        }

        bool? InOutIsPrinted
        {
            get;
            set;
        }

        string InOutMovementType
        {
            get;
            set;
        }

        DateTime? InOutMovementDate
        {
            get;
            set;
        }

        string InOutBusinessPartnerId
        {
            get;
            set;
        }

        string InOutWarehouseId
        {
            get;
            set;
        }

        string InOutPOReference
        {
            get;
            set;
        }

        Money? InOutFreightAmount
        {
            get;
            set;
        }

        string InOutShipperId
        {
            get;
            set;
        }

        Money? InOutChargeAmount
        {
            get;
            set;
        }

        DateTime? InOutDatePrinted
        {
            get;
            set;
        }

        string InOutSalesRepresentative
        {
            get;
            set;
        }

        int? InOutNumberOfPackages
        {
            get;
            set;
        }

        DateTime? InOutPickDate
        {
            get;
            set;
        }

        DateTime? InOutShipDate
        {
            get;
            set;
        }

        string InOutTrackingNumber
        {
            get;
            set;
        }

        DateTime? InOutDateReceived
        {
            get;
            set;
        }

        bool? InOutIsInTransit
        {
            get;
            set;
        }

        bool? InOutIsApproved
        {
            get;
            set;
        }

        bool? InOutIsInDispute
        {
            get;
            set;
        }

        decimal? InOutVolume
        {
            get;
            set;
        }

        decimal? InOutWeight
        {
            get;
            set;
        }

        string InOutRmaNumber
        {
            get;
            set;
        }

        string InOutReversalNumber
        {
            get;
            set;
        }

        bool? InOutIsDropShip
        {
            get;
            set;
        }

        string InOutDropShipBusinessPartnerId
        {
            get;
            set;
        }

        string InOutCreatedBy
        {
            get;
            set;
        }

        DateTime? InOutCreatedAt
        {
            get;
            set;
        }

        string InOutUpdatedBy
        {
            get;
            set;
        }

        DateTime? InOutUpdatedAt
        {
            get;
            set;
        }

        bool? InOutActive
        {
            get;
            set;
        }

        bool? InOutDeleted
        {
            get;
            set;
        }

        long? InOutVersion
        {
            get;
            set;
        }

        string CreatedBy
        {
            get;
            set;
        }

        DateTime? CreatedAt
        {
            get;
            set;
        }

        string UpdatedBy
        {
            get;
            set;
        }

        DateTime? UpdatedAt
        {
            get;
            set;
        }

        IInOutLineMvoState ToInOutLineMvoState();

    }

}
