﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSupplierProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SupplierProduct;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.SupplierProduct
{
	public partial interface ISupplierProductStateQueryRepository
	{
        ISupplierProductState Get(SupplierProductId id);

        IEnumerable<ISupplierProductState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<ISupplierProductState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<ISupplierProductState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        ISupplierProductState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        ISupplierProductState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<ISupplierProductState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}

