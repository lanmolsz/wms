﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{
    public partial class InventoryItemAggregate : AggregateBase, IInventoryItemAggregate
    {

        readonly IInventoryItemState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IInventoryItemState State
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

        InventoryItemId IGlobalIdentity<InventoryItemId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public InventoryItemAggregate(IInventoryItemState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IInventoryItemStateProperties)_state).Version == InventoryItemState.VersionZero)
            {
                if (IsCommandCreate((IInventoryItemCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (IsCommandCreate((IInventoryItemCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IInventoryItemCommand c)
        {
            return c.Version == InventoryItemState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateInventoryItem c)
        {
            IInventoryItemStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchInventoryItem c)
        {
            IInventoryItemStateMergePatched e = Map(c);
            Apply(e);
        }


        protected virtual IInventoryItemStateCreated Map(ICreateInventoryItem c)
        {
			var stateEventId = new InventoryItemEventId(c.InventoryItemId, c.Version);
            IInventoryItemStateCreated e = NewInventoryItemStateCreated(stateEventId);
		
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;

            decimal onHandQuantity = default(decimal);
            decimal inTransitQuantity = default(decimal);
            decimal reservedQuantity = default(decimal);
            decimal occupiedQuantity = default(decimal);
            decimal virtualQuantity = default(decimal);
            foreach (ICreateInventoryItemEntry innerCommand in c.Entries)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IInventoryItemEntryStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddInventoryItemEntryEvent(innerEvent);
                onHandQuantity = onHandQuantity + (innerEvent.OnHandQuantity != null ? innerEvent.OnHandQuantity.GetValueOrDefault() : default(decimal));
                inTransitQuantity = inTransitQuantity + (innerEvent.InTransitQuantity != null ? innerEvent.InTransitQuantity.GetValueOrDefault() : default(decimal));
                reservedQuantity = reservedQuantity + (innerEvent.ReservedQuantity != null ? innerEvent.ReservedQuantity.GetValueOrDefault() : default(decimal));
                occupiedQuantity = occupiedQuantity + (innerEvent.OccupiedQuantity != null ? innerEvent.OccupiedQuantity.GetValueOrDefault() : default(decimal));
                virtualQuantity = virtualQuantity + (innerEvent.VirtualQuantity != null ? innerEvent.VirtualQuantity.GetValueOrDefault() : default(decimal));
            }

            e.OnHandQuantity = onHandQuantity;
            e.InTransitQuantity = inTransitQuantity;
            e.ReservedQuantity = reservedQuantity;
            e.OccupiedQuantity = occupiedQuantity;
            e.VirtualQuantity = virtualQuantity;

            return e;
        }

        protected virtual IInventoryItemStateMergePatched Map(IMergePatchInventoryItem c)
        {
			var stateEventId = new InventoryItemEventId(c.InventoryItemId, c.Version);
            IInventoryItemStateMergePatched e = NewInventoryItemStateMergePatched(stateEventId);


            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;

            decimal onHandQuantity = _state.OnHandQuantity;
            decimal inTransitQuantity = _state.InTransitQuantity;
            decimal reservedQuantity = _state.ReservedQuantity;
            decimal occupiedQuantity = _state.OccupiedQuantity;
            decimal virtualQuantity = _state.VirtualQuantity;
            foreach (IInventoryItemEntryCommand innerCommand in c.InventoryItemEntryCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IInventoryItemEntryStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddInventoryItemEntryEvent(innerEvent);
                // ////////////////
                if (!(innerEvent is IInventoryItemEntryStateCreated)) { continue; }
                var entryCreated = (IInventoryItemEntryStateCreated)innerEvent;
                onHandQuantity = onHandQuantity + (entryCreated.OnHandQuantity != null ? entryCreated.OnHandQuantity.GetValueOrDefault() : default(decimal));
                inTransitQuantity = inTransitQuantity + (entryCreated.InTransitQuantity != null ? entryCreated.InTransitQuantity.GetValueOrDefault() : default(decimal));
                reservedQuantity = reservedQuantity + (entryCreated.ReservedQuantity != null ? entryCreated.ReservedQuantity.GetValueOrDefault() : default(decimal));
                occupiedQuantity = occupiedQuantity + (entryCreated.OccupiedQuantity != null ? entryCreated.OccupiedQuantity.GetValueOrDefault() : default(decimal));
                virtualQuantity = virtualQuantity + (entryCreated.VirtualQuantity != null ? entryCreated.VirtualQuantity.GetValueOrDefault() : default(decimal));
                // ////////////////
            }

            e.OnHandQuantity = onHandQuantity;
            e.InTransitQuantity = inTransitQuantity;
            e.ReservedQuantity = reservedQuantity;
            e.OccupiedQuantity = occupiedQuantity;
            e.VirtualQuantity = virtualQuantity;

            return e;
        }


        protected void ThrowOnInconsistentCommands(IInventoryItemCommand command, IInventoryItemEntryCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeleteInventoryItem;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveInventoryItemEntry;
            if (properties == null || innerProperties == null) { return; }
            if (innerProperties.InventoryItemId == default(InventoryItemId))
            {
                innerProperties.InventoryItemId = properties.InventoryItemId;
            }
            else
            {
                var outerInventoryItemIdName = "InventoryItemId";
                var outerInventoryItemIdValue = properties.InventoryItemId;
                var innerInventoryItemIdName = "InventoryItemId";
                var innerInventoryItemIdValue = innerProperties.InventoryItemId;
                ThrowOnInconsistentIds(innerProperties, innerInventoryItemIdName, innerInventoryItemIdValue, outerInventoryItemIdName, outerInventoryItemIdValue);
            }

        }// END ThrowOnInconsistentCommands /////////////////////


        protected virtual IInventoryItemEntryStateEvent Map(IInventoryItemEntryCommand c, IInventoryItemCommand outerCommand, long version, IInventoryItemState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateInventoryItemEntry) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            throw new NotSupportedException();
        }


        protected virtual IInventoryItemEntryStateCreated MapCreate(ICreateInventoryItemEntry c, IInventoryItemCommand outerCommand, long version, IInventoryItemState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new InventoryItemEntryEventId(c.InventoryItemId, c.EntrySeqId, version);
            IInventoryItemEntryStateCreated e = NewInventoryItemEntryStateCreated(stateEventId);
            var s = outerState.Entries.Get(c.EntrySeqId, true);

            e.OnHandQuantity = c.OnHandQuantity;
            e.InTransitQuantity = c.InTransitQuantity;
            e.ReservedQuantity = c.ReservedQuantity;
            e.OccupiedQuantity = c.OccupiedQuantity;
            e.VirtualQuantity = c.VirtualQuantity;
            e.Source = c.Source;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
            return e;

        }// END Map(ICreate... ////////////////////////////



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

        protected InventoryItemStateCreated NewInventoryItemStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new InventoryItemEventId(_state.InventoryItemId, version);
            var e = NewInventoryItemStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected InventoryItemStateMergePatched NewInventoryItemStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new InventoryItemEventId(_state.InventoryItemId, version);
            var e = NewInventoryItemStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


////////////////////////

		private InventoryItemStateCreated NewInventoryItemStateCreated(InventoryItemEventId stateEventId)
		{
			return new InventoryItemStateCreated(stateEventId);			
		}

        private InventoryItemStateMergePatched NewInventoryItemStateMergePatched(InventoryItemEventId stateEventId)
		{
			return new InventoryItemStateMergePatched(stateEventId);
		}


		private InventoryItemEntryStateCreated NewInventoryItemEntryStateCreated(InventoryItemEntryEventId stateEventId)
		{
			return new InventoryItemEntryStateCreated(stateEventId);
		}

    }

}

