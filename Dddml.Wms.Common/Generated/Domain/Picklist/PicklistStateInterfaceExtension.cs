﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Picklist
{

	public static partial class PicklistStateInterfaceExtension
	{

        public static IPicklistCommand ToCreateOrMergePatchPicklist<TCreatePicklist, TMergePatchPicklist, TCreatePicklistRole, TMergePatchPicklistRole>(this IPicklistState state)
            where TCreatePicklist : ICreatePicklist, new()
            where TMergePatchPicklist : IMergePatchPicklist, new()
            where TCreatePicklistRole : ICreatePicklistRole, new()
            where TMergePatchPicklistRole : IMergePatchPicklistRole, new()
        {
            bool bUnsaved = ((IPicklistState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreatePicklist<TCreatePicklist, TCreatePicklistRole>();
            }
            else 
            {
                return state.ToMergePatchPicklist<TMergePatchPicklist, TCreatePicklistRole, TMergePatchPicklistRole>();
            }
        }

        public static TDeletePicklist ToDeletePicklist<TDeletePicklist>(this IPicklistState state)
            where TDeletePicklist : IDeletePicklist, new()
        {
            var cmd = new TDeletePicklist();
            cmd.PicklistId = state.PicklistId;
            cmd.Version = ((IPicklistStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchPicklist ToMergePatchPicklist<TMergePatchPicklist, TCreatePicklistRole, TMergePatchPicklistRole>(this IPicklistState state)
            where TMergePatchPicklist : IMergePatchPicklist, new()
            where TCreatePicklistRole : ICreatePicklistRole, new()
            where TMergePatchPicklistRole : IMergePatchPicklistRole, new()
        {
            var cmd = new TMergePatchPicklist();

            cmd.Version = ((IPicklistStateProperties)state).Version;

            cmd.PicklistId = state.PicklistId;
            cmd.Description = state.Description;
            cmd.FacilityId = state.FacilityId;
            cmd.ShipmentMethodTypeId = state.ShipmentMethodTypeId;
            cmd.StatusId = state.StatusId;
            cmd.PicklistDate = state.PicklistDate;
            cmd.PickwaveId = state.PickwaveId;
            cmd.Active = ((IPicklistStateProperties)state).Active;
            
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            if (state.FacilityId == null) { cmd.IsPropertyFacilityIdRemoved = true; }
            if (state.ShipmentMethodTypeId == null) { cmd.IsPropertyShipmentMethodTypeIdRemoved = true; }
            if (state.StatusId == null) { cmd.IsPropertyStatusIdRemoved = true; }
            if (state.PicklistDate == null) { cmd.IsPropertyPicklistDateRemoved = true; }
            if (state.PickwaveId == null) { cmd.IsPropertyPickwaveIdRemoved = true; }
            foreach (var d in state.PicklistRoles)
            {
                var c = d.ToCreateOrMergePatchPicklistRole<TCreatePicklistRole, TMergePatchPicklistRole>();
                cmd.PicklistRoleCommands.Add(c);
            }
            return cmd;
        }

        public static TCreatePicklist ToCreatePicklist<TCreatePicklist, TCreatePicklistRole>(this IPicklistState state)
            where TCreatePicklist : ICreatePicklist, new()
            where TCreatePicklistRole : ICreatePicklistRole, new()
        {
            var cmd = new TCreatePicklist();

            cmd.Version = ((IPicklistStateProperties)state).Version;

            cmd.PicklistId = state.PicklistId;
            cmd.Description = state.Description;
            cmd.FacilityId = state.FacilityId;
            cmd.ShipmentMethodTypeId = state.ShipmentMethodTypeId;
            cmd.StatusId = state.StatusId;
            cmd.PicklistDate = state.PicklistDate;
            cmd.PickwaveId = state.PickwaveId;
            cmd.Active = ((IPicklistStateProperties)state).Active;
            foreach (var d in state.PicklistRoles)
            {
                var c = d.ToCreatePicklistRole<TCreatePicklistRole>();
                cmd.PicklistRoles.Add(c);
            }
            return cmd;
        }
		

	}

}

