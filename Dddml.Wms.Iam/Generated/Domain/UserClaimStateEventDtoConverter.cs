﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

    public class UserClaimStateEventDtoConverter
    {
        public virtual UserClaimStateCreatedOrMergePatchedOrRemovedDto ToUserClaimStateEventDto(IUserClaimEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (IUserClaimStateCreated)stateEvent;
                return ToUserClaimStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (IUserClaimStateMergePatched)stateEvent;
                return ToUserClaimStateMergePatchedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.Removed)
            {
                var e = (IUserClaimStateRemoved)stateEvent;
                return ToUserClaimStateRemovedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual UserClaimStateCreatedDto ToUserClaimStateCreatedDto(IUserClaimStateCreated e)
        {
            var dto = new UserClaimStateCreatedDto();
            dto.UserClaimEventId = e.UserClaimEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.ClaimType = e.ClaimType;
            dto.ClaimValue = e.ClaimValue;
            dto.Active = e.Active;
            return dto;
        }

        public virtual UserClaimStateMergePatchedDto ToUserClaimStateMergePatchedDto(IUserClaimStateMergePatched e)
        {
            var dto = new UserClaimStateMergePatchedDto();
            dto.UserClaimEventId = e.UserClaimEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.ClaimType = e.ClaimType;
            dto.ClaimValue = e.ClaimValue;
            dto.Active = e.Active;
            dto.IsPropertyClaimTypeRemoved = e.IsPropertyClaimTypeRemoved;
            dto.IsPropertyClaimValueRemoved = e.IsPropertyClaimValueRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual UserClaimStateRemovedDto ToUserClaimStateRemovedDto(IUserClaimStateRemoved e)
        {
            var dto = new UserClaimStateRemovedDto();
            dto.UserClaimEventId = e.UserClaimEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

