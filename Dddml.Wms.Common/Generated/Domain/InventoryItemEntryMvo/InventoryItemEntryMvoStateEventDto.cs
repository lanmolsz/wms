﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEntryMvo;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItemEntryMvo
{

	public abstract class InventoryItemEntryMvoStateEventDtoBase : IStateEventDto, IInventoryItemEntryMvoStateCreated, IInventoryItemEntryMvoStateMergePatched
	{

        private InventoryItemEntryMvoEventId _inventoryItemEntryMvoEventId;

		protected internal virtual InventoryItemEntryMvoEventId InventoryItemEntryMvoEventId 
        {
            get 
            {
                if (_inventoryItemEntryMvoEventId == null) { _inventoryItemEntryMvoEventId = new InventoryItemEntryMvoEventId(); }
                return _inventoryItemEntryMvoEventId;
            }
            set
            {
                _inventoryItemEntryMvoEventId = value;
            }
        }

        public virtual InventoryItemEntryId InventoryItemEntryId
        {
            get { return InventoryItemEntryMvoEventId.InventoryItemEntryId; }
            set { InventoryItemEntryMvoEventId.InventoryItemEntryId = value; }
        }

        public virtual long InventoryItemVersion
        {
            get { return InventoryItemEntryMvoEventId.InventoryItemVersion; }
            set { InventoryItemEntryMvoEventId.InventoryItemVersion = value; }
        }

		public virtual decimal? OnHandQuantity { get; set; }

		public virtual decimal? InTransitQuantity { get; set; }

		public virtual decimal? ReservedQuantity { get; set; }

		public virtual decimal? OccupiedQuantity { get; set; }

		public virtual decimal? VirtualQuantity { get; set; }

		public virtual InventoryItemSourceInfo Source { get; set; }

		public virtual long? Version { get; set; }

		public virtual decimal? InventoryItemOnHandQuantity { get; set; }

		public virtual decimal? InventoryItemInTransitQuantity { get; set; }

		public virtual decimal? InventoryItemReservedQuantity { get; set; }

		public virtual decimal? InventoryItemOccupiedQuantity { get; set; }

		public virtual decimal? InventoryItemVirtualQuantity { get; set; }

		public virtual string InventoryItemCreatedBy { get; set; }

		public virtual DateTime? InventoryItemCreatedAt { get; set; }

		public virtual string InventoryItemUpdatedBy { get; set; }

		public virtual DateTime? InventoryItemUpdatedAt { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InventoryItemEntryMvoEventId IGlobalIdentity<InventoryItemEntryMvoEventId>.GlobalId {
			get 
			{
				return this.InventoryItemEntryMvoEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IInventoryItemEntryMvoStateEvent.ReadOnly
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

		public virtual bool? IsPropertyOnHandQuantityRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyOnHandQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyOnHandQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOnHandQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyInTransitQuantityRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyInTransitQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyInTransitQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInTransitQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyReservedQuantityRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyReservedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyReservedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReservedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyOccupiedQuantityRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyOccupiedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyOccupiedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOccupiedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyVirtualQuantityRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyVirtualQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyVirtualQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVirtualQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertySourceRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertySourceRemoved
        {
            get 
            {
                var b = this.IsPropertySourceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySourceRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyVersionRemoved
        {
            get 
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyInventoryItemOnHandQuantityRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyInventoryItemOnHandQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyInventoryItemOnHandQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInventoryItemOnHandQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyInventoryItemInTransitQuantityRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyInventoryItemInTransitQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyInventoryItemInTransitQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInventoryItemInTransitQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyInventoryItemReservedQuantityRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyInventoryItemReservedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyInventoryItemReservedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInventoryItemReservedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyInventoryItemOccupiedQuantityRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyInventoryItemOccupiedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyInventoryItemOccupiedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInventoryItemOccupiedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyInventoryItemVirtualQuantityRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyInventoryItemVirtualQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyInventoryItemVirtualQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInventoryItemVirtualQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyInventoryItemCreatedByRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyInventoryItemCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyInventoryItemCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInventoryItemCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyInventoryItemCreatedAtRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyInventoryItemCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyInventoryItemCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInventoryItemCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyInventoryItemUpdatedByRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyInventoryItemUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyInventoryItemUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInventoryItemUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyInventoryItemUpdatedAtRemoved { get; set; }

        bool IInventoryItemEntryMvoStateMergePatched.IsPropertyInventoryItemUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyInventoryItemUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInventoryItemUpdatedAtRemoved = value;
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


        InventoryItemEntryMvoEventId IInventoryItemEntryMvoStateEvent.InventoryItemEntryMvoEventId
        {
            get { return this.InventoryItemEntryMvoEventId; }
        }

        protected InventoryItemEntryMvoStateEventDtoBase()
        {
        }

        protected InventoryItemEntryMvoStateEventDtoBase(InventoryItemEntryMvoEventId stateEventId)
        {
            this.InventoryItemEntryMvoEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class InventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto : InventoryItemEntryMvoStateEventDtoBase
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



	public class InventoryItemEntryMvoStateCreatedDto : InventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryItemEntryMvoStateCreatedDto()
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


	public class InventoryItemEntryMvoStateMergePatchedDto : InventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryItemEntryMvoStateMergePatchedDto()
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


	public class InventoryItemEntryMvoStateDeletedDto : InventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryItemEntryMvoStateDeletedDto()
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


    public partial class InventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IInventoryItemEntryMvoStateCreated>, IEnumerable<IInventoryItemEntryMvoStateMergePatched>
    {
        private List<InventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<InventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual InventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<InventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInventoryItemEntryMvoStateCreated> IEnumerable<IInventoryItemEntryMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInventoryItemEntryMvoStateMergePatched> IEnumerable<IInventoryItemEntryMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddInventoryItemEntryMvoEvent(IInventoryItemEntryMvoStateCreated e)
        {
            _innerStateEvents.Add((InventoryItemEntryMvoStateCreatedDto)e);
        }

        public void AddInventoryItemEntryMvoEvent(IInventoryItemEntryMvoStateEvent e)
        {
            _innerStateEvents.Add((InventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }


    }


}

