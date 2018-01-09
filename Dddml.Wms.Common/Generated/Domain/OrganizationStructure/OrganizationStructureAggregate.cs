﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationStructureDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructure;

namespace Dddml.Wms.Domain.OrganizationStructure
{
    public partial class OrganizationStructureAggregate : AggregateBase, IOrganizationStructureAggregate
    {

        readonly IOrganizationStructureState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IOrganizationStructureState State
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

        OrganizationStructureId IGlobalIdentity<OrganizationStructureId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public OrganizationStructureAggregate(IOrganizationStructureState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IOrganizationStructureStateProperties)_state).Version == OrganizationStructureState.VersionZero)
            {
                if (IsCommandCreate((IOrganizationStructureCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IOrganizationStructureCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IOrganizationStructureCommand c)
        {
            return c.Version == OrganizationStructureState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateOrganizationStructure c)
        {
            IOrganizationStructureStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchOrganizationStructure c)
        {
            IOrganizationStructureStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteOrganizationStructure c)
        {
            IOrganizationStructureStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IOrganizationStructureStateCreated Map(ICreateOrganizationStructure c)
        {
			var stateEventId = new OrganizationStructureStateEventId(c.Id, c.Version);
            IOrganizationStructureStateCreated e = NewOrganizationStructureStateCreated(stateEventId);
		
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;


            return e;
        }

        protected virtual IOrganizationStructureStateMergePatched Map(IMergePatchOrganizationStructure c)
        {
			var stateEventId = new OrganizationStructureStateEventId(c.Id, c.Version);
            IOrganizationStructureStateMergePatched e = NewOrganizationStructureStateMergePatched(stateEventId);

            e.Active = c.Active;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;


            return e;
        }

        protected virtual IOrganizationStructureStateDeleted Map(IDeleteOrganizationStructure c)
        {
			var stateEventId = new OrganizationStructureStateEventId(c.Id, c.Version);
            IOrganizationStructureStateDeleted e = NewOrganizationStructureStateDeleted(stateEventId);
			
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

        protected OrganizationStructureStateCreated NewOrganizationStructureStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new OrganizationStructureStateEventId(_state.Id, version);
            var e = NewOrganizationStructureStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected OrganizationStructureStateMergePatched NewOrganizationStructureStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new OrganizationStructureStateEventId(_state.Id, version);
            var e = NewOrganizationStructureStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected OrganizationStructureStateDeleted NewOrganizationStructureStateDeleted(long version, string commandId, string requesterId)
        {
            var stateEventId = new OrganizationStructureStateEventId(_state.Id, version);
            var e = NewOrganizationStructureStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private OrganizationStructureStateCreated NewOrganizationStructureStateCreated(OrganizationStructureStateEventId stateEventId)
		{
			return new OrganizationStructureStateCreated(stateEventId);			
		}

        private OrganizationStructureStateMergePatched NewOrganizationStructureStateMergePatched(OrganizationStructureStateEventId stateEventId)
		{
			return new OrganizationStructureStateMergePatched(stateEventId);
		}

        private OrganizationStructureStateDeleted NewOrganizationStructureStateDeleted(OrganizationStructureStateEventId stateEventId)
		{
			return new OrganizationStructureStateDeleted(stateEventId);
		}
    }

}

