﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{

	public static partial class AttributeAliasStateDtoExtension
	{

        public static IAttributeAliasCommand ToCreateOrMergePatchAttributeAlias(this AttributeAliasStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchAttributeAlias<CreateAttributeAliasDto, MergePatchAttributeAliasDto>();
        }

        public static RemoveAttributeAliasDto ToRemoveAttributeAlias(this AttributeAliasStateDtoWrapper state)
        {
            return state.ToRemoveAttributeAlias<RemoveAttributeAliasDto>();
        }

        public static MergePatchAttributeAliasDto ToMergePatchAttributeAlias(this AttributeAliasStateDtoWrapper state)
        {
            return state.ToMergePatchAttributeAlias<MergePatchAttributeAliasDto>();
        }

        public static CreateAttributeAliasDto ToCreateAttributeAlias(this AttributeAliasStateDtoWrapper state)
        {
            return state.ToCreateAttributeAlias<CreateAttributeAliasDto>();
        }
		

	}

}

