﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RolePermission;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.RolePermission.NHibernate
{

	public partial class RolePermissionApplicationService : RolePermissionApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IRolePermissionStateRepository _stateRepository;

		protected override IRolePermissionStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IRolePermissionStateQueryRepository _stateQueryRepository;

		protected override IRolePermissionStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public RolePermissionApplicationService(IEventStore eventStore, IRolePermissionStateRepository stateRepository, IRolePermissionStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(RolePermissionId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IRolePermissionAggregate GetRolePermissionAggregate(IRolePermissionState state)
		{
			return new RolePermissionAggregate(state);
		}

	}

}

