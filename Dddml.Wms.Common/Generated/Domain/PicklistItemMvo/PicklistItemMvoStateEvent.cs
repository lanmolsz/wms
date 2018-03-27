﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistItemMvo;
using Dddml.Wms.Domain.PicklistBin;

namespace Dddml.Wms.Domain.PicklistItemMvo
{

	public abstract class PicklistItemMvoStateEventBase : IPicklistItemMvoStateEvent
	{

		public virtual PicklistItemMvoEventId PicklistItemMvoEventId { get; set; }

        public virtual PicklistBinPicklistItemId PicklistBinPicklistItemId
        {
            get { return PicklistItemMvoEventId.PicklistBinPicklistItemId; }
            set { PicklistItemMvoEventId.PicklistBinPicklistItemId = value; }
        }

		public virtual string ItemStatusId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string PicklistBinPicklistId { get; set; }

		public virtual long? PicklistBinBinLocationNumber { get; set; }

		public virtual string PicklistBinPrimaryOrderId { get; set; }

		public virtual long? PicklistBinPrimaryShipGroupSeqId { get; set; }

		public virtual string PicklistBinCreatedBy { get; set; }

		public virtual DateTime? PicklistBinCreatedAt { get; set; }

		public virtual string PicklistBinUpdatedBy { get; set; }

		public virtual DateTime? PicklistBinUpdatedAt { get; set; }

		public virtual bool? PicklistBinActive { get; set; }

		public virtual bool? PicklistBinDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		PicklistItemMvoEventId IGlobalIdentity<PicklistItemMvoEventId>.GlobalId {
			get
			{
				return this.PicklistItemMvoEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IPicklistItemMvoStateEvent.ReadOnly
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

        protected PicklistItemMvoStateEventBase()
        {
        }

        protected PicklistItemMvoStateEventBase(PicklistItemMvoEventId stateEventId)
        {
            this.PicklistItemMvoEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class PicklistItemMvoStateCreated : PicklistItemMvoStateEventBase, IPicklistItemMvoStateCreated
	{
		public PicklistItemMvoStateCreated () : this(new PicklistItemMvoEventId())
		{
		}

		public PicklistItemMvoStateCreated (PicklistItemMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class PicklistItemMvoStateMergePatched : PicklistItemMvoStateEventBase, IPicklistItemMvoStateMergePatched
	{
		public virtual bool IsPropertyItemStatusIdRemoved { get; set; }

		public virtual bool IsPropertyQuantityRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinPicklistIdRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinBinLocationNumberRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinPrimaryOrderIdRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinPrimaryShipGroupSeqIdRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinCreatedByRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinActiveRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinDeletedRemoved { get; set; }


		public PicklistItemMvoStateMergePatched ()
		{
		}

		public PicklistItemMvoStateMergePatched (PicklistItemMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class PicklistItemMvoStateDeleted : PicklistItemMvoStateEventBase, IPicklistItemMvoStateDeleted
	{
		public PicklistItemMvoStateDeleted ()
		{
		}

		public PicklistItemMvoStateDeleted (PicklistItemMvoEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}
