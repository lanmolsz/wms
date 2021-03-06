﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGroupAssociationMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo.NHibernate
{

	public partial class OrderItemShipGroupAssociationMvoApplicationService : OrderItemShipGroupAssociationMvoApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IOrderItemShipGroupAssociationMvoStateRepository _stateRepository;

		protected override IOrderItemShipGroupAssociationMvoStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IOrderItemShipGroupAssociationMvoStateQueryRepository _stateQueryRepository;

		protected override IOrderItemShipGroupAssociationMvoStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public OrderItemShipGroupAssociationMvoApplicationService(IEventStore eventStore, IOrderItemShipGroupAssociationMvoStateRepository stateRepository, IOrderItemShipGroupAssociationMvoStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(OrderItemShipGroupAssociationId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IOrderItemShipGroupAssociationMvoAggregate GetOrderItemShipGroupAssociationMvoAggregate(IOrderItemShipGroupAssociationMvoState state)
		{
			return new OrderItemShipGroupAssociationMvoAggregate(state);
		}

	}

}

