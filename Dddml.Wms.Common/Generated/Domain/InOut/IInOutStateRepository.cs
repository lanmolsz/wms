﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.InOut
{
	public partial interface IInOutStateRepository
	{

        IInOutState Get(string id, bool nullAllowed);
        
        void Save(IInOutState state);
        
	}

}

