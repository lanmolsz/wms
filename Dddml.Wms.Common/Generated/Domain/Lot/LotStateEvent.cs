﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLotDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Lot;

namespace Dddml.Wms.Domain.Lot
{

	public abstract class LotStateEventBase : ILotStateEvent
	{

		public virtual LotEventId StateEventId { get; set; }

        public virtual string LotId
        {
            get { return StateEventId.LotId; }
            set { StateEventId.LotId = value; }
        }

		public virtual decimal? Quantity { get; set; }

		public virtual DateTime? ExpirationDate { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		LotEventId IGlobalIdentity<LotEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool ILotStateEvent.ReadOnly
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

        protected LotStateEventBase()
        {
        }

        protected LotStateEventBase(LotEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class LotStateCreated : LotStateEventBase, ILotStateCreated
	{
		public LotStateCreated () : this(new LotEventId())
		{
		}

		public LotStateCreated (LotEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class LotStateMergePatched : LotStateEventBase, ILotStateMergePatched
	{
		public virtual bool IsPropertyQuantityRemoved { get; set; }

		public virtual bool IsPropertyExpirationDateRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public LotStateMergePatched ()
		{
		}

		public LotStateMergePatched (LotEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class LotStateDeleted : LotStateEventBase, ILotStateDeleted
	{
		public LotStateDeleted ()
		{
		}

		public LotStateDeleted (LotEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

