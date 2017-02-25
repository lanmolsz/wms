﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain
{

	public partial interface IAttributeSetInstanceApplicationService : IApplicationService
	{
		string CreateWithoutId(ICreateAttributeSetInstance c);

		void When(ICreateAttributeSetInstance c);

 		IAttributeSetInstanceState Get(string attributeSetInstanceId);

        IEnumerable<IAttributeSetInstanceState> GetAll(int firstResult, int maxResults);

        IEnumerable<IAttributeSetInstanceState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeSetInstanceState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeSetInstanceState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IAttributeSetInstanceStateEvent GetStateEvent(string attributeSetInstanceId, long version);

        IAttributeSetInstanceState GetHistoryState(string attributeSetInstanceId, long version);


	}

}

