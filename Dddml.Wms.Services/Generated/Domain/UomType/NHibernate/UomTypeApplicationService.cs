﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomTypeDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomType;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.UomType.NHibernate
{

	public partial class UomTypeApplicationService : UomTypeApplicationServiceBase
	{

		private IUomTypeStateRepository _stateRepository;

		protected override IUomTypeStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IUomTypeStateQueryRepository _stateQueryRepository;

		protected override IUomTypeStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public UomTypeApplicationService(IUomTypeStateRepository stateRepository, IUomTypeStateQueryRepository stateQueryRepository)
		{
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}
		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IUomTypeAggregate GetUomTypeAggregate(IUomTypeState state)
		{
			return new UomTypeAggregate(state);
		}

	}

}

