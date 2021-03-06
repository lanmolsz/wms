﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageType;

namespace Dddml.Wms.Domain.DamageType
{

	public abstract class DamageTypeStateEventDtoBase : IEventDto, IDamageTypeStateCreated, IDamageTypeStateMergePatched, IDamageTypeStateDeleted
	{

        private DamageTypeEventId _damageTypeEventId;

		protected internal virtual DamageTypeEventId DamageTypeEventId 
        {
            get 
            {
                if (_damageTypeEventId == null) { _damageTypeEventId = new DamageTypeEventId(); }
                return _damageTypeEventId;
            }
            set
            {
                _damageTypeEventId = value;
            }
        }

        public virtual string DamageTypeId
        {
            get { return DamageTypeEventId.DamageTypeId; }
            set { DamageTypeEventId.DamageTypeId = value; }
        }

        public virtual long Version
        {
            get { return DamageTypeEventId.Version; }
            set { DamageTypeEventId.Version = value; }
        }

		public virtual string Description { get; set; }

		public virtual string SequenceId { get; set; }

		public virtual string DefaultHandlingMethodId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		DamageTypeEventId IGlobalIdentity<DamageTypeEventId>.GlobalId {
			get 
			{
				return this.DamageTypeEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IDamageTypeEvent.ReadOnly
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

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IDamageTypeStateMergePatched.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertySequenceIdRemoved { get; set; }

        bool IDamageTypeStateMergePatched.IsPropertySequenceIdRemoved
        {
            get 
            {
                var b = this.IsPropertySequenceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySequenceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDefaultHandlingMethodIdRemoved { get; set; }

        bool IDamageTypeStateMergePatched.IsPropertyDefaultHandlingMethodIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDefaultHandlingMethodIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDefaultHandlingMethodIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IDamageTypeStateMergePatched.IsPropertyActiveRemoved
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


        DamageTypeEventId IDamageTypeEvent.DamageTypeEventId
        {
            get { return this.DamageTypeEventId; }
        }

        protected DamageTypeStateEventDtoBase()
        {
        }

        protected DamageTypeStateEventDtoBase(DamageTypeEventId stateEventId)
        {
            this.DamageTypeEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class DamageTypeStateCreatedOrMergePatchedOrDeletedDto : DamageTypeStateEventDtoBase
    {
        private string _eventType;

        public virtual string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        protected override string GetEventType()
        {
            return this._eventType;
        }

    }



	public class DamageTypeStateCreatedDto : DamageTypeStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageTypeStateCreatedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class DamageTypeStateMergePatchedDto : DamageTypeStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageTypeStateMergePatchedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class DamageTypeStateDeletedDto : DamageTypeStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageTypeStateDeletedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class DamageTypeStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IDamageTypeStateCreated>, IEnumerable<IDamageTypeStateMergePatched>, IEnumerable<IDamageTypeStateDeleted>
    {
        private List<DamageTypeStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<DamageTypeStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual DamageTypeStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<DamageTypeStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDamageTypeStateCreated> IEnumerable<IDamageTypeStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDamageTypeStateMergePatched> IEnumerable<IDamageTypeStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDamageTypeStateDeleted> IEnumerable<IDamageTypeStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddDamageTypeEvent(IDamageTypeStateCreated e)
        {
            _innerStateEvents.Add((DamageTypeStateCreatedDto)e);
        }

        public void AddDamageTypeEvent(IDamageTypeEvent e)
        {
            _innerStateEvents.Add((DamageTypeStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddDamageTypeEvent(IDamageTypeStateDeleted e)
        {
            _innerStateEvents.Add((DamageTypeStateDeletedDto)e);
        }

    }


}

