﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.Movement
{

	public partial class MovementLineStateDtoWrapper : StateDtoWrapperBase, IMovementLineStateDto, IMovementLineState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IMovementLineState _state;

        public MovementLineStateDtoWrapper()
        {
            this._state = new MovementLineState();
        }

		public MovementLineStateDtoWrapper(IMovementLineState state)
		{
            this._state = state;
		}

		public IMovementLineState ToMovementLineState()
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

        string IMovementLineStateProperties.LineNumber
        {
            get 
            {
                return (this._state as IMovementLineStateProperties).LineNumber;
            }
            set 
            {
                (this._state as IMovementLineStateProperties).LineNumber = value;
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

        decimal IMovementLineStateProperties.MovementQuantity
        {
            get 
            {
                return (this._state as IMovementLineStateProperties).MovementQuantity;
            }
            set 
            {
                (this._state as IMovementLineStateProperties).MovementQuantity = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IMovementLineStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IMovementLineStateProperties).Active = value.Value;
                }
            }
        }

        bool IMovementLineStateProperties.Active
        {
            get 
            {
                return (this._state as IMovementLineStateProperties).Active;
            }
            set 
            {
                (this._state as IMovementLineStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IMovementLineStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IMovementLineStateProperties).Version = value.Value;
                }
            }
        }

        long IMovementLineStateProperties.Version
        {
            get 
            {
                return (this._state as IMovementLineStateProperties).Version;
            }
            set 
            {
                (this._state as IMovementLineStateProperties).Version = value;
            }
        }

		public virtual string MovementDocumentNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("MovementDocumentNumber"))
                {
                    return _state.MovementDocumentNumber;
                }
                return null;
            }
            set
            {
                _state.MovementDocumentNumber = value;
            }
        }

        string IMovementLineStateProperties.MovementDocumentNumber
        {
            get 
            {
                return (this._state as IMovementLineStateProperties).MovementDocumentNumber;
            }
            set 
            {
                (this._state as IMovementLineStateProperties).MovementDocumentNumber = value;
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


		MovementLineId IGlobalIdentity<MovementLineId>.GlobalId {
			get { return (_state as IMovementLineState).GlobalId; }
		}

        string ILocalIdentity<string>.LocalId
        {
			get { return (_state as IMovementLineState).LocalId; }
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
            get { return (_state as IMovementLineState).CreatedBy; }
            set { (_state as IMovementLineState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IMovementLineState).CreatedAt; }
            set { (_state as IMovementLineState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IMovementLineState).UpdatedBy; }
            set { (_state as IMovementLineState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IMovementLineState).UpdatedAt; }
            set { (_state as IMovementLineState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IEntityVersioned<long>.EntityVersion
		{
            get { return (_state as IMovementLineStateProperties).Version; }
		}

		#endregion

        bool IMovementLineState.IsUnsaved
        {
            get { return this.Version == MovementLineState.VersionZero; }
        }

		void IMovementLineState.When(IMovementLineStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IMovementLineState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IMovementLineState.When(IMovementLineStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IMovementLineState.When(IMovementLineStateRemoved e)
		{
            throw new NotSupportedException();
		}

		void IMovementLineState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class MovementLineStateDtoWrapperCollection : StateDtoWrapperCollectionBase<MovementLineStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(MovementLineStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

