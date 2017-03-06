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

	public static partial class AudienceStateDtoExtension
	{

        public static IAudienceCommand ToCreateOrMergePatchAudience(this AudienceStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchAudience<CreateAudienceDto, MergePatchAudienceDto>();
        }

        public static DeleteAudienceDto ToDeleteAudience(this AudienceStateDtoWrapper state)
        {
            return state.ToDeleteAudience<DeleteAudienceDto>();
        }

        public static MergePatchAudienceDto ToMergePatchAudience(this AudienceStateDtoWrapper state)
        {
            return state.ToMergePatchAudience<MergePatchAudienceDto>();
        }

        public static CreateAudienceDto ToCreateAudience(this AudienceStateDtoWrapper state)
        {
            return state.ToCreateAudience<CreateAudienceDto>();
        }
		

	}

}

