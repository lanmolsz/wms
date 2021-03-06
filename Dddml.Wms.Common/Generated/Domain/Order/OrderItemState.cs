﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public partial class OrderItemState : OrderItemStateProperties, IOrderItemState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		#region IIdentity implementation

        private OrderItemId _orderItemId = new OrderItemId();

        public virtual OrderItemId OrderItemId 
        {
            get { return this._orderItemId; }
            set { this._orderItemId = value; }
        }

		OrderItemId IGlobalIdentity<OrderItemId>.GlobalId {
			get {
				return  this.OrderItemId;
			}
		}

        string ILocalIdentity<string>.LocalId
        {
            get
            {
                return this.OrderItemSeqId;
            }
        }


        public override string OrderId {
			get {
				return this.OrderItemId.OrderId;
			}
			set {
				this.OrderItemId.OrderId = value;
			}
		}

        public override string OrderItemSeqId {
			get {
				return this.OrderItemId.OrderItemSeqId;
			}
			set {
				this.OrderItemId.OrderItemSeqId = value;
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

        bool IOrderItemState.IsUnsaved
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

        public OrderItemState() : this(false)
        {
        }

        public OrderItemState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IOrderItemStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.ProductId = e.ProductId;

			this.ExternalProductId = e.ExternalProductId;

			this.Quantity = e.Quantity;

			this.CancelQuantity = e.CancelQuantity;

			this.SelectedAmount = e.SelectedAmount;

			this.ExternalId = e.ExternalId;

			this.OrderItemTypeId = e.OrderItemTypeId;

			this.OrderItemGroupSeqId = e.OrderItemGroupSeqId;

			this.IsItemGroupPrimary = e.IsItemGroupPrimary;

			this.FromInventoryItemId = e.FromInventoryItemId;

			this.IsPromo = e.IsPromo;

			this.QuoteId = e.QuoteId;

			this.QuoteItemSeqId = e.QuoteItemSeqId;

			this.ShoppingListId = e.ShoppingListId;

			this.ShoppingListItemSeqId = e.ShoppingListItemSeqId;

			this.UnitPrice = e.UnitPrice;

			this.UnitListPrice = e.UnitListPrice;

			this.UnitAverageCost = e.UnitAverageCost;

			this.UnitRecurringPrice = e.UnitRecurringPrice;

			this.IsModifiedPrice = e.IsModifiedPrice;

			this.RecurringFreqUomId = e.RecurringFreqUomId;

			this.ItemDescription = e.ItemDescription;

			this.Comments = e.Comments;

			this.CorrespondingPoId = e.CorrespondingPoId;

			this.StatusId = e.StatusId;

			this.SyncStatusId = e.SyncStatusId;

			this.EstimatedShipDate = e.EstimatedShipDate;

			this.EstimatedDeliveryDate = e.EstimatedDeliveryDate;

			this.AutoCancelDate = e.AutoCancelDate;

			this.DontCancelSetDate = e.DontCancelSetDate;

			this.DontCancelSetBy = e.DontCancelSetBy;

			this.ShipBeforeDate = e.ShipBeforeDate;

			this.ShipAfterDate = e.ShipAfterDate;

			this.CancelBackOrderDate = e.CancelBackOrderDate;

			this.OverrideGlAccountId = e.OverrideGlAccountId;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IOrderItemStateMergePatched e)
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

			if (e.ExternalProductId == null)
			{
				if (e.IsPropertyExternalProductIdRemoved)
				{
					this.ExternalProductId = default(string);
				}
			}
			else
			{
				this.ExternalProductId = e.ExternalProductId;
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

			if (e.CancelQuantity == null)
			{
				if (e.IsPropertyCancelQuantityRemoved)
				{
					this.CancelQuantity = default(decimal?);
				}
			}
			else
			{
				this.CancelQuantity = e.CancelQuantity;
			}

			if (e.SelectedAmount == null)
			{
				if (e.IsPropertySelectedAmountRemoved)
				{
					this.SelectedAmount = default(decimal?);
				}
			}
			else
			{
				this.SelectedAmount = e.SelectedAmount;
			}

			if (e.ExternalId == null)
			{
				if (e.IsPropertyExternalIdRemoved)
				{
					this.ExternalId = default(string);
				}
			}
			else
			{
				this.ExternalId = e.ExternalId;
			}

			if (e.OrderItemTypeId == null)
			{
				if (e.IsPropertyOrderItemTypeIdRemoved)
				{
					this.OrderItemTypeId = default(string);
				}
			}
			else
			{
				this.OrderItemTypeId = e.OrderItemTypeId;
			}

			if (e.OrderItemGroupSeqId == null)
			{
				if (e.IsPropertyOrderItemGroupSeqIdRemoved)
				{
					this.OrderItemGroupSeqId = default(string);
				}
			}
			else
			{
				this.OrderItemGroupSeqId = e.OrderItemGroupSeqId;
			}

			if (e.IsItemGroupPrimary == null)
			{
				if (e.IsPropertyIsItemGroupPrimaryRemoved)
				{
					this.IsItemGroupPrimary = default(string);
				}
			}
			else
			{
				this.IsItemGroupPrimary = e.IsItemGroupPrimary;
			}

			if (e.FromInventoryItemId == null)
			{
				if (e.IsPropertyFromInventoryItemIdRemoved)
				{
					this.FromInventoryItemId = default(string);
				}
			}
			else
			{
				this.FromInventoryItemId = e.FromInventoryItemId;
			}

			if (e.IsPromo == null)
			{
				if (e.IsPropertyIsPromoRemoved)
				{
					this.IsPromo = default(string);
				}
			}
			else
			{
				this.IsPromo = e.IsPromo;
			}

			if (e.QuoteId == null)
			{
				if (e.IsPropertyQuoteIdRemoved)
				{
					this.QuoteId = default(string);
				}
			}
			else
			{
				this.QuoteId = e.QuoteId;
			}

			if (e.QuoteItemSeqId == null)
			{
				if (e.IsPropertyQuoteItemSeqIdRemoved)
				{
					this.QuoteItemSeqId = default(string);
				}
			}
			else
			{
				this.QuoteItemSeqId = e.QuoteItemSeqId;
			}

			if (e.ShoppingListId == null)
			{
				if (e.IsPropertyShoppingListIdRemoved)
				{
					this.ShoppingListId = default(string);
				}
			}
			else
			{
				this.ShoppingListId = e.ShoppingListId;
			}

			if (e.ShoppingListItemSeqId == null)
			{
				if (e.IsPropertyShoppingListItemSeqIdRemoved)
				{
					this.ShoppingListItemSeqId = default(string);
				}
			}
			else
			{
				this.ShoppingListItemSeqId = e.ShoppingListItemSeqId;
			}

			if (e.UnitPrice == null)
			{
				if (e.IsPropertyUnitPriceRemoved)
				{
					this.UnitPrice = default(decimal?);
				}
			}
			else
			{
				this.UnitPrice = e.UnitPrice;
			}

			if (e.UnitListPrice == null)
			{
				if (e.IsPropertyUnitListPriceRemoved)
				{
					this.UnitListPrice = default(decimal?);
				}
			}
			else
			{
				this.UnitListPrice = e.UnitListPrice;
			}

			if (e.UnitAverageCost == null)
			{
				if (e.IsPropertyUnitAverageCostRemoved)
				{
					this.UnitAverageCost = default(decimal?);
				}
			}
			else
			{
				this.UnitAverageCost = e.UnitAverageCost;
			}

			if (e.UnitRecurringPrice == null)
			{
				if (e.IsPropertyUnitRecurringPriceRemoved)
				{
					this.UnitRecurringPrice = default(decimal?);
				}
			}
			else
			{
				this.UnitRecurringPrice = e.UnitRecurringPrice;
			}

			if (e.IsModifiedPrice == null)
			{
				if (e.IsPropertyIsModifiedPriceRemoved)
				{
					this.IsModifiedPrice = default(string);
				}
			}
			else
			{
				this.IsModifiedPrice = e.IsModifiedPrice;
			}

			if (e.RecurringFreqUomId == null)
			{
				if (e.IsPropertyRecurringFreqUomIdRemoved)
				{
					this.RecurringFreqUomId = default(string);
				}
			}
			else
			{
				this.RecurringFreqUomId = e.RecurringFreqUomId;
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

			if (e.Comments == null)
			{
				if (e.IsPropertyCommentsRemoved)
				{
					this.Comments = default(string);
				}
			}
			else
			{
				this.Comments = e.Comments;
			}

			if (e.CorrespondingPoId == null)
			{
				if (e.IsPropertyCorrespondingPoIdRemoved)
				{
					this.CorrespondingPoId = default(string);
				}
			}
			else
			{
				this.CorrespondingPoId = e.CorrespondingPoId;
			}

			if (e.StatusId == null)
			{
				if (e.IsPropertyStatusIdRemoved)
				{
					this.StatusId = default(string);
				}
			}
			else
			{
				this.StatusId = e.StatusId;
			}

			if (e.SyncStatusId == null)
			{
				if (e.IsPropertySyncStatusIdRemoved)
				{
					this.SyncStatusId = default(string);
				}
			}
			else
			{
				this.SyncStatusId = e.SyncStatusId;
			}

			if (e.EstimatedShipDate == null)
			{
				if (e.IsPropertyEstimatedShipDateRemoved)
				{
					this.EstimatedShipDate = default(DateTime?);
				}
			}
			else
			{
				this.EstimatedShipDate = e.EstimatedShipDate;
			}

			if (e.EstimatedDeliveryDate == null)
			{
				if (e.IsPropertyEstimatedDeliveryDateRemoved)
				{
					this.EstimatedDeliveryDate = default(DateTime?);
				}
			}
			else
			{
				this.EstimatedDeliveryDate = e.EstimatedDeliveryDate;
			}

			if (e.AutoCancelDate == null)
			{
				if (e.IsPropertyAutoCancelDateRemoved)
				{
					this.AutoCancelDate = default(DateTime?);
				}
			}
			else
			{
				this.AutoCancelDate = e.AutoCancelDate;
			}

			if (e.DontCancelSetDate == null)
			{
				if (e.IsPropertyDontCancelSetDateRemoved)
				{
					this.DontCancelSetDate = default(DateTime?);
				}
			}
			else
			{
				this.DontCancelSetDate = e.DontCancelSetDate;
			}

			if (e.DontCancelSetBy == null)
			{
				if (e.IsPropertyDontCancelSetByRemoved)
				{
					this.DontCancelSetBy = default(string);
				}
			}
			else
			{
				this.DontCancelSetBy = e.DontCancelSetBy;
			}

			if (e.ShipBeforeDate == null)
			{
				if (e.IsPropertyShipBeforeDateRemoved)
				{
					this.ShipBeforeDate = default(DateTime?);
				}
			}
			else
			{
				this.ShipBeforeDate = e.ShipBeforeDate;
			}

			if (e.ShipAfterDate == null)
			{
				if (e.IsPropertyShipAfterDateRemoved)
				{
					this.ShipAfterDate = default(DateTime?);
				}
			}
			else
			{
				this.ShipAfterDate = e.ShipAfterDate;
			}

			if (e.CancelBackOrderDate == null)
			{
				if (e.IsPropertyCancelBackOrderDateRemoved)
				{
					this.CancelBackOrderDate = default(DateTime?);
				}
			}
			else
			{
				this.CancelBackOrderDate = e.CancelBackOrderDate;
			}

			if (e.OverrideGlAccountId == null)
			{
				if (e.IsPropertyOverrideGlAccountIdRemoved)
				{
					this.OverrideGlAccountId = default(string);
				}
			}
			else
			{
				this.OverrideGlAccountId = e.OverrideGlAccountId;
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

        protected void ThrowOnWrongEvent(IOrderItemEvent e)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("OrderItem|");

            var stateEntityIdOrderId = (this as IGlobalIdentity<OrderItemId>).GlobalId.OrderId;
            var eventEntityIdOrderId = e.OrderItemEventId.OrderId;
            if (stateEntityIdOrderId != eventEntityIdOrderId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id OrderId {0} in state but entity id OrderId {1} in event", stateEntityIdOrderId, eventEntityIdOrderId);
            }
            id.Append(stateEntityIdOrderId).Append(",");

            var stateEntityIdOrderItemSeqId = (this as IGlobalIdentity<OrderItemId>).GlobalId.OrderItemSeqId;
            var eventEntityIdOrderItemSeqId = e.OrderItemEventId.OrderItemSeqId;
            if (stateEntityIdOrderItemSeqId != eventEntityIdOrderItemSeqId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id OrderItemSeqId {0} in state but entity id OrderItemSeqId {1} in event", stateEntityIdOrderItemSeqId, eventEntityIdOrderItemSeqId);
            }
            id.Append(stateEntityIdOrderItemSeqId).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var stateEvent = e is IOrderItemStateEvent ? (IOrderItemStateEvent)e : null;
            if (e == null) { return; }
            stateEvent.Version = stateVersion;
            //var stateEventStateVersion = stateEvent.Version;
            //if (OrderItemState.VersionZero == stateEventStateVersion)
            //{
            //    stateEventStateVersion = stateEvent.Version = stateVersion;
            //}
            //if (stateVersion != stateEventStateVersion)
            //{
            //    throw OptimisticConcurrencyException.Create(stateVersion, stateEventStateVersion, id.ToString());
            //}
        }
    }

}

