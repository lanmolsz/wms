﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{

    public partial class InventoryItemApplicationServiceFactory : IInventoryItemApplicationServiceFactory
    {

        public virtual IInventoryItemApplicationService InventoryItemApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["InventoryItemApplicationService"] as IInventoryItemApplicationService;
		    }
        }

        public virtual ICreateInventoryItem NewCreateInventoryItem()
        {
		    return new CreateInventoryItem();
        }

        public virtual IMergePatchInventoryItem NewMergePatchInventoryItem()
        {
            return new MergePatchInventoryItem();
        }

        public virtual IDeleteInventoryItem NewDeleteInventoryItem()
        {
            return new DeleteInventoryItem();
        }

    }


}

