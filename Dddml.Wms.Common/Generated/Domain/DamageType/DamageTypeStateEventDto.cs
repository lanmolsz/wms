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

	public abstract class DamageTypeStateEventDtoBase : IStateEventDto, IDamageTypeStateCreated, IDamageTypeStateMergePatched, IDamageTypeStateDeleted
	{

        private DamageTypeEventIdDto _stateEventId;

		protected internal virtual DamageTypeEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new DamageTypeEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string DamageTypeId
        {
            get { return StateEventId.DamageTypeId; }
            set { StateEventId.DamageTypeId = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
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
				return this.StateEventId.ToDamageTypeEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IDamageTypeStateEvent.ReadOnly
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


        DamageTypeEventId IDamageTypeStateEvent.StateEventId
        {
            get { return this.StateEventId.ToDamageTypeEventId(); }
        }

        protected DamageTypeStateEventDtoBase()
        {
        }

        protected DamageTypeStateEventDtoBase(DamageTypeEventIdDto stateEventId)
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


    public class DamageTypeStateCreatedOrMergePatchedOrDeletedDto : DamageTypeStateEventDtoBase
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



	public class DamageTypeStateCreatedDto : DamageTypeStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageTypeStateCreatedDto()
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


	public class DamageTypeStateMergePatchedDto : DamageTypeStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageTypeStateMergePatchedDto()
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


	public class DamageTypeStateDeletedDto : DamageTypeStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageTypeStateDeletedDto()
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

        public void AddDamageTypeEvent(IDamageTypeStateEvent e)
        {
            _innerStateEvents.Add((DamageTypeStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddDamageTypeEvent(IDamageTypeStateDeleted e)
        {
            _innerStateEvents.Add((DamageTypeStateDeletedDto)e);
        }

    }


}

