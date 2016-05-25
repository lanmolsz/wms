﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Support.Criterion;
using Dddml.Wms.Domain;


namespace Dddml.Wms.Domain
{
	public interface IAttributeSetStateRepository
	{
        IAttributeSetState Get(string id);

        IEnumerable<IAttributeSetState> GetAll(int firstResult, int maxResults);
        
        void Save(IAttributeSetState state);
        
        IEnumerable<IAttributeSetState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeSetState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IAttributeSetState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IAttributeSetState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

	}

}

