﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateStatusItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.StatusItem;

namespace Dddml.Wms.Domain.StatusItem
{

	public partial class StatusItemStateDtoWrapper : StateDtoWrapperBase, IStatusItemStateDto, IStatusItemState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IStatusItemState _state;

        public StatusItemStateDtoWrapper()
        {
            this._state = new StatusItemState();
        }

		public StatusItemStateDtoWrapper(IStatusItemState state)
		{
            this._state = state;
		}

		public IStatusItemState ToStatusItemState()
		{
			return this._state;
		}

		public virtual string StatusId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("StatusId"))
                {
                    return _state.StatusId;
                }
                return null;
            }
            set
            {
                _state.StatusId = value;
            }
        }

        string IStatusItemStateProperties.StatusId
        {
            get 
            {
                return (this._state as IStatusItemStateProperties).StatusId;
            }
            set 
            {
                (this._state as IStatusItemStateProperties).StatusId = value;
            }
        }

		public virtual string StatusTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("StatusTypeId"))
                {
                    return _state.StatusTypeId;
                }
                return null;
            }
            set
            {
                _state.StatusTypeId = value;
            }
        }

        string IStatusItemStateProperties.StatusTypeId
        {
            get 
            {
                return (this._state as IStatusItemStateProperties).StatusTypeId;
            }
            set 
            {
                (this._state as IStatusItemStateProperties).StatusTypeId = value;
            }
        }

		public virtual string StatusCode
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("StatusCode"))
                {
                    return _state.StatusCode;
                }
                return null;
            }
            set
            {
                _state.StatusCode = value;
            }
        }

        string IStatusItemStateProperties.StatusCode
        {
            get 
            {
                return (this._state as IStatusItemStateProperties).StatusCode;
            }
            set 
            {
                (this._state as IStatusItemStateProperties).StatusCode = value;
            }
        }

		public virtual string SequenceId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SequenceId"))
                {
                    return _state.SequenceId;
                }
                return null;
            }
            set
            {
                _state.SequenceId = value;
            }
        }

        string IStatusItemStateProperties.SequenceId
        {
            get 
            {
                return (this._state as IStatusItemStateProperties).SequenceId;
            }
            set 
            {
                (this._state as IStatusItemStateProperties).SequenceId = value;
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

        string IStatusItemStateProperties.Description
        {
            get 
            {
                return (this._state as IStatusItemStateProperties).Description;
            }
            set 
            {
                (this._state as IStatusItemStateProperties).Description = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IStatusItemStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IStatusItemStateProperties).Active = value.Value;
                }
            }
        }

        bool IStatusItemStateProperties.Active
        {
            get 
            {
                return (this._state as IStatusItemStateProperties).Active;
            }
            set 
            {
                (this._state as IStatusItemStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IStatusItemStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IStatusItemStateProperties).Version = value.Value;
                }
            }
        }

        long IStatusItemStateProperties.Version
        {
            get 
            {
                return (this._state as IStatusItemStateProperties).Version;
            }
            set 
            {
                (this._state as IStatusItemStateProperties).Version = value;
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
			get { return (_state as IStatusItemState).GlobalId; }
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
            get { return (_state as IStatusItemState).CreatedBy; }
            set { (_state as IStatusItemState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IStatusItemState).CreatedAt; }
            set { (_state as IStatusItemState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IStatusItemState).UpdatedBy; }
            set { (_state as IStatusItemState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IStatusItemState).UpdatedAt; }
            set { (_state as IStatusItemState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IStatusItemStateProperties).Version; }
		}

		#endregion

        bool IStatusItemState.IsUnsaved
        {
            get { return this.Version == StatusItemState.VersionZero; }
        }

		void IStatusItemState.When(IStatusItemStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IStatusItemState.ForReapplying
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

		void IStatusItemState.When(IStatusItemStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IStatusItemState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class StatusItemStateDtoWrapperCollection : StateDtoWrapperCollectionBase<StatusItemStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(StatusItemStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

