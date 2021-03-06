﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateStatusItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.StatusItem;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.StatusItem
{

	public partial interface IStatusItemApplicationService : IApplicationService
	{
		void When(ICreateStatusItem c);

		void When(IMergePatchStatusItem c);

 		IStatusItemState Get(string statusId);

        IEnumerable<IStatusItemState> GetAll(int firstResult, int maxResults);

        IEnumerable<IStatusItemState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IStatusItemState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IStatusItemState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);


	}

    public static partial class StatusItemApplicationServiceExtension
    {
        public static IEnumerable<IStatusItemState> GetByProperty(this IStatusItemApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IStatusItemState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IStatusItemState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IStatusItemState> GetByProperty<TPropertyType>(this IStatusItemApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IStatusItemState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IStatusItemState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

