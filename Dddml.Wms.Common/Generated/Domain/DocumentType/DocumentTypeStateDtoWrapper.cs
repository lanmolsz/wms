﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDocumentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DocumentType;

namespace Dddml.Wms.Domain.DocumentType
{

	public partial class DocumentTypeStateDtoWrapper : StateDtoWrapperBase, IDocumentTypeStateDto, IDocumentTypeState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IDocumentTypeState _state;

        public DocumentTypeStateDtoWrapper()
        {
            this._state = new DocumentTypeState();
        }

		public DocumentTypeStateDtoWrapper(IDocumentTypeState state)
		{
            this._state = state;
		}

		public IDocumentTypeState ToDocumentTypeState()
		{
			return this._state;
		}

		public virtual string DocumentTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DocumentTypeId"))
                {
                    return _state.DocumentTypeId;
                }
                return null;
            }
            set
            {
                _state.DocumentTypeId = value;
            }
        }

        string IDocumentTypeStateProperties.DocumentTypeId
        {
            get 
            {
                return (this._state as IDocumentTypeStateProperties).DocumentTypeId;
            }
            set 
            {
                (this._state as IDocumentTypeStateProperties).DocumentTypeId = value;
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

        string IDocumentTypeStateProperties.Description
        {
            get 
            {
                return (this._state as IDocumentTypeStateProperties).Description;
            }
            set 
            {
                (this._state as IDocumentTypeStateProperties).Description = value;
            }
        }

		public virtual string ParentDocumentTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ParentDocumentTypeId"))
                {
                    return _state.ParentDocumentTypeId;
                }
                return null;
            }
            set
            {
                _state.ParentDocumentTypeId = value;
            }
        }

        string IDocumentTypeStateProperties.ParentDocumentTypeId
        {
            get 
            {
                return (this._state as IDocumentTypeStateProperties).ParentDocumentTypeId;
            }
            set 
            {
                (this._state as IDocumentTypeStateProperties).ParentDocumentTypeId = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IDocumentTypeStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IDocumentTypeStateProperties).Active = value.Value;
                }
            }
        }

        bool IDocumentTypeStateProperties.Active
        {
            get 
            {
                return (this._state as IDocumentTypeStateProperties).Active;
            }
            set 
            {
                (this._state as IDocumentTypeStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IDocumentTypeStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IDocumentTypeStateProperties).Version = value.Value;
                }
            }
        }

        long IDocumentTypeStateProperties.Version
        {
            get 
            {
                return (this._state as IDocumentTypeStateProperties).Version;
            }
            set 
            {
                (this._state as IDocumentTypeStateProperties).Version = value;
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
			get { return (_state as IDocumentTypeState).GlobalId; }
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
            get { return (_state as IDocumentTypeState).CreatedBy; }
            set { (_state as IDocumentTypeState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IDocumentTypeState).CreatedAt; }
            set { (_state as IDocumentTypeState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IDocumentTypeState).UpdatedBy; }
            set { (_state as IDocumentTypeState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IDocumentTypeState).UpdatedAt; }
            set { (_state as IDocumentTypeState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IDocumentTypeStateProperties).Version; }
		}

		#endregion

        bool IDocumentTypeState.IsUnsaved
        {
            get { return this.Version == DocumentTypeState.VersionZero; }
        }

		void IDocumentTypeState.When(IDocumentTypeStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IDocumentTypeState.ForReapplying
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

		void IDocumentTypeState.When(IDocumentTypeStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IDocumentTypeState.When(IDocumentTypeStateDeleted e)
		{
            throw new NotSupportedException();
		}

		void IDocumentTypeState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class DocumentTypeStateDtoWrapperCollection : StateDtoWrapperCollectionBase<DocumentTypeStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(DocumentTypeStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

