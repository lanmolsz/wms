﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

	public partial class InOutLineStateDtoWrapper : StateDtoWrapperBase, IInOutLineStateDto, IInOutLineState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IInOutLineState _state;

        public InOutLineStateDtoWrapper()
        {
            this._state = new InOutLineState();
        }

		public InOutLineStateDtoWrapper(IInOutLineState state)
		{
            this._state = state;
		}

		public IInOutLineState ToInOutLineState()
		{
			return this._state;
		}

		public virtual string LineNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("LineNumber"))
                {
                    return _state.LineNumber;
                }
                return null;
            }
            set
            {
                _state.LineNumber = value;
            }
        }

        string IInOutLineStateProperties.LineNumber
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).LineNumber;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).LineNumber = value;
            }
        }

		public virtual string LocatorId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("LocatorId"))
                {
                    return _state.LocatorId;
                }
                return null;
            }
            set
            {
                _state.LocatorId = value;
            }
        }

        string IInOutLineStateProperties.LocatorId
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).LocatorId;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).LocatorId = value;
            }
        }

		public virtual string ProductId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ProductId"))
                {
                    return _state.ProductId;
                }
                return null;
            }
            set
            {
                _state.ProductId = value;
            }
        }

        string IInOutLineStateProperties.ProductId
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).ProductId;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).ProductId = value;
            }
        }

		public virtual string AttributeSetInstanceId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AttributeSetInstanceId"))
                {
                    return _state.AttributeSetInstanceId;
                }
                return null;
            }
            set
            {
                _state.AttributeSetInstanceId = value;
            }
        }

        string IInOutLineStateProperties.AttributeSetInstanceId
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).AttributeSetInstanceId;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).AttributeSetInstanceId = value;
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

        string IInOutLineStateProperties.Description
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).Description;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).Description = value;
            }
        }

		public virtual string UomId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UomId"))
                {
                    return _state.UomId;
                }
                return null;
            }
            set
            {
                _state.UomId = value;
            }
        }

        string IInOutLineStateProperties.UomId
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).UomId;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).UomId = value;
            }
        }

		public virtual decimal? MovementQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("MovementQuantity"))
                {
                    return _state.MovementQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.MovementQuantity = value.Value;
                }
            }
        }

        decimal IInOutLineStateProperties.MovementQuantity
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).MovementQuantity;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).MovementQuantity = value;
            }
        }

		public virtual decimal? ConfirmedQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ConfirmedQuantity"))
                {
                    return _state.ConfirmedQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.ConfirmedQuantity = value.Value;
                }
            }
        }

        decimal IInOutLineStateProperties.ConfirmedQuantity
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).ConfirmedQuantity;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).ConfirmedQuantity = value;
            }
        }

		public virtual decimal? ScrappedQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ScrappedQuantity"))
                {
                    return _state.ScrappedQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.ScrappedQuantity = value.Value;
                }
            }
        }

        decimal IInOutLineStateProperties.ScrappedQuantity
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).ScrappedQuantity;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).ScrappedQuantity = value;
            }
        }

		public virtual decimal? TargetQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("TargetQuantity"))
                {
                    return _state.TargetQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.TargetQuantity = value.Value;
                }
            }
        }

        decimal IInOutLineStateProperties.TargetQuantity
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).TargetQuantity;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).TargetQuantity = value;
            }
        }

		public virtual decimal? PickedQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PickedQuantity"))
                {
                    return _state.PickedQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PickedQuantity = value.Value;
                }
            }
        }

        decimal IInOutLineStateProperties.PickedQuantity
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).PickedQuantity;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).PickedQuantity = value;
            }
        }

		public virtual bool? IsInvoiced
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsInvoiced"))
                {
                    return _state.IsInvoiced;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsInvoiced = value.Value;
                }
            }
        }

        bool IInOutLineStateProperties.IsInvoiced
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).IsInvoiced;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).IsInvoiced = value;
            }
        }

		public virtual bool? Processed
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Processed"))
                {
                    return _state.Processed;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Processed = value.Value;
                }
            }
        }

        bool IInOutLineStateProperties.Processed
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).Processed;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).Processed = value;
            }
        }

		public virtual decimal? QuantityEntered
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("QuantityEntered"))
                {
                    return _state.QuantityEntered;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.QuantityEntered = value.Value;
                }
            }
        }

        decimal IInOutLineStateProperties.QuantityEntered
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).QuantityEntered;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).QuantityEntered = value;
            }
        }

		public virtual long? RmaLineNumber
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("RmaLineNumber"))
                {
                    return _state.RmaLineNumber;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.RmaLineNumber = value.Value;
                }
            }
        }

        long IInOutLineStateProperties.RmaLineNumber
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).RmaLineNumber;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).RmaLineNumber = value;
            }
        }

		public virtual long? ReversalLineNumber
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ReversalLineNumber"))
                {
                    return _state.ReversalLineNumber;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.ReversalLineNumber = value.Value;
                }
            }
        }

        long IInOutLineStateProperties.ReversalLineNumber
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).ReversalLineNumber;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).ReversalLineNumber = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IInOutLineStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IInOutLineStateProperties).Active = value.Value;
                }
            }
        }

        bool IInOutLineStateProperties.Active
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).Active;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IInOutLineStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IInOutLineStateProperties).Version = value.Value;
                }
            }
        }

        long IInOutLineStateProperties.Version
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).Version;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).Version = value;
            }
        }

		public virtual string InOutDocumentNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InOutDocumentNumber"))
                {
                    return _state.InOutDocumentNumber;
                }
                return null;
            }
            set
            {
                _state.InOutDocumentNumber = value;
            }
        }

        string IInOutLineStateProperties.InOutDocumentNumber
        {
            get 
            {
                return (this._state as IInOutLineStateProperties).InOutDocumentNumber;
            }
            set 
            {
                (this._state as IInOutLineStateProperties).InOutDocumentNumber = value;
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


		InOutLineId IGlobalIdentity<InOutLineId>.GlobalId {
			get { return (_state as IInOutLineState).GlobalId; }
		}

        string ILocalIdentity<string>.LocalId
        {
			get { return (_state as IInOutLineState).LocalId; }
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
            get { return (_state as IInOutLineState).CreatedBy; }
            set { (_state as IInOutLineState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IInOutLineState).CreatedAt; }
            set { (_state as IInOutLineState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IInOutLineState).UpdatedBy; }
            set { (_state as IInOutLineState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IInOutLineState).UpdatedAt; }
            set { (_state as IInOutLineState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IEntityVersioned<long>.EntityVersion
		{
            get { return (_state as IInOutLineStateProperties).Version; }
		}

		#endregion

        bool IInOutLineState.IsUnsaved
        {
            get { return this.Version == InOutLineState.VersionZero; }
        }

		void IInOutLineState.When(IInOutLineStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IInOutLineState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IInOutLineState.When(IInOutLineStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IInOutLineState.When(IInOutLineStateRemoved e)
		{
            throw new NotSupportedException();
		}

		void IInOutLineState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class InOutLineStateDtoWrapperCollection : StateDtoWrapperCollectionBase<InOutLineStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(InOutLineStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

