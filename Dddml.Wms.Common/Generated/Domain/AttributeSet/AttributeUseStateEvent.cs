﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeSet
{

	public abstract class AttributeUseStateEventBase : IAttributeUseStateEvent
	{

		public virtual AttributeUseEventId StateEventId { get; set; }

        public virtual string AttributeId
        {
            get { return StateEventId.AttributeId; }
            set { StateEventId.AttributeId = value; }
        }

		public virtual int? SequenceNumber { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeUseEventId IGlobalIdentity<AttributeUseEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeUseStateEvent.ReadOnly
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

        protected AttributeUseStateEventBase()
        {
        }

        protected AttributeUseStateEventBase(AttributeUseEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class AttributeUseStateCreated : AttributeUseStateEventBase, IAttributeUseStateCreated
	{
		public AttributeUseStateCreated () : this(new AttributeUseEventId())
		{
		}

		public AttributeUseStateCreated (AttributeUseEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class AttributeUseStateMergePatched : AttributeUseStateEventBase, IAttributeUseStateMergePatched
	{
		public virtual bool IsPropertySequenceNumberRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public AttributeUseStateMergePatched ()
		{
		}

		public AttributeUseStateMergePatched (AttributeUseEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class AttributeUseStateRemoved : AttributeUseStateEventBase, IAttributeUseStateRemoved
	{
		public AttributeUseStateRemoved ()
		{
		}

		public AttributeUseStateRemoved (AttributeUseEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}

