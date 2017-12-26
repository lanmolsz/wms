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
    public partial class ShipmentItemMvoAggregate : AggregateBase, IShipmentItemMvoAggregate
    {

        readonly IShipmentItemMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IShipmentItemMvoState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        ShipmentItemId IGlobalIdentity<ShipmentItemId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public ShipmentItemMvoAggregate(IShipmentItemMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IShipmentItemMvoStateProperties)_state).ShipmentVersion == ShipmentItemMvoState.VersionZero)
            {
                if (IsCommandCreate((IShipmentItemMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (IsCommandCreate((IShipmentItemMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IShipmentItemMvoCommand c)
        {
            return c.ShipmentVersion == ShipmentItemMvoState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateShipmentItemMvo c)
        {
            IShipmentItemMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchShipmentItemMvo c)
        {
            IShipmentItemMvoStateMergePatched e = Map(c);
            Apply(e);
        }


        protected virtual IShipmentItemMvoStateCreated Map(ICreateShipmentItemMvo c)
        {
			var stateEventId = new ShipmentItemMvoStateEventId(c.ShipmentItemId, c.ShipmentVersion);
            IShipmentItemMvoStateCreated e = NewShipmentItemMvoStateCreated(stateEventId);
		
            e.ProductId = c.ProductId;
            e.Quantity = c.Quantity;
            e.ShipmentContentDescription = c.ShipmentContentDescription;
            e.Version = c.Version;
            e.Active = c.Active;
            e.ShipmentShipmentTypeId = c.ShipmentShipmentTypeId;
            e.ShipmentStatusId = c.ShipmentStatusId;
            e.ShipmentPrimaryOrderId = c.ShipmentPrimaryOrderId;
            e.ShipmentPrimaryReturnId = c.ShipmentPrimaryReturnId;
            e.ShipmentPicklistBinId = c.ShipmentPicklistBinId;
            e.ShipmentEstimatedReadyDate = c.ShipmentEstimatedReadyDate;
            e.ShipmentEstimatedShipDate = c.ShipmentEstimatedShipDate;
            e.ShipmentEstimatedShipWorkEffId = c.ShipmentEstimatedShipWorkEffId;
            e.ShipmentEstimatedArrivalDate = c.ShipmentEstimatedArrivalDate;
            e.ShipmentEstimatedArrivalWorkEffId = c.ShipmentEstimatedArrivalWorkEffId;
            e.ShipmentLatestCancelDate = c.ShipmentLatestCancelDate;
            e.ShipmentEstimatedShipCost = c.ShipmentEstimatedShipCost;
            e.ShipmentCurrencyUomId = c.ShipmentCurrencyUomId;
            e.ShipmentHandlingInstructions = c.ShipmentHandlingInstructions;
            e.ShipmentOriginFacilityId = c.ShipmentOriginFacilityId;
            e.ShipmentDestinationFacilityId = c.ShipmentDestinationFacilityId;
            e.ShipmentOriginContactMechId = c.ShipmentOriginContactMechId;
            e.ShipmentOriginTelecomNumberId = c.ShipmentOriginTelecomNumberId;
            e.ShipmentDestinationContactMechId = c.ShipmentDestinationContactMechId;
            e.ShipmentDestinationTelecomNumberId = c.ShipmentDestinationTelecomNumberId;
            e.ShipmentPartyIdTo = c.ShipmentPartyIdTo;
            e.ShipmentPartyIdFrom = c.ShipmentPartyIdFrom;
            e.ShipmentAdditionalShippingCharge = c.ShipmentAdditionalShippingCharge;
            e.ShipmentAddtlShippingChargeDesc = c.ShipmentAddtlShippingChargeDesc;
            e.ShipmentCreatedBy = c.ShipmentCreatedBy;
            e.ShipmentCreatedAt = c.ShipmentCreatedAt;
            e.ShipmentUpdatedBy = c.ShipmentUpdatedBy;
            e.ShipmentUpdatedAt = c.ShipmentUpdatedAt;
            e.ShipmentActive = c.ShipmentActive;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var shipmentVersion = c.ShipmentVersion;


            return e;
        }

        protected virtual IShipmentItemMvoStateMergePatched Map(IMergePatchShipmentItemMvo c)
        {
			var stateEventId = new ShipmentItemMvoStateEventId(c.ShipmentItemId, c.ShipmentVersion);
            IShipmentItemMvoStateMergePatched e = NewShipmentItemMvoStateMergePatched(stateEventId);

            e.ProductId = c.ProductId;
            e.Quantity = c.Quantity;
            e.ShipmentContentDescription = c.ShipmentContentDescription;
            e.Version = c.Version;
            e.Active = c.Active;
            e.ShipmentShipmentTypeId = c.ShipmentShipmentTypeId;
            e.ShipmentStatusId = c.ShipmentStatusId;
            e.ShipmentPrimaryOrderId = c.ShipmentPrimaryOrderId;
            e.ShipmentPrimaryReturnId = c.ShipmentPrimaryReturnId;
            e.ShipmentPicklistBinId = c.ShipmentPicklistBinId;
            e.ShipmentEstimatedReadyDate = c.ShipmentEstimatedReadyDate;
            e.ShipmentEstimatedShipDate = c.ShipmentEstimatedShipDate;
            e.ShipmentEstimatedShipWorkEffId = c.ShipmentEstimatedShipWorkEffId;
            e.ShipmentEstimatedArrivalDate = c.ShipmentEstimatedArrivalDate;
            e.ShipmentEstimatedArrivalWorkEffId = c.ShipmentEstimatedArrivalWorkEffId;
            e.ShipmentLatestCancelDate = c.ShipmentLatestCancelDate;
            e.ShipmentEstimatedShipCost = c.ShipmentEstimatedShipCost;
            e.ShipmentCurrencyUomId = c.ShipmentCurrencyUomId;
            e.ShipmentHandlingInstructions = c.ShipmentHandlingInstructions;
            e.ShipmentOriginFacilityId = c.ShipmentOriginFacilityId;
            e.ShipmentDestinationFacilityId = c.ShipmentDestinationFacilityId;
            e.ShipmentOriginContactMechId = c.ShipmentOriginContactMechId;
            e.ShipmentOriginTelecomNumberId = c.ShipmentOriginTelecomNumberId;
            e.ShipmentDestinationContactMechId = c.ShipmentDestinationContactMechId;
            e.ShipmentDestinationTelecomNumberId = c.ShipmentDestinationTelecomNumberId;
            e.ShipmentPartyIdTo = c.ShipmentPartyIdTo;
            e.ShipmentPartyIdFrom = c.ShipmentPartyIdFrom;
            e.ShipmentAdditionalShippingCharge = c.ShipmentAdditionalShippingCharge;
            e.ShipmentAddtlShippingChargeDesc = c.ShipmentAddtlShippingChargeDesc;
            e.ShipmentCreatedBy = c.ShipmentCreatedBy;
            e.ShipmentCreatedAt = c.ShipmentCreatedAt;
            e.ShipmentUpdatedBy = c.ShipmentUpdatedBy;
            e.ShipmentUpdatedAt = c.ShipmentUpdatedAt;
            e.ShipmentActive = c.ShipmentActive;
            e.IsPropertyProductIdRemoved = c.IsPropertyProductIdRemoved;
            e.IsPropertyQuantityRemoved = c.IsPropertyQuantityRemoved;
            e.IsPropertyShipmentContentDescriptionRemoved = c.IsPropertyShipmentContentDescriptionRemoved;
            e.IsPropertyVersionRemoved = c.IsPropertyVersionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;
            e.IsPropertyShipmentShipmentTypeIdRemoved = c.IsPropertyShipmentShipmentTypeIdRemoved;
            e.IsPropertyShipmentStatusIdRemoved = c.IsPropertyShipmentStatusIdRemoved;
            e.IsPropertyShipmentPrimaryOrderIdRemoved = c.IsPropertyShipmentPrimaryOrderIdRemoved;
            e.IsPropertyShipmentPrimaryReturnIdRemoved = c.IsPropertyShipmentPrimaryReturnIdRemoved;
            e.IsPropertyShipmentPicklistBinIdRemoved = c.IsPropertyShipmentPicklistBinIdRemoved;
            e.IsPropertyShipmentEstimatedReadyDateRemoved = c.IsPropertyShipmentEstimatedReadyDateRemoved;
            e.IsPropertyShipmentEstimatedShipDateRemoved = c.IsPropertyShipmentEstimatedShipDateRemoved;
            e.IsPropertyShipmentEstimatedShipWorkEffIdRemoved = c.IsPropertyShipmentEstimatedShipWorkEffIdRemoved;
            e.IsPropertyShipmentEstimatedArrivalDateRemoved = c.IsPropertyShipmentEstimatedArrivalDateRemoved;
            e.IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved = c.IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved;
            e.IsPropertyShipmentLatestCancelDateRemoved = c.IsPropertyShipmentLatestCancelDateRemoved;
            e.IsPropertyShipmentEstimatedShipCostRemoved = c.IsPropertyShipmentEstimatedShipCostRemoved;
            e.IsPropertyShipmentCurrencyUomIdRemoved = c.IsPropertyShipmentCurrencyUomIdRemoved;
            e.IsPropertyShipmentHandlingInstructionsRemoved = c.IsPropertyShipmentHandlingInstructionsRemoved;
            e.IsPropertyShipmentOriginFacilityIdRemoved = c.IsPropertyShipmentOriginFacilityIdRemoved;
            e.IsPropertyShipmentDestinationFacilityIdRemoved = c.IsPropertyShipmentDestinationFacilityIdRemoved;
            e.IsPropertyShipmentOriginContactMechIdRemoved = c.IsPropertyShipmentOriginContactMechIdRemoved;
            e.IsPropertyShipmentOriginTelecomNumberIdRemoved = c.IsPropertyShipmentOriginTelecomNumberIdRemoved;
            e.IsPropertyShipmentDestinationContactMechIdRemoved = c.IsPropertyShipmentDestinationContactMechIdRemoved;
            e.IsPropertyShipmentDestinationTelecomNumberIdRemoved = c.IsPropertyShipmentDestinationTelecomNumberIdRemoved;
            e.IsPropertyShipmentPartyIdToRemoved = c.IsPropertyShipmentPartyIdToRemoved;
            e.IsPropertyShipmentPartyIdFromRemoved = c.IsPropertyShipmentPartyIdFromRemoved;
            e.IsPropertyShipmentAdditionalShippingChargeRemoved = c.IsPropertyShipmentAdditionalShippingChargeRemoved;
            e.IsPropertyShipmentAddtlShippingChargeDescRemoved = c.IsPropertyShipmentAddtlShippingChargeDescRemoved;
            e.IsPropertyShipmentCreatedByRemoved = c.IsPropertyShipmentCreatedByRemoved;
            e.IsPropertyShipmentCreatedAtRemoved = c.IsPropertyShipmentCreatedAtRemoved;
            e.IsPropertyShipmentUpdatedByRemoved = c.IsPropertyShipmentUpdatedByRemoved;
            e.IsPropertyShipmentUpdatedAtRemoved = c.IsPropertyShipmentUpdatedAtRemoved;
            e.IsPropertyShipmentActiveRemoved = c.IsPropertyShipmentActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var shipmentVersion = c.ShipmentVersion;


            return e;
        }

        private void ThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected ShipmentItemMvoStateCreated NewShipmentItemMvoStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new ShipmentItemMvoStateEventId(_state.ShipmentItemId, ((IShipmentItemMvoStateProperties)_state).ShipmentVersion);
            var e = NewShipmentItemMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected ShipmentItemMvoStateMergePatched NewShipmentItemMvoStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new ShipmentItemMvoStateEventId(_state.ShipmentItemId, ((IShipmentItemMvoStateProperties)_state).ShipmentVersion);
            var e = NewShipmentItemMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


////////////////////////

		private ShipmentItemMvoStateCreated NewShipmentItemMvoStateCreated(ShipmentItemMvoStateEventId stateEventId)
		{
			return new ShipmentItemMvoStateCreated(stateEventId);			
		}

        private ShipmentItemMvoStateMergePatched NewShipmentItemMvoStateMergePatched(ShipmentItemMvoStateEventId stateEventId)
		{
			return new ShipmentItemMvoStateMergePatched(stateEventId);
		}


    }

}

