﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateGoodIdentificationMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.GoodIdentificationMvo;
using Dddml.Wms.Domain.Product;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.GoodIdentificationMvo
{
	public partial interface IGoodIdentificationMvoStateQueryRepository
	{
        IGoodIdentificationMvoState Get(ProductGoodIdentificationId id);

        IEnumerable<IGoodIdentificationMvoState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IGoodIdentificationMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IGoodIdentificationMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IGoodIdentificationMvoState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IGoodIdentificationMvoState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IGoodIdentificationMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}
