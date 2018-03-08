﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationStructureDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructure;

namespace Dddml.Wms.Domain.OrganizationStructure
{

	public abstract class OrganizationStructureStateEventDtoBase : IStateEventDto, IOrganizationStructureStateCreated, IOrganizationStructureStateMergePatched, IOrganizationStructureStateDeleted
	{

        private OrganizationStructureEventIdDto _stateEventId;

		protected internal virtual OrganizationStructureEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new OrganizationStructureEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual OrganizationStructureIdDto Id
        {
            get { return StateEventId.Id; }
            set { StateEventId.Id = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		OrganizationStructureEventId IGlobalIdentity<OrganizationStructureEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToOrganizationStructureEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IOrganizationStructureStateEvent.ReadOnly
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

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IOrganizationStructureStateMergePatched.IsPropertyActiveRemoved
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


        OrganizationStructureEventId IOrganizationStructureStateEvent.StateEventId
        {
            get { return this.StateEventId.ToOrganizationStructureEventId(); }
        }

        protected OrganizationStructureStateEventDtoBase()
        {
        }

        protected OrganizationStructureStateEventDtoBase(OrganizationStructureEventIdDto stateEventId)
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


    public class OrganizationStructureStateCreatedOrMergePatchedOrDeletedDto : OrganizationStructureStateEventDtoBase
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



	public class OrganizationStructureStateCreatedDto : OrganizationStructureStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrganizationStructureStateCreatedDto()
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


	public class OrganizationStructureStateMergePatchedDto : OrganizationStructureStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrganizationStructureStateMergePatchedDto()
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


	public class OrganizationStructureStateDeletedDto : OrganizationStructureStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrganizationStructureStateDeletedDto()
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


    public partial class OrganizationStructureStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IOrganizationStructureStateCreated>, IEnumerable<IOrganizationStructureStateMergePatched>, IEnumerable<IOrganizationStructureStateDeleted>
    {
        private List<OrganizationStructureStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<OrganizationStructureStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual OrganizationStructureStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<OrganizationStructureStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IOrganizationStructureStateCreated> IEnumerable<IOrganizationStructureStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IOrganizationStructureStateMergePatched> IEnumerable<IOrganizationStructureStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IOrganizationStructureStateDeleted> IEnumerable<IOrganizationStructureStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddOrganizationStructureEvent(IOrganizationStructureStateCreated e)
        {
            _innerStateEvents.Add((OrganizationStructureStateCreatedDto)e);
        }

        public void AddOrganizationStructureEvent(IOrganizationStructureStateEvent e)
        {
            _innerStateEvents.Add((OrganizationStructureStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddOrganizationStructureEvent(IOrganizationStructureStateDeleted e)
        {
            _innerStateEvents.Add((OrganizationStructureStateDeletedDto)e);
        }

    }


}

