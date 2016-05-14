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

	public partial class AttributeState : AttributeStateProperties, IAttributeState, ISaveable
	{

		public virtual long Version { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get
			{
				return this.AttributeId;
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


        private IAttributeValueStates _attributeValues;
      
        public virtual IAttributeValueStates AttributeValues
        {
            get
            {
                return this._attributeValues;
            }
        }

        protected internal virtual void SetAttributeValues(IAttributeValueStates value)
        {
            this._attributeValues = value;
        }



		public AttributeState ()
		{
            _attributeValues = new AttributeValueStates(this);

		}



		#region Saveable Implements

        public virtual void Save()
        {
            _attributeValues.Save();

        }


		#endregion


		public virtual void When(IAttributeStateCreated e)
		{
			ThrowOnWrongEvent(e);
			ReflectUtils.CopyPropertyValue("Name", e, this);
			ReflectUtils.CopyPropertyValue("Description", e, this);
			ReflectUtils.CopyPropertyValue("IsMandatory", e, this);
			ReflectUtils.CopyPropertyValue("IsInstanceAttribute", e, this);
			ReflectUtils.CopyPropertyValue("AttributeValueType", e, this);
			ReflectUtils.CopyPropertyValue("FieldName", e, this);
			ReflectUtils.CopyPropertyValue("Active", e, this);
			ReflectUtils.SetPropertyValue("CreatedBy", this, e.CreatedBy);
			ReflectUtils.SetPropertyValue("CreatedAt", this, e.CreatedAt);

			foreach (IAttributeValueStateCreated innerEvent in e.AttributeValueEvents) {
				IAttributeValueState innerState = this.AttributeValues.Get(innerEvent.GlobalId.AttributeValueValue);
				innerState.Mutate (innerEvent);
			}

		}


		public virtual void When(IAttributeStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.IsPropertyNameRemoved)
			{
				ReflectUtils.SetPropertyValue("Name", this, default(string));
			}
			else
			{
				if (e.Name != null)
				{
					ReflectUtils.CopyPropertyValue("Name", e, this);
				}
			}
			if (e.IsPropertyDescriptionRemoved)
			{
				ReflectUtils.SetPropertyValue("Description", this, default(string));
			}
			else
			{
				if (e.Description != null)
				{
					ReflectUtils.CopyPropertyValue("Description", e, this);
				}
			}
			if (e.IsPropertyIsMandatoryRemoved)
			{
				ReflectUtils.SetPropertyValue("IsMandatory", this, default(bool));
			}
			else
			{
				if (e.IsMandatory != null)
				{
					ReflectUtils.CopyPropertyValue("IsMandatory", e, this);
				}
			}
			if (e.IsPropertyIsInstanceAttributeRemoved)
			{
				ReflectUtils.SetPropertyValue("IsInstanceAttribute", this, default(bool));
			}
			else
			{
				if (e.IsInstanceAttribute != null)
				{
					ReflectUtils.CopyPropertyValue("IsInstanceAttribute", e, this);
				}
			}
			if (e.IsPropertyAttributeValueTypeRemoved)
			{
				ReflectUtils.SetPropertyValue("AttributeValueType", this, default(string));
			}
			else
			{
				if (e.AttributeValueType != null)
				{
					ReflectUtils.CopyPropertyValue("AttributeValueType", e, this);
				}
			}
			if (e.IsPropertyFieldNameRemoved)
			{
				ReflectUtils.SetPropertyValue("FieldName", this, default(string));
			}
			else
			{
				if (e.FieldName != null)
				{
					ReflectUtils.CopyPropertyValue("FieldName", e, this);
				}
			}
			if (e.IsPropertyActiveRemoved)
			{
				ReflectUtils.SetPropertyValue("Active", this, default(bool));
			}
			else
			{
				if (e.Active != null)
				{
					ReflectUtils.CopyPropertyValue("Active", e, this);
				}
			}

			ReflectUtils.SetPropertyValue("UpdatedBy", this, e.CreatedBy);
			ReflectUtils.SetPropertyValue("UpdatedAt", this, e.CreatedAt);


			foreach (IAttributeValueStateEvent innerEvent in e.AttributeValueEvents)
            {
                IAttributeValueState innerState = this.AttributeValues.Get(innerEvent.GlobalId.AttributeValueValue);

                var removed = innerEvent as IAttributeValueStateRemoved;
                if (removed != null)
                {
                    this.AttributeValues.Remove(innerState);
                }
                else
                {
                    innerState.Mutate(innerEvent);
                }
            }

		}

		public virtual void When(IAttributeStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			ReflectUtils.SetPropertyValue("Deleted", this, true);
			ReflectUtils.SetPropertyValue("UpdatedBy", this, e.CreatedBy);
			ReflectUtils.SetPropertyValue("UpdatedAt", this, e.CreatedAt);
		}


		public virtual void Mutate(IEvent e)
		{
			((dynamic)this).When((dynamic)e);
		}

		protected void ThrowOnWrongEvent(IAttributeStateEvent stateEvent)
		{
			var stateEntityId = this.AttributeId; // Aggregate Id
			var eventEntityId = stateEvent.StateEventId.AttributeId;
			if (stateEntityId != eventEntityId)
			{
				DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
			}
			var stateVersion = this.Version;
			var eventVersion = stateEvent.StateEventId.AttributeVersion;
			if (stateVersion != eventVersion)
			{
				throw DomainError.Named("concurrencyConflict", "Conflict between state version {0} and event version {1}", stateVersion, eventVersion);
			}

		}
	}

}

