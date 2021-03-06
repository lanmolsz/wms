﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementLineMvo;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.MovementLineMvo
{

	public partial class MovementLineMvoState : MovementLineMvoStateProperties, IMovementLineMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		MovementLineId IGlobalIdentity<MovementLineId>.GlobalId
		{
			get
			{
				return this.MovementLineId;
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
				return this.MovementVersion;
			}
		}


		#endregion

        bool IMovementLineMvoState.IsUnsaved
        {
            get { return this.MovementVersion == VersionZero; }
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

        public MovementLineMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.MovementLineId = ((IMovementLineMvoEvent)events.First()).MovementLineMvoEventId.MovementLineId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.MovementVersion += 1;
                }
            }
        }

        public MovementLineMvoState() : this(false)
        {
        }

        public MovementLineMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IMovementLineMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.MovementQuantity = (e.MovementQuantity != null && e.MovementQuantity.HasValue) ? e.MovementQuantity.Value : default(decimal);

			this.ProductId = e.ProductId;

			this.LocatorIdFrom = e.LocatorIdFrom;

			this.LocatorIdTo = e.LocatorIdTo;

			this.AttributeSetInstanceId = e.AttributeSetInstanceId;

            this.Processed = (e.Processed != null && e.Processed.HasValue) ? e.Processed.Value : default(bool);

			this.ReversalLineNumber = e.ReversalLineNumber;

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.MovementDocumentStatusId = e.MovementDocumentStatusId;

            this.MovementMovementDate = (e.MovementMovementDate != null && e.MovementMovementDate.HasValue) ? e.MovementMovementDate.Value : default(DateTime);

            this.MovementPosted = (e.MovementPosted != null && e.MovementPosted.HasValue) ? e.MovementPosted.Value : default(bool);

            this.MovementProcessed = (e.MovementProcessed != null && e.MovementProcessed.HasValue) ? e.MovementProcessed.Value : default(bool);

			this.MovementProcessing = e.MovementProcessing;

            this.MovementDateReceived = (e.MovementDateReceived != null && e.MovementDateReceived.HasValue) ? e.MovementDateReceived.Value : default(DateTime);

			this.MovementDocumentTypeId = e.MovementDocumentTypeId;

            this.MovementIsInTransit = (e.MovementIsInTransit != null && e.MovementIsInTransit.HasValue) ? e.MovementIsInTransit.Value : default(bool);

            this.MovementIsApproved = (e.MovementIsApproved != null && e.MovementIsApproved.HasValue) ? e.MovementIsApproved.Value : default(bool);

            this.MovementApprovalAmount = (e.MovementApprovalAmount != null && e.MovementApprovalAmount.HasValue) ? e.MovementApprovalAmount.Value : default(decimal);

			this.MovementShipperId = e.MovementShipperId;

			this.MovementSalesRepresentativeId = e.MovementSalesRepresentativeId;

			this.MovementBusinessPartnerId = e.MovementBusinessPartnerId;

            this.MovementChargeAmount = (e.MovementChargeAmount != null && e.MovementChargeAmount.HasValue) ? e.MovementChargeAmount.Value : default(decimal);

			this.MovementCreateFrom = e.MovementCreateFrom;

            this.MovementFreightAmount = (e.MovementFreightAmount != null && e.MovementFreightAmount.HasValue) ? e.MovementFreightAmount.Value : default(decimal);

			this.MovementReversalDocumentNumber = e.MovementReversalDocumentNumber;

			this.MovementWarehouseIdFrom = e.MovementWarehouseIdFrom;

			this.MovementWarehouseIdTo = e.MovementWarehouseIdTo;

			this.MovementDescription = e.MovementDescription;

			this.MovementCreatedBy = e.MovementCreatedBy;

            this.MovementCreatedAt = (e.MovementCreatedAt != null && e.MovementCreatedAt.HasValue) ? e.MovementCreatedAt.Value : default(DateTime);

			this.MovementUpdatedBy = e.MovementUpdatedBy;

            this.MovementUpdatedAt = (e.MovementUpdatedAt != null && e.MovementUpdatedAt.HasValue) ? e.MovementUpdatedAt.Value : default(DateTime);

            this.MovementActive = (e.MovementActive != null && e.MovementActive.HasValue) ? e.MovementActive.Value : default(bool);

            this.MovementDeleted = (e.MovementDeleted != null && e.MovementDeleted.HasValue) ? e.MovementDeleted.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IMovementLineMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.MovementQuantity == null)
			{
				if (e.IsPropertyMovementQuantityRemoved)
				{
					this.MovementQuantity = default(decimal);
				}
			}
			else
			{
				this.MovementQuantity = (e.MovementQuantity != null && e.MovementQuantity.HasValue) ? e.MovementQuantity.Value : default(decimal);
			}

			if (e.ProductId == null)
			{
				if (e.IsPropertyProductIdRemoved)
				{
					this.ProductId = default(string);
				}
			}
			else
			{
				this.ProductId = e.ProductId;
			}

			if (e.LocatorIdFrom == null)
			{
				if (e.IsPropertyLocatorIdFromRemoved)
				{
					this.LocatorIdFrom = default(string);
				}
			}
			else
			{
				this.LocatorIdFrom = e.LocatorIdFrom;
			}

			if (e.LocatorIdTo == null)
			{
				if (e.IsPropertyLocatorIdToRemoved)
				{
					this.LocatorIdTo = default(string);
				}
			}
			else
			{
				this.LocatorIdTo = e.LocatorIdTo;
			}

			if (e.AttributeSetInstanceId == null)
			{
				if (e.IsPropertyAttributeSetInstanceIdRemoved)
				{
					this.AttributeSetInstanceId = default(string);
				}
			}
			else
			{
				this.AttributeSetInstanceId = e.AttributeSetInstanceId;
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

			if (e.ReversalLineNumber == null)
			{
				if (e.IsPropertyReversalLineNumberRemoved)
				{
					this.ReversalLineNumber = default(string);
				}
			}
			else
			{
				this.ReversalLineNumber = e.ReversalLineNumber;
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

			if (e.MovementDocumentStatusId == null)
			{
				if (e.IsPropertyMovementDocumentStatusIdRemoved)
				{
					this.MovementDocumentStatusId = default(string);
				}
			}
			else
			{
				this.MovementDocumentStatusId = e.MovementDocumentStatusId;
			}

			if (e.MovementMovementDate == null)
			{
				if (e.IsPropertyMovementMovementDateRemoved)
				{
					this.MovementMovementDate = default(DateTime);
				}
			}
			else
			{
				this.MovementMovementDate = (e.MovementMovementDate != null && e.MovementMovementDate.HasValue) ? e.MovementMovementDate.Value : default(DateTime);
			}

			if (e.MovementPosted == null)
			{
				if (e.IsPropertyMovementPostedRemoved)
				{
					this.MovementPosted = default(bool);
				}
			}
			else
			{
				this.MovementPosted = (e.MovementPosted != null && e.MovementPosted.HasValue) ? e.MovementPosted.Value : default(bool);
			}

			if (e.MovementProcessed == null)
			{
				if (e.IsPropertyMovementProcessedRemoved)
				{
					this.MovementProcessed = default(bool);
				}
			}
			else
			{
				this.MovementProcessed = (e.MovementProcessed != null && e.MovementProcessed.HasValue) ? e.MovementProcessed.Value : default(bool);
			}

			if (e.MovementProcessing == null)
			{
				if (e.IsPropertyMovementProcessingRemoved)
				{
					this.MovementProcessing = default(string);
				}
			}
			else
			{
				this.MovementProcessing = e.MovementProcessing;
			}

			if (e.MovementDateReceived == null)
			{
				if (e.IsPropertyMovementDateReceivedRemoved)
				{
					this.MovementDateReceived = default(DateTime);
				}
			}
			else
			{
				this.MovementDateReceived = (e.MovementDateReceived != null && e.MovementDateReceived.HasValue) ? e.MovementDateReceived.Value : default(DateTime);
			}

			if (e.MovementDocumentTypeId == null)
			{
				if (e.IsPropertyMovementDocumentTypeIdRemoved)
				{
					this.MovementDocumentTypeId = default(string);
				}
			}
			else
			{
				this.MovementDocumentTypeId = e.MovementDocumentTypeId;
			}

			if (e.MovementIsInTransit == null)
			{
				if (e.IsPropertyMovementIsInTransitRemoved)
				{
					this.MovementIsInTransit = default(bool);
				}
			}
			else
			{
				this.MovementIsInTransit = (e.MovementIsInTransit != null && e.MovementIsInTransit.HasValue) ? e.MovementIsInTransit.Value : default(bool);
			}

			if (e.MovementIsApproved == null)
			{
				if (e.IsPropertyMovementIsApprovedRemoved)
				{
					this.MovementIsApproved = default(bool);
				}
			}
			else
			{
				this.MovementIsApproved = (e.MovementIsApproved != null && e.MovementIsApproved.HasValue) ? e.MovementIsApproved.Value : default(bool);
			}

			if (e.MovementApprovalAmount == null)
			{
				if (e.IsPropertyMovementApprovalAmountRemoved)
				{
					this.MovementApprovalAmount = default(decimal);
				}
			}
			else
			{
				this.MovementApprovalAmount = (e.MovementApprovalAmount != null && e.MovementApprovalAmount.HasValue) ? e.MovementApprovalAmount.Value : default(decimal);
			}

			if (e.MovementShipperId == null)
			{
				if (e.IsPropertyMovementShipperIdRemoved)
				{
					this.MovementShipperId = default(string);
				}
			}
			else
			{
				this.MovementShipperId = e.MovementShipperId;
			}

			if (e.MovementSalesRepresentativeId == null)
			{
				if (e.IsPropertyMovementSalesRepresentativeIdRemoved)
				{
					this.MovementSalesRepresentativeId = default(string);
				}
			}
			else
			{
				this.MovementSalesRepresentativeId = e.MovementSalesRepresentativeId;
			}

			if (e.MovementBusinessPartnerId == null)
			{
				if (e.IsPropertyMovementBusinessPartnerIdRemoved)
				{
					this.MovementBusinessPartnerId = default(string);
				}
			}
			else
			{
				this.MovementBusinessPartnerId = e.MovementBusinessPartnerId;
			}

			if (e.MovementChargeAmount == null)
			{
				if (e.IsPropertyMovementChargeAmountRemoved)
				{
					this.MovementChargeAmount = default(decimal);
				}
			}
			else
			{
				this.MovementChargeAmount = (e.MovementChargeAmount != null && e.MovementChargeAmount.HasValue) ? e.MovementChargeAmount.Value : default(decimal);
			}

			if (e.MovementCreateFrom == null)
			{
				if (e.IsPropertyMovementCreateFromRemoved)
				{
					this.MovementCreateFrom = default(string);
				}
			}
			else
			{
				this.MovementCreateFrom = e.MovementCreateFrom;
			}

			if (e.MovementFreightAmount == null)
			{
				if (e.IsPropertyMovementFreightAmountRemoved)
				{
					this.MovementFreightAmount = default(decimal);
				}
			}
			else
			{
				this.MovementFreightAmount = (e.MovementFreightAmount != null && e.MovementFreightAmount.HasValue) ? e.MovementFreightAmount.Value : default(decimal);
			}

			if (e.MovementReversalDocumentNumber == null)
			{
				if (e.IsPropertyMovementReversalDocumentNumberRemoved)
				{
					this.MovementReversalDocumentNumber = default(string);
				}
			}
			else
			{
				this.MovementReversalDocumentNumber = e.MovementReversalDocumentNumber;
			}

			if (e.MovementWarehouseIdFrom == null)
			{
				if (e.IsPropertyMovementWarehouseIdFromRemoved)
				{
					this.MovementWarehouseIdFrom = default(string);
				}
			}
			else
			{
				this.MovementWarehouseIdFrom = e.MovementWarehouseIdFrom;
			}

			if (e.MovementWarehouseIdTo == null)
			{
				if (e.IsPropertyMovementWarehouseIdToRemoved)
				{
					this.MovementWarehouseIdTo = default(string);
				}
			}
			else
			{
				this.MovementWarehouseIdTo = e.MovementWarehouseIdTo;
			}

			if (e.MovementDescription == null)
			{
				if (e.IsPropertyMovementDescriptionRemoved)
				{
					this.MovementDescription = default(string);
				}
			}
			else
			{
				this.MovementDescription = e.MovementDescription;
			}

			if (e.MovementCreatedBy == null)
			{
				if (e.IsPropertyMovementCreatedByRemoved)
				{
					this.MovementCreatedBy = default(string);
				}
			}
			else
			{
				this.MovementCreatedBy = e.MovementCreatedBy;
			}

			if (e.MovementCreatedAt == null)
			{
				if (e.IsPropertyMovementCreatedAtRemoved)
				{
					this.MovementCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.MovementCreatedAt = (e.MovementCreatedAt != null && e.MovementCreatedAt.HasValue) ? e.MovementCreatedAt.Value : default(DateTime);
			}

			if (e.MovementUpdatedBy == null)
			{
				if (e.IsPropertyMovementUpdatedByRemoved)
				{
					this.MovementUpdatedBy = default(string);
				}
			}
			else
			{
				this.MovementUpdatedBy = e.MovementUpdatedBy;
			}

			if (e.MovementUpdatedAt == null)
			{
				if (e.IsPropertyMovementUpdatedAtRemoved)
				{
					this.MovementUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.MovementUpdatedAt = (e.MovementUpdatedAt != null && e.MovementUpdatedAt.HasValue) ? e.MovementUpdatedAt.Value : default(DateTime);
			}

			if (e.MovementActive == null)
			{
				if (e.IsPropertyMovementActiveRemoved)
				{
					this.MovementActive = default(bool);
				}
			}
			else
			{
				this.MovementActive = (e.MovementActive != null && e.MovementActive.HasValue) ? e.MovementActive.Value : default(bool);
			}

			if (e.MovementDeleted == null)
			{
				if (e.IsPropertyMovementDeletedRemoved)
				{
					this.MovementDeleted = default(bool);
				}
			}
			else
			{
				this.MovementDeleted = (e.MovementDeleted != null && e.MovementDeleted.HasValue) ? e.MovementDeleted.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IMovementLineMvoStateDeleted e)
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

        protected void ThrowOnWrongEvent(IMovementLineMvoEvent e)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("MovementLineMvo|");

            var stateEntityId = this.MovementLineId; // Aggregate Id
            var eventEntityId = e.MovementLineMvoEventId.MovementLineId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.MovementVersion;
            var eventVersion = e.MovementLineMvoEventId.MovementVersion;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

