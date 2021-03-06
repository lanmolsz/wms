﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateItemIssuanceMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ItemIssuanceMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ItemIssuanceMvo
{
    public partial class ItemIssuanceMvoAggregate : AggregateBase, IItemIssuanceMvoAggregate
    {

        readonly IItemIssuanceMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IItemIssuanceMvoState State
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

        ShipmentItemIssuanceId IGlobalIdentity<ShipmentItemIssuanceId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public ItemIssuanceMvoAggregate(IItemIssuanceMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IItemIssuanceMvoStateProperties)_state).ShipmentVersion == ItemIssuanceMvoState.VersionZero)
            {
                if (IsCommandCreate((IItemIssuanceMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IItemIssuanceMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IItemIssuanceMvoCommand c)
        {
            return c.ShipmentVersion == ItemIssuanceMvoState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateItemIssuanceMvo c)
        {
            IItemIssuanceMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchItemIssuanceMvo c)
        {
            IItemIssuanceMvoStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteItemIssuanceMvo c)
        {
            IItemIssuanceMvoStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IItemIssuanceMvoStateCreated Map(ICreateItemIssuanceMvo c)
        {
			var stateEventId = new ItemIssuanceMvoEventId(c.ShipmentItemIssuanceId, c.ShipmentVersion);
            IItemIssuanceMvoStateCreated e = NewItemIssuanceMvoStateCreated(stateEventId);
		
            e.OrderId = c.OrderId;
            e.OrderItemSeqId = c.OrderItemSeqId;
            e.ShipGroupSeqId = c.ShipGroupSeqId;
            e.ProductId = c.ProductId;
            e.LocatorId = c.LocatorId;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.ShipmentItemSeqId = c.ShipmentItemSeqId;
            e.FixedAssetId = c.FixedAssetId;
            e.MaintHistSeqId = c.MaintHistSeqId;
            e.IssuedDateTime = c.IssuedDateTime;
            e.IssuedByUserLoginId = c.IssuedByUserLoginId;
            e.Quantity = c.Quantity;
            e.CancelQuantity = c.CancelQuantity;
            e.Version = c.Version;
            e.Active = c.Active;
            e.ShipmentShipmentTypeId = c.ShipmentShipmentTypeId;
            e.ShipmentStatusId = c.ShipmentStatusId;
            e.ShipmentPrimaryOrderId = c.ShipmentPrimaryOrderId;
            e.ShipmentPrimaryReturnId = c.ShipmentPrimaryReturnId;
            e.ShipmentPrimaryShipGroupSeqId = c.ShipmentPrimaryShipGroupSeqId;
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

        protected virtual IItemIssuanceMvoStateMergePatched Map(IMergePatchItemIssuanceMvo c)
        {
			var stateEventId = new ItemIssuanceMvoEventId(c.ShipmentItemIssuanceId, c.ShipmentVersion);
            IItemIssuanceMvoStateMergePatched e = NewItemIssuanceMvoStateMergePatched(stateEventId);

            e.OrderId = c.OrderId;
            e.OrderItemSeqId = c.OrderItemSeqId;
            e.ShipGroupSeqId = c.ShipGroupSeqId;
            e.ProductId = c.ProductId;
            e.LocatorId = c.LocatorId;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.ShipmentItemSeqId = c.ShipmentItemSeqId;
            e.FixedAssetId = c.FixedAssetId;
            e.MaintHistSeqId = c.MaintHistSeqId;
            e.IssuedDateTime = c.IssuedDateTime;
            e.IssuedByUserLoginId = c.IssuedByUserLoginId;
            e.Quantity = c.Quantity;
            e.CancelQuantity = c.CancelQuantity;
            e.Version = c.Version;
            e.Active = c.Active;
            e.ShipmentShipmentTypeId = c.ShipmentShipmentTypeId;
            e.ShipmentStatusId = c.ShipmentStatusId;
            e.ShipmentPrimaryOrderId = c.ShipmentPrimaryOrderId;
            e.ShipmentPrimaryReturnId = c.ShipmentPrimaryReturnId;
            e.ShipmentPrimaryShipGroupSeqId = c.ShipmentPrimaryShipGroupSeqId;
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
            e.IsPropertyOrderIdRemoved = c.IsPropertyOrderIdRemoved;
            e.IsPropertyOrderItemSeqIdRemoved = c.IsPropertyOrderItemSeqIdRemoved;
            e.IsPropertyShipGroupSeqIdRemoved = c.IsPropertyShipGroupSeqIdRemoved;
            e.IsPropertyProductIdRemoved = c.IsPropertyProductIdRemoved;
            e.IsPropertyLocatorIdRemoved = c.IsPropertyLocatorIdRemoved;
            e.IsPropertyAttributeSetInstanceIdRemoved = c.IsPropertyAttributeSetInstanceIdRemoved;
            e.IsPropertyShipmentItemSeqIdRemoved = c.IsPropertyShipmentItemSeqIdRemoved;
            e.IsPropertyFixedAssetIdRemoved = c.IsPropertyFixedAssetIdRemoved;
            e.IsPropertyMaintHistSeqIdRemoved = c.IsPropertyMaintHistSeqIdRemoved;
            e.IsPropertyIssuedDateTimeRemoved = c.IsPropertyIssuedDateTimeRemoved;
            e.IsPropertyIssuedByUserLoginIdRemoved = c.IsPropertyIssuedByUserLoginIdRemoved;
            e.IsPropertyQuantityRemoved = c.IsPropertyQuantityRemoved;
            e.IsPropertyCancelQuantityRemoved = c.IsPropertyCancelQuantityRemoved;
            e.IsPropertyVersionRemoved = c.IsPropertyVersionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;
            e.IsPropertyShipmentShipmentTypeIdRemoved = c.IsPropertyShipmentShipmentTypeIdRemoved;
            e.IsPropertyShipmentStatusIdRemoved = c.IsPropertyShipmentStatusIdRemoved;
            e.IsPropertyShipmentPrimaryOrderIdRemoved = c.IsPropertyShipmentPrimaryOrderIdRemoved;
            e.IsPropertyShipmentPrimaryReturnIdRemoved = c.IsPropertyShipmentPrimaryReturnIdRemoved;
            e.IsPropertyShipmentPrimaryShipGroupSeqIdRemoved = c.IsPropertyShipmentPrimaryShipGroupSeqIdRemoved;
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

        protected virtual IItemIssuanceMvoStateDeleted Map(IDeleteItemIssuanceMvo c)
        {
			var stateEventId = new ItemIssuanceMvoEventId(c.ShipmentItemIssuanceId, c.ShipmentVersion);
            IItemIssuanceMvoStateDeleted e = NewItemIssuanceMvoStateDeleted(stateEventId);
			
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();


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

        protected ItemIssuanceMvoStateCreated NewItemIssuanceMvoStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new ItemIssuanceMvoEventId(_state.ShipmentItemIssuanceId, version);
            var e = NewItemIssuanceMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected ItemIssuanceMvoStateMergePatched NewItemIssuanceMvoStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new ItemIssuanceMvoEventId(_state.ShipmentItemIssuanceId, version);
            var e = NewItemIssuanceMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected ItemIssuanceMvoStateDeleted NewItemIssuanceMvoStateDeleted(long version, string commandId, string requesterId)
        {
            var stateEventId = new ItemIssuanceMvoEventId(_state.ShipmentItemIssuanceId, version);
            var e = NewItemIssuanceMvoStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private ItemIssuanceMvoStateCreated NewItemIssuanceMvoStateCreated(ItemIssuanceMvoEventId stateEventId)
		{
			return new ItemIssuanceMvoStateCreated(stateEventId);			
		}

        private ItemIssuanceMvoStateMergePatched NewItemIssuanceMvoStateMergePatched(ItemIssuanceMvoEventId stateEventId)
		{
			return new ItemIssuanceMvoStateMergePatched(stateEventId);
		}

        private ItemIssuanceMvoStateDeleted NewItemIssuanceMvoStateDeleted(ItemIssuanceMvoEventId stateEventId)
		{
			return new ItemIssuanceMvoStateDeleted(stateEventId);
		}
    }

}

