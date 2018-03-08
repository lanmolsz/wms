﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentType;

namespace Dddml.Wms.Domain.ShipmentType
{

    public class ShipmentTypeStateEventDtoConverter
    {
        public virtual ShipmentTypeStateCreatedOrMergePatchedOrDeletedDto ToShipmentTypeStateEventDto(IShipmentTypeStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IShipmentTypeStateCreated)stateEvent;
                return ToShipmentTypeStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IShipmentTypeStateMergePatched)stateEvent;
                return ToShipmentTypeStateMergePatchedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual ShipmentTypeStateCreatedDto ToShipmentTypeStateCreatedDto(IShipmentTypeStateCreated e)
        {
            var dto = new ShipmentTypeStateCreatedDto();
            dto.StateEventId = new ShipmentTypeEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ParentTypeId = e.ParentTypeId;
            dto.HasTable = e.HasTable;
            dto.Description = e.Description;
            dto.Active = e.Active;
            return dto;
        }

        public virtual ShipmentTypeStateMergePatchedDto ToShipmentTypeStateMergePatchedDto(IShipmentTypeStateMergePatched e)
        {
            var dto = new ShipmentTypeStateMergePatchedDto();
            dto.StateEventId = new ShipmentTypeEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ParentTypeId = e.ParentTypeId;
            dto.HasTable = e.HasTable;
            dto.Description = e.Description;
            dto.Active = e.Active;
            dto.IsPropertyParentTypeIdRemoved = e.IsPropertyParentTypeIdRemoved;
            dto.IsPropertyHasTableRemoved = e.IsPropertyHasTableRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }



    }


}

