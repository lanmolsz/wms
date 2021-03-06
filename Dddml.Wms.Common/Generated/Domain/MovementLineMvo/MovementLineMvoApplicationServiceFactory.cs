﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementLineMvo;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.MovementLineMvo
{

    public partial class MovementLineMvoApplicationServiceFactory : IMovementLineMvoApplicationServiceFactory
    {

        public virtual IMovementLineMvoApplicationService MovementLineMvoApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["MovementLineMvoApplicationService"] as IMovementLineMvoApplicationService;
		    }
        }

        public virtual ICreateMovementLineMvo NewCreateMovementLineMvo()
        {
		    return new CreateMovementLineMvo();
        }

        public virtual IMergePatchMovementLineMvo NewMergePatchMovementLineMvo()
        {
            return new MergePatchMovementLineMvo();
        }

        public virtual IDeleteMovementLineMvo NewDeleteMovementLineMvo()
        {
            return new DeleteMovementLineMvo();
        }

    }


}

