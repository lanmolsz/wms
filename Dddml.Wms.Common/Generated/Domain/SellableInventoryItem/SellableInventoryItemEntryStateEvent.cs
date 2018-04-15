﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItem
{

	public abstract class SellableInventoryItemEntryStateEventBase : ISellableInventoryItemEntryStateEvent
	{

        private SellableInventoryItemEntryState _state;

        public virtual SellableInventoryItemEntryState SellableInventoryItemEntryState { get { return _state; } }

        public virtual SellableInventoryItemEntryEventId SellableInventoryItemEntryEventId
        {
            get
            {
                SellableInventoryItemEntryEventId eventId = new SellableInventoryItemEntryEventId(_state.SellableInventoryItemId, _state.EntrySeqId, default(long));
                return eventId;
            }
            set
            {
                _state.SellableInventoryItemId = value.SellableInventoryItemId;
                _state.EntrySeqId = value.EntrySeqId;
            }
        }

        public virtual long EntrySeqId
        {
            get { return SellableInventoryItemEntryEventId.EntrySeqId; }
            set { SellableInventoryItemEntryEventId.EntrySeqId = value; }
        }

        public virtual decimal? SellableQuantity { get { return _state.SellableQuantity; } set { _state.SellableQuantity = (value != null && value.HasValue) ? value.Value : default(decimal); } }

        public virtual InventoryPRTriggeredId SourceEventId { get { return _state.SourceEventId; } set { _state.SourceEventId = value; } }

		public virtual string CreatedBy { get { return _state.CreatedBy; } set { _state.CreatedBy = value; } }

		public virtual DateTime CreatedAt { get { return _state.CreatedAt; } set { _state.CreatedAt = value; } }

        public virtual string CommandId { get { return _state.CommandId; } set { _state.CommandId = value; } }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		SellableInventoryItemEntryEventId IGlobalIdentity<SellableInventoryItemEntryEventId>.GlobalId {
			get
			{
				return this.SellableInventoryItemEntryEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool ISellableInventoryItemEntryStateEvent.ReadOnly
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

        protected SellableInventoryItemEntryStateEventBase() : this(new SellableInventoryItemEntryState())
        {
        }

        protected SellableInventoryItemEntryStateEventBase(SellableInventoryItemEntryEventId stateEventId) : this(new SellableInventoryItemEntryState())
        {
            this.SellableInventoryItemEntryEventId = stateEventId;
        }

        protected SellableInventoryItemEntryStateEventBase(SellableInventoryItemEntryState state)
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

	public class SellableInventoryItemEntryStateCreated : SellableInventoryItemEntryStateEventBase, ISellableInventoryItemEntryStateCreated
	{
		public SellableInventoryItemEntryStateCreated () : this(new SellableInventoryItemEntryEventId())
		{
		}

		public SellableInventoryItemEntryStateCreated (SellableInventoryItemEntryEventId stateEventId) : base(stateEventId)
		{
		}

        public SellableInventoryItemEntryStateCreated(SellableInventoryItemEntryState state) : base(state)
        {
        }


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}




}

