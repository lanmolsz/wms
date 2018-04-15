﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Role;

namespace Dddml.Wms.Domain.Role
{

	public abstract class RoleStateEventDtoBase : IStateEventDto, IRoleStateCreated, IRoleStateMergePatched, IRoleStateDeleted
	{

        private RoleEventId _roleEventId;

		protected internal virtual RoleEventId RoleEventId 
        {
            get 
            {
                if (_roleEventId == null) { _roleEventId = new RoleEventId(); }
                return _roleEventId;
            }
            set
            {
                _roleEventId = value;
            }
        }

        public virtual string RoleId
        {
            get { return RoleEventId.RoleId; }
            set { RoleEventId.RoleId = value; }
        }

        public virtual long Version
        {
            get { return RoleEventId.Version; }
            set { RoleEventId.Version = value; }
        }

		public virtual string Name { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		RoleEventId IGlobalIdentity<RoleEventId>.GlobalId {
			get 
			{
				return this.RoleEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IRoleStateEvent.ReadOnly
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

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IRoleStateMergePatched.IsPropertyNameRemoved
        {
            get 
            {
                var b = this.IsPropertyNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IRoleStateMergePatched.IsPropertyDescriptionRemoved
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

        bool IRoleStateMergePatched.IsPropertyActiveRemoved
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


        RoleEventId IRoleStateEvent.RoleEventId
        {
            get { return this.RoleEventId; }
        }

        protected RoleStateEventDtoBase()
        {
        }

        protected RoleStateEventDtoBase(RoleEventId stateEventId)
        {
            this.RoleEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class RoleStateCreatedOrMergePatchedOrDeletedDto : RoleStateEventDtoBase
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



	public class RoleStateCreatedDto : RoleStateCreatedOrMergePatchedOrDeletedDto
	{
		public RoleStateCreatedDto()
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


	public class RoleStateMergePatchedDto : RoleStateCreatedOrMergePatchedOrDeletedDto
	{
		public RoleStateMergePatchedDto()
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


	public class RoleStateDeletedDto : RoleStateCreatedOrMergePatchedOrDeletedDto
	{
		public RoleStateDeletedDto()
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


    public partial class RoleStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IRoleStateCreated>, IEnumerable<IRoleStateMergePatched>, IEnumerable<IRoleStateDeleted>
    {
        private List<RoleStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<RoleStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual RoleStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<RoleStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IRoleStateCreated> IEnumerable<IRoleStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IRoleStateMergePatched> IEnumerable<IRoleStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IRoleStateDeleted> IEnumerable<IRoleStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddRoleEvent(IRoleStateCreated e)
        {
            _innerStateEvents.Add((RoleStateCreatedDto)e);
        }

        public void AddRoleEvent(IRoleStateEvent e)
        {
            _innerStateEvents.Add((RoleStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddRoleEvent(IRoleStateDeleted e)
        {
            _innerStateEvents.Add((RoleStateDeletedDto)e);
        }

    }


}

