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

	public abstract class MovementStateEventDtoBase : IStateEventDto, IMovementStateCreated, IMovementStateMergePatched, IMovementStateDeleted
	{

        private MovementStateEventIdDto _stateEventId;

		protected internal virtual MovementStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new MovementStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string DocumentNumber
        {
            get { return StateEventId.DocumentNumber; }
            set { StateEventId.DocumentNumber = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		public virtual string DocumentTypeId { get; set; }

		public virtual string DocumentStatusId { get; set; }

		public virtual string MovementTypeId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		MovementStateEventId IGlobalIdentity<MovementStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToMovementStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IMovementStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyDocumentTypeIdRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyDocumentTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDocumentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDocumentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDocumentStatusIdRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyDocumentStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDocumentStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDocumentStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementTypeIdRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyMovementTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMovementStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}


        private MovementLineStateCreatedOrMergePatchedOrRemovedDtos _movementLineEvents = new MovementLineStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual MovementLineStateCreatedOrMergePatchedOrRemovedDto[] MovementLineEvents
        {
            get
            {
                return _movementLineEvents.ToArray();
            }
            set
            {
                _movementLineEvents.Clear();
                _movementLineEvents.AddRange(value);
            }
        }



        private MovementLineStateEventIdDto NewMovementLineStateEventId(string lineNumber)
        {
            var eId = new MovementLineStateEventIdDto();
            eId.MovementDocumentNumber = this.StateEventId.DocumentNumber;
            eId.LineNumber = lineNumber;
            eId.MovementVersion = this.StateEventId.Version;
            return eId;
        }

        public virtual MovementLineStateCreatedDto NewMovementLineStateCreated(string lineNumber)
        {
            var e = new MovementLineStateCreatedDto();
            var eId = NewMovementLineStateEventId(lineNumber);
            e.StateEventId = eId;
            return e;
        }

        public virtual MovementLineStateMergePatchedDto NewMovementLineStateMergePatched(string lineNumber)
        {
            var e = new MovementLineStateMergePatchedDto();
            var eId = NewMovementLineStateEventId(lineNumber);
            e.StateEventId = eId;
            return e;
        }

        public virtual MovementLineStateRemovedDto NewMovementLineStateRemoved(string lineNumber)
        {
            var e = new MovementLineStateRemovedDto();
            var eId = NewMovementLineStateEventId(lineNumber);
            e.StateEventId = eId;
            return e;
        }

        IEnumerable<IMovementLineStateCreated> IMovementStateCreated.MovementLineEvents
        {
            get { return this._movementLineEvents; }
        }

        void IMovementStateCreated.AddMovementLineEvent(IMovementLineStateCreated e)
        {
            this._movementLineEvents.AddMovementLineEvent(e);
        }

        IMovementLineStateCreated IMovementStateCreated.NewMovementLineStateCreated(string lineNumber)
        {
            return NewMovementLineStateCreated(lineNumber);
        }

        IEnumerable<IMovementLineStateEvent> IMovementStateMergePatched.MovementLineEvents
        {
            get { return this._movementLineEvents; }
        }

        void IMovementStateMergePatched.AddMovementLineEvent(IMovementLineStateEvent e)
        {
            this._movementLineEvents.AddMovementLineEvent(e);
        }

        IMovementLineStateCreated IMovementStateMergePatched.NewMovementLineStateCreated(string lineNumber)
        {
            return NewMovementLineStateCreated(lineNumber);
        }

        IMovementLineStateMergePatched IMovementStateMergePatched.NewMovementLineStateMergePatched(string lineNumber)
        {
            return NewMovementLineStateMergePatched(lineNumber);
        }

        IMovementLineStateRemoved IMovementStateMergePatched.NewMovementLineStateRemoved(string lineNumber)
        {
            return NewMovementLineStateRemoved(lineNumber);
        }


        IEnumerable<IMovementLineStateRemoved> IMovementStateDeleted.MovementLineEvents
        {
            get { return this._movementLineEvents; }
        }

        void IMovementStateDeleted.AddMovementLineEvent(IMovementLineStateRemoved e)
        {
            this._movementLineEvents.AddMovementLineEvent(e);
        }

        IMovementLineStateRemoved IMovementStateDeleted.NewMovementLineStateRemoved(string lineNumber)
        {
            return NewMovementLineStateRemoved(lineNumber);
        }



        private MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDtos _movementConfirmationLineEvents = new MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto[] MovementConfirmationLineEvents
        {
            get
            {
                return _movementConfirmationLineEvents.ToArray();
            }
            set
            {
                _movementConfirmationLineEvents.Clear();
                _movementConfirmationLineEvents.AddRange(value);
            }
        }



        private MovementConfirmationLineStateEventIdDto NewMovementConfirmationLineStateEventId(string lineNumber)
        {
            var eId = new MovementConfirmationLineStateEventIdDto();
            eId.MovementDocumentNumber = this.StateEventId.DocumentNumber;
            eId.LineNumber = lineNumber;
            eId.MovementVersion = this.StateEventId.Version;
            return eId;
        }

        public virtual MovementConfirmationLineStateCreatedDto NewMovementConfirmationLineStateCreated(string lineNumber)
        {
            var e = new MovementConfirmationLineStateCreatedDto();
            var eId = NewMovementConfirmationLineStateEventId(lineNumber);
            e.StateEventId = eId;
            return e;
        }

        public virtual MovementConfirmationLineStateMergePatchedDto NewMovementConfirmationLineStateMergePatched(string lineNumber)
        {
            var e = new MovementConfirmationLineStateMergePatchedDto();
            var eId = NewMovementConfirmationLineStateEventId(lineNumber);
            e.StateEventId = eId;
            return e;
        }

        public virtual MovementConfirmationLineStateRemovedDto NewMovementConfirmationLineStateRemoved(string lineNumber)
        {
            var e = new MovementConfirmationLineStateRemovedDto();
            var eId = NewMovementConfirmationLineStateEventId(lineNumber);
            e.StateEventId = eId;
            return e;
        }

        IEnumerable<IMovementConfirmationLineStateCreated> IMovementStateCreated.MovementConfirmationLineEvents
        {
            get { return this._movementConfirmationLineEvents; }
        }

        void IMovementStateCreated.AddMovementConfirmationLineEvent(IMovementConfirmationLineStateCreated e)
        {
            this._movementConfirmationLineEvents.AddMovementConfirmationLineEvent(e);
        }

        IMovementConfirmationLineStateCreated IMovementStateCreated.NewMovementConfirmationLineStateCreated(string lineNumber)
        {
            return NewMovementConfirmationLineStateCreated(lineNumber);
        }

        IEnumerable<IMovementConfirmationLineStateEvent> IMovementStateMergePatched.MovementConfirmationLineEvents
        {
            get { return this._movementConfirmationLineEvents; }
        }

        void IMovementStateMergePatched.AddMovementConfirmationLineEvent(IMovementConfirmationLineStateEvent e)
        {
            this._movementConfirmationLineEvents.AddMovementConfirmationLineEvent(e);
        }

        IMovementConfirmationLineStateCreated IMovementStateMergePatched.NewMovementConfirmationLineStateCreated(string lineNumber)
        {
            return NewMovementConfirmationLineStateCreated(lineNumber);
        }

        IMovementConfirmationLineStateMergePatched IMovementStateMergePatched.NewMovementConfirmationLineStateMergePatched(string lineNumber)
        {
            return NewMovementConfirmationLineStateMergePatched(lineNumber);
        }

        IMovementConfirmationLineStateRemoved IMovementStateMergePatched.NewMovementConfirmationLineStateRemoved(string lineNumber)
        {
            return NewMovementConfirmationLineStateRemoved(lineNumber);
        }


        IEnumerable<IMovementConfirmationLineStateRemoved> IMovementStateDeleted.MovementConfirmationLineEvents
        {
            get { return this._movementConfirmationLineEvents; }
        }

        void IMovementStateDeleted.AddMovementConfirmationLineEvent(IMovementConfirmationLineStateRemoved e)
        {
            this._movementConfirmationLineEvents.AddMovementConfirmationLineEvent(e);
        }

        IMovementConfirmationLineStateRemoved IMovementStateDeleted.NewMovementConfirmationLineStateRemoved(string lineNumber)
        {
            return NewMovementConfirmationLineStateRemoved(lineNumber);
        }



        MovementStateEventId IMovementStateEvent.StateEventId
        {
            get { return this.StateEventId.ToMovementStateEventId(); }
        }

        protected MovementStateEventDtoBase()
        {
        }

        protected MovementStateEventDtoBase(MovementStateEventIdDto stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class MovementStateCreatedOrMergePatchedOrDeletedDto : MovementStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class MovementStateCreatedDto : MovementStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class MovementStateMergePatchedDto : MovementStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class MovementStateDeletedDto : MovementStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementStateDeletedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class MovementStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IMovementStateCreated>, IEnumerable<IMovementStateMergePatched>, IEnumerable<IMovementStateDeleted>
    {
        private List<MovementStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<MovementStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual MovementStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<MovementStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementStateCreated> IEnumerable<IMovementStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementStateMergePatched> IEnumerable<IMovementStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementStateDeleted> IEnumerable<IMovementStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddMovementEvent(IMovementStateCreated e)
        {
            _innerStateEvents.Add((MovementStateCreatedDto)e);
        }

        public void AddMovementEvent(IMovementStateEvent e)
        {
            _innerStateEvents.Add((MovementStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddMovementEvent(IMovementStateDeleted e)
        {
            _innerStateEvents.Add((MovementStateDeletedDto)e);
        }

    }


}

