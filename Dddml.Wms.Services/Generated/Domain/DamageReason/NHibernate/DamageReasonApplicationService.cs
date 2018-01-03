﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageReasonDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageReason;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.DamageReason.NHibernate
{

	public partial class DamageReasonApplicationService : DamageReasonApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IDamageReasonStateRepository _stateRepository;

		protected override IDamageReasonStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IDamageReasonStateQueryRepository _stateQueryRepository;

		protected override IDamageReasonStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public DamageReasonApplicationService(IEventStore eventStore, IDamageReasonStateRepository stateRepository, IDamageReasonStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IDamageReasonAggregate GetDamageReasonAggregate(IDamageReasonState state)
		{
			return new DamageReasonAggregate(state);
		}

	}

}

