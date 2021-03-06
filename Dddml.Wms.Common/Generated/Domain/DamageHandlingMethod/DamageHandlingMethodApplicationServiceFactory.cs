﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageHandlingMethodDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageHandlingMethod;

namespace Dddml.Wms.Domain.DamageHandlingMethod
{

    public partial class DamageHandlingMethodApplicationServiceFactory : IDamageHandlingMethodApplicationServiceFactory
    {

        public virtual IDamageHandlingMethodApplicationService DamageHandlingMethodApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["DamageHandlingMethodApplicationService"] as IDamageHandlingMethodApplicationService;
		    }
        }

        public virtual ICreateDamageHandlingMethod NewCreateDamageHandlingMethod()
        {
		    return new CreateDamageHandlingMethod();
        }

        public virtual IMergePatchDamageHandlingMethod NewMergePatchDamageHandlingMethod()
        {
            return new MergePatchDamageHandlingMethod();
        }

        public virtual IDeleteDamageHandlingMethod NewDeleteDamageHandlingMethod()
        {
            return new DeleteDamageHandlingMethod();
        }

    }


}

