﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageReasonDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageReason;

namespace Dddml.Wms.Domain.DamageReason
{
    public partial class DamageReasonAggregate : AggregateBase, IDamageReasonAggregate
    {

        readonly IDamageReasonState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IDamageReasonState State
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


        public DamageReasonAggregate(IDamageReasonState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IDamageReasonStateProperties)_state).Version == DamageReasonState.VersionZero)
            {
                if (IsCommandCreate((IDamageReasonCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IDamageReasonCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IDamageReasonCommand c)
        {
            return c.Version == DamageReasonState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateDamageReason c)
        {
            IDamageReasonStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchDamageReason c)
        {
            IDamageReasonStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteDamageReason c)
        {
            IDamageReasonStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IDamageReasonStateCreated Map(ICreateDamageReason c)
        {
			var stateEventId = new DamageReasonStateEventId(c.DamageReasonId, c.Version);
            IDamageReasonStateCreated e = NewDamageReasonStateCreated(stateEventId);
		
            e.Description = c.Description;
            e.SequenceId = c.SequenceId;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;


            return e;
        }

        protected virtual IDamageReasonStateMergePatched Map(IMergePatchDamageReason c)
        {
			var stateEventId = new DamageReasonStateEventId(c.DamageReasonId, c.Version);
            IDamageReasonStateMergePatched e = NewDamageReasonStateMergePatched(stateEventId);

            e.Description = c.Description;
            e.SequenceId = c.SequenceId;
            e.Active = c.Active;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertySequenceIdRemoved = c.IsPropertySequenceIdRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;


            return e;
        }

        protected virtual IDamageReasonStateDeleted Map(IDeleteDamageReason c)
        {
			var stateEventId = new DamageReasonStateEventId(c.DamageReasonId, c.Version);
            IDamageReasonStateDeleted e = NewDamageReasonStateDeleted(stateEventId);
			
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

        protected DamageReasonStateCreated NewDamageReasonStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new DamageReasonStateEventId(_state.DamageReasonId, ((IDamageReasonStateProperties)_state).Version);
            var e = NewDamageReasonStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected DamageReasonStateMergePatched NewDamageReasonStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new DamageReasonStateEventId(_state.DamageReasonId, ((IDamageReasonStateProperties)_state).Version);
            var e = NewDamageReasonStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected DamageReasonStateDeleted NewDamageReasonStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new DamageReasonStateEventId(_state.DamageReasonId, ((IDamageReasonStateProperties)_state).Version);
            var e = NewDamageReasonStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private DamageReasonStateCreated NewDamageReasonStateCreated(DamageReasonStateEventId stateEventId)
		{
			return new DamageReasonStateCreated(stateEventId);			
		}

        private DamageReasonStateMergePatched NewDamageReasonStateMergePatched(DamageReasonStateEventId stateEventId)
		{
			return new DamageReasonStateMergePatched(stateEventId);
		}

        private DamageReasonStateDeleted NewDamageReasonStateDeleted(DamageReasonStateEventId stateEventId)
		{
			return new DamageReasonStateDeleted(stateEventId);
		}

    }

}

