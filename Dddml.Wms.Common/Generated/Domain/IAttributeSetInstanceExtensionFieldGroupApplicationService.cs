﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Support.Criterion;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public partial interface IAttributeSetInstanceExtensionFieldGroupApplicationService : IApplicationService
	{
		void When(ICreateAttributeSetInstanceExtensionFieldGroup c);

		void When(IMergePatchAttributeSetInstanceExtensionFieldGroup c);

		void When(IDeleteAttributeSetInstanceExtensionFieldGroup c);

 		IAttributeSetInstanceExtensionFieldGroupState Get(string id);

        IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> GetAll(int firstResult, int maxResults);

        IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(IDictionary<string, object> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IAttributeSetInstanceExtensionFieldGroupStateEvent GetStateEvent(string id, long version);

	}

}

