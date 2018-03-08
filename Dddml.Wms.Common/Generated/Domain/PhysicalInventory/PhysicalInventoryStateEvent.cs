﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.PhysicalInventory
{

	public abstract class PhysicalInventoryStateEventBase : IPhysicalInventoryStateEvent
	{

		public virtual PhysicalInventoryEventId StateEventId { get; set; }

        public virtual string DocumentNumber
        {
            get { return StateEventId.DocumentNumber; }
            set { StateEventId.DocumentNumber = value; }
        }

		public virtual string DocumentStatusId { get; set; }

		public virtual string WarehouseId { get; set; }

		public virtual string LocatorIdPattern { get; set; }

		public virtual string ProductIdPattern { get; set; }

		public virtual bool? Posted { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string Processing { get; set; }

		public virtual string DocumentTypeId { get; set; }

		public virtual DateTime? MovementDate { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? IsApproved { get; set; }

		public virtual decimal? ApprovalAmount { get; set; }

		public virtual bool? IsQuantityUpdated { get; set; }

		public virtual string ReversalDocumentNumber { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		PhysicalInventoryEventId IGlobalIdentity<PhysicalInventoryEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IPhysicalInventoryStateEvent.ReadOnly
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

        protected PhysicalInventoryStateEventBase()
        {
        }

        protected PhysicalInventoryStateEventBase(PhysicalInventoryEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }

		protected IPhysicalInventoryLineStateEventDao PhysicalInventoryLineStateEventDao
		{
			get { return ApplicationContext.Current["PhysicalInventoryLineStateEventDao"] as IPhysicalInventoryLineStateEventDao; }
		}

        protected PhysicalInventoryLineEventId NewPhysicalInventoryLineEventId(InventoryItemId inventoryItemId)
        {
            var stateEventId = new PhysicalInventoryLineEventId(this.StateEventId.DocumentNumber, inventoryItemId, this.StateEventId.Version);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IPhysicalInventoryLineStateEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IPhysicalInventoryStateEvent oe, IPhysicalInventoryLineStateEvent e)
		{
			if (!oe.StateEventId.DocumentNumber.Equals(e.StateEventId.PhysicalInventoryDocumentNumber))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id DocumentNumber {0} but inner id PhysicalInventoryDocumentNumber {1}", 
					oe.StateEventId.DocumentNumber, e.StateEventId.PhysicalInventoryDocumentNumber);
			}
		}



        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class PhysicalInventoryStateCreated : PhysicalInventoryStateEventBase, IPhysicalInventoryStateCreated, ISaveable
	{
		public PhysicalInventoryStateCreated () : this(new PhysicalInventoryEventId())
		{
		}

		public PhysicalInventoryStateCreated (PhysicalInventoryEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<PhysicalInventoryLineEventId, IPhysicalInventoryLineStateCreated> _physicalInventoryLineEvents = new Dictionary<PhysicalInventoryLineEventId, IPhysicalInventoryLineStateCreated>();
        
        private IEnumerable<IPhysicalInventoryLineStateCreated> _readOnlyPhysicalInventoryLineEvents;

        public virtual IEnumerable<IPhysicalInventoryLineStateCreated> PhysicalInventoryLineEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
                    return this._physicalInventoryLineEvents.Values;
                }
                else
                {
                    if (_readOnlyPhysicalInventoryLineEvents != null) { return _readOnlyPhysicalInventoryLineEvents; }
                    var eventDao = PhysicalInventoryLineStateEventDao;
                    var eL = new List<IPhysicalInventoryLineStateCreated>();
                    foreach (var e in eventDao.FindByPhysicalInventoryEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IPhysicalInventoryLineStateCreated)e);
                    }
                    return (_readOnlyPhysicalInventoryLineEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddPhysicalInventoryLineEvent(e);
                    }
                }
                else { this._physicalInventoryLineEvents.Clear(); }
            }
        }
    
		public virtual void AddPhysicalInventoryLineEvent(IPhysicalInventoryLineStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._physicalInventoryLineEvents[e.StateEventId] = e;
		}

        public virtual IPhysicalInventoryLineStateCreated NewPhysicalInventoryLineStateCreated(InventoryItemId inventoryItemId)
        {
            var stateEvent = new PhysicalInventoryLineStateCreated(NewPhysicalInventoryLineEventId(inventoryItemId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IPhysicalInventoryLineStateCreated e in this.PhysicalInventoryLineEvents) {
				PhysicalInventoryLineStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class PhysicalInventoryStateMergePatched : PhysicalInventoryStateEventBase, IPhysicalInventoryStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyDocumentStatusIdRemoved { get; set; }

		public virtual bool IsPropertyWarehouseIdRemoved { get; set; }

		public virtual bool IsPropertyLocatorIdPatternRemoved { get; set; }

		public virtual bool IsPropertyProductIdPatternRemoved { get; set; }

		public virtual bool IsPropertyPostedRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyProcessingRemoved { get; set; }

		public virtual bool IsPropertyDocumentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyMovementDateRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyIsApprovedRemoved { get; set; }

		public virtual bool IsPropertyApprovalAmountRemoved { get; set; }

		public virtual bool IsPropertyIsQuantityUpdatedRemoved { get; set; }

		public virtual bool IsPropertyReversalDocumentNumberRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public PhysicalInventoryStateMergePatched ()
		{
		}

		public PhysicalInventoryStateMergePatched (PhysicalInventoryEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<PhysicalInventoryLineEventId, IPhysicalInventoryLineStateEvent> _physicalInventoryLineEvents = new Dictionary<PhysicalInventoryLineEventId, IPhysicalInventoryLineStateEvent>();

        private IEnumerable<IPhysicalInventoryLineStateEvent> _readOnlyPhysicalInventoryLineEvents;
        
        public virtual IEnumerable<IPhysicalInventoryLineStateEvent> PhysicalInventoryLineEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
                    return this._physicalInventoryLineEvents.Values;
                }
                else
                {
                    if (_readOnlyPhysicalInventoryLineEvents != null) { return _readOnlyPhysicalInventoryLineEvents; }
                    var eventDao = PhysicalInventoryLineStateEventDao;
                    var eL = new List<IPhysicalInventoryLineStateEvent>();
                    foreach (var e in eventDao.FindByPhysicalInventoryEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IPhysicalInventoryLineStateEvent)e);
                    }
                    return (_readOnlyPhysicalInventoryLineEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddPhysicalInventoryLineEvent(e);
                    }
                }
                else { this._physicalInventoryLineEvents.Clear(); }
            }
        }

		public virtual void AddPhysicalInventoryLineEvent(IPhysicalInventoryLineStateEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._physicalInventoryLineEvents[e.StateEventId] = e;
		}

        public virtual IPhysicalInventoryLineStateCreated NewPhysicalInventoryLineStateCreated(InventoryItemId inventoryItemId)
        {
            var stateEvent = new PhysicalInventoryLineStateCreated(NewPhysicalInventoryLineEventId(inventoryItemId));
            return stateEvent;
        }

        public virtual IPhysicalInventoryLineStateMergePatched NewPhysicalInventoryLineStateMergePatched(InventoryItemId inventoryItemId)
        {
            var stateEvent = new PhysicalInventoryLineStateMergePatched(NewPhysicalInventoryLineEventId(inventoryItemId));
            return stateEvent;
        }

        public virtual IPhysicalInventoryLineStateRemoved NewPhysicalInventoryLineStateRemoved(InventoryItemId inventoryItemId)
        {
            var stateEvent = new PhysicalInventoryLineStateRemoved(NewPhysicalInventoryLineEventId(inventoryItemId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IPhysicalInventoryLineStateEvent e in this.PhysicalInventoryLineEvents) {
				PhysicalInventoryLineStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}

