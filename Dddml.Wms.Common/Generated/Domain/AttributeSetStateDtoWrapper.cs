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

	public partial class AttributeSetStateDtoWrapper : StateDtoWrapperBase, IAttributeSetStateDto, IAttributeSetState
	{

        internal static IList<string> _collectionFieldNames = new string[] { "AttributeUses" };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IAttributeSetState _state;

        public AttributeSetStateDtoWrapper()
        {
            this._state = new AttributeSetState();
        }

		public AttributeSetStateDtoWrapper(IAttributeSetState state)
		{
            this._state = state;
		}

		public IAttributeSetState ToAttributeSetState()
		{
			return this._state;
		}

		public virtual string AttributeSetId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeSetId"))
                {
                    return _state.AttributeSetId;
                }
                return null;
            }
            set
            {
                _state.AttributeSetId = value;
            }
        }

        string IAttributeSetStateProperties.AttributeSetId
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).AttributeSetId;
            }
            set 
            {
                (this._state as IAttributeSetStateProperties).AttributeSetId = value;
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

        string IAttributeSetStateProperties.Name
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).Name;
            }
            set 
            {
                (this._state as IAttributeSetStateProperties).Name = value;
            }
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

        string IAttributeSetStateProperties.OrganizationId
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).OrganizationId;
            }
            set 
            {
                (this._state as IAttributeSetStateProperties).OrganizationId = value;
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

        string IAttributeSetStateProperties.Description
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).Description;
            }
            set 
            {
                (this._state as IAttributeSetStateProperties).Description = value;
            }
        }

		public virtual string SerialNumberAttributeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SerialNumberAttributeId"))
                {
                    return _state.SerialNumberAttributeId;
                }
                return null;
            }
            set
            {
                _state.SerialNumberAttributeId = value;
            }
        }

        string IAttributeSetStateProperties.SerialNumberAttributeId
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).SerialNumberAttributeId;
            }
            set 
            {
                (this._state as IAttributeSetStateProperties).SerialNumberAttributeId = value;
            }
        }

		public virtual string LotAttributeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("LotAttributeId"))
                {
                    return _state.LotAttributeId;
                }
                return null;
            }
            set
            {
                _state.LotAttributeId = value;
            }
        }

        string IAttributeSetStateProperties.LotAttributeId
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).LotAttributeId;
            }
            set 
            {
                (this._state as IAttributeSetStateProperties).LotAttributeId = value;
            }
        }

		public virtual string ReferenceId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ReferenceId"))
                {
                    return _state.ReferenceId;
                }
                return null;
            }
            set
            {
                _state.ReferenceId = value;
            }
        }

        string IAttributeSetStateProperties.ReferenceId
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).ReferenceId;
            }
            set 
            {
                (this._state as IAttributeSetStateProperties).ReferenceId = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IAttributeSetStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IAttributeSetStateProperties).Active = value.Value;
                }
            }
        }

        bool IAttributeSetStateProperties.Active
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).Active;
            }
            set 
            {
                (this._state as IAttributeSetStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IAttributeSetStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IAttributeSetStateProperties).Version = value.Value;
                }
            }
        }

        long IAttributeSetStateProperties.Version
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).Version;
            }
            set 
            {
                (this._state as IAttributeSetStateProperties).Version = value;
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
			get { return (_state as IAttributeSetState).GlobalId; }
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
            get { return (_state as IAttributeSetState).CreatedBy; }
            set { (_state as IAttributeSetState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IAttributeSetState).CreatedAt; }
            set { (_state as IAttributeSetState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IAttributeSetState).UpdatedBy; }
            set { (_state as IAttributeSetState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IAttributeSetState).UpdatedAt; }
            set { (_state as IAttributeSetState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IAttributeSetStateProperties).Version; }
		}

		#endregion

        bool IAttributeSetState.IsUnsaved
        {
            get { return this.Version == AttributeSetState.VersionZero; }
        }

        public virtual IAttributeUseStateDto[] AttributeUses
        {
            get 
            {
                if (!(this as IStateDtoWrapper).ReturnedFieldsContains("AttributeUses"))
                {
                    return null;
                }
                var dtos = new List<IAttributeUseStateDto>();
                if (this._state.AttributeUses != null)
                {
                    foreach (var s in this._state.AttributeUses)
                    {
                        var dto = new AttributeUseStateDtoWrapper((AttributeUseState)s);
                        var returnFS = CollectionUtils.DictionaryGetValueIgnoringCase(ReturnedFields, "AttributeUses");
                        if (!String.IsNullOrWhiteSpace(returnFS))
                        {
                            (dto as IStateDtoWrapper).ReturnedFieldsString = returnFS;
                        }
                        else
                        {
                            (dto as IStateDtoWrapper).AllFieldsReturned = this.AllFieldsReturned;
                        }
                        dtos.Add(dto);
                    }
                }
                return dtos.ToArray();
            }
            set 
            {
                if (value == null) { value = new AttributeUseStateDtoWrapper[0]; }
                var states = new List<IAttributeUseState>();
                foreach (var s in value)
                {
                    states.Add(s.ToAttributeUseState());
                }
                this._state.AttributeUses = new DtoAttributeUseStates(this._state, states);
            }
        }

        IAttributeUseStates IAttributeSetState.AttributeUses
        {
            get { return _state.AttributeUses; }
            set { _state.AttributeUses = value; }
        }

		void IAttributeSetState.When(IAttributeSetStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IAttributeSetState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IAttributeSetState.When(IAttributeSetStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IAttributeSetState.When(IAttributeSetStateDeleted e)
		{
            throw new NotSupportedException();
		}

		void IAttributeSetState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

        public class DtoAttributeUseStates : IAttributeUseStates
        {

            private IAttributeSetState _outerState;

            private IEnumerable<IAttributeUseState> _innerStates;

            public DtoAttributeUseStates(IAttributeSetState outerState, IEnumerable<IAttributeUseState> innerStates)
            {
                this._outerState = outerState;
                if (innerStates == null)
                {
                    this._innerStates = new IAttributeUseState[] { };
                }
                else
                {
                    this._innerStates = innerStates;
                }
            }

            public IEnumerator<IAttributeUseState> GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            public IAttributeUseState Get(string attributeId)
            {
                throw new NotSupportedException();
            }

            public IAttributeUseState Get(string attributeId, bool forCreation)
            {
                throw new NotSupportedException();
            }

            public IAttributeUseState Get(string attributeId, bool forCreation, bool nullAllowed)
            {
                throw new NotSupportedException();
            }

            public void Remove(IAttributeUseState state)
            {
                throw new NotSupportedException();
            }

            public void AddToSave(IAttributeUseState state)
            {
                throw new NotSupportedException();
            }

            public void Save()
            {
                throw new NotSupportedException();
            }
        }

	}

    partial class AttributeSetStateDtoWrapperCollection : StateDtoWrapperCollectionBase<AttributeSetStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(AttributeSetStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

