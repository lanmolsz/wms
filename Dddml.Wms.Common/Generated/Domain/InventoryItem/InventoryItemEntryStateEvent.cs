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

	public abstract class InventoryItemEntryStateEventBase : IInventoryItemEntryStateEvent
	{

        private InventoryItemEntryState _state;

        public virtual InventoryItemEntryState InventoryItemEntryState { get { return _state; } }

        public virtual InventoryItemEntryEventId InventoryItemEntryEventId
        {
            get
            {
                InventoryItemEntryEventId eventId = new InventoryItemEntryEventId(_state.InventoryItemId, _state.EntrySeqId, default(long));
                return eventId;
            }
            set
            {
                _state.InventoryItemId = value.InventoryItemId;
                _state.EntrySeqId = value.EntrySeqId;
            }
        }

        public virtual long EntrySeqId
        {
            get { return InventoryItemEntryEventId.EntrySeqId; }
            set { InventoryItemEntryEventId.EntrySeqId = value; }
        }

        public virtual decimal? OnHandQuantity { get { return _state.OnHandQuantity; } set { _state.OnHandQuantity = (value != null && value.HasValue) ? value.Value : default(decimal); } }

        public virtual decimal? InTransitQuantity { get { return _state.InTransitQuantity; } set { _state.InTransitQuantity = (value != null && value.HasValue) ? value.Value : default(decimal); } }

        public virtual decimal? ReservedQuantity { get { return _state.ReservedQuantity; } set { _state.ReservedQuantity = (value != null && value.HasValue) ? value.Value : default(decimal); } }

        public virtual decimal? OccupiedQuantity { get { return _state.OccupiedQuantity; } set { _state.OccupiedQuantity = (value != null && value.HasValue) ? value.Value : default(decimal); } }

        public virtual decimal? VirtualQuantity { get { return _state.VirtualQuantity; } set { _state.VirtualQuantity = (value != null && value.HasValue) ? value.Value : default(decimal); } }

        public virtual InventoryItemSourceInfo Source { get { return _state.Source; } set { _state.Source = value; } }

		public virtual string CreatedBy { get { return _state.CreatedBy; } set { _state.CreatedBy = value; } }

		public virtual DateTime CreatedAt { get { return _state.CreatedAt; } set { _state.CreatedAt = value; } }

        public virtual string CommandId { get { return _state.CommandId; } set { _state.CommandId = value; } }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InventoryItemEntryEventId IGlobalIdentity<InventoryItemEntryEventId>.GlobalId {
			get
			{
				return this.InventoryItemEntryEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IInventoryItemEntryStateEvent.ReadOnly
        {
            get
            {
                return this.EventReadOnly;
            }
            set
            {
                this.EventReadOnly = value;
            }
        }

		public virtual long Version { get; set; }


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}

        protected InventoryItemEntryStateEventBase() : this(new InventoryItemEntryState())
        {
        }

        protected InventoryItemEntryStateEventBase(InventoryItemEntryEventId stateEventId) : this(new InventoryItemEntryState())
        {
            this.InventoryItemEntryEventId = stateEventId;
        }

        protected InventoryItemEntryStateEventBase(InventoryItemEntryState state)
        {
            if (state == null) { throw new ArgumentNullException(); }
            this._state = state;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class InventoryItemEntryStateCreated : InventoryItemEntryStateEventBase, IInventoryItemEntryStateCreated
	{
		public InventoryItemEntryStateCreated () : this(new InventoryItemEntryEventId())
		{
		}

		public InventoryItemEntryStateCreated (InventoryItemEntryEventId stateEventId) : base(stateEventId)
		{
		}

        public InventoryItemEntryStateCreated(InventoryItemEntryState state) : base(state)
        {
        }


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}




}

