﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeAliasMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeAliasMvo;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.AttributeAliasMvo
{

    public partial interface IAttributeAliasMvoApplicationServiceFactory
    {

        IAttributeAliasMvoApplicationService AttributeAliasMvoApplicationService { get; }

        ICreateAttributeAliasMvo NewCreateAttributeAliasMvo();

        IMergePatchAttributeAliasMvo NewMergePatchAttributeAliasMvo();

        IDeleteAttributeAliasMvo NewDeleteAttributeAliasMvo();
    }


}

