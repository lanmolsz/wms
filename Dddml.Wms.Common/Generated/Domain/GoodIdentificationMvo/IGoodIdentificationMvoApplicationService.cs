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

	public partial interface IGoodIdentificationMvoApplicationService : IApplicationService
	{
		void When(ICreateGoodIdentificationMvo c);

		void When(IMergePatchGoodIdentificationMvo c);

		void When(IDeleteGoodIdentificationMvo c);

 		IGoodIdentificationMvoState Get(ProductGoodIdentificationId productGoodIdentificationId);

        IEnumerable<IGoodIdentificationMvoState> GetAll(int firstResult, int maxResults);

        IEnumerable<IGoodIdentificationMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IGoodIdentificationMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IGoodIdentificationMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IGoodIdentificationMvoEvent GetEvent(ProductGoodIdentificationId productGoodIdentificationId, long version);

        IGoodIdentificationMvoState GetHistoryState(ProductGoodIdentificationId productGoodIdentificationId, long version);


	}

    public static partial class GoodIdentificationMvoApplicationServiceExtension
    {
        public static IEnumerable<IGoodIdentificationMvoState> GetByProperty(this IGoodIdentificationMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IGoodIdentificationMvoState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IGoodIdentificationMvoState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IGoodIdentificationMvoState> GetByProperty<TPropertyType>(this IGoodIdentificationMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IGoodIdentificationMvoState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IGoodIdentificationMvoState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

