﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Product;

namespace Dddml.Wms.Domain.Product
{

    public partial interface IProductApplicationServiceFactory
    {

        IProductApplicationService ProductApplicationService { get; }

        ICreateProduct NewCreateProduct();

        IMergePatchProduct NewMergePatchProduct();

        IDeleteProduct NewDeleteProduct();
    }


}

