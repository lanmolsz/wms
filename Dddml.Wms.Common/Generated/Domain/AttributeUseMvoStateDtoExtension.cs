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

	public static partial class AttributeUseMvoStateDtoExtension
	{

        public static IAttributeUseMvoCommand ToCreateOrMergePatchAttributeUseMvo(this AttributeUseMvoStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchAttributeUseMvo<CreateAttributeUseMvoDto, MergePatchAttributeUseMvoDto>();
        }

        public static DeleteAttributeUseMvoDto ToDeleteAttributeUseMvo(this AttributeUseMvoStateDtoWrapper state)
        {
            return state.ToDeleteAttributeUseMvo<DeleteAttributeUseMvoDto>();
        }

        public static MergePatchAttributeUseMvoDto ToMergePatchAttributeUseMvo(this AttributeUseMvoStateDtoWrapper state)
        {
            return state.ToMergePatchAttributeUseMvo<MergePatchAttributeUseMvoDto>();
        }

        public static CreateAttributeUseMvoDto ToCreateAttributeUseMvo(this AttributeUseMvoStateDtoWrapper state)
        {
            return state.ToCreateAttributeUseMvo<CreateAttributeUseMvoDto>();
        }
		

	}

}
