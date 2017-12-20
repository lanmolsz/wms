﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmationLineMvo;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmationLineMvo
{

	public partial class MovementConfirmationLineMvoState : MovementConfirmationLineMvoStateProperties, IMovementConfirmationLineMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		MovementConfirmationLineId IGlobalIdentity<MovementConfirmationLineId>.GlobalId
		{
			get
			{
				return this.MovementConfirmationLineId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.MovementConfirmationVersion;
			}
		}


		#endregion

        bool IMovementConfirmationLineMvoState.IsUnsaved
        {
            get { return this.MovementConfirmationVersion == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public MovementConfirmationLineMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.MovementConfirmationLineId = ((IMovementConfirmationLineMvoStateEvent)events.First()).StateEventId.MovementConfirmationLineId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.MovementConfirmationVersion += 1;
                }
            }
        }

        public MovementConfirmationLineMvoState() : this(false)
        {
        }

        public MovementConfirmationLineMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IMovementConfirmationLineMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.MovementLineNumber = e.MovementLineNumber;

            this.TargetQuantity = (e.TargetQuantity != null && e.TargetQuantity.HasValue) ? e.TargetQuantity.Value : default(decimal);

            this.ConfirmedQuantity = (e.ConfirmedQuantity != null && e.ConfirmedQuantity.HasValue) ? e.ConfirmedQuantity.Value : default(decimal);

            this.DifferenceQuantity = (e.DifferenceQuantity != null && e.DifferenceQuantity.HasValue) ? e.DifferenceQuantity.Value : default(decimal);

            this.ScrappedQuantity = (e.ScrappedQuantity != null && e.ScrappedQuantity.HasValue) ? e.ScrappedQuantity.Value : default(decimal);

			this.Description = e.Description;

            this.Processed = (e.Processed != null && e.Processed.HasValue) ? e.Processed.Value : default(bool);

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.MovementConfirmationDocumentTypeId = e.MovementConfirmationDocumentTypeId;

			this.MovementConfirmationDocumentStatusId = e.MovementConfirmationDocumentStatusId;

			this.MovementConfirmationMovementDocumentNumber = e.MovementConfirmationMovementDocumentNumber;

            this.MovementConfirmationIsApproved = (e.MovementConfirmationIsApproved != null && e.MovementConfirmationIsApproved.HasValue) ? e.MovementConfirmationIsApproved.Value : default(bool);

            this.MovementConfirmationApprovalAmount = (e.MovementConfirmationApprovalAmount != null && e.MovementConfirmationApprovalAmount.HasValue) ? e.MovementConfirmationApprovalAmount.Value : default(decimal);

			this.MovementConfirmationProcessing = e.MovementConfirmationProcessing;

            this.MovementConfirmationProcessed = (e.MovementConfirmationProcessed != null && e.MovementConfirmationProcessed.HasValue) ? e.MovementConfirmationProcessed.Value : default(bool);

			this.MovementConfirmationDescription = e.MovementConfirmationDescription;

			this.MovementConfirmationCreatedBy = e.MovementConfirmationCreatedBy;

            this.MovementConfirmationCreatedAt = (e.MovementConfirmationCreatedAt != null && e.MovementConfirmationCreatedAt.HasValue) ? e.MovementConfirmationCreatedAt.Value : default(DateTime);

			this.MovementConfirmationUpdatedBy = e.MovementConfirmationUpdatedBy;

            this.MovementConfirmationUpdatedAt = (e.MovementConfirmationUpdatedAt != null && e.MovementConfirmationUpdatedAt.HasValue) ? e.MovementConfirmationUpdatedAt.Value : default(DateTime);

            this.MovementConfirmationActive = (e.MovementConfirmationActive != null && e.MovementConfirmationActive.HasValue) ? e.MovementConfirmationActive.Value : default(bool);

            this.MovementConfirmationDeleted = (e.MovementConfirmationDeleted != null && e.MovementConfirmationDeleted.HasValue) ? e.MovementConfirmationDeleted.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IMovementConfirmationLineMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.MovementLineNumber == null)
			{
				if (e.IsPropertyMovementLineNumberRemoved)
				{
					this.MovementLineNumber = default(string);
				}
			}
			else
			{
				this.MovementLineNumber = e.MovementLineNumber;
			}

			if (e.TargetQuantity == null)
			{
				if (e.IsPropertyTargetQuantityRemoved)
				{
					this.TargetQuantity = default(decimal);
				}
			}
			else
			{
				this.TargetQuantity = (e.TargetQuantity != null && e.TargetQuantity.HasValue) ? e.TargetQuantity.Value : default(decimal);
			}

			if (e.ConfirmedQuantity == null)
			{
				if (e.IsPropertyConfirmedQuantityRemoved)
				{
					this.ConfirmedQuantity = default(decimal);
				}
			}
			else
			{
				this.ConfirmedQuantity = (e.ConfirmedQuantity != null && e.ConfirmedQuantity.HasValue) ? e.ConfirmedQuantity.Value : default(decimal);
			}

			if (e.DifferenceQuantity == null)
			{
				if (e.IsPropertyDifferenceQuantityRemoved)
				{
					this.DifferenceQuantity = default(decimal);
				}
			}
			else
			{
				this.DifferenceQuantity = (e.DifferenceQuantity != null && e.DifferenceQuantity.HasValue) ? e.DifferenceQuantity.Value : default(decimal);
			}

			if (e.ScrappedQuantity == null)
			{
				if (e.IsPropertyScrappedQuantityRemoved)
				{
					this.ScrappedQuantity = default(decimal);
				}
			}
			else
			{
				this.ScrappedQuantity = (e.ScrappedQuantity != null && e.ScrappedQuantity.HasValue) ? e.ScrappedQuantity.Value : default(decimal);
			}

			if (e.Description == null)
			{
				if (e.IsPropertyDescriptionRemoved)
				{
					this.Description = default(string);
				}
			}
			else
			{
				this.Description = e.Description;
			}

			if (e.Processed == null)
			{
				if (e.IsPropertyProcessedRemoved)
				{
					this.Processed = default(bool);
				}
			}
			else
			{
				this.Processed = (e.Processed != null && e.Processed.HasValue) ? e.Processed.Value : default(bool);
			}

			if (e.Version == null)
			{
				if (e.IsPropertyVersionRemoved)
				{
					this.Version = default(long);
				}
			}
			else
			{
				this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}

			if (e.MovementConfirmationDocumentTypeId == null)
			{
				if (e.IsPropertyMovementConfirmationDocumentTypeIdRemoved)
				{
					this.MovementConfirmationDocumentTypeId = default(string);
				}
			}
			else
			{
				this.MovementConfirmationDocumentTypeId = e.MovementConfirmationDocumentTypeId;
			}

			if (e.MovementConfirmationDocumentStatusId == null)
			{
				if (e.IsPropertyMovementConfirmationDocumentStatusIdRemoved)
				{
					this.MovementConfirmationDocumentStatusId = default(string);
				}
			}
			else
			{
				this.MovementConfirmationDocumentStatusId = e.MovementConfirmationDocumentStatusId;
			}

			if (e.MovementConfirmationMovementDocumentNumber == null)
			{
				if (e.IsPropertyMovementConfirmationMovementDocumentNumberRemoved)
				{
					this.MovementConfirmationMovementDocumentNumber = default(string);
				}
			}
			else
			{
				this.MovementConfirmationMovementDocumentNumber = e.MovementConfirmationMovementDocumentNumber;
			}

			if (e.MovementConfirmationIsApproved == null)
			{
				if (e.IsPropertyMovementConfirmationIsApprovedRemoved)
				{
					this.MovementConfirmationIsApproved = default(bool);
				}
			}
			else
			{
				this.MovementConfirmationIsApproved = (e.MovementConfirmationIsApproved != null && e.MovementConfirmationIsApproved.HasValue) ? e.MovementConfirmationIsApproved.Value : default(bool);
			}

			if (e.MovementConfirmationApprovalAmount == null)
			{
				if (e.IsPropertyMovementConfirmationApprovalAmountRemoved)
				{
					this.MovementConfirmationApprovalAmount = default(decimal);
				}
			}
			else
			{
				this.MovementConfirmationApprovalAmount = (e.MovementConfirmationApprovalAmount != null && e.MovementConfirmationApprovalAmount.HasValue) ? e.MovementConfirmationApprovalAmount.Value : default(decimal);
			}

			if (e.MovementConfirmationProcessing == null)
			{
				if (e.IsPropertyMovementConfirmationProcessingRemoved)
				{
					this.MovementConfirmationProcessing = default(string);
				}
			}
			else
			{
				this.MovementConfirmationProcessing = e.MovementConfirmationProcessing;
			}

			if (e.MovementConfirmationProcessed == null)
			{
				if (e.IsPropertyMovementConfirmationProcessedRemoved)
				{
					this.MovementConfirmationProcessed = default(bool);
				}
			}
			else
			{
				this.MovementConfirmationProcessed = (e.MovementConfirmationProcessed != null && e.MovementConfirmationProcessed.HasValue) ? e.MovementConfirmationProcessed.Value : default(bool);
			}

			if (e.MovementConfirmationDescription == null)
			{
				if (e.IsPropertyMovementConfirmationDescriptionRemoved)
				{
					this.MovementConfirmationDescription = default(string);
				}
			}
			else
			{
				this.MovementConfirmationDescription = e.MovementConfirmationDescription;
			}

			if (e.MovementConfirmationCreatedBy == null)
			{
				if (e.IsPropertyMovementConfirmationCreatedByRemoved)
				{
					this.MovementConfirmationCreatedBy = default(string);
				}
			}
			else
			{
				this.MovementConfirmationCreatedBy = e.MovementConfirmationCreatedBy;
			}

			if (e.MovementConfirmationCreatedAt == null)
			{
				if (e.IsPropertyMovementConfirmationCreatedAtRemoved)
				{
					this.MovementConfirmationCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.MovementConfirmationCreatedAt = (e.MovementConfirmationCreatedAt != null && e.MovementConfirmationCreatedAt.HasValue) ? e.MovementConfirmationCreatedAt.Value : default(DateTime);
			}

			if (e.MovementConfirmationUpdatedBy == null)
			{
				if (e.IsPropertyMovementConfirmationUpdatedByRemoved)
				{
					this.MovementConfirmationUpdatedBy = default(string);
				}
			}
			else
			{
				this.MovementConfirmationUpdatedBy = e.MovementConfirmationUpdatedBy;
			}

			if (e.MovementConfirmationUpdatedAt == null)
			{
				if (e.IsPropertyMovementConfirmationUpdatedAtRemoved)
				{
					this.MovementConfirmationUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.MovementConfirmationUpdatedAt = (e.MovementConfirmationUpdatedAt != null && e.MovementConfirmationUpdatedAt.HasValue) ? e.MovementConfirmationUpdatedAt.Value : default(DateTime);
			}

			if (e.MovementConfirmationActive == null)
			{
				if (e.IsPropertyMovementConfirmationActiveRemoved)
				{
					this.MovementConfirmationActive = default(bool);
				}
			}
			else
			{
				this.MovementConfirmationActive = (e.MovementConfirmationActive != null && e.MovementConfirmationActive.HasValue) ? e.MovementConfirmationActive.Value : default(bool);
			}

			if (e.MovementConfirmationDeleted == null)
			{
				if (e.IsPropertyMovementConfirmationDeletedRemoved)
				{
					this.MovementConfirmationDeleted = default(bool);
				}
			}
			else
			{
				this.MovementConfirmationDeleted = (e.MovementConfirmationDeleted != null && e.MovementConfirmationDeleted.HasValue) ? e.MovementConfirmationDeleted.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IMovementConfirmationLineMvoStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IMovementConfirmationLineMvoStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("MovementConfirmationLineMvo|");

            var stateEntityId = this.MovementConfirmationLineId; // Aggregate Id
            var eventEntityId = stateEvent.StateEventId.MovementConfirmationLineId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.MovementConfirmationVersion;
            var eventVersion = stateEvent.StateEventId.MovementConfirmationVersion;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

