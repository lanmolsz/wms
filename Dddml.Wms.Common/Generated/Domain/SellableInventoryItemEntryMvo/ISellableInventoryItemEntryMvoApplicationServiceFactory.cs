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

    public partial interface ISellableInventoryItemEntryMvoApplicationServiceFactory
    {

        ISellableInventoryItemEntryMvoApplicationService SellableInventoryItemEntryMvoApplicationService { get; }

        ICreateSellableInventoryItemEntryMvo NewCreateSellableInventoryItemEntryMvo();

        IMergePatchSellableInventoryItemEntryMvo NewMergePatchSellableInventoryItemEntryMvo();

        IDeleteSellableInventoryItemEntryMvo NewDeleteSellableInventoryItemEntryMvo();
    }


}

