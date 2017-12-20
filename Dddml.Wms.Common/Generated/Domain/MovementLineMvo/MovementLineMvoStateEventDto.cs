﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementLineMvo;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.MovementLineMvo
{

	public abstract class MovementLineMvoStateEventDtoBase : IStateEventDto, IMovementLineMvoStateCreated, IMovementLineMvoStateMergePatched, IMovementLineMvoStateDeleted
	{

        private MovementLineMvoStateEventIdDto _stateEventId;

		protected internal virtual MovementLineMvoStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new MovementLineMvoStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual MovementLineIdDto MovementLineId
        {
            get { return StateEventId.MovementLineId; }
            set { StateEventId.MovementLineId = value; }
        }

        public virtual long MovementVersion
        {
            get { return StateEventId.MovementVersion; }
            set { StateEventId.MovementVersion = value; }
        }

		public virtual decimal? MovementQuantity { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string LocatorIdFrom { get; set; }

		public virtual string LocatorIdTo { get; set; }

		public virtual string AttributeSetInstanceIdFrom { get; set; }

		public virtual string AttributeSetInstanceIdTo { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string ReversalLineNumber { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string MovementDocumentTypeId { get; set; }

		public virtual string MovementDocumentStatusId { get; set; }

		public virtual string MovementDescription { get; set; }

		public virtual string MovementCreatedBy { get; set; }

		public virtual DateTime? MovementCreatedAt { get; set; }

		public virtual string MovementUpdatedBy { get; set; }

		public virtual DateTime? MovementUpdatedAt { get; set; }

		public virtual bool? MovementActive { get; set; }

		public virtual bool? MovementDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		MovementLineMvoStateEventId IGlobalIdentity<MovementLineMvoStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToMovementLineMvoStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IMovementLineMvoStateEvent.ReadOnly
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

		public virtual bool? IsPropertyMovementQuantityRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductIdRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyProductIdRemoved
        {
            get 
            {
                var b = this.IsPropertyProductIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyLocatorIdFromRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyLocatorIdFromRemoved
        {
            get 
            {
                var b = this.IsPropertyLocatorIdFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLocatorIdFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyLocatorIdToRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyLocatorIdToRemoved
        {
            get 
            {
                var b = this.IsPropertyLocatorIdToRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLocatorIdToRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetInstanceIdFromRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyAttributeSetInstanceIdFromRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetInstanceIdFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetInstanceIdFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetInstanceIdToRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyAttributeSetInstanceIdToRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetInstanceIdToRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetInstanceIdToRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyProcessedRemoved
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

		public virtual bool? IsPropertyReversalLineNumberRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyReversalLineNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyReversalLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReversalLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyVersionRemoved
        {
            get 
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyActiveRemoved
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

		public virtual bool? IsPropertyMovementDocumentTypeIdRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementDocumentTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDocumentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDocumentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementDocumentStatusIdRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementDocumentStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDocumentStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDocumentStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementDescriptionRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementCreatedByRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementCreatedAtRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementUpdatedByRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementUpdatedAtRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementActiveRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementDeletedRemoved { get; set; }

        bool IMovementLineMvoStateMergePatched.IsPropertyMovementDeletedRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDeletedRemoved = value;
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


        MovementLineMvoStateEventId IMovementLineMvoStateEvent.StateEventId
        {
            get { return this.StateEventId.ToMovementLineMvoStateEventId(); }
        }

        protected MovementLineMvoStateEventDtoBase()
        {
        }

        protected MovementLineMvoStateEventDtoBase(MovementLineMvoStateEventIdDto stateEventId)
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


    public class MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto : MovementLineMvoStateEventDtoBase
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



	public class MovementLineMvoStateCreatedDto : MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementLineMvoStateCreatedDto()
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


	public class MovementLineMvoStateMergePatchedDto : MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementLineMvoStateMergePatchedDto()
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


	public class MovementLineMvoStateDeletedDto : MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementLineMvoStateDeletedDto()
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


    public partial class MovementLineMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IMovementLineMvoStateCreated>, IEnumerable<IMovementLineMvoStateMergePatched>, IEnumerable<IMovementLineMvoStateDeleted>
    {
        private List<MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementLineMvoStateCreated> IEnumerable<IMovementLineMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementLineMvoStateMergePatched> IEnumerable<IMovementLineMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementLineMvoStateDeleted> IEnumerable<IMovementLineMvoStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddMovementLineMvoEvent(IMovementLineMvoStateCreated e)
        {
            _innerStateEvents.Add((MovementLineMvoStateCreatedDto)e);
        }

        public void AddMovementLineMvoEvent(IMovementLineMvoStateEvent e)
        {
            _innerStateEvents.Add((MovementLineMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddMovementLineMvoEvent(IMovementLineMvoStateDeleted e)
        {
            _innerStateEvents.Add((MovementLineMvoStateDeletedDto)e);
        }

    }


}

