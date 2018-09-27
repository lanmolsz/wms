﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItemMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentItemMvo
{

	public abstract class ShipmentItemMvoEventBase : IShipmentItemMvoEvent
	{

		public virtual ShipmentItemMvoEventId ShipmentItemMvoEventId { get; set; }

        public virtual ShipmentItemId ShipmentItemId
        {
            get { return ShipmentItemMvoEventId.ShipmentItemId; }
            set { ShipmentItemMvoEventId.ShipmentItemId = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ShipmentItemMvoEventId IGlobalIdentity<ShipmentItemMvoEventId>.GlobalId {
			get
			{
				return this.ShipmentItemMvoEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IShipmentItemMvoEvent.ReadOnly
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

        protected ShipmentItemMvoEventBase()
        {
        }

        protected ShipmentItemMvoEventBase(ShipmentItemMvoEventId stateEventId)
        {
            this.ShipmentItemMvoEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class ShipmentItemMvoStateEventBase : ShipmentItemMvoEventBase, IShipmentItemMvoStateEvent
    {

		public virtual string ProductId { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual string ShipmentContentDescription { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string ShipmentShipmentTypeId { get; set; }

		public virtual string ShipmentStatusId { get; set; }

		public virtual string ShipmentPrimaryOrderId { get; set; }

		public virtual string ShipmentPrimaryReturnId { get; set; }

		public virtual long? ShipmentPrimaryShipGroupSeqId { get; set; }

		public virtual string ShipmentPicklistBinId { get; set; }

		public virtual DateTime? ShipmentEstimatedReadyDate { get; set; }

		public virtual DateTime? ShipmentEstimatedShipDate { get; set; }

		public virtual string ShipmentEstimatedShipWorkEffId { get; set; }

		public virtual DateTime? ShipmentEstimatedArrivalDate { get; set; }

		public virtual string ShipmentEstimatedArrivalWorkEffId { get; set; }

		public virtual DateTime? ShipmentLatestCancelDate { get; set; }

		public virtual decimal? ShipmentEstimatedShipCost { get; set; }

		public virtual string ShipmentCurrencyUomId { get; set; }

		public virtual string ShipmentHandlingInstructions { get; set; }

		public virtual string ShipmentOriginFacilityId { get; set; }

		public virtual string ShipmentDestinationFacilityId { get; set; }

		public virtual string ShipmentOriginContactMechId { get; set; }

		public virtual string ShipmentOriginTelecomNumberId { get; set; }

		public virtual string ShipmentDestinationContactMechId { get; set; }

		public virtual string ShipmentDestinationTelecomNumberId { get; set; }

		public virtual string ShipmentPartyIdTo { get; set; }

		public virtual string ShipmentPartyIdFrom { get; set; }

		public virtual decimal? ShipmentAdditionalShippingCharge { get; set; }

		public virtual string ShipmentAddtlShippingChargeDesc { get; set; }

		public virtual string ShipmentCreatedBy { get; set; }

		public virtual DateTime? ShipmentCreatedAt { get; set; }

		public virtual string ShipmentUpdatedBy { get; set; }

		public virtual DateTime? ShipmentUpdatedAt { get; set; }

		public virtual bool? ShipmentActive { get; set; }

        protected ShipmentItemMvoStateEventBase() : base()
        {
        }

        protected ShipmentItemMvoStateEventBase(ShipmentItemMvoEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class ShipmentItemMvoStateCreated : ShipmentItemMvoStateEventBase, IShipmentItemMvoStateCreated
	{
		public ShipmentItemMvoStateCreated () : this(new ShipmentItemMvoEventId())
		{
		}

		public ShipmentItemMvoStateCreated (ShipmentItemMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ShipmentItemMvoStateMergePatched : ShipmentItemMvoStateEventBase, IShipmentItemMvoStateMergePatched
	{
		public virtual bool IsPropertyProductIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		public virtual bool IsPropertyQuantityRemoved { get; set; }

		public virtual bool IsPropertyShipmentContentDescriptionRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyShipmentShipmentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentStatusIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentPrimaryOrderIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentPrimaryReturnIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentPrimaryShipGroupSeqIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentPicklistBinIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentEstimatedReadyDateRemoved { get; set; }

		public virtual bool IsPropertyShipmentEstimatedShipDateRemoved { get; set; }

		public virtual bool IsPropertyShipmentEstimatedShipWorkEffIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentEstimatedArrivalDateRemoved { get; set; }

		public virtual bool IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentLatestCancelDateRemoved { get; set; }

		public virtual bool IsPropertyShipmentEstimatedShipCostRemoved { get; set; }

		public virtual bool IsPropertyShipmentCurrencyUomIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentHandlingInstructionsRemoved { get; set; }

		public virtual bool IsPropertyShipmentOriginFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentDestinationFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentOriginContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentOriginTelecomNumberIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentDestinationContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentDestinationTelecomNumberIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentPartyIdToRemoved { get; set; }

		public virtual bool IsPropertyShipmentPartyIdFromRemoved { get; set; }

		public virtual bool IsPropertyShipmentAdditionalShippingChargeRemoved { get; set; }

		public virtual bool IsPropertyShipmentAddtlShippingChargeDescRemoved { get; set; }

		public virtual bool IsPropertyShipmentCreatedByRemoved { get; set; }

		public virtual bool IsPropertyShipmentCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyShipmentUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyShipmentUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyShipmentActiveRemoved { get; set; }


		public ShipmentItemMvoStateMergePatched ()
		{
		}

		public ShipmentItemMvoStateMergePatched (ShipmentItemMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}
