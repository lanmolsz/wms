﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirement
{

	public partial class InventoryItemRequirementState : InventoryItemRequirementStateProperties, IInventoryItemRequirementState, ISaveable
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

        public virtual string CommandId { get; set; }


		#region IIdentity implementation

		InventoryItemId IGlobalIdentity<InventoryItemId>.GlobalId
		{
			get
			{
				return this.InventoryItemRequirementId;
			}
		}

		#endregion


		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IInventoryItemRequirementState.IsUnsaved
        {
            get { return this.Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        private IInventoryItemRequirementEntryStates _entries;
      
        public virtual IInventoryItemRequirementEntryStates Entries
        {
            get
            {
                return this._entries;
            }
            set
            {
                this._entries = value;
            }
        }


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public InventoryItemRequirementState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.InventoryItemRequirementId = ((IInventoryItemRequirementStateEvent)events.First()).StateEventId.InventoryItemRequirementId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
        }

        public InventoryItemRequirementState() : this(false)
        {
        }

        public InventoryItemRequirementState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            _entries = new InventoryItemRequirementEntryStates(this);

            InitializeProperties();
        }


		#region Saveable Implements

        public virtual void Save()
        {
            _entries.Save();

        }


		#endregion


		public virtual void When(IInventoryItemRequirementStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.Quantity = (e.Quantity != null && e.Quantity.HasValue) ? e.Quantity.Value : default(decimal);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;

			foreach (IInventoryItemRequirementEntryStateCreated innerEvent in e.InventoryItemRequirementEntryEvents) {
				IInventoryItemRequirementEntryState innerState = this.Entries.Get(innerEvent.GlobalId.EntrySeqId, true);
				innerState.Mutate (innerEvent);
			}

		}


		public virtual void When(IInventoryItemRequirementStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.Quantity == null)
			{
				if (e.IsPropertyQuantityRemoved)
				{
					this.Quantity = default(decimal);
				}
			}
			else
			{
				this.Quantity = (e.Quantity != null && e.Quantity.HasValue) ? e.Quantity.Value : default(decimal);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


			foreach (IInventoryItemRequirementEntryStateEvent innerEvent in e.InventoryItemRequirementEntryEvents)
            {
                IInventoryItemRequirementEntryState innerState = this.Entries.Get(innerEvent.GlobalId.EntrySeqId);

                innerState.Mutate(innerEvent);
          
            }

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IInventoryItemRequirementStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("InventoryItemRequirement|");

            var stateEntityId = this.InventoryItemRequirementId; // Aggregate Id
            var eventEntityId = stateEvent.StateEventId.InventoryItemRequirementId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.Version;
            var eventVersion = stateEvent.StateEventId.Version;
            if (stateVersion > eventVersion)//!=
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

