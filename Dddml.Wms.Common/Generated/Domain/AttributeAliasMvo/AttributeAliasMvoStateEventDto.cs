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

	public abstract class AttributeAliasMvoStateEventDtoBase : IStateEventDto, IAttributeAliasMvoStateCreated, IAttributeAliasMvoStateMergePatched, IAttributeAliasMvoStateDeleted
	{

        private AttributeAliasMvoEventIdDto _stateEventId;

		protected internal virtual AttributeAliasMvoEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new AttributeAliasMvoEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual AttributeAliasIdDto AttributeAliasId
        {
            get { return StateEventId.AttributeAliasId; }
            set { StateEventId.AttributeAliasId = value; }
        }

        public virtual long AttributeVersion
        {
            get { return StateEventId.AttributeVersion; }
            set { StateEventId.AttributeVersion = value; }
        }

		public virtual string Name { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string AttributeAttributeName { get; set; }

		public virtual string AttributeOrganizationId { get; set; }

		public virtual string AttributeDescription { get; set; }

		public virtual bool? AttributeIsMandatory { get; set; }

		public virtual string AttributeAttributeValueType { get; set; }

		public virtual int? AttributeAttributeValueLength { get; set; }

		public virtual bool? AttributeIsList { get; set; }

		public virtual string AttributeFieldName { get; set; }

		public virtual string AttributeReferenceId { get; set; }

		public virtual string AttributeCreatedBy { get; set; }

		public virtual DateTime? AttributeCreatedAt { get; set; }

		public virtual string AttributeUpdatedBy { get; set; }

		public virtual DateTime? AttributeUpdatedAt { get; set; }

		public virtual bool? AttributeActive { get; set; }

		public virtual bool? AttributeDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeAliasMvoEventId IGlobalIdentity<AttributeAliasMvoEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToAttributeAliasMvoEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeAliasMvoStateEvent.ReadOnly
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

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyNameRemoved
        {
            get 
            {
                var b = this.IsPropertyNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyVersionRemoved
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

        bool IAttributeAliasMvoStateMergePatched.IsPropertyActiveRemoved
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

		public virtual bool? IsPropertyAttributeAttributeNameRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeAttributeNameRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeAttributeNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeAttributeNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeOrganizationIdRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeOrganizationIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeOrganizationIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeOrganizationIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeDescriptionRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeIsMandatoryRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeIsMandatoryRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeIsMandatoryRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeIsMandatoryRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeAttributeValueTypeRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeAttributeValueTypeRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeAttributeValueTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeAttributeValueTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeAttributeValueLengthRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeAttributeValueLengthRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeAttributeValueLengthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeAttributeValueLengthRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeIsListRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeIsListRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeIsListRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeIsListRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeFieldNameRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeFieldNameRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeFieldNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeFieldNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeReferenceIdRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeReferenceIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeReferenceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeReferenceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeCreatedByRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeCreatedAtRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeUpdatedByRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeUpdatedAtRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeActiveRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeDeletedRemoved { get; set; }

        bool IAttributeAliasMvoStateMergePatched.IsPropertyAttributeDeletedRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeDeletedRemoved = value;
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


        AttributeAliasMvoEventId IAttributeAliasMvoStateEvent.StateEventId
        {
            get { return this.StateEventId.ToAttributeAliasMvoEventId(); }
        }

        protected AttributeAliasMvoStateEventDtoBase()
        {
        }

        protected AttributeAliasMvoStateEventDtoBase(AttributeAliasMvoEventIdDto stateEventId)
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


    public class AttributeAliasMvoStateCreatedOrMergePatchedOrDeletedDto : AttributeAliasMvoStateEventDtoBase
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



	public class AttributeAliasMvoStateCreatedDto : AttributeAliasMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeAliasMvoStateCreatedDto()
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


	public class AttributeAliasMvoStateMergePatchedDto : AttributeAliasMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeAliasMvoStateMergePatchedDto()
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


	public class AttributeAliasMvoStateDeletedDto : AttributeAliasMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeAliasMvoStateDeletedDto()
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


    public partial class AttributeAliasMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IAttributeAliasMvoStateCreated>, IEnumerable<IAttributeAliasMvoStateMergePatched>, IEnumerable<IAttributeAliasMvoStateDeleted>
    {
        private List<AttributeAliasMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<AttributeAliasMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual AttributeAliasMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<AttributeAliasMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeAliasMvoStateCreated> IEnumerable<IAttributeAliasMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeAliasMvoStateMergePatched> IEnumerable<IAttributeAliasMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeAliasMvoStateDeleted> IEnumerable<IAttributeAliasMvoStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddAttributeAliasMvoEvent(IAttributeAliasMvoStateCreated e)
        {
            _innerStateEvents.Add((AttributeAliasMvoStateCreatedDto)e);
        }

        public void AddAttributeAliasMvoEvent(IAttributeAliasMvoStateEvent e)
        {
            _innerStateEvents.Add((AttributeAliasMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddAttributeAliasMvoEvent(IAttributeAliasMvoStateDeleted e)
        {
            _innerStateEvents.Add((AttributeAliasMvoStateDeletedDto)e);
        }

    }


}

