﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementTypeDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementType;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.MovementType.NHibernate
{

	public class MovementTypeApplicationService : MovementTypeApplicationServiceBase
	{

		private IMovementTypeStateRepository _stateRepository;

		protected override IMovementTypeStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IMovementTypeStateQueryRepository _stateQueryRepository;

		protected override IMovementTypeStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public MovementTypeApplicationService(IMovementTypeStateRepository stateRepository, IMovementTypeStateQueryRepository stateQueryRepository)
		{
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}
		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IMovementTypeAggregate GetMovementTypeAggregate(IMovementTypeState state)
		{
			return new MovementTypeAggregate(state);
		}

	}

}

