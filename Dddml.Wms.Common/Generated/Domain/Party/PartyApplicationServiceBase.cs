﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePartyDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Party;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Party
{
	public abstract partial class PartyApplicationServiceBase : IPartyApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IPartyStateRepository StateRepository { get; }

		protected abstract IPartyStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IPartyAggregate, IPartyState> _aggregateEventListener;

        public virtual IAggregateEventListener<IPartyAggregate, IPartyState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected PartyApplicationServiceBase()
		{
		}

		protected virtual void Update(IPartyCommand c, Action<IPartyAggregate> action)
		{
			var aggregateId = c.AggregateId;
            var stateType = GetStateType(c);
			var state = StateRepository.Get(stateType, aggregateId, false);
			var aggregate = GetPartyAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IPartyAggregate aggregate, IPartyState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IPartyStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IPartyAggregate, IPartyState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IPartyStateCreated stateCreated)
        {
            var aggregateId = stateCreated.PartyEventId.PartyId;
            var state = new PartyState();
            state.PartyId = aggregateId;
            var aggregate = (PartyAggregate)GetPartyAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

        protected virtual Type GetStateType(IPartyCommand c) 
        {
            Type clazz = null; //typeof(PartyState);
            string discriminatorVal = null;
            if (c is ICreateParty) {
                discriminatorVal = ((ICreateParty) c).PartyTypeId;
            } else if (c is IMergePatchParty) {
                discriminatorVal = ((IMergePatchParty) c).PartyTypeId;
            } else if (c is IDeleteParty) {
                discriminatorVal = ((IDeleteParty) c).PartyTypeId;
            }
            if (discriminatorVal != null) {
                switch (discriminatorVal) {
                    case PartyTypeIds.Party:
                        clazz = typeof(PartyState);
                        break;
                    case PartyTypeIds.Organization:
                        clazz = typeof(OrganizationState);
                        break;
                }
            }
            if (clazz == null)
            {
                throw new ArgumentException(String.Format("CANNOT find discriminator info from command: {0}", c));
            }
            return clazz;
        }

		protected bool IsRepeatedCommand(IPartyCommand command, IEventStoreAggregateId eventStoreAggregateId, IPartyState state)
		{
			bool repeated = false;
			if (((IPartyStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IPartyEvent), eventStoreAggregateId, command.AggregateVersion);
				if (lastEvent != null && lastEvent.CommandId == command.CommandId)
				{
					repeated = true;
				}
			}
			return repeated;
		}


		public virtual void Execute(object command)
		{
			((dynamic)this).When((dynamic)command);
		}


		public virtual void When(ICreateParty c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchParty c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteParty c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IPartyState Get(string partyId)
        {
            var state = StateRepository.Get(partyId, true);
            return state;
        }

        public virtual IEnumerable<IPartyState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IPartyState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IPartyState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IPartyState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = StateQueryRepository.GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
			return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
            return StateQueryRepository.GetCount(filter);
		}

        public virtual long GetCount(ICriterion filter)
		{
            return StateQueryRepository.GetCount(filter);
		}

        public virtual IEnumerable<T> GetAll<T>(int firstResult, int maxResults) where T : class, IPartyState
		{
            var states = StateQueryRepository.GetAll<T>(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<T> Get<T>(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue) where T : class, IPartyState
		{
            var states = StateQueryRepository.Get<T>(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<T> Get<T>(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue) where T : class, IPartyState
		{
            var states = StateQueryRepository.Get<T>(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<T> GetByProperty<T>(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue) where T : class, IPartyState
        {
            var states = StateQueryRepository.GetByProperty<T>(propertyName, propertyValue, orders, firstResult, maxResults);
			return states;
        }

        public virtual long GetCount<T>(IEnumerable<KeyValuePair<string, object>> filter) where T : class, IPartyState
		{
            return StateQueryRepository.GetCount<T>(filter);
		}

        public virtual long GetCount<T>(ICriterion filter) where T : class, IPartyState
		{
            return StateQueryRepository.GetCount<T>(filter);
		}

	    public virtual IPartyEvent GetEvent(string partyId, long version)
        {
            var e = (IPartyEvent)EventStore.GetEvent(ToEventStoreAggregateId(partyId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(partyId, 0);
            }
            return e;
        }

        public virtual IPartyState GetHistoryState(string partyId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IPartyEvent), ToEventStoreAggregateId(partyId), version - 1);
            return new PartyState(eventStream.Events);
        }


		public abstract IPartyAggregate GetPartyAggregate(IPartyState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}

