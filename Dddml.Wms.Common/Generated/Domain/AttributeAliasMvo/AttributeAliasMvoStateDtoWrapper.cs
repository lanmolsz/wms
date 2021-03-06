﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeAliasMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeAliasMvo;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.AttributeAliasMvo
{

	public partial class AttributeAliasMvoStateDtoWrapper : StateDtoWrapperBase, IAttributeAliasMvoStateDto, IAttributeAliasMvoState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IAttributeAliasMvoState _state;

        public AttributeAliasMvoStateDtoWrapper()
        {
            this._state = new AttributeAliasMvoState();
        }

		public AttributeAliasMvoStateDtoWrapper(IAttributeAliasMvoState state)
		{
            this._state = state;
		}

		public IAttributeAliasMvoState ToAttributeAliasMvoState()
		{
			return this._state;
		}

		public virtual AttributeAliasId AttributeAliasId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeAliasId"))
                {
                    return _state.AttributeAliasId;
                }
                return null;
            }
            set
            {
                _state.AttributeAliasId = value;
            }
        }

        AttributeAliasId IAttributeAliasMvoStateProperties.AttributeAliasId
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeAliasId;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeAliasId = value;
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

        string IAttributeAliasMvoStateProperties.Name
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).Name;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).Name = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IAttributeAliasMvoStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IAttributeAliasMvoStateProperties).Version = value.Value;
                }
            }
        }

        long IAttributeAliasMvoStateProperties.Version
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).Version;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).Version = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IAttributeAliasMvoStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IAttributeAliasMvoStateProperties).Active = value.Value;
                }
            }
        }

        bool IAttributeAliasMvoStateProperties.Active
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).Active;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).Active = value;
            }
        }

		public virtual string AttributeAttributeName
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeAttributeName"))
                {
                    return _state.AttributeAttributeName;
                }
                return null;
            }
            set
            {
                _state.AttributeAttributeName = value;
            }
        }

        string IAttributeAliasMvoStateProperties.AttributeAttributeName
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeAttributeName;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeAttributeName = value;
            }
        }

		public virtual string AttributeOrganizationId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeOrganizationId"))
                {
                    return _state.AttributeOrganizationId;
                }
                return null;
            }
            set
            {
                _state.AttributeOrganizationId = value;
            }
        }

        string IAttributeAliasMvoStateProperties.AttributeOrganizationId
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeOrganizationId;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeOrganizationId = value;
            }
        }

		public virtual string AttributeDescription
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeDescription"))
                {
                    return _state.AttributeDescription;
                }
                return null;
            }
            set
            {
                _state.AttributeDescription = value;
            }
        }

        string IAttributeAliasMvoStateProperties.AttributeDescription
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeDescription;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeDescription = value;
            }
        }

		public virtual bool? AttributeIsMandatory
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeIsMandatory"))
                {
                    return _state.AttributeIsMandatory;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeIsMandatory = value.Value;
                }
            }
        }

        bool IAttributeAliasMvoStateProperties.AttributeIsMandatory
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeIsMandatory;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeIsMandatory = value;
            }
        }

		public virtual string AttributeAttributeValueType
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeAttributeValueType"))
                {
                    return _state.AttributeAttributeValueType;
                }
                return null;
            }
            set
            {
                _state.AttributeAttributeValueType = value;
            }
        }

        string IAttributeAliasMvoStateProperties.AttributeAttributeValueType
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeAttributeValueType;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeAttributeValueType = value;
            }
        }

		public virtual int? AttributeAttributeValueLength
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeAttributeValueLength"))
                {
                    return _state.AttributeAttributeValueLength;
                }
                return null;
            }
            set
            {
                _state.AttributeAttributeValueLength = value;
            }
        }

        int? IAttributeAliasMvoStateProperties.AttributeAttributeValueLength
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeAttributeValueLength;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeAttributeValueLength = value;
            }
        }

		public virtual bool? AttributeIsList
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeIsList"))
                {
                    return _state.AttributeIsList;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeIsList = value.Value;
                }
            }
        }

        bool IAttributeAliasMvoStateProperties.AttributeIsList
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeIsList;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeIsList = value;
            }
        }

		public virtual string AttributeFieldName
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeFieldName"))
                {
                    return _state.AttributeFieldName;
                }
                return null;
            }
            set
            {
                _state.AttributeFieldName = value;
            }
        }

        string IAttributeAliasMvoStateProperties.AttributeFieldName
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeFieldName;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeFieldName = value;
            }
        }

		public virtual string AttributeReferenceId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeReferenceId"))
                {
                    return _state.AttributeReferenceId;
                }
                return null;
            }
            set
            {
                _state.AttributeReferenceId = value;
            }
        }

        string IAttributeAliasMvoStateProperties.AttributeReferenceId
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeReferenceId;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeReferenceId = value;
            }
        }

		public virtual string AttributeCreatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeCreatedBy"))
                {
                    return _state.AttributeCreatedBy;
                }
                return null;
            }
            set
            {
                _state.AttributeCreatedBy = value;
            }
        }

        string IAttributeAliasMvoStateProperties.AttributeCreatedBy
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeCreatedBy;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeCreatedBy = value;
            }
        }

		public virtual DateTime? AttributeCreatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeCreatedAt"))
                {
                    return _state.AttributeCreatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.AttributeCreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeCreatedAt = value.Value;
                }
            }
        }

        DateTime IAttributeAliasMvoStateProperties.AttributeCreatedAt
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeCreatedAt;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeCreatedAt = value;
            }
        }

		public virtual string AttributeUpdatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeUpdatedBy"))
                {
                    return _state.AttributeUpdatedBy;
                }
                return null;
            }
            set
            {
                _state.AttributeUpdatedBy = value;
            }
        }

        string IAttributeAliasMvoStateProperties.AttributeUpdatedBy
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeUpdatedBy;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeUpdatedBy = value;
            }
        }

		public virtual DateTime? AttributeUpdatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeUpdatedAt"))
                {
                    return _state.AttributeUpdatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.AttributeUpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeUpdatedAt = value.Value;
                }
            }
        }

        DateTime IAttributeAliasMvoStateProperties.AttributeUpdatedAt
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeUpdatedAt;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeUpdatedAt = value;
            }
        }

		public virtual bool? AttributeActive
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeActive"))
                {
                    return _state.AttributeActive;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeActive = value.Value;
                }
            }
        }

        bool IAttributeAliasMvoStateProperties.AttributeActive
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeActive;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeActive = value;
            }
        }

		public virtual bool? AttributeDeleted
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeDeleted"))
                {
                    return _state.AttributeDeleted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeDeleted = value.Value;
                }
            }
        }

        bool IAttributeAliasMvoStateProperties.AttributeDeleted
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeDeleted;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeDeleted = value;
            }
        }

		public virtual long? AttributeVersion
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeVersion"))
                {
                    return _state.AttributeVersion;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeVersion = value.Value;
                }
            }
        }

        long IAttributeAliasMvoStateProperties.AttributeVersion
        {
            get 
            {
                return (this._state as IAttributeAliasMvoStateProperties).AttributeVersion;
            }
            set 
            {
                (this._state as IAttributeAliasMvoStateProperties).AttributeVersion = value;
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

		AttributeAliasId IGlobalIdentity<AttributeAliasId>.GlobalId
		{
			get { return (_state as IAttributeAliasMvoState).GlobalId; }
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
            get { return (_state as IAttributeAliasMvoState).CreatedBy; }
            set { (_state as IAttributeAliasMvoState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IAttributeAliasMvoState).CreatedAt; }
            set { (_state as IAttributeAliasMvoState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IAttributeAliasMvoState).UpdatedBy; }
            set { (_state as IAttributeAliasMvoState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IAttributeAliasMvoState).UpdatedAt; }
            set { (_state as IAttributeAliasMvoState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IAttributeAliasMvoStateProperties).AttributeVersion; }
		}

		#endregion

        bool IAttributeAliasMvoState.IsUnsaved
        {
            get { return this.AttributeVersion == AttributeAliasMvoState.VersionZero; }
        }

		void IAttributeAliasMvoState.When(IAttributeAliasMvoStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IAttributeAliasMvoState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IAttributeAliasMvoState.When(IAttributeAliasMvoStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IAttributeAliasMvoState.When(IAttributeAliasMvoStateDeleted e)
		{
            throw new NotSupportedException();
		}

		void IAttributeAliasMvoState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class AttributeAliasMvoStateDtoWrapperCollection : StateDtoWrapperCollectionBase<AttributeAliasMvoStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(AttributeAliasMvoStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

