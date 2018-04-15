﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePartyDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Party;

namespace Dddml.Wms.Domain.Party
{

	public abstract class PartyStateEventDtoBase : IStateEventDto, IPartyStateCreated, IPartyStateMergePatched, IPartyStateDeleted
	{

        private PartyEventId _partyEventId;

		protected internal virtual PartyEventId PartyEventId 
        {
            get 
            {
                if (_partyEventId == null) { _partyEventId = new PartyEventId(); }
                return _partyEventId;
            }
            set
            {
                _partyEventId = value;
            }
        }

        public virtual string PartyId
        {
            get { return PartyEventId.PartyId; }
            set { PartyEventId.PartyId = value; }
        }

        public virtual long Version
        {
            get { return PartyEventId.Version; }
            set { PartyEventId.Version = value; }
        }

		public virtual string PartyTypeId { get; set; }

		public virtual string PrimaryRoleTypeId { get; set; }

		public virtual string OrganizationName { get; set; }

		public virtual string Description { get; set; }

		public virtual string Type { get; set; }

		public virtual bool? IsSummary { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		PartyEventId IGlobalIdentity<PartyEventId>.GlobalId {
			get 
			{
				return this.PartyEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IPartyStateEvent.ReadOnly
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

		public virtual bool? IsPropertyPartyTypeIdRemoved { get; set; }

        bool IPartyStateMergePatched.IsPropertyPartyTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPartyTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPartyTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPrimaryRoleTypeIdRemoved { get; set; }

        bool IPartyStateMergePatched.IsPropertyPrimaryRoleTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPrimaryRoleTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPrimaryRoleTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrganizationNameRemoved { get; set; }

        bool IPartyStateMergePatched.IsPropertyOrganizationNameRemoved
        {
            get 
            {
                var b = this.IsPropertyOrganizationNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOrganizationNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IPartyStateMergePatched.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyTypeRemoved { get; set; }

        bool IPartyStateMergePatched.IsPropertyTypeRemoved
        {
            get 
            {
                var b = this.IsPropertyTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsSummaryRemoved { get; set; }

        bool IPartyStateMergePatched.IsPropertyIsSummaryRemoved
        {
            get 
            {
                var b = this.IsPropertyIsSummaryRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsSummaryRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IPartyStateMergePatched.IsPropertyActiveRemoved
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


        PartyEventId IPartyStateEvent.PartyEventId
        {
            get { return this.PartyEventId; }
        }

        protected PartyStateEventDtoBase()
        {
        }

        protected PartyStateEventDtoBase(PartyEventId stateEventId)
        {
            this.PartyEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class PartyStateCreatedOrMergePatchedOrDeletedDto : PartyStateEventDtoBase
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



	public class PartyStateCreatedDto : PartyStateCreatedOrMergePatchedOrDeletedDto
	{
		public PartyStateCreatedDto()
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


	public class PartyStateMergePatchedDto : PartyStateCreatedOrMergePatchedOrDeletedDto
	{
		public PartyStateMergePatchedDto()
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


	public class PartyStateDeletedDto : PartyStateCreatedOrMergePatchedOrDeletedDto
	{
		public PartyStateDeletedDto()
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


    public partial class PartyStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IPartyStateCreated>, IEnumerable<IPartyStateMergePatched>, IEnumerable<IPartyStateDeleted>
    {
        private List<PartyStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<PartyStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual PartyStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<PartyStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPartyStateCreated> IEnumerable<IPartyStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPartyStateMergePatched> IEnumerable<IPartyStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPartyStateDeleted> IEnumerable<IPartyStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddPartyEvent(IPartyStateCreated e)
        {
            _innerStateEvents.Add((PartyStateCreatedDto)e);
        }

        public void AddPartyEvent(IPartyStateEvent e)
        {
            _innerStateEvents.Add((PartyStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddPartyEvent(IPartyStateDeleted e)
        {
            _innerStateEvents.Add((PartyStateDeletedDto)e);
        }

    }


}

