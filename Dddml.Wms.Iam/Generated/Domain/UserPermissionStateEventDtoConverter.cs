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

    public class UserPermissionStateEventDtoConverter
    {
        public virtual UserPermissionStateCreatedOrMergePatchedOrRemovedDto ToUserPermissionStateEventDto(IUserPermissionStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IUserPermissionStateCreated)stateEvent;
                return ToUserPermissionStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IUserPermissionStateMergePatched)stateEvent;
                return ToUserPermissionStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Removed)
            {
                var e = (IUserPermissionStateRemoved)stateEvent;
                return ToUserPermissionStateRemovedDto(e);
            }

            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual UserPermissionStateCreatedDto ToUserPermissionStateCreatedDto(IUserPermissionStateCreated e)
        {
            var dto = new UserPermissionStateCreatedDto();
            dto.StateEventId = new UserPermissionStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Active = e.Active;
            return dto;
        }

        public virtual UserPermissionStateMergePatchedDto ToUserPermissionStateMergePatchedDto(IUserPermissionStateMergePatched e)
        {
            var dto = new UserPermissionStateMergePatchedDto();
            dto.StateEventId = new UserPermissionStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Active = e.Active;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual UserPermissionStateRemovedDto ToUserPermissionStateRemovedDto(IUserPermissionStateRemoved e)
        {
            var dto = new UserPermissionStateRemovedDto();
            dto.StateEventId = new UserPermissionStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

