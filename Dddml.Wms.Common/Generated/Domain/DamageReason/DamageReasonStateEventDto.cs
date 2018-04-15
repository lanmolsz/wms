﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageReasonDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageReason;

namespace Dddml.Wms.Domain.DamageReason
{

	public abstract class DamageReasonStateEventDtoBase : IStateEventDto, IDamageReasonStateCreated, IDamageReasonStateMergePatched, IDamageReasonStateDeleted
	{

        private DamageReasonEventId _damageReasonEventId;

		protected internal virtual DamageReasonEventId DamageReasonEventId 
        {
            get 
            {
                if (_damageReasonEventId == null) { _damageReasonEventId = new DamageReasonEventId(); }
                return _damageReasonEventId;
            }
            set
            {
                _damageReasonEventId = value;
            }
        }

        public virtual string DamageReasonId
        {
            get { return DamageReasonEventId.DamageReasonId; }
            set { DamageReasonEventId.DamageReasonId = value; }
        }

        public virtual long Version
        {
            get { return DamageReasonEventId.Version; }
            set { DamageReasonEventId.Version = value; }
        }

		public virtual string Description { get; set; }

		public virtual string SequenceId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		DamageReasonEventId IGlobalIdentity<DamageReasonEventId>.GlobalId {
			get 
			{
				return this.DamageReasonEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IDamageReasonStateEvent.ReadOnly
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

        bool IDamageReasonStateMergePatched.IsPropertyDescriptionRemoved
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

        bool IDamageReasonStateMergePatched.IsPropertySequenceIdRemoved
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

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IDamageReasonStateMergePatched.IsPropertyActiveRemoved
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


        DamageReasonEventId IDamageReasonStateEvent.DamageReasonEventId
        {
            get { return this.DamageReasonEventId; }
        }

        protected DamageReasonStateEventDtoBase()
        {
        }

        protected DamageReasonStateEventDtoBase(DamageReasonEventId stateEventId)
        {
            this.DamageReasonEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class DamageReasonStateCreatedOrMergePatchedOrDeletedDto : DamageReasonStateEventDtoBase
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



	public class DamageReasonStateCreatedDto : DamageReasonStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageReasonStateCreatedDto()
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


	public class DamageReasonStateMergePatchedDto : DamageReasonStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageReasonStateMergePatchedDto()
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


	public class DamageReasonStateDeletedDto : DamageReasonStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageReasonStateDeletedDto()
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


    public partial class DamageReasonStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IDamageReasonStateCreated>, IEnumerable<IDamageReasonStateMergePatched>, IEnumerable<IDamageReasonStateDeleted>
    {
        private List<DamageReasonStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<DamageReasonStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual DamageReasonStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<DamageReasonStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDamageReasonStateCreated> IEnumerable<IDamageReasonStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDamageReasonStateMergePatched> IEnumerable<IDamageReasonStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDamageReasonStateDeleted> IEnumerable<IDamageReasonStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddDamageReasonEvent(IDamageReasonStateCreated e)
        {
            _innerStateEvents.Add((DamageReasonStateCreatedDto)e);
        }

        public void AddDamageReasonEvent(IDamageReasonStateEvent e)
        {
            _innerStateEvents.Add((DamageReasonStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddDamageReasonEvent(IDamageReasonStateDeleted e)
        {
            _innerStateEvents.Add((DamageReasonStateDeletedDto)e);
        }

    }


}

