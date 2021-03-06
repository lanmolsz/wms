﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipGroupMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipGroupMvo;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.OrderShipGroupMvo
{

	public partial class OrderShipGroupMvoState : OrderShipGroupMvoStateProperties, IOrderShipGroupMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		OrderShipGroupId IGlobalIdentity<OrderShipGroupId>.GlobalId
		{
			get
			{
				return this.OrderShipGroupId;
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
				return this.OrderVersion;
			}
		}


		#endregion

        bool IOrderShipGroupMvoState.IsUnsaved
        {
            get { return this.OrderVersion == VersionZero; }
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

        public OrderShipGroupMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.OrderShipGroupId = ((IOrderShipGroupMvoEvent)events.First()).OrderShipGroupMvoEventId.OrderShipGroupId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.OrderVersion += 1;
                }
            }
        }

        public OrderShipGroupMvoState() : this(false)
        {
        }

        public OrderShipGroupMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IOrderShipGroupMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.ShipmentMethodTypeId = e.ShipmentMethodTypeId;

			this.SupplierPartyId = e.SupplierPartyId;

			this.VendorPartyId = e.VendorPartyId;

			this.CarrierPartyId = e.CarrierPartyId;

			this.CarrierRoleTypeId = e.CarrierRoleTypeId;

			this.FacilityId = e.FacilityId;

			this.ContactMechId = e.ContactMechId;

			this.TelecomContactMechId = e.TelecomContactMechId;

			this.TrackingNumber = e.TrackingNumber;

			this.ShippingInstructions = e.ShippingInstructions;

			this.MaySplit = e.MaySplit;

			this.GiftMessage = e.GiftMessage;

			this.IsGift = e.IsGift;

			this.ShipAfterDate = e.ShipAfterDate;

			this.ShipByDate = e.ShipByDate;

			this.EstimatedShipDate = e.EstimatedShipDate;

			this.EstimatedDeliveryDate = e.EstimatedDeliveryDate;

			this.PickwaveId = e.PickwaveId;

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.OrderOrderTypeId = e.OrderOrderTypeId;

			this.OrderOrderName = e.OrderOrderName;

			this.OrderExternalId = e.OrderExternalId;

			this.OrderSalesChannelEnumId = e.OrderSalesChannelEnumId;

			this.OrderOrderDate = e.OrderOrderDate;

			this.OrderPriority = e.OrderPriority;

			this.OrderEntryDate = e.OrderEntryDate;

			this.OrderPickSheetPrintedDate = e.OrderPickSheetPrintedDate;

			this.OrderStatusId = e.OrderStatusId;

			this.OrderCurrencyUom = e.OrderCurrencyUom;

			this.OrderSyncStatusId = e.OrderSyncStatusId;

			this.OrderBillingAccountId = e.OrderBillingAccountId;

			this.OrderOriginFacilityId = e.OrderOriginFacilityId;

			this.OrderWebSiteId = e.OrderWebSiteId;

			this.OrderProductStoreId = e.OrderProductStoreId;

			this.OrderTerminalId = e.OrderTerminalId;

			this.OrderTransactionId = e.OrderTransactionId;

			this.OrderAutoOrderShoppingListId = e.OrderAutoOrderShoppingListId;

			this.OrderNeedsInventoryIssuance = e.OrderNeedsInventoryIssuance;

			this.OrderIsRushOrder = e.OrderIsRushOrder;

			this.OrderInternalCode = e.OrderInternalCode;

			this.OrderRemainingSubTotal = e.OrderRemainingSubTotal;

			this.OrderGrandTotal = e.OrderGrandTotal;

			this.OrderInvoicePerShipment = e.OrderInvoicePerShipment;

			this.OrderCreatedBy = e.OrderCreatedBy;

            this.OrderCreatedAt = (e.OrderCreatedAt != null && e.OrderCreatedAt.HasValue) ? e.OrderCreatedAt.Value : default(DateTime);

			this.OrderUpdatedBy = e.OrderUpdatedBy;

            this.OrderUpdatedAt = (e.OrderUpdatedAt != null && e.OrderUpdatedAt.HasValue) ? e.OrderUpdatedAt.Value : default(DateTime);

            this.OrderActive = (e.OrderActive != null && e.OrderActive.HasValue) ? e.OrderActive.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IOrderShipGroupMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.ShipmentMethodTypeId == null)
			{
				if (e.IsPropertyShipmentMethodTypeIdRemoved)
				{
					this.ShipmentMethodTypeId = default(string);
				}
			}
			else
			{
				this.ShipmentMethodTypeId = e.ShipmentMethodTypeId;
			}

			if (e.SupplierPartyId == null)
			{
				if (e.IsPropertySupplierPartyIdRemoved)
				{
					this.SupplierPartyId = default(string);
				}
			}
			else
			{
				this.SupplierPartyId = e.SupplierPartyId;
			}

			if (e.VendorPartyId == null)
			{
				if (e.IsPropertyVendorPartyIdRemoved)
				{
					this.VendorPartyId = default(string);
				}
			}
			else
			{
				this.VendorPartyId = e.VendorPartyId;
			}

			if (e.CarrierPartyId == null)
			{
				if (e.IsPropertyCarrierPartyIdRemoved)
				{
					this.CarrierPartyId = default(string);
				}
			}
			else
			{
				this.CarrierPartyId = e.CarrierPartyId;
			}

			if (e.CarrierRoleTypeId == null)
			{
				if (e.IsPropertyCarrierRoleTypeIdRemoved)
				{
					this.CarrierRoleTypeId = default(string);
				}
			}
			else
			{
				this.CarrierRoleTypeId = e.CarrierRoleTypeId;
			}

			if (e.FacilityId == null)
			{
				if (e.IsPropertyFacilityIdRemoved)
				{
					this.FacilityId = default(string);
				}
			}
			else
			{
				this.FacilityId = e.FacilityId;
			}

			if (e.ContactMechId == null)
			{
				if (e.IsPropertyContactMechIdRemoved)
				{
					this.ContactMechId = default(string);
				}
			}
			else
			{
				this.ContactMechId = e.ContactMechId;
			}

			if (e.TelecomContactMechId == null)
			{
				if (e.IsPropertyTelecomContactMechIdRemoved)
				{
					this.TelecomContactMechId = default(string);
				}
			}
			else
			{
				this.TelecomContactMechId = e.TelecomContactMechId;
			}

			if (e.TrackingNumber == null)
			{
				if (e.IsPropertyTrackingNumberRemoved)
				{
					this.TrackingNumber = default(string);
				}
			}
			else
			{
				this.TrackingNumber = e.TrackingNumber;
			}

			if (e.ShippingInstructions == null)
			{
				if (e.IsPropertyShippingInstructionsRemoved)
				{
					this.ShippingInstructions = default(string);
				}
			}
			else
			{
				this.ShippingInstructions = e.ShippingInstructions;
			}

			if (e.MaySplit == null)
			{
				if (e.IsPropertyMaySplitRemoved)
				{
					this.MaySplit = default(string);
				}
			}
			else
			{
				this.MaySplit = e.MaySplit;
			}

			if (e.GiftMessage == null)
			{
				if (e.IsPropertyGiftMessageRemoved)
				{
					this.GiftMessage = default(string);
				}
			}
			else
			{
				this.GiftMessage = e.GiftMessage;
			}

			if (e.IsGift == null)
			{
				if (e.IsPropertyIsGiftRemoved)
				{
					this.IsGift = default(string);
				}
			}
			else
			{
				this.IsGift = e.IsGift;
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

			if (e.ShipByDate == null)
			{
				if (e.IsPropertyShipByDateRemoved)
				{
					this.ShipByDate = default(DateTime?);
				}
			}
			else
			{
				this.ShipByDate = e.ShipByDate;
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

			if (e.PickwaveId == null)
			{
				if (e.IsPropertyPickwaveIdRemoved)
				{
					this.PickwaveId = default(long?);
				}
			}
			else
			{
				this.PickwaveId = e.PickwaveId;
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

			if (e.OrderOrderTypeId == null)
			{
				if (e.IsPropertyOrderOrderTypeIdRemoved)
				{
					this.OrderOrderTypeId = default(string);
				}
			}
			else
			{
				this.OrderOrderTypeId = e.OrderOrderTypeId;
			}

			if (e.OrderOrderName == null)
			{
				if (e.IsPropertyOrderOrderNameRemoved)
				{
					this.OrderOrderName = default(string);
				}
			}
			else
			{
				this.OrderOrderName = e.OrderOrderName;
			}

			if (e.OrderExternalId == null)
			{
				if (e.IsPropertyOrderExternalIdRemoved)
				{
					this.OrderExternalId = default(string);
				}
			}
			else
			{
				this.OrderExternalId = e.OrderExternalId;
			}

			if (e.OrderSalesChannelEnumId == null)
			{
				if (e.IsPropertyOrderSalesChannelEnumIdRemoved)
				{
					this.OrderSalesChannelEnumId = default(string);
				}
			}
			else
			{
				this.OrderSalesChannelEnumId = e.OrderSalesChannelEnumId;
			}

			if (e.OrderOrderDate == null)
			{
				if (e.IsPropertyOrderOrderDateRemoved)
				{
					this.OrderOrderDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderOrderDate = e.OrderOrderDate;
			}

			if (e.OrderPriority == null)
			{
				if (e.IsPropertyOrderPriorityRemoved)
				{
					this.OrderPriority = default(string);
				}
			}
			else
			{
				this.OrderPriority = e.OrderPriority;
			}

			if (e.OrderEntryDate == null)
			{
				if (e.IsPropertyOrderEntryDateRemoved)
				{
					this.OrderEntryDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderEntryDate = e.OrderEntryDate;
			}

			if (e.OrderPickSheetPrintedDate == null)
			{
				if (e.IsPropertyOrderPickSheetPrintedDateRemoved)
				{
					this.OrderPickSheetPrintedDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderPickSheetPrintedDate = e.OrderPickSheetPrintedDate;
			}

			if (e.OrderStatusId == null)
			{
				if (e.IsPropertyOrderStatusIdRemoved)
				{
					this.OrderStatusId = default(string);
				}
			}
			else
			{
				this.OrderStatusId = e.OrderStatusId;
			}

			if (e.OrderCurrencyUom == null)
			{
				if (e.IsPropertyOrderCurrencyUomRemoved)
				{
					this.OrderCurrencyUom = default(string);
				}
			}
			else
			{
				this.OrderCurrencyUom = e.OrderCurrencyUom;
			}

			if (e.OrderSyncStatusId == null)
			{
				if (e.IsPropertyOrderSyncStatusIdRemoved)
				{
					this.OrderSyncStatusId = default(string);
				}
			}
			else
			{
				this.OrderSyncStatusId = e.OrderSyncStatusId;
			}

			if (e.OrderBillingAccountId == null)
			{
				if (e.IsPropertyOrderBillingAccountIdRemoved)
				{
					this.OrderBillingAccountId = default(string);
				}
			}
			else
			{
				this.OrderBillingAccountId = e.OrderBillingAccountId;
			}

			if (e.OrderOriginFacilityId == null)
			{
				if (e.IsPropertyOrderOriginFacilityIdRemoved)
				{
					this.OrderOriginFacilityId = default(string);
				}
			}
			else
			{
				this.OrderOriginFacilityId = e.OrderOriginFacilityId;
			}

			if (e.OrderWebSiteId == null)
			{
				if (e.IsPropertyOrderWebSiteIdRemoved)
				{
					this.OrderWebSiteId = default(string);
				}
			}
			else
			{
				this.OrderWebSiteId = e.OrderWebSiteId;
			}

			if (e.OrderProductStoreId == null)
			{
				if (e.IsPropertyOrderProductStoreIdRemoved)
				{
					this.OrderProductStoreId = default(string);
				}
			}
			else
			{
				this.OrderProductStoreId = e.OrderProductStoreId;
			}

			if (e.OrderTerminalId == null)
			{
				if (e.IsPropertyOrderTerminalIdRemoved)
				{
					this.OrderTerminalId = default(string);
				}
			}
			else
			{
				this.OrderTerminalId = e.OrderTerminalId;
			}

			if (e.OrderTransactionId == null)
			{
				if (e.IsPropertyOrderTransactionIdRemoved)
				{
					this.OrderTransactionId = default(string);
				}
			}
			else
			{
				this.OrderTransactionId = e.OrderTransactionId;
			}

			if (e.OrderAutoOrderShoppingListId == null)
			{
				if (e.IsPropertyOrderAutoOrderShoppingListIdRemoved)
				{
					this.OrderAutoOrderShoppingListId = default(string);
				}
			}
			else
			{
				this.OrderAutoOrderShoppingListId = e.OrderAutoOrderShoppingListId;
			}

			if (e.OrderNeedsInventoryIssuance == null)
			{
				if (e.IsPropertyOrderNeedsInventoryIssuanceRemoved)
				{
					this.OrderNeedsInventoryIssuance = default(string);
				}
			}
			else
			{
				this.OrderNeedsInventoryIssuance = e.OrderNeedsInventoryIssuance;
			}

			if (e.OrderIsRushOrder == null)
			{
				if (e.IsPropertyOrderIsRushOrderRemoved)
				{
					this.OrderIsRushOrder = default(string);
				}
			}
			else
			{
				this.OrderIsRushOrder = e.OrderIsRushOrder;
			}

			if (e.OrderInternalCode == null)
			{
				if (e.IsPropertyOrderInternalCodeRemoved)
				{
					this.OrderInternalCode = default(string);
				}
			}
			else
			{
				this.OrderInternalCode = e.OrderInternalCode;
			}

			if (e.OrderRemainingSubTotal == null)
			{
				if (e.IsPropertyOrderRemainingSubTotalRemoved)
				{
					this.OrderRemainingSubTotal = default(decimal?);
				}
			}
			else
			{
				this.OrderRemainingSubTotal = e.OrderRemainingSubTotal;
			}

			if (e.OrderGrandTotal == null)
			{
				if (e.IsPropertyOrderGrandTotalRemoved)
				{
					this.OrderGrandTotal = default(decimal?);
				}
			}
			else
			{
				this.OrderGrandTotal = e.OrderGrandTotal;
			}

			if (e.OrderInvoicePerShipment == null)
			{
				if (e.IsPropertyOrderInvoicePerShipmentRemoved)
				{
					this.OrderInvoicePerShipment = default(string);
				}
			}
			else
			{
				this.OrderInvoicePerShipment = e.OrderInvoicePerShipment;
			}

			if (e.OrderCreatedBy == null)
			{
				if (e.IsPropertyOrderCreatedByRemoved)
				{
					this.OrderCreatedBy = default(string);
				}
			}
			else
			{
				this.OrderCreatedBy = e.OrderCreatedBy;
			}

			if (e.OrderCreatedAt == null)
			{
				if (e.IsPropertyOrderCreatedAtRemoved)
				{
					this.OrderCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.OrderCreatedAt = (e.OrderCreatedAt != null && e.OrderCreatedAt.HasValue) ? e.OrderCreatedAt.Value : default(DateTime);
			}

			if (e.OrderUpdatedBy == null)
			{
				if (e.IsPropertyOrderUpdatedByRemoved)
				{
					this.OrderUpdatedBy = default(string);
				}
			}
			else
			{
				this.OrderUpdatedBy = e.OrderUpdatedBy;
			}

			if (e.OrderUpdatedAt == null)
			{
				if (e.IsPropertyOrderUpdatedAtRemoved)
				{
					this.OrderUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.OrderUpdatedAt = (e.OrderUpdatedAt != null && e.OrderUpdatedAt.HasValue) ? e.OrderUpdatedAt.Value : default(DateTime);
			}

			if (e.OrderActive == null)
			{
				if (e.IsPropertyOrderActiveRemoved)
				{
					this.OrderActive = default(bool);
				}
			}
			else
			{
				this.OrderActive = (e.OrderActive != null && e.OrderActive.HasValue) ? e.OrderActive.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IOrderShipGroupMvoStateDeleted e)
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

        protected void ThrowOnWrongEvent(IOrderShipGroupMvoEvent e)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("OrderShipGroupMvo|");

            var stateEntityId = this.OrderShipGroupId; // Aggregate Id
            var eventEntityId = e.OrderShipGroupMvoEventId.OrderShipGroupId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.OrderVersion;
            var eventVersion = e.OrderShipGroupMvoEventId.OrderVersion;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

