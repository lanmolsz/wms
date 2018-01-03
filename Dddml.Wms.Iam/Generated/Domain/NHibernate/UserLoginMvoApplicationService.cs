﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserLoginMvo;
using Dddml.Wms.Domain.User;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.UserLoginMvo.NHibernate
{

	public partial class UserLoginMvoApplicationService : UserLoginMvoApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IUserLoginMvoStateRepository _stateRepository;

		protected override IUserLoginMvoStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IUserLoginMvoStateQueryRepository _stateQueryRepository;

		protected override IUserLoginMvoStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public UserLoginMvoApplicationService(IEventStore eventStore, IUserLoginMvoStateRepository stateRepository, IUserLoginMvoStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(UserLoginId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IUserLoginMvoAggregate GetUserLoginMvoAggregate(IUserLoginMvoState state)
		{
			return new UserLoginMvoAggregate(state);
		}

	}

}

