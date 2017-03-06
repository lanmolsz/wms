﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Audience;

namespace Dddml.Wms.Domain.Audience
{

	public static partial class AudienceStateInterfaceExtension
	{

        public static IAudienceCommand ToCreateOrMergePatchAudience<TCreateAudience, TMergePatchAudience>(this IAudienceState state)
            where TCreateAudience : ICreateAudience, new()
            where TMergePatchAudience : IMergePatchAudience, new()
        {
            bool bUnsaved = ((IAudienceState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateAudience<TCreateAudience>();
            }
            else 
            {
                return state.ToMergePatchAudience<TMergePatchAudience>();
            }
        }

        public static TDeleteAudience ToDeleteAudience<TDeleteAudience>(this IAudienceState state)
            where TDeleteAudience : IDeleteAudience, new()
        {
            var cmd = new TDeleteAudience();
            cmd.ClientId = state.ClientId;
            cmd.Version = ((IAudienceStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchAudience ToMergePatchAudience<TMergePatchAudience>(this IAudienceState state)
            where TMergePatchAudience : IMergePatchAudience, new()
        {
            var cmd = new TMergePatchAudience();

            cmd.Version = ((IAudienceStateProperties)state).Version;

            cmd.ClientId = state.ClientId;
            cmd.Name = state.Name;
            cmd.Base64Secret = state.Base64Secret;
            cmd.Active = ((IAudienceStateProperties)state).Active;
            
            if (state.Name == null) { cmd.IsPropertyNameRemoved = true; }
            if (state.Base64Secret == null) { cmd.IsPropertyBase64SecretRemoved = true; }
            return cmd;
        }

        public static TCreateAudience ToCreateAudience<TCreateAudience>(this IAudienceState state)
            where TCreateAudience : ICreateAudience, new()
        {
            var cmd = new TCreateAudience();

            cmd.Version = ((IAudienceStateProperties)state).Version;

            cmd.ClientId = state.ClientId;
            cmd.Name = state.Name;
            cmd.Base64Secret = state.Base64Secret;
            cmd.Active = ((IAudienceStateProperties)state).Active;
            return cmd;
        }
		

	}

}

