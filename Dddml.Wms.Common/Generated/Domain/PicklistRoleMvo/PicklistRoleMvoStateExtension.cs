﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistRoleMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistRoleMvo;
using Dddml.Wms.Domain.Picklist;

namespace Dddml.Wms.Domain.PicklistRoleMvo
{

	public static partial class PicklistRoleMvoStateExtension
	{

        public static IPicklistRoleMvoCommand ToCreateOrMergePatchPicklistRoleMvo(this PicklistRoleMvoState state)
        {
            return state.ToCreateOrMergePatchPicklistRoleMvo<CreatePicklistRoleMvo, MergePatchPicklistRoleMvo>();
        }

        public static DeletePicklistRoleMvo ToDeletePicklistRoleMvo(this PicklistRoleMvoState state)
        {
            return state.ToDeletePicklistRoleMvo<DeletePicklistRoleMvo>();
        }

        public static MergePatchPicklistRoleMvo ToMergePatchPicklistRoleMvo(this PicklistRoleMvoState state)
        {
            return state.ToMergePatchPicklistRoleMvo<MergePatchPicklistRoleMvo>();
        }

        public static CreatePicklistRoleMvo ToCreatePicklistRoleMvo(this PicklistRoleMvoState state)
        {
            return state.ToCreatePicklistRoleMvo<CreatePicklistRoleMvo>();
        }
		

	}

}

