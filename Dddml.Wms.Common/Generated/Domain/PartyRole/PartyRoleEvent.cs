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

	public abstract class PartyRoleEventBase : IPartyRoleEvent
	{

		public virtual PartyRoleEventId PartyRoleEventId { get; set; }

        public virtual PartyRoleId PartyRoleId
        {
            get { return PartyRoleEventId.PartyRoleId; }
            set { PartyRoleEventId.PartyRoleId = value; }
        }

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

        protected PartyRoleEventBase()
        {
        }

        protected PartyRoleEventBase(PartyRoleEventId stateEventId)
        {
            this.PartyRoleEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class PartyRoleStateEventBase : PartyRoleEventBase, IPartyRoleStateEvent
    {

		public virtual bool? Active { get; set; }

        protected PartyRoleStateEventBase() : base()
        {
        }

        protected PartyRoleStateEventBase(PartyRoleEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class PartyRoleStateCreated : PartyRoleStateEventBase, IPartyRoleStateCreated
	{
		public PartyRoleStateCreated () : this(new PartyRoleEventId())
		{
		}

		public PartyRoleStateCreated (PartyRoleEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class PartyRoleStateMergePatched : PartyRoleStateEventBase, IPartyRoleStateMergePatched
	{
		public virtual bool IsPropertyActiveRemoved { get; set; }


		public PartyRoleStateMergePatched ()
		{
		}

		public PartyRoleStateMergePatched (PartyRoleEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class PartyRoleStateDeleted : PartyRoleStateEventBase, IPartyRoleStateDeleted
	{
		public PartyRoleStateDeleted ()
		{
		}

		public PartyRoleStateDeleted (PartyRoleEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}
