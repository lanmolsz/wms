﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageType;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.DamageType
{
	public abstract partial class DamageTypeApplicationServiceBase : IDamageTypeApplicationService, IApplicationService
	{
		protected abstract IDamageTypeStateRepository StateRepository { get; }

		protected abstract IDamageTypeStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IDamageTypeAggregate, IDamageTypeState> _aggregateEventListener;

        public virtual IAggregateEventListener<IDamageTypeAggregate, IDamageTypeState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected DamageTypeApplicationServiceBase()
		{
		}

		protected virtual void Update(IDamageTypeCommand c, Action<IDamageTypeAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetDamageTypeAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IDamageTypeAggregate aggregate, IDamageTypeState state)
        {
            StateRepository.Save(state);
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IDamageTypeAggregate, IDamageTypeState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IDamageTypeStateCreated stateCreated)
        {
            var aggregateId = stateCreated.StateEventId.DamageTypeId;
            var state = new DamageTypeState();
            state.DamageTypeId = aggregateId;
            var aggregate = (DamageTypeAggregate)GetDamageTypeAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IDamageTypeCommand command, IEventStoreAggregateId eventStoreAggregateId, IDamageTypeState state)
		{
			bool repeated = false;
			if (((IDamageTypeStateProperties)state).Version == command.AggregateVersion + 1)
			{
				if (state.CommandId == command.CommandId)
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


		public virtual void When(ICreateDamageType c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchDamageType c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteDamageType c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IDamageTypeState Get(string damageTypeId)
        {
            var state = StateRepository.Get(damageTypeId, true);
            return state;
        }

        public virtual IEnumerable<IDamageTypeState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IDamageTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IDamageTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IDamageTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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


		public abstract IDamageTypeAggregate GetDamageTypeAggregate(IDamageTypeState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}
