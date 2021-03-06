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
    public partial class MovementLineMvoAggregate : AggregateBase, IMovementLineMvoAggregate
    {

        readonly IMovementLineMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IMovementLineMvoState State
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

        MovementLineId IGlobalIdentity<MovementLineId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public MovementLineMvoAggregate(IMovementLineMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IMovementLineMvoStateProperties)_state).MovementVersion == MovementLineMvoState.VersionZero)
            {
                if (IsCommandCreate((IMovementLineMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IMovementLineMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IMovementLineMvoCommand c)
        {
            return c.MovementVersion == MovementLineMvoState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateMovementLineMvo c)
        {
            IMovementLineMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchMovementLineMvo c)
        {
            IMovementLineMvoStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteMovementLineMvo c)
        {
            IMovementLineMvoStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IMovementLineMvoStateCreated Map(ICreateMovementLineMvo c)
        {
			var stateEventId = new MovementLineMvoEventId(c.MovementLineId, c.MovementVersion);
            IMovementLineMvoStateCreated e = NewMovementLineMvoStateCreated(stateEventId);
		
            e.MovementQuantity = c.MovementQuantity;
            e.ProductId = c.ProductId;
            e.LocatorIdFrom = c.LocatorIdFrom;
            e.LocatorIdTo = c.LocatorIdTo;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.Processed = c.Processed;
            e.ReversalLineNumber = c.ReversalLineNumber;
            e.Version = c.Version;
            e.Active = c.Active;
            e.MovementDocumentStatusId = c.MovementDocumentStatusId;
            e.MovementMovementDate = c.MovementMovementDate;
            e.MovementPosted = c.MovementPosted;
            e.MovementProcessed = c.MovementProcessed;
            e.MovementProcessing = c.MovementProcessing;
            e.MovementDateReceived = c.MovementDateReceived;
            e.MovementDocumentTypeId = c.MovementDocumentTypeId;
            e.MovementIsInTransit = c.MovementIsInTransit;
            e.MovementIsApproved = c.MovementIsApproved;
            e.MovementApprovalAmount = c.MovementApprovalAmount;
            e.MovementShipperId = c.MovementShipperId;
            e.MovementSalesRepresentativeId = c.MovementSalesRepresentativeId;
            e.MovementBusinessPartnerId = c.MovementBusinessPartnerId;
            e.MovementChargeAmount = c.MovementChargeAmount;
            e.MovementCreateFrom = c.MovementCreateFrom;
            e.MovementFreightAmount = c.MovementFreightAmount;
            e.MovementReversalDocumentNumber = c.MovementReversalDocumentNumber;
            e.MovementWarehouseIdFrom = c.MovementWarehouseIdFrom;
            e.MovementWarehouseIdTo = c.MovementWarehouseIdTo;
            e.MovementDescription = c.MovementDescription;
            e.MovementCreatedBy = c.MovementCreatedBy;
            e.MovementCreatedAt = c.MovementCreatedAt;
            e.MovementUpdatedBy = c.MovementUpdatedBy;
            e.MovementUpdatedAt = c.MovementUpdatedAt;
            e.MovementActive = c.MovementActive;
            e.MovementDeleted = c.MovementDeleted;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var movementVersion = c.MovementVersion;


            return e;
        }

        protected virtual IMovementLineMvoStateMergePatched Map(IMergePatchMovementLineMvo c)
        {
			var stateEventId = new MovementLineMvoEventId(c.MovementLineId, c.MovementVersion);
            IMovementLineMvoStateMergePatched e = NewMovementLineMvoStateMergePatched(stateEventId);

            e.MovementQuantity = c.MovementQuantity;
            e.ProductId = c.ProductId;
            e.LocatorIdFrom = c.LocatorIdFrom;
            e.LocatorIdTo = c.LocatorIdTo;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.Processed = c.Processed;
            e.ReversalLineNumber = c.ReversalLineNumber;
            e.Version = c.Version;
            e.Active = c.Active;
            e.MovementDocumentStatusId = c.MovementDocumentStatusId;
            e.MovementMovementDate = c.MovementMovementDate;
            e.MovementPosted = c.MovementPosted;
            e.MovementProcessed = c.MovementProcessed;
            e.MovementProcessing = c.MovementProcessing;
            e.MovementDateReceived = c.MovementDateReceived;
            e.MovementDocumentTypeId = c.MovementDocumentTypeId;
            e.MovementIsInTransit = c.MovementIsInTransit;
            e.MovementIsApproved = c.MovementIsApproved;
            e.MovementApprovalAmount = c.MovementApprovalAmount;
            e.MovementShipperId = c.MovementShipperId;
            e.MovementSalesRepresentativeId = c.MovementSalesRepresentativeId;
            e.MovementBusinessPartnerId = c.MovementBusinessPartnerId;
            e.MovementChargeAmount = c.MovementChargeAmount;
            e.MovementCreateFrom = c.MovementCreateFrom;
            e.MovementFreightAmount = c.MovementFreightAmount;
            e.MovementReversalDocumentNumber = c.MovementReversalDocumentNumber;
            e.MovementWarehouseIdFrom = c.MovementWarehouseIdFrom;
            e.MovementWarehouseIdTo = c.MovementWarehouseIdTo;
            e.MovementDescription = c.MovementDescription;
            e.MovementCreatedBy = c.MovementCreatedBy;
            e.MovementCreatedAt = c.MovementCreatedAt;
            e.MovementUpdatedBy = c.MovementUpdatedBy;
            e.MovementUpdatedAt = c.MovementUpdatedAt;
            e.MovementActive = c.MovementActive;
            e.MovementDeleted = c.MovementDeleted;
            e.IsPropertyMovementQuantityRemoved = c.IsPropertyMovementQuantityRemoved;
            e.IsPropertyProductIdRemoved = c.IsPropertyProductIdRemoved;
            e.IsPropertyLocatorIdFromRemoved = c.IsPropertyLocatorIdFromRemoved;
            e.IsPropertyLocatorIdToRemoved = c.IsPropertyLocatorIdToRemoved;
            e.IsPropertyAttributeSetInstanceIdRemoved = c.IsPropertyAttributeSetInstanceIdRemoved;
            e.IsPropertyProcessedRemoved = c.IsPropertyProcessedRemoved;
            e.IsPropertyReversalLineNumberRemoved = c.IsPropertyReversalLineNumberRemoved;
            e.IsPropertyVersionRemoved = c.IsPropertyVersionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;
            e.IsPropertyMovementDocumentStatusIdRemoved = c.IsPropertyMovementDocumentStatusIdRemoved;
            e.IsPropertyMovementMovementDateRemoved = c.IsPropertyMovementMovementDateRemoved;
            e.IsPropertyMovementPostedRemoved = c.IsPropertyMovementPostedRemoved;
            e.IsPropertyMovementProcessedRemoved = c.IsPropertyMovementProcessedRemoved;
            e.IsPropertyMovementProcessingRemoved = c.IsPropertyMovementProcessingRemoved;
            e.IsPropertyMovementDateReceivedRemoved = c.IsPropertyMovementDateReceivedRemoved;
            e.IsPropertyMovementDocumentTypeIdRemoved = c.IsPropertyMovementDocumentTypeIdRemoved;
            e.IsPropertyMovementIsInTransitRemoved = c.IsPropertyMovementIsInTransitRemoved;
            e.IsPropertyMovementIsApprovedRemoved = c.IsPropertyMovementIsApprovedRemoved;
            e.IsPropertyMovementApprovalAmountRemoved = c.IsPropertyMovementApprovalAmountRemoved;
            e.IsPropertyMovementShipperIdRemoved = c.IsPropertyMovementShipperIdRemoved;
            e.IsPropertyMovementSalesRepresentativeIdRemoved = c.IsPropertyMovementSalesRepresentativeIdRemoved;
            e.IsPropertyMovementBusinessPartnerIdRemoved = c.IsPropertyMovementBusinessPartnerIdRemoved;
            e.IsPropertyMovementChargeAmountRemoved = c.IsPropertyMovementChargeAmountRemoved;
            e.IsPropertyMovementCreateFromRemoved = c.IsPropertyMovementCreateFromRemoved;
            e.IsPropertyMovementFreightAmountRemoved = c.IsPropertyMovementFreightAmountRemoved;
            e.IsPropertyMovementReversalDocumentNumberRemoved = c.IsPropertyMovementReversalDocumentNumberRemoved;
            e.IsPropertyMovementWarehouseIdFromRemoved = c.IsPropertyMovementWarehouseIdFromRemoved;
            e.IsPropertyMovementWarehouseIdToRemoved = c.IsPropertyMovementWarehouseIdToRemoved;
            e.IsPropertyMovementDescriptionRemoved = c.IsPropertyMovementDescriptionRemoved;
            e.IsPropertyMovementCreatedByRemoved = c.IsPropertyMovementCreatedByRemoved;
            e.IsPropertyMovementCreatedAtRemoved = c.IsPropertyMovementCreatedAtRemoved;
            e.IsPropertyMovementUpdatedByRemoved = c.IsPropertyMovementUpdatedByRemoved;
            e.IsPropertyMovementUpdatedAtRemoved = c.IsPropertyMovementUpdatedAtRemoved;
            e.IsPropertyMovementActiveRemoved = c.IsPropertyMovementActiveRemoved;
            e.IsPropertyMovementDeletedRemoved = c.IsPropertyMovementDeletedRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var movementVersion = c.MovementVersion;


            return e;
        }

        protected virtual IMovementLineMvoStateDeleted Map(IDeleteMovementLineMvo c)
        {
			var stateEventId = new MovementLineMvoEventId(c.MovementLineId, c.MovementVersion);
            IMovementLineMvoStateDeleted e = NewMovementLineMvoStateDeleted(stateEventId);
			
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

        protected MovementLineMvoStateCreated NewMovementLineMvoStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new MovementLineMvoEventId(_state.MovementLineId, version);
            var e = NewMovementLineMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected MovementLineMvoStateMergePatched NewMovementLineMvoStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new MovementLineMvoEventId(_state.MovementLineId, version);
            var e = NewMovementLineMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected MovementLineMvoStateDeleted NewMovementLineMvoStateDeleted(long version, string commandId, string requesterId)
        {
            var stateEventId = new MovementLineMvoEventId(_state.MovementLineId, version);
            var e = NewMovementLineMvoStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private MovementLineMvoStateCreated NewMovementLineMvoStateCreated(MovementLineMvoEventId stateEventId)
		{
			return new MovementLineMvoStateCreated(stateEventId);			
		}

        private MovementLineMvoStateMergePatched NewMovementLineMvoStateMergePatched(MovementLineMvoEventId stateEventId)
		{
			return new MovementLineMvoStateMergePatched(stateEventId);
		}

        private MovementLineMvoStateDeleted NewMovementLineMvoStateDeleted(MovementLineMvoEventId stateEventId)
		{
			return new MovementLineMvoStateDeleted(stateEventId);
		}
    }

}

