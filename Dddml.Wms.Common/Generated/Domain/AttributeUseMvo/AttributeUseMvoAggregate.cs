﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeUseMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeUseMvo;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeUseMvo
{
    public partial class AttributeUseMvoAggregate : AggregateBase, IAttributeUseMvoAggregate
    {

        readonly IAttributeUseMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IAttributeUseMvoState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        AttributeSetAttributeUseId IGlobalIdentity<AttributeSetAttributeUseId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public AttributeUseMvoAggregate(IAttributeUseMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IAttributeUseMvoStateProperties)_state).AttributeSetVersion == AttributeUseMvoState.VersionZero)
            {
                if (IsCommandCreate((IAttributeUseMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IAttributeUseMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IAttributeUseMvoCommand c)
        {
            return c.AttributeSetVersion == AttributeUseMvoState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateAttributeUseMvo c)
        {
            IAttributeUseMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchAttributeUseMvo c)
        {
            IAttributeUseMvoStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteAttributeUseMvo c)
        {
            IAttributeUseMvoStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IAttributeUseMvoStateCreated Map(ICreateAttributeUseMvo c)
        {
			var stateEventId = new AttributeUseMvoStateEventId(c.AttributeSetAttributeUseId, c.AttributeSetVersion);
            IAttributeUseMvoStateCreated e = NewAttributeUseMvoStateCreated(stateEventId);
		
            e.SequenceNumber = c.SequenceNumber;
            e.Version = c.Version;
            e.Active = c.Active;
            e.AttributeSetAttributeSetName = c.AttributeSetAttributeSetName;
            e.AttributeSetOrganizationId = c.AttributeSetOrganizationId;
            e.AttributeSetDescription = c.AttributeSetDescription;
            e.AttributeSetSerialNumberAttributeId = c.AttributeSetSerialNumberAttributeId;
            e.AttributeSetLotAttributeId = c.AttributeSetLotAttributeId;
            e.AttributeSetReferenceId = c.AttributeSetReferenceId;
            e.AttributeSetCreatedBy = c.AttributeSetCreatedBy;
            e.AttributeSetCreatedAt = c.AttributeSetCreatedAt;
            e.AttributeSetUpdatedBy = c.AttributeSetUpdatedBy;
            e.AttributeSetUpdatedAt = c.AttributeSetUpdatedAt;
            e.AttributeSetActive = c.AttributeSetActive;
            e.AttributeSetDeleted = c.AttributeSetDeleted;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var attributeSetVersion = c.AttributeSetVersion;


            return e;
        }

        protected virtual IAttributeUseMvoStateMergePatched Map(IMergePatchAttributeUseMvo c)
        {
			var stateEventId = new AttributeUseMvoStateEventId(c.AttributeSetAttributeUseId, c.AttributeSetVersion);
            IAttributeUseMvoStateMergePatched e = NewAttributeUseMvoStateMergePatched(stateEventId);

            e.SequenceNumber = c.SequenceNumber;
            e.Version = c.Version;
            e.Active = c.Active;
            e.AttributeSetAttributeSetName = c.AttributeSetAttributeSetName;
            e.AttributeSetOrganizationId = c.AttributeSetOrganizationId;
            e.AttributeSetDescription = c.AttributeSetDescription;
            e.AttributeSetSerialNumberAttributeId = c.AttributeSetSerialNumberAttributeId;
            e.AttributeSetLotAttributeId = c.AttributeSetLotAttributeId;
            e.AttributeSetReferenceId = c.AttributeSetReferenceId;
            e.AttributeSetCreatedBy = c.AttributeSetCreatedBy;
            e.AttributeSetCreatedAt = c.AttributeSetCreatedAt;
            e.AttributeSetUpdatedBy = c.AttributeSetUpdatedBy;
            e.AttributeSetUpdatedAt = c.AttributeSetUpdatedAt;
            e.AttributeSetActive = c.AttributeSetActive;
            e.AttributeSetDeleted = c.AttributeSetDeleted;
            e.IsPropertySequenceNumberRemoved = c.IsPropertySequenceNumberRemoved;
            e.IsPropertyVersionRemoved = c.IsPropertyVersionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;
            e.IsPropertyAttributeSetAttributeSetNameRemoved = c.IsPropertyAttributeSetAttributeSetNameRemoved;
            e.IsPropertyAttributeSetOrganizationIdRemoved = c.IsPropertyAttributeSetOrganizationIdRemoved;
            e.IsPropertyAttributeSetDescriptionRemoved = c.IsPropertyAttributeSetDescriptionRemoved;
            e.IsPropertyAttributeSetSerialNumberAttributeIdRemoved = c.IsPropertyAttributeSetSerialNumberAttributeIdRemoved;
            e.IsPropertyAttributeSetLotAttributeIdRemoved = c.IsPropertyAttributeSetLotAttributeIdRemoved;
            e.IsPropertyAttributeSetReferenceIdRemoved = c.IsPropertyAttributeSetReferenceIdRemoved;
            e.IsPropertyAttributeSetCreatedByRemoved = c.IsPropertyAttributeSetCreatedByRemoved;
            e.IsPropertyAttributeSetCreatedAtRemoved = c.IsPropertyAttributeSetCreatedAtRemoved;
            e.IsPropertyAttributeSetUpdatedByRemoved = c.IsPropertyAttributeSetUpdatedByRemoved;
            e.IsPropertyAttributeSetUpdatedAtRemoved = c.IsPropertyAttributeSetUpdatedAtRemoved;
            e.IsPropertyAttributeSetActiveRemoved = c.IsPropertyAttributeSetActiveRemoved;
            e.IsPropertyAttributeSetDeletedRemoved = c.IsPropertyAttributeSetDeletedRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var attributeSetVersion = c.AttributeSetVersion;


            return e;
        }

        protected virtual IAttributeUseMvoStateDeleted Map(IDeleteAttributeUseMvo c)
        {
			var stateEventId = new AttributeUseMvoStateEventId(c.AttributeSetAttributeUseId, c.AttributeSetVersion);
            IAttributeUseMvoStateDeleted e = NewAttributeUseMvoStateDeleted(stateEventId);
			
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();


            return e;
        }

        private void ThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected AttributeUseMvoStateCreated NewAttributeUseMvoStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new AttributeUseMvoStateEventId(_state.AttributeSetAttributeUseId, ((IAttributeUseMvoStateProperties)_state).AttributeSetVersion);
            var e = NewAttributeUseMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected AttributeUseMvoStateMergePatched NewAttributeUseMvoStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new AttributeUseMvoStateEventId(_state.AttributeSetAttributeUseId, ((IAttributeUseMvoStateProperties)_state).AttributeSetVersion);
            var e = NewAttributeUseMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected AttributeUseMvoStateDeleted NewAttributeUseMvoStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new AttributeUseMvoStateEventId(_state.AttributeSetAttributeUseId, ((IAttributeUseMvoStateProperties)_state).AttributeSetVersion);
            var e = NewAttributeUseMvoStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private AttributeUseMvoStateCreated NewAttributeUseMvoStateCreated(AttributeUseMvoStateEventId stateEventId)
		{
			return new AttributeUseMvoStateCreated(stateEventId);			
		}

        private AttributeUseMvoStateMergePatched NewAttributeUseMvoStateMergePatched(AttributeUseMvoStateEventId stateEventId)
		{
			return new AttributeUseMvoStateMergePatched(stateEventId);
		}

        private AttributeUseMvoStateDeleted NewAttributeUseMvoStateDeleted(AttributeUseMvoStateEventId stateEventId)
		{
			return new AttributeUseMvoStateDeleted(stateEventId);
		}

    }

}

