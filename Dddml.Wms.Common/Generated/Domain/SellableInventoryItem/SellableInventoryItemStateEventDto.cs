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

	public abstract class SellableInventoryItemStateEventDtoBase : IStateEventDto, ISellableInventoryItemStateCreated, ISellableInventoryItemStateMergePatched
	{

        private SellableInventoryItemEventId _sellableInventoryItemEventId;

		protected internal virtual SellableInventoryItemEventId SellableInventoryItemEventId 
        {
            get 
            {
                if (_sellableInventoryItemEventId == null) { _sellableInventoryItemEventId = new SellableInventoryItemEventId(); }
                return _sellableInventoryItemEventId;
            }
            set
            {
                _sellableInventoryItemEventId = value;
            }
        }

        public virtual InventoryItemId SellableInventoryItemId
        {
            get { return SellableInventoryItemEventId.SellableInventoryItemId; }
            set { SellableInventoryItemEventId.SellableInventoryItemId = value; }
        }

        public virtual long Version
        {
            get { return SellableInventoryItemEventId.Version; }
            set { SellableInventoryItemEventId.Version = value; }
        }

		public virtual decimal? SellableQuantity { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		SellableInventoryItemEventId IGlobalIdentity<SellableInventoryItemEventId>.GlobalId {
			get 
			{
				return this.SellableInventoryItemEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool ISellableInventoryItemStateEvent.ReadOnly
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

		public virtual bool? IsPropertySellableQuantityRemoved { get; set; }

        bool ISellableInventoryItemStateMergePatched.IsPropertySellableQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertySellableQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySellableQuantityRemoved = value;
            }
        }

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


        private SellableInventoryItemEntryStateCreatedOrMergePatchedOrRemovedDtos _sellableInventoryItemEntryEvents = new SellableInventoryItemEntryStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual SellableInventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto[] SellableInventoryItemEntryEvents
        {
            get
            {
                return _sellableInventoryItemEntryEvents.ToArray();
            }
            set
            {
                _sellableInventoryItemEntryEvents.Clear();
                _sellableInventoryItemEntryEvents.AddRange(value);
            }
        }



        private SellableInventoryItemEntryEventId NewSellableInventoryItemEntryEventId(long entrySeqId)
        {
            var eId = new SellableInventoryItemEntryEventId();
            eId.SellableInventoryItemId = this.SellableInventoryItemEventId.SellableInventoryItemId;
            eId.EntrySeqId = entrySeqId;
            eId.SellableInventoryItemVersion = this.SellableInventoryItemEventId.Version;
            return eId;
        }

        public virtual SellableInventoryItemEntryStateCreatedDto NewSellableInventoryItemEntryStateCreated(long entrySeqId)
        {
            var e = new SellableInventoryItemEntryStateCreatedDto();
            var eId = NewSellableInventoryItemEntryEventId(entrySeqId);
            e.SellableInventoryItemEntryEventId = eId;
            return e;
        }

        IEnumerable<ISellableInventoryItemEntryStateCreated> ISellableInventoryItemStateCreated.SellableInventoryItemEntryEvents
        {
            get { return this._sellableInventoryItemEntryEvents; }
        }

        void ISellableInventoryItemStateCreated.AddSellableInventoryItemEntryEvent(ISellableInventoryItemEntryStateCreated e)
        {
            this._sellableInventoryItemEntryEvents.AddSellableInventoryItemEntryEvent(e);
        }

        ISellableInventoryItemEntryStateCreated ISellableInventoryItemStateCreated.NewSellableInventoryItemEntryStateCreated(long entrySeqId)
        {
            return NewSellableInventoryItemEntryStateCreated(entrySeqId);
        }

        IEnumerable<ISellableInventoryItemEntryStateEvent> ISellableInventoryItemStateMergePatched.SellableInventoryItemEntryEvents
        {
            get { return this._sellableInventoryItemEntryEvents; }
        }

        void ISellableInventoryItemStateMergePatched.AddSellableInventoryItemEntryEvent(ISellableInventoryItemEntryStateEvent e)
        {
            this._sellableInventoryItemEntryEvents.AddSellableInventoryItemEntryEvent(e);
        }

        ISellableInventoryItemEntryStateCreated ISellableInventoryItemStateMergePatched.NewSellableInventoryItemEntryStateCreated(long entrySeqId)
        {
            return NewSellableInventoryItemEntryStateCreated(entrySeqId);
        }


        SellableInventoryItemEventId ISellableInventoryItemStateEvent.SellableInventoryItemEventId
        {
            get { return this.SellableInventoryItemEventId; }
        }

        protected SellableInventoryItemStateEventDtoBase()
        {
        }

        protected SellableInventoryItemStateEventDtoBase(SellableInventoryItemEventId stateEventId)
        {
            this.SellableInventoryItemEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class SellableInventoryItemStateCreatedOrMergePatchedOrDeletedDto : SellableInventoryItemStateEventDtoBase
    {
        private string _eventType;

        public virtual string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._eventType;
        }

    }



	public class SellableInventoryItemStateCreatedDto : SellableInventoryItemStateCreatedOrMergePatchedOrDeletedDto
	{
		public SellableInventoryItemStateCreatedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class SellableInventoryItemStateMergePatchedDto : SellableInventoryItemStateCreatedOrMergePatchedOrDeletedDto
	{
		public SellableInventoryItemStateMergePatchedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class SellableInventoryItemStateDeletedDto : SellableInventoryItemStateCreatedOrMergePatchedOrDeletedDto
	{
		public SellableInventoryItemStateDeletedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class SellableInventoryItemStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<ISellableInventoryItemStateCreated>, IEnumerable<ISellableInventoryItemStateMergePatched>
    {
        private List<SellableInventoryItemStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<SellableInventoryItemStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual SellableInventoryItemStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<SellableInventoryItemStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<ISellableInventoryItemStateCreated> IEnumerable<ISellableInventoryItemStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<ISellableInventoryItemStateMergePatched> IEnumerable<ISellableInventoryItemStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddSellableInventoryItemEvent(ISellableInventoryItemStateCreated e)
        {
            _innerStateEvents.Add((SellableInventoryItemStateCreatedDto)e);
        }

        public void AddSellableInventoryItemEvent(ISellableInventoryItemStateEvent e)
        {
            _innerStateEvents.Add((SellableInventoryItemStateCreatedOrMergePatchedOrDeletedDto)e);
        }


    }


}

