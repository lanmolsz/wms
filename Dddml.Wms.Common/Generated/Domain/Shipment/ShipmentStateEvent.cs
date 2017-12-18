﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{

	public abstract class ShipmentStateEventBase : IShipmentStateEvent
	{

		public virtual ShipmentStateEventId StateEventId { get; set; }

        public virtual string ShipmentId
        {
            get { return StateEventId.ShipmentId; }
            set { StateEventId.ShipmentId = value; }
        }

		public virtual string ShipmentTypeId { get; set; }

		public virtual string StatusId { get; set; }

		public virtual string PrimaryOrderId { get; set; }

		public virtual string PrimaryReturnId { get; set; }

		public virtual string PicklistBinId { get; set; }

		public virtual DateTime? EstimatedReadyDate { get; set; }

		public virtual DateTime? EstimatedShipDate { get; set; }

		public virtual string EstimatedShipWorkEffId { get; set; }

		public virtual DateTime? EstimatedArrivalDate { get; set; }

		public virtual string EstimatedArrivalWorkEffId { get; set; }

		public virtual DateTime? LatestCancelDate { get; set; }

		public virtual decimal? EstimatedShipCost { get; set; }

		public virtual string CurrencyUomId { get; set; }

		public virtual string HandlingInstructions { get; set; }

		public virtual string OriginFacilityId { get; set; }

		public virtual string DestinationFacilityId { get; set; }

		public virtual string OriginContactMechId { get; set; }

		public virtual string OriginTelecomNumberId { get; set; }

		public virtual string DestinationContactMechId { get; set; }

		public virtual string DestinationTelecomNumberId { get; set; }

		public virtual string PartyIdTo { get; set; }

		public virtual string PartyIdFrom { get; set; }

		public virtual decimal? AdditionalShippingCharge { get; set; }

		public virtual string AddtlShippingChargeDesc { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ShipmentStateEventId IGlobalIdentity<ShipmentStateEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IShipmentStateEvent.ReadOnly
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

        protected ShipmentStateEventBase()
        {
        }

        protected ShipmentStateEventBase(ShipmentStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }

		protected IShipmentItemStateEventDao ShipmentItemStateEventDao
		{
			get { return ApplicationContext.Current["ShipmentItemStateEventDao"] as IShipmentItemStateEventDao; }
		}

        protected ShipmentItemStateEventId NewShipmentItemStateEventId(string shipmentItemSeqId)
        {
            var stateEventId = new ShipmentItemStateEventId(this.StateEventId.ShipmentId, shipmentItemSeqId, this.StateEventId.Version);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IShipmentItemStateEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IShipmentStateEvent oe, IShipmentItemStateEvent e)
		{
			if (!oe.StateEventId.ShipmentId.Equals(e.StateEventId.ShipmentId))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id ShipmentId {0} but inner id ShipmentId {1}", 
					oe.StateEventId.ShipmentId, e.StateEventId.ShipmentId);
			}
		}



        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class ShipmentStateCreated : ShipmentStateEventBase, IShipmentStateCreated, ISaveable
	{
		public ShipmentStateCreated () : this(new ShipmentStateEventId())
		{
		}

		public ShipmentStateCreated (ShipmentStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<ShipmentItemStateEventId, IShipmentItemStateCreated> _shipmentItemEvents = new Dictionary<ShipmentItemStateEventId, IShipmentItemStateCreated>();
        
        private IEnumerable<IShipmentItemStateCreated> _readOnlyShipmentItemEvents;

        public virtual IEnumerable<IShipmentItemStateCreated> ShipmentItemEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
                    return this._shipmentItemEvents.Values;
                }
                else
                {
                    if (_readOnlyShipmentItemEvents != null) { return _readOnlyShipmentItemEvents; }
                    var eventDao = ShipmentItemStateEventDao;
                    var eL = new List<IShipmentItemStateCreated>();
                    foreach (var e in eventDao.FindByShipmentStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IShipmentItemStateCreated)e);
                    }
                    return (_readOnlyShipmentItemEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddShipmentItemEvent(e);
                    }
                }
                else { this._shipmentItemEvents.Clear(); }
            }
        }
    
		public virtual void AddShipmentItemEvent(IShipmentItemStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._shipmentItemEvents[e.StateEventId] = e;
		}

        public virtual IShipmentItemStateCreated NewShipmentItemStateCreated(string shipmentItemSeqId)
        {
            var stateEvent = new ShipmentItemStateCreated(NewShipmentItemStateEventId(shipmentItemSeqId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IShipmentItemStateCreated e in this.ShipmentItemEvents) {
				ShipmentItemStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ShipmentStateMergePatched : ShipmentStateEventBase, IShipmentStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyShipmentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyStatusIdRemoved { get; set; }

		public virtual bool IsPropertyPrimaryOrderIdRemoved { get; set; }

		public virtual bool IsPropertyPrimaryReturnIdRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinIdRemoved { get; set; }

		public virtual bool IsPropertyEstimatedReadyDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedShipDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedShipWorkEffIdRemoved { get; set; }

		public virtual bool IsPropertyEstimatedArrivalDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedArrivalWorkEffIdRemoved { get; set; }

		public virtual bool IsPropertyLatestCancelDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedShipCostRemoved { get; set; }

		public virtual bool IsPropertyCurrencyUomIdRemoved { get; set; }

		public virtual bool IsPropertyHandlingInstructionsRemoved { get; set; }

		public virtual bool IsPropertyOriginFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyDestinationFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyOriginContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyOriginTelecomNumberIdRemoved { get; set; }

		public virtual bool IsPropertyDestinationContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyDestinationTelecomNumberIdRemoved { get; set; }

		public virtual bool IsPropertyPartyIdToRemoved { get; set; }

		public virtual bool IsPropertyPartyIdFromRemoved { get; set; }

		public virtual bool IsPropertyAdditionalShippingChargeRemoved { get; set; }

		public virtual bool IsPropertyAddtlShippingChargeDescRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public ShipmentStateMergePatched ()
		{
		}

		public ShipmentStateMergePatched (ShipmentStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<ShipmentItemStateEventId, IShipmentItemStateEvent> _shipmentItemEvents = new Dictionary<ShipmentItemStateEventId, IShipmentItemStateEvent>();

        private IEnumerable<IShipmentItemStateEvent> _readOnlyShipmentItemEvents;
        
        public virtual IEnumerable<IShipmentItemStateEvent> ShipmentItemEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
                    return this._shipmentItemEvents.Values;
                }
                else
                {
                    if (_readOnlyShipmentItemEvents != null) { return _readOnlyShipmentItemEvents; }
                    var eventDao = ShipmentItemStateEventDao;
                    var eL = new List<IShipmentItemStateEvent>();
                    foreach (var e in eventDao.FindByShipmentStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IShipmentItemStateEvent)e);
                    }
                    return (_readOnlyShipmentItemEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddShipmentItemEvent(e);
                    }
                }
                else { this._shipmentItemEvents.Clear(); }
            }
        }

		public virtual void AddShipmentItemEvent(IShipmentItemStateEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._shipmentItemEvents[e.StateEventId] = e;
		}

        public virtual IShipmentItemStateCreated NewShipmentItemStateCreated(string shipmentItemSeqId)
        {
            var stateEvent = new ShipmentItemStateCreated(NewShipmentItemStateEventId(shipmentItemSeqId));
            return stateEvent;
        }

        public virtual IShipmentItemStateMergePatched NewShipmentItemStateMergePatched(string shipmentItemSeqId)
        {
            var stateEvent = new ShipmentItemStateMergePatched(NewShipmentItemStateEventId(shipmentItemSeqId));
            return stateEvent;
        }

        public virtual IShipmentItemStateRemoved NewShipmentItemStateRemoved(string shipmentItemSeqId)
        {
            var stateEvent = new ShipmentItemStateRemoved(NewShipmentItemStateEventId(shipmentItemSeqId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IShipmentItemStateEvent e in this.ShipmentItemEvents) {
				ShipmentItemStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}
