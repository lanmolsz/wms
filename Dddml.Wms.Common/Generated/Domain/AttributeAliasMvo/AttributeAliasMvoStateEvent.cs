﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeAliasMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeAliasMvo;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.AttributeAliasMvo
{

	public abstract class AttributeAliasMvoStateEventBase : IAttributeAliasMvoStateEvent
	{

		public virtual AttributeAliasMvoEventId AttributeAliasMvoEventId { get; set; }

        public virtual AttributeAliasId AttributeAliasId
        {
            get { return AttributeAliasMvoEventId.AttributeAliasId; }
            set { AttributeAliasMvoEventId.AttributeAliasId = value; }
        }

		public virtual string Name { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string AttributeAttributeName { get; set; }

		public virtual string AttributeOrganizationId { get; set; }

		public virtual string AttributeDescription { get; set; }

		public virtual bool? AttributeIsMandatory { get; set; }

		public virtual string AttributeAttributeValueType { get; set; }

		public virtual int? AttributeAttributeValueLength { get; set; }

		public virtual bool? AttributeIsList { get; set; }

		public virtual string AttributeFieldName { get; set; }

		public virtual string AttributeReferenceId { get; set; }

		public virtual string AttributeCreatedBy { get; set; }

		public virtual DateTime? AttributeCreatedAt { get; set; }

		public virtual string AttributeUpdatedBy { get; set; }

		public virtual DateTime? AttributeUpdatedAt { get; set; }

		public virtual bool? AttributeActive { get; set; }

		public virtual bool? AttributeDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeAliasMvoEventId IGlobalIdentity<AttributeAliasMvoEventId>.GlobalId {
			get
			{
				return this.AttributeAliasMvoEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IAttributeAliasMvoStateEvent.ReadOnly
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

        protected AttributeAliasMvoStateEventBase()
        {
        }

        protected AttributeAliasMvoStateEventBase(AttributeAliasMvoEventId stateEventId)
        {
            this.AttributeAliasMvoEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class AttributeAliasMvoStateCreated : AttributeAliasMvoStateEventBase, IAttributeAliasMvoStateCreated
	{
		public AttributeAliasMvoStateCreated () : this(new AttributeAliasMvoEventId())
		{
		}

		public AttributeAliasMvoStateCreated (AttributeAliasMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class AttributeAliasMvoStateMergePatched : AttributeAliasMvoStateEventBase, IAttributeAliasMvoStateMergePatched
	{
		public virtual bool IsPropertyNameRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyAttributeAttributeNameRemoved { get; set; }

		public virtual bool IsPropertyAttributeOrganizationIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeDescriptionRemoved { get; set; }

		public virtual bool IsPropertyAttributeIsMandatoryRemoved { get; set; }

		public virtual bool IsPropertyAttributeAttributeValueTypeRemoved { get; set; }

		public virtual bool IsPropertyAttributeAttributeValueLengthRemoved { get; set; }

		public virtual bool IsPropertyAttributeIsListRemoved { get; set; }

		public virtual bool IsPropertyAttributeFieldNameRemoved { get; set; }

		public virtual bool IsPropertyAttributeReferenceIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeCreatedByRemoved { get; set; }

		public virtual bool IsPropertyAttributeCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyAttributeUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyAttributeUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyAttributeActiveRemoved { get; set; }

		public virtual bool IsPropertyAttributeDeletedRemoved { get; set; }


		public AttributeAliasMvoStateMergePatched ()
		{
		}

		public AttributeAliasMvoStateMergePatched (AttributeAliasMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class AttributeAliasMvoStateDeleted : AttributeAliasMvoStateEventBase, IAttributeAliasMvoStateDeleted
	{
		public AttributeAliasMvoStateDeleted ()
		{
		}

		public AttributeAliasMvoStateDeleted (AttributeAliasMvoEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

