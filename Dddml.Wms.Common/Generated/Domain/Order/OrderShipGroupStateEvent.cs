﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public abstract class OrderShipGroupStateEventBase : IOrderShipGroupStateEvent
	{

		public virtual OrderShipGroupEventId OrderShipGroupEventId { get; set; }

        public virtual long? ShipGroupSeqId
        {
            get { return OrderShipGroupEventId.ShipGroupSeqId; }
            set { OrderShipGroupEventId.ShipGroupSeqId = value; }
        }

		public virtual string ShipmentMethodTypeId { get; set; }

		public virtual string SupplierPartyId { get; set; }

		public virtual string VendorPartyId { get; set; }

		public virtual string CarrierPartyId { get; set; }

		public virtual string CarrierRoleTypeId { get; set; }

		public virtual string FacilityId { get; set; }

		public virtual string ContactMechId { get; set; }

		public virtual string TelecomContactMechId { get; set; }

		public virtual string TrackingNumber { get; set; }

		public virtual string ShippingInstructions { get; set; }

		public virtual string MaySplit { get; set; }

		public virtual string GiftMessage { get; set; }

		public virtual string IsGift { get; set; }

		public virtual DateTime? ShipAfterDate { get; set; }

		public virtual DateTime? ShipByDate { get; set; }

		public virtual DateTime? EstimatedShipDate { get; set; }

		public virtual DateTime? EstimatedDeliveryDate { get; set; }

		public virtual long? PickwaveId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		OrderShipGroupEventId IGlobalIdentity<OrderShipGroupEventId>.GlobalId {
			get
			{
				return this.OrderShipGroupEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IOrderShipGroupStateEvent.ReadOnly
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

		public virtual long Version { get; set; }


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

        protected OrderShipGroupStateEventBase()
        {
        }

        protected OrderShipGroupStateEventBase(OrderShipGroupEventId stateEventId)
        {
            this.OrderShipGroupEventId = stateEventId;
        }

		protected IOrderItemShipGroupAssociationStateEventDao OrderItemShipGroupAssociationStateEventDao
		{
			get { return ApplicationContext.Current["OrderItemShipGroupAssociationStateEventDao"] as IOrderItemShipGroupAssociationStateEventDao; }
		}

        protected OrderItemShipGroupAssociationEventId NewOrderItemShipGroupAssociationEventId(string orderItemSeqId)
        {
            var stateEventId = new OrderItemShipGroupAssociationEventId(this.OrderShipGroupEventId.OrderId, this.OrderShipGroupEventId.ShipGroupSeqId, orderItemSeqId, this.OrderShipGroupEventId.OrderVersion);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IOrderItemShipGroupAssociationStateEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IOrderShipGroupStateEvent oe, IOrderItemShipGroupAssociationStateEvent e)
		{
			if (!oe.OrderShipGroupEventId.OrderId.Equals(e.OrderItemShipGroupAssociationEventId.OrderId))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id OrderId {0} but inner id OrderId {1}", 
					oe.OrderShipGroupEventId.OrderId, e.OrderItemShipGroupAssociationEventId.OrderId);
			}
			if (!oe.OrderShipGroupEventId.ShipGroupSeqId.Equals(e.OrderItemShipGroupAssociationEventId.OrderShipGroupShipGroupSeqId))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id ShipGroupSeqId {0} but inner id OrderShipGroupShipGroupSeqId {1}", 
					oe.OrderShipGroupEventId.ShipGroupSeqId, e.OrderItemShipGroupAssociationEventId.OrderShipGroupShipGroupSeqId);
			}
		}



        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class OrderShipGroupStateCreated : OrderShipGroupStateEventBase, IOrderShipGroupStateCreated, ISaveable
	{
		public OrderShipGroupStateCreated () : this(new OrderShipGroupEventId())
		{
		}

		public OrderShipGroupStateCreated (OrderShipGroupEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<OrderItemShipGroupAssociationEventId, IOrderItemShipGroupAssociationStateCreated> _orderItemShipGroupAssociationEvents = new Dictionary<OrderItemShipGroupAssociationEventId, IOrderItemShipGroupAssociationStateCreated>();
        
        private IEnumerable<IOrderItemShipGroupAssociationStateCreated> _readOnlyOrderItemShipGroupAssociationEvents;

        public virtual IEnumerable<IOrderItemShipGroupAssociationStateCreated> OrderItemShipGroupAssociationEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._orderItemShipGroupAssociationEvents.Values;
                }
                else
                {
                    if (_readOnlyOrderItemShipGroupAssociationEvents != null) { return _readOnlyOrderItemShipGroupAssociationEvents; }
                    var eventDao = OrderItemShipGroupAssociationStateEventDao;
                    var eL = new List<IOrderItemShipGroupAssociationStateCreated>();
                    foreach (var e in eventDao.FindByOrderShipGroupEventId(this.OrderShipGroupEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IOrderItemShipGroupAssociationStateCreated)e);
                    }
                    return (_readOnlyOrderItemShipGroupAssociationEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddOrderItemShipGroupAssociationEvent(e);
                    }
                }
                else { this._orderItemShipGroupAssociationEvents.Clear(); }
            }
        }
    
		public virtual void AddOrderItemShipGroupAssociationEvent(IOrderItemShipGroupAssociationStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._orderItemShipGroupAssociationEvents[e.OrderItemShipGroupAssociationEventId] = e;
		}

        public virtual IOrderItemShipGroupAssociationStateCreated NewOrderItemShipGroupAssociationStateCreated(string orderItemSeqId)
        {
            var stateEvent = new OrderItemShipGroupAssociationStateCreated(NewOrderItemShipGroupAssociationEventId(orderItemSeqId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IOrderItemShipGroupAssociationStateCreated e in this.OrderItemShipGroupAssociationEvents) {
				OrderItemShipGroupAssociationStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class OrderShipGroupStateMergePatched : OrderShipGroupStateEventBase, IOrderShipGroupStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyShipmentMethodTypeIdRemoved { get; set; }

		public virtual bool IsPropertySupplierPartyIdRemoved { get; set; }

		public virtual bool IsPropertyVendorPartyIdRemoved { get; set; }

		public virtual bool IsPropertyCarrierPartyIdRemoved { get; set; }

		public virtual bool IsPropertyCarrierRoleTypeIdRemoved { get; set; }

		public virtual bool IsPropertyFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyTelecomContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyTrackingNumberRemoved { get; set; }

		public virtual bool IsPropertyShippingInstructionsRemoved { get; set; }

		public virtual bool IsPropertyMaySplitRemoved { get; set; }

		public virtual bool IsPropertyGiftMessageRemoved { get; set; }

		public virtual bool IsPropertyIsGiftRemoved { get; set; }

		public virtual bool IsPropertyShipAfterDateRemoved { get; set; }

		public virtual bool IsPropertyShipByDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedShipDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedDeliveryDateRemoved { get; set; }

		public virtual bool IsPropertyPickwaveIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public OrderShipGroupStateMergePatched ()
		{
		}

		public OrderShipGroupStateMergePatched (OrderShipGroupEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<OrderItemShipGroupAssociationEventId, IOrderItemShipGroupAssociationStateEvent> _orderItemShipGroupAssociationEvents = new Dictionary<OrderItemShipGroupAssociationEventId, IOrderItemShipGroupAssociationStateEvent>();

        private IEnumerable<IOrderItemShipGroupAssociationStateEvent> _readOnlyOrderItemShipGroupAssociationEvents;
        
        public virtual IEnumerable<IOrderItemShipGroupAssociationStateEvent> OrderItemShipGroupAssociationEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._orderItemShipGroupAssociationEvents.Values;
                }
                else
                {
                    if (_readOnlyOrderItemShipGroupAssociationEvents != null) { return _readOnlyOrderItemShipGroupAssociationEvents; }
                    var eventDao = OrderItemShipGroupAssociationStateEventDao;
                    var eL = new List<IOrderItemShipGroupAssociationStateEvent>();
                    foreach (var e in eventDao.FindByOrderShipGroupEventId(this.OrderShipGroupEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IOrderItemShipGroupAssociationStateEvent)e);
                    }
                    return (_readOnlyOrderItemShipGroupAssociationEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddOrderItemShipGroupAssociationEvent(e);
                    }
                }
                else { this._orderItemShipGroupAssociationEvents.Clear(); }
            }
        }

		public virtual void AddOrderItemShipGroupAssociationEvent(IOrderItemShipGroupAssociationStateEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._orderItemShipGroupAssociationEvents[e.OrderItemShipGroupAssociationEventId] = e;
		}

        public virtual IOrderItemShipGroupAssociationStateCreated NewOrderItemShipGroupAssociationStateCreated(string orderItemSeqId)
        {
            var stateEvent = new OrderItemShipGroupAssociationStateCreated(NewOrderItemShipGroupAssociationEventId(orderItemSeqId));
            return stateEvent;
        }

        public virtual IOrderItemShipGroupAssociationStateMergePatched NewOrderItemShipGroupAssociationStateMergePatched(string orderItemSeqId)
        {
            var stateEvent = new OrderItemShipGroupAssociationStateMergePatched(NewOrderItemShipGroupAssociationEventId(orderItemSeqId));
            return stateEvent;
        }

        public virtual IOrderItemShipGroupAssociationStateRemoved NewOrderItemShipGroupAssociationStateRemoved(string orderItemSeqId)
        {
            var stateEvent = new OrderItemShipGroupAssociationStateRemoved(NewOrderItemShipGroupAssociationEventId(orderItemSeqId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IOrderItemShipGroupAssociationStateEvent e in this.OrderItemShipGroupAssociationEvents) {
				OrderItemShipGroupAssociationStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class OrderShipGroupStateRemoved : OrderShipGroupStateEventBase, IOrderShipGroupStateRemoved, ISaveable
	{
		public OrderShipGroupStateRemoved ()
		{
		}

		public OrderShipGroupStateRemoved (OrderShipGroupEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

		private Dictionary<OrderItemShipGroupAssociationEventId, IOrderItemShipGroupAssociationStateRemoved> _orderItemShipGroupAssociationEvents = new Dictionary<OrderItemShipGroupAssociationEventId, IOrderItemShipGroupAssociationStateRemoved>();
		
        private IEnumerable<IOrderItemShipGroupAssociationStateRemoved> _readOnlyOrderItemShipGroupAssociationEvents;

        public virtual IEnumerable<IOrderItemShipGroupAssociationStateRemoved> OrderItemShipGroupAssociationEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._orderItemShipGroupAssociationEvents.Values;
                }
                else
                {
                    if (_readOnlyOrderItemShipGroupAssociationEvents != null) { return _readOnlyOrderItemShipGroupAssociationEvents; }
                    var eventDao = OrderItemShipGroupAssociationStateEventDao;
                    var eL = new List<IOrderItemShipGroupAssociationStateRemoved>();
                    foreach (var e in eventDao.FindByOrderShipGroupEventId(this.OrderShipGroupEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IOrderItemShipGroupAssociationStateRemoved)e);
                    }
                    return (_readOnlyOrderItemShipGroupAssociationEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddOrderItemShipGroupAssociationEvent(e);
                    }
                }
                else { this._orderItemShipGroupAssociationEvents.Clear(); }
            }
        }
	
		public virtual void AddOrderItemShipGroupAssociationEvent(IOrderItemShipGroupAssociationStateRemoved e)
		{
			ThrowOnInconsistentEventIds(e);
			this._orderItemShipGroupAssociationEvents[e.OrderItemShipGroupAssociationEventId] = e;
		}

        public virtual IOrderItemShipGroupAssociationStateRemoved NewOrderItemShipGroupAssociationStateRemoved(string orderItemSeqId)
        {
            var stateEvent = new OrderItemShipGroupAssociationStateRemoved(NewOrderItemShipGroupAssociationEventId(orderItemSeqId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IOrderItemShipGroupAssociationStateRemoved e in this.OrderItemShipGroupAssociationEvents) {
				OrderItemShipGroupAssociationStateEventDao.Save(e);
			}
		}


	}



}

