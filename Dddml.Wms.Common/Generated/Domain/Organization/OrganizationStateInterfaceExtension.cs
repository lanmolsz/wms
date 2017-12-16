﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Organization;

namespace Dddml.Wms.Domain.Organization
{

	public static partial class OrganizationStateInterfaceExtension
	{

        public static IOrganizationCommand ToCreateOrMergePatchOrganization<TCreateOrganization, TMergePatchOrganization>(this IOrganizationState state)
            where TCreateOrganization : ICreateOrganization, new()
            where TMergePatchOrganization : IMergePatchOrganization, new()
        {
            bool bUnsaved = ((IOrganizationState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateOrganization<TCreateOrganization>();
            }
            else 
            {
                return state.ToMergePatchOrganization<TMergePatchOrganization>();
            }
        }

        public static TDeleteOrganization ToDeleteOrganization<TDeleteOrganization>(this IOrganizationState state)
            where TDeleteOrganization : IDeleteOrganization, new()
        {
            var cmd = new TDeleteOrganization();
            cmd.OrganizationId = state.OrganizationId;
            cmd.Version = ((IOrganizationStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchOrganization ToMergePatchOrganization<TMergePatchOrganization>(this IOrganizationState state)
            where TMergePatchOrganization : IMergePatchOrganization, new()
        {
            var cmd = new TMergePatchOrganization();

            cmd.Version = ((IOrganizationStateProperties)state).Version;

            cmd.OrganizationId = state.OrganizationId;
            cmd.OrganizationName = state.OrganizationName;
            cmd.Description = state.Description;
            cmd.Type = state.Type;
            cmd.IsSummary = state.IsSummary;
            cmd.Active = ((IOrganizationStateProperties)state).Active;
            
            if (state.OrganizationName == null) { cmd.IsPropertyOrganizationNameRemoved = true; }
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            if (state.Type == null) { cmd.IsPropertyTypeRemoved = true; }
            return cmd;
        }

        public static TCreateOrganization ToCreateOrganization<TCreateOrganization>(this IOrganizationState state)
            where TCreateOrganization : ICreateOrganization, new()
        {
            var cmd = new TCreateOrganization();

            cmd.Version = ((IOrganizationStateProperties)state).Version;

            cmd.OrganizationId = state.OrganizationId;
            cmd.OrganizationName = state.OrganizationName;
            cmd.Description = state.Description;
            cmd.Type = state.Type;
            cmd.IsSummary = state.IsSummary;
            cmd.Active = ((IOrganizationStateProperties)state).Active;
            return cmd;
        }
		

	}

}

