﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageType;

namespace Dddml.Wms.Domain.DamageType
{

    public partial class DamageTypeApplicationServiceFactory : IDamageTypeApplicationServiceFactory
    {

        public virtual IDamageTypeApplicationService DamageTypeApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["DamageTypeApplicationService"] as IDamageTypeApplicationService;
		    }
        }

        public virtual ICreateDamageType NewCreateDamageType()
        {
		    return new CreateDamageType();
        }

        public virtual IMergePatchDamageType NewMergePatchDamageType()
        {
            return new MergePatchDamageType();
        }

        public virtual IDeleteDamageType NewDeleteDamageType()
        {
            return new DeleteDamageType();
        }

    }


}

