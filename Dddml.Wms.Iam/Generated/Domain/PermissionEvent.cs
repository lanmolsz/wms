﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Permission;

namespace Dddml.Wms.Domain.Permission
{

	public abstract class PermissionEventBase : IPermissionEvent
	{

		public virtual PermissionEventId PermissionEventId { get; set; }

        public virtual string PermissionId
        {
            get { return PermissionEventId.PermissionId; }
            set { PermissionEventId.PermissionId = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		PermissionEventId IGlobalIdentity<PermissionEventId>.GlobalId {
			get
			{
				return this.PermissionEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IPermissionEvent.ReadOnly
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

        protected PermissionEventBase()
        {
        }

        protected PermissionEventBase(PermissionEventId stateEventId)
        {
            this.PermissionEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class PermissionStateEventBase : PermissionEventBase, IPermissionStateEvent
    {

		public virtual string Name { get; set; }

		public virtual string ParentPermissionId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

        protected PermissionStateEventBase() : base()
        {
        }

        protected PermissionStateEventBase(PermissionEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class PermissionStateCreated : PermissionStateEventBase, IPermissionStateCreated
	{
		public PermissionStateCreated () : this(new PermissionEventId())
		{
		}

		public PermissionStateCreated (PermissionEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class PermissionStateMergePatched : PermissionStateEventBase, IPermissionStateMergePatched
	{
		public virtual bool IsPropertyNameRemoved { get; set; }

		public virtual bool IsPropertyParentPermissionIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public PermissionStateMergePatched ()
		{
		}

		public PermissionStateMergePatched (PermissionEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class PermissionStateDeleted : PermissionStateEventBase, IPermissionStateDeleted
	{
		public PermissionStateDeleted ()
		{
		}

		public PermissionStateDeleted (PermissionEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

