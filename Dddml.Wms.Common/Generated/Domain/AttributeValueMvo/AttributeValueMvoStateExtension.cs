﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeValueMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeValueMvo;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.AttributeValueMvo
{

	public static partial class AttributeValueMvoStateExtension
	{

        public static IAttributeValueMvoCommand ToCreateOrMergePatchAttributeValueMvo(this AttributeValueMvoState state)
        {
            return state.ToCreateOrMergePatchAttributeValueMvo<CreateAttributeValueMvo, MergePatchAttributeValueMvo>();
        }

        public static DeleteAttributeValueMvo ToDeleteAttributeValueMvo(this AttributeValueMvoState state)
        {
            return state.ToDeleteAttributeValueMvo<DeleteAttributeValueMvo>();
        }

        public static MergePatchAttributeValueMvo ToMergePatchAttributeValueMvo(this AttributeValueMvoState state)
        {
            return state.ToMergePatchAttributeValueMvo<MergePatchAttributeValueMvo>();
        }

        public static CreateAttributeValueMvo ToCreateAttributeValueMvo(this AttributeValueMvoState state)
        {
            return state.ToCreateAttributeValueMvo<CreateAttributeValueMvo>();
        }
		

	}

}

