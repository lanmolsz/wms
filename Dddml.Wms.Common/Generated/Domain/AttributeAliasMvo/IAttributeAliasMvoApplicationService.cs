﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeAliasMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeAliasMvo;
using Dddml.Wms.Domain.Attribute;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.AttributeAliasMvo
{

	public partial interface IAttributeAliasMvoApplicationService : IApplicationService
	{
		void When(ICreateAttributeAliasMvo c);

		void When(IMergePatchAttributeAliasMvo c);

		void When(IDeleteAttributeAliasMvo c);

 		IAttributeAliasMvoState Get(AttributeAliasId attributeAliasId);

        IEnumerable<IAttributeAliasMvoState> GetAll(int firstResult, int maxResults);

        IEnumerable<IAttributeAliasMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeAliasMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeAliasMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IAttributeAliasMvoStateEvent GetStateEvent(AttributeAliasId attributeAliasId, long version);

        IAttributeAliasMvoState GetHistoryState(AttributeAliasId attributeAliasId, long version);


	}

    public static partial class AttributeAliasMvoApplicationServiceExtension
    {
        public static IEnumerable<IAttributeAliasMvoState> GetByProperty(this IAttributeAliasMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAttributeAliasMvoState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAttributeAliasMvoState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IAttributeAliasMvoState> GetByProperty<TPropertyType>(this IAttributeAliasMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAttributeAliasMvoState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAttributeAliasMvoState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

