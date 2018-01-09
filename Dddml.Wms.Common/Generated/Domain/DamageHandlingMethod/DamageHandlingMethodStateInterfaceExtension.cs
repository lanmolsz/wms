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

	public static partial class DamageHandlingMethodStateInterfaceExtension
	{

        public static IDamageHandlingMethodCommand ToCreateOrMergePatchDamageHandlingMethod<TCreateDamageHandlingMethod, TMergePatchDamageHandlingMethod>(this IDamageHandlingMethodState state)
            where TCreateDamageHandlingMethod : ICreateDamageHandlingMethod, new()
            where TMergePatchDamageHandlingMethod : IMergePatchDamageHandlingMethod, new()
        {
            bool bUnsaved = ((IDamageHandlingMethodState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateDamageHandlingMethod<TCreateDamageHandlingMethod>();
            }
            else 
            {
                return state.ToMergePatchDamageHandlingMethod<TMergePatchDamageHandlingMethod>();
            }
        }

        public static TDeleteDamageHandlingMethod ToDeleteDamageHandlingMethod<TDeleteDamageHandlingMethod>(this IDamageHandlingMethodState state)
            where TDeleteDamageHandlingMethod : IDeleteDamageHandlingMethod, new()
        {
            var cmd = new TDeleteDamageHandlingMethod();
            cmd.DamageHandlingMethodId = state.DamageHandlingMethodId;
            cmd.Version = ((IDamageHandlingMethodStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchDamageHandlingMethod ToMergePatchDamageHandlingMethod<TMergePatchDamageHandlingMethod>(this IDamageHandlingMethodState state)
            where TMergePatchDamageHandlingMethod : IMergePatchDamageHandlingMethod, new()
        {
            var cmd = new TMergePatchDamageHandlingMethod();

            cmd.Version = ((IDamageHandlingMethodStateProperties)state).Version;

            cmd.DamageHandlingMethodId = state.DamageHandlingMethodId;
            cmd.Description = state.Description;
            cmd.SequenceId = state.SequenceId;
            cmd.Active = ((IDamageHandlingMethodStateProperties)state).Active;
            
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            if (state.SequenceId == null) { cmd.IsPropertySequenceIdRemoved = true; }
            return cmd;
        }

        public static TCreateDamageHandlingMethod ToCreateDamageHandlingMethod<TCreateDamageHandlingMethod>(this IDamageHandlingMethodState state)
            where TCreateDamageHandlingMethod : ICreateDamageHandlingMethod, new()
        {
            var cmd = new TCreateDamageHandlingMethod();

            cmd.Version = ((IDamageHandlingMethodStateProperties)state).Version;

            cmd.DamageHandlingMethodId = state.DamageHandlingMethodId;
            cmd.Description = state.Description;
            cmd.SequenceId = state.SequenceId;
            cmd.Active = ((IDamageHandlingMethodStateProperties)state).Active;
            return cmd;
        }
		

	}

}
