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

	public partial class InOutStateDtoWrapper : StateDtoWrapperBase, IInOutStateDto, IInOutState
	{

        internal static IList<string> _collectionFieldNames = new string[] { "InOutLines" };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IInOutState _state;

        public InOutStateDtoWrapper()
        {
            this._state = new InOutState();
        }

		public InOutStateDtoWrapper(IInOutState state)
		{
            this._state = state;
		}

		public IInOutState ToInOutState()
		{
			return this._state;
		}

		public virtual string DocumentNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DocumentNumber"))
                {
                    return _state.DocumentNumber;
                }
                return null;
            }
            set
            {
                _state.DocumentNumber = value;
            }
        }

        string IInOutStateProperties.DocumentNumber
        {
            get 
            {
                return (this._state as IInOutStateProperties).DocumentNumber;
            }
            set 
            {
                (this._state as IInOutStateProperties).DocumentNumber = value;
            }
        }

		public virtual string DocumentStatusId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DocumentStatusId"))
                {
                    return _state.DocumentStatusId;
                }
                return null;
            }
            set
            {
                _state.DocumentStatusId = value;
            }
        }

        string IInOutStateProperties.DocumentStatusId
        {
            get 
            {
                return (this._state as IInOutStateProperties).DocumentStatusId;
            }
            set 
            {
                (this._state as IInOutStateProperties).DocumentStatusId = value;
            }
        }

		public virtual bool? Posted
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Posted"))
                {
                    return _state.Posted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Posted = value.Value;
                }
            }
        }

        bool IInOutStateProperties.Posted
        {
            get 
            {
                return (this._state as IInOutStateProperties).Posted;
            }
            set 
            {
                (this._state as IInOutStateProperties).Posted = value;
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

        bool IInOutStateProperties.Processed
        {
            get 
            {
                return (this._state as IInOutStateProperties).Processed;
            }
            set 
            {
                (this._state as IInOutStateProperties).Processed = value;
            }
        }

		public virtual string Processing
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Processing"))
                {
                    return _state.Processing;
                }
                return null;
            }
            set
            {
                _state.Processing = value;
            }
        }

        string IInOutStateProperties.Processing
        {
            get 
            {
                return (this._state as IInOutStateProperties).Processing;
            }
            set 
            {
                (this._state as IInOutStateProperties).Processing = value;
            }
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

        string IInOutStateProperties.DocumentTypeId
        {
            get 
            {
                return (this._state as IInOutStateProperties).DocumentTypeId;
            }
            set 
            {
                (this._state as IInOutStateProperties).DocumentTypeId = value;
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

        string IInOutStateProperties.Description
        {
            get 
            {
                return (this._state as IInOutStateProperties).Description;
            }
            set 
            {
                (this._state as IInOutStateProperties).Description = value;
            }
        }

		public virtual string OrderId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderId"))
                {
                    return _state.OrderId;
                }
                return null;
            }
            set
            {
                _state.OrderId = value;
            }
        }

        string IInOutStateProperties.OrderId
        {
            get 
            {
                return (this._state as IInOutStateProperties).OrderId;
            }
            set 
            {
                (this._state as IInOutStateProperties).OrderId = value;
            }
        }

		public virtual DateTime? DateOrdered
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DateOrdered"))
                {
                    return _state.DateOrdered;
                }
                return null;
            }
            set
            {
                _state.DateOrdered = value;
            }
        }

        DateTime? IInOutStateProperties.DateOrdered
        {
            get 
            {
                return (this._state as IInOutStateProperties).DateOrdered;
            }
            set 
            {
                (this._state as IInOutStateProperties).DateOrdered = value;
            }
        }

		public virtual bool? IsPrinted
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsPrinted"))
                {
                    return _state.IsPrinted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsPrinted = value.Value;
                }
            }
        }

        bool IInOutStateProperties.IsPrinted
        {
            get 
            {
                return (this._state as IInOutStateProperties).IsPrinted;
            }
            set 
            {
                (this._state as IInOutStateProperties).IsPrinted = value;
            }
        }

		public virtual string MovementTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("MovementTypeId"))
                {
                    return _state.MovementTypeId;
                }
                return null;
            }
            set
            {
                _state.MovementTypeId = value;
            }
        }

        string IInOutStateProperties.MovementTypeId
        {
            get 
            {
                return (this._state as IInOutStateProperties).MovementTypeId;
            }
            set 
            {
                (this._state as IInOutStateProperties).MovementTypeId = value;
            }
        }

		public virtual DateTime? MovementDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("MovementDate"))
                {
                    return _state.MovementDate;
                }
                return null;
            }
            set
            {
                _state.MovementDate = value;
            }
        }

        DateTime? IInOutStateProperties.MovementDate
        {
            get 
            {
                return (this._state as IInOutStateProperties).MovementDate;
            }
            set 
            {
                (this._state as IInOutStateProperties).MovementDate = value;
            }
        }

		public virtual string BusinessPartnerId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("BusinessPartnerId"))
                {
                    return _state.BusinessPartnerId;
                }
                return null;
            }
            set
            {
                _state.BusinessPartnerId = value;
            }
        }

        string IInOutStateProperties.BusinessPartnerId
        {
            get 
            {
                return (this._state as IInOutStateProperties).BusinessPartnerId;
            }
            set 
            {
                (this._state as IInOutStateProperties).BusinessPartnerId = value;
            }
        }

		public virtual string WarehouseId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("WarehouseId"))
                {
                    return _state.WarehouseId;
                }
                return null;
            }
            set
            {
                _state.WarehouseId = value;
            }
        }

        string IInOutStateProperties.WarehouseId
        {
            get 
            {
                return (this._state as IInOutStateProperties).WarehouseId;
            }
            set 
            {
                (this._state as IInOutStateProperties).WarehouseId = value;
            }
        }

		public virtual string POReference
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("POReference"))
                {
                    return _state.POReference;
                }
                return null;
            }
            set
            {
                _state.POReference = value;
            }
        }

        string IInOutStateProperties.POReference
        {
            get 
            {
                return (this._state as IInOutStateProperties).POReference;
            }
            set 
            {
                (this._state as IInOutStateProperties).POReference = value;
            }
        }

		public virtual string ShipperId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShipperId"))
                {
                    return _state.ShipperId;
                }
                return null;
            }
            set
            {
                _state.ShipperId = value;
            }
        }

        string IInOutStateProperties.ShipperId
        {
            get 
            {
                return (this._state as IInOutStateProperties).ShipperId;
            }
            set 
            {
                (this._state as IInOutStateProperties).ShipperId = value;
            }
        }

		public virtual DateTime? DatePrinted
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DatePrinted"))
                {
                    return _state.DatePrinted;
                }
                return null;
            }
            set
            {
                _state.DatePrinted = value;
            }
        }

        DateTime? IInOutStateProperties.DatePrinted
        {
            get 
            {
                return (this._state as IInOutStateProperties).DatePrinted;
            }
            set 
            {
                (this._state as IInOutStateProperties).DatePrinted = value;
            }
        }

		public virtual string SalesRepresentativeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SalesRepresentativeId"))
                {
                    return _state.SalesRepresentativeId;
                }
                return null;
            }
            set
            {
                _state.SalesRepresentativeId = value;
            }
        }

        string IInOutStateProperties.SalesRepresentativeId
        {
            get 
            {
                return (this._state as IInOutStateProperties).SalesRepresentativeId;
            }
            set 
            {
                (this._state as IInOutStateProperties).SalesRepresentativeId = value;
            }
        }

		public virtual int? NumberOfPackages
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("NumberOfPackages"))
                {
                    return _state.NumberOfPackages;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.NumberOfPackages = value.Value;
                }
            }
        }

        int IInOutStateProperties.NumberOfPackages
        {
            get 
            {
                return (this._state as IInOutStateProperties).NumberOfPackages;
            }
            set 
            {
                (this._state as IInOutStateProperties).NumberOfPackages = value;
            }
        }

		public virtual DateTime? PickDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PickDate"))
                {
                    return _state.PickDate;
                }
                return null;
            }
            set
            {
                _state.PickDate = value;
            }
        }

        DateTime? IInOutStateProperties.PickDate
        {
            get 
            {
                return (this._state as IInOutStateProperties).PickDate;
            }
            set 
            {
                (this._state as IInOutStateProperties).PickDate = value;
            }
        }

		public virtual DateTime? ShipDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShipDate"))
                {
                    return _state.ShipDate;
                }
                return null;
            }
            set
            {
                _state.ShipDate = value;
            }
        }

        DateTime? IInOutStateProperties.ShipDate
        {
            get 
            {
                return (this._state as IInOutStateProperties).ShipDate;
            }
            set 
            {
                (this._state as IInOutStateProperties).ShipDate = value;
            }
        }

		public virtual string TrackingNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("TrackingNumber"))
                {
                    return _state.TrackingNumber;
                }
                return null;
            }
            set
            {
                _state.TrackingNumber = value;
            }
        }

        string IInOutStateProperties.TrackingNumber
        {
            get 
            {
                return (this._state as IInOutStateProperties).TrackingNumber;
            }
            set 
            {
                (this._state as IInOutStateProperties).TrackingNumber = value;
            }
        }

		public virtual DateTime? DateReceived
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DateReceived"))
                {
                    return _state.DateReceived;
                }
                return null;
            }
            set
            {
                _state.DateReceived = value;
            }
        }

        DateTime? IInOutStateProperties.DateReceived
        {
            get 
            {
                return (this._state as IInOutStateProperties).DateReceived;
            }
            set 
            {
                (this._state as IInOutStateProperties).DateReceived = value;
            }
        }

		public virtual bool? IsInTransit
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsInTransit"))
                {
                    return _state.IsInTransit;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsInTransit = value.Value;
                }
            }
        }

        bool IInOutStateProperties.IsInTransit
        {
            get 
            {
                return (this._state as IInOutStateProperties).IsInTransit;
            }
            set 
            {
                (this._state as IInOutStateProperties).IsInTransit = value;
            }
        }

		public virtual bool? IsApproved
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsApproved"))
                {
                    return _state.IsApproved;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsApproved = value.Value;
                }
            }
        }

        bool IInOutStateProperties.IsApproved
        {
            get 
            {
                return (this._state as IInOutStateProperties).IsApproved;
            }
            set 
            {
                (this._state as IInOutStateProperties).IsApproved = value;
            }
        }

		public virtual bool? IsInDispute
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsInDispute"))
                {
                    return _state.IsInDispute;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsInDispute = value.Value;
                }
            }
        }

        bool IInOutStateProperties.IsInDispute
        {
            get 
            {
                return (this._state as IInOutStateProperties).IsInDispute;
            }
            set 
            {
                (this._state as IInOutStateProperties).IsInDispute = value;
            }
        }

		public virtual string RmaDocumentNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("RmaDocumentNumber"))
                {
                    return _state.RmaDocumentNumber;
                }
                return null;
            }
            set
            {
                _state.RmaDocumentNumber = value;
            }
        }

        string IInOutStateProperties.RmaDocumentNumber
        {
            get 
            {
                return (this._state as IInOutStateProperties).RmaDocumentNumber;
            }
            set 
            {
                (this._state as IInOutStateProperties).RmaDocumentNumber = value;
            }
        }

		public virtual string ReversalDocumentNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ReversalDocumentNumber"))
                {
                    return _state.ReversalDocumentNumber;
                }
                return null;
            }
            set
            {
                _state.ReversalDocumentNumber = value;
            }
        }

        string IInOutStateProperties.ReversalDocumentNumber
        {
            get 
            {
                return (this._state as IInOutStateProperties).ReversalDocumentNumber;
            }
            set 
            {
                (this._state as IInOutStateProperties).ReversalDocumentNumber = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IInOutStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IInOutStateProperties).Active = value.Value;
                }
            }
        }

        bool IInOutStateProperties.Active
        {
            get 
            {
                return (this._state as IInOutStateProperties).Active;
            }
            set 
            {
                (this._state as IInOutStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IInOutStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IInOutStateProperties).Version = value.Value;
                }
            }
        }

        long IInOutStateProperties.Version
        {
            get 
            {
                return (this._state as IInOutStateProperties).Version;
            }
            set 
            {
                (this._state as IInOutStateProperties).Version = value;
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
			get { return (_state as IInOutState).GlobalId; }
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
            get { return (_state as IInOutState).CreatedBy; }
            set { (_state as IInOutState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IInOutState).CreatedAt; }
            set { (_state as IInOutState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IInOutState).UpdatedBy; }
            set { (_state as IInOutState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IInOutState).UpdatedAt; }
            set { (_state as IInOutState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IInOutStateProperties).Version; }
		}

		#endregion

        bool IInOutState.IsUnsaved
        {
            get { return this.Version == InOutState.VersionZero; }
        }

        public virtual IInOutLineStateDto[] InOutLines
        {
            get 
            {
                if (!(this as IStateDtoWrapper).ReturnedFieldsContains("InOutLines"))
                {
                    return null;
                }
                var dtos = new List<IInOutLineStateDto>();
                if (this._state.InOutLines != null)
                {
                    foreach (var s in this._state.InOutLines)
                    {
                        var dto = new InOutLineStateDtoWrapper((InOutLineState)s);
                        var returnFS = CollectionUtils.DictionaryGetValueIgnoringCase(ReturnedFields, "InOutLines");
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
                if (value == null) { value = new InOutLineStateDtoWrapper[0]; }
                var states = new List<IInOutLineState>();
                foreach (var s in value)
                {
                    states.Add(s.ToInOutLineState());
                }
                this._state.InOutLines = new DtoInOutLineStates(this._state, states);
            }
        }

        IInOutLineStates IInOutState.InOutLines
        {
            get { return _state.InOutLines; }
            set { _state.InOutLines = value; }
        }

		void IInOutState.When(IInOutStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IInOutState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IInOutState.When(IInOutStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IInOutState.When(IInOutStateDeleted e)
		{
            throw new NotSupportedException();
		}

		void IInOutState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

        public class DtoInOutLineStates : IInOutLineStates
        {

            private IInOutState _outerState;

            private IEnumerable<IInOutLineState> _innerStates;

            public DtoInOutLineStates(IInOutState outerState, IEnumerable<IInOutLineState> innerStates)
            {
                this._outerState = outerState;
                if (innerStates == null)
                {
                    this._innerStates = new IInOutLineState[] { };
                }
                else
                {
                    this._innerStates = innerStates;
                }
            }

            public IEnumerator<IInOutLineState> GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            public IInOutLineState Get(string lineNumber)
            {
                throw new NotSupportedException();
            }

            public IInOutLineState Get(string lineNumber, bool forCreation)
            {
                throw new NotSupportedException();
            }

            public IInOutLineState Get(string lineNumber, bool forCreation, bool nullAllowed)
            {
                throw new NotSupportedException();
            }

            public void Remove(IInOutLineState state)
            {
                throw new NotSupportedException();
            }

            public void AddToSave(IInOutLineState state)
            {
                throw new NotSupportedException();
            }

            public void Save()
            {
                throw new NotSupportedException();
            }
        }

	}

    partial class InOutStateDtoWrapperCollection : StateDtoWrapperCollectionBase<InOutStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(InOutStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

