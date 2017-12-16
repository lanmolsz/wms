﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateWarehouseDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Warehouse;

namespace Dddml.Wms.Domain.Warehouse
{

	public abstract class WarehouseStateEventDtoBase : IStateEventDto, IWarehouseStateCreated, IWarehouseStateMergePatched, IWarehouseStateDeleted
	{

        private WarehouseStateEventIdDto _stateEventId;

		protected internal virtual WarehouseStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new WarehouseStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string WarehouseId
        {
            get { return StateEventId.WarehouseId; }
            set { StateEventId.WarehouseId = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		public virtual string WarehouseName { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? IsInTransit { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		WarehouseStateEventId IGlobalIdentity<WarehouseStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToWarehouseStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IWarehouseStateEvent.ReadOnly
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

		public virtual bool? IsPropertyWarehouseNameRemoved { get; set; }

        bool IWarehouseStateMergePatched.IsPropertyWarehouseNameRemoved
        {
            get 
            {
                var b = this.IsPropertyWarehouseNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyWarehouseNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IWarehouseStateMergePatched.IsPropertyDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInTransitRemoved { get; set; }

        bool IWarehouseStateMergePatched.IsPropertyIsInTransitRemoved
        {
            get 
            {
                var b = this.IsPropertyIsInTransitRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsInTransitRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IWarehouseStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
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


        WarehouseStateEventId IWarehouseStateEvent.StateEventId
        {
            get { return this.StateEventId.ToWarehouseStateEventId(); }
        }

        protected WarehouseStateEventDtoBase()
        {
        }

        protected WarehouseStateEventDtoBase(WarehouseStateEventIdDto stateEventId)
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


    public class WarehouseStateCreatedOrMergePatchedOrDeletedDto : WarehouseStateEventDtoBase
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



	public class WarehouseStateCreatedDto : WarehouseStateCreatedOrMergePatchedOrDeletedDto
	{
		public WarehouseStateCreatedDto()
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


	public class WarehouseStateMergePatchedDto : WarehouseStateCreatedOrMergePatchedOrDeletedDto
	{
		public WarehouseStateMergePatchedDto()
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


	public class WarehouseStateDeletedDto : WarehouseStateCreatedOrMergePatchedOrDeletedDto
	{
		public WarehouseStateDeletedDto()
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
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class WarehouseStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IWarehouseStateCreated>, IEnumerable<IWarehouseStateMergePatched>, IEnumerable<IWarehouseStateDeleted>
    {
        private List<WarehouseStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<WarehouseStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual WarehouseStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<WarehouseStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IWarehouseStateCreated> IEnumerable<IWarehouseStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IWarehouseStateMergePatched> IEnumerable<IWarehouseStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IWarehouseStateDeleted> IEnumerable<IWarehouseStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddWarehouseEvent(IWarehouseStateCreated e)
        {
            _innerStateEvents.Add((WarehouseStateCreatedDto)e);
        }

        public void AddWarehouseEvent(IWarehouseStateEvent e)
        {
            _innerStateEvents.Add((WarehouseStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddWarehouseEvent(IWarehouseStateDeleted e)
        {
            _innerStateEvents.Add((WarehouseStateDeletedDto)e);
        }

    }


}

