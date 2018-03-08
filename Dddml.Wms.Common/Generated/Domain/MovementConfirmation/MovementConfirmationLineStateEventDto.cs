﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmation
{

	public abstract class MovementConfirmationLineStateEventDtoBase : IStateEventDto, IMovementConfirmationLineStateCreated, IMovementConfirmationLineStateMergePatched, IMovementConfirmationLineStateRemoved
	{

        private MovementConfirmationLineEventIdDto _stateEventId;

		protected internal virtual MovementConfirmationLineEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new MovementConfirmationLineEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string LineNumber
        {
            get { return StateEventId.LineNumber; }
            set { StateEventId.LineNumber = value; }
        }

		public virtual string MovementLineNumber { get; set; }

		public virtual decimal? TargetQuantity { get; set; }

		public virtual decimal? ConfirmedQuantity { get; set; }

		public virtual decimal? DifferenceQuantity { get; set; }

		public virtual decimal? ScrappedQuantity { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		MovementConfirmationLineEventId IGlobalIdentity<MovementConfirmationLineEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToMovementConfirmationLineEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IMovementConfirmationLineStateEvent.ReadOnly
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

		public virtual long Version { get; set; }

		public virtual bool? IsPropertyMovementLineNumberRemoved { get; set; }

        bool IMovementConfirmationLineStateMergePatched.IsPropertyMovementLineNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyTargetQuantityRemoved { get; set; }

        bool IMovementConfirmationLineStateMergePatched.IsPropertyTargetQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyTargetQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyTargetQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyConfirmedQuantityRemoved { get; set; }

        bool IMovementConfirmationLineStateMergePatched.IsPropertyConfirmedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyConfirmedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyConfirmedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyDifferenceQuantityRemoved { get; set; }

        bool IMovementConfirmationLineStateMergePatched.IsPropertyDifferenceQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyDifferenceQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDifferenceQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyScrappedQuantityRemoved { get; set; }

        bool IMovementConfirmationLineStateMergePatched.IsPropertyScrappedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyScrappedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyScrappedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMovementConfirmationLineStateMergePatched.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IMovementConfirmationLineStateMergePatched.IsPropertyProcessedRemoved
        {
            get 
            {
                var b = this.IsPropertyProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMovementConfirmationLineStateMergePatched.IsPropertyActiveRemoved
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


        MovementConfirmationLineEventId IMovementConfirmationLineStateEvent.StateEventId
        {
            get { return this.StateEventId.ToMovementConfirmationLineEventId(); }
        }

        protected MovementConfirmationLineStateEventDtoBase()
        {
        }

        protected MovementConfirmationLineStateEventDtoBase(MovementConfirmationLineEventIdDto stateEventId)
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


    public class MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto : MovementConfirmationLineStateEventDtoBase
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



	public class MovementConfirmationLineStateCreatedDto : MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto
	{
		public MovementConfirmationLineStateCreatedDto()
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


	public class MovementConfirmationLineStateMergePatchedDto : MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto
	{
		public MovementConfirmationLineStateMergePatchedDto()
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


	public class MovementConfirmationLineStateRemovedDto : MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto
	{
		public MovementConfirmationLineStateRemovedDto()
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
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

	}


    public partial class MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IMovementConfirmationLineStateCreated>, IEnumerable<IMovementConfirmationLineStateMergePatched>, IEnumerable<IMovementConfirmationLineStateRemoved>
    {
        private List<MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementConfirmationLineStateCreated> IEnumerable<IMovementConfirmationLineStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementConfirmationLineStateMergePatched> IEnumerable<IMovementConfirmationLineStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementConfirmationLineStateRemoved> IEnumerable<IMovementConfirmationLineStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddMovementConfirmationLineEvent(IMovementConfirmationLineStateCreated e)
        {
            _innerStateEvents.Add((MovementConfirmationLineStateCreatedDto)e);
        }

        public void AddMovementConfirmationLineEvent(IMovementConfirmationLineStateEvent e)
        {
            _innerStateEvents.Add((MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddMovementConfirmationLineEvent(IMovementConfirmationLineStateRemoved e)
        {
            _innerStateEvents.Add((MovementConfirmationLineStateRemovedDto)e);
        }

    }


}

