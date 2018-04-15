﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirement
{

	public abstract class InventoryItemRequirementStateEventDtoBase : IStateEventDto, IInventoryItemRequirementStateCreated, IInventoryItemRequirementStateMergePatched
	{

        private InventoryItemRequirementEventId _inventoryItemRequirementEventId;

		protected internal virtual InventoryItemRequirementEventId InventoryItemRequirementEventId 
        {
            get 
            {
                if (_inventoryItemRequirementEventId == null) { _inventoryItemRequirementEventId = new InventoryItemRequirementEventId(); }
                return _inventoryItemRequirementEventId;
            }
            set
            {
                _inventoryItemRequirementEventId = value;
            }
        }

        public virtual InventoryItemId InventoryItemRequirementId
        {
            get { return InventoryItemRequirementEventId.InventoryItemRequirementId; }
            set { InventoryItemRequirementEventId.InventoryItemRequirementId = value; }
        }

        public virtual long Version
        {
            get { return InventoryItemRequirementEventId.Version; }
            set { InventoryItemRequirementEventId.Version = value; }
        }

		public virtual decimal? Quantity { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InventoryItemRequirementEventId IGlobalIdentity<InventoryItemRequirementEventId>.GlobalId {
			get 
			{
				return this.InventoryItemRequirementEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IInventoryItemRequirementStateEvent.ReadOnly
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

		public virtual bool? IsPropertyQuantityRemoved { get; set; }

        bool IInventoryItemRequirementStateMergePatched.IsPropertyQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyQuantityRemoved = value;
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


        private InventoryItemRequirementEntryStateCreatedOrMergePatchedOrRemovedDtos _inventoryItemRequirementEntryEvents = new InventoryItemRequirementEntryStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual InventoryItemRequirementEntryStateCreatedOrMergePatchedOrRemovedDto[] InventoryItemRequirementEntryEvents
        {
            get
            {
                return _inventoryItemRequirementEntryEvents.ToArray();
            }
            set
            {
                _inventoryItemRequirementEntryEvents.Clear();
                _inventoryItemRequirementEntryEvents.AddRange(value);
            }
        }



        private InventoryItemRequirementEntryEventId NewInventoryItemRequirementEntryEventId(long entrySeqId)
        {
            var eId = new InventoryItemRequirementEntryEventId();
            eId.InventoryItemRequirementId = this.InventoryItemRequirementEventId.InventoryItemRequirementId;
            eId.EntrySeqId = entrySeqId;
            eId.InventoryItemRequirementVersion = this.InventoryItemRequirementEventId.Version;
            return eId;
        }

        public virtual InventoryItemRequirementEntryStateCreatedDto NewInventoryItemRequirementEntryStateCreated(long entrySeqId)
        {
            var e = new InventoryItemRequirementEntryStateCreatedDto();
            var eId = NewInventoryItemRequirementEntryEventId(entrySeqId);
            e.InventoryItemRequirementEntryEventId = eId;
            return e;
        }

        IEnumerable<IInventoryItemRequirementEntryStateCreated> IInventoryItemRequirementStateCreated.InventoryItemRequirementEntryEvents
        {
            get { return this._inventoryItemRequirementEntryEvents; }
        }

        void IInventoryItemRequirementStateCreated.AddInventoryItemRequirementEntryEvent(IInventoryItemRequirementEntryStateCreated e)
        {
            this._inventoryItemRequirementEntryEvents.AddInventoryItemRequirementEntryEvent(e);
        }

        IInventoryItemRequirementEntryStateCreated IInventoryItemRequirementStateCreated.NewInventoryItemRequirementEntryStateCreated(long entrySeqId)
        {
            return NewInventoryItemRequirementEntryStateCreated(entrySeqId);
        }

        IEnumerable<IInventoryItemRequirementEntryStateEvent> IInventoryItemRequirementStateMergePatched.InventoryItemRequirementEntryEvents
        {
            get { return this._inventoryItemRequirementEntryEvents; }
        }

        void IInventoryItemRequirementStateMergePatched.AddInventoryItemRequirementEntryEvent(IInventoryItemRequirementEntryStateEvent e)
        {
            this._inventoryItemRequirementEntryEvents.AddInventoryItemRequirementEntryEvent(e);
        }

        IInventoryItemRequirementEntryStateCreated IInventoryItemRequirementStateMergePatched.NewInventoryItemRequirementEntryStateCreated(long entrySeqId)
        {
            return NewInventoryItemRequirementEntryStateCreated(entrySeqId);
        }


        InventoryItemRequirementEventId IInventoryItemRequirementStateEvent.InventoryItemRequirementEventId
        {
            get { return this.InventoryItemRequirementEventId; }
        }

        protected InventoryItemRequirementStateEventDtoBase()
        {
        }

        protected InventoryItemRequirementStateEventDtoBase(InventoryItemRequirementEventId stateEventId)
        {
            this.InventoryItemRequirementEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class InventoryItemRequirementStateCreatedOrMergePatchedOrDeletedDto : InventoryItemRequirementStateEventDtoBase
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



	public class InventoryItemRequirementStateCreatedDto : InventoryItemRequirementStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryItemRequirementStateCreatedDto()
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


	public class InventoryItemRequirementStateMergePatchedDto : InventoryItemRequirementStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryItemRequirementStateMergePatchedDto()
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


	public class InventoryItemRequirementStateDeletedDto : InventoryItemRequirementStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryItemRequirementStateDeletedDto()
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


    public partial class InventoryItemRequirementStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IInventoryItemRequirementStateCreated>, IEnumerable<IInventoryItemRequirementStateMergePatched>
    {
        private List<InventoryItemRequirementStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<InventoryItemRequirementStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual InventoryItemRequirementStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<InventoryItemRequirementStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInventoryItemRequirementStateCreated> IEnumerable<IInventoryItemRequirementStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInventoryItemRequirementStateMergePatched> IEnumerable<IInventoryItemRequirementStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddInventoryItemRequirementEvent(IInventoryItemRequirementStateCreated e)
        {
            _innerStateEvents.Add((InventoryItemRequirementStateCreatedDto)e);
        }

        public void AddInventoryItemRequirementEvent(IInventoryItemRequirementStateEvent e)
        {
            _innerStateEvents.Add((InventoryItemRequirementStateCreatedOrMergePatchedOrDeletedDto)e);
        }


    }


}

