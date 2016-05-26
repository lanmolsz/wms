﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public partial class AttributeValueState : AttributeValueStateProperties, IAttributeValueState
	{

		public virtual long Version { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }



		#region IIdentity implementation

        private AttributeValueId _attributeValueId = new AttributeValueId();

        public virtual AttributeValueId AttributeValueId 
        {
            get { return this._attributeValueId; }
            set { this._attributeValueId = value; }
        }

		AttributeValueId IGlobalIdentity<AttributeValueId>.GlobalId {
			get {
				return  this.AttributeValueId;
			}
		}

        string ILocalIdentity<string>.LocalId
        {
            get
            {
                return this.Value;
            }
        }


        public override string AttributeId {
			get {
				return this.AttributeValueId.AttributeId;
			}
			set {
				this.AttributeValueId.AttributeId = value;
			}
		}

        public override string Value {
			get {
				return this.AttributeValueId.Value;
			}
			set {
				this.AttributeValueId.Value = value;
			}
		}

		#endregion



		#region IActive implementation

		bool IActive.Active
		{
			get
			{
				return this.Active;
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
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get
			{
				return this.UpdatedBy;
			}
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get
			{
				return this.UpdatedAt;
			}
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


		public AttributeValueState ()
		{
		}



		public virtual void When(IAttributeValueStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.Name = e.Name;
			this.Description = e.Description;
			this.ReferenceId = e.ReferenceId;
			this.Active = e.Active;
			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IAttributeValueStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.IsPropertyNameRemoved)
			{
				this.Name = default(string);
			}
			else
			{
				if (e.Name != null)
				{
					this.Name = e.Name;
				}
			}
			if (e.IsPropertyDescriptionRemoved)
			{
				this.Description = default(string);
			}
			else
			{
				if (e.Description != null)
				{
					this.Description = e.Description;
				}
			}
			if (e.IsPropertyReferenceIdRemoved)
			{
				this.ReferenceId = default(string);
			}
			else
			{
				if (e.ReferenceId != null)
				{
					this.ReferenceId = e.ReferenceId;
				}
			}
			if (e.IsPropertyActiveRemoved)
			{
				this.Active = default(bool);
			}
			else
			{
				if (e.Active != null)
				{
					this.Active = e.Active;
				}
			}

			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}


		public virtual void Mutate(IEvent e)
		{
			((dynamic)this).When((dynamic)e);
		}

		protected void ThrowOnWrongEvent(IAttributeValueStateEvent stateEvent)
		{
				var stateEntityIdAttributeId = (this as IGlobalIdentity<AttributeValueId>).GlobalId.AttributeId;
				var eventEntityIdAttributeId = stateEvent.StateEventId.AttributeId;
				if (stateEntityIdAttributeId != eventEntityIdAttributeId)
				{
					DomainError.Named("mutateWrongEntity", "Entity Id AttributeId {0} in state but entity id AttributeId {1} in event", stateEntityIdAttributeId, eventEntityIdAttributeId);
				}

				var stateEntityIdValue = (this as IGlobalIdentity<AttributeValueId>).GlobalId.Value;
				var eventEntityIdValue = stateEvent.StateEventId.Value;
				if (stateEntityIdValue != eventEntityIdValue)
				{
					DomainError.Named("mutateWrongEntity", "Entity Id Value {0} in state but entity id Value {1} in event", stateEntityIdValue, eventEntityIdValue);
				}

			var stateVersion = this.Version;
			var eventVersion = stateEvent.Version;
			if (AttributeValueState.VersionZero == eventVersion)
			{
				eventVersion = stateEvent.Version = stateVersion;
			}
			if (stateVersion != eventVersion)
			{
				throw DomainError.Named("concurrencyConflict", "Conflict between state version {0} and event version {1}", stateVersion, eventVersion);
			}

		}
	}

}

