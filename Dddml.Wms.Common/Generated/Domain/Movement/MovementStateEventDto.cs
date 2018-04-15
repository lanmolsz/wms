﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.Movement
{

	public abstract class MovementStateEventDtoBase : IStateEventDto, IMovementStateCreated, IMovementStateMergePatched, IMovementStateDeleted
	{

        private MovementEventId _movementEventId;

		protected internal virtual MovementEventId MovementEventId 
        {
            get 
            {
                if (_movementEventId == null) { _movementEventId = new MovementEventId(); }
                return _movementEventId;
            }
            set
            {
                _movementEventId = value;
            }
        }

        public virtual string DocumentNumber
        {
            get { return MovementEventId.DocumentNumber; }
            set { MovementEventId.DocumentNumber = value; }
        }

        public virtual long Version
        {
            get { return MovementEventId.Version; }
            set { MovementEventId.Version = value; }
        }

		public virtual string DocumentStatusId { get; set; }

		public virtual DateTime? MovementDate { get; set; }

		public virtual bool? Posted { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string Processing { get; set; }

		public virtual DateTime? DateReceived { get; set; }

		public virtual string DocumentTypeId { get; set; }

		public virtual bool? IsInTransit { get; set; }

		public virtual bool? IsApproved { get; set; }

		public virtual decimal? ApprovalAmount { get; set; }

		public virtual string ShipperId { get; set; }

		public virtual string SalesRepresentativeId { get; set; }

		public virtual string BusinessPartnerId { get; set; }

		public virtual decimal? ChargeAmount { get; set; }

		public virtual string CreateFrom { get; set; }

		public virtual decimal? FreightAmount { get; set; }

		public virtual string ReversalDocumentNumber { get; set; }

		public virtual string WarehouseIdFrom { get; set; }

		public virtual string WarehouseIdTo { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		MovementEventId IGlobalIdentity<MovementEventId>.GlobalId {
			get 
			{
				return this.MovementEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IMovementStateEvent.ReadOnly
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

        bool IMovementStateMergePatched.IsPropertyDocumentStatusIdRemoved
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

		public virtual bool? IsPropertyMovementDateRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyMovementDateRemoved
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

		public virtual bool? IsPropertyPostedRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyPostedRemoved
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

        bool IMovementStateMergePatched.IsPropertyProcessedRemoved
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

        bool IMovementStateMergePatched.IsPropertyProcessingRemoved
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

		public virtual bool? IsPropertyDateReceivedRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyDateReceivedRemoved
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

		public virtual bool? IsPropertyDocumentTypeIdRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyDocumentTypeIdRemoved
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

		public virtual bool? IsPropertyIsInTransitRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyIsInTransitRemoved
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

        bool IMovementStateMergePatched.IsPropertyIsApprovedRemoved
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

		public virtual bool? IsPropertyApprovalAmountRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyApprovalAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyApprovalAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyApprovalAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipperIdRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyShipperIdRemoved
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

		public virtual bool? IsPropertySalesRepresentativeIdRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertySalesRepresentativeIdRemoved
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

		public virtual bool? IsPropertyBusinessPartnerIdRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyBusinessPartnerIdRemoved
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

		public virtual bool? IsPropertyChargeAmountRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyChargeAmountRemoved
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

		public virtual bool? IsPropertyCreateFromRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyCreateFromRemoved
        {
            get 
            {
                var b = this.IsPropertyCreateFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCreateFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyFreightAmountRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyFreightAmountRemoved
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

		public virtual bool? IsPropertyReversalDocumentNumberRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyReversalDocumentNumberRemoved
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

		public virtual bool? IsPropertyWarehouseIdFromRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyWarehouseIdFromRemoved
        {
            get 
            {
                var b = this.IsPropertyWarehouseIdFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyWarehouseIdFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyWarehouseIdToRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyWarehouseIdToRemoved
        {
            get 
            {
                var b = this.IsPropertyWarehouseIdToRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyWarehouseIdToRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyActiveRemoved
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


        private MovementLineStateCreatedOrMergePatchedOrRemovedDtos _movementLineEvents = new MovementLineStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual MovementLineStateCreatedOrMergePatchedOrRemovedDto[] MovementLineEvents
        {
            get
            {
                return _movementLineEvents.ToArray();
            }
            set
            {
                _movementLineEvents.Clear();
                _movementLineEvents.AddRange(value);
            }
        }



        private MovementLineEventId NewMovementLineEventId(string lineNumber)
        {
            var eId = new MovementLineEventId();
            eId.MovementDocumentNumber = this.MovementEventId.DocumentNumber;
            eId.LineNumber = lineNumber;
            eId.MovementVersion = this.MovementEventId.Version;
            return eId;
        }

        public virtual MovementLineStateCreatedDto NewMovementLineStateCreated(string lineNumber)
        {
            var e = new MovementLineStateCreatedDto();
            var eId = NewMovementLineEventId(lineNumber);
            e.MovementLineEventId = eId;
            return e;
        }

        public virtual MovementLineStateMergePatchedDto NewMovementLineStateMergePatched(string lineNumber)
        {
            var e = new MovementLineStateMergePatchedDto();
            var eId = NewMovementLineEventId(lineNumber);
            e.MovementLineEventId = eId;
            return e;
        }

        public virtual MovementLineStateRemovedDto NewMovementLineStateRemoved(string lineNumber)
        {
            var e = new MovementLineStateRemovedDto();
            var eId = NewMovementLineEventId(lineNumber);
            e.MovementLineEventId = eId;
            return e;
        }

        IEnumerable<IMovementLineStateCreated> IMovementStateCreated.MovementLineEvents
        {
            get { return this._movementLineEvents; }
        }

        void IMovementStateCreated.AddMovementLineEvent(IMovementLineStateCreated e)
        {
            this._movementLineEvents.AddMovementLineEvent(e);
        }

        IMovementLineStateCreated IMovementStateCreated.NewMovementLineStateCreated(string lineNumber)
        {
            return NewMovementLineStateCreated(lineNumber);
        }

        IEnumerable<IMovementLineStateEvent> IMovementStateMergePatched.MovementLineEvents
        {
            get { return this._movementLineEvents; }
        }

        void IMovementStateMergePatched.AddMovementLineEvent(IMovementLineStateEvent e)
        {
            this._movementLineEvents.AddMovementLineEvent(e);
        }

        IMovementLineStateCreated IMovementStateMergePatched.NewMovementLineStateCreated(string lineNumber)
        {
            return NewMovementLineStateCreated(lineNumber);
        }

        IMovementLineStateMergePatched IMovementStateMergePatched.NewMovementLineStateMergePatched(string lineNumber)
        {
            return NewMovementLineStateMergePatched(lineNumber);
        }

        IMovementLineStateRemoved IMovementStateMergePatched.NewMovementLineStateRemoved(string lineNumber)
        {
            return NewMovementLineStateRemoved(lineNumber);
        }


        IEnumerable<IMovementLineStateRemoved> IMovementStateDeleted.MovementLineEvents
        {
            get { return this._movementLineEvents; }
        }

        void IMovementStateDeleted.AddMovementLineEvent(IMovementLineStateRemoved e)
        {
            this._movementLineEvents.AddMovementLineEvent(e);
        }

        IMovementLineStateRemoved IMovementStateDeleted.NewMovementLineStateRemoved(string lineNumber)
        {
            return NewMovementLineStateRemoved(lineNumber);
        }



        MovementEventId IMovementStateEvent.MovementEventId
        {
            get { return this.MovementEventId; }
        }

        protected MovementStateEventDtoBase()
        {
        }

        protected MovementStateEventDtoBase(MovementEventId stateEventId)
        {
            this.MovementEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class MovementStateCreatedOrMergePatchedOrDeletedDto : MovementStateEventDtoBase
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



	public class MovementStateCreatedDto : MovementStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementStateCreatedDto()
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


	public class MovementStateMergePatchedDto : MovementStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementStateMergePatchedDto()
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


	public class MovementStateDeletedDto : MovementStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementStateDeletedDto()
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


    public partial class MovementStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IMovementStateCreated>, IEnumerable<IMovementStateMergePatched>, IEnumerable<IMovementStateDeleted>
    {
        private List<MovementStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<MovementStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual MovementStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<MovementStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementStateCreated> IEnumerable<IMovementStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementStateMergePatched> IEnumerable<IMovementStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementStateDeleted> IEnumerable<IMovementStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddMovementEvent(IMovementStateCreated e)
        {
            _innerStateEvents.Add((MovementStateCreatedDto)e);
        }

        public void AddMovementEvent(IMovementStateEvent e)
        {
            _innerStateEvents.Add((MovementStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddMovementEvent(IMovementStateDeleted e)
        {
            _innerStateEvents.Add((MovementStateDeletedDto)e);
        }

    }


}

