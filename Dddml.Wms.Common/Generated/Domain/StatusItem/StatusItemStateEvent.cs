﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateStatusItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.StatusItem;

namespace Dddml.Wms.Domain.StatusItem
{

	public abstract class StatusItemStateEventBase : IStatusItemStateEvent
	{

		public virtual StatusItemEventId StateEventId { get; set; }

        public virtual string StatusId
        {
            get { return StateEventId.StatusId; }
            set { StateEventId.StatusId = value; }
        }

		public virtual string StatusTypeId { get; set; }

		public virtual string StatusCode { get; set; }

		public virtual string SequenceId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		StatusItemEventId IGlobalIdentity<StatusItemEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IStatusItemStateEvent.ReadOnly
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

        protected StatusItemStateEventBase()
        {
        }

        protected StatusItemStateEventBase(StatusItemEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class StatusItemStateCreated : StatusItemStateEventBase, IStatusItemStateCreated
	{
		public StatusItemStateCreated () : this(new StatusItemEventId())
		{
		}

		public StatusItemStateCreated (StatusItemEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class StatusItemStateMergePatched : StatusItemStateEventBase, IStatusItemStateMergePatched
	{
		public virtual bool IsPropertyStatusTypeIdRemoved { get; set; }

		public virtual bool IsPropertyStatusCodeRemoved { get; set; }

		public virtual bool IsPropertySequenceIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public StatusItemStateMergePatched ()
		{
		}

		public StatusItemStateMergePatched (StatusItemEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}

