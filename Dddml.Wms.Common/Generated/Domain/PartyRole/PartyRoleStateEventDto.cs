﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePartyRoleDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.PartyRole
{

	public abstract class PartyRoleStateEventDtoBase : IEventDto, IPartyRoleStateCreated, IPartyRoleStateMergePatched, IPartyRoleStateDeleted
	{

        private PartyRoleEventId _partyRoleEventId;

		protected internal virtual PartyRoleEventId PartyRoleEventId 
        {
            get 
            {
                if (_partyRoleEventId == null) { _partyRoleEventId = new PartyRoleEventId(); }
                return _partyRoleEventId;
            }
            set
            {
                _partyRoleEventId = value;
            }
        }

        public virtual PartyRoleId PartyRoleId
        {
            get { return PartyRoleEventId.PartyRoleId; }
            set { PartyRoleEventId.PartyRoleId = value; }
        }

        public virtual long Version
        {
            get { return PartyRoleEventId.Version; }
            set { PartyRoleEventId.Version = value; }
        }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		PartyRoleEventId IGlobalIdentity<PartyRoleEventId>.GlobalId {
			get 
			{
				return this.PartyRoleEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IPartyRoleEvent.ReadOnly
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

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IPartyRoleStateMergePatched.IsPropertyActiveRemoved
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


        PartyRoleEventId IPartyRoleEvent.PartyRoleEventId
        {
            get { return this.PartyRoleEventId; }
        }

        protected PartyRoleStateEventDtoBase()
        {
        }

        protected PartyRoleStateEventDtoBase(PartyRoleEventId stateEventId)
        {
            this.PartyRoleEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class PartyRoleStateCreatedOrMergePatchedOrDeletedDto : PartyRoleStateEventDtoBase
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



	public class PartyRoleStateCreatedDto : PartyRoleStateCreatedOrMergePatchedOrDeletedDto
	{
		public PartyRoleStateCreatedDto()
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


	public class PartyRoleStateMergePatchedDto : PartyRoleStateCreatedOrMergePatchedOrDeletedDto
	{
		public PartyRoleStateMergePatchedDto()
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


	public class PartyRoleStateDeletedDto : PartyRoleStateCreatedOrMergePatchedOrDeletedDto
	{
		public PartyRoleStateDeletedDto()
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


    public partial class PartyRoleStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IPartyRoleStateCreated>, IEnumerable<IPartyRoleStateMergePatched>, IEnumerable<IPartyRoleStateDeleted>
    {
        private List<PartyRoleStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<PartyRoleStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual PartyRoleStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<PartyRoleStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPartyRoleStateCreated> IEnumerable<IPartyRoleStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPartyRoleStateMergePatched> IEnumerable<IPartyRoleStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPartyRoleStateDeleted> IEnumerable<IPartyRoleStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddPartyRoleEvent(IPartyRoleStateCreated e)
        {
            _innerStateEvents.Add((PartyRoleStateCreatedDto)e);
        }

        public void AddPartyRoleEvent(IPartyRoleEvent e)
        {
            _innerStateEvents.Add((PartyRoleStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddPartyRoleEvent(IPartyRoleStateDeleted e)
        {
            _innerStateEvents.Add((PartyRoleStateDeletedDto)e);
        }

    }


}

