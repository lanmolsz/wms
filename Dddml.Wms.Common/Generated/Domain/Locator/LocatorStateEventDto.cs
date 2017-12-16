﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLocatorDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Locator;

namespace Dddml.Wms.Domain.Locator
{

	public abstract class LocatorStateEventDtoBase : IStateEventDto, ILocatorStateCreated, ILocatorStateMergePatched, ILocatorStateDeleted
	{

        private LocatorStateEventIdDto _stateEventId;

		protected internal virtual LocatorStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new LocatorStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string LocatorId
        {
            get { return StateEventId.LocatorId; }
            set { StateEventId.LocatorId = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		public virtual string WarehouseId { get; set; }

		public virtual string ParentLocatorId { get; set; }

		public virtual string LocatorType { get; set; }

		public virtual string PriorityNumber { get; set; }

		public virtual bool? IsDefault { get; set; }

		public virtual string X { get; set; }

		public virtual string Y { get; set; }

		public virtual string Z { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		LocatorStateEventId IGlobalIdentity<LocatorStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToLocatorStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool ILocatorStateEvent.ReadOnly
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

		public virtual bool? IsPropertyWarehouseIdRemoved { get; set; }

        bool ILocatorStateMergePatched.IsPropertyWarehouseIdRemoved
        {
            get 
            {
                var b = this.IsPropertyWarehouseIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyWarehouseIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyParentLocatorIdRemoved { get; set; }

        bool ILocatorStateMergePatched.IsPropertyParentLocatorIdRemoved
        {
            get 
            {
                var b = this.IsPropertyParentLocatorIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyParentLocatorIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyLocatorTypeRemoved { get; set; }

        bool ILocatorStateMergePatched.IsPropertyLocatorTypeRemoved
        {
            get 
            {
                var b = this.IsPropertyLocatorTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLocatorTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyPriorityNumberRemoved { get; set; }

        bool ILocatorStateMergePatched.IsPropertyPriorityNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyPriorityNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPriorityNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsDefaultRemoved { get; set; }

        bool ILocatorStateMergePatched.IsPropertyIsDefaultRemoved
        {
            get 
            {
                var b = this.IsPropertyIsDefaultRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsDefaultRemoved = value;
            }
        }

		public virtual bool? IsPropertyXRemoved { get; set; }

        bool ILocatorStateMergePatched.IsPropertyXRemoved
        {
            get 
            {
                var b = this.IsPropertyXRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyXRemoved = value;
            }
        }

		public virtual bool? IsPropertyYRemoved { get; set; }

        bool ILocatorStateMergePatched.IsPropertyYRemoved
        {
            get 
            {
                var b = this.IsPropertyYRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyYRemoved = value;
            }
        }

		public virtual bool? IsPropertyZRemoved { get; set; }

        bool ILocatorStateMergePatched.IsPropertyZRemoved
        {
            get 
            {
                var b = this.IsPropertyZRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyZRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool ILocatorStateMergePatched.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool ILocatorStateMergePatched.IsPropertyActiveRemoved
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


        LocatorStateEventId ILocatorStateEvent.StateEventId
        {
            get { return this.StateEventId.ToLocatorStateEventId(); }
        }

        protected LocatorStateEventDtoBase()
        {
        }

        protected LocatorStateEventDtoBase(LocatorStateEventIdDto stateEventId)
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


    public class LocatorStateCreatedOrMergePatchedOrDeletedDto : LocatorStateEventDtoBase
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



	public class LocatorStateCreatedDto : LocatorStateCreatedOrMergePatchedOrDeletedDto
	{
		public LocatorStateCreatedDto()
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


	public class LocatorStateMergePatchedDto : LocatorStateCreatedOrMergePatchedOrDeletedDto
	{
		public LocatorStateMergePatchedDto()
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


	public class LocatorStateDeletedDto : LocatorStateCreatedOrMergePatchedOrDeletedDto
	{
		public LocatorStateDeletedDto()
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


    public partial class LocatorStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<ILocatorStateCreated>, IEnumerable<ILocatorStateMergePatched>, IEnumerable<ILocatorStateDeleted>
    {
        private List<LocatorStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<LocatorStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual LocatorStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<LocatorStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<ILocatorStateCreated> IEnumerable<ILocatorStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<ILocatorStateMergePatched> IEnumerable<ILocatorStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<ILocatorStateDeleted> IEnumerable<ILocatorStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddLocatorEvent(ILocatorStateCreated e)
        {
            _innerStateEvents.Add((LocatorStateCreatedDto)e);
        }

        public void AddLocatorEvent(ILocatorStateEvent e)
        {
            _innerStateEvents.Add((LocatorStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddLocatorEvent(ILocatorStateDeleted e)
        {
            _innerStateEvents.Add((LocatorStateDeletedDto)e);
        }

    }


}

