﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.InOutLineMvo
{
	public abstract partial class InOutLineMvoApplicationServiceBase : IInOutLineMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IInOutLineMvoStateRepository StateRepository { get; }

		protected abstract IInOutLineMvoStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IInOutLineMvoAggregate, IInOutLineMvoState> _aggregateEventListener;

        public virtual IAggregateEventListener<IInOutLineMvoAggregate, IInOutLineMvoState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected InOutLineMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IInOutLineMvoCommand c, Action<IInOutLineMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetInOutLineMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IInOutLineMvoAggregate aggregate, IInOutLineMvoState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IInOutLineMvoStateProperties)state).InOutVersion, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IInOutLineMvoAggregate, IInOutLineMvoState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IInOutLineMvoStateCreated stateCreated)
        {
            var aggregateId = stateCreated.InOutLineMvoEventId.InOutLineId;
            var state = new InOutLineMvoState();
            state.InOutLineId = aggregateId;
            var aggregate = (InOutLineMvoAggregate)GetInOutLineMvoAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IInOutLineMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IInOutLineMvoState state)
		{
			bool repeated = false;
			if (((IInOutLineMvoStateProperties)state).InOutVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IInOutLineMvoEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateInOutLineMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchInOutLineMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteInOutLineMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IInOutLineMvoState Get(InOutLineId inOutLineId)
        {
            var state = StateRepository.Get(inOutLineId, true);
            return state;
        }

        public virtual IEnumerable<IInOutLineMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IInOutLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IInOutLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IInOutLineMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IInOutLineMvoEvent GetEvent(InOutLineId inOutLineId, long version)
        {
            var e = (IInOutLineMvoEvent)EventStore.GetEvent(ToEventStoreAggregateId(inOutLineId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(inOutLineId, 0);
            }
            return e;
        }

        public virtual IInOutLineMvoState GetHistoryState(InOutLineId inOutLineId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IInOutLineMvoEvent), ToEventStoreAggregateId(inOutLineId), version - 1);
            return new InOutLineMvoState(eventStream.Events);
        }


		public abstract IInOutLineMvoAggregate GetInOutLineMvoAggregate(IInOutLineMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(InOutLineId aggregateId);


	}

}

