﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentType;

namespace Dddml.Wms.Domain.ShipmentType
{

	public abstract class ShipmentTypeStateEventBase : IShipmentTypeStateEvent
	{

		public virtual ShipmentTypeStateEventId StateEventId { get; set; }

        public virtual string ShipmentTypeId
        {
            get { return StateEventId.ShipmentTypeId; }
            set { StateEventId.ShipmentTypeId = value; }
        }

		public virtual string ParentTypeId { get; set; }

		public virtual string HasTable { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ShipmentTypeStateEventId IGlobalIdentity<ShipmentTypeStateEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IShipmentTypeStateEvent.ReadOnly
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

        protected ShipmentTypeStateEventBase()
        {
        }

        protected ShipmentTypeStateEventBase(ShipmentTypeStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class ShipmentTypeStateCreated : ShipmentTypeStateEventBase, IShipmentTypeStateCreated
	{
		public ShipmentTypeStateCreated () : this(new ShipmentTypeStateEventId())
		{
		}

		public ShipmentTypeStateCreated (ShipmentTypeStateEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ShipmentTypeStateMergePatched : ShipmentTypeStateEventBase, IShipmentTypeStateMergePatched
	{
		public virtual bool IsPropertyParentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyHasTableRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public ShipmentTypeStateMergePatched ()
		{
		}

		public ShipmentTypeStateMergePatched (ShipmentTypeStateEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}

