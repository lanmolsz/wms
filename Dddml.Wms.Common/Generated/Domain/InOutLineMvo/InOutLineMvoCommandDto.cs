﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOutLineMvo
{

	public abstract class InOutLineMvoCommandDtoBase : ICommandDto, ICreateInOutLineMvo, IMergePatchInOutLineMvo, IDeleteInOutLineMvo
	{

		InOutLineId IAggregateCommand<InOutLineId, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteInOutLineMvo)this).InOutLineId;
			}
		}


		long IAggregateCommand<InOutLineId, long>.AggregateVersion
		{
			get
			{
				return this.InOutVersion;
			}
		}

		public virtual long InOutVersion { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual InOutLineIdDto InOutLineId { get; set; }

		public virtual string LocatorId { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual string Description { get; set; }

		public virtual string QuantityUomId { get; set; }

		public virtual decimal? MovementQuantity { get; set; }

		public virtual decimal? PickedQuantity { get; set; }

		public virtual bool? IsInvoiced { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual long? RmaLineNumber { get; set; }

		public virtual long? ReversalLineNumber { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual bool? InOutPosted { get; set; }

		public virtual bool? InOutProcessed { get; set; }

		public virtual string InOutProcessing { get; set; }

		public virtual string InOutDocumentTypeId { get; set; }

		public virtual string InOutDescription { get; set; }

		public virtual string InOutOrderId { get; set; }

		public virtual DateTime? InOutDateOrdered { get; set; }

		public virtual bool? InOutIsPrinted { get; set; }

		public virtual string InOutMovementTypeId { get; set; }

		public virtual DateTime? InOutMovementDate { get; set; }

		public virtual string InOutBusinessPartnerId { get; set; }

		public virtual string InOutWarehouseId { get; set; }

		public virtual string InOutPOReference { get; set; }

		public virtual decimal? InOutFreightAmount { get; set; }

		public virtual string InOutShipperId { get; set; }

		public virtual decimal? InOutChargeAmount { get; set; }

		public virtual DateTime? InOutDatePrinted { get; set; }

		public virtual string InOutCreatedFrom { get; set; }

		public virtual string InOutSalesRepresentativeId { get; set; }

		public virtual int? InOutNumberOfPackages { get; set; }

		public virtual DateTime? InOutPickDate { get; set; }

		public virtual DateTime? InOutShipDate { get; set; }

		public virtual string InOutTrackingNumber { get; set; }

		public virtual DateTime? InOutDateReceived { get; set; }

		public virtual bool? InOutIsInTransit { get; set; }

		public virtual bool? InOutIsApproved { get; set; }

		public virtual bool? InOutIsInDispute { get; set; }

		public virtual string InOutRmaDocumentNumber { get; set; }

		public virtual string InOutReversalDocumentNumber { get; set; }

		public virtual string InOutCreatedBy { get; set; }

		public virtual DateTime? InOutCreatedAt { get; set; }

		public virtual string InOutUpdatedBy { get; set; }

		public virtual DateTime? InOutUpdatedAt { get; set; }

		public virtual bool? InOutActive { get; set; }


        InOutLineId IInOutLineMvoCommand.InOutLineId
        {
            get 
            {
                return this.InOutLineId.ToInOutLineId();
            }
            set 
            {
                this.InOutLineId = new InOutLineIdDtoWrapper(value);
            }
        }

		public virtual bool? IsPropertyLocatorIdRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyLocatorIdRemoved
        {
            get
            {
                var b = this.IsPropertyLocatorIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyLocatorIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductIdRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyProductIdRemoved
        {
            get
            {
                var b = this.IsPropertyProductIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyProductIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetInstanceIdRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyAttributeSetInstanceIdRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeSetInstanceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeSetInstanceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuantityUomIdRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyQuantityUomIdRemoved
        {
            get
            {
                var b = this.IsPropertyQuantityUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyQuantityUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementQuantityRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyMovementQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyMovementQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMovementQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyPickedQuantityRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyPickedQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyPickedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPickedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInvoicedRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyIsInvoicedRemoved
        {
            get
            {
                var b = this.IsPropertyIsInvoicedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsInvoicedRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyProcessedRemoved
        {
            get
            {
                var b = this.IsPropertyProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyRmaLineNumberRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyRmaLineNumberRemoved
        {
            get
            {
                var b = this.IsPropertyRmaLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyRmaLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyReversalLineNumberRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyReversalLineNumberRemoved
        {
            get
            {
                var b = this.IsPropertyReversalLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyReversalLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyVersionRemoved
        {
            get
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutPostedRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutPostedRemoved
        {
            get
            {
                var b = this.IsPropertyInOutPostedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutPostedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutProcessedRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutProcessedRemoved
        {
            get
            {
                var b = this.IsPropertyInOutProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutProcessingRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutProcessingRemoved
        {
            get
            {
                var b = this.IsPropertyInOutProcessingRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutProcessingRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutDocumentTypeIdRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutDocumentTypeIdRemoved
        {
            get
            {
                var b = this.IsPropertyInOutDocumentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutDocumentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutDescriptionRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyInOutDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutOrderIdRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutOrderIdRemoved
        {
            get
            {
                var b = this.IsPropertyInOutOrderIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutOrderIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutDateOrderedRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutDateOrderedRemoved
        {
            get
            {
                var b = this.IsPropertyInOutDateOrderedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutDateOrderedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutIsPrintedRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutIsPrintedRemoved
        {
            get
            {
                var b = this.IsPropertyInOutIsPrintedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutIsPrintedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutMovementTypeIdRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutMovementTypeIdRemoved
        {
            get
            {
                var b = this.IsPropertyInOutMovementTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutMovementTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutMovementDateRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutMovementDateRemoved
        {
            get
            {
                var b = this.IsPropertyInOutMovementDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutMovementDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutBusinessPartnerIdRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutBusinessPartnerIdRemoved
        {
            get
            {
                var b = this.IsPropertyInOutBusinessPartnerIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutBusinessPartnerIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutWarehouseIdRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutWarehouseIdRemoved
        {
            get
            {
                var b = this.IsPropertyInOutWarehouseIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutWarehouseIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutPOReferenceRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutPOReferenceRemoved
        {
            get
            {
                var b = this.IsPropertyInOutPOReferenceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutPOReferenceRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutFreightAmountRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutFreightAmountRemoved
        {
            get
            {
                var b = this.IsPropertyInOutFreightAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutFreightAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutShipperIdRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutShipperIdRemoved
        {
            get
            {
                var b = this.IsPropertyInOutShipperIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutShipperIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutChargeAmountRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutChargeAmountRemoved
        {
            get
            {
                var b = this.IsPropertyInOutChargeAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutChargeAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutDatePrintedRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutDatePrintedRemoved
        {
            get
            {
                var b = this.IsPropertyInOutDatePrintedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutDatePrintedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutCreatedFromRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutCreatedFromRemoved
        {
            get
            {
                var b = this.IsPropertyInOutCreatedFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutCreatedFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutSalesRepresentativeIdRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutSalesRepresentativeIdRemoved
        {
            get
            {
                var b = this.IsPropertyInOutSalesRepresentativeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutSalesRepresentativeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutNumberOfPackagesRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutNumberOfPackagesRemoved
        {
            get
            {
                var b = this.IsPropertyInOutNumberOfPackagesRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutNumberOfPackagesRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutPickDateRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutPickDateRemoved
        {
            get
            {
                var b = this.IsPropertyInOutPickDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutPickDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutShipDateRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutShipDateRemoved
        {
            get
            {
                var b = this.IsPropertyInOutShipDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutShipDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutTrackingNumberRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutTrackingNumberRemoved
        {
            get
            {
                var b = this.IsPropertyInOutTrackingNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutTrackingNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutDateReceivedRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutDateReceivedRemoved
        {
            get
            {
                var b = this.IsPropertyInOutDateReceivedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutDateReceivedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutIsInTransitRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutIsInTransitRemoved
        {
            get
            {
                var b = this.IsPropertyInOutIsInTransitRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutIsInTransitRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutIsApprovedRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutIsApprovedRemoved
        {
            get
            {
                var b = this.IsPropertyInOutIsApprovedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutIsApprovedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutIsInDisputeRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutIsInDisputeRemoved
        {
            get
            {
                var b = this.IsPropertyInOutIsInDisputeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutIsInDisputeRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutRmaDocumentNumberRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutRmaDocumentNumberRemoved
        {
            get
            {
                var b = this.IsPropertyInOutRmaDocumentNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutRmaDocumentNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutReversalDocumentNumberRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutReversalDocumentNumberRemoved
        {
            get
            {
                var b = this.IsPropertyInOutReversalDocumentNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutReversalDocumentNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutCreatedByRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutCreatedByRemoved
        {
            get
            {
                var b = this.IsPropertyInOutCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutCreatedAtRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutCreatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyInOutCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutUpdatedByRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutUpdatedByRemoved
        {
            get
            {
                var b = this.IsPropertyInOutUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutUpdatedAtRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutUpdatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyInOutUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutActiveRemoved { get; set; }

        bool IMergePatchInOutLineMvo.IsPropertyInOutActiveRemoved
        {
            get
            {
                var b = this.IsPropertyInOutActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInOutActiveRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteInOutLineMvoDto : InOutLineMvoCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateInOutLineMvoDto : CreateOrMergePatchOrDeleteInOutLineMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchInOutLineMvoDto : CreateOrMergePatchOrDeleteInOutLineMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteInOutLineMvoDto : CreateOrMergePatchOrDeleteInOutLineMvoDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}

    public static partial class InOutLineMvoCommandDtos
    {

    }

}

