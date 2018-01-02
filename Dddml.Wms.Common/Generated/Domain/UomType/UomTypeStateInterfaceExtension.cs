﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomType;

namespace Dddml.Wms.Domain.UomType
{

	public static partial class UomTypeStateInterfaceExtension
	{

        public static IUomTypeCommand ToCreateOrMergePatchUomType<TCreateUomType, TMergePatchUomType>(this IUomTypeState state)
            where TCreateUomType : ICreateUomType, new()
            where TMergePatchUomType : IMergePatchUomType, new()
        {
            bool bUnsaved = ((IUomTypeState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateUomType<TCreateUomType>();
            }
            else 
            {
                return state.ToMergePatchUomType<TMergePatchUomType>();
            }
        }

        public static TDeleteUomType ToDeleteUomType<TDeleteUomType>(this IUomTypeState state)
            where TDeleteUomType : IDeleteUomType, new()
        {
            var cmd = new TDeleteUomType();
            cmd.UomTypeId = state.UomTypeId;
            cmd.Version = ((IUomTypeStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchUomType ToMergePatchUomType<TMergePatchUomType>(this IUomTypeState state)
            where TMergePatchUomType : IMergePatchUomType, new()
        {
            var cmd = new TMergePatchUomType();

            cmd.Version = ((IUomTypeStateProperties)state).Version;

            cmd.UomTypeId = state.UomTypeId;
            cmd.ParentTypeId = state.ParentTypeId;
            cmd.HasTable = state.HasTable;
            cmd.Description = state.Description;
            cmd.Active = ((IUomTypeStateProperties)state).Active;
            
            if (state.ParentTypeId == null) { cmd.IsPropertyParentTypeIdRemoved = true; }
            if (state.HasTable == null) { cmd.IsPropertyHasTableRemoved = true; }
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            return cmd;
        }

        public static TCreateUomType ToCreateUomType<TCreateUomType>(this IUomTypeState state)
            where TCreateUomType : ICreateUomType, new()
        {
            var cmd = new TCreateUomType();

            cmd.Version = ((IUomTypeStateProperties)state).Version;

            cmd.UomTypeId = state.UomTypeId;
            cmd.ParentTypeId = state.ParentTypeId;
            cmd.HasTable = state.HasTable;
            cmd.Description = state.Description;
            cmd.Active = ((IUomTypeStateProperties)state).Active;
            return cmd;
        }
		

	}

}
