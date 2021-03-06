﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryLineMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventoryLineMvo;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.PhysicalInventoryLineMvo.NHibernate
{

	public partial class PhysicalInventoryLineMvoApplicationService : PhysicalInventoryLineMvoApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IPhysicalInventoryLineMvoStateRepository _stateRepository;

		protected override IPhysicalInventoryLineMvoStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IPhysicalInventoryLineMvoStateQueryRepository _stateQueryRepository;

		protected override IPhysicalInventoryLineMvoStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public PhysicalInventoryLineMvoApplicationService(IEventStore eventStore, IPhysicalInventoryLineMvoStateRepository stateRepository, IPhysicalInventoryLineMvoStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(PhysicalInventoryLineId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IPhysicalInventoryLineMvoAggregate GetPhysicalInventoryLineMvoAggregate(IPhysicalInventoryLineMvoState state)
		{
			return new PhysicalInventoryLineMvoAggregate(state);
		}

	}

}

