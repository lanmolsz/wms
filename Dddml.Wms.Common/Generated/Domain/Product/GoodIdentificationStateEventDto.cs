﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Product;

namespace Dddml.Wms.Domain.Product
{

	public abstract class GoodIdentificationStateEventDtoBase : IEventDto, IGoodIdentificationStateCreated, IGoodIdentificationStateMergePatched, IGoodIdentificationStateRemoved
	{

        private GoodIdentificationEventId _goodIdentificationEventId;

		protected internal virtual GoodIdentificationEventId GoodIdentificationEventId 
        {
            get 
            {
                if (_goodIdentificationEventId == null) { _goodIdentificationEventId = new GoodIdentificationEventId(); }
                return _goodIdentificationEventId;
            }
            set
            {
                _goodIdentificationEventId = value;
            }
        }

        public virtual string GoodIdentificationTypeId
        {
            get { return GoodIdentificationEventId.GoodIdentificationTypeId; }
            set { GoodIdentificationEventId.GoodIdentificationTypeId = value; }
        }

		public virtual string IdValue { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		GoodIdentificationEventId IGlobalIdentity<GoodIdentificationEventId>.GlobalId {
			get 
			{
				return this.GoodIdentificationEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IGoodIdentificationEvent.ReadOnly
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

		public virtual long Version { get; set; }

		public virtual bool? IsPropertyIdValueRemoved { get; set; }

        bool IGoodIdentificationStateMergePatched.IsPropertyIdValueRemoved
        {
            get 
            {
                var b = this.IsPropertyIdValueRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIdValueRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IGoodIdentificationStateMergePatched.IsPropertyActiveRemoved
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


        GoodIdentificationEventId IGoodIdentificationEvent.GoodIdentificationEventId
        {
            get { return this.GoodIdentificationEventId; }
        }

        protected GoodIdentificationStateEventDtoBase()
        {
        }

        protected GoodIdentificationStateEventDtoBase(GoodIdentificationEventId stateEventId)
        {
            this.GoodIdentificationEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class GoodIdentificationStateCreatedOrMergePatchedOrRemovedDto : GoodIdentificationStateEventDtoBase
    {
        private string _eventType;

        public virtual string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        protected override string GetEventType()
        {
            return this._eventType;
        }

    }



	public class GoodIdentificationStateCreatedDto : GoodIdentificationStateCreatedOrMergePatchedOrRemovedDto
	{
		public GoodIdentificationStateCreatedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class GoodIdentificationStateMergePatchedDto : GoodIdentificationStateCreatedOrMergePatchedOrRemovedDto
	{
		public GoodIdentificationStateMergePatchedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class GoodIdentificationStateRemovedDto : GoodIdentificationStateCreatedOrMergePatchedOrRemovedDto
	{
		public GoodIdentificationStateRemovedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

	}


    public partial class GoodIdentificationStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IGoodIdentificationStateCreated>, IEnumerable<IGoodIdentificationStateMergePatched>, IEnumerable<IGoodIdentificationStateRemoved>
    {
        private List<GoodIdentificationStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<GoodIdentificationStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual GoodIdentificationStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<GoodIdentificationStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IGoodIdentificationStateCreated> IEnumerable<IGoodIdentificationStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IGoodIdentificationStateMergePatched> IEnumerable<IGoodIdentificationStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IGoodIdentificationStateRemoved> IEnumerable<IGoodIdentificationStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddGoodIdentificationEvent(IGoodIdentificationStateCreated e)
        {
            _innerStateEvents.Add((GoodIdentificationStateCreatedDto)e);
        }

        public void AddGoodIdentificationEvent(IGoodIdentificationEvent e)
        {
            _innerStateEvents.Add((GoodIdentificationStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddGoodIdentificationEvent(IGoodIdentificationStateRemoved e)
        {
            _innerStateEvents.Add((GoodIdentificationStateRemovedDto)e);
        }

    }


}

