﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.PhysicalInventory
{
	public partial interface IPhysicalInventoryStateQueryRepository
	{
        IPhysicalInventoryState Get(string id);

        IEnumerable<IPhysicalInventoryState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IPhysicalInventoryState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IPhysicalInventoryState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IPhysicalInventoryState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IPhysicalInventoryState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IPhysicalInventoryState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IPhysicalInventoryLineState GetPhysicalInventoryLine(string physicalInventoryDocumentNumber, InventoryItemId inventoryItemId);

        IEnumerable<IPhysicalInventoryLineState> GetPhysicalInventoryLines(string physicalInventoryDocumentNumber);

	}

}

