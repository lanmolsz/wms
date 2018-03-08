﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{

	public abstract class AttributeAliasStateEventBase : IAttributeAliasStateEvent
	{

		public virtual AttributeAliasEventId StateEventId { get; set; }

        public virtual string Code
        {
            get { return StateEventId.Code; }
            set { StateEventId.Code = value; }
        }

		public virtual string Name { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeAliasEventId IGlobalIdentity<AttributeAliasEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeAliasStateEvent.ReadOnly
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

        protected AttributeAliasStateEventBase()
        {
        }

        protected AttributeAliasStateEventBase(AttributeAliasEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class AttributeAliasStateCreated : AttributeAliasStateEventBase, IAttributeAliasStateCreated
	{
		public AttributeAliasStateCreated () : this(new AttributeAliasEventId())
		{
		}

		public AttributeAliasStateCreated (AttributeAliasEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class AttributeAliasStateMergePatched : AttributeAliasStateEventBase, IAttributeAliasStateMergePatched
	{
		public virtual bool IsPropertyNameRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public AttributeAliasStateMergePatched ()
		{
		}

		public AttributeAliasStateMergePatched (AttributeAliasEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class AttributeAliasStateRemoved : AttributeAliasStateEventBase, IAttributeAliasStateRemoved
	{
		public AttributeAliasStateRemoved ()
		{
		}

		public AttributeAliasStateRemoved (AttributeAliasEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}

