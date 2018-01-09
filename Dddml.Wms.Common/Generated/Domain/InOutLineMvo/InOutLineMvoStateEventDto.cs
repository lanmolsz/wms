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

	public abstract class InOutLineMvoStateEventDtoBase : IStateEventDto, IInOutLineMvoStateCreated, IInOutLineMvoStateMergePatched, IInOutLineMvoStateDeleted
	{

        private InOutLineMvoStateEventIdDto _stateEventId;

		protected internal virtual InOutLineMvoStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new InOutLineMvoStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual InOutLineIdDto InOutLineId
        {
            get { return StateEventId.InOutLineId; }
            set { StateEventId.InOutLineId = value; }
        }

        public virtual long InOutVersion
        {
            get { return StateEventId.InOutVersion; }
            set { StateEventId.InOutVersion = value; }
        }

		public virtual string LocatorId { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual string Description { get; set; }

		public virtual string QuantityUomId { get; set; }

		public virtual decimal? MovementQuantity { get; set; }

		public virtual decimal? PickedQuantity { get; set; }

		public virtual bool? IsInvoiced { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string RmaLineNumber { get; set; }

		public virtual string ReversalLineNumber { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string InOutDocumentStatusId { get; set; }

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

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InOutLineMvoStateEventId IGlobalIdentity<InOutLineMvoStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToInOutLineMvoStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IInOutLineMvoStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyLocatorIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyLocatorIdRemoved
        {
            get 
            {
                var b = this.IsPropertyLocatorIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLocatorIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyProductIdRemoved
        {
            get 
            {
                var b = this.IsPropertyProductIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetInstanceIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyAttributeSetInstanceIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetInstanceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetInstanceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuantityUomIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyQuantityUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyQuantityUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyQuantityUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementQuantityRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyMovementQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyPickedQuantityRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyPickedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyPickedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPickedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInvoicedRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyIsInvoicedRemoved
        {
            get 
            {
                var b = this.IsPropertyIsInvoicedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsInvoicedRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyProcessedRemoved
        {
            get 
            {
                var b = this.IsPropertyProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyRmaLineNumberRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyRmaLineNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyRmaLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyRmaLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyReversalLineNumberRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyReversalLineNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyReversalLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReversalLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyVersionRemoved
        {
            get 
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutDocumentStatusIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutDocumentStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutDocumentStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutDocumentStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutPostedRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutPostedRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutPostedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutPostedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutProcessedRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutProcessedRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutProcessingRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutProcessingRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutProcessingRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutProcessingRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutDocumentTypeIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutDocumentTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutDocumentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutDocumentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutDescriptionRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutOrderIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutOrderIdRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutOrderIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutOrderIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutDateOrderedRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutDateOrderedRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutDateOrderedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutDateOrderedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutIsPrintedRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutIsPrintedRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutIsPrintedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutIsPrintedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutMovementTypeIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutMovementTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutMovementTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutMovementTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutMovementDateRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutMovementDateRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutMovementDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutMovementDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutBusinessPartnerIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutBusinessPartnerIdRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutBusinessPartnerIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutBusinessPartnerIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutWarehouseIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutWarehouseIdRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutWarehouseIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutWarehouseIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutPOReferenceRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutPOReferenceRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutPOReferenceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutPOReferenceRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutFreightAmountRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutFreightAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutFreightAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutFreightAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutShipperIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutShipperIdRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutShipperIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutShipperIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutChargeAmountRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutChargeAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutChargeAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutChargeAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutDatePrintedRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutDatePrintedRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutDatePrintedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutDatePrintedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutCreatedFromRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutCreatedFromRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutCreatedFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutCreatedFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutSalesRepresentativeIdRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutSalesRepresentativeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutSalesRepresentativeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutSalesRepresentativeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutNumberOfPackagesRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutNumberOfPackagesRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutNumberOfPackagesRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutNumberOfPackagesRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutPickDateRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutPickDateRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutPickDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutPickDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutShipDateRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutShipDateRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutShipDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutShipDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutTrackingNumberRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutTrackingNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutTrackingNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutTrackingNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutDateReceivedRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutDateReceivedRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutDateReceivedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutDateReceivedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutIsInTransitRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutIsInTransitRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutIsInTransitRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutIsInTransitRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutIsApprovedRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutIsApprovedRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutIsApprovedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutIsApprovedRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutIsInDisputeRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutIsInDisputeRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutIsInDisputeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutIsInDisputeRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutRmaDocumentNumberRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutRmaDocumentNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutRmaDocumentNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutRmaDocumentNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutReversalDocumentNumberRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutReversalDocumentNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutReversalDocumentNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutReversalDocumentNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutCreatedByRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutCreatedAtRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutUpdatedByRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutUpdatedAtRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyInOutActiveRemoved { get; set; }

        bool IInOutLineMvoStateMergePatched.IsPropertyInOutActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyInOutActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInOutActiveRemoved = value;
            }
        }

		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}


        InOutLineMvoStateEventId IInOutLineMvoStateEvent.StateEventId
        {
            get { return this.StateEventId.ToInOutLineMvoStateEventId(); }
        }

        protected InOutLineMvoStateEventDtoBase()
        {
        }

        protected InOutLineMvoStateEventDtoBase(InOutLineMvoStateEventIdDto stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class InOutLineMvoStateCreatedOrMergePatchedOrDeletedDto : InOutLineMvoStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class InOutLineMvoStateCreatedDto : InOutLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public InOutLineMvoStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class InOutLineMvoStateMergePatchedDto : InOutLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public InOutLineMvoStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class InOutLineMvoStateDeletedDto : InOutLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public InOutLineMvoStateDeletedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class InOutLineMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IInOutLineMvoStateCreated>, IEnumerable<IInOutLineMvoStateMergePatched>, IEnumerable<IInOutLineMvoStateDeleted>
    {
        private List<InOutLineMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<InOutLineMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual InOutLineMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<InOutLineMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInOutLineMvoStateCreated> IEnumerable<IInOutLineMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInOutLineMvoStateMergePatched> IEnumerable<IInOutLineMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInOutLineMvoStateDeleted> IEnumerable<IInOutLineMvoStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddInOutLineMvoEvent(IInOutLineMvoStateCreated e)
        {
            _innerStateEvents.Add((InOutLineMvoStateCreatedDto)e);
        }

        public void AddInOutLineMvoEvent(IInOutLineMvoStateEvent e)
        {
            _innerStateEvents.Add((InOutLineMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddInOutLineMvoEvent(IInOutLineMvoStateDeleted e)
        {
            _innerStateEvents.Add((InOutLineMvoStateDeletedDto)e);
        }

    }


}

