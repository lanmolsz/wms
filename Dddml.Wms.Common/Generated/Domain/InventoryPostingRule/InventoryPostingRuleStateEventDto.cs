﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryPostingRuleDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryPostingRule;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryPostingRule
{

	public abstract class InventoryPostingRuleStateEventDtoBase : IStateEventDto, IInventoryPostingRuleStateCreated, IInventoryPostingRuleStateMergePatched, IInventoryPostingRuleStateDeleted
	{

        private InventoryPostingRuleEventIdDto _stateEventId;

		protected internal virtual InventoryPostingRuleEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new InventoryPostingRuleEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string InventoryPostingRuleId
        {
            get { return StateEventId.InventoryPostingRuleId; }
            set { StateEventId.InventoryPostingRuleId = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		private InventoryItemIdDto _triggerInventoryItemId = new InventoryItemIdDto();

		public virtual InventoryItemIdDto TriggerInventoryItemId { get { return _triggerInventoryItemId; } set { _triggerInventoryItemId = value; } }

		InventoryItemId IInventoryPostingRuleStateEvent.TriggerInventoryItemId
		{ 
			get 
			{
				return this.TriggerInventoryItemId == null ? null : this.TriggerInventoryItemId.ToInventoryItemId(); 
			} 
			set
			{
				if (value == null) { TriggerInventoryItemId = null; } else { TriggerInventoryItemId = new InventoryItemIdDtoWrapper(value); }
			} 
		}

		private InventoryItemIdDto _outputInventoryItemId = new InventoryItemIdDto();

		public virtual InventoryItemIdDto OutputInventoryItemId { get { return _outputInventoryItemId; } set { _outputInventoryItemId = value; } }

		InventoryItemId IInventoryPostingRuleStateEvent.OutputInventoryItemId
		{ 
			get 
			{
				return this.OutputInventoryItemId == null ? null : this.OutputInventoryItemId.ToInventoryItemId(); 
			} 
			set
			{
				if (value == null) { OutputInventoryItemId = null; } else { OutputInventoryItemId = new InventoryItemIdDtoWrapper(value); }
			} 
		}

		public virtual string TriggerAccountName { get; set; }

		public virtual string OutputAccountName { get; set; }

		public virtual bool? IsOutputNegated { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InventoryPostingRuleEventId IGlobalIdentity<InventoryPostingRuleEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToInventoryPostingRuleEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IInventoryPostingRuleStateEvent.ReadOnly
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

		public virtual bool? IsPropertyTriggerInventoryItemIdRemoved { get; set; }

        bool IInventoryPostingRuleStateMergePatched.IsPropertyTriggerInventoryItemIdRemoved
        {
            get 
            {
                var b = this.IsPropertyTriggerInventoryItemIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyTriggerInventoryItemIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOutputInventoryItemIdRemoved { get; set; }

        bool IInventoryPostingRuleStateMergePatched.IsPropertyOutputInventoryItemIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOutputInventoryItemIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOutputInventoryItemIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyTriggerAccountNameRemoved { get; set; }

        bool IInventoryPostingRuleStateMergePatched.IsPropertyTriggerAccountNameRemoved
        {
            get 
            {
                var b = this.IsPropertyTriggerAccountNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyTriggerAccountNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyOutputAccountNameRemoved { get; set; }

        bool IInventoryPostingRuleStateMergePatched.IsPropertyOutputAccountNameRemoved
        {
            get 
            {
                var b = this.IsPropertyOutputAccountNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOutputAccountNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsOutputNegatedRemoved { get; set; }

        bool IInventoryPostingRuleStateMergePatched.IsPropertyIsOutputNegatedRemoved
        {
            get 
            {
                var b = this.IsPropertyIsOutputNegatedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsOutputNegatedRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IInventoryPostingRuleStateMergePatched.IsPropertyActiveRemoved
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


        InventoryPostingRuleEventId IInventoryPostingRuleStateEvent.StateEventId
        {
            get { return this.StateEventId.ToInventoryPostingRuleEventId(); }
        }

        protected InventoryPostingRuleStateEventDtoBase()
        {
        }

        protected InventoryPostingRuleStateEventDtoBase(InventoryPostingRuleEventIdDto stateEventId)
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


    public class InventoryPostingRuleStateCreatedOrMergePatchedOrDeletedDto : InventoryPostingRuleStateEventDtoBase
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



	public class InventoryPostingRuleStateCreatedDto : InventoryPostingRuleStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryPostingRuleStateCreatedDto()
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


	public class InventoryPostingRuleStateMergePatchedDto : InventoryPostingRuleStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryPostingRuleStateMergePatchedDto()
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


	public class InventoryPostingRuleStateDeletedDto : InventoryPostingRuleStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryPostingRuleStateDeletedDto()
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


    public partial class InventoryPostingRuleStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IInventoryPostingRuleStateCreated>, IEnumerable<IInventoryPostingRuleStateMergePatched>, IEnumerable<IInventoryPostingRuleStateDeleted>
    {
        private List<InventoryPostingRuleStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<InventoryPostingRuleStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual InventoryPostingRuleStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<InventoryPostingRuleStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInventoryPostingRuleStateCreated> IEnumerable<IInventoryPostingRuleStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInventoryPostingRuleStateMergePatched> IEnumerable<IInventoryPostingRuleStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInventoryPostingRuleStateDeleted> IEnumerable<IInventoryPostingRuleStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddInventoryPostingRuleEvent(IInventoryPostingRuleStateCreated e)
        {
            _innerStateEvents.Add((InventoryPostingRuleStateCreatedDto)e);
        }

        public void AddInventoryPostingRuleEvent(IInventoryPostingRuleStateEvent e)
        {
            _innerStateEvents.Add((InventoryPostingRuleStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddInventoryPostingRuleEvent(IInventoryPostingRuleStateDeleted e)
        {
            _innerStateEvents.Add((InventoryPostingRuleStateDeletedDto)e);
        }

    }


}

