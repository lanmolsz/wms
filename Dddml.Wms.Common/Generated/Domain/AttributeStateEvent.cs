﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public abstract class AttributeStateEventBase : AttributeStateProperties, IAttributeStateEvent
	{

		public virtual AttributeStateEventId StateEventId { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		AttributeStateEventId IGlobalIdentity<AttributeStateEventId>.GlobalId {
			get {
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeStateEvent.ReadOnly
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

		public override string AttributeId {
			get {
				return StateEventId.AttributeId;//EntityBase.Aggregate.GetStateEventIdPropertyIdName()
			}
			set {
				throw new NotSupportedException ();
			}
		}

		public virtual long Version {
			get {
				return StateEventId.Version;//EntityBase.Aggregate.GetStateEventIdPropertyVersionName()
			}
			set {
				throw new NotSupportedException ();
			}
		}


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
		}

        protected AttributeStateEventBase()
        {
        }

        protected AttributeStateEventBase(AttributeStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        protected AttributeValueStateEventId NewAttributeValueStateEventId(string value)
        {
            var stateEventId = new AttributeValueStateEventId(this.StateEventId.AttributeId, value, this.StateEventId.Version);
            return stateEventId;
        }

		protected void ThrowOnInconsistentEventIds(IAttributeValueStateEvent e)
		{
			if (this.StateEventId.AttributeId != e.StateEventId.AttributeId) 
			{ 
				DomainError.Named("inconsistentEventIds", "Outer Id AttributeId {0} but inner id AttributeId {1}", 
					this.StateEventId.AttributeId, e.StateEventId.AttributeId);
			}
		}



	}

	public class AttributeStateCreated : AttributeStateEventBase, IAttributeStateCreated, ISaveable
	{
		public AttributeStateCreated ()
		{
		}

		public AttributeStateCreated (AttributeStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<AttributeValueStateEventId, IAttributeValueStateCreated> _attributeValueEvents = new Dictionary<AttributeValueStateEventId, IAttributeValueStateCreated>();
		
		public virtual IEnumerable<IAttributeValueStateCreated> AttributeValueEvents {
			get {
				return this._attributeValueEvents.Values;
			}
		}
	
		public virtual void AddAttributeValueEvent(IAttributeValueStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._attributeValueEvents[e.StateEventId] = e;
		}

        public virtual AttributeValueStateCreated NewAttributeValueStateCreated(string value)
        {
            var stateEvent = new AttributeValueStateCreated(NewAttributeValueStateEventId(value));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IAttributeValueStateCreated e in this.AttributeValueEvents) {
				(ApplicationContext.Current["AttributeValueStateEventDao"] as IAttributeValueStateEventDao).Save(e);
			}
		}

	}


	public class AttributeStateMergePatched : AttributeStateEventBase, IAttributeStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyNameRemoved { get; set; }

		public virtual bool IsPropertyOrganizationIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyIsMandatoryRemoved { get; set; }

		public virtual bool IsPropertyIsInstanceAttributeRemoved { get; set; }

		public virtual bool IsPropertyAttributeValueTypeRemoved { get; set; }

		public virtual bool IsPropertyAttributeValueLengthRemoved { get; set; }

		public virtual bool IsPropertyIsListRemoved { get; set; }

		public virtual bool IsPropertyFieldNameRemoved { get; set; }

		public virtual bool IsPropertyReferenceIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public AttributeStateMergePatched ()
		{
		}

		public AttributeStateMergePatched (AttributeStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<AttributeValueStateEventId, IAttributeValueStateEvent> _attributeValueEvents = new Dictionary<AttributeValueStateEventId, IAttributeValueStateEvent>();
		
		public virtual IEnumerable<IAttributeValueStateEvent> AttributeValueEvents {
			get {
				return this._attributeValueEvents.Values;
			}
		}
	
		public virtual void AddAttributeValueEvent(IAttributeValueStateEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._attributeValueEvents[e.StateEventId] = e;
		}

        public virtual AttributeValueStateCreated NewAttributeValueStateCreated(string value)
        {
            var stateEvent = new AttributeValueStateCreated(NewAttributeValueStateEventId(value));
            return stateEvent;
        }

        public virtual AttributeValueStateMergePatched NewAttributeValueStateMergePatched(string value)
        {
            var stateEvent = new AttributeValueStateMergePatched(NewAttributeValueStateEventId(value));
            return stateEvent;
        }

        public virtual AttributeValueStateRemoved NewAttributeValueStateRemoved(string value)
        {
            var stateEvent = new AttributeValueStateRemoved(NewAttributeValueStateEventId(value));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IAttributeValueStateEvent e in this.AttributeValueEvents) {
				(ApplicationContext.Current["AttributeValueStateEventDao"] as IAttributeValueStateEventDao).Save(e);
			}
		}


	}


	public class AttributeStateDeleted : AttributeStateEventBase, IAttributeStateDeleted
	{
		public AttributeStateDeleted ()
		{
		}

		public AttributeStateDeleted (AttributeStateEventId stateEventId) : base(stateEventId)
		{
		}

	}



}

