﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderHeaderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderHeader;

namespace Dddml.Wms.Domain.OrderHeader
{

	public partial class OrderHeaderStateDtoWrapper : StateDtoWrapperBase, IOrderHeaderStateDto, IOrderHeaderState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IOrderHeaderState _state;

        public OrderHeaderStateDtoWrapper()
        {
            this._state = new OrderHeaderState();
        }

		public OrderHeaderStateDtoWrapper(IOrderHeaderState state)
		{
            this._state = state;
		}

		public IOrderHeaderState ToOrderHeaderState()
		{
			return this._state;
		}

		public virtual string OrderId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderId"))
                {
                    return _state.OrderId;
                }
                return null;
            }
            set
            {
                _state.OrderId = value;
            }
        }

        string IOrderHeaderStateProperties.OrderId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).OrderId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).OrderId = value;
            }
        }

		public virtual string OrderTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderTypeId"))
                {
                    return _state.OrderTypeId;
                }
                return null;
            }
            set
            {
                _state.OrderTypeId = value;
            }
        }

        string IOrderHeaderStateProperties.OrderTypeId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).OrderTypeId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).OrderTypeId = value;
            }
        }

		public virtual string OrderName
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderName"))
                {
                    return _state.OrderName;
                }
                return null;
            }
            set
            {
                _state.OrderName = value;
            }
        }

        string IOrderHeaderStateProperties.OrderName
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).OrderName;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).OrderName = value;
            }
        }

		public virtual string ExternalId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ExternalId"))
                {
                    return _state.ExternalId;
                }
                return null;
            }
            set
            {
                _state.ExternalId = value;
            }
        }

        string IOrderHeaderStateProperties.ExternalId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).ExternalId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).ExternalId = value;
            }
        }

		public virtual string SalesChannelEnumId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SalesChannelEnumId"))
                {
                    return _state.SalesChannelEnumId;
                }
                return null;
            }
            set
            {
                _state.SalesChannelEnumId = value;
            }
        }

        string IOrderHeaderStateProperties.SalesChannelEnumId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).SalesChannelEnumId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).SalesChannelEnumId = value;
            }
        }

		public virtual DateTime? OrderDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderDate"))
                {
                    return _state.OrderDate;
                }
                return null;
            }
            set
            {
                _state.OrderDate = value;
            }
        }

        DateTime? IOrderHeaderStateProperties.OrderDate
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).OrderDate;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).OrderDate = value;
            }
        }

		public virtual string Priority
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Priority"))
                {
                    return _state.Priority;
                }
                return null;
            }
            set
            {
                _state.Priority = value;
            }
        }

        string IOrderHeaderStateProperties.Priority
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).Priority;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).Priority = value;
            }
        }

		public virtual DateTime? EntryDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("EntryDate"))
                {
                    return _state.EntryDate;
                }
                return null;
            }
            set
            {
                _state.EntryDate = value;
            }
        }

        DateTime? IOrderHeaderStateProperties.EntryDate
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).EntryDate;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).EntryDate = value;
            }
        }

		public virtual DateTime? PickSheetPrintedDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PickSheetPrintedDate"))
                {
                    return _state.PickSheetPrintedDate;
                }
                return null;
            }
            set
            {
                _state.PickSheetPrintedDate = value;
            }
        }

        DateTime? IOrderHeaderStateProperties.PickSheetPrintedDate
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).PickSheetPrintedDate;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).PickSheetPrintedDate = value;
            }
        }

		public virtual string CurrencyUom
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CurrencyUom"))
                {
                    return _state.CurrencyUom;
                }
                return null;
            }
            set
            {
                _state.CurrencyUom = value;
            }
        }

        string IOrderHeaderStateProperties.CurrencyUom
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).CurrencyUom;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).CurrencyUom = value;
            }
        }

		public virtual string SyncStatusId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SyncStatusId"))
                {
                    return _state.SyncStatusId;
                }
                return null;
            }
            set
            {
                _state.SyncStatusId = value;
            }
        }

        string IOrderHeaderStateProperties.SyncStatusId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).SyncStatusId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).SyncStatusId = value;
            }
        }

		public virtual string BillingAccountId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("BillingAccountId"))
                {
                    return _state.BillingAccountId;
                }
                return null;
            }
            set
            {
                _state.BillingAccountId = value;
            }
        }

        string IOrderHeaderStateProperties.BillingAccountId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).BillingAccountId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).BillingAccountId = value;
            }
        }

		public virtual string OriginFacilityId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OriginFacilityId"))
                {
                    return _state.OriginFacilityId;
                }
                return null;
            }
            set
            {
                _state.OriginFacilityId = value;
            }
        }

        string IOrderHeaderStateProperties.OriginFacilityId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).OriginFacilityId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).OriginFacilityId = value;
            }
        }

		public virtual string WebSiteId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("WebSiteId"))
                {
                    return _state.WebSiteId;
                }
                return null;
            }
            set
            {
                _state.WebSiteId = value;
            }
        }

        string IOrderHeaderStateProperties.WebSiteId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).WebSiteId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).WebSiteId = value;
            }
        }

		public virtual string ProductStoreId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ProductStoreId"))
                {
                    return _state.ProductStoreId;
                }
                return null;
            }
            set
            {
                _state.ProductStoreId = value;
            }
        }

        string IOrderHeaderStateProperties.ProductStoreId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).ProductStoreId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).ProductStoreId = value;
            }
        }

		public virtual string TerminalId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("TerminalId"))
                {
                    return _state.TerminalId;
                }
                return null;
            }
            set
            {
                _state.TerminalId = value;
            }
        }

        string IOrderHeaderStateProperties.TerminalId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).TerminalId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).TerminalId = value;
            }
        }

		public virtual string TransactionId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("TransactionId"))
                {
                    return _state.TransactionId;
                }
                return null;
            }
            set
            {
                _state.TransactionId = value;
            }
        }

        string IOrderHeaderStateProperties.TransactionId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).TransactionId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).TransactionId = value;
            }
        }

		public virtual string AutoOrderShoppingListId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AutoOrderShoppingListId"))
                {
                    return _state.AutoOrderShoppingListId;
                }
                return null;
            }
            set
            {
                _state.AutoOrderShoppingListId = value;
            }
        }

        string IOrderHeaderStateProperties.AutoOrderShoppingListId
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).AutoOrderShoppingListId;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).AutoOrderShoppingListId = value;
            }
        }

		public virtual string NeedsInventoryIssuance
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("NeedsInventoryIssuance"))
                {
                    return _state.NeedsInventoryIssuance;
                }
                return null;
            }
            set
            {
                _state.NeedsInventoryIssuance = value;
            }
        }

        string IOrderHeaderStateProperties.NeedsInventoryIssuance
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).NeedsInventoryIssuance;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).NeedsInventoryIssuance = value;
            }
        }

		public virtual string IsRushOrder
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsRushOrder"))
                {
                    return _state.IsRushOrder;
                }
                return null;
            }
            set
            {
                _state.IsRushOrder = value;
            }
        }

        string IOrderHeaderStateProperties.IsRushOrder
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).IsRushOrder;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).IsRushOrder = value;
            }
        }

		public virtual string InternalCode
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InternalCode"))
                {
                    return _state.InternalCode;
                }
                return null;
            }
            set
            {
                _state.InternalCode = value;
            }
        }

        string IOrderHeaderStateProperties.InternalCode
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).InternalCode;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).InternalCode = value;
            }
        }

		public virtual decimal? RemainingSubTotal
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("RemainingSubTotal"))
                {
                    return _state.RemainingSubTotal;
                }
                return null;
            }
            set
            {
                _state.RemainingSubTotal = value;
            }
        }

        decimal? IOrderHeaderStateProperties.RemainingSubTotal
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).RemainingSubTotal;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).RemainingSubTotal = value;
            }
        }

		public virtual decimal? GrandTotal
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("GrandTotal"))
                {
                    return _state.GrandTotal;
                }
                return null;
            }
            set
            {
                _state.GrandTotal = value;
            }
        }

        decimal? IOrderHeaderStateProperties.GrandTotal
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).GrandTotal;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).GrandTotal = value;
            }
        }

		public virtual string InvoicePerShipment
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InvoicePerShipment"))
                {
                    return _state.InvoicePerShipment;
                }
                return null;
            }
            set
            {
                _state.InvoicePerShipment = value;
            }
        }

        string IOrderHeaderStateProperties.InvoicePerShipment
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).InvoicePerShipment;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).InvoicePerShipment = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IOrderHeaderStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IOrderHeaderStateProperties).Active = value.Value;
                }
            }
        }

        bool IOrderHeaderStateProperties.Active
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).Active;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IOrderHeaderStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IOrderHeaderStateProperties).Version = value.Value;
                }
            }
        }

        long IOrderHeaderStateProperties.Version
        {
            get 
            {
                return (this._state as IOrderHeaderStateProperties).Version;
            }
            set 
            {
                (this._state as IOrderHeaderStateProperties).Version = value;
            }
        }

		public virtual string CreatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CreatedBy"))
                {
                    return _state.CreatedBy;
                }
                return null;
            }
            set
            {
                _state.CreatedBy = value;
            }
        }

		public virtual DateTime? CreatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CreatedAt"))
                {
                    return _state.CreatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.CreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.CreatedAt = value.Value;
                }
            }
        }

		public virtual string UpdatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UpdatedBy"))
                {
                    return _state.UpdatedBy;
                }
                return null;
            }
            set
            {
                _state.UpdatedBy = value;
            }
        }

		public virtual DateTime? UpdatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UpdatedAt"))
                {
                    return _state.UpdatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.UpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UpdatedAt = value.Value;
                }
            }
        }

		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get { return (_state as IOrderHeaderState).GlobalId; }
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
            return (_state as IActive).IsActive();
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
            get { return (_state as IOrderHeaderState).CreatedBy; }
            set { (_state as IOrderHeaderState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IOrderHeaderState).CreatedAt; }
            set { (_state as IOrderHeaderState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IOrderHeaderState).UpdatedBy; }
            set { (_state as IOrderHeaderState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IOrderHeaderState).UpdatedAt; }
            set { (_state as IOrderHeaderState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IOrderHeaderStateProperties).Version; }
		}

		#endregion

        bool IOrderHeaderState.IsUnsaved
        {
            get { return this.Version == OrderHeaderState.VersionZero; }
        }

		void IOrderHeaderState.When(IOrderHeaderStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IOrderHeaderState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IOrderHeaderState.When(IOrderHeaderStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IOrderHeaderState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class OrderHeaderStateDtoWrapperCollection : StateDtoWrapperCollectionBase<OrderHeaderStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(OrderHeaderStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

