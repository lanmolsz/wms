﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEventTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEventType;

namespace Dddml.Wms.Domain.InventoryItemEventType
{

    public partial class InventoryItemEventTypeApplicationServiceFactory : IInventoryItemEventTypeApplicationServiceFactory
    {

        public virtual IInventoryItemEventTypeApplicationService InventoryItemEventTypeApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["InventoryItemEventTypeApplicationService"] as IInventoryItemEventTypeApplicationService;
		    }
        }

        public virtual ICreateInventoryItemEventType NewCreateInventoryItemEventType()
        {
		    return new CreateInventoryItemEventType();
        }

        public virtual IMergePatchInventoryItemEventType NewMergePatchInventoryItemEventType()
        {
            return new MergePatchInventoryItemEventType();
        }

        public virtual IDeleteInventoryItemEventType NewDeleteInventoryItemEventType()
        {
            return new DeleteInventoryItemEventType();
        }

    }


}
