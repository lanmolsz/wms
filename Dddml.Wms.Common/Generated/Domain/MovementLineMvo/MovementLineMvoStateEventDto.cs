﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementLineMvo;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.MovementLineMvo
{

	public abstract class MovementLineMvoStateEventDtoBase : IStateEventDto, IMovementLineMvoStateCreated, IMovementLineMvoStateMergePatched, IMovementLineMvoStateDeleted
	{

        private MovementLineMvoEventIdDto _stateEventId;

		protected internal virtual MovementLineMvoEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new MovementLineMvoEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual MovementLineIdDto MovementLineId
        {
            get { return StateEventId.MovementLineId; }
            set { StateEventId.MovementLineId = value; }
        }

        public virtual long MovementVersion
        {
            get { return StateEventId.MovementVersion; }
            set { StateEventId.MovementVersion = value; }
        }

		public virtual decimal? MovementQuantity { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string LocatorIdFrom { get; set; }

		public virtual string LocatorIdTo { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string ReversalLineNumber { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string MovementDocumentStatusId { get; set; }

		public virtual DateTime? MovementMovementDate { get; set; }

		public virtual bool? MovementPosted { get; set; }

		public virtual bool? MovementProcessed { get; set; }

		public virtual string MovementProcessing { get; set; }

		public virtual DateTime? MovementDateReceived { get; set; }

		public virtual string MovementDocumentTypeId { get; set; }

		public virtual bool? MovementIsInTransit { get; set; }

		public virtual bool? MovementIsApproved { get; set; }

		public virtual decimal? MovementApprovalAmount { get; set; }

		public virtual string MovementShipperId { get; set; }

		public virtual string MovementSalesRepresentativeId { get; set; }

		public virtual string MovementBusinessPartnerId { get; set; }

		public virtual decimal? MovementChargeAmount { get; set; }

		public virtual string MovementCreateFrom { get; set; }

		public virtual decimal? MovementFreightAmount { get; set; }

		public virtual string MovementReversalDocumentNumber { get; set; }

		public virtual string MovementWarehouseIdFrom { get; set; }

		public virtual string MovementWarehouseIdTo { get; set; }

		public virtual string MovementDescription { get; set; }

		public virtual string MovementCreatedBy { get; set; }

		public virtual DateTime? MovementCreatedAt { get; set; }

		public virtual string MovementUpdatedBy { get; set; }

		public virtual DateTime? MovementUpdatedAt { get; set; }

		public virtual bool? MovementActive { get; set; }

		public virtual bool? MovementDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		MovementLineMvoEventId IGlobalIdentity<MovementLineMvoEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToMovementLineMvoEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IMovementLineMvoStateEvent.ReadOnly
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

		public virtual bool? IsPropertyMovementQuantityRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementQuantityRemoved
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

		public virtual bool? IsPropertyProductIdRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyProductIdRemoved
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

		public virtual bool? IsPropertyLocatorIdFromRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyLocatorIdFromRemoved
        {
            get 
            {
                var b = this.IsPropertyLocatorIdFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLocatorIdFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyLocatorIdToRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyLocatorIdToRemoved
        {
            get 
            {
                var b = this.IsPropertyLocatorIdToRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLocatorIdToRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetInstanceIdRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyAttributeSetInstanceIdRemoved
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

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyProcessedRemoved
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

		public virtual bool? IsPropertyReversalLineNumberRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyReversalLineNumberRemoved
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

        bool IMovementLineMvoStateMergePatched.IsPropertyVersionRemoved
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

        bool IMovementLineMvoStateMergePatched.IsPropertyActiveRemoved
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

		public virtual bool? IsPropertyMovementDocumentStatusIdRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementDocumentStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDocumentStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDocumentStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementMovementDateRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementMovementDateRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementMovementDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementMovementDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementPostedRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementPostedRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementPostedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementPostedRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementProcessedRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementProcessedRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementProcessingRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementProcessingRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementProcessingRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementProcessingRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementDateReceivedRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementDateReceivedRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDateReceivedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDateReceivedRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementDocumentTypeIdRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementDocumentTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDocumentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDocumentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementIsInTransitRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementIsInTransitRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementIsInTransitRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementIsInTransitRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementIsApprovedRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementIsApprovedRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementIsApprovedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementIsApprovedRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementApprovalAmountRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementApprovalAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementApprovalAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementApprovalAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementShipperIdRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementShipperIdRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementShipperIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementShipperIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementSalesRepresentativeIdRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementSalesRepresentativeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementSalesRepresentativeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementSalesRepresentativeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementBusinessPartnerIdRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementBusinessPartnerIdRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementBusinessPartnerIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementBusinessPartnerIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementChargeAmountRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementChargeAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementChargeAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementChargeAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementCreateFromRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementCreateFromRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementCreateFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementCreateFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementFreightAmountRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementFreightAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementFreightAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementFreightAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementReversalDocumentNumberRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementReversalDocumentNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementReversalDocumentNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementReversalDocumentNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementWarehouseIdFromRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementWarehouseIdFromRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementWarehouseIdFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementWarehouseIdFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementWarehouseIdToRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementWarehouseIdToRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementWarehouseIdToRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementWarehouseIdToRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementDescriptionRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementCreatedByRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementCreatedAtRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementUpdatedByRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementUpdatedAtRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementActiveRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementDeletedRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementDeletedRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDeletedRemoved = value;
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


        MovementLineMvoEventId IMovementLineMvoStateEvent.StateEventId
        {
            get { return this.StateEventId.ToMovementLineMvoEventId(); }
        }

        protected MovementLineMvoStateEventDtoBase()
        {
        }

        protected MovementLineMvoStateEventDtoBase(MovementLineMvoEventIdDto stateEventId)
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


    public class MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto : MovementLineMvoStateEventDtoBase
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



	public class MovementLineMvoStateCreatedDto : MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementLineMvoStateCreatedDto()
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


	public class MovementLineMvoStateMergePatchedDto : MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementLineMvoStateMergePatchedDto()
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


	public class MovementLineMvoStateDeletedDto : MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementLineMvoStateDeletedDto()
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


    public partial class MovementLineMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IMovementLineMvoStateCreated>, IEnumerable<IMovementLineMvoStateMergePatched>, IEnumerable<IMovementLineMvoStateDeleted>
    {
        private List<MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementLineMvoStateCreated> IEnumerable<IMovementLineMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementLineMvoStateMergePatched> IEnumerable<IMovementLineMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementLineMvoStateDeleted> IEnumerable<IMovementLineMvoStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddMovementLineMvoEvent(IMovementLineMvoStateCreated e)
        {
            _innerStateEvents.Add((MovementLineMvoStateCreatedDto)e);
        }

        public void AddMovementLineMvoEvent(IMovementLineMvoStateEvent e)
        {
            _innerStateEvents.Add((MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddMovementLineMvoEvent(IMovementLineMvoStateDeleted e)
        {
            _innerStateEvents.Add((MovementLineMvoStateDeletedDto)e);
        }

    }


}

