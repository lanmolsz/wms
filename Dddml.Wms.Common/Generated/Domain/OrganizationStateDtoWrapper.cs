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

	public partial class OrganizationStateDtoWrapper : StateDtoWrapperBase, IOrganizationStateDto, IOrganizationState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IOrganizationState _state;

        public OrganizationStateDtoWrapper()
        {
            this._state = new OrganizationState();
        }

		public OrganizationStateDtoWrapper(IOrganizationState state)
		{
            this._state = state;
		}

		public IOrganizationState ToOrganizationState()
		{
			return this._state;
		}

		public virtual string OrganizationId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrganizationId"))
                {
                    return _state.OrganizationId;
                }
                return null;
            }
            set
            {
                _state.OrganizationId = value;
            }
        }

        string IOrganizationStateProperties.OrganizationId
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).OrganizationId;
            }
            set 
            {
                (this._state as IOrganizationStateProperties).OrganizationId = value;
            }
        }

		public virtual string Name
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Name"))
                {
                    return _state.Name;
                }
                return null;
            }
            set
            {
                _state.Name = value;
            }
        }

        string IOrganizationStateProperties.Name
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).Name;
            }
            set 
            {
                (this._state as IOrganizationStateProperties).Name = value;
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

        string IOrganizationStateProperties.Description
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).Description;
            }
            set 
            {
                (this._state as IOrganizationStateProperties).Description = value;
            }
        }

		public virtual string Type
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Type"))
                {
                    return _state.Type;
                }
                return null;
            }
            set
            {
                _state.Type = value;
            }
        }

        string IOrganizationStateProperties.Type
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).Type;
            }
            set 
            {
                (this._state as IOrganizationStateProperties).Type = value;
            }
        }

		public virtual bool? IsSummary
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsSummary"))
                {
                    return _state.IsSummary;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsSummary = value.Value;
                }
            }
        }

        bool IOrganizationStateProperties.IsSummary
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).IsSummary;
            }
            set 
            {
                (this._state as IOrganizationStateProperties).IsSummary = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IOrganizationStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IOrganizationStateProperties).Active = value.Value;
                }
            }
        }

        bool IOrganizationStateProperties.Active
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).Active;
            }
            set 
            {
                (this._state as IOrganizationStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IOrganizationStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IOrganizationStateProperties).Version = value.Value;
                }
            }
        }

        long IOrganizationStateProperties.Version
        {
            get 
            {
                return (this._state as IOrganizationStateProperties).Version;
            }
            set 
            {
                (this._state as IOrganizationStateProperties).Version = value;
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
			get { return (_state as IOrganizationState).GlobalId; }
		}

		#endregion


		#region IActive implementation

		bool IActive.Active
		{
            get { return (_state as IActive).Active; }
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
            get { return (_state as IOrganizationState).CreatedBy; }
            set { (_state as IOrganizationState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IOrganizationState).CreatedAt; }
            set { (_state as IOrganizationState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IOrganizationState).UpdatedBy; }
            set { (_state as IOrganizationState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IOrganizationState).UpdatedAt; }
            set { (_state as IOrganizationState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return (_state as IOrganizationStateProperties).Version; }
		}

		#endregion

        bool IOrganizationState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == OrganizationState.VersionZero; }
        }


		void IOrganizationState.When(IOrganizationStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IOrganizationState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IOrganizationState.When(IOrganizationStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IOrganizationState.When(IOrganizationStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IOrganizationState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class OrganizationStateDtoWrapperCollection : StateDtoWrapperCollectionBase<OrganizationStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(OrganizationStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

