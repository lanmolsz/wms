﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmation
{

    public class MovementConfirmationStateEventDtoConverter
    {
        public virtual MovementConfirmationStateCreatedOrMergePatchedOrDeletedDto ToMovementConfirmationStateEventDto(IMovementConfirmationStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IMovementConfirmationStateCreated)stateEvent;
                return ToMovementConfirmationStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IMovementConfirmationStateMergePatched)stateEvent;
                return ToMovementConfirmationStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IMovementConfirmationStateDeleted)stateEvent;
                return ToMovementConfirmationStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual MovementConfirmationStateCreatedDto ToMovementConfirmationStateCreatedDto(IMovementConfirmationStateCreated e)
        {
            var dto = new MovementConfirmationStateCreatedDto();
            dto.StateEventId = new MovementConfirmationStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.DocumentTypeId = e.DocumentTypeId;
            dto.DocumentStatusId = e.DocumentStatusId;
            dto.MovementDocumentNumber = e.MovementDocumentNumber;
            dto.IsApproved = e.IsApproved;
            dto.ApprovalAmount = e.ApprovalAmount;
            dto.Processing = e.Processing;
            dto.Processed = e.Processed;
            dto.Description = e.Description;
            dto.Active = e.Active;
            var movementConfirmationLineEvents = new List<MovementConfirmationLineStateCreatedDto>();
            foreach (var ee in e.MovementConfirmationLineEvents)
            {
                MovementConfirmationLineStateCreatedDto eeDto = MovementConfirmationLineStateEventDtoConverter.ToMovementConfirmationLineStateCreatedDto(ee);
                movementConfirmationLineEvents.Add(eeDto);
            }
            dto.MovementConfirmationLineEvents = movementConfirmationLineEvents.ToArray();

            return dto;
        }

        public virtual MovementConfirmationStateMergePatchedDto ToMovementConfirmationStateMergePatchedDto(IMovementConfirmationStateMergePatched e)
        {
            var dto = new MovementConfirmationStateMergePatchedDto();
            dto.StateEventId = new MovementConfirmationStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.DocumentTypeId = e.DocumentTypeId;
            dto.DocumentStatusId = e.DocumentStatusId;
            dto.MovementDocumentNumber = e.MovementDocumentNumber;
            dto.IsApproved = e.IsApproved;
            dto.ApprovalAmount = e.ApprovalAmount;
            dto.Processing = e.Processing;
            dto.Processed = e.Processed;
            dto.Description = e.Description;
            dto.Active = e.Active;
            dto.IsPropertyDocumentTypeIdRemoved = e.IsPropertyDocumentTypeIdRemoved;
            dto.IsPropertyDocumentStatusIdRemoved = e.IsPropertyDocumentStatusIdRemoved;
            dto.IsPropertyMovementDocumentNumberRemoved = e.IsPropertyMovementDocumentNumberRemoved;
            dto.IsPropertyIsApprovedRemoved = e.IsPropertyIsApprovedRemoved;
            dto.IsPropertyApprovalAmountRemoved = e.IsPropertyApprovalAmountRemoved;
            dto.IsPropertyProcessingRemoved = e.IsPropertyProcessingRemoved;
            dto.IsPropertyProcessedRemoved = e.IsPropertyProcessedRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;
            var movementConfirmationLineEvents = new List<MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto>();
            foreach (var ee in e.MovementConfirmationLineEvents)
            {
                MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto eeDto = MovementConfirmationLineStateEventDtoConverter.ToMovementConfirmationLineStateEventDto(ee);
                movementConfirmationLineEvents.Add(eeDto);
            }
            dto.MovementConfirmationLineEvents = movementConfirmationLineEvents.ToArray();


            return dto;
        }


        public virtual MovementConfirmationStateDeletedDto ToMovementConfirmationStateDeletedDto(IMovementConfirmationStateDeleted e)
        {
            var dto = new MovementConfirmationStateDeletedDto();
            dto.StateEventId = new MovementConfirmationStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            var movementConfirmationLineEvents = new List<MovementConfirmationLineStateRemovedDto>();
            foreach (var ee in e.MovementConfirmationLineEvents)
            {
                MovementConfirmationLineStateRemovedDto eeDto = MovementConfirmationLineStateEventDtoConverter.ToMovementConfirmationLineStateRemovedDto(ee);
                movementConfirmationLineEvents.Add(eeDto);
            }
            dto.MovementConfirmationLineEvents = movementConfirmationLineEvents.ToArray();


            return dto;
        }

        protected virtual MovementConfirmationLineStateEventDtoConverter MovementConfirmationLineStateEventDtoConverter
        {
            get
            {
                return new MovementConfirmationLineStateEventDtoConverter();
            }
        }


    }


}
