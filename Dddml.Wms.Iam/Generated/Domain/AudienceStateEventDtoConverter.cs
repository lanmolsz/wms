﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Audience;

namespace Dddml.Wms.Domain.Audience
{

    public class AudienceStateEventDtoConverter
    {
        public virtual AudienceStateCreatedOrMergePatchedOrDeletedDto ToAudienceStateEventDto(IAudienceStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IAudienceStateCreated)stateEvent;
                return ToAudienceStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IAudienceStateMergePatched)stateEvent;
                return ToAudienceStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IAudienceStateDeleted)stateEvent;
                return ToAudienceStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual AudienceStateCreatedDto ToAudienceStateCreatedDto(IAudienceStateCreated e)
        {
            var dto = new AudienceStateCreatedDto();
            dto.StateEventId = new AudienceEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Name = e.Name;
            dto.Base64Secret = e.Base64Secret;
            dto.Active = e.Active;
            return dto;
        }

        public virtual AudienceStateMergePatchedDto ToAudienceStateMergePatchedDto(IAudienceStateMergePatched e)
        {
            var dto = new AudienceStateMergePatchedDto();
            dto.StateEventId = new AudienceEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Name = e.Name;
            dto.Base64Secret = e.Base64Secret;
            dto.Active = e.Active;
            dto.IsPropertyNameRemoved = e.IsPropertyNameRemoved;
            dto.IsPropertyBase64SecretRemoved = e.IsPropertyBase64SecretRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual AudienceStateDeletedDto ToAudienceStateDeletedDto(IAudienceStateDeleted e)
        {
            var dto = new AudienceStateDeletedDto();
            dto.StateEventId = new AudienceEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

