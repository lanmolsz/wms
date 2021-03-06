﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmation
{

	public abstract class MovementConfirmationLineEventBase : IMovementConfirmationLineEvent
	{

		public virtual MovementConfirmationLineEventId MovementConfirmationLineEventId { get; set; }

        public virtual string LineNumber
        {
            get { return MovementConfirmationLineEventId.LineNumber; }
            set { MovementConfirmationLineEventId.LineNumber = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		MovementConfirmationLineEventId IGlobalIdentity<MovementConfirmationLineEventId>.GlobalId {
			get
			{
				return this.MovementConfirmationLineEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IMovementConfirmationLineEvent.ReadOnly
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

        protected MovementConfirmationLineEventBase()
        {
        }

        protected MovementConfirmationLineEventBase(MovementConfirmationLineEventId stateEventId)
        {
            this.MovementConfirmationLineEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class MovementConfirmationLineStateEventBase : MovementConfirmationLineEventBase, IMovementConfirmationLineStateEvent
    {

		public virtual string MovementLineNumber { get; set; }

		public virtual decimal? TargetQuantity { get; set; }

		public virtual decimal? ConfirmedQuantity { get; set; }

		public virtual decimal? DifferenceQuantity { get; set; }

		public virtual decimal? ScrappedQuantity { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual bool? Active { get; set; }

        protected MovementConfirmationLineStateEventBase() : base()
        {
        }

        protected MovementConfirmationLineStateEventBase(MovementConfirmationLineEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class MovementConfirmationLineStateCreated : MovementConfirmationLineStateEventBase, IMovementConfirmationLineStateCreated
	{
		public MovementConfirmationLineStateCreated () : this(new MovementConfirmationLineEventId())
		{
		}

		public MovementConfirmationLineStateCreated (MovementConfirmationLineEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class MovementConfirmationLineStateMergePatched : MovementConfirmationLineStateEventBase, IMovementConfirmationLineStateMergePatched
	{
		public virtual bool IsPropertyMovementLineNumberRemoved { get; set; }

		public virtual bool IsPropertyTargetQuantityRemoved { get; set; }

		public virtual bool IsPropertyConfirmedQuantityRemoved { get; set; }

		public virtual bool IsPropertyDifferenceQuantityRemoved { get; set; }

		public virtual bool IsPropertyScrappedQuantityRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MovementConfirmationLineStateMergePatched ()
		{
		}

		public MovementConfirmationLineStateMergePatched (MovementConfirmationLineEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class MovementConfirmationLineStateRemoved : MovementConfirmationLineStateEventBase, IMovementConfirmationLineStateRemoved
	{
		public MovementConfirmationLineStateRemoved ()
		{
		}

		public MovementConfirmationLineStateRemoved (MovementConfirmationLineEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}

