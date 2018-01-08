﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;

namespace Dddml.Wms.Domain.PhysicalInventory
{
    public partial class PhysicalInventoryAggregate : AggregateBase, IPhysicalInventoryAggregate
    {

        readonly IPhysicalInventoryState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IPhysicalInventoryState State
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

        string IGlobalIdentity<string>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public PhysicalInventoryAggregate(IPhysicalInventoryState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IPhysicalInventoryStateProperties)_state).Version == PhysicalInventoryState.VersionZero)
            {
                if (IsCommandCreate((IPhysicalInventoryCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IPhysicalInventoryCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IPhysicalInventoryCommand c)
        {
            return c.Version == PhysicalInventoryState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreatePhysicalInventory c)
        {
            IPhysicalInventoryStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchPhysicalInventory c)
        {
            IPhysicalInventoryStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeletePhysicalInventory c)
        {
            IPhysicalInventoryStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IPhysicalInventoryStateCreated Map(ICreatePhysicalInventory c)
        {
			var stateEventId = new PhysicalInventoryStateEventId(c.DocumentNumber, c.Version);
            IPhysicalInventoryStateCreated e = NewPhysicalInventoryStateCreated(stateEventId);
		
            NewPhysicalInventoryDocumentActionCommandAndExecute(c, _state, e);
            e.WarehouseId = c.WarehouseId;
            e.Posted = c.Posted;
            e.Processed = c.Processed;
            e.Processing = c.Processing;
            e.DocumentTypeId = c.DocumentTypeId;
            e.MovementDate = c.MovementDate;
            e.Description = c.Description;
            e.IsApproved = c.IsApproved;
            e.ApprovalAmount = c.ApprovalAmount;
            e.IsQuantityUpdated = c.IsQuantityUpdated;
            e.ReversalDocumentNumber = c.ReversalDocumentNumber;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;

            foreach (ICreatePhysicalInventoryLine innerCommand in c.PhysicalInventoryLines)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IPhysicalInventoryLineStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddPhysicalInventoryLineEvent(innerEvent);
            }


            return e;
        }

        protected virtual IPhysicalInventoryStateMergePatched Map(IMergePatchPhysicalInventory c)
        {
			var stateEventId = new PhysicalInventoryStateEventId(c.DocumentNumber, c.Version);
            IPhysicalInventoryStateMergePatched e = NewPhysicalInventoryStateMergePatched(stateEventId);

            e.WarehouseId = c.WarehouseId;
            e.Posted = c.Posted;
            e.Processed = c.Processed;
            e.Processing = c.Processing;
            e.DocumentTypeId = c.DocumentTypeId;
            e.MovementDate = c.MovementDate;
            e.Description = c.Description;
            e.IsApproved = c.IsApproved;
            e.ApprovalAmount = c.ApprovalAmount;
            e.IsQuantityUpdated = c.IsQuantityUpdated;
            e.ReversalDocumentNumber = c.ReversalDocumentNumber;
            e.Active = c.Active;
            e.IsPropertyWarehouseIdRemoved = c.IsPropertyWarehouseIdRemoved;
            e.IsPropertyPostedRemoved = c.IsPropertyPostedRemoved;
            e.IsPropertyProcessedRemoved = c.IsPropertyProcessedRemoved;
            e.IsPropertyProcessingRemoved = c.IsPropertyProcessingRemoved;
            e.IsPropertyDocumentTypeIdRemoved = c.IsPropertyDocumentTypeIdRemoved;
            e.IsPropertyMovementDateRemoved = c.IsPropertyMovementDateRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyIsApprovedRemoved = c.IsPropertyIsApprovedRemoved;
            e.IsPropertyApprovalAmountRemoved = c.IsPropertyApprovalAmountRemoved;
            e.IsPropertyIsQuantityUpdatedRemoved = c.IsPropertyIsQuantityUpdatedRemoved;
            e.IsPropertyReversalDocumentNumberRemoved = c.IsPropertyReversalDocumentNumberRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;

            foreach (IPhysicalInventoryLineCommand innerCommand in c.PhysicalInventoryLineCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IPhysicalInventoryLineStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddPhysicalInventoryLineEvent(innerEvent);
            }


            return e;
        }

        protected virtual IPhysicalInventoryStateDeleted Map(IDeletePhysicalInventory c)
        {
			var stateEventId = new PhysicalInventoryStateEventId(c.DocumentNumber, c.Version);
            IPhysicalInventoryStateDeleted e = NewPhysicalInventoryStateDeleted(stateEventId);
			
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();


            return e;
        }


        protected void ThrowOnInconsistentCommands(IPhysicalInventoryCommand command, IPhysicalInventoryLineCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeletePhysicalInventory;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemovePhysicalInventoryLine;
            if (properties == null || innerProperties == null) { return; }
            if (innerProperties.PhysicalInventoryDocumentNumber == default(string))
            {
                innerProperties.PhysicalInventoryDocumentNumber = properties.DocumentNumber;
            }
            else
            {
                var outerDocumentNumberName = "DocumentNumber";
                var outerDocumentNumberValue = properties.DocumentNumber;
                var innerPhysicalInventoryDocumentNumberName = "PhysicalInventoryDocumentNumber";
                var innerPhysicalInventoryDocumentNumberValue = innerProperties.PhysicalInventoryDocumentNumber;
                ThrowOnInconsistentIds(innerProperties, innerPhysicalInventoryDocumentNumberName, innerPhysicalInventoryDocumentNumberValue, outerDocumentNumberName, outerDocumentNumberValue);
            }

        }// END ThrowOnInconsistentCommands /////////////////////


        protected virtual IPhysicalInventoryLineStateEvent Map(IPhysicalInventoryLineCommand c, IPhysicalInventoryCommand outerCommand, long version, IPhysicalInventoryState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreatePhysicalInventoryLine) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchPhysicalInventoryLine) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemovePhysicalInventoryLine) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IPhysicalInventoryLineStateCreated MapCreate(ICreatePhysicalInventoryLine c, IPhysicalInventoryCommand outerCommand, long version, IPhysicalInventoryState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new PhysicalInventoryLineStateEventId(c.PhysicalInventoryDocumentNumber, c.LineNumber, version);
            IPhysicalInventoryLineStateCreated e = NewPhysicalInventoryLineStateCreated(stateEventId);
            var s = outerState.PhysicalInventoryLines.Get(c.LineNumber, true);

            e.LocatorId = c.LocatorId;
            e.ProductId = c.ProductId;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.BookQuantity = c.BookQuantity;
            e.CountedQuantity = c.CountedQuantity;
            e.Processed = c.Processed;
            e.ReversalLineNumber = c.ReversalLineNumber;
            e.Description = c.Description;
            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IPhysicalInventoryLineStateMergePatched MapMergePatch(IMergePatchPhysicalInventoryLine c, IPhysicalInventoryCommand outerCommand, long version, IPhysicalInventoryState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new PhysicalInventoryLineStateEventId(c.PhysicalInventoryDocumentNumber, c.LineNumber, version);
            IPhysicalInventoryLineStateMergePatched e = NewPhysicalInventoryLineStateMergePatched(stateEventId);
            var s = outerState.PhysicalInventoryLines.Get(c.LineNumber);

            e.LocatorId = c.LocatorId;
            e.ProductId = c.ProductId;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.BookQuantity = c.BookQuantity;
            e.CountedQuantity = c.CountedQuantity;
            e.Processed = c.Processed;
            e.ReversalLineNumber = c.ReversalLineNumber;
            e.Description = c.Description;
            e.Active = c.Active;
            e.IsPropertyLocatorIdRemoved = c.IsPropertyLocatorIdRemoved;
            e.IsPropertyProductIdRemoved = c.IsPropertyProductIdRemoved;
            e.IsPropertyAttributeSetInstanceIdRemoved = c.IsPropertyAttributeSetInstanceIdRemoved;
            e.IsPropertyBookQuantityRemoved = c.IsPropertyBookQuantityRemoved;
            e.IsPropertyCountedQuantityRemoved = c.IsPropertyCountedQuantityRemoved;
            e.IsPropertyProcessedRemoved = c.IsPropertyProcessedRemoved;
            e.IsPropertyReversalLineNumberRemoved = c.IsPropertyReversalLineNumberRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IPhysicalInventoryLineStateRemoved MapRemove(IRemovePhysicalInventoryLine c, IPhysicalInventoryCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new PhysicalInventoryLineStateEventId(c.PhysicalInventoryDocumentNumber, c.LineNumber, version);
            IPhysicalInventoryLineStateRemoved e = NewPhysicalInventoryLineStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;

        }// END Map(IRemove... ////////////////////////////

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

        protected PhysicalInventoryStateCreated NewPhysicalInventoryStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new PhysicalInventoryStateEventId(_state.DocumentNumber, ((IPhysicalInventoryStateProperties)_state).Version);
            var e = NewPhysicalInventoryStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected PhysicalInventoryStateMergePatched NewPhysicalInventoryStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new PhysicalInventoryStateEventId(_state.DocumentNumber, ((IPhysicalInventoryStateProperties)_state).Version);
            var e = NewPhysicalInventoryStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected PhysicalInventoryStateDeleted NewPhysicalInventoryStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new PhysicalInventoryStateEventId(_state.DocumentNumber, ((IPhysicalInventoryStateProperties)_state).Version);
            var e = NewPhysicalInventoryStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private PhysicalInventoryStateCreated NewPhysicalInventoryStateCreated(PhysicalInventoryStateEventId stateEventId)
		{
			return new PhysicalInventoryStateCreated(stateEventId);			
		}

        private PhysicalInventoryStateMergePatched NewPhysicalInventoryStateMergePatched(PhysicalInventoryStateEventId stateEventId)
		{
			return new PhysicalInventoryStateMergePatched(stateEventId);
		}

        private PhysicalInventoryStateDeleted NewPhysicalInventoryStateDeleted(PhysicalInventoryStateEventId stateEventId)
		{
			return new PhysicalInventoryStateDeleted(stateEventId);
		}

		private PhysicalInventoryLineStateCreated NewPhysicalInventoryLineStateCreated(PhysicalInventoryLineStateEventId stateEventId)
		{
			return new PhysicalInventoryLineStateCreated(stateEventId);
		}

        private PhysicalInventoryLineStateMergePatched NewPhysicalInventoryLineStateMergePatched(PhysicalInventoryLineStateEventId stateEventId)
		{
			return new PhysicalInventoryLineStateMergePatched(stateEventId);
		}

        private PhysicalInventoryLineStateRemoved NewPhysicalInventoryLineStateRemoved(PhysicalInventoryLineStateEventId stateEventId)
		{
			return new PhysicalInventoryLineStateRemoved(stateEventId);
		}

        protected void NewPhysicalInventoryDocumentActionCommandAndExecute(ICreatePhysicalInventory c, IPhysicalInventoryState s, IPhysicalInventoryStateCreated e)
        {
            var pCommandHandler = this.PhysicalInventoryDocumentActionCommandHandler;
            var pCmdContent = default(string);
            var pCmd = new PropertyCommand<string, string> { Content = pCmdContent, GetState = () => s.DocumentStatusId, SetState = p => e.DocumentStatusId = p, OuterCommandType = CommandType.Create };
            pCommandHandler.Execute(pCmd);
        }

        //protected void NewPhysicalInventoryDocumentActionCommandAndExecute(IMergePatchPhysicalInventory c, IPhysicalInventoryState s, IPhysicalInventoryStateMergePatched e)
        //{
        //    var pCommandHandler = this.PhysicalInventoryDocumentActionCommandHandler;
        //    var pCmdContent = c.DocumentAction;
        //    var pCmd = new PropertyCommand<string, string> { Content = pCmdContent, GetState = () => s.DocumentStatusId, SetState = p => e.DocumentStatusId = p, OuterCommandType = CommandType.MergePatch };
        //    pCommandHandler.Execute(pCmd);
        //}

        protected IPropertyCommandHandler<string, string> PhysicalInventoryDocumentActionCommandHandler
        {
            get
            {
                return ApplicationContext.Current["PhysicalInventoryDocumentActionCommandHandler"] as IPropertyCommandHandler<string, string>;
            }
        }

        protected virtual void DoDocumentAction(string value, Action<string> setDocumentStatusId)
        {
            var pCommandHandler = this.PhysicalInventoryDocumentActionCommandHandler;
            var pCmdContent = value;
            var pCmd = new PropertyCommand<string, string> { Content = pCmdContent, GetState = () => this.State.DocumentStatusId, SetState = setDocumentStatusId, OuterCommandType = "DocumentAction" };
            pCommandHandler.Execute(pCmd);
        }

    }

}

