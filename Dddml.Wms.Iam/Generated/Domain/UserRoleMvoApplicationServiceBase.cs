﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserRoleMvo;
using Dddml.Wms.Domain.User;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.UserRoleMvo
{
	public abstract partial class UserRoleMvoApplicationServiceBase : IUserRoleMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IUserRoleMvoStateRepository StateRepository { get; }

		protected abstract IUserRoleMvoStateQueryRepository StateQueryRepository { get; }

		protected UserRoleMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IUserRoleMvoCommand c, Action<IUserRoleMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetUserRoleMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(eventStoreAggregateId, ((IUserRoleMvoStateProperties)state).UserVersion, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IUserRoleMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IUserRoleMvoState state)
		{
			bool repeated = false;
			if (((IUserRoleMvoStateProperties)state).UserVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IUserRoleMvoStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateUserRoleMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchUserRoleMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteUserRoleMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IUserRoleMvoState Get(UserRoleId userRoleId)
        {
            var state = StateRepository.Get(userRoleId, true);
            return state;
        }

        public virtual IEnumerable<IUserRoleMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserRoleMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserRoleMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserRoleMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IUserRoleMvoStateEvent GetStateEvent(UserRoleId userRoleId, long version)
        {
            var e = (IUserRoleMvoStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(userRoleId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(userRoleId, 0);
            }
            return e;
        }

        public virtual IUserRoleMvoState GetHistoryState(UserRoleId userRoleId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IUserRoleMvoStateEvent), ToEventStoreAggregateId(userRoleId), version - 1);
            return new UserRoleMvoState(eventStream.Events);
        }


		public abstract IUserRoleMvoAggregate GetUserRoleMvoAggregate(IUserRoleMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(UserRoleId aggregateId);


	}

}

