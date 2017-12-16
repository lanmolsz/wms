﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSupplierProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SupplierProduct;

namespace Dddml.Wms.Domain.SupplierProduct
{

    public partial class SupplierProductApplicationServiceFactory : ISupplierProductApplicationServiceFactory
    {

        public virtual ISupplierProductApplicationService SupplierProductApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["SupplierProductApplicationService"] as ISupplierProductApplicationService;
		    }
        }

        public virtual ICreateSupplierProduct NewCreateSupplierProduct()
        {
		    return new CreateSupplierProduct();
        }

        public virtual IMergePatchSupplierProduct NewMergePatchSupplierProduct()
        {
            return new MergePatchSupplierProduct();
        }

        public virtual IDeleteSupplierProduct NewDeleteSupplierProduct()
        {
            return new DeleteSupplierProduct();
        }

    }


}

