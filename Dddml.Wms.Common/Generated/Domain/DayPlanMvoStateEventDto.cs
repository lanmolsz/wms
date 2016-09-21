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

	public abstract class DayPlanMvoStateEventDtoBase : IStateEventDto, IDayPlanMvoStateCreated, IDayPlanMvoStateMergePatched, IDayPlanMvoStateDeleted
	{

		public virtual DayPlanMvoStateEventIdDto StateEventId { get; set; }

		public virtual string Description { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string MonthPlanDescription { get; set; }

		public virtual string MonthPlanCreatedBy { get; set; }

		public virtual string MonthPlanUpdatedBy { get; set; }

		public virtual long? MonthPlanVersion { get; set; }

		public virtual DateTime? MonthPlanCreatedAt { get; set; }

		public virtual DateTime? MonthPlanUpdatedAt { get; set; }

		public virtual bool? MonthPlanActive { get; set; }

		public virtual bool? MonthPlanDeleted { get; set; }

		public virtual string YearPlanDescription { get; set; }

		public virtual string YearPlanCreatedBy { get; set; }

		public virtual string YearPlanUpdatedBy { get; set; }

		public virtual long? YearPlanVersion { get; set; }

		public virtual DateTime? YearPlanCreatedAt { get; set; }

		public virtual DateTime? YearPlanUpdatedAt { get; set; }

		public virtual bool? YearPlanActive { get; set; }

		public virtual bool? YearPlanDeleted { get; set; }

		public virtual DateTime? PersonBirthDate { get; set; }

		public virtual PersonalName PersonLoves { get; set; }

		public virtual Contact PersonEmergencyContact { get; set; }

		public virtual string PersonCreatedBy { get; set; }

		public virtual string PersonUpdatedBy { get; set; }

		public virtual DateTime? PersonCreatedAt { get; set; }

		public virtual DateTime? PersonUpdatedAt { get; set; }

		public virtual bool? PersonActive { get; set; }

		public virtual bool? PersonDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		DayPlanMvoStateEventId IGlobalIdentity<DayPlanMvoStateEventId>.GlobalId {
			get {
				return this.StateEventId.ToDayPlanMvoStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IDayPlanMvoStateEvent.ReadOnly
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

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyVersionRemoved
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

        bool IDayPlanMvoStateMergePatched.IsPropertyActiveRemoved
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

		public virtual bool? IsPropertyMonthPlanDescriptionRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyMonthPlanDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyMonthPlanDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMonthPlanDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanCreatedByRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyMonthPlanCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyMonthPlanCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMonthPlanCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanUpdatedByRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyMonthPlanUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyMonthPlanUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMonthPlanUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanVersionRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyMonthPlanVersionRemoved
        {
            get 
            {
                var b = this.IsPropertyMonthPlanVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMonthPlanVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanCreatedAtRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyMonthPlanCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyMonthPlanCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMonthPlanCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanUpdatedAtRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyMonthPlanUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyMonthPlanUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMonthPlanUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanActiveRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyMonthPlanActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyMonthPlanActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMonthPlanActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanDeletedRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyMonthPlanDeletedRemoved
        {
            get 
            {
                var b = this.IsPropertyMonthPlanDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMonthPlanDeletedRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanDescriptionRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyYearPlanDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyYearPlanDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyYearPlanDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanCreatedByRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyYearPlanCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyYearPlanCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyYearPlanCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanUpdatedByRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyYearPlanUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyYearPlanUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyYearPlanUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanVersionRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyYearPlanVersionRemoved
        {
            get 
            {
                var b = this.IsPropertyYearPlanVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyYearPlanVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanCreatedAtRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyYearPlanCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyYearPlanCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyYearPlanCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanUpdatedAtRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyYearPlanUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyYearPlanUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyYearPlanUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanActiveRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyYearPlanActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyYearPlanActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyYearPlanActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanDeletedRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyYearPlanDeletedRemoved
        {
            get 
            {
                var b = this.IsPropertyYearPlanDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyYearPlanDeletedRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonBirthDateRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyPersonBirthDateRemoved
        {
            get 
            {
                var b = this.IsPropertyPersonBirthDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPersonBirthDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonLovesRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyPersonLovesRemoved
        {
            get 
            {
                var b = this.IsPropertyPersonLovesRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPersonLovesRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonEmergencyContactRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyPersonEmergencyContactRemoved
        {
            get 
            {
                var b = this.IsPropertyPersonEmergencyContactRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPersonEmergencyContactRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonCreatedByRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyPersonCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyPersonCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPersonCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonUpdatedByRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyPersonUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyPersonUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPersonUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonCreatedAtRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyPersonCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyPersonCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPersonCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonUpdatedAtRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyPersonUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyPersonUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPersonUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonActiveRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyPersonActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyPersonActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPersonActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonDeletedRemoved { get; set; }

        bool IDayPlanMvoStateMergePatched.IsPropertyPersonDeletedRemoved
        {
            get 
            {
                var b = this.IsPropertyPersonDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPersonDeletedRemoved = value;
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


        DayPlanMvoStateEventId IDayPlanMvoStateEvent.StateEventId
        {
            get { return this.StateEventId.ToDayPlanMvoStateEventId(); }
        }

        protected DayPlanMvoStateEventDtoBase()
        {
        }

        protected DayPlanMvoStateEventDtoBase(DayPlanMvoStateEventIdDto stateEventId)
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


    public class DayPlanMvoStateCreatedOrMergePatchedOrDeletedDto : DayPlanMvoStateEventDtoBase
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



	public class DayPlanMvoStateCreatedDto : DayPlanMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public DayPlanMvoStateCreatedDto()
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


	public class DayPlanMvoStateMergePatchedDto : DayPlanMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public DayPlanMvoStateMergePatchedDto()
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


	public class DayPlanMvoStateDeletedDto : DayPlanMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public DayPlanMvoStateDeletedDto()
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


    public partial class DayPlanMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IDayPlanMvoStateCreated>, IEnumerable<IDayPlanMvoStateMergePatched>, IEnumerable<IDayPlanMvoStateDeleted>
    {
        private List<DayPlanMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<DayPlanMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual DayPlanMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<DayPlanMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDayPlanMvoStateCreated> IEnumerable<IDayPlanMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDayPlanMvoStateMergePatched> IEnumerable<IDayPlanMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IDayPlanMvoStateDeleted> IEnumerable<IDayPlanMvoStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddDayPlanMvoEvent(IDayPlanMvoStateCreated e)
        {
            _innerStateEvents.Add((DayPlanMvoStateCreatedDto)e);
        }

        public void AddDayPlanMvoEvent(IDayPlanMvoStateEvent e)
        {
            _innerStateEvents.Add((DayPlanMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddDayPlanMvoEvent(IDayPlanMvoStateDeleted e)
        {
            _innerStateEvents.Add((DayPlanMvoStateDeletedDto)e);
        }

    }


}

