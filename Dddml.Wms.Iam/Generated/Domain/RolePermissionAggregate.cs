﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RolePermission;

namespace Dddml.Wms.Domain.RolePermission
{
    public partial class RolePermissionAggregate : AggregateBase, IRolePermissionAggregate
    {

        readonly IRolePermissionState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IRolePermissionState State
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

        RolePermissionId IGlobalIdentity<RolePermissionId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public RolePermissionAggregate(IRolePermissionState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IRolePermissionStateProperties)_state).Version == RolePermissionState.VersionZero)
            {
                if (IsCommandCreate((IRolePermissionCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IRolePermissionCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IRolePermissionCommand c)
        {
            return c.Version == RolePermissionState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateRolePermission c)
        {
            IRolePermissionStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchRolePermission c)
        {
            IRolePermissionStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteRolePermission c)
        {
            IRolePermissionStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IRolePermissionStateCreated Map(ICreateRolePermission c)
        {
			var stateEventId = new RolePermissionEventId(c.Id, c.Version);
            IRolePermissionStateCreated e = NewRolePermissionStateCreated(stateEventId);
		
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;


            return e;
        }

        protected virtual IRolePermissionStateMergePatched Map(IMergePatchRolePermission c)
        {
			var stateEventId = new RolePermissionEventId(c.Id, c.Version);
            IRolePermissionStateMergePatched e = NewRolePermissionStateMergePatched(stateEventId);

            e.Active = c.Active;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;


            return e;
        }

        protected virtual IRolePermissionStateDeleted Map(IDeleteRolePermission c)
        {
			var stateEventId = new RolePermissionEventId(c.Id, c.Version);
            IRolePermissionStateDeleted e = NewRolePermissionStateDeleted(stateEventId);
			
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

        protected RolePermissionStateCreated NewRolePermissionStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new RolePermissionEventId(_state.Id, version);
            var e = NewRolePermissionStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected RolePermissionStateMergePatched NewRolePermissionStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new RolePermissionEventId(_state.Id, version);
            var e = NewRolePermissionStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected RolePermissionStateDeleted NewRolePermissionStateDeleted(long version, string commandId, string requesterId)
        {
            var stateEventId = new RolePermissionEventId(_state.Id, version);
            var e = NewRolePermissionStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private RolePermissionStateCreated NewRolePermissionStateCreated(RolePermissionEventId stateEventId)
		{
			return new RolePermissionStateCreated(stateEventId);			
		}

        private RolePermissionStateMergePatched NewRolePermissionStateMergePatched(RolePermissionEventId stateEventId)
		{
			return new RolePermissionStateMergePatched(stateEventId);
		}

        private RolePermissionStateDeleted NewRolePermissionStateDeleted(RolePermissionEventId stateEventId)
		{
			return new RolePermissionStateDeleted(stateEventId);
		}
    }

}

