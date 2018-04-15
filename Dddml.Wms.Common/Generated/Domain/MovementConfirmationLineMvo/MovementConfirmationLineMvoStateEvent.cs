﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmationLineMvo;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmationLineMvo
{

	public abstract class MovementConfirmationLineMvoStateEventBase : IMovementConfirmationLineMvoStateEvent
	{

		public virtual MovementConfirmationLineMvoEventId MovementConfirmationLineMvoEventId { get; set; }

        public virtual MovementConfirmationLineId MovementConfirmationLineId
        {
            get { return MovementConfirmationLineMvoEventId.MovementConfirmationLineId; }
            set { MovementConfirmationLineMvoEventId.MovementConfirmationLineId = value; }
        }

		public virtual string MovementLineNumber { get; set; }

		public virtual decimal? TargetQuantity { get; set; }

		public virtual decimal? ConfirmedQuantity { get; set; }

		public virtual decimal? DifferenceQuantity { get; set; }

		public virtual decimal? ScrappedQuantity { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string MovementConfirmationDocumentStatusId { get; set; }

		public virtual string MovementConfirmationMovementDocumentNumber { get; set; }

		public virtual bool? MovementConfirmationIsApproved { get; set; }

		public virtual decimal? MovementConfirmationApprovalAmount { get; set; }

		public virtual bool? MovementConfirmationProcessed { get; set; }

		public virtual string MovementConfirmationProcessing { get; set; }

		public virtual string MovementConfirmationDocumentTypeId { get; set; }

		public virtual string MovementConfirmationDescription { get; set; }

		public virtual string MovementConfirmationCreatedBy { get; set; }

		public virtual DateTime? MovementConfirmationCreatedAt { get; set; }

		public virtual string MovementConfirmationUpdatedBy { get; set; }

		public virtual DateTime? MovementConfirmationUpdatedAt { get; set; }

		public virtual bool? MovementConfirmationActive { get; set; }

		public virtual bool? MovementConfirmationDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		MovementConfirmationLineMvoEventId IGlobalIdentity<MovementConfirmationLineMvoEventId>.GlobalId {
			get
			{
				return this.MovementConfirmationLineMvoEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IMovementConfirmationLineMvoStateEvent.ReadOnly
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

        protected MovementConfirmationLineMvoStateEventBase()
        {
        }

        protected MovementConfirmationLineMvoStateEventBase(MovementConfirmationLineMvoEventId stateEventId)
        {
            this.MovementConfirmationLineMvoEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class MovementConfirmationLineMvoStateCreated : MovementConfirmationLineMvoStateEventBase, IMovementConfirmationLineMvoStateCreated
	{
		public MovementConfirmationLineMvoStateCreated () : this(new MovementConfirmationLineMvoEventId())
		{
		}

		public MovementConfirmationLineMvoStateCreated (MovementConfirmationLineMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class MovementConfirmationLineMvoStateMergePatched : MovementConfirmationLineMvoStateEventBase, IMovementConfirmationLineMvoStateMergePatched
	{
		public virtual bool IsPropertyMovementLineNumberRemoved { get; set; }

		public virtual bool IsPropertyTargetQuantityRemoved { get; set; }

		public virtual bool IsPropertyConfirmedQuantityRemoved { get; set; }

		public virtual bool IsPropertyDifferenceQuantityRemoved { get; set; }

		public virtual bool IsPropertyScrappedQuantityRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationDocumentStatusIdRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationMovementDocumentNumberRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationIsApprovedRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationApprovalAmountRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationProcessedRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationProcessingRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationDocumentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationDescriptionRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationCreatedByRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationActiveRemoved { get; set; }

		public virtual bool IsPropertyMovementConfirmationDeletedRemoved { get; set; }


		public MovementConfirmationLineMvoStateMergePatched ()
		{
		}

		public MovementConfirmationLineMvoStateMergePatched (MovementConfirmationLineMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class MovementConfirmationLineMvoStateDeleted : MovementConfirmationLineMvoStateEventBase, IMovementConfirmationLineMvoStateDeleted
	{
		public MovementConfirmationLineMvoStateDeleted ()
		{
		}

		public MovementConfirmationLineMvoStateDeleted (MovementConfirmationLineMvoEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

