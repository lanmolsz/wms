﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageTypeDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageType;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.DamageType.NHibernate
{

	public partial class DamageTypeApplicationService : DamageTypeApplicationServiceBase
	{

		private IDamageTypeStateRepository _stateRepository;

		protected override IDamageTypeStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IDamageTypeStateQueryRepository _stateQueryRepository;

		protected override IDamageTypeStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public DamageTypeApplicationService(IDamageTypeStateRepository stateRepository, IDamageTypeStateQueryRepository stateQueryRepository)
		{
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}
		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IDamageTypeAggregate GetDamageTypeAggregate(IDamageTypeState state)
		{
			return new DamageTypeAggregate(state);
		}

	}

}
