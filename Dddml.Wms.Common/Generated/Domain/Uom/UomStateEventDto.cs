﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Uom;

namespace Dddml.Wms.Domain.Uom
{

	public abstract class UomStateEventDtoBase : IStateEventDto, IUomStateCreated, IUomStateMergePatched, IUomStateDeleted
	{

        private UomEventId _uomEventId;

		protected internal virtual UomEventId UomEventId 
        {
            get 
            {
                if (_uomEventId == null) { _uomEventId = new UomEventId(); }
                return _uomEventId;
            }
            set
            {
                _uomEventId = value;
            }
        }

        public virtual string UomId
        {
            get { return UomEventId.UomId; }
            set { UomEventId.UomId = value; }
        }

        public virtual long Version
        {
            get { return UomEventId.Version; }
            set { UomEventId.Version = value; }
        }

		public virtual string UomTypeId { get; set; }

		public virtual string Abbreviation { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		UomEventId IGlobalIdentity<UomEventId>.GlobalId {
			get 
			{
				return this.UomEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IUomStateEvent.ReadOnly
        {
            get
            {
                return this.EventReadOnly;
            }
            set
            {
                this.EventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyUomTypeIdRemoved { get; set; }

        bool IUomStateMergePatched.IsPropertyUomTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyUomTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUomTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAbbreviationRemoved { get; set; }

        bool IUomStateMergePatched.IsPropertyAbbreviationRemoved
        {
            get 
            {
                var b = this.IsPropertyAbbreviationRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAbbreviationRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IUomStateMergePatched.IsPropertyDescriptionRemoved
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

        bool IUomStateMergePatched.IsPropertyActiveRemoved
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


        UomEventId IUomStateEvent.UomEventId
        {
            get { return this.UomEventId; }
        }

        protected UomStateEventDtoBase()
        {
        }

        protected UomStateEventDtoBase(UomEventId stateEventId)
        {
            this.UomEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class UomStateCreatedOrMergePatchedOrDeletedDto : UomStateEventDtoBase
    {
        private string _eventType;

        public virtual string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._eventType;
        }

    }



	public class UomStateCreatedDto : UomStateCreatedOrMergePatchedOrDeletedDto
	{
		public UomStateCreatedDto()
		{
		}

        public override string EventType
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


	public class UomStateMergePatchedDto : UomStateCreatedOrMergePatchedOrDeletedDto
	{
		public UomStateMergePatchedDto()
		{
		}

        public override string EventType
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


	public class UomStateDeletedDto : UomStateCreatedOrMergePatchedOrDeletedDto
	{
		public UomStateDeletedDto()
		{
		}

        public override string EventType
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


    public partial class UomStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IUomStateCreated>, IEnumerable<IUomStateMergePatched>, IEnumerable<IUomStateDeleted>
    {
        private List<UomStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<UomStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual UomStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<UomStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUomStateCreated> IEnumerable<IUomStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUomStateMergePatched> IEnumerable<IUomStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUomStateDeleted> IEnumerable<IUomStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddUomEvent(IUomStateCreated e)
        {
            _innerStateEvents.Add((UomStateCreatedDto)e);
        }

        public void AddUomEvent(IUomStateEvent e)
        {
            _innerStateEvents.Add((UomStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddUomEvent(IUomStateDeleted e)
        {
            _innerStateEvents.Add((UomStateDeletedDto)e);
        }

    }


}

