﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageHandlingMethodDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageHandlingMethod;

namespace Dddml.Wms.Domain.DamageHandlingMethod
{

	public abstract class DamageHandlingMethodStateEventDtoBase : IStateEventDto, IDamageHandlingMethodStateCreated, IDamageHandlingMethodStateMergePatched, IDamageHandlingMethodStateDeleted
	{

        private DamageHandlingMethodStateEventIdDto _stateEventId;

		protected internal virtual DamageHandlingMethodStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new DamageHandlingMethodStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string DamageHandlingMethodId
        {
            get { return StateEventId.DamageHandlingMethodId; }
            set { StateEventId.DamageHandlingMethodId = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		public virtual string Description { get; set; }

		public virtual string SequenceId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		DamageHandlingMethodStateEventId IGlobalIdentity<DamageHandlingMethodStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToDamageHandlingMethodStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IDamageHandlingMethodStateEvent.ReadOnly
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

        bool IDamageHandlingMethodStateMergePatched.IsPropertyDescriptionRemoved
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

        bool IDamageHandlingMethodStateMergePatched.IsPropertySequenceIdRemoved
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

        bool IDamageHandlingMethodStateMergePatched.IsPropertyActiveRemoved
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


        DamageHandlingMethodStateEventId IDamageHandlingMethodStateEvent.StateEventId
        {
            get { return this.StateEventId.ToDamageHandlingMethodStateEventId(); }
        }

        protected DamageHandlingMethodStateEventDtoBase()
        {
        }

        protected DamageHandlingMethodStateEventDtoBase(DamageHandlingMethodStateEventIdDto stateEventId)
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


    public class DamageHandlingMethodStateCreatedOrMergePatchedOrDeletedDto : DamageHandlingMethodStateEventDtoBase
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



	public class DamageHandlingMethodStateCreatedDto : DamageHandlingMethodStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageHandlingMethodStateCreatedDto()
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


	public class DamageHandlingMethodStateMergePatchedDto : DamageHandlingMethodStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageHandlingMethodStateMergePatchedDto()
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


	public class DamageHandlingMethodStateDeletedDto : DamageHandlingMethodStateCreatedOrMergePatchedOrDeletedDto
	{
		public DamageHandlingMethodStateDeletedDto()
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


    public partial class DamageHandlingMethodStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IDamageHandlingMethodStateCreated>, IEnumerable<IDamageHandlingMethodStateMergePatched>, IEnumerable<IDamageHandlingMethodStateDeleted>
    {
        private List<DamageHandlingMethodStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<DamageHandlingMethodStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual DamageHandlingMethodStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<DamageHandlingMethodStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDamageHandlingMethodStateCreated> IEnumerable<IDamageHandlingMethodStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDamageHandlingMethodStateMergePatched> IEnumerable<IDamageHandlingMethodStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDamageHandlingMethodStateDeleted> IEnumerable<IDamageHandlingMethodStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddDamageHandlingMethodEvent(IDamageHandlingMethodStateCreated e)
        {
            _innerStateEvents.Add((DamageHandlingMethodStateCreatedDto)e);
        }

        public void AddDamageHandlingMethodEvent(IDamageHandlingMethodStateEvent e)
        {
            _innerStateEvents.Add((DamageHandlingMethodStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddDamageHandlingMethodEvent(IDamageHandlingMethodStateDeleted e)
        {
            _innerStateEvents.Add((DamageHandlingMethodStateDeletedDto)e);
        }

    }


}
