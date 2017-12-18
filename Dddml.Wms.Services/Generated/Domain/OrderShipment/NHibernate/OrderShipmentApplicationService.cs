﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipmentDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipment;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.OrderShipment.NHibernate
{

	public class OrderShipmentApplicationService : OrderShipmentApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IOrderShipmentStateRepository _stateRepository;

		protected override IOrderShipmentStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IOrderShipmentStateQueryRepository _stateQueryRepository;

		protected override IOrderShipmentStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public OrderShipmentApplicationService(IEventStore eventStore, IOrderShipmentStateRepository stateRepository, IOrderShipmentStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(OrderShipmentId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IOrderShipmentAggregate GetOrderShipmentAggregate(IOrderShipmentState state)
		{
			return new OrderShipmentAggregate(state);
		}

	}

}
