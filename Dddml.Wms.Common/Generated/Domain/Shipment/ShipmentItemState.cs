﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{

	public partial class ShipmentItemState : ShipmentItemStateProperties, IShipmentItemState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		#region IIdentity implementation

        private ShipmentItemId _shipmentItemId = new ShipmentItemId();

        public virtual ShipmentItemId ShipmentItemId 
        {
            get { return this._shipmentItemId; }
            set { this._shipmentItemId = value; }
        }

		ShipmentItemId IGlobalIdentity<ShipmentItemId>.GlobalId {
			get {
				return  this.ShipmentItemId;
			}
		}

        string ILocalIdentity<string>.LocalId
        {
            get
            {
                return this.ShipmentItemSeqId;
            }
        }


        public override string ShipmentId {
			get {
				return this.ShipmentItemId.ShipmentId;
			}
			set {
				this.ShipmentItemId.ShipmentId = value;
			}
		}

        public override string ShipmentItemSeqId {
			get {
				return this.ShipmentItemId.ShipmentItemSeqId;
			}
			set {
				this.ShipmentItemId.ShipmentItemSeqId = value;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
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

		long IEntityVersioned<long>.EntityVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IShipmentItemState.IsUnsaved
        {
            get { return this.Version == VersionZero; }
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

        public ShipmentItemState() : this(false)
        {
        }

        public ShipmentItemState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IShipmentItemStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.ProductId = e.ProductId;

			this.Quantity = e.Quantity;

			this.ShipmentContentDescription = e.ShipmentContentDescription;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IShipmentItemStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

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

			if (e.Quantity == null)
			{
				if (e.IsPropertyQuantityRemoved)
				{
					this.Quantity = default(decimal?);
				}
			}
			else
			{
				this.Quantity = e.Quantity;
			}

			if (e.ShipmentContentDescription == null)
			{
				if (e.IsPropertyShipmentContentDescriptionRemoved)
				{
					this.ShipmentContentDescription = default(string);
				}
			}
			else
			{
				this.ShipmentContentDescription = e.ShipmentContentDescription;
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


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IShipmentItemStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("ShipmentItem|");

            var stateEntityIdShipmentId = (this as IGlobalIdentity<ShipmentItemId>).GlobalId.ShipmentId;
            var eventEntityIdShipmentId = stateEvent.StateEventId.ShipmentId;
            if (stateEntityIdShipmentId != eventEntityIdShipmentId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id ShipmentId {0} in state but entity id ShipmentId {1} in event", stateEntityIdShipmentId, eventEntityIdShipmentId);
            }
            id.Append(stateEntityIdShipmentId).Append(",");

            var stateEntityIdShipmentItemSeqId = (this as IGlobalIdentity<ShipmentItemId>).GlobalId.ShipmentItemSeqId;
            var eventEntityIdShipmentItemSeqId = stateEvent.StateEventId.ShipmentItemSeqId;
            if (stateEntityIdShipmentItemSeqId != eventEntityIdShipmentItemSeqId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id ShipmentItemSeqId {0} in state but entity id ShipmentItemSeqId {1} in event", stateEntityIdShipmentItemSeqId, eventEntityIdShipmentItemSeqId);
            }
            id.Append(stateEntityIdShipmentItemSeqId).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var eventVersion = stateEvent.Version;
            if (ShipmentItemState.VersionZero == eventVersion)
            {
                eventVersion = stateEvent.Version = stateVersion;
            }
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

