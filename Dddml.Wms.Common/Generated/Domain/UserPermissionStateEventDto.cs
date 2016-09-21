﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public abstract class UserPermissionStateEventDtoBase : IStateEventDto, IUserPermissionStateCreated, IUserPermissionStateMergePatched, IUserPermissionStateRemoved
	{

		public virtual UserPermissionStateEventIdDto StateEventId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		UserPermissionStateEventId IGlobalIdentity<UserPermissionStateEventId>.GlobalId {
			get {
				return this.StateEventId.ToUserPermissionStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IUserPermissionStateEvent.ReadOnly
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

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IUserPermissionStateMergePatched.IsPropertyActiveRemoved
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


        UserPermissionStateEventId IUserPermissionStateEvent.StateEventId
        {
            get { return this.StateEventId.ToUserPermissionStateEventId(); }
        }

        protected UserPermissionStateEventDtoBase()
        {
        }

        protected UserPermissionStateEventDtoBase(UserPermissionStateEventIdDto stateEventId)
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


    public class UserPermissionStateCreatedOrMergePatchedOrRemovedDto : UserPermissionStateEventDtoBase
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



	public class UserPermissionStateCreatedDto : UserPermissionStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserPermissionStateCreatedDto()
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


	public class UserPermissionStateMergePatchedDto : UserPermissionStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserPermissionStateMergePatchedDto()
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


	public class UserPermissionStateRemovedDto : UserPermissionStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserPermissionStateRemovedDto()
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


    public partial class UserPermissionStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IUserPermissionStateCreated>, IEnumerable<IUserPermissionStateMergePatched>, IEnumerable<IUserPermissionStateRemoved>
    {
        private List<UserPermissionStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<UserPermissionStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual UserPermissionStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<UserPermissionStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserPermissionStateCreated> IEnumerable<IUserPermissionStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserPermissionStateMergePatched> IEnumerable<IUserPermissionStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserPermissionStateRemoved> IEnumerable<IUserPermissionStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddUserPermissionEvent(IUserPermissionStateCreated e)
        {
            _innerStateEvents.Add((UserPermissionStateCreatedDto)e);
        }

        public void AddUserPermissionEvent(IUserPermissionStateEvent e)
        {
            _innerStateEvents.Add((UserPermissionStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddUserPermissionEvent(IUserPermissionStateRemoved e)
        {
            _innerStateEvents.Add((UserPermissionStateRemovedDto)e);
        }

    }


}

