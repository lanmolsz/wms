﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

    public partial class AttributeSetApplicationServiceFactory : IAttributeSetApplicationServiceFactory
    {

        public virtual IAttributeSetApplicationService AttributeSetApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["AttributeSetApplicationService"] as IAttributeSetApplicationService;
		    }
        }

        public virtual ICreateAttributeSet NewCreateAttributeSet()
        {
		    return new CreateAttributeSet();
        }

        public virtual IMergePatchAttributeSet NewMergePatchAttributeSet()
        {
            return new MergePatchAttributeSet();
        }

        public virtual IDeleteAttributeSet NewDeleteAttributeSet()
        {
            return new DeleteAttributeSet();
        }

    }


}

