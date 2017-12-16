﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItem;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrderItem
{
	public abstract partial class OrderItemApplicationServiceBase : IOrderItemApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IOrderItemStateRepository StateRepository { get; }

		protected abstract IOrderItemStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IOrderItemAggregate, IOrderItemState> _aggregateEventListener;

        public virtual IAggregateEventListener<IOrderItemAggregate, IOrderItemState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected OrderItemApplicationServiceBase()
		{
		}

		protected virtual void Update(IOrderItemCommand c, Action<IOrderItemAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetOrderItemAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IOrderItemAggregate aggregate, IOrderItemState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IOrderItemStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IOrderItemAggregate, IOrderItemState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IOrderItemStateCreated stateCreated)
        {
            var aggregateId = stateCreated.StateEventId.OrderItemId;
            var state = new OrderItemState();
            state.OrderItemId = aggregateId;
            var aggregate = (OrderItemAggregate)GetOrderItemAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IOrderItemCommand command, IEventStoreAggregateId eventStoreAggregateId, IOrderItemState state)
		{
			bool repeated = false;
			if (((IOrderItemStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IOrderItemStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateOrderItem c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchOrderItem c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

        public virtual IOrderItemState Get(OrderItemId orderItemId)
        {
            var state = StateRepository.Get(orderItemId, true);
            return state;
        }

        public virtual IEnumerable<IOrderItemState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IOrderItemStateEvent GetStateEvent(OrderItemId orderItemId, long version)
        {
            var e = (IOrderItemStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(orderItemId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(orderItemId, 0);
            }
            return e;
        }

        public virtual IOrderItemState GetHistoryState(OrderItemId orderItemId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IOrderItemStateEvent), ToEventStoreAggregateId(orderItemId), version - 1);
            return new OrderItemState(eventStream.Events);
        }


		public abstract IOrderItemAggregate GetOrderItemAggregate(IOrderItemState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(OrderItemId aggregateId);


	}

}

