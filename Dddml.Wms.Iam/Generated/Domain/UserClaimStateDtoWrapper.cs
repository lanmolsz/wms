﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public partial class UserClaimStateDtoWrapper : StateDtoWrapperBase, IUserClaimStateDto, IUserClaimState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IUserClaimState _state;

        public UserClaimStateDtoWrapper()
        {
            this._state = new UserClaimState();
        }

		public UserClaimStateDtoWrapper(IUserClaimState state)
		{
            this._state = state;
		}

		public IUserClaimState ToUserClaimState()
		{
			return this._state;
		}

		public virtual int? ClaimId
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ClaimId"))
                {
                    return _state.ClaimId;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.ClaimId = value.Value;
                }
            }
        }

        int IUserClaimStateProperties.ClaimId
        {
            get 
            {
                return (this._state as IUserClaimStateProperties).ClaimId;
            }
            set 
            {
                (this._state as IUserClaimStateProperties).ClaimId = value;
            }
        }

		public virtual string ClaimType
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ClaimType"))
                {
                    return _state.ClaimType;
                }
                return null;
            }
            set
            {
                _state.ClaimType = value;
            }
        }

        string IUserClaimStateProperties.ClaimType
        {
            get 
            {
                return (this._state as IUserClaimStateProperties).ClaimType;
            }
            set 
            {
                (this._state as IUserClaimStateProperties).ClaimType = value;
            }
        }

		public virtual string ClaimValue
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ClaimValue"))
                {
                    return _state.ClaimValue;
                }
                return null;
            }
            set
            {
                _state.ClaimValue = value;
            }
        }

        string IUserClaimStateProperties.ClaimValue
        {
            get 
            {
                return (this._state as IUserClaimStateProperties).ClaimValue;
            }
            set 
            {
                (this._state as IUserClaimStateProperties).ClaimValue = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IUserClaimStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IUserClaimStateProperties).Active = value.Value;
                }
            }
        }

        bool IUserClaimStateProperties.Active
        {
            get 
            {
                return (this._state as IUserClaimStateProperties).Active;
            }
            set 
            {
                (this._state as IUserClaimStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IUserClaimStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IUserClaimStateProperties).Version = value.Value;
                }
            }
        }

        long IUserClaimStateProperties.Version
        {
            get 
            {
                return (this._state as IUserClaimStateProperties).Version;
            }
            set 
            {
                (this._state as IUserClaimStateProperties).Version = value;
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

        string IUserClaimStateProperties.UserId
        {
            get 
            {
                return (this._state as IUserClaimStateProperties).UserId;
            }
            set 
            {
                (this._state as IUserClaimStateProperties).UserId = value;
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


		UserClaimId IGlobalIdentity<UserClaimId>.GlobalId {
			get { return (_state as IUserClaimState).GlobalId; }
		}

        int ILocalIdentity<int>.LocalId
        {
			get { return (_state as IUserClaimState).LocalId; }
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
            get { return (_state as IUserClaimState).CreatedBy; }
            set { (_state as IUserClaimState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IUserClaimState).CreatedAt; }
            set { (_state as IUserClaimState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IUserClaimState).UpdatedBy; }
            set { (_state as IUserClaimState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IUserClaimState).UpdatedAt; }
            set { (_state as IUserClaimState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IEntityVersioned<long>.EntityVersion
		{
            get { return (_state as IUserClaimStateProperties).Version; }
		}

		#endregion

        bool IUserClaimState.IsUnsaved
        {
            get { return this.Version == UserClaimState.VersionZero; }
        }

		void IUserClaimState.When(IUserClaimStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IUserClaimState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IUserClaimState.When(IUserClaimStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IUserClaimState.When(IUserClaimStateRemoved e)
		{
            throw new NotSupportedException();
		}

		void IUserClaimState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class UserClaimStateDtoWrapperCollection : StateDtoWrapperCollectionBase<UserClaimStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(UserClaimStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

