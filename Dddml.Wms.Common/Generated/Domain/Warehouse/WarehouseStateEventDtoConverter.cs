﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateWarehouseDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Warehouse;

namespace Dddml.Wms.Domain.Warehouse
{

    public class WarehouseStateEventDtoConverter
    {
        public virtual WarehouseStateCreatedOrMergePatchedOrDeletedDto ToWarehouseStateEventDto(IWarehouseStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IWarehouseStateCreated)stateEvent;
                return ToWarehouseStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IWarehouseStateMergePatched)stateEvent;
                return ToWarehouseStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IWarehouseStateDeleted)stateEvent;
                return ToWarehouseStateDeletedDto(e);
            }

            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual WarehouseStateCreatedDto ToWarehouseStateCreatedDto(IWarehouseStateCreated e)
        {
            var dto = new WarehouseStateCreatedDto();
            dto.StateEventId = new WarehouseStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Name = e.Name;
            dto.Description = e.Description;
            dto.IsInTransit = e.IsInTransit;
            dto.Active = e.Active;
            return dto;
        }

        public virtual WarehouseStateMergePatchedDto ToWarehouseStateMergePatchedDto(IWarehouseStateMergePatched e)
        {
            var dto = new WarehouseStateMergePatchedDto();
            dto.StateEventId = new WarehouseStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Name = e.Name;
            dto.Description = e.Description;
            dto.IsInTransit = e.IsInTransit;
            dto.Active = e.Active;
            dto.IsPropertyNameRemoved = e.IsPropertyNameRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyIsInTransitRemoved = e.IsPropertyIsInTransitRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual WarehouseStateDeletedDto ToWarehouseStateDeletedDto(IWarehouseStateDeleted e)
        {
            var dto = new WarehouseStateDeletedDto();
            dto.StateEventId = new WarehouseStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}
