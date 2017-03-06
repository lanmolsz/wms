﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{
    public partial class AttributeAggregate : AggregateBase, IAttributeAggregate
    {

        readonly IAttributeState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IAttributeState State
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

        string IGlobalIdentity<string>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public AttributeAggregate(IAttributeState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IAttributeStateProperties)_state).Version == AttributeState.VersionZero)
            {
                if (IsCommandCreate((IAttributeCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IAttributeCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IAttributeCommand c)
        {
            return c.Version == AttributeState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateAttribute c)
        {
            IAttributeStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchAttribute c)
        {
            IAttributeStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteAttribute c)
        {
            IAttributeStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IAttributeStateCreated Map(ICreateAttribute c)
        {
			var stateEventId = new AttributeStateEventId(c.AttributeId, c.Version);
            IAttributeStateCreated e = NewAttributeStateCreated(stateEventId);
		
            e.Name = c.Name;
            e.OrganizationId = c.OrganizationId;
            e.Description = c.Description;
            e.IsMandatory = c.IsMandatory;
            e.IsInstanceAttribute = c.IsInstanceAttribute;
            e.AttributeValueType = c.AttributeValueType;
            e.AttributeValueLength = c.AttributeValueLength;
            e.IsList = c.IsList;
            e.FieldName = c.FieldName;
            e.ReferenceId = c.ReferenceId;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var version = c.Version;

            foreach (ICreateAttributeValue innerCommand in c.AttributeValues)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IAttributeValueStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddAttributeValueEvent(innerEvent);
            }


            return e;
        }

        protected virtual IAttributeStateMergePatched Map(IMergePatchAttribute c)
        {
			var stateEventId = new AttributeStateEventId(c.AttributeId, c.Version);
            IAttributeStateMergePatched e = NewAttributeStateMergePatched(stateEventId);

            e.Name = c.Name;
            e.OrganizationId = c.OrganizationId;
            e.Description = c.Description;
            e.IsMandatory = c.IsMandatory;
            e.IsInstanceAttribute = c.IsInstanceAttribute;
            e.AttributeValueType = c.AttributeValueType;
            e.AttributeValueLength = c.AttributeValueLength;
            e.IsList = c.IsList;
            e.FieldName = c.FieldName;
            e.ReferenceId = c.ReferenceId;
            e.Active = c.Active;
            e.IsPropertyNameRemoved = c.IsPropertyNameRemoved;
            e.IsPropertyOrganizationIdRemoved = c.IsPropertyOrganizationIdRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyIsMandatoryRemoved = c.IsPropertyIsMandatoryRemoved;
            e.IsPropertyIsInstanceAttributeRemoved = c.IsPropertyIsInstanceAttributeRemoved;
            e.IsPropertyAttributeValueTypeRemoved = c.IsPropertyAttributeValueTypeRemoved;
            e.IsPropertyAttributeValueLengthRemoved = c.IsPropertyAttributeValueLengthRemoved;
            e.IsPropertyIsListRemoved = c.IsPropertyIsListRemoved;
            e.IsPropertyFieldNameRemoved = c.IsPropertyFieldNameRemoved;
            e.IsPropertyReferenceIdRemoved = c.IsPropertyReferenceIdRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var version = c.Version;

            foreach (IAttributeValueCommand innerCommand in c.AttributeValueCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IAttributeValueStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddAttributeValueEvent(innerEvent);
            }


            return e;
        }

        protected virtual IAttributeStateDeleted Map(IDeleteAttribute c)
        {
			var stateEventId = new AttributeStateEventId(c.AttributeId, c.Version);
            IAttributeStateDeleted e = NewAttributeStateDeleted(stateEventId);
			
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;


            return e;
        }


        protected void ThrowOnInconsistentCommands(IAttributeCommand command, IAttributeValueCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeleteAttribute;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveAttributeValue;
            if (properties == null || innerProperties == null) { return; }
            if (innerProperties.AttributeId == default(string))
            {
                innerProperties.AttributeId = properties.AttributeId;
            }
            else
            {
                var outerAttributeIdName = "AttributeId";
                var outerAttributeIdValue = properties.AttributeId;
                var innerAttributeIdName = "AttributeId";
                var innerAttributeIdValue = innerProperties.AttributeId;
                ThrowOnInconsistentIds(innerProperties, innerAttributeIdName, innerAttributeIdValue, outerAttributeIdName, outerAttributeIdValue);
            }

        }// END ThrowOnInconsistentCommands /////////////////////


        protected virtual IAttributeValueStateEvent Map(IAttributeValueCommand c, IAttributeCommand outerCommand, long version, IAttributeState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateAttributeValue) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchAttributeValue) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemoveAttributeValue) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IAttributeValueStateCreated MapCreate(ICreateAttributeValue c, IAttributeCommand outerCommand, long version, IAttributeState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new AttributeValueStateEventId(c.AttributeId, c.Value, version);
            IAttributeValueStateCreated e = NewAttributeValueStateCreated(stateEventId);
            var s = outerState.AttributeValues.Get(c.Value, true);

            e.Name = c.Name;
            e.Description = c.Description;
            e.ReferenceId = c.ReferenceId;
            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IAttributeValueStateMergePatched MapMergePatch(IMergePatchAttributeValue c, IAttributeCommand outerCommand, long version, IAttributeState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new AttributeValueStateEventId(c.AttributeId, c.Value, version);
            IAttributeValueStateMergePatched e = NewAttributeValueStateMergePatched(stateEventId);
            var s = outerState.AttributeValues.Get(c.Value);

            e.Name = c.Name;
            e.Description = c.Description;
            e.ReferenceId = c.ReferenceId;
            e.Active = c.Active;
            e.IsPropertyNameRemoved = c.IsPropertyNameRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyReferenceIdRemoved = c.IsPropertyReferenceIdRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IAttributeValueStateRemoved MapRemove(IRemoveAttributeValue c, IAttributeCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new AttributeValueStateEventId(c.AttributeId, c.Value, version);
            IAttributeValueStateRemoved e = NewAttributeValueStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            return e;

        }// END Map(IRemove... ////////////////////////////

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

        protected AttributeStateCreated NewAttributeStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new AttributeStateEventId(_state.AttributeId, ((IAttributeStateProperties)_state).Version);
            var e = NewAttributeStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected AttributeStateMergePatched NewAttributeStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new AttributeStateEventId(_state.AttributeId, ((IAttributeStateProperties)_state).Version);
            var e = NewAttributeStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected AttributeStateDeleted NewAttributeStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new AttributeStateEventId(_state.AttributeId, ((IAttributeStateProperties)_state).Version);
            var e = NewAttributeStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private AttributeStateCreated NewAttributeStateCreated(AttributeStateEventId stateEventId)
		{
			return new AttributeStateCreated(stateEventId);			
		}

        private AttributeStateMergePatched NewAttributeStateMergePatched(AttributeStateEventId stateEventId)
		{
			return new AttributeStateMergePatched(stateEventId);
		}

        private AttributeStateDeleted NewAttributeStateDeleted(AttributeStateEventId stateEventId)
		{
			return new AttributeStateDeleted(stateEventId);
		}

		private AttributeValueStateCreated NewAttributeValueStateCreated(AttributeValueStateEventId stateEventId)
		{
			return new AttributeValueStateCreated(stateEventId);
		}

        private AttributeValueStateMergePatched NewAttributeValueStateMergePatched(AttributeValueStateEventId stateEventId)
		{
			return new AttributeValueStateMergePatched(stateEventId);
		}

        private AttributeValueStateRemoved NewAttributeValueStateRemoved(AttributeValueStateEventId stateEventId)
		{
			return new AttributeValueStateRemoved(stateEventId);
		}


    }

}
