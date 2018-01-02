﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRejectionReasonDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RejectionReason;

namespace Dddml.Wms.Domain.RejectionReason
{

	public partial class RejectionReasonStateDtoWrapper : StateDtoWrapperBase, IRejectionReasonStateDto, IRejectionReasonState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IRejectionReasonState _state;

        public RejectionReasonStateDtoWrapper()
        {
            this._state = new RejectionReasonState();
        }

		public RejectionReasonStateDtoWrapper(IRejectionReasonState state)
		{
            this._state = state;
		}

		public IRejectionReasonState ToRejectionReasonState()
		{
			return this._state;
		}

		public virtual string RejectionReasonId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("RejectionReasonId"))
                {
                    return _state.RejectionReasonId;
                }
                return null;
            }
            set
            {
                _state.RejectionReasonId = value;
            }
        }

        string IRejectionReasonStateProperties.RejectionReasonId
        {
            get 
            {
                return (this._state as IRejectionReasonStateProperties).RejectionReasonId;
            }
            set 
            {
                (this._state as IRejectionReasonStateProperties).RejectionReasonId = value;
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

        string IRejectionReasonStateProperties.Description
        {
            get 
            {
                return (this._state as IRejectionReasonStateProperties).Description;
            }
            set 
            {
                (this._state as IRejectionReasonStateProperties).Description = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IRejectionReasonStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IRejectionReasonStateProperties).Active = value.Value;
                }
            }
        }

        bool IRejectionReasonStateProperties.Active
        {
            get 
            {
                return (this._state as IRejectionReasonStateProperties).Active;
            }
            set 
            {
                (this._state as IRejectionReasonStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IRejectionReasonStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IRejectionReasonStateProperties).Version = value.Value;
                }
            }
        }

        long IRejectionReasonStateProperties.Version
        {
            get 
            {
                return (this._state as IRejectionReasonStateProperties).Version;
            }
            set 
            {
                (this._state as IRejectionReasonStateProperties).Version = value;
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
			get { return (_state as IRejectionReasonState).GlobalId; }
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
            get { return (_state as IRejectionReasonState).CreatedBy; }
            set { (_state as IRejectionReasonState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IRejectionReasonState).CreatedAt; }
            set { (_state as IRejectionReasonState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IRejectionReasonState).UpdatedBy; }
            set { (_state as IRejectionReasonState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IRejectionReasonState).UpdatedAt; }
            set { (_state as IRejectionReasonState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IRejectionReasonStateProperties).Version; }
		}

		#endregion

        bool IRejectionReasonState.IsUnsaved
        {
            get { return this.Version == RejectionReasonState.VersionZero; }
        }

		void IRejectionReasonState.When(IRejectionReasonStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IRejectionReasonState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IRejectionReasonState.When(IRejectionReasonStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IRejectionReasonState.When(IRejectionReasonStateDeleted e)
		{
            throw new NotSupportedException();
		}

		void IRejectionReasonState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class RejectionReasonStateDtoWrapperCollection : StateDtoWrapperCollectionBase<RejectionReasonStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(RejectionReasonStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

