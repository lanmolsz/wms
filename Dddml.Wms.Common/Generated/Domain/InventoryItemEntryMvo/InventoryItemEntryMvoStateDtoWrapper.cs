﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEntryMvo;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItemEntryMvo
{

	public partial class InventoryItemEntryMvoStateDtoWrapper : StateDtoWrapperBase, IInventoryItemEntryMvoStateDto, IInventoryItemEntryMvoState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IInventoryItemEntryMvoState _state;

        public InventoryItemEntryMvoStateDtoWrapper()
        {
            this._state = new InventoryItemEntryMvoState();
        }

		public InventoryItemEntryMvoStateDtoWrapper(IInventoryItemEntryMvoState state)
		{
            this._state = state;
		}

		public IInventoryItemEntryMvoState ToInventoryItemEntryMvoState()
		{
			return this._state;
		}

		public virtual InventoryItemEntryId InventoryItemEntryId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemEntryId"))
                {
                    return _state.InventoryItemEntryId;
                }
                return null;
            }
            set
            {
                _state.InventoryItemEntryId = value;
            }
        }

        InventoryItemEntryId IInventoryItemEntryMvoStateProperties.InventoryItemEntryId
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemEntryId;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemEntryId = value;
            }
        }

		public virtual decimal? OnHandQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OnHandQuantity"))
                {
                    return _state.OnHandQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.OnHandQuantity = value.Value;
                }
            }
        }

        decimal IInventoryItemEntryMvoStateProperties.OnHandQuantity
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).OnHandQuantity;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).OnHandQuantity = value;
            }
        }

		public virtual decimal? InTransitQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InTransitQuantity"))
                {
                    return _state.InTransitQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InTransitQuantity = value.Value;
                }
            }
        }

        decimal IInventoryItemEntryMvoStateProperties.InTransitQuantity
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InTransitQuantity;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InTransitQuantity = value;
            }
        }

		public virtual decimal? ReservedQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ReservedQuantity"))
                {
                    return _state.ReservedQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.ReservedQuantity = value.Value;
                }
            }
        }

        decimal IInventoryItemEntryMvoStateProperties.ReservedQuantity
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).ReservedQuantity;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).ReservedQuantity = value;
            }
        }

		public virtual decimal? OccupiedQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OccupiedQuantity"))
                {
                    return _state.OccupiedQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.OccupiedQuantity = value.Value;
                }
            }
        }

        decimal IInventoryItemEntryMvoStateProperties.OccupiedQuantity
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).OccupiedQuantity;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).OccupiedQuantity = value;
            }
        }

		public virtual decimal? VirtualQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("VirtualQuantity"))
                {
                    return _state.VirtualQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.VirtualQuantity = value.Value;
                }
            }
        }

        decimal IInventoryItemEntryMvoStateProperties.VirtualQuantity
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).VirtualQuantity;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).VirtualQuantity = value;
            }
        }

		public virtual InventoryItemSourceInfo Source
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Source"))
                {
                    return _state.Source;
                }
                return null;
            }
            set
            {
                _state.Source = value;
            }
        }

        InventoryItemSourceInfo IInventoryItemEntryMvoStateProperties.Source
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).Source;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).Source = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IInventoryItemEntryMvoStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IInventoryItemEntryMvoStateProperties).Version = value.Value;
                }
            }
        }

        long IInventoryItemEntryMvoStateProperties.Version
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).Version;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).Version = value;
            }
        }

		public virtual decimal? InventoryItemOnHandQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemOnHandQuantity"))
                {
                    return _state.InventoryItemOnHandQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemOnHandQuantity = value.Value;
                }
            }
        }

        decimal IInventoryItemEntryMvoStateProperties.InventoryItemOnHandQuantity
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemOnHandQuantity;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemOnHandQuantity = value;
            }
        }

		public virtual decimal? InventoryItemInTransitQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemInTransitQuantity"))
                {
                    return _state.InventoryItemInTransitQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemInTransitQuantity = value.Value;
                }
            }
        }

        decimal IInventoryItemEntryMvoStateProperties.InventoryItemInTransitQuantity
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemInTransitQuantity;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemInTransitQuantity = value;
            }
        }

		public virtual decimal? InventoryItemReservedQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemReservedQuantity"))
                {
                    return _state.InventoryItemReservedQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemReservedQuantity = value.Value;
                }
            }
        }

        decimal IInventoryItemEntryMvoStateProperties.InventoryItemReservedQuantity
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemReservedQuantity;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemReservedQuantity = value;
            }
        }

		public virtual decimal? InventoryItemOccupiedQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemOccupiedQuantity"))
                {
                    return _state.InventoryItemOccupiedQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemOccupiedQuantity = value.Value;
                }
            }
        }

        decimal IInventoryItemEntryMvoStateProperties.InventoryItemOccupiedQuantity
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemOccupiedQuantity;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemOccupiedQuantity = value;
            }
        }

		public virtual decimal? InventoryItemVirtualQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemVirtualQuantity"))
                {
                    return _state.InventoryItemVirtualQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemVirtualQuantity = value.Value;
                }
            }
        }

        decimal IInventoryItemEntryMvoStateProperties.InventoryItemVirtualQuantity
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemVirtualQuantity;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemVirtualQuantity = value;
            }
        }

		public virtual string InventoryItemCreatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemCreatedBy"))
                {
                    return _state.InventoryItemCreatedBy;
                }
                return null;
            }
            set
            {
                _state.InventoryItemCreatedBy = value;
            }
        }

        string IInventoryItemEntryMvoStateProperties.InventoryItemCreatedBy
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemCreatedBy;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemCreatedBy = value;
            }
        }

		public virtual DateTime? InventoryItemCreatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemCreatedAt"))
                {
                    return _state.InventoryItemCreatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.InventoryItemCreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemCreatedAt = value.Value;
                }
            }
        }

        DateTime IInventoryItemEntryMvoStateProperties.InventoryItemCreatedAt
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemCreatedAt;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemCreatedAt = value;
            }
        }

		public virtual string InventoryItemUpdatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemUpdatedBy"))
                {
                    return _state.InventoryItemUpdatedBy;
                }
                return null;
            }
            set
            {
                _state.InventoryItemUpdatedBy = value;
            }
        }

        string IInventoryItemEntryMvoStateProperties.InventoryItemUpdatedBy
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemUpdatedBy;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemUpdatedBy = value;
            }
        }

		public virtual DateTime? InventoryItemUpdatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemUpdatedAt"))
                {
                    return _state.InventoryItemUpdatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.InventoryItemUpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemUpdatedAt = value.Value;
                }
            }
        }

        DateTime IInventoryItemEntryMvoStateProperties.InventoryItemUpdatedAt
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemUpdatedAt;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemUpdatedAt = value;
            }
        }

		public virtual long? InventoryItemVersion
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemVersion"))
                {
                    return _state.InventoryItemVersion;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemVersion = value.Value;
                }
            }
        }

        long IInventoryItemEntryMvoStateProperties.InventoryItemVersion
        {
            get 
            {
                return (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemVersion;
            }
            set 
            {
                (this._state as IInventoryItemEntryMvoStateProperties).InventoryItemVersion = value;
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

		InventoryItemEntryId IGlobalIdentity<InventoryItemEntryId>.GlobalId
		{
			get { return (_state as IInventoryItemEntryMvoState).GlobalId; }
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
            get { return (_state as IInventoryItemEntryMvoState).CreatedBy; }
            set { (_state as IInventoryItemEntryMvoState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IInventoryItemEntryMvoState).CreatedAt; }
            set { (_state as IInventoryItemEntryMvoState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IInventoryItemEntryMvoState).UpdatedBy; }
            set { (_state as IInventoryItemEntryMvoState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IInventoryItemEntryMvoState).UpdatedAt; }
            set { (_state as IInventoryItemEntryMvoState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IInventoryItemEntryMvoStateProperties).InventoryItemVersion; }
		}

		#endregion

        bool IInventoryItemEntryMvoState.IsUnsaved
        {
            get { return this.InventoryItemVersion == InventoryItemEntryMvoState.VersionZero; }
        }

		void IInventoryItemEntryMvoState.When(IInventoryItemEntryMvoStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IInventoryItemEntryMvoState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IInventoryItemEntryMvoState.When(IInventoryItemEntryMvoStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IInventoryItemEntryMvoState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class InventoryItemEntryMvoStateDtoWrapperCollection : StateDtoWrapperCollectionBase<InventoryItemEntryMvoStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(InventoryItemEntryMvoStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

