﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentType;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.ShipmentType
{

	public partial interface IShipmentTypeApplicationService : IApplicationService
	{
		void When(ICreateShipmentType c);

		void When(IMergePatchShipmentType c);

 		IShipmentTypeState Get(string shipmentTypeId);

        IEnumerable<IShipmentTypeState> GetAll(int firstResult, int maxResults);

        IEnumerable<IShipmentTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IShipmentTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IShipmentTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);


	}

    public static partial class ShipmentTypeApplicationServiceExtension
    {
        public static IEnumerable<IShipmentTypeState> GetByProperty(this IShipmentTypeApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IShipmentTypeState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IShipmentTypeState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IShipmentTypeState> GetByProperty<TPropertyType>(this IShipmentTypeApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IShipmentTypeState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IShipmentTypeState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

