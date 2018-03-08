﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Uom;

namespace Dddml.Wms.Domain.Uom
{
    public partial class UomAggregate : AggregateBase, IUomAggregate
    {

        readonly IUomState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IUomState State
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


        public UomAggregate(IUomState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IUomStateProperties)_state).Version == UomState.VersionZero)
            {
                if (IsCommandCreate((IUomCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IUomCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IUomCommand c)
        {
            return c.Version == UomState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateUom c)
        {
            IUomStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchUom c)
        {
            IUomStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteUom c)
        {
            IUomStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IUomStateCreated Map(ICreateUom c)
        {
			var stateEventId = new UomEventId(c.UomId, c.Version);
            IUomStateCreated e = NewUomStateCreated(stateEventId);
		
            e.UomTypeId = c.UomTypeId;
            e.Abbreviation = c.Abbreviation;
            e.Description = c.Description;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;


            return e;
        }

        protected virtual IUomStateMergePatched Map(IMergePatchUom c)
        {
			var stateEventId = new UomEventId(c.UomId, c.Version);
            IUomStateMergePatched e = NewUomStateMergePatched(stateEventId);

            e.UomTypeId = c.UomTypeId;
            e.Abbreviation = c.Abbreviation;
            e.Description = c.Description;
            e.Active = c.Active;
            e.IsPropertyUomTypeIdRemoved = c.IsPropertyUomTypeIdRemoved;
            e.IsPropertyAbbreviationRemoved = c.IsPropertyAbbreviationRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;


            return e;
        }

        protected virtual IUomStateDeleted Map(IDeleteUom c)
        {
			var stateEventId = new UomEventId(c.UomId, c.Version);
            IUomStateDeleted e = NewUomStateDeleted(stateEventId);
			
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

        protected UomStateCreated NewUomStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new UomEventId(_state.UomId, version);
            var e = NewUomStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected UomStateMergePatched NewUomStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new UomEventId(_state.UomId, version);
            var e = NewUomStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected UomStateDeleted NewUomStateDeleted(long version, string commandId, string requesterId)
        {
            var stateEventId = new UomEventId(_state.UomId, version);
            var e = NewUomStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private UomStateCreated NewUomStateCreated(UomEventId stateEventId)
		{
			return new UomStateCreated(stateEventId);			
		}

        private UomStateMergePatched NewUomStateMergePatched(UomEventId stateEventId)
		{
			return new UomStateMergePatched(stateEventId);
		}

        private UomStateDeleted NewUomStateDeleted(UomEventId stateEventId)
		{
			return new UomStateDeleted(stateEventId);
		}
    }

}

