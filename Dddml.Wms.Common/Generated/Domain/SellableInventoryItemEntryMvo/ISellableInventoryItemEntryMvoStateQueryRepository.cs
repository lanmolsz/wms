﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItemEntryMvo;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.SellableInventoryItemEntryMvo
{
	public partial interface ISellableInventoryItemEntryMvoStateQueryRepository
	{
        ISellableInventoryItemEntryMvoState Get(SellableInventoryItemEntryId id);

        IEnumerable<ISellableInventoryItemEntryMvoState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<ISellableInventoryItemEntryMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<ISellableInventoryItemEntryMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        ISellableInventoryItemEntryMvoState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        ISellableInventoryItemEntryMvoState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<ISellableInventoryItemEntryMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}

