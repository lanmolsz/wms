﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

	public abstract class InOutLineEventBase : IInOutLineEvent
	{

		public virtual InOutLineEventId InOutLineEventId { get; set; }

        public virtual string LineNumber
        {
            get { return InOutLineEventId.LineNumber; }
            set { InOutLineEventId.LineNumber = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InOutLineEventId IGlobalIdentity<InOutLineEventId>.GlobalId {
			get
			{
				return this.InOutLineEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IInOutLineEvent.ReadOnly
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

        protected InOutLineEventBase()
        {
        }

        protected InOutLineEventBase(InOutLineEventId stateEventId)
        {
            this.InOutLineEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class InOutLineStateEventBase : InOutLineEventBase, IInOutLineStateEvent
    {

		public virtual string LocatorId { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual string Description { get; set; }

		public virtual string QuantityUomId { get; set; }

		public virtual decimal? MovementQuantity { get; set; }

		public virtual decimal? PickedQuantity { get; set; }

		public virtual bool? IsInvoiced { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string RmaLineNumber { get; set; }

		public virtual string ReversalLineNumber { get; set; }

		public virtual bool? Active { get; set; }

        protected InOutLineStateEventBase() : base()
        {
        }

        protected InOutLineStateEventBase(InOutLineEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class InOutLineStateCreated : InOutLineStateEventBase, IInOutLineStateCreated
	{
		public InOutLineStateCreated () : this(new InOutLineEventId())
		{
		}

		public InOutLineStateCreated (InOutLineEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class InOutLineStateMergePatched : InOutLineStateEventBase, IInOutLineStateMergePatched
	{
		public virtual bool IsPropertyLocatorIdRemoved { get; set; }

		public virtual bool IsPropertyProductIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyQuantityUomIdRemoved { get; set; }

		public virtual bool IsPropertyMovementQuantityRemoved { get; set; }

		public virtual bool IsPropertyPickedQuantityRemoved { get; set; }

		public virtual bool IsPropertyIsInvoicedRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyRmaLineNumberRemoved { get; set; }

		public virtual bool IsPropertyReversalLineNumberRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public InOutLineStateMergePatched ()
		{
		}

		public InOutLineStateMergePatched (InOutLineEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class InOutLineStateRemoved : InOutLineStateEventBase, IInOutLineStateRemoved
	{
		public InOutLineStateRemoved ()
		{
		}

		public InOutLineStateRemoved (InOutLineEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}

