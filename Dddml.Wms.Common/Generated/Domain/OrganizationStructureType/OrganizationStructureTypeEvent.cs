﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationStructureTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructureType;

namespace Dddml.Wms.Domain.OrganizationStructureType
{

	public abstract class OrganizationStructureTypeEventBase : IOrganizationStructureTypeEvent
	{

		public virtual OrganizationStructureTypeEventId OrganizationStructureTypeEventId { get; set; }

        public virtual string Id
        {
            get { return OrganizationStructureTypeEventId.Id; }
            set { OrganizationStructureTypeEventId.Id = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		OrganizationStructureTypeEventId IGlobalIdentity<OrganizationStructureTypeEventId>.GlobalId {
			get
			{
				return this.OrganizationStructureTypeEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IOrganizationStructureTypeEvent.ReadOnly
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

        protected OrganizationStructureTypeEventBase()
        {
        }

        protected OrganizationStructureTypeEventBase(OrganizationStructureTypeEventId stateEventId)
        {
            this.OrganizationStructureTypeEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class OrganizationStructureTypeStateEventBase : OrganizationStructureTypeEventBase, IOrganizationStructureTypeStateEvent
    {

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

        protected OrganizationStructureTypeStateEventBase() : base()
        {
        }

        protected OrganizationStructureTypeStateEventBase(OrganizationStructureTypeEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class OrganizationStructureTypeStateCreated : OrganizationStructureTypeStateEventBase, IOrganizationStructureTypeStateCreated
	{
		public OrganizationStructureTypeStateCreated () : this(new OrganizationStructureTypeEventId())
		{
		}

		public OrganizationStructureTypeStateCreated (OrganizationStructureTypeEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class OrganizationStructureTypeStateMergePatched : OrganizationStructureTypeStateEventBase, IOrganizationStructureTypeStateMergePatched
	{
		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public OrganizationStructureTypeStateMergePatched ()
		{
		}

		public OrganizationStructureTypeStateMergePatched (OrganizationStructureTypeEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class OrganizationStructureTypeStateDeleted : OrganizationStructureTypeStateEventBase, IOrganizationStructureTypeStateDeleted
	{
		public OrganizationStructureTypeStateDeleted ()
		{
		}

		public OrganizationStructureTypeStateDeleted (OrganizationStructureTypeEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}
