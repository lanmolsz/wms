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

	public partial class ShipmentTypeStateDtoWrapper : StateDtoWrapperBase, IShipmentTypeStateDto, IShipmentTypeState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IShipmentTypeState _state;

        public ShipmentTypeStateDtoWrapper()
        {
            this._state = new ShipmentTypeState();
        }

		public ShipmentTypeStateDtoWrapper(IShipmentTypeState state)
		{
            this._state = state;
		}

		public IShipmentTypeState ToShipmentTypeState()
		{
			return this._state;
		}

		public virtual string ShipmentTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShipmentTypeId"))
                {
                    return _state.ShipmentTypeId;
                }
                return null;
            }
            set
            {
                _state.ShipmentTypeId = value;
            }
        }

        string IShipmentTypeStateProperties.ShipmentTypeId
        {
            get 
            {
                return (this._state as IShipmentTypeStateProperties).ShipmentTypeId;
            }
            set 
            {
                (this._state as IShipmentTypeStateProperties).ShipmentTypeId = value;
            }
        }

		public virtual string ParentTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ParentTypeId"))
                {
                    return _state.ParentTypeId;
                }
                return null;
            }
            set
            {
                _state.ParentTypeId = value;
            }
        }

        string IShipmentTypeStateProperties.ParentTypeId
        {
            get 
            {
                return (this._state as IShipmentTypeStateProperties).ParentTypeId;
            }
            set 
            {
                (this._state as IShipmentTypeStateProperties).ParentTypeId = value;
            }
        }

		public virtual string HasTable
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("HasTable"))
                {
                    return _state.HasTable;
                }
                return null;
            }
            set
            {
                _state.HasTable = value;
            }
        }

        string IShipmentTypeStateProperties.HasTable
        {
            get 
            {
                return (this._state as IShipmentTypeStateProperties).HasTable;
            }
            set 
            {
                (this._state as IShipmentTypeStateProperties).HasTable = value;
            }
        }

		public virtual string Description
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Description"))
                {
                    return _state.Description;
                }
                return null;
            }
            set
            {
                _state.Description = value;
            }
        }

        string IShipmentTypeStateProperties.Description
        {
            get 
            {
                return (this._state as IShipmentTypeStateProperties).Description;
            }
            set 
            {
                (this._state as IShipmentTypeStateProperties).Description = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IShipmentTypeStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IShipmentTypeStateProperties).Active = value.Value;
                }
            }
        }

        bool IShipmentTypeStateProperties.Active
        {
            get 
            {
                return (this._state as IShipmentTypeStateProperties).Active;
            }
            set 
            {
                (this._state as IShipmentTypeStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IShipmentTypeStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IShipmentTypeStateProperties).Version = value.Value;
                }
            }
        }

        long IShipmentTypeStateProperties.Version
        {
            get 
            {
                return (this._state as IShipmentTypeStateProperties).Version;
            }
            set 
            {
                (this._state as IShipmentTypeStateProperties).Version = value;
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
			get { return (_state as IShipmentTypeState).GlobalId; }
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
            get { return (_state as IShipmentTypeState).CreatedBy; }
            set { (_state as IShipmentTypeState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IShipmentTypeState).CreatedAt; }
            set { (_state as IShipmentTypeState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IShipmentTypeState).UpdatedBy; }
            set { (_state as IShipmentTypeState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IShipmentTypeState).UpdatedAt; }
            set { (_state as IShipmentTypeState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IShipmentTypeStateProperties).Version; }
		}

		#endregion

        bool IShipmentTypeState.IsUnsaved
        {
            get { return this.Version == ShipmentTypeState.VersionZero; }
        }

		void IShipmentTypeState.When(IShipmentTypeStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IShipmentTypeState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

        public virtual string CommandId
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CommandId"))
                {
                    return _state.CommandId; 
                }
                return null;
            }
            set { _state.CommandId = value; }
        }

		void IShipmentTypeState.When(IShipmentTypeStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IShipmentTypeState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class ShipmentTypeStateDtoWrapperCollection : StateDtoWrapperCollectionBase<ShipmentTypeStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(ShipmentTypeStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

