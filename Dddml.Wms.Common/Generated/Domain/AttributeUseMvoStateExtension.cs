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

	public static partial class AttributeUseMvoStateExtension
	{

        public static IAttributeUseMvoCommand ToCreateOrMergePatchAttributeUseMvo(this AttributeUseMvoState state)
        {
            return state.ToCreateOrMergePatchAttributeUseMvo<CreateAttributeUseMvo, MergePatchAttributeUseMvo>();
        }

        public static DeleteAttributeUseMvo ToDeleteAttributeUseMvo(this AttributeUseMvoState state)
        {
            return state.ToDeleteAttributeUseMvo<DeleteAttributeUseMvo>();
        }

        public static MergePatchAttributeUseMvo ToMergePatchAttributeUseMvo(this AttributeUseMvoState state)
        {
            return state.ToMergePatchAttributeUseMvo<MergePatchAttributeUseMvo>();
        }

        public static CreateAttributeUseMvo ToCreateAttributeUseMvo(this AttributeUseMvoState state)
        {
            return state.ToCreateAttributeUseMvo<CreateAttributeUseMvo>();
        }
		

	}

}
