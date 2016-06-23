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

	public abstract class InOutCommandDtoBase : ICommandDto, ICreateInOut, IMergePatchInOut, IDeleteInOut
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteInOut)this).DocumentNumber;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

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

		public virtual string DocumentNumber { get; set; }

		public virtual bool? IsSOTransaction { get; set; }


		public virtual DocumentActionDto DocumentAction { get; set; }

        DocumentAction ICreateOrMergePatchOrDeleteInOut.DocumentAction
        {
            get 
            {
                return this.DocumentAction.ToDocumentAction();
            }
            set 
            {
                this.DocumentAction = new DocumentActionDto(value);
            }
        }

		public virtual bool? Posted { get; set; }

		public virtual bool? Processing { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual int? DocumentType { get; set; }

		public virtual string Description { get; set; }

		public virtual string OrderNumber { get; set; }

		public virtual DateTime? DateOrdered { get; set; }

		public virtual bool? IsPrinted { get; set; }

		public virtual string MovementType { get; set; }

		public virtual DateTime? MovementDate { get; set; }

		public virtual string BusinessPartnerId { get; set; }

		public virtual string WarehouseId { get; set; }

		public virtual string POReference { get; set; }

		public virtual Money? FreightAmount { get; set; }

		public virtual string ShipperId { get; set; }

		public virtual Money? ChargeAmount { get; set; }

		public virtual DateTime? DatePrinted { get; set; }

		public virtual string SalesRepresentative { get; set; }

		public virtual int? NumberOfPackages { get; set; }

		public virtual DateTime? PickDate { get; set; }

		public virtual DateTime? ShipDate { get; set; }

		public virtual string TrackingNumber { get; set; }

		public virtual DateTime? DateReceived { get; set; }

		public virtual bool? IsInTransit { get; set; }

		public virtual bool? IsApproved { get; set; }

		public virtual bool? IsInDispute { get; set; }

		public virtual decimal? Volume { get; set; }

		public virtual decimal? Weight { get; set; }

		public virtual string RmaNumber { get; set; }

		public virtual string ReversalNumber { get; set; }

		public virtual bool? IsDropShip { get; set; }

		public virtual string DropShipBusinessPartnerId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual bool? IsPropertyIsSOTransactionRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyIsSOTransactionRemoved
        {
            get
            {
                var b = this.IsPropertyIsSOTransactionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsSOTransactionRemoved = value;
            }
        }

		public virtual bool? IsPropertyPostedRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyPostedRemoved
        {
            get
            {
                var b = this.IsPropertyPostedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPostedRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessingRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyProcessingRemoved
        {
            get
            {
                var b = this.IsPropertyProcessingRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyProcessingRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyProcessedRemoved
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

		public virtual bool? IsPropertyDocumentTypeRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyDocumentTypeRemoved
        {
            get
            {
                var b = this.IsPropertyDocumentTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDocumentTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyOrderNumberRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyOrderNumberRemoved
        {
            get
            {
                var b = this.IsPropertyOrderNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyDateOrderedRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyDateOrderedRemoved
        {
            get
            {
                var b = this.IsPropertyDateOrderedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDateOrderedRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsPrintedRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyIsPrintedRemoved
        {
            get
            {
                var b = this.IsPropertyIsPrintedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsPrintedRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementTypeRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyMovementTypeRemoved
        {
            get
            {
                var b = this.IsPropertyMovementTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMovementTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementDateRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyMovementDateRemoved
        {
            get
            {
                var b = this.IsPropertyMovementDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMovementDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyBusinessPartnerIdRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyBusinessPartnerIdRemoved
        {
            get
            {
                var b = this.IsPropertyBusinessPartnerIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyBusinessPartnerIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyWarehouseIdRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyWarehouseIdRemoved
        {
            get
            {
                var b = this.IsPropertyWarehouseIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyWarehouseIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPOReferenceRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyPOReferenceRemoved
        {
            get
            {
                var b = this.IsPropertyPOReferenceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPOReferenceRemoved = value;
            }
        }

		public virtual bool? IsPropertyFreightAmountRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyFreightAmountRemoved
        {
            get
            {
                var b = this.IsPropertyFreightAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyFreightAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipperIdRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyShipperIdRemoved
        {
            get
            {
                var b = this.IsPropertyShipperIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyShipperIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyChargeAmountRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyChargeAmountRemoved
        {
            get
            {
                var b = this.IsPropertyChargeAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyChargeAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyDatePrintedRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyDatePrintedRemoved
        {
            get
            {
                var b = this.IsPropertyDatePrintedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDatePrintedRemoved = value;
            }
        }

		public virtual bool? IsPropertySalesRepresentativeRemoved { get; set; }

        bool IMergePatchInOut.IsPropertySalesRepresentativeRemoved
        {
            get
            {
                var b = this.IsPropertySalesRepresentativeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertySalesRepresentativeRemoved = value;
            }
        }

		public virtual bool? IsPropertyNumberOfPackagesRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyNumberOfPackagesRemoved
        {
            get
            {
                var b = this.IsPropertyNumberOfPackagesRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyNumberOfPackagesRemoved = value;
            }
        }

		public virtual bool? IsPropertyPickDateRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyPickDateRemoved
        {
            get
            {
                var b = this.IsPropertyPickDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPickDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipDateRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyShipDateRemoved
        {
            get
            {
                var b = this.IsPropertyShipDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyShipDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyTrackingNumberRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyTrackingNumberRemoved
        {
            get
            {
                var b = this.IsPropertyTrackingNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyTrackingNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyDateReceivedRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyDateReceivedRemoved
        {
            get
            {
                var b = this.IsPropertyDateReceivedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDateReceivedRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInTransitRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyIsInTransitRemoved
        {
            get
            {
                var b = this.IsPropertyIsInTransitRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsInTransitRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsApprovedRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyIsApprovedRemoved
        {
            get
            {
                var b = this.IsPropertyIsApprovedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsApprovedRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInDisputeRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyIsInDisputeRemoved
        {
            get
            {
                var b = this.IsPropertyIsInDisputeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsInDisputeRemoved = value;
            }
        }

		public virtual bool? IsPropertyVolumeRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyVolumeRemoved
        {
            get
            {
                var b = this.IsPropertyVolumeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyVolumeRemoved = value;
            }
        }

		public virtual bool? IsPropertyWeightRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyWeightRemoved
        {
            get
            {
                var b = this.IsPropertyWeightRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyWeightRemoved = value;
            }
        }

		public virtual bool? IsPropertyRmaNumberRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyRmaNumberRemoved
        {
            get
            {
                var b = this.IsPropertyRmaNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyRmaNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyReversalNumberRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyReversalNumberRemoved
        {
            get
            {
                var b = this.IsPropertyReversalNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyReversalNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsDropShipRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyIsDropShipRemoved
        {
            get
            {
                var b = this.IsPropertyIsDropShipRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsDropShipRemoved = value;
            }
        }

		public virtual bool? IsPropertyDropShipBusinessPartnerIdRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyDropShipBusinessPartnerIdRemoved
        {
            get
            {
                var b = this.IsPropertyDropShipBusinessPartnerIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDropShipBusinessPartnerIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchInOut.IsPropertyActiveRemoved
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

        ICreateInOutLineCommands ICreateInOut.InOutLines
        {
            get
            {
                return this._inOutLines;
            }
        }

        IInOutLineCommands IMergePatchInOut.InOutLineCommands
        {
            get
            {
                return this._inOutLines;
            }
        }

        public virtual CreateInOutLineDto NewCreateInOutLine()
        {
            var c = new CreateInOutLineDto();
            c.InOutDocumentNumber = this.DocumentNumber;

            return c;
        }

        ICreateInOutLine ICreateInOut.NewCreateInOutLine()
        {
            return this.NewCreateInOutLine();
        }

        ICreateInOutLine IMergePatchInOut.NewCreateInOutLine()
        {
            return this.NewCreateInOutLine();
        }

        public virtual MergePatchInOutLineDto NewMergePatchInOutLine()
        {
            var c = new MergePatchInOutLineDto();
            c.InOutDocumentNumber = this.DocumentNumber;

            return c;
        }

        IMergePatchInOutLine IMergePatchInOut.NewMergePatchInOutLine()
        {
            return this.NewMergePatchInOutLine();
        }

        public virtual RemoveInOutLineDto NewRemoveInOutLine()
        {
            var c = new RemoveInOutLineDto();
            c.InOutDocumentNumber = this.DocumentNumber;

            return c;
        }

        IRemoveInOutLine IMergePatchInOut.NewRemoveInOutLine()
        {
            return this.NewRemoveInOutLine();
        }

        private CreateOrMergePatchOrRemoveInOutLineDtos _inOutLines = new CreateOrMergePatchOrRemoveInOutLineDtos();

        public virtual CreateOrMergePatchOrRemoveInOutLineDto[] InOutLines
        {
            get
            {
                return _inOutLines.ToArray();
            }
            set
            {
                _inOutLines.Clear();
                _inOutLines.AddRange(value);
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteInOutDto : InOutCommandDtoBase
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



	public class CreateInOutDto : CreateOrMergePatchOrDeleteInOutDto
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


	public class MergePatchInOutDto : CreateOrMergePatchOrDeleteInOutDto
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

	public class DeleteInOutDto : CreateOrMergePatchOrDeleteInOutDto
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





}
