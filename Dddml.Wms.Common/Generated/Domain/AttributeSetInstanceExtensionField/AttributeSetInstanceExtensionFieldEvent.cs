﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionField;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionField
{

	public abstract class AttributeSetInstanceExtensionFieldEventBase : IAttributeSetInstanceExtensionFieldEvent
	{

		public virtual AttributeSetInstanceExtensionFieldEventId AttributeSetInstanceExtensionFieldEventId { get; set; }

        public virtual string Name
        {
            get { return AttributeSetInstanceExtensionFieldEventId.Name; }
            set { AttributeSetInstanceExtensionFieldEventId.Name = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeSetInstanceExtensionFieldEventId IGlobalIdentity<AttributeSetInstanceExtensionFieldEventId>.GlobalId {
			get
			{
				return this.AttributeSetInstanceExtensionFieldEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IAttributeSetInstanceExtensionFieldEvent.ReadOnly
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

        protected AttributeSetInstanceExtensionFieldEventBase()
        {
        }

        protected AttributeSetInstanceExtensionFieldEventBase(AttributeSetInstanceExtensionFieldEventId stateEventId)
        {
            this.AttributeSetInstanceExtensionFieldEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class AttributeSetInstanceExtensionFieldStateEventBase : AttributeSetInstanceExtensionFieldEventBase, IAttributeSetInstanceExtensionFieldStateEvent
    {

		public virtual string Type { get; set; }

		public virtual int? Length { get; set; }

		public virtual string Alias { get; set; }

		public virtual string Description { get; set; }

		public virtual string GroupId { get; set; }

		public virtual bool? Active { get; set; }

        protected AttributeSetInstanceExtensionFieldStateEventBase() : base()
        {
        }

        protected AttributeSetInstanceExtensionFieldStateEventBase(AttributeSetInstanceExtensionFieldEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class AttributeSetInstanceExtensionFieldStateCreated : AttributeSetInstanceExtensionFieldStateEventBase, IAttributeSetInstanceExtensionFieldStateCreated
	{
		public AttributeSetInstanceExtensionFieldStateCreated () : this(new AttributeSetInstanceExtensionFieldEventId())
		{
		}

		public AttributeSetInstanceExtensionFieldStateCreated (AttributeSetInstanceExtensionFieldEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class AttributeSetInstanceExtensionFieldStateMergePatched : AttributeSetInstanceExtensionFieldStateEventBase, IAttributeSetInstanceExtensionFieldStateMergePatched
	{
		public virtual bool IsPropertyTypeRemoved { get; set; }

		public virtual bool IsPropertyLengthRemoved { get; set; }

		public virtual bool IsPropertyAliasRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyGroupIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public AttributeSetInstanceExtensionFieldStateMergePatched ()
		{
		}

		public AttributeSetInstanceExtensionFieldStateMergePatched (AttributeSetInstanceExtensionFieldEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class AttributeSetInstanceExtensionFieldStateDeleted : AttributeSetInstanceExtensionFieldStateEventBase, IAttributeSetInstanceExtensionFieldStateDeleted
	{
		public AttributeSetInstanceExtensionFieldStateDeleted ()
		{
		}

		public AttributeSetInstanceExtensionFieldStateDeleted (AttributeSetInstanceExtensionFieldEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}
