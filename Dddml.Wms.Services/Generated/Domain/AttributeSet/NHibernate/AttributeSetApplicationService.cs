﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.AttributeSet.NHibernate
{

	public partial class AttributeSetApplicationService : AttributeSetApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IAttributeSetStateRepository _stateRepository;

		protected override IAttributeSetStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IAttributeSetStateQueryRepository _stateQueryRepository;

		protected override IAttributeSetStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public AttributeSetApplicationService(IEventStore eventStore, IAttributeSetStateRepository stateRepository, IAttributeSetStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IAttributeSetAggregate GetAttributeSetAggregate(IAttributeSetState state)
		{
			return new AttributeSetAggregate(state);
		}

	}

}

