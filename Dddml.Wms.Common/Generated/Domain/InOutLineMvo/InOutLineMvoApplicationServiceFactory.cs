﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOutLineMvo
{

    public partial class InOutLineMvoApplicationServiceFactory : IInOutLineMvoApplicationServiceFactory
    {

        public virtual IInOutLineMvoApplicationService InOutLineMvoApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["InOutLineMvoApplicationService"] as IInOutLineMvoApplicationService;
		    }
        }

        public virtual ICreateInOutLineMvo NewCreateInOutLineMvo()
        {
		    return new CreateInOutLineMvo();
        }

        public virtual IMergePatchInOutLineMvo NewMergePatchInOutLineMvo()
        {
            return new MergePatchInOutLineMvo();
        }

        public virtual IDeleteInOutLineMvo NewDeleteInOutLineMvo()
        {
            return new DeleteInOutLineMvo();
        }

    }


}

