﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeUseMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeUseMvo;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeUseMvo
{

	public abstract class AttributeUseMvoStateEventBase : IAttributeUseMvoStateEvent
	{

		public virtual AttributeUseMvoEventId StateEventId { get; set; }

        public virtual AttributeSetAttributeUseId AttributeSetAttributeUseId
        {
            get { return StateEventId.AttributeSetAttributeUseId; }
            set { StateEventId.AttributeSetAttributeUseId = value; }
        }

		public virtual int? SequenceNumber { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string AttributeSetAttributeSetName { get; set; }

		public virtual string AttributeSetOrganizationId { get; set; }

		public virtual string AttributeSetDescription { get; set; }

		public virtual string AttributeSetReferenceId { get; set; }

		public virtual bool? AttributeSetIsInstanceAttributeSet { get; set; }

		public virtual bool? AttributeSetIsMandatory { get; set; }

		public virtual string AttributeSetCreatedBy { get; set; }

		public virtual DateTime? AttributeSetCreatedAt { get; set; }

		public virtual string AttributeSetUpdatedBy { get; set; }

		public virtual DateTime? AttributeSetUpdatedAt { get; set; }

		public virtual bool? AttributeSetActive { get; set; }

		public virtual bool? AttributeSetDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeUseMvoEventId IGlobalIdentity<AttributeUseMvoEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeUseMvoStateEvent.ReadOnly
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

        protected AttributeUseMvoStateEventBase()
        {
        }

        protected AttributeUseMvoStateEventBase(AttributeUseMvoEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class AttributeUseMvoStateCreated : AttributeUseMvoStateEventBase, IAttributeUseMvoStateCreated
	{
		public AttributeUseMvoStateCreated () : this(new AttributeUseMvoEventId())
		{
		}

		public AttributeUseMvoStateCreated (AttributeUseMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class AttributeUseMvoStateMergePatched : AttributeUseMvoStateEventBase, IAttributeUseMvoStateMergePatched
	{
		public virtual bool IsPropertySequenceNumberRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetAttributeSetNameRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetOrganizationIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetDescriptionRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetReferenceIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetIsInstanceAttributeSetRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetIsMandatoryRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetCreatedByRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetActiveRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetDeletedRemoved { get; set; }


		public AttributeUseMvoStateMergePatched ()
		{
		}

		public AttributeUseMvoStateMergePatched (AttributeUseMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class AttributeUseMvoStateDeleted : AttributeUseMvoStateEventBase, IAttributeUseMvoStateDeleted
	{
		public AttributeUseMvoStateDeleted ()
		{
		}

		public AttributeUseMvoStateDeleted (AttributeUseMvoEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

