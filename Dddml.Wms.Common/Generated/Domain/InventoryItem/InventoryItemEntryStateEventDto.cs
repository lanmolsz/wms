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

	public abstract class InventoryItemEntryStateEventDtoBase : IStateEventDto, IInventoryItemEntryStateCreated
	{

        private InventoryItemEntryStateEventIdDto _stateEventId;

		protected internal virtual InventoryItemEntryStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new InventoryItemEntryStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual long EntrySeqId
        {
            get { return StateEventId.EntrySeqId; }
            set { StateEventId.EntrySeqId = value; }
        }

		public virtual decimal? QuantityOnHand { get; set; }

		public virtual decimal? QuantityReserved { get; set; }

		public virtual decimal? QuantityOccupied { get; set; }

		public virtual decimal? QuantityVirtual { get; set; }

		private InventoryItemSourceVODto _source = new InventoryItemSourceVODto();

		public virtual InventoryItemSourceVODto Source { get { return _source; } set { _source = value; } }

		InventoryItemSourceVO IInventoryItemEntryStateEvent.Source
		{ 
			get 
			{
				return this.Source == null ? null : this.Source.ToInventoryItemSourceVO(); 
			} 
			set
			{
				if (value == null) { Source = null; } else { Source = new InventoryItemSourceVODtoWrapper(value); }
			} 
		}

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InventoryItemEntryStateEventId IGlobalIdentity<InventoryItemEntryStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToInventoryItemEntryStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IInventoryItemEntryStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
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


        InventoryItemEntryStateEventId IInventoryItemEntryStateEvent.StateEventId
        {
            get { return this.StateEventId.ToInventoryItemEntryStateEventId(); }
        }

        protected InventoryItemEntryStateEventDtoBase()
        {
        }

        protected InventoryItemEntryStateEventDtoBase(InventoryItemEntryStateEventIdDto stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto : InventoryItemEntryStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class InventoryItemEntryStateCreatedDto : InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto
	{
		public InventoryItemEntryStateCreatedDto()
		{
		}

        public override string StateEventType
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


	public class InventoryItemEntryStateMergePatchedDto : InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto
	{
		public InventoryItemEntryStateMergePatchedDto()
		{
		}

        public override string StateEventType
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


	public class InventoryItemEntryStateRemovedDto : InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto
	{
		public InventoryItemEntryStateRemovedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

	}


    public partial class InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IInventoryItemEntryStateCreated>
    {
        private List<InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInventoryItemEntryStateCreated> IEnumerable<IInventoryItemEntryStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddInventoryItemEntryEvent(IInventoryItemEntryStateCreated e)
        {
            _innerStateEvents.Add((InventoryItemEntryStateCreatedDto)e);
        }

        public void AddInventoryItemEntryEvent(IInventoryItemEntryStateEvent e)
        {
            _innerStateEvents.Add((InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto)e);
        }


    }


}

