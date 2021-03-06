﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipment;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrderShipment
{
	public partial interface IOrderShipmentStateQueryRepository
	{
        IOrderShipmentState Get(OrderShipmentId id);

        IEnumerable<IOrderShipmentState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IOrderShipmentState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IOrderShipmentState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IOrderShipmentState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IOrderShipmentState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IOrderShipmentState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}

