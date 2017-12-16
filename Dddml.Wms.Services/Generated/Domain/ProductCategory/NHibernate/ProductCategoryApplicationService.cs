﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductCategoryDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategory;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.ProductCategory.NHibernate
{

	public class ProductCategoryApplicationService : ProductCategoryApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IProductCategoryStateRepository _stateRepository;

		protected override IProductCategoryStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IProductCategoryStateQueryRepository _stateQueryRepository;

		protected override IProductCategoryStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public ProductCategoryApplicationService(IEventStore eventStore, IProductCategoryStateRepository stateRepository, IProductCategoryStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IProductCategoryAggregate GetProductCategoryAggregate(IProductCategoryState state)
		{
			return new ProductCategoryAggregate(state);
		}

	}

}

