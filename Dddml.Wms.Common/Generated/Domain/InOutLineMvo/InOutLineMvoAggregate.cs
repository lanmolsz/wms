﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOutLineMvo
{
    public partial class InOutLineMvoAggregate : AggregateBase, IInOutLineMvoAggregate
    {

        readonly IInOutLineMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IInOutLineMvoState State
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

        InOutLineId IGlobalIdentity<InOutLineId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public InOutLineMvoAggregate(IInOutLineMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IInOutLineMvoStateProperties)_state).InOutVersion == InOutLineMvoState.VersionZero)
            {
                if (IsCommandCreate((IInOutLineMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IInOutLineMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IInOutLineMvoCommand c)
        {
            return c.InOutVersion == InOutLineMvoState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateInOutLineMvo c)
        {
            IInOutLineMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchInOutLineMvo c)
        {
            IInOutLineMvoStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteInOutLineMvo c)
        {
            IInOutLineMvoStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IInOutLineMvoStateCreated Map(ICreateInOutLineMvo c)
        {
			var stateEventId = new InOutLineMvoStateEventId(c.InOutLineId, c.InOutVersion);
            IInOutLineMvoStateCreated e = NewInOutLineMvoStateCreated(stateEventId);
		
            e.LocatorId = c.LocatorId;
            e.ProductId = c.ProductId;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.Description = c.Description;
            e.QuantityUomId = c.QuantityUomId;
            e.MovementQuantity = c.MovementQuantity;
            e.PickedQuantity = c.PickedQuantity;
            e.IsInvoiced = c.IsInvoiced;
            e.Processed = c.Processed;
            e.RmaLineNumber = c.RmaLineNumber;
            e.ReversalLineNumber = c.ReversalLineNumber;
            e.Version = c.Version;
            e.Active = c.Active;
            NewInOutLineMvoDocumentActionCommandAndExecute(c, _state, e);
            e.InOutPosted = c.InOutPosted;
            e.InOutProcessed = c.InOutProcessed;
            e.InOutProcessing = c.InOutProcessing;
            e.InOutDocumentTypeId = c.InOutDocumentTypeId;
            e.InOutDescription = c.InOutDescription;
            e.InOutOrderId = c.InOutOrderId;
            e.InOutDateOrdered = c.InOutDateOrdered;
            e.InOutIsPrinted = c.InOutIsPrinted;
            e.InOutMovementTypeId = c.InOutMovementTypeId;
            e.InOutMovementDate = c.InOutMovementDate;
            e.InOutBusinessPartnerId = c.InOutBusinessPartnerId;
            e.InOutWarehouseId = c.InOutWarehouseId;
            e.InOutPOReference = c.InOutPOReference;
            e.InOutFreightAmount = c.InOutFreightAmount;
            e.InOutShipperId = c.InOutShipperId;
            e.InOutChargeAmount = c.InOutChargeAmount;
            e.InOutDatePrinted = c.InOutDatePrinted;
            e.InOutCreatedFrom = c.InOutCreatedFrom;
            e.InOutSalesRepresentativeId = c.InOutSalesRepresentativeId;
            e.InOutNumberOfPackages = c.InOutNumberOfPackages;
            e.InOutPickDate = c.InOutPickDate;
            e.InOutShipDate = c.InOutShipDate;
            e.InOutTrackingNumber = c.InOutTrackingNumber;
            e.InOutDateReceived = c.InOutDateReceived;
            e.InOutIsInTransit = c.InOutIsInTransit;
            e.InOutIsApproved = c.InOutIsApproved;
            e.InOutIsInDispute = c.InOutIsInDispute;
            e.InOutRmaDocumentNumber = c.InOutRmaDocumentNumber;
            e.InOutReversalDocumentNumber = c.InOutReversalDocumentNumber;
            e.InOutCreatedBy = c.InOutCreatedBy;
            e.InOutCreatedAt = c.InOutCreatedAt;
            e.InOutUpdatedBy = c.InOutUpdatedBy;
            e.InOutUpdatedAt = c.InOutUpdatedAt;
            e.InOutActive = c.InOutActive;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var inOutVersion = c.InOutVersion;


            return e;
        }

        protected virtual IInOutLineMvoStateMergePatched Map(IMergePatchInOutLineMvo c)
        {
			var stateEventId = new InOutLineMvoStateEventId(c.InOutLineId, c.InOutVersion);
            IInOutLineMvoStateMergePatched e = NewInOutLineMvoStateMergePatched(stateEventId);

            e.LocatorId = c.LocatorId;
            e.ProductId = c.ProductId;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.Description = c.Description;
            e.QuantityUomId = c.QuantityUomId;
            e.MovementQuantity = c.MovementQuantity;
            e.PickedQuantity = c.PickedQuantity;
            e.IsInvoiced = c.IsInvoiced;
            e.Processed = c.Processed;
            e.RmaLineNumber = c.RmaLineNumber;
            e.ReversalLineNumber = c.ReversalLineNumber;
            e.Version = c.Version;
            e.Active = c.Active;
            e.InOutPosted = c.InOutPosted;
            e.InOutProcessed = c.InOutProcessed;
            e.InOutProcessing = c.InOutProcessing;
            e.InOutDocumentTypeId = c.InOutDocumentTypeId;
            e.InOutDescription = c.InOutDescription;
            e.InOutOrderId = c.InOutOrderId;
            e.InOutDateOrdered = c.InOutDateOrdered;
            e.InOutIsPrinted = c.InOutIsPrinted;
            e.InOutMovementTypeId = c.InOutMovementTypeId;
            e.InOutMovementDate = c.InOutMovementDate;
            e.InOutBusinessPartnerId = c.InOutBusinessPartnerId;
            e.InOutWarehouseId = c.InOutWarehouseId;
            e.InOutPOReference = c.InOutPOReference;
            e.InOutFreightAmount = c.InOutFreightAmount;
            e.InOutShipperId = c.InOutShipperId;
            e.InOutChargeAmount = c.InOutChargeAmount;
            e.InOutDatePrinted = c.InOutDatePrinted;
            e.InOutCreatedFrom = c.InOutCreatedFrom;
            e.InOutSalesRepresentativeId = c.InOutSalesRepresentativeId;
            e.InOutNumberOfPackages = c.InOutNumberOfPackages;
            e.InOutPickDate = c.InOutPickDate;
            e.InOutShipDate = c.InOutShipDate;
            e.InOutTrackingNumber = c.InOutTrackingNumber;
            e.InOutDateReceived = c.InOutDateReceived;
            e.InOutIsInTransit = c.InOutIsInTransit;
            e.InOutIsApproved = c.InOutIsApproved;
            e.InOutIsInDispute = c.InOutIsInDispute;
            e.InOutRmaDocumentNumber = c.InOutRmaDocumentNumber;
            e.InOutReversalDocumentNumber = c.InOutReversalDocumentNumber;
            e.InOutCreatedBy = c.InOutCreatedBy;
            e.InOutCreatedAt = c.InOutCreatedAt;
            e.InOutUpdatedBy = c.InOutUpdatedBy;
            e.InOutUpdatedAt = c.InOutUpdatedAt;
            e.InOutActive = c.InOutActive;
            e.IsPropertyLocatorIdRemoved = c.IsPropertyLocatorIdRemoved;
            e.IsPropertyProductIdRemoved = c.IsPropertyProductIdRemoved;
            e.IsPropertyAttributeSetInstanceIdRemoved = c.IsPropertyAttributeSetInstanceIdRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyQuantityUomIdRemoved = c.IsPropertyQuantityUomIdRemoved;
            e.IsPropertyMovementQuantityRemoved = c.IsPropertyMovementQuantityRemoved;
            e.IsPropertyPickedQuantityRemoved = c.IsPropertyPickedQuantityRemoved;
            e.IsPropertyIsInvoicedRemoved = c.IsPropertyIsInvoicedRemoved;
            e.IsPropertyProcessedRemoved = c.IsPropertyProcessedRemoved;
            e.IsPropertyRmaLineNumberRemoved = c.IsPropertyRmaLineNumberRemoved;
            e.IsPropertyReversalLineNumberRemoved = c.IsPropertyReversalLineNumberRemoved;
            e.IsPropertyVersionRemoved = c.IsPropertyVersionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;
            e.IsPropertyInOutPostedRemoved = c.IsPropertyInOutPostedRemoved;
            e.IsPropertyInOutProcessedRemoved = c.IsPropertyInOutProcessedRemoved;
            e.IsPropertyInOutProcessingRemoved = c.IsPropertyInOutProcessingRemoved;
            e.IsPropertyInOutDocumentTypeIdRemoved = c.IsPropertyInOutDocumentTypeIdRemoved;
            e.IsPropertyInOutDescriptionRemoved = c.IsPropertyInOutDescriptionRemoved;
            e.IsPropertyInOutOrderIdRemoved = c.IsPropertyInOutOrderIdRemoved;
            e.IsPropertyInOutDateOrderedRemoved = c.IsPropertyInOutDateOrderedRemoved;
            e.IsPropertyInOutIsPrintedRemoved = c.IsPropertyInOutIsPrintedRemoved;
            e.IsPropertyInOutMovementTypeIdRemoved = c.IsPropertyInOutMovementTypeIdRemoved;
            e.IsPropertyInOutMovementDateRemoved = c.IsPropertyInOutMovementDateRemoved;
            e.IsPropertyInOutBusinessPartnerIdRemoved = c.IsPropertyInOutBusinessPartnerIdRemoved;
            e.IsPropertyInOutWarehouseIdRemoved = c.IsPropertyInOutWarehouseIdRemoved;
            e.IsPropertyInOutPOReferenceRemoved = c.IsPropertyInOutPOReferenceRemoved;
            e.IsPropertyInOutFreightAmountRemoved = c.IsPropertyInOutFreightAmountRemoved;
            e.IsPropertyInOutShipperIdRemoved = c.IsPropertyInOutShipperIdRemoved;
            e.IsPropertyInOutChargeAmountRemoved = c.IsPropertyInOutChargeAmountRemoved;
            e.IsPropertyInOutDatePrintedRemoved = c.IsPropertyInOutDatePrintedRemoved;
            e.IsPropertyInOutCreatedFromRemoved = c.IsPropertyInOutCreatedFromRemoved;
            e.IsPropertyInOutSalesRepresentativeIdRemoved = c.IsPropertyInOutSalesRepresentativeIdRemoved;
            e.IsPropertyInOutNumberOfPackagesRemoved = c.IsPropertyInOutNumberOfPackagesRemoved;
            e.IsPropertyInOutPickDateRemoved = c.IsPropertyInOutPickDateRemoved;
            e.IsPropertyInOutShipDateRemoved = c.IsPropertyInOutShipDateRemoved;
            e.IsPropertyInOutTrackingNumberRemoved = c.IsPropertyInOutTrackingNumberRemoved;
            e.IsPropertyInOutDateReceivedRemoved = c.IsPropertyInOutDateReceivedRemoved;
            e.IsPropertyInOutIsInTransitRemoved = c.IsPropertyInOutIsInTransitRemoved;
            e.IsPropertyInOutIsApprovedRemoved = c.IsPropertyInOutIsApprovedRemoved;
            e.IsPropertyInOutIsInDisputeRemoved = c.IsPropertyInOutIsInDisputeRemoved;
            e.IsPropertyInOutRmaDocumentNumberRemoved = c.IsPropertyInOutRmaDocumentNumberRemoved;
            e.IsPropertyInOutReversalDocumentNumberRemoved = c.IsPropertyInOutReversalDocumentNumberRemoved;
            e.IsPropertyInOutCreatedByRemoved = c.IsPropertyInOutCreatedByRemoved;
            e.IsPropertyInOutCreatedAtRemoved = c.IsPropertyInOutCreatedAtRemoved;
            e.IsPropertyInOutUpdatedByRemoved = c.IsPropertyInOutUpdatedByRemoved;
            e.IsPropertyInOutUpdatedAtRemoved = c.IsPropertyInOutUpdatedAtRemoved;
            e.IsPropertyInOutActiveRemoved = c.IsPropertyInOutActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var inOutVersion = c.InOutVersion;


            return e;
        }

        protected virtual IInOutLineMvoStateDeleted Map(IDeleteInOutLineMvo c)
        {
			var stateEventId = new InOutLineMvoStateEventId(c.InOutLineId, c.InOutVersion);
            IInOutLineMvoStateDeleted e = NewInOutLineMvoStateDeleted(stateEventId);
			
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();


            return e;
        }

        protected void NewInOutLineMvoDocumentActionCommandAndExecute(ICreateInOutLineMvo c, IInOutLineMvoState s, IInOutLineMvoStateCreated e)
        {
            var pCommandHandler = this.InOutLineMvoDocumentActionCommandHandler;
            var pCmdContent = default(string);
            var pCmd = new PropertyCommand<string, string> { Content = pCmdContent, GetState = () => s.InOutDocumentStatusId, SetState = p => e.InOutDocumentStatusId = p, OuterCommandType = CommandType.Create };
            pCommandHandler.Execute(pCmd);
        }

        /*
        protected void NewInOutLineMvoDocumentActionCommandAndExecute(IMergePatchInOutLineMvo c, IInOutLineMvoState s, IInOutLineMvoStateMergePatched e)
        {
            var pCommandHandler = this.InOutLineMvoDocumentActionCommandHandler;
            var pCmdContent = c.DocumentAction;
            var pCmd = new PropertyCommand<string, string> { Content = pCmdContent, GetState = () => s.InOutDocumentStatusId, SetState = p => e.InOutDocumentStatusId = p, OuterCommandType = CommandType.MergePatch };
            pCommandHandler.Execute(pCmd);
        }
        */

        protected IPropertyCommandHandler<string, string> InOutLineMvoDocumentActionCommandHandler
        {
            get
            {
                return ApplicationContext.Current["InOutLineMvoDocumentActionCommandHandler"] as IPropertyCommandHandler<string, string>;
            }
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

        protected InOutLineMvoStateCreated NewInOutLineMvoStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new InOutLineMvoStateEventId(_state.InOutLineId, ((IInOutLineMvoStateProperties)_state).InOutVersion);
            var e = NewInOutLineMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected InOutLineMvoStateMergePatched NewInOutLineMvoStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new InOutLineMvoStateEventId(_state.InOutLineId, ((IInOutLineMvoStateProperties)_state).InOutVersion);
            var e = NewInOutLineMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected InOutLineMvoStateDeleted NewInOutLineMvoStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new InOutLineMvoStateEventId(_state.InOutLineId, ((IInOutLineMvoStateProperties)_state).InOutVersion);
            var e = NewInOutLineMvoStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private InOutLineMvoStateCreated NewInOutLineMvoStateCreated(InOutLineMvoStateEventId stateEventId)
		{
			return new InOutLineMvoStateCreated(stateEventId);			
		}

        private InOutLineMvoStateMergePatched NewInOutLineMvoStateMergePatched(InOutLineMvoStateEventId stateEventId)
		{
			return new InOutLineMvoStateMergePatched(stateEventId);
		}

        private InOutLineMvoStateDeleted NewInOutLineMvoStateDeleted(InOutLineMvoStateEventId stateEventId)
		{
			return new InOutLineMvoStateDeleted(stateEventId);
		}

    }

}

