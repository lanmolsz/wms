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

	public abstract class InOutStateEventDtoBase : IStateEventDto, IInOutStateCreated, IInOutStateMergePatched
	{

        private InOutEventId _inOutEventId;

		protected internal virtual InOutEventId InOutEventId 
        {
            get 
            {
                if (_inOutEventId == null) { _inOutEventId = new InOutEventId(); }
                return _inOutEventId;
            }
            set
            {
                _inOutEventId = value;
            }
        }

        public virtual string DocumentNumber
        {
            get { return InOutEventId.DocumentNumber; }
            set { InOutEventId.DocumentNumber = value; }
        }

        public virtual long Version
        {
            get { return InOutEventId.Version; }
            set { InOutEventId.Version = value; }
        }

		public virtual string DocumentStatusId { get; set; }

		public virtual bool? Posted { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string Processing { get; set; }

		public virtual string DocumentTypeId { get; set; }

		public virtual string Description { get; set; }

		public virtual string OrderId { get; set; }

		public virtual DateTime? DateOrdered { get; set; }

		public virtual bool? IsPrinted { get; set; }

		public virtual string MovementTypeId { get; set; }

		public virtual DateTime? MovementDate { get; set; }

		public virtual string BusinessPartnerId { get; set; }

		public virtual string WarehouseId { get; set; }

		public virtual string POReference { get; set; }

		public virtual decimal? FreightAmount { get; set; }

		public virtual string ShipperId { get; set; }

		public virtual decimal? ChargeAmount { get; set; }

		public virtual DateTime? DatePrinted { get; set; }

		public virtual string CreatedFrom { get; set; }

		public virtual string SalesRepresentativeId { get; set; }

		public virtual int? NumberOfPackages { get; set; }

		public virtual DateTime? PickDate { get; set; }

		public virtual DateTime? ShipDate { get; set; }

		public virtual string TrackingNumber { get; set; }

		public virtual DateTime? DateReceived { get; set; }

		public virtual bool? IsInTransit { get; set; }

		public virtual bool? IsApproved { get; set; }

		public virtual bool? IsInDispute { get; set; }

		public virtual string RmaDocumentNumber { get; set; }

		public virtual string ReversalDocumentNumber { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InOutEventId IGlobalIdentity<InOutEventId>.GlobalId {
			get 
			{
				return this.InOutEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IInOutStateEvent.ReadOnly
        {
            get
            {
                return this.EventReadOnly;
            }
            set
            {
                this.EventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyDocumentStatusIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDocumentStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDocumentStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDocumentStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPostedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyPostedRemoved
        {
            get 
            {
                var b = this.IsPropertyPostedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPostedRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyProcessedRemoved
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

		public virtual bool? IsPropertyProcessingRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyProcessingRemoved
        {
            get 
            {
                var b = this.IsPropertyProcessingRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProcessingRemoved = value;
            }
        }

		public virtual bool? IsPropertyDocumentTypeIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDocumentTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDocumentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDocumentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyOrderIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyOrderIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOrderIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOrderIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDateOrderedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDateOrderedRemoved
        {
            get 
            {
                var b = this.IsPropertyDateOrderedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDateOrderedRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsPrintedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyIsPrintedRemoved
        {
            get 
            {
                var b = this.IsPropertyIsPrintedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsPrintedRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementTypeIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyMovementTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementDateRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyMovementDateRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyBusinessPartnerIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyBusinessPartnerIdRemoved
        {
            get 
            {
                var b = this.IsPropertyBusinessPartnerIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyBusinessPartnerIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyWarehouseIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyWarehouseIdRemoved
        {
            get 
            {
                var b = this.IsPropertyWarehouseIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyWarehouseIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPOReferenceRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyPOReferenceRemoved
        {
            get 
            {
                var b = this.IsPropertyPOReferenceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPOReferenceRemoved = value;
            }
        }

		public virtual bool? IsPropertyFreightAmountRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyFreightAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyFreightAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyFreightAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipperIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyShipperIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipperIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipperIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyChargeAmountRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyChargeAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyChargeAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyChargeAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyDatePrintedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDatePrintedRemoved
        {
            get 
            {
                var b = this.IsPropertyDatePrintedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDatePrintedRemoved = value;
            }
        }

		public virtual bool? IsPropertyCreatedFromRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyCreatedFromRemoved
        {
            get 
            {
                var b = this.IsPropertyCreatedFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCreatedFromRemoved = value;
            }
        }

		public virtual bool? IsPropertySalesRepresentativeIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertySalesRepresentativeIdRemoved
        {
            get 
            {
                var b = this.IsPropertySalesRepresentativeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySalesRepresentativeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyNumberOfPackagesRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyNumberOfPackagesRemoved
        {
            get 
            {
                var b = this.IsPropertyNumberOfPackagesRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyNumberOfPackagesRemoved = value;
            }
        }

		public virtual bool? IsPropertyPickDateRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyPickDateRemoved
        {
            get 
            {
                var b = this.IsPropertyPickDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPickDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipDateRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyShipDateRemoved
        {
            get 
            {
                var b = this.IsPropertyShipDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyTrackingNumberRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyTrackingNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyTrackingNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyTrackingNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyDateReceivedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDateReceivedRemoved
        {
            get 
            {
                var b = this.IsPropertyDateReceivedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDateReceivedRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInTransitRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyIsInTransitRemoved
        {
            get 
            {
                var b = this.IsPropertyIsInTransitRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsInTransitRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsApprovedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyIsApprovedRemoved
        {
            get 
            {
                var b = this.IsPropertyIsApprovedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsApprovedRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInDisputeRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyIsInDisputeRemoved
        {
            get 
            {
                var b = this.IsPropertyIsInDisputeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsInDisputeRemoved = value;
            }
        }

		public virtual bool? IsPropertyRmaDocumentNumberRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyRmaDocumentNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyRmaDocumentNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyRmaDocumentNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyReversalDocumentNumberRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyReversalDocumentNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyReversalDocumentNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReversalDocumentNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyActiveRemoved
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


        private InOutLineStateCreatedOrMergePatchedOrRemovedDtos _inOutLineEvents = new InOutLineStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual InOutLineStateCreatedOrMergePatchedOrRemovedDto[] InOutLineEvents
        {
            get
            {
                return _inOutLineEvents.ToArray();
            }
            set
            {
                _inOutLineEvents.Clear();
                _inOutLineEvents.AddRange(value);
            }
        }



        private InOutLineEventId NewInOutLineEventId(string lineNumber)
        {
            var eId = new InOutLineEventId();
            eId.InOutDocumentNumber = this.InOutEventId.DocumentNumber;
            eId.LineNumber = lineNumber;
            eId.InOutVersion = this.InOutEventId.Version;
            return eId;
        }

        public virtual InOutLineStateCreatedDto NewInOutLineStateCreated(string lineNumber)
        {
            var e = new InOutLineStateCreatedDto();
            var eId = NewInOutLineEventId(lineNumber);
            e.InOutLineEventId = eId;
            return e;
        }

        public virtual InOutLineStateMergePatchedDto NewInOutLineStateMergePatched(string lineNumber)
        {
            var e = new InOutLineStateMergePatchedDto();
            var eId = NewInOutLineEventId(lineNumber);
            e.InOutLineEventId = eId;
            return e;
        }

        public virtual InOutLineStateRemovedDto NewInOutLineStateRemoved(string lineNumber)
        {
            var e = new InOutLineStateRemovedDto();
            var eId = NewInOutLineEventId(lineNumber);
            e.InOutLineEventId = eId;
            return e;
        }

        IEnumerable<IInOutLineStateCreated> IInOutStateCreated.InOutLineEvents
        {
            get { return this._inOutLineEvents; }
        }

        void IInOutStateCreated.AddInOutLineEvent(IInOutLineStateCreated e)
        {
            this._inOutLineEvents.AddInOutLineEvent(e);
        }

        IInOutLineStateCreated IInOutStateCreated.NewInOutLineStateCreated(string lineNumber)
        {
            return NewInOutLineStateCreated(lineNumber);
        }

        IEnumerable<IInOutLineStateEvent> IInOutStateMergePatched.InOutLineEvents
        {
            get { return this._inOutLineEvents; }
        }

        void IInOutStateMergePatched.AddInOutLineEvent(IInOutLineStateEvent e)
        {
            this._inOutLineEvents.AddInOutLineEvent(e);
        }

        IInOutLineStateCreated IInOutStateMergePatched.NewInOutLineStateCreated(string lineNumber)
        {
            return NewInOutLineStateCreated(lineNumber);
        }

        IInOutLineStateMergePatched IInOutStateMergePatched.NewInOutLineStateMergePatched(string lineNumber)
        {
            return NewInOutLineStateMergePatched(lineNumber);
        }

        IInOutLineStateRemoved IInOutStateMergePatched.NewInOutLineStateRemoved(string lineNumber)
        {
            return NewInOutLineStateRemoved(lineNumber);
        }


        InOutEventId IInOutStateEvent.InOutEventId
        {
            get { return this.InOutEventId; }
        }

        protected InOutStateEventDtoBase()
        {
        }

        protected InOutStateEventDtoBase(InOutEventId stateEventId)
        {
            this.InOutEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class InOutStateCreatedOrMergePatchedOrDeletedDto : InOutStateEventDtoBase
    {
        private string _eventType;

        public virtual string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._eventType;
        }

    }



	public class InOutStateCreatedDto : InOutStateCreatedOrMergePatchedOrDeletedDto
	{
		public InOutStateCreatedDto()
		{
		}

        public override string EventType
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


	public class InOutStateMergePatchedDto : InOutStateCreatedOrMergePatchedOrDeletedDto
	{
		public InOutStateMergePatchedDto()
		{
		}

        public override string EventType
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


	public class InOutStateDeletedDto : InOutStateCreatedOrMergePatchedOrDeletedDto
	{
		public InOutStateDeletedDto()
		{
		}

        public override string EventType
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


    public partial class InOutStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IInOutStateCreated>, IEnumerable<IInOutStateMergePatched>
    {
        private List<InOutStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<InOutStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual InOutStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<InOutStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInOutStateCreated> IEnumerable<IInOutStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInOutStateMergePatched> IEnumerable<IInOutStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddInOutEvent(IInOutStateCreated e)
        {
            _innerStateEvents.Add((InOutStateCreatedDto)e);
        }

        public void AddInOutEvent(IInOutStateEvent e)
        {
            _innerStateEvents.Add((InOutStateCreatedOrMergePatchedOrDeletedDto)e);
        }


    }


}

