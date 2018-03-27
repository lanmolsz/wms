﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLocatorTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.LocatorType;

namespace Dddml.Wms.Domain.LocatorType
{
    public partial class LocatorTypeAggregate : AggregateBase, ILocatorTypeAggregate
    {

        readonly ILocatorTypeState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public ILocatorTypeState State
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


        public LocatorTypeAggregate(ILocatorTypeState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((ILocatorTypeStateProperties)_state).Version == LocatorTypeState.VersionZero)
            {
                if (IsCommandCreate((ILocatorTypeCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((ILocatorTypeCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(ILocatorTypeCommand c)
        {
            return c.Version == LocatorTypeState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateLocatorType c)
        {
            ILocatorTypeStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchLocatorType c)
        {
            ILocatorTypeStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteLocatorType c)
        {
            ILocatorTypeStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual ILocatorTypeStateCreated Map(ICreateLocatorType c)
        {
			var stateEventId = new LocatorTypeEventId(c.LocatorTypeId, c.Version);
            ILocatorTypeStateCreated e = NewLocatorTypeStateCreated(stateEventId);
		
            e.Description = c.Description;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;


            return e;
        }

        protected virtual ILocatorTypeStateMergePatched Map(IMergePatchLocatorType c)
        {
			var stateEventId = new LocatorTypeEventId(c.LocatorTypeId, c.Version);
            ILocatorTypeStateMergePatched e = NewLocatorTypeStateMergePatched(stateEventId);

            e.Description = c.Description;
            e.Active = c.Active;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;


            return e;
        }

        protected virtual ILocatorTypeStateDeleted Map(IDeleteLocatorType c)
        {
			var stateEventId = new LocatorTypeEventId(c.LocatorTypeId, c.Version);
            ILocatorTypeStateDeleted e = NewLocatorTypeStateDeleted(stateEventId);
			
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

        protected LocatorTypeStateCreated NewLocatorTypeStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new LocatorTypeEventId(_state.LocatorTypeId, version);
            var e = NewLocatorTypeStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected LocatorTypeStateMergePatched NewLocatorTypeStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new LocatorTypeEventId(_state.LocatorTypeId, version);
            var e = NewLocatorTypeStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected LocatorTypeStateDeleted NewLocatorTypeStateDeleted(long version, string commandId, string requesterId)
        {
            var stateEventId = new LocatorTypeEventId(_state.LocatorTypeId, version);
            var e = NewLocatorTypeStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private LocatorTypeStateCreated NewLocatorTypeStateCreated(LocatorTypeEventId stateEventId)
		{
			return new LocatorTypeStateCreated(stateEventId);			
		}

        private LocatorTypeStateMergePatched NewLocatorTypeStateMergePatched(LocatorTypeEventId stateEventId)
		{
			return new LocatorTypeStateMergePatched(stateEventId);
		}

        private LocatorTypeStateDeleted NewLocatorTypeStateDeleted(LocatorTypeEventId stateEventId)
		{
			return new LocatorTypeStateDeleted(stateEventId);
		}
    }

}
