﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistBinDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistBin;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.PicklistBin.NHibernate
{

	public partial class PicklistBinApplicationService : PicklistBinApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IPicklistBinStateRepository _stateRepository;

		protected override IPicklistBinStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IPicklistBinStateQueryRepository _stateQueryRepository;

		protected override IPicklistBinStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public PicklistBinApplicationService(IEventStore eventStore, IPicklistBinStateRepository stateRepository, IPicklistBinStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IPicklistBinAggregate GetPicklistBinAggregate(IPicklistBinState state)
		{
			return new PicklistBinAggregate(state);
		}

	}

}
