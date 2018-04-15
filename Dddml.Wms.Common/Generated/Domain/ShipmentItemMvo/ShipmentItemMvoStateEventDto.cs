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

	public abstract class ShipmentItemMvoStateEventDtoBase : IStateEventDto, IShipmentItemMvoStateCreated, IShipmentItemMvoStateMergePatched
	{

        private ShipmentItemMvoEventId _shipmentItemMvoEventId;

		protected internal virtual ShipmentItemMvoEventId ShipmentItemMvoEventId 
        {
            get 
            {
                if (_shipmentItemMvoEventId == null) { _shipmentItemMvoEventId = new ShipmentItemMvoEventId(); }
                return _shipmentItemMvoEventId;
            }
            set
            {
                _shipmentItemMvoEventId = value;
            }
        }

        public virtual ShipmentItemId ShipmentItemId
        {
            get { return ShipmentItemMvoEventId.ShipmentItemId; }
            set { ShipmentItemMvoEventId.ShipmentItemId = value; }
        }

        public virtual long ShipmentVersion
        {
            get { return ShipmentItemMvoEventId.ShipmentVersion; }
            set { ShipmentItemMvoEventId.ShipmentVersion = value; }
        }

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

        bool IShipmentItemMvoStateEvent.ReadOnly
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

		public virtual bool? IsPropertyProductIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyProductIdRemoved
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

        bool IShipmentItemMvoStateMergePatched.IsPropertyAttributeSetInstanceIdRemoved
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

		public virtual bool? IsPropertyQuantityRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentContentDescriptionRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentContentDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentContentDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentContentDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyVersionRemoved
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

        bool IShipmentItemMvoStateMergePatched.IsPropertyActiveRemoved
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

		public virtual bool? IsPropertyShipmentShipmentTypeIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentShipmentTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentShipmentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentShipmentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentStatusIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPrimaryOrderIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentPrimaryOrderIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPrimaryOrderIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPrimaryOrderIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPrimaryReturnIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentPrimaryReturnIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPrimaryReturnIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPrimaryReturnIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPrimaryShipGroupSeqIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentPrimaryShipGroupSeqIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPrimaryShipGroupSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPrimaryShipGroupSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPicklistBinIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentPicklistBinIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPicklistBinIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPicklistBinIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentEstimatedReadyDateRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentEstimatedReadyDateRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentEstimatedReadyDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentEstimatedReadyDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentEstimatedShipDateRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentEstimatedShipDateRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentEstimatedShipDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentEstimatedShipDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentEstimatedShipWorkEffIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentEstimatedShipWorkEffIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentEstimatedShipWorkEffIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentEstimatedShipWorkEffIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentEstimatedArrivalDateRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentEstimatedArrivalDateRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentEstimatedArrivalDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentEstimatedArrivalDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentLatestCancelDateRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentLatestCancelDateRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentLatestCancelDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentLatestCancelDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentEstimatedShipCostRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentEstimatedShipCostRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentEstimatedShipCostRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentEstimatedShipCostRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentCurrencyUomIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentCurrencyUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentCurrencyUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentCurrencyUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentHandlingInstructionsRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentHandlingInstructionsRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentHandlingInstructionsRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentHandlingInstructionsRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentOriginFacilityIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentOriginFacilityIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentOriginFacilityIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentOriginFacilityIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentDestinationFacilityIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentDestinationFacilityIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentDestinationFacilityIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentDestinationFacilityIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentOriginContactMechIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentOriginContactMechIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentOriginContactMechIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentOriginContactMechIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentOriginTelecomNumberIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentOriginTelecomNumberIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentOriginTelecomNumberIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentOriginTelecomNumberIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentDestinationContactMechIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentDestinationContactMechIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentDestinationContactMechIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentDestinationContactMechIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentDestinationTelecomNumberIdRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentDestinationTelecomNumberIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentDestinationTelecomNumberIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentDestinationTelecomNumberIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPartyIdToRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentPartyIdToRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPartyIdToRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPartyIdToRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPartyIdFromRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentPartyIdFromRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPartyIdFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPartyIdFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentAdditionalShippingChargeRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentAdditionalShippingChargeRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentAdditionalShippingChargeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentAdditionalShippingChargeRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentAddtlShippingChargeDescRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentAddtlShippingChargeDescRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentAddtlShippingChargeDescRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentAddtlShippingChargeDescRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentCreatedByRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentCreatedAtRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentUpdatedByRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentUpdatedAtRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentActiveRemoved { get; set; }

        bool IShipmentItemMvoStateMergePatched.IsPropertyShipmentActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentActiveRemoved = value;
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


        ShipmentItemMvoEventId IShipmentItemMvoStateEvent.ShipmentItemMvoEventId
        {
            get { return this.ShipmentItemMvoEventId; }
        }

        protected ShipmentItemMvoStateEventDtoBase()
        {
        }

        protected ShipmentItemMvoStateEventDtoBase(ShipmentItemMvoEventId stateEventId)
        {
            this.ShipmentItemMvoEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class ShipmentItemMvoStateCreatedOrMergePatchedOrDeletedDto : ShipmentItemMvoStateEventDtoBase
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



	public class ShipmentItemMvoStateCreatedDto : ShipmentItemMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public ShipmentItemMvoStateCreatedDto()
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


	public class ShipmentItemMvoStateMergePatchedDto : ShipmentItemMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public ShipmentItemMvoStateMergePatchedDto()
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


	public class ShipmentItemMvoStateDeletedDto : ShipmentItemMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public ShipmentItemMvoStateDeletedDto()
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


    public partial class ShipmentItemMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IShipmentItemMvoStateCreated>, IEnumerable<IShipmentItemMvoStateMergePatched>
    {
        private List<ShipmentItemMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<ShipmentItemMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual ShipmentItemMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<ShipmentItemMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IShipmentItemMvoStateCreated> IEnumerable<IShipmentItemMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IShipmentItemMvoStateMergePatched> IEnumerable<IShipmentItemMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddShipmentItemMvoEvent(IShipmentItemMvoStateCreated e)
        {
            _innerStateEvents.Add((ShipmentItemMvoStateCreatedDto)e);
        }

        public void AddShipmentItemMvoEvent(IShipmentItemMvoStateEvent e)
        {
            _innerStateEvents.Add((ShipmentItemMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }


    }


}

