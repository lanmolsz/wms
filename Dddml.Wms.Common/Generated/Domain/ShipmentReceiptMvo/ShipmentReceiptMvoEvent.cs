﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentReceiptMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentReceiptMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentReceiptMvo
{

	public abstract class ShipmentReceiptMvoEventBase : IShipmentReceiptMvoEvent
	{

		public virtual ShipmentReceiptMvoEventId ShipmentReceiptMvoEventId { get; set; }

        public virtual ShipmentReceiptId ShipmentReceiptId
        {
            get { return ShipmentReceiptMvoEventId.ShipmentReceiptId; }
            set { ShipmentReceiptMvoEventId.ShipmentReceiptId = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ShipmentReceiptMvoEventId IGlobalIdentity<ShipmentReceiptMvoEventId>.GlobalId {
			get
			{
				return this.ShipmentReceiptMvoEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IShipmentReceiptMvoEvent.ReadOnly
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

        protected ShipmentReceiptMvoEventBase()
        {
        }

        protected ShipmentReceiptMvoEventBase(ShipmentReceiptMvoEventId stateEventId)
        {
            this.ShipmentReceiptMvoEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class ShipmentReceiptMvoStateEventBase : ShipmentReceiptMvoEventBase, IShipmentReceiptMvoStateEvent
    {

		public virtual string ProductId { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual string LocatorId { get; set; }

		public virtual string ShipmentItemSeqId { get; set; }

		public virtual string ShipmentPackageSeqId { get; set; }

		public virtual string OrderId { get; set; }

		public virtual string OrderItemSeqId { get; set; }

		public virtual string ReturnId { get; set; }

		public virtual string ReturnItemSeqId { get; set; }

		public virtual string RejectionReasonId { get; set; }

		public virtual string DamageStatusId { get; set; }

		public virtual string DamageReasonId { get; set; }

		public virtual string ReceivedBy { get; set; }

		public virtual DateTime? DatetimeReceived { get; set; }

		public virtual string ItemDescription { get; set; }

		public virtual decimal? AcceptedQuantity { get; set; }

		public virtual decimal? RejectedQuantity { get; set; }

		public virtual decimal? DamagedQuantity { get; set; }

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

        protected ShipmentReceiptMvoStateEventBase() : base()
        {
        }

        protected ShipmentReceiptMvoStateEventBase(ShipmentReceiptMvoEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class ShipmentReceiptMvoStateCreated : ShipmentReceiptMvoStateEventBase, IShipmentReceiptMvoStateCreated
	{
		public ShipmentReceiptMvoStateCreated () : this(new ShipmentReceiptMvoEventId())
		{
		}

		public ShipmentReceiptMvoStateCreated (ShipmentReceiptMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ShipmentReceiptMvoStateMergePatched : ShipmentReceiptMvoStateEventBase, IShipmentReceiptMvoStateMergePatched
	{
		public virtual bool IsPropertyProductIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		public virtual bool IsPropertyLocatorIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentItemSeqIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentPackageSeqIdRemoved { get; set; }

		public virtual bool IsPropertyOrderIdRemoved { get; set; }

		public virtual bool IsPropertyOrderItemSeqIdRemoved { get; set; }

		public virtual bool IsPropertyReturnIdRemoved { get; set; }

		public virtual bool IsPropertyReturnItemSeqIdRemoved { get; set; }

		public virtual bool IsPropertyRejectionReasonIdRemoved { get; set; }

		public virtual bool IsPropertyDamageStatusIdRemoved { get; set; }

		public virtual bool IsPropertyDamageReasonIdRemoved { get; set; }

		public virtual bool IsPropertyReceivedByRemoved { get; set; }

		public virtual bool IsPropertyDatetimeReceivedRemoved { get; set; }

		public virtual bool IsPropertyItemDescriptionRemoved { get; set; }

		public virtual bool IsPropertyAcceptedQuantityRemoved { get; set; }

		public virtual bool IsPropertyRejectedQuantityRemoved { get; set; }

		public virtual bool IsPropertyDamagedQuantityRemoved { get; set; }

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


		public ShipmentReceiptMvoStateMergePatched ()
		{
		}

		public ShipmentReceiptMvoStateMergePatched (ShipmentReceiptMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}

