﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRoleTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RoleType;

namespace Dddml.Wms.Domain.RoleType
{
    public partial class RoleTypeAggregate : AggregateBase, IRoleTypeAggregate
    {

        readonly IRoleTypeState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IRoleTypeState State
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


        public RoleTypeAggregate(IRoleTypeState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IRoleTypeStateProperties)_state).Version == RoleTypeState.VersionZero)
            {
                if (IsCommandCreate((IRoleTypeCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IRoleTypeCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IRoleTypeCommand c)
        {
            return c.Version == RoleTypeState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateRoleType c)
        {
            IRoleTypeStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchRoleType c)
        {
            IRoleTypeStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteRoleType c)
        {
            IRoleTypeStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IRoleTypeStateCreated Map(ICreateRoleType c)
        {
			var stateEventId = new RoleTypeEventId(c.RoleTypeId, c.Version);
            IRoleTypeStateCreated e = NewRoleTypeStateCreated(stateEventId);
		
            e.ParentTypeId = c.ParentTypeId;
            e.HasTable = c.HasTable;
            e.Description = c.Description;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;


            return e;
        }

        protected virtual IRoleTypeStateMergePatched Map(IMergePatchRoleType c)
        {
			var stateEventId = new RoleTypeEventId(c.RoleTypeId, c.Version);
            IRoleTypeStateMergePatched e = NewRoleTypeStateMergePatched(stateEventId);

            e.ParentTypeId = c.ParentTypeId;
            e.HasTable = c.HasTable;
            e.Description = c.Description;
            e.Active = c.Active;
            e.IsPropertyParentTypeIdRemoved = c.IsPropertyParentTypeIdRemoved;
            e.IsPropertyHasTableRemoved = c.IsPropertyHasTableRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;


            return e;
        }

        protected virtual IRoleTypeStateDeleted Map(IDeleteRoleType c)
        {
			var stateEventId = new RoleTypeEventId(c.RoleTypeId, c.Version);
            IRoleTypeStateDeleted e = NewRoleTypeStateDeleted(stateEventId);
			
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

        protected RoleTypeStateCreated NewRoleTypeStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new RoleTypeEventId(_state.RoleTypeId, version);
            var e = NewRoleTypeStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected RoleTypeStateMergePatched NewRoleTypeStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new RoleTypeEventId(_state.RoleTypeId, version);
            var e = NewRoleTypeStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected RoleTypeStateDeleted NewRoleTypeStateDeleted(long version, string commandId, string requesterId)
        {
            var stateEventId = new RoleTypeEventId(_state.RoleTypeId, version);
            var e = NewRoleTypeStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private RoleTypeStateCreated NewRoleTypeStateCreated(RoleTypeEventId stateEventId)
		{
			return new RoleTypeStateCreated(stateEventId);			
		}

        private RoleTypeStateMergePatched NewRoleTypeStateMergePatched(RoleTypeEventId stateEventId)
		{
			return new RoleTypeStateMergePatched(stateEventId);
		}

        private RoleTypeStateDeleted NewRoleTypeStateDeleted(RoleTypeEventId stateEventId)
		{
			return new RoleTypeStateDeleted(stateEventId);
		}
    }

}
