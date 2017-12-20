﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmationLineMvo;
using Dddml.Wms.Domain.MovementConfirmation;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.MovementConfirmationLineMvo
{

	public partial interface IMovementConfirmationLineMvoApplicationService : IApplicationService
	{
		void When(ICreateMovementConfirmationLineMvo c);

		void When(IMergePatchMovementConfirmationLineMvo c);

		void When(IDeleteMovementConfirmationLineMvo c);

 		IMovementConfirmationLineMvoState Get(MovementConfirmationLineId movementConfirmationLineId);

        IEnumerable<IMovementConfirmationLineMvoState> GetAll(int firstResult, int maxResults);

        IEnumerable<IMovementConfirmationLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IMovementConfirmationLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IMovementConfirmationLineMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IMovementConfirmationLineMvoStateEvent GetStateEvent(MovementConfirmationLineId movementConfirmationLineId, long version);

        IMovementConfirmationLineMvoState GetHistoryState(MovementConfirmationLineId movementConfirmationLineId, long version);


	}

    public static partial class MovementConfirmationLineMvoApplicationServiceExtension
    {
        public static IEnumerable<IMovementConfirmationLineMvoState> GetByProperty(this IMovementConfirmationLineMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IMovementConfirmationLineMvoState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IMovementConfirmationLineMvoState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IMovementConfirmationLineMvoState> GetByProperty<TPropertyType>(this IMovementConfirmationLineMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IMovementConfirmationLineMvoState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IMovementConfirmationLineMvoState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

