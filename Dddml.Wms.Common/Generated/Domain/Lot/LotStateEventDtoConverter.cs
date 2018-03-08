﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLotDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Lot;

namespace Dddml.Wms.Domain.Lot
{

    public class LotStateEventDtoConverter
    {
        public virtual LotStateCreatedOrMergePatchedOrDeletedDto ToLotStateEventDto(ILotStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (ILotStateCreated)stateEvent;
                return ToLotStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (ILotStateMergePatched)stateEvent;
                return ToLotStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (ILotStateDeleted)stateEvent;
                return ToLotStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual LotStateCreatedDto ToLotStateCreatedDto(ILotStateCreated e)
        {
            var dto = new LotStateCreatedDto();
            dto.StateEventId = new LotEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Quantity = e.Quantity;
            dto.ExpirationDate = e.ExpirationDate;
            dto.Active = e.Active;
            return dto;
        }

        public virtual LotStateMergePatchedDto ToLotStateMergePatchedDto(ILotStateMergePatched e)
        {
            var dto = new LotStateMergePatchedDto();
            dto.StateEventId = new LotEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Quantity = e.Quantity;
            dto.ExpirationDate = e.ExpirationDate;
            dto.Active = e.Active;
            dto.IsPropertyQuantityRemoved = e.IsPropertyQuantityRemoved;
            dto.IsPropertyExpirationDateRemoved = e.IsPropertyExpirationDateRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual LotStateDeletedDto ToLotStateDeletedDto(ILotStateDeleted e)
        {
            var dto = new LotStateDeletedDto();
            dto.StateEventId = new LotEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

