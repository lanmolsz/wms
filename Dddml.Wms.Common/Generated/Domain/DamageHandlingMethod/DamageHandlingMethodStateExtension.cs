﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageHandlingMethodDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageHandlingMethod;

namespace Dddml.Wms.Domain.DamageHandlingMethod
{

	public static partial class DamageHandlingMethodStateExtension
	{

        public static IDamageHandlingMethodCommand ToCreateOrMergePatchDamageHandlingMethod(this DamageHandlingMethodState state)
        {
            return state.ToCreateOrMergePatchDamageHandlingMethod<CreateDamageHandlingMethod, MergePatchDamageHandlingMethod>();
        }

        public static DeleteDamageHandlingMethod ToDeleteDamageHandlingMethod(this DamageHandlingMethodState state)
        {
            return state.ToDeleteDamageHandlingMethod<DeleteDamageHandlingMethod>();
        }

        public static MergePatchDamageHandlingMethod ToMergePatchDamageHandlingMethod(this DamageHandlingMethodState state)
        {
            return state.ToMergePatchDamageHandlingMethod<MergePatchDamageHandlingMethod>();
        }

        public static CreateDamageHandlingMethod ToCreateDamageHandlingMethod(this DamageHandlingMethodState state)
        {
            return state.ToCreateDamageHandlingMethod<CreateDamageHandlingMethod>();
        }
		

	}

}

