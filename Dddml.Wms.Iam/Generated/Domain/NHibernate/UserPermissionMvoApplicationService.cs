﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserPermissionMvo;
using Dddml.Wms.Domain.User;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.UserPermissionMvo.NHibernate
{

	public class UserPermissionMvoApplicationService : UserPermissionMvoApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IUserPermissionMvoStateRepository _stateRepository;

		protected override IUserPermissionMvoStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IUserPermissionMvoStateQueryRepository _stateQueryRepository;

		protected override IUserPermissionMvoStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public UserPermissionMvoApplicationService(IEventStore eventStore, IUserPermissionMvoStateRepository stateRepository, IUserPermissionMvoStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(UserPermissionId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IUserPermissionMvoAggregate GetUserPermissionMvoAggregate(IUserPermissionMvoState state)
		{
			return new UserPermissionMvoAggregate(state);
		}

	}

}

