﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmationLineMvo;
using Dddml.Wms.Domain.MovementConfirmation;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.MovementConfirmationLineMvo
{
	public abstract partial class MovementConfirmationLineMvoApplicationServiceBase : IMovementConfirmationLineMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IMovementConfirmationLineMvoStateRepository StateRepository { get; }

		protected abstract IMovementConfirmationLineMvoStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IMovementConfirmationLineMvoAggregate, IMovementConfirmationLineMvoState> _aggregateEventListener;

        public virtual IAggregateEventListener<IMovementConfirmationLineMvoAggregate, IMovementConfirmationLineMvoState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected MovementConfirmationLineMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IMovementConfirmationLineMvoCommand c, Action<IMovementConfirmationLineMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetMovementConfirmationLineMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IMovementConfirmationLineMvoAggregate aggregate, IMovementConfirmationLineMvoState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IMovementConfirmationLineMvoStateProperties)state).MovementConfirmationVersion, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IMovementConfirmationLineMvoAggregate, IMovementConfirmationLineMvoState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IMovementConfirmationLineMvoStateCreated stateCreated)
        {
            var aggregateId = stateCreated.MovementConfirmationLineMvoEventId.MovementConfirmationLineId;
            var state = new MovementConfirmationLineMvoState();
            state.MovementConfirmationLineId = aggregateId;
            var aggregate = (MovementConfirmationLineMvoAggregate)GetMovementConfirmationLineMvoAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IMovementConfirmationLineMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IMovementConfirmationLineMvoState state)
		{
			bool repeated = false;
			if (((IMovementConfirmationLineMvoStateProperties)state).MovementConfirmationVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IMovementConfirmationLineMvoEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateMovementConfirmationLineMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchMovementConfirmationLineMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteMovementConfirmationLineMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IMovementConfirmationLineMvoState Get(MovementConfirmationLineId movementConfirmationLineId)
        {
            var state = StateRepository.Get(movementConfirmationLineId, true);
            return state;
        }

        public virtual IEnumerable<IMovementConfirmationLineMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IMovementConfirmationLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IMovementConfirmationLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IMovementConfirmationLineMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IMovementConfirmationLineMvoEvent GetEvent(MovementConfirmationLineId movementConfirmationLineId, long version)
        {
            var e = (IMovementConfirmationLineMvoEvent)EventStore.GetEvent(ToEventStoreAggregateId(movementConfirmationLineId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(movementConfirmationLineId, 0);
            }
            return e;
        }

        public virtual IMovementConfirmationLineMvoState GetHistoryState(MovementConfirmationLineId movementConfirmationLineId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IMovementConfirmationLineMvoEvent), ToEventStoreAggregateId(movementConfirmationLineId), version - 1);
            return new MovementConfirmationLineMvoState(eventStream.Events);
        }


		public abstract IMovementConfirmationLineMvoAggregate GetMovementConfirmationLineMvoAggregate(IMovementConfirmationLineMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(MovementConfirmationLineId aggregateId);


	}

}

