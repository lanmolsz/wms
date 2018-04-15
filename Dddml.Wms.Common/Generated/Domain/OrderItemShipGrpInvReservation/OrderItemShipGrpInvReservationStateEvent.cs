﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGrpInvReservationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGrpInvReservation;

namespace Dddml.Wms.Domain.OrderItemShipGrpInvReservation
{

	public abstract class OrderItemShipGrpInvReservationStateEventBase : IOrderItemShipGrpInvReservationStateEvent
	{

		public virtual OrderItemShipGrpInvReservationEventId OrderItemShipGrpInvReservationEventId { get; set; }

        public virtual OrderItemShipGrpInvResId OrderItemShipGrpInvResId
        {
            get { return OrderItemShipGrpInvReservationEventId.OrderItemShipGrpInvResId; }
            set { OrderItemShipGrpInvReservationEventId.OrderItemShipGrpInvResId = value; }
        }

		public virtual string ReserveOrderEnumId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual decimal? QuantityNotAvailable { get; set; }

		public virtual DateTime? ReservedDatetime { get; set; }

		public virtual DateTime? CreatedDatetime { get; set; }

		public virtual DateTime? PromisedDatetime { get; set; }

		public virtual DateTime? CurrentPromisedDate { get; set; }

		public virtual string Priority { get; set; }

		public virtual long? SequenceId { get; set; }

		public virtual DateTime? OldPickStartDate { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		OrderItemShipGrpInvReservationEventId IGlobalIdentity<OrderItemShipGrpInvReservationEventId>.GlobalId {
			get
			{
				return this.OrderItemShipGrpInvReservationEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IOrderItemShipGrpInvReservationStateEvent.ReadOnly
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

        protected OrderItemShipGrpInvReservationStateEventBase()
        {
        }

        protected OrderItemShipGrpInvReservationStateEventBase(OrderItemShipGrpInvReservationEventId stateEventId)
        {
            this.OrderItemShipGrpInvReservationEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class OrderItemShipGrpInvReservationStateCreated : OrderItemShipGrpInvReservationStateEventBase, IOrderItemShipGrpInvReservationStateCreated
	{
		public OrderItemShipGrpInvReservationStateCreated () : this(new OrderItemShipGrpInvReservationEventId())
		{
		}

		public OrderItemShipGrpInvReservationStateCreated (OrderItemShipGrpInvReservationEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class OrderItemShipGrpInvReservationStateMergePatched : OrderItemShipGrpInvReservationStateEventBase, IOrderItemShipGrpInvReservationStateMergePatched
	{
		public virtual bool IsPropertyReserveOrderEnumIdRemoved { get; set; }

		public virtual bool IsPropertyQuantityRemoved { get; set; }

		public virtual bool IsPropertyQuantityNotAvailableRemoved { get; set; }

		public virtual bool IsPropertyReservedDatetimeRemoved { get; set; }

		public virtual bool IsPropertyCreatedDatetimeRemoved { get; set; }

		public virtual bool IsPropertyPromisedDatetimeRemoved { get; set; }

		public virtual bool IsPropertyCurrentPromisedDateRemoved { get; set; }

		public virtual bool IsPropertyPriorityRemoved { get; set; }

		public virtual bool IsPropertySequenceIdRemoved { get; set; }

		public virtual bool IsPropertyOldPickStartDateRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public OrderItemShipGrpInvReservationStateMergePatched ()
		{
		}

		public OrderItemShipGrpInvReservationStateMergePatched (OrderItemShipGrpInvReservationEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class OrderItemShipGrpInvReservationStateDeleted : OrderItemShipGrpInvReservationStateEventBase, IOrderItemShipGrpInvReservationStateDeleted
	{
		public OrderItemShipGrpInvReservationStateDeleted ()
		{
		}

		public OrderItemShipGrpInvReservationStateDeleted (OrderItemShipGrpInvReservationEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

