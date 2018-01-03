﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageHandlingMethodDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageHandlingMethod;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.DamageHandlingMethod
{

	public partial interface IDamageHandlingMethodApplicationService : IApplicationService
	{
		void When(ICreateDamageHandlingMethod c);

		void When(IMergePatchDamageHandlingMethod c);

		void When(IDeleteDamageHandlingMethod c);

 		IDamageHandlingMethodState Get(string damageHandlingMethodId);

        IEnumerable<IDamageHandlingMethodState> GetAll(int firstResult, int maxResults);

        IEnumerable<IDamageHandlingMethodState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IDamageHandlingMethodState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IDamageHandlingMethodState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);


	}

    public static partial class DamageHandlingMethodApplicationServiceExtension
    {
        public static IEnumerable<IDamageHandlingMethodState> GetByProperty(this IDamageHandlingMethodApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IDamageHandlingMethodState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IDamageHandlingMethodState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IDamageHandlingMethodState> GetByProperty<TPropertyType>(this IDamageHandlingMethodApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IDamageHandlingMethodState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IDamageHandlingMethodState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

