﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.SellableInventoryItem.NHibernate
{

	public partial class SellableInventoryItemApplicationService : SellableInventoryItemApplicationServiceBase
	{

		private ISellableInventoryItemStateRepository _stateRepository;

		protected override ISellableInventoryItemStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private ISellableInventoryItemStateQueryRepository _stateQueryRepository;

		protected override ISellableInventoryItemStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public SellableInventoryItemApplicationService(ISellableInventoryItemStateRepository stateRepository, ISellableInventoryItemStateQueryRepository stateQueryRepository)
		{
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}
		public override IEventStoreAggregateId ToEventStoreAggregateId(InventoryItemId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override ISellableInventoryItemAggregate GetSellableInventoryItemAggregate(ISellableInventoryItemState state)
		{
			return new SellableInventoryItemAggregate(state);
		}

	}

}

