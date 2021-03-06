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

    public class UserRoleStateEventDtoConverter
    {
        public virtual UserRoleStateCreatedOrMergePatchedOrRemovedDto ToUserRoleStateEventDto(IUserRoleEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (IUserRoleStateCreated)stateEvent;
                return ToUserRoleStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (IUserRoleStateMergePatched)stateEvent;
                return ToUserRoleStateMergePatchedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.Removed)
            {
                var e = (IUserRoleStateRemoved)stateEvent;
                return ToUserRoleStateRemovedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual UserRoleStateCreatedDto ToUserRoleStateCreatedDto(IUserRoleStateCreated e)
        {
            var dto = new UserRoleStateCreatedDto();
            dto.UserRoleEventId = e.UserRoleEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Active = e.Active;
            return dto;
        }

        public virtual UserRoleStateMergePatchedDto ToUserRoleStateMergePatchedDto(IUserRoleStateMergePatched e)
        {
            var dto = new UserRoleStateMergePatchedDto();
            dto.UserRoleEventId = e.UserRoleEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Active = e.Active;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual UserRoleStateRemovedDto ToUserRoleStateRemovedDto(IUserRoleStateRemoved e)
        {
            var dto = new UserRoleStateRemovedDto();
            dto.UserRoleEventId = e.UserRoleEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

