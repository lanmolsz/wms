﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeAliasMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeAliasMvo;
using Dddml.Wms.Domain.Attribute;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.AttributeAliasMvo.NHibernate
{

	public partial class AttributeAliasMvoApplicationService : AttributeAliasMvoApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IAttributeAliasMvoStateRepository _stateRepository;

		protected override IAttributeAliasMvoStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IAttributeAliasMvoStateQueryRepository _stateQueryRepository;

		protected override IAttributeAliasMvoStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public AttributeAliasMvoApplicationService(IEventStore eventStore, IAttributeAliasMvoStateRepository stateRepository, IAttributeAliasMvoStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(AttributeAliasId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IAttributeAliasMvoAggregate GetAttributeAliasMvoAggregate(IAttributeAliasMvoState state)
		{
			return new AttributeAliasMvoAggregate(state);
		}

	}

}

