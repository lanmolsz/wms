﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserRoleMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserRoleMvo
{

    public partial class UserRoleMvoApplicationServiceFactory : IUserRoleMvoApplicationServiceFactory
    {

        public virtual IUserRoleMvoApplicationService UserRoleMvoApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["UserRoleMvoApplicationService"] as IUserRoleMvoApplicationService;
		    }
        }

        public virtual ICreateUserRoleMvo NewCreateUserRoleMvo()
        {
		    return new CreateUserRoleMvo();
        }

        public virtual IMergePatchUserRoleMvo NewMergePatchUserRoleMvo()
        {
            return new MergePatchUserRoleMvo();
        }

        public virtual IDeleteUserRoleMvo NewDeleteUserRoleMvo()
        {
            return new DeleteUserRoleMvo();
        }

    }


}

