﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

	public partial class UserPermissionStateDtoWrapper : StateDtoWrapperBase, IUserPermissionStateDto, IUserPermissionState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IUserPermissionState _state;

        public UserPermissionStateDtoWrapper()
        {
            this._state = new UserPermissionState();
        }

		public UserPermissionStateDtoWrapper(IUserPermissionState state)
		{
            this._state = state;
		}

		public IUserPermissionState ToUserPermissionState()
		{
			return this._state;
		}

		public virtual string PermissionId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PermissionId"))
                {
                    return _state.PermissionId;
                }
                return null;
            }
            set
            {
                _state.PermissionId = value;
            }
        }

        string IUserPermissionStateProperties.PermissionId
        {
            get 
            {
                return (this._state as IUserPermissionStateProperties).PermissionId;
            }
            set 
            {
                (this._state as IUserPermissionStateProperties).PermissionId = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IUserPermissionStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IUserPermissionStateProperties).Active = value.Value;
                }
            }
        }

        bool IUserPermissionStateProperties.Active
        {
            get 
            {
                return (this._state as IUserPermissionStateProperties).Active;
            }
            set 
            {
                (this._state as IUserPermissionStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IUserPermissionStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IUserPermissionStateProperties).Version = value.Value;
                }
            }
        }

        long IUserPermissionStateProperties.Version
        {
            get 
            {
                return (this._state as IUserPermissionStateProperties).Version;
            }
            set 
            {
                (this._state as IUserPermissionStateProperties).Version = value;
            }
        }

		public virtual string UserId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserId"))
                {
                    return _state.UserId;
                }
                return null;
            }
            set
            {
                _state.UserId = value;
            }
        }

        string IUserPermissionStateProperties.UserId
        {
            get 
            {
                return (this._state as IUserPermissionStateProperties).UserId;
            }
            set 
            {
                (this._state as IUserPermissionStateProperties).UserId = value;
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


		UserPermissionId IGlobalIdentity<UserPermissionId>.GlobalId {
			get { return (_state as IUserPermissionState).GlobalId; }
		}

        string ILocalIdentity<string>.LocalId
        {
			get { return (_state as IUserPermissionState).LocalId; }
        }

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
            return (_state as IActive).IsActive();
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
            get { return (_state as IDeleted).Deleted; }
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
            get { return (_state as IUserPermissionState).CreatedBy; }
            set { (_state as IUserPermissionState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IUserPermissionState).CreatedAt; }
            set { (_state as IUserPermissionState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IUserPermissionState).UpdatedBy; }
            set { (_state as IUserPermissionState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IUserPermissionState).UpdatedAt; }
            set { (_state as IUserPermissionState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IEntityVersioned<long>.EntityVersion
		{
            get { return (_state as IUserPermissionStateProperties).Version; }
		}

		#endregion

        bool IUserPermissionState.IsUnsaved
        {
            get { return this.Version == UserPermissionState.VersionZero; }
        }

		void IUserPermissionState.When(IUserPermissionStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IUserPermissionState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IUserPermissionState.When(IUserPermissionStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IUserPermissionState.When(IUserPermissionStateRemoved e)
		{
            throw new NotSupportedException();
		}

		void IUserPermissionState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class UserPermissionStateDtoWrapperCollection : StateDtoWrapperCollectionBase<UserPermissionStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(UserPermissionStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

