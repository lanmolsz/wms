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

namespace Dddml.Wms.Domain.SellableInventoryItemEntryMvo
{
	public interface ISellableInventoryItemEntryMvoState : ISellableInventoryItemEntryMvoStateProperties, 
		IGlobalIdentity<SellableInventoryItemEntryId>, 
		ICreated<string>, 
		IUpdated<string>, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(ISellableInventoryItemEntryMvoStateCreated e);

		void When(ISellableInventoryItemEntryMvoStateMergePatched e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}

}

