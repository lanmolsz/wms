﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeUseMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeUseMvo;
using Dddml.Wms.Domain.AttributeSet;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.AttributeUseMvo
{
	public partial interface IAttributeUseMvoStateRepository
	{

        IAttributeUseMvoState Get(AttributeSetAttributeUseId id, bool nullAllowed);
        
        void Save(IAttributeUseMvoState state);
        
	}

}
