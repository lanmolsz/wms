﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageHandlingMethodDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageHandlingMethod;

namespace Dddml.Wms.Domain.DamageHandlingMethod
{

	public abstract class DamageHandlingMethodStateEventBase : IDamageHandlingMethodStateEvent
	{

		public virtual DamageHandlingMethodStateEventId StateEventId { get; set; }

        public virtual string DamageHandlingMethodId
        {
            get { return StateEventId.DamageHandlingMethodId; }
            set { StateEventId.DamageHandlingMethodId = value; }
        }

		public virtual string Description { get; set; }

		public virtual string SequenceId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		DamageHandlingMethodStateEventId IGlobalIdentity<DamageHandlingMethodStateEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IDamageHandlingMethodStateEvent.ReadOnly
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

        protected DamageHandlingMethodStateEventBase()
        {
        }

        protected DamageHandlingMethodStateEventBase(DamageHandlingMethodStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class DamageHandlingMethodStateCreated : DamageHandlingMethodStateEventBase, IDamageHandlingMethodStateCreated
	{
		public DamageHandlingMethodStateCreated () : this(new DamageHandlingMethodStateEventId())
		{
		}

		public DamageHandlingMethodStateCreated (DamageHandlingMethodStateEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class DamageHandlingMethodStateMergePatched : DamageHandlingMethodStateEventBase, IDamageHandlingMethodStateMergePatched
	{
		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertySequenceIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public DamageHandlingMethodStateMergePatched ()
		{
		}

		public DamageHandlingMethodStateMergePatched (DamageHandlingMethodStateEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class DamageHandlingMethodStateDeleted : DamageHandlingMethodStateEventBase, IDamageHandlingMethodStateDeleted
	{
		public DamageHandlingMethodStateDeleted ()
		{
		}

		public DamageHandlingMethodStateDeleted (DamageHandlingMethodStateEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

