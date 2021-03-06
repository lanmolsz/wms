﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirementEntryMvo;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirementEntryMvo
{

	public partial class InventoryItemRequirementEntryMvoStateDtoWrapper : StateDtoWrapperBase, IInventoryItemRequirementEntryMvoStateDto, IInventoryItemRequirementEntryMvoState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IInventoryItemRequirementEntryMvoState _state;

        public InventoryItemRequirementEntryMvoStateDtoWrapper()
        {
            this._state = new InventoryItemRequirementEntryMvoState();
        }

		public InventoryItemRequirementEntryMvoStateDtoWrapper(IInventoryItemRequirementEntryMvoState state)
		{
            this._state = state;
		}

		public IInventoryItemRequirementEntryMvoState ToInventoryItemRequirementEntryMvoState()
		{
			return this._state;
		}

		public virtual InventoryItemRequirementEntryId InventoryItemRequirementEntryId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemRequirementEntryId"))
                {
                    return _state.InventoryItemRequirementEntryId;
                }
                return null;
            }
            set
            {
                _state.InventoryItemRequirementEntryId = value;
            }
        }

        InventoryItemRequirementEntryId IInventoryItemRequirementEntryMvoStateProperties.InventoryItemRequirementEntryId
        {
            get 
            {
                return (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementEntryId;
            }
            set 
            {
                (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementEntryId = value;
            }
        }

		public virtual decimal? Quantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Quantity"))
                {
                    return _state.Quantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Quantity = value.Value;
                }
            }
        }

        decimal IInventoryItemRequirementEntryMvoStateProperties.Quantity
        {
            get 
            {
                return (this._state as IInventoryItemRequirementEntryMvoStateProperties).Quantity;
            }
            set 
            {
                (this._state as IInventoryItemRequirementEntryMvoStateProperties).Quantity = value;
            }
        }

		public virtual InventoryPRTriggeredId SourceEventId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SourceEventId"))
                {
                    return _state.SourceEventId;
                }
                return null;
            }
            set
            {
                _state.SourceEventId = value;
            }
        }

        InventoryPRTriggeredId IInventoryItemRequirementEntryMvoStateProperties.SourceEventId
        {
            get 
            {
                return (this._state as IInventoryItemRequirementEntryMvoStateProperties).SourceEventId;
            }
            set 
            {
                (this._state as IInventoryItemRequirementEntryMvoStateProperties).SourceEventId = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IInventoryItemRequirementEntryMvoStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IInventoryItemRequirementEntryMvoStateProperties).Version = value.Value;
                }
            }
        }

        long IInventoryItemRequirementEntryMvoStateProperties.Version
        {
            get 
            {
                return (this._state as IInventoryItemRequirementEntryMvoStateProperties).Version;
            }
            set 
            {
                (this._state as IInventoryItemRequirementEntryMvoStateProperties).Version = value;
            }
        }

		public virtual decimal? InventoryItemRequirementQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemRequirementQuantity"))
                {
                    return _state.InventoryItemRequirementQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemRequirementQuantity = value.Value;
                }
            }
        }

        decimal IInventoryItemRequirementEntryMvoStateProperties.InventoryItemRequirementQuantity
        {
            get 
            {
                return (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementQuantity;
            }
            set 
            {
                (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementQuantity = value;
            }
        }

		public virtual string InventoryItemRequirementCreatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemRequirementCreatedBy"))
                {
                    return _state.InventoryItemRequirementCreatedBy;
                }
                return null;
            }
            set
            {
                _state.InventoryItemRequirementCreatedBy = value;
            }
        }

        string IInventoryItemRequirementEntryMvoStateProperties.InventoryItemRequirementCreatedBy
        {
            get 
            {
                return (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementCreatedBy;
            }
            set 
            {
                (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementCreatedBy = value;
            }
        }

		public virtual DateTime? InventoryItemRequirementCreatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemRequirementCreatedAt"))
                {
                    return _state.InventoryItemRequirementCreatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.InventoryItemRequirementCreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemRequirementCreatedAt = value.Value;
                }
            }
        }

        DateTime IInventoryItemRequirementEntryMvoStateProperties.InventoryItemRequirementCreatedAt
        {
            get 
            {
                return (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementCreatedAt;
            }
            set 
            {
                (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementCreatedAt = value;
            }
        }

		public virtual string InventoryItemRequirementUpdatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemRequirementUpdatedBy"))
                {
                    return _state.InventoryItemRequirementUpdatedBy;
                }
                return null;
            }
            set
            {
                _state.InventoryItemRequirementUpdatedBy = value;
            }
        }

        string IInventoryItemRequirementEntryMvoStateProperties.InventoryItemRequirementUpdatedBy
        {
            get 
            {
                return (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementUpdatedBy;
            }
            set 
            {
                (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementUpdatedBy = value;
            }
        }

		public virtual DateTime? InventoryItemRequirementUpdatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemRequirementUpdatedAt"))
                {
                    return _state.InventoryItemRequirementUpdatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.InventoryItemRequirementUpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemRequirementUpdatedAt = value.Value;
                }
            }
        }

        DateTime IInventoryItemRequirementEntryMvoStateProperties.InventoryItemRequirementUpdatedAt
        {
            get 
            {
                return (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementUpdatedAt;
            }
            set 
            {
                (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementUpdatedAt = value;
            }
        }

		public virtual long? InventoryItemRequirementVersion
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemRequirementVersion"))
                {
                    return _state.InventoryItemRequirementVersion;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.InventoryItemRequirementVersion = value.Value;
                }
            }
        }

        long IInventoryItemRequirementEntryMvoStateProperties.InventoryItemRequirementVersion
        {
            get 
            {
                return (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementVersion;
            }
            set 
            {
                (this._state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementVersion = value;
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

		InventoryItemRequirementEntryId IGlobalIdentity<InventoryItemRequirementEntryId>.GlobalId
		{
			get { return (_state as IInventoryItemRequirementEntryMvoState).GlobalId; }
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
            get { return (_state as IInventoryItemRequirementEntryMvoState).CreatedBy; }
            set { (_state as IInventoryItemRequirementEntryMvoState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IInventoryItemRequirementEntryMvoState).CreatedAt; }
            set { (_state as IInventoryItemRequirementEntryMvoState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IInventoryItemRequirementEntryMvoState).UpdatedBy; }
            set { (_state as IInventoryItemRequirementEntryMvoState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IInventoryItemRequirementEntryMvoState).UpdatedAt; }
            set { (_state as IInventoryItemRequirementEntryMvoState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IInventoryItemRequirementEntryMvoStateProperties).InventoryItemRequirementVersion; }
		}

		#endregion

        bool IInventoryItemRequirementEntryMvoState.IsUnsaved
        {
            get { return this.InventoryItemRequirementVersion == InventoryItemRequirementEntryMvoState.VersionZero; }
        }

		void IInventoryItemRequirementEntryMvoState.When(IInventoryItemRequirementEntryMvoStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IInventoryItemRequirementEntryMvoState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IInventoryItemRequirementEntryMvoState.When(IInventoryItemRequirementEntryMvoStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IInventoryItemRequirementEntryMvoState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class InventoryItemRequirementEntryMvoStateDtoWrapperCollection : StateDtoWrapperCollectionBase<InventoryItemRequirementEntryMvoStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(InventoryItemRequirementEntryMvoStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

