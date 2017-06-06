﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationStructureDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructure;

namespace Dddml.Wms.Domain.OrganizationStructure
{

    public class OrganizationStructureStateEventDtoConverter
    {
        public virtual OrganizationStructureStateCreatedOrMergePatchedOrDeletedDto ToOrganizationStructureStateEventDto(IOrganizationStructureStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IOrganizationStructureStateCreated)stateEvent;
                return ToOrganizationStructureStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IOrganizationStructureStateMergePatched)stateEvent;
                return ToOrganizationStructureStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IOrganizationStructureStateDeleted)stateEvent;
                return ToOrganizationStructureStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual OrganizationStructureStateCreatedDto ToOrganizationStructureStateCreatedDto(IOrganizationStructureStateCreated e)
        {
            var dto = new OrganizationStructureStateCreatedDto();
            dto.StateEventId = new OrganizationStructureStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Active = e.Active;
            return dto;
        }

        public virtual OrganizationStructureStateMergePatchedDto ToOrganizationStructureStateMergePatchedDto(IOrganizationStructureStateMergePatched e)
        {
            var dto = new OrganizationStructureStateMergePatchedDto();
            dto.StateEventId = new OrganizationStructureStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Active = e.Active;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual OrganizationStructureStateDeletedDto ToOrganizationStructureStateDeletedDto(IOrganizationStructureStateDeleted e)
        {
            var dto = new OrganizationStructureStateDeletedDto();
            dto.StateEventId = new OrganizationStructureStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

