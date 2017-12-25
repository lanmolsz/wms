﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmation
{
    public partial class MovementConfirmationAggregate : AggregateBase, IMovementConfirmationAggregate
    {

        readonly IMovementConfirmationState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IMovementConfirmationState State
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


        public MovementConfirmationAggregate(IMovementConfirmationState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IMovementConfirmationStateProperties)_state).Version == MovementConfirmationState.VersionZero)
            {
                if (IsCommandCreate((IMovementConfirmationCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IMovementConfirmationCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IMovementConfirmationCommand c)
        {
            return c.Version == MovementConfirmationState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateMovementConfirmation c)
        {
            IMovementConfirmationStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchMovementConfirmation c)
        {
            IMovementConfirmationStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteMovementConfirmation c)
        {
            IMovementConfirmationStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IMovementConfirmationStateCreated Map(ICreateMovementConfirmation c)
        {
			var stateEventId = new MovementConfirmationStateEventId(c.DocumentNumber, c.Version);
            IMovementConfirmationStateCreated e = NewMovementConfirmationStateCreated(stateEventId);
		
            NewMovementConfirmationDocumentActionCommandAndExecute(c, _state, e);
            e.MovementDocumentNumber = c.MovementDocumentNumber;
            e.IsApproved = c.IsApproved;
            e.ApprovalAmount = c.ApprovalAmount;
            e.Processed = c.Processed;
            e.Processing = c.Processing;
            e.DocumentTypeId = c.DocumentTypeId;
            e.Description = c.Description;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var version = c.Version;

            foreach (ICreateMovementConfirmationLine innerCommand in c.MovementConfirmationLines)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IMovementConfirmationLineStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddMovementConfirmationLineEvent(innerEvent);
            }


            return e;
        }

        protected virtual IMovementConfirmationStateMergePatched Map(IMergePatchMovementConfirmation c)
        {
			var stateEventId = new MovementConfirmationStateEventId(c.DocumentNumber, c.Version);
            IMovementConfirmationStateMergePatched e = NewMovementConfirmationStateMergePatched(stateEventId);

            NewMovementConfirmationDocumentActionCommandAndExecute(c, _state, e);
            e.MovementDocumentNumber = c.MovementDocumentNumber;
            e.IsApproved = c.IsApproved;
            e.ApprovalAmount = c.ApprovalAmount;
            e.Processed = c.Processed;
            e.Processing = c.Processing;
            e.DocumentTypeId = c.DocumentTypeId;
            e.Description = c.Description;
            e.Active = c.Active;
            e.IsPropertyMovementDocumentNumberRemoved = c.IsPropertyMovementDocumentNumberRemoved;
            e.IsPropertyIsApprovedRemoved = c.IsPropertyIsApprovedRemoved;
            e.IsPropertyApprovalAmountRemoved = c.IsPropertyApprovalAmountRemoved;
            e.IsPropertyProcessedRemoved = c.IsPropertyProcessedRemoved;
            e.IsPropertyProcessingRemoved = c.IsPropertyProcessingRemoved;
            e.IsPropertyDocumentTypeIdRemoved = c.IsPropertyDocumentTypeIdRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var version = c.Version;

            foreach (IMovementConfirmationLineCommand innerCommand in c.MovementConfirmationLineCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IMovementConfirmationLineStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddMovementConfirmationLineEvent(innerEvent);
            }


            return e;
        }

        protected virtual IMovementConfirmationStateDeleted Map(IDeleteMovementConfirmation c)
        {
			var stateEventId = new MovementConfirmationStateEventId(c.DocumentNumber, c.Version);
            IMovementConfirmationStateDeleted e = NewMovementConfirmationStateDeleted(stateEventId);
			
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;


            return e;
        }


        protected void ThrowOnInconsistentCommands(IMovementConfirmationCommand command, IMovementConfirmationLineCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeleteMovementConfirmation;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveMovementConfirmationLine;
            if (properties == null || innerProperties == null) { return; }
            if (innerProperties.MovementConfirmationDocumentNumber == default(string))
            {
                innerProperties.MovementConfirmationDocumentNumber = properties.DocumentNumber;
            }
            else
            {
                var outerDocumentNumberName = "DocumentNumber";
                var outerDocumentNumberValue = properties.DocumentNumber;
                var innerMovementConfirmationDocumentNumberName = "MovementConfirmationDocumentNumber";
                var innerMovementConfirmationDocumentNumberValue = innerProperties.MovementConfirmationDocumentNumber;
                ThrowOnInconsistentIds(innerProperties, innerMovementConfirmationDocumentNumberName, innerMovementConfirmationDocumentNumberValue, outerDocumentNumberName, outerDocumentNumberValue);
            }

        }// END ThrowOnInconsistentCommands /////////////////////


        protected virtual IMovementConfirmationLineStateEvent Map(IMovementConfirmationLineCommand c, IMovementConfirmationCommand outerCommand, long version, IMovementConfirmationState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateMovementConfirmationLine) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchMovementConfirmationLine) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemoveMovementConfirmationLine) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IMovementConfirmationLineStateCreated MapCreate(ICreateMovementConfirmationLine c, IMovementConfirmationCommand outerCommand, long version, IMovementConfirmationState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new MovementConfirmationLineStateEventId(c.MovementConfirmationDocumentNumber, c.LineNumber, version);
            IMovementConfirmationLineStateCreated e = NewMovementConfirmationLineStateCreated(stateEventId);
            var s = outerState.MovementConfirmationLines.Get(c.LineNumber, true);

            e.MovementLineNumber = c.MovementLineNumber;
            e.TargetQuantity = c.TargetQuantity;
            e.ConfirmedQuantity = c.ConfirmedQuantity;
            e.DifferenceQuantity = c.DifferenceQuantity;
            e.ScrappedQuantity = c.ScrappedQuantity;
            e.Description = c.Description;
            e.Processed = c.Processed;
            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IMovementConfirmationLineStateMergePatched MapMergePatch(IMergePatchMovementConfirmationLine c, IMovementConfirmationCommand outerCommand, long version, IMovementConfirmationState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new MovementConfirmationLineStateEventId(c.MovementConfirmationDocumentNumber, c.LineNumber, version);
            IMovementConfirmationLineStateMergePatched e = NewMovementConfirmationLineStateMergePatched(stateEventId);
            var s = outerState.MovementConfirmationLines.Get(c.LineNumber);

            e.MovementLineNumber = c.MovementLineNumber;
            e.TargetQuantity = c.TargetQuantity;
            e.ConfirmedQuantity = c.ConfirmedQuantity;
            e.DifferenceQuantity = c.DifferenceQuantity;
            e.ScrappedQuantity = c.ScrappedQuantity;
            e.Description = c.Description;
            e.Processed = c.Processed;
            e.Active = c.Active;
            e.IsPropertyMovementLineNumberRemoved = c.IsPropertyMovementLineNumberRemoved;
            e.IsPropertyTargetQuantityRemoved = c.IsPropertyTargetQuantityRemoved;
            e.IsPropertyConfirmedQuantityRemoved = c.IsPropertyConfirmedQuantityRemoved;
            e.IsPropertyDifferenceQuantityRemoved = c.IsPropertyDifferenceQuantityRemoved;
            e.IsPropertyScrappedQuantityRemoved = c.IsPropertyScrappedQuantityRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyProcessedRemoved = c.IsPropertyProcessedRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IMovementConfirmationLineStateRemoved MapRemove(IRemoveMovementConfirmationLine c, IMovementConfirmationCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new MovementConfirmationLineStateEventId(c.MovementConfirmationDocumentNumber, c.LineNumber, version);
            IMovementConfirmationLineStateRemoved e = NewMovementConfirmationLineStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            return e;

        }// END Map(IRemove... ////////////////////////////

        protected void NewMovementConfirmationDocumentActionCommandAndExecute(IMergePatchMovementConfirmation c, IMovementConfirmationState s, IMovementConfirmationStateMergePatched e)
        {
            var pCommandHandler = this.MovementConfirmationDocumentActionCommandHandler;
            var pCmdContent = c.DocumentAction;
            var pCmd = new PropertyCommand<string, string> { Content = pCmdContent, GetState = () => s.DocumentStatusId, SetState = p => e.DocumentStatusId = p, OuterCommandType = CommandType.MergePatch };
            pCommandHandler.Execute(pCmd);
        }

        protected void NewMovementConfirmationDocumentActionCommandAndExecute(ICreateMovementConfirmation c, IMovementConfirmationState s, IMovementConfirmationStateCreated e)
        {
            var pCommandHandler = this.MovementConfirmationDocumentActionCommandHandler;
            var pCmdContent = c.DocumentAction;
            var pCmd = new PropertyCommand<string, string> { Content = pCmdContent, GetState = () => s.DocumentStatusId, SetState = p => e.DocumentStatusId = p, OuterCommandType = CommandType.Create };
            pCommandHandler.Execute(pCmd);
        }

        protected IPropertyCommandHandler<string, string> MovementConfirmationDocumentActionCommandHandler
        {
            get
            {
                return ApplicationContext.Current["MovementConfirmationDocumentActionCommandHandler"] as IPropertyCommandHandler<string, string>;
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

        protected MovementConfirmationStateCreated NewMovementConfirmationStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new MovementConfirmationStateEventId(_state.DocumentNumber, ((IMovementConfirmationStateProperties)_state).Version);
            var e = NewMovementConfirmationStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected MovementConfirmationStateMergePatched NewMovementConfirmationStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new MovementConfirmationStateEventId(_state.DocumentNumber, ((IMovementConfirmationStateProperties)_state).Version);
            var e = NewMovementConfirmationStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected MovementConfirmationStateDeleted NewMovementConfirmationStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new MovementConfirmationStateEventId(_state.DocumentNumber, ((IMovementConfirmationStateProperties)_state).Version);
            var e = NewMovementConfirmationStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private MovementConfirmationStateCreated NewMovementConfirmationStateCreated(MovementConfirmationStateEventId stateEventId)
		{
			return new MovementConfirmationStateCreated(stateEventId);			
		}

        private MovementConfirmationStateMergePatched NewMovementConfirmationStateMergePatched(MovementConfirmationStateEventId stateEventId)
		{
			return new MovementConfirmationStateMergePatched(stateEventId);
		}

        private MovementConfirmationStateDeleted NewMovementConfirmationStateDeleted(MovementConfirmationStateEventId stateEventId)
		{
			return new MovementConfirmationStateDeleted(stateEventId);
		}

		private MovementConfirmationLineStateCreated NewMovementConfirmationLineStateCreated(MovementConfirmationLineStateEventId stateEventId)
		{
			return new MovementConfirmationLineStateCreated(stateEventId);
		}

        private MovementConfirmationLineStateMergePatched NewMovementConfirmationLineStateMergePatched(MovementConfirmationLineStateEventId stateEventId)
		{
			return new MovementConfirmationLineStateMergePatched(stateEventId);
		}

        private MovementConfirmationLineStateRemoved NewMovementConfirmationLineStateRemoved(MovementConfirmationLineStateEventId stateEventId)
		{
			return new MovementConfirmationLineStateRemoved(stateEventId);
		}


    }

}

