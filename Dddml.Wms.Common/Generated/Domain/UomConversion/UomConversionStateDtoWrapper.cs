﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomConversionDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomConversion;

namespace Dddml.Wms.Domain.UomConversion
{

	public partial class UomConversionStateDtoWrapper : StateDtoWrapperBase, IUomConversionStateDto, IUomConversionState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IUomConversionState _state;

        public UomConversionStateDtoWrapper()
        {
            this._state = new UomConversionState();
        }

		public UomConversionStateDtoWrapper(IUomConversionState state)
		{
            this._state = state;
		}

		public IUomConversionState ToUomConversionState()
		{
			return this._state;
		}

        public UomConversionIdDto UomConversionId
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UomConversionId"))
                {
					return (_state.UomConversionId == null) ? null : new UomConversionIdDtoWrapper(_state.UomConversionId);
                }
                return null;
            }
            set
            {
                _state.UomConversionId = (value == null) ? null : value.ToUomConversionId();
            }
        }

        UomConversionId IUomConversionStateProperties.UomConversionId
        {
            get 
            {
                return (this._state as IUomConversionStateProperties).UomConversionId;
            }
            set 
            {
                (this._state as IUomConversionStateProperties).UomConversionId = value;
            }
        }

		public virtual double? ConversionFactor
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ConversionFactor"))
                {
                    return _state.ConversionFactor;
                }
                return null;
            }
            set
            {
                _state.ConversionFactor = value;
            }
        }

        double? IUomConversionStateProperties.ConversionFactor
        {
            get 
            {
                return (this._state as IUomConversionStateProperties).ConversionFactor;
            }
            set 
            {
                (this._state as IUomConversionStateProperties).ConversionFactor = value;
            }
        }

		public virtual string CustomMethodId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CustomMethodId"))
                {
                    return _state.CustomMethodId;
                }
                return null;
            }
            set
            {
                _state.CustomMethodId = value;
            }
        }

        string IUomConversionStateProperties.CustomMethodId
        {
            get 
            {
                return (this._state as IUomConversionStateProperties).CustomMethodId;
            }
            set 
            {
                (this._state as IUomConversionStateProperties).CustomMethodId = value;
            }
        }

		public virtual long? DecimalScale
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DecimalScale"))
                {
                    return _state.DecimalScale;
                }
                return null;
            }
            set
            {
                _state.DecimalScale = value;
            }
        }

        long? IUomConversionStateProperties.DecimalScale
        {
            get 
            {
                return (this._state as IUomConversionStateProperties).DecimalScale;
            }
            set 
            {
                (this._state as IUomConversionStateProperties).DecimalScale = value;
            }
        }

		public virtual string RoundingMode
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("RoundingMode"))
                {
                    return _state.RoundingMode;
                }
                return null;
            }
            set
            {
                _state.RoundingMode = value;
            }
        }

        string IUomConversionStateProperties.RoundingMode
        {
            get 
            {
                return (this._state as IUomConversionStateProperties).RoundingMode;
            }
            set 
            {
                (this._state as IUomConversionStateProperties).RoundingMode = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IUomConversionStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IUomConversionStateProperties).Active = value.Value;
                }
            }
        }

        bool IUomConversionStateProperties.Active
        {
            get 
            {
                return (this._state as IUomConversionStateProperties).Active;
            }
            set 
            {
                (this._state as IUomConversionStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IUomConversionStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IUomConversionStateProperties).Version = value.Value;
                }
            }
        }

        long IUomConversionStateProperties.Version
        {
            get 
            {
                return (this._state as IUomConversionStateProperties).Version;
            }
            set 
            {
                (this._state as IUomConversionStateProperties).Version = value;
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

		UomConversionId IGlobalIdentity<UomConversionId>.GlobalId
		{
			get { return (_state as IUomConversionState).GlobalId; }
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
            get { return (_state as IUomConversionState).CreatedBy; }
            set { (_state as IUomConversionState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IUomConversionState).CreatedAt; }
            set { (_state as IUomConversionState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IUomConversionState).UpdatedBy; }
            set { (_state as IUomConversionState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IUomConversionState).UpdatedAt; }
            set { (_state as IUomConversionState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IUomConversionStateProperties).Version; }
		}

		#endregion

        bool IUomConversionState.IsUnsaved
        {
            get { return this.Version == UomConversionState.VersionZero; }
        }

		void IUomConversionState.When(IUomConversionStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IUomConversionState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IUomConversionState.When(IUomConversionStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IUomConversionState.When(IUomConversionStateDeleted e)
		{
            throw new NotSupportedException();
		}

		void IUomConversionState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class UomConversionStateDtoWrapperCollection : StateDtoWrapperCollectionBase<UomConversionStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(UomConversionStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}
