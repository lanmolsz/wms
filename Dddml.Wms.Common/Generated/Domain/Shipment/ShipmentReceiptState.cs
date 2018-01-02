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

	public partial class ShipmentReceiptState : ShipmentReceiptStateProperties, IShipmentReceiptState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		#region IIdentity implementation

        private ShipmentReceiptId _shipmentReceiptId = new ShipmentReceiptId();

        public virtual ShipmentReceiptId ShipmentReceiptId 
        {
            get { return this._shipmentReceiptId; }
            set { this._shipmentReceiptId = value; }
        }

		ShipmentReceiptId IGlobalIdentity<ShipmentReceiptId>.GlobalId {
			get {
				return  this.ShipmentReceiptId;
			}
		}

        string ILocalIdentity<string>.LocalId
        {
            get
            {
                return this.ReceiptSeqId;
            }
        }


        public override string ShipmentId {
			get {
				return this.ShipmentReceiptId.ShipmentId;
			}
			set {
				this.ShipmentReceiptId.ShipmentId = value;
			}
		}

        public override string ReceiptSeqId {
			get {
				return this.ShipmentReceiptId.ReceiptSeqId;
			}
			set {
				this.ShipmentReceiptId.ReceiptSeqId = value;
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

        bool IShipmentReceiptState.IsUnsaved
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

        public ShipmentReceiptState() : this(false)
        {
        }

        public ShipmentReceiptState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IShipmentReceiptStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.ProductId = e.ProductId;

			this.ShipmentItemSeqId = e.ShipmentItemSeqId;

			this.RejectionReasonId = e.RejectionReasonId;

			this.DamageStatusId = e.DamageStatusId;

			this.DamageReasonId = e.DamageReasonId;

			this.ItemDescription = e.ItemDescription;

			this.AcceptedQuantity = e.AcceptedQuantity;

			this.RejectedQuantity = e.RejectedQuantity;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IShipmentReceiptStateMergePatched e)
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

			if (e.ShipmentItemSeqId == null)
			{
				if (e.IsPropertyShipmentItemSeqIdRemoved)
				{
					this.ShipmentItemSeqId = default(string);
				}
			}
			else
			{
				this.ShipmentItemSeqId = e.ShipmentItemSeqId;
			}

			if (e.RejectionReasonId == null)
			{
				if (e.IsPropertyRejectionReasonIdRemoved)
				{
					this.RejectionReasonId = default(string);
				}
			}
			else
			{
				this.RejectionReasonId = e.RejectionReasonId;
			}

			if (e.DamageStatusId == null)
			{
				if (e.IsPropertyDamageStatusIdRemoved)
				{
					this.DamageStatusId = default(string);
				}
			}
			else
			{
				this.DamageStatusId = e.DamageStatusId;
			}

			if (e.DamageReasonId == null)
			{
				if (e.IsPropertyDamageReasonIdRemoved)
				{
					this.DamageReasonId = default(string);
				}
			}
			else
			{
				this.DamageReasonId = e.DamageReasonId;
			}

			if (e.ItemDescription == null)
			{
				if (e.IsPropertyItemDescriptionRemoved)
				{
					this.ItemDescription = default(string);
				}
			}
			else
			{
				this.ItemDescription = e.ItemDescription;
			}

			if (e.AcceptedQuantity == null)
			{
				if (e.IsPropertyAcceptedQuantityRemoved)
				{
					this.AcceptedQuantity = default(decimal?);
				}
			}
			else
			{
				this.AcceptedQuantity = e.AcceptedQuantity;
			}

			if (e.RejectedQuantity == null)
			{
				if (e.IsPropertyRejectedQuantityRemoved)
				{
					this.RejectedQuantity = default(decimal?);
				}
			}
			else
			{
				this.RejectedQuantity = e.RejectedQuantity;
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

        protected void ThrowOnWrongEvent(IShipmentReceiptStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("ShipmentReceipt|");

            var stateEntityIdShipmentId = (this as IGlobalIdentity<ShipmentReceiptId>).GlobalId.ShipmentId;
            var eventEntityIdShipmentId = stateEvent.StateEventId.ShipmentId;
            if (stateEntityIdShipmentId != eventEntityIdShipmentId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id ShipmentId {0} in state but entity id ShipmentId {1} in event", stateEntityIdShipmentId, eventEntityIdShipmentId);
            }
            id.Append(stateEntityIdShipmentId).Append(",");

            var stateEntityIdReceiptSeqId = (this as IGlobalIdentity<ShipmentReceiptId>).GlobalId.ReceiptSeqId;
            var eventEntityIdReceiptSeqId = stateEvent.StateEventId.ReceiptSeqId;
            if (stateEntityIdReceiptSeqId != eventEntityIdReceiptSeqId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id ReceiptSeqId {0} in state but entity id ReceiptSeqId {1} in event", stateEntityIdReceiptSeqId, eventEntityIdReceiptSeqId);
            }
            id.Append(stateEntityIdReceiptSeqId).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var eventVersion = stateEvent.Version;
            if (ShipmentReceiptState.VersionZero == eventVersion)
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

