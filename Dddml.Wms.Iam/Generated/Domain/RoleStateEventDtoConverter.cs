﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Role;

namespace Dddml.Wms.Domain.Role
{

    public class RoleStateEventDtoConverter
    {
        public virtual RoleStateCreatedOrMergePatchedOrDeletedDto ToRoleStateEventDto(IRoleStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IRoleStateCreated)stateEvent;
                return ToRoleStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IRoleStateMergePatched)stateEvent;
                return ToRoleStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IRoleStateDeleted)stateEvent;
                return ToRoleStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual RoleStateCreatedDto ToRoleStateCreatedDto(IRoleStateCreated e)
        {
            var dto = new RoleStateCreatedDto();
            dto.StateEventId = new RoleEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Name = e.Name;
            dto.Description = e.Description;
            dto.Active = e.Active;
            return dto;
        }

        public virtual RoleStateMergePatchedDto ToRoleStateMergePatchedDto(IRoleStateMergePatched e)
        {
            var dto = new RoleStateMergePatchedDto();
            dto.StateEventId = new RoleEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Name = e.Name;
            dto.Description = e.Description;
            dto.Active = e.Active;
            dto.IsPropertyNameRemoved = e.IsPropertyNameRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual RoleStateDeletedDto ToRoleStateDeletedDto(IRoleStateDeleted e)
        {
            var dto = new RoleStateDeletedDto();
            dto.StateEventId = new RoleEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

