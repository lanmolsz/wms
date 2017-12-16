﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Organization;

namespace Dddml.Wms.Domain.Organization
{

	public abstract class OrganizationStateEventDtoBase : IStateEventDto, IOrganizationStateCreated, IOrganizationStateMergePatched, IOrganizationStateDeleted
	{

        private OrganizationStateEventIdDto _stateEventId;

		protected internal virtual OrganizationStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new OrganizationStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string OrganizationId
        {
            get { return StateEventId.OrganizationId; }
            set { StateEventId.OrganizationId = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		public virtual string OrganizationName { get; set; }

		public virtual string Description { get; set; }

		public virtual string Type { get; set; }

		public virtual bool? IsSummary { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		OrganizationStateEventId IGlobalIdentity<OrganizationStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToOrganizationStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IOrganizationStateEvent.ReadOnly
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

		public virtual bool? IsPropertyOrganizationNameRemoved { get; set; }

        bool IOrganizationStateMergePatched.IsPropertyOrganizationNameRemoved
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

        bool IOrganizationStateMergePatched.IsPropertyDescriptionRemoved
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

        bool IOrganizationStateMergePatched.IsPropertyTypeRemoved
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

        bool IOrganizationStateMergePatched.IsPropertyIsSummaryRemoved
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

        bool IOrganizationStateMergePatched.IsPropertyActiveRemoved
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


        OrganizationStateEventId IOrganizationStateEvent.StateEventId
        {
            get { return this.StateEventId.ToOrganizationStateEventId(); }
        }

        protected OrganizationStateEventDtoBase()
        {
        }

        protected OrganizationStateEventDtoBase(OrganizationStateEventIdDto stateEventId)
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


    public class OrganizationStateCreatedOrMergePatchedOrDeletedDto : OrganizationStateEventDtoBase
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



	public class OrganizationStateCreatedDto : OrganizationStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrganizationStateCreatedDto()
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


	public class OrganizationStateMergePatchedDto : OrganizationStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrganizationStateMergePatchedDto()
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


	public class OrganizationStateDeletedDto : OrganizationStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrganizationStateDeletedDto()
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


    public partial class OrganizationStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IOrganizationStateCreated>, IEnumerable<IOrganizationStateMergePatched>, IEnumerable<IOrganizationStateDeleted>
    {
        private List<OrganizationStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<OrganizationStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual OrganizationStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<OrganizationStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IOrganizationStateCreated> IEnumerable<IOrganizationStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IOrganizationStateMergePatched> IEnumerable<IOrganizationStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IOrganizationStateDeleted> IEnumerable<IOrganizationStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddOrganizationEvent(IOrganizationStateCreated e)
        {
            _innerStateEvents.Add((OrganizationStateCreatedDto)e);
        }

        public void AddOrganizationEvent(IOrganizationStateEvent e)
        {
            _innerStateEvents.Add((OrganizationStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddOrganizationEvent(IOrganizationStateDeleted e)
        {
            _innerStateEvents.Add((OrganizationStateDeletedDto)e);
        }

    }


}

