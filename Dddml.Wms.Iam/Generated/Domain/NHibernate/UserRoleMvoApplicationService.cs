﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserRoleMvo;
using Dddml.Wms.Domain.User;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.UserRoleMvo.NHibernate
{

	public class UserRoleMvoApplicationService : UserRoleMvoApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IUserRoleMvoStateRepository _stateRepository;

		protected override IUserRoleMvoStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IUserRoleMvoStateQueryRepository _stateQueryRepository;

		protected override IUserRoleMvoStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public UserRoleMvoApplicationService(IEventStore eventStore, IUserRoleMvoStateRepository stateRepository, IUserRoleMvoStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(UserRoleId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IUserRoleMvoAggregate GetUserRoleMvoAggregate(IUserRoleMvoState state)
		{
			return new UserRoleMvoAggregate(state);
		}

	}

}

