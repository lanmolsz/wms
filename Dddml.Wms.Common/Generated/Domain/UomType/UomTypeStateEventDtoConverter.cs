﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomType;

namespace Dddml.Wms.Domain.UomType
{

    public class UomTypeStateEventDtoConverter
    {
        public virtual UomTypeStateCreatedOrMergePatchedOrDeletedDto ToUomTypeStateEventDto(IUomTypeStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IUomTypeStateCreated)stateEvent;
                return ToUomTypeStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IUomTypeStateMergePatched)stateEvent;
                return ToUomTypeStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IUomTypeStateDeleted)stateEvent;
                return ToUomTypeStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual UomTypeStateCreatedDto ToUomTypeStateCreatedDto(IUomTypeStateCreated e)
        {
            var dto = new UomTypeStateCreatedDto();
            dto.StateEventId = new UomTypeStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ParentTypeId = e.ParentTypeId;
            dto.HasTable = e.HasTable;
            dto.Description = e.Description;
            dto.Active = e.Active;
            return dto;
        }

        public virtual UomTypeStateMergePatchedDto ToUomTypeStateMergePatchedDto(IUomTypeStateMergePatched e)
        {
            var dto = new UomTypeStateMergePatchedDto();
            dto.StateEventId = new UomTypeStateEventIdDtoWrapper(e.StateEventId);
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


        public virtual UomTypeStateDeletedDto ToUomTypeStateDeletedDto(IUomTypeStateDeleted e)
        {
            var dto = new UomTypeStateDeletedDto();
            dto.StateEventId = new UomTypeStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}
