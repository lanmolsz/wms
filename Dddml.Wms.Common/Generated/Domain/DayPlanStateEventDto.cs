﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public abstract class DayPlanStateEventDtoBase : IStateEventDto, IDayPlanStateCreated, IDayPlanStateMergePatched, IDayPlanStateRemoved
	{

		public virtual DayPlanStateEventIdDto StateEventId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		DayPlanStateEventId IGlobalIdentity<DayPlanStateEventId>.GlobalId {
			get {
				return this.StateEventId.ToDayPlanStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IDayPlanStateEvent.ReadOnly
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

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IDayPlanStateMergePatched.IsPropertyDescriptionRemoved
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

        bool IDayPlanStateMergePatched.IsPropertyActiveRemoved
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


        DayPlanStateEventId IDayPlanStateEvent.StateEventId
        {
            get { return this.StateEventId.ToDayPlanStateEventId(); }
        }

        protected DayPlanStateEventDtoBase()
        {
        }

        protected DayPlanStateEventDtoBase(DayPlanStateEventIdDto stateEventId)
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


    public class DayPlanStateCreatedOrMergePatchedOrRemovedDto : DayPlanStateEventDtoBase
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



	public class DayPlanStateCreatedDto : DayPlanStateCreatedOrMergePatchedOrRemovedDto
	{
		public DayPlanStateCreatedDto()
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


	public class DayPlanStateMergePatchedDto : DayPlanStateCreatedOrMergePatchedOrRemovedDto
	{
		public DayPlanStateMergePatchedDto()
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


	public class DayPlanStateRemovedDto : DayPlanStateCreatedOrMergePatchedOrRemovedDto
	{
		public DayPlanStateRemovedDto()
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


    public partial class DayPlanStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IDayPlanStateCreated>, IEnumerable<IDayPlanStateMergePatched>, IEnumerable<IDayPlanStateRemoved>
    {
        private List<DayPlanStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<DayPlanStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual DayPlanStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<DayPlanStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDayPlanStateCreated> IEnumerable<IDayPlanStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDayPlanStateMergePatched> IEnumerable<IDayPlanStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDayPlanStateRemoved> IEnumerable<IDayPlanStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddDayPlanEvent(IDayPlanStateCreated e)
        {
            _innerStateEvents.Add((DayPlanStateCreatedDto)e);
        }

        public void AddDayPlanEvent(IDayPlanStateEvent e)
        {
            _innerStateEvents.Add((DayPlanStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddDayPlanEvent(IDayPlanStateRemoved e)
        {
            _innerStateEvents.Add((DayPlanStateRemovedDto)e);
        }

    }


}

