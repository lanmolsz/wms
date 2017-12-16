﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeUseMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeUseMvo;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeUseMvo
{

	public partial class AttributeUseMvoState : AttributeUseMvoStateProperties, IAttributeUseMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		AttributeSetAttributeUseId IGlobalIdentity<AttributeSetAttributeUseId>.GlobalId
		{
			get
			{
				return this.AttributeSetAttributeUseId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
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
				return this.AttributeSetVersion;
			}
		}


		#endregion

        bool IAttributeUseMvoState.IsUnsaved
        {
            get { return this.AttributeSetVersion == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
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

        public AttributeUseMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.AttributeSetAttributeUseId = ((IAttributeUseMvoStateEvent)events.First()).StateEventId.AttributeSetAttributeUseId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.AttributeSetVersion += 1;
                }
            }
        }

        public AttributeUseMvoState() : this(false)
        {
        }

        public AttributeUseMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IAttributeUseMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.SequenceNumber = (e.SequenceNumber != null && e.SequenceNumber.HasValue) ? e.SequenceNumber.Value : default(int);

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.AttributeSetAttributeSetName = e.AttributeSetAttributeSetName;

			this.AttributeSetOrganizationId = e.AttributeSetOrganizationId;

			this.AttributeSetDescription = e.AttributeSetDescription;

			this.AttributeSetSerialNumberAttributeId = e.AttributeSetSerialNumberAttributeId;

			this.AttributeSetLotAttributeId = e.AttributeSetLotAttributeId;

			this.AttributeSetReferenceId = e.AttributeSetReferenceId;

			this.AttributeSetCreatedBy = e.AttributeSetCreatedBy;

            this.AttributeSetCreatedAt = (e.AttributeSetCreatedAt != null && e.AttributeSetCreatedAt.HasValue) ? e.AttributeSetCreatedAt.Value : default(DateTime);

			this.AttributeSetUpdatedBy = e.AttributeSetUpdatedBy;

            this.AttributeSetUpdatedAt = (e.AttributeSetUpdatedAt != null && e.AttributeSetUpdatedAt.HasValue) ? e.AttributeSetUpdatedAt.Value : default(DateTime);

            this.AttributeSetActive = (e.AttributeSetActive != null && e.AttributeSetActive.HasValue) ? e.AttributeSetActive.Value : default(bool);

            this.AttributeSetDeleted = (e.AttributeSetDeleted != null && e.AttributeSetDeleted.HasValue) ? e.AttributeSetDeleted.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IAttributeUseMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.SequenceNumber == null)
			{
				if (e.IsPropertySequenceNumberRemoved)
				{
					this.SequenceNumber = default(int);
				}
			}
			else
			{
				this.SequenceNumber = (e.SequenceNumber != null && e.SequenceNumber.HasValue) ? e.SequenceNumber.Value : default(int);
			}

			if (e.Version == null)
			{
				if (e.IsPropertyVersionRemoved)
				{
					this.Version = default(long);
				}
			}
			else
			{
				this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}

			if (e.AttributeSetAttributeSetName == null)
			{
				if (e.IsPropertyAttributeSetAttributeSetNameRemoved)
				{
					this.AttributeSetAttributeSetName = default(string);
				}
			}
			else
			{
				this.AttributeSetAttributeSetName = e.AttributeSetAttributeSetName;
			}

			if (e.AttributeSetOrganizationId == null)
			{
				if (e.IsPropertyAttributeSetOrganizationIdRemoved)
				{
					this.AttributeSetOrganizationId = default(string);
				}
			}
			else
			{
				this.AttributeSetOrganizationId = e.AttributeSetOrganizationId;
			}

			if (e.AttributeSetDescription == null)
			{
				if (e.IsPropertyAttributeSetDescriptionRemoved)
				{
					this.AttributeSetDescription = default(string);
				}
			}
			else
			{
				this.AttributeSetDescription = e.AttributeSetDescription;
			}

			if (e.AttributeSetSerialNumberAttributeId == null)
			{
				if (e.IsPropertyAttributeSetSerialNumberAttributeIdRemoved)
				{
					this.AttributeSetSerialNumberAttributeId = default(string);
				}
			}
			else
			{
				this.AttributeSetSerialNumberAttributeId = e.AttributeSetSerialNumberAttributeId;
			}

			if (e.AttributeSetLotAttributeId == null)
			{
				if (e.IsPropertyAttributeSetLotAttributeIdRemoved)
				{
					this.AttributeSetLotAttributeId = default(string);
				}
			}
			else
			{
				this.AttributeSetLotAttributeId = e.AttributeSetLotAttributeId;
			}

			if (e.AttributeSetReferenceId == null)
			{
				if (e.IsPropertyAttributeSetReferenceIdRemoved)
				{
					this.AttributeSetReferenceId = default(string);
				}
			}
			else
			{
				this.AttributeSetReferenceId = e.AttributeSetReferenceId;
			}

			if (e.AttributeSetCreatedBy == null)
			{
				if (e.IsPropertyAttributeSetCreatedByRemoved)
				{
					this.AttributeSetCreatedBy = default(string);
				}
			}
			else
			{
				this.AttributeSetCreatedBy = e.AttributeSetCreatedBy;
			}

			if (e.AttributeSetCreatedAt == null)
			{
				if (e.IsPropertyAttributeSetCreatedAtRemoved)
				{
					this.AttributeSetCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.AttributeSetCreatedAt = (e.AttributeSetCreatedAt != null && e.AttributeSetCreatedAt.HasValue) ? e.AttributeSetCreatedAt.Value : default(DateTime);
			}

			if (e.AttributeSetUpdatedBy == null)
			{
				if (e.IsPropertyAttributeSetUpdatedByRemoved)
				{
					this.AttributeSetUpdatedBy = default(string);
				}
			}
			else
			{
				this.AttributeSetUpdatedBy = e.AttributeSetUpdatedBy;
			}

			if (e.AttributeSetUpdatedAt == null)
			{
				if (e.IsPropertyAttributeSetUpdatedAtRemoved)
				{
					this.AttributeSetUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.AttributeSetUpdatedAt = (e.AttributeSetUpdatedAt != null && e.AttributeSetUpdatedAt.HasValue) ? e.AttributeSetUpdatedAt.Value : default(DateTime);
			}

			if (e.AttributeSetActive == null)
			{
				if (e.IsPropertyAttributeSetActiveRemoved)
				{
					this.AttributeSetActive = default(bool);
				}
			}
			else
			{
				this.AttributeSetActive = (e.AttributeSetActive != null && e.AttributeSetActive.HasValue) ? e.AttributeSetActive.Value : default(bool);
			}

			if (e.AttributeSetDeleted == null)
			{
				if (e.IsPropertyAttributeSetDeletedRemoved)
				{
					this.AttributeSetDeleted = default(bool);
				}
			}
			else
			{
				this.AttributeSetDeleted = (e.AttributeSetDeleted != null && e.AttributeSetDeleted.HasValue) ? e.AttributeSetDeleted.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IAttributeUseMvoStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IAttributeUseMvoStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("AttributeUseMvo|");

            var stateEntityId = this.AttributeSetAttributeUseId; // Aggregate Id
            var eventEntityId = stateEvent.StateEventId.AttributeSetAttributeUseId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.AttributeSetVersion;
            var eventVersion = stateEvent.StateEventId.AttributeSetVersion;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

