﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventoryLineMvo;
using Dddml.Wms.Domain.PhysicalInventory;

namespace Dddml.Wms.Domain.PhysicalInventoryLineMvo
{

	public abstract class PhysicalInventoryLineMvoEventBase : IPhysicalInventoryLineMvoEvent
	{

		public virtual PhysicalInventoryLineMvoEventId PhysicalInventoryLineMvoEventId { get; set; }

        public virtual PhysicalInventoryLineId PhysicalInventoryLineId
        {
            get { return PhysicalInventoryLineMvoEventId.PhysicalInventoryLineId; }
            set { PhysicalInventoryLineMvoEventId.PhysicalInventoryLineId = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		PhysicalInventoryLineMvoEventId IGlobalIdentity<PhysicalInventoryLineMvoEventId>.GlobalId {
			get
			{
				return this.PhysicalInventoryLineMvoEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IPhysicalInventoryLineMvoEvent.ReadOnly
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

        protected PhysicalInventoryLineMvoEventBase()
        {
        }

        protected PhysicalInventoryLineMvoEventBase(PhysicalInventoryLineMvoEventId stateEventId)
        {
            this.PhysicalInventoryLineMvoEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class PhysicalInventoryLineMvoStateEventBase : PhysicalInventoryLineMvoEventBase, IPhysicalInventoryLineMvoStateEvent
    {

		public virtual decimal? BookQuantity { get; set; }

		public virtual decimal? CountedQuantity { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string LineNumber { get; set; }

		public virtual long? ReversalLineNumber { get; set; }

		public virtual string Description { get; set; }

		public virtual long? Version { get; set; }

		public virtual string PhysicalInventoryDocumentStatusId { get; set; }

		public virtual string PhysicalInventoryWarehouseId { get; set; }

		public virtual string PhysicalInventoryLocatorIdPattern { get; set; }

		public virtual string PhysicalInventoryProductIdPattern { get; set; }

		public virtual bool? PhysicalInventoryPosted { get; set; }

		public virtual bool? PhysicalInventoryProcessed { get; set; }

		public virtual string PhysicalInventoryProcessing { get; set; }

		public virtual string PhysicalInventoryDocumentTypeId { get; set; }

		public virtual DateTime? PhysicalInventoryMovementDate { get; set; }

		public virtual string PhysicalInventoryDescription { get; set; }

		public virtual bool? PhysicalInventoryIsApproved { get; set; }

		public virtual decimal? PhysicalInventoryApprovalAmount { get; set; }

		public virtual bool? PhysicalInventoryIsQuantityUpdated { get; set; }

		public virtual string PhysicalInventoryReversalDocumentNumber { get; set; }

		public virtual string PhysicalInventoryCreatedBy { get; set; }

		public virtual DateTime? PhysicalInventoryCreatedAt { get; set; }

		public virtual string PhysicalInventoryUpdatedBy { get; set; }

		public virtual DateTime? PhysicalInventoryUpdatedAt { get; set; }

		public virtual bool? PhysicalInventoryActive { get; set; }

        protected PhysicalInventoryLineMvoStateEventBase() : base()
        {
        }

        protected PhysicalInventoryLineMvoStateEventBase(PhysicalInventoryLineMvoEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class PhysicalInventoryLineMvoStateCreated : PhysicalInventoryLineMvoStateEventBase, IPhysicalInventoryLineMvoStateCreated
	{
		public PhysicalInventoryLineMvoStateCreated () : this(new PhysicalInventoryLineMvoEventId())
		{
		}

		public PhysicalInventoryLineMvoStateCreated (PhysicalInventoryLineMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class PhysicalInventoryLineMvoStateMergePatched : PhysicalInventoryLineMvoStateEventBase, IPhysicalInventoryLineMvoStateMergePatched
	{
		public virtual bool IsPropertyBookQuantityRemoved { get; set; }

		public virtual bool IsPropertyCountedQuantityRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyLineNumberRemoved { get; set; }

		public virtual bool IsPropertyReversalLineNumberRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryDocumentStatusIdRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryWarehouseIdRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryLocatorIdPatternRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryProductIdPatternRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryPostedRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryProcessedRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryProcessingRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryDocumentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryMovementDateRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryDescriptionRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryIsApprovedRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryApprovalAmountRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryIsQuantityUpdatedRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryReversalDocumentNumberRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryCreatedByRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyPhysicalInventoryActiveRemoved { get; set; }


		public PhysicalInventoryLineMvoStateMergePatched ()
		{
		}

		public PhysicalInventoryLineMvoStateMergePatched (PhysicalInventoryLineMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class PhysicalInventoryLineMvoStateDeleted : PhysicalInventoryLineMvoStateEventBase, IPhysicalInventoryLineMvoStateDeleted
	{
		public PhysicalInventoryLineMvoStateDeleted ()
		{
		}

		public PhysicalInventoryLineMvoStateDeleted (PhysicalInventoryLineMvoEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

