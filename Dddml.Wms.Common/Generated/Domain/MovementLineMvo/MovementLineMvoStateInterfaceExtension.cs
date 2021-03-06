﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementLineMvo;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.MovementLineMvo
{

	public static partial class MovementLineMvoStateInterfaceExtension
	{

        public static IMovementLineMvoCommand ToCreateOrMergePatchMovementLineMvo<TCreateMovementLineMvo, TMergePatchMovementLineMvo>(this IMovementLineMvoState state)
            where TCreateMovementLineMvo : ICreateMovementLineMvo, new()
            where TMergePatchMovementLineMvo : IMergePatchMovementLineMvo, new()
        {
            bool bUnsaved = ((IMovementLineMvoState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateMovementLineMvo<TCreateMovementLineMvo>();
            }
            else 
            {
                return state.ToMergePatchMovementLineMvo<TMergePatchMovementLineMvo>();
            }
        }

        public static TDeleteMovementLineMvo ToDeleteMovementLineMvo<TDeleteMovementLineMvo>(this IMovementLineMvoState state)
            where TDeleteMovementLineMvo : IDeleteMovementLineMvo, new()
        {
            var cmd = new TDeleteMovementLineMvo();
            cmd.MovementLineId = state.MovementLineId;
            cmd.MovementVersion = ((IMovementLineMvoStateProperties)state).MovementVersion;

            return cmd;
        }

        public static TMergePatchMovementLineMvo ToMergePatchMovementLineMvo<TMergePatchMovementLineMvo>(this IMovementLineMvoState state)
            where TMergePatchMovementLineMvo : IMergePatchMovementLineMvo, new()
        {
            var cmd = new TMergePatchMovementLineMvo();

            cmd.MovementVersion = ((IMovementLineMvoStateProperties)state).MovementVersion;

            cmd.MovementLineId = state.MovementLineId;
            cmd.MovementQuantity = state.MovementQuantity;
            cmd.ProductId = state.ProductId;
            cmd.LocatorIdFrom = state.LocatorIdFrom;
            cmd.LocatorIdTo = state.LocatorIdTo;
            cmd.AttributeSetInstanceId = state.AttributeSetInstanceId;
            cmd.Processed = state.Processed;
            cmd.ReversalLineNumber = state.ReversalLineNumber;
            cmd.Version = ((IMovementLineMvoStateProperties)state).Version;
            cmd.Active = ((IMovementLineMvoStateProperties)state).Active;
            cmd.MovementDocumentStatusId = state.MovementDocumentStatusId;
            cmd.MovementMovementDate = state.MovementMovementDate;
            cmd.MovementPosted = state.MovementPosted;
            cmd.MovementProcessed = state.MovementProcessed;
            cmd.MovementProcessing = state.MovementProcessing;
            cmd.MovementDateReceived = state.MovementDateReceived;
            cmd.MovementDocumentTypeId = state.MovementDocumentTypeId;
            cmd.MovementIsInTransit = state.MovementIsInTransit;
            cmd.MovementIsApproved = state.MovementIsApproved;
            cmd.MovementApprovalAmount = state.MovementApprovalAmount;
            cmd.MovementShipperId = state.MovementShipperId;
            cmd.MovementSalesRepresentativeId = state.MovementSalesRepresentativeId;
            cmd.MovementBusinessPartnerId = state.MovementBusinessPartnerId;
            cmd.MovementChargeAmount = state.MovementChargeAmount;
            cmd.MovementCreateFrom = state.MovementCreateFrom;
            cmd.MovementFreightAmount = state.MovementFreightAmount;
            cmd.MovementReversalDocumentNumber = state.MovementReversalDocumentNumber;
            cmd.MovementWarehouseIdFrom = state.MovementWarehouseIdFrom;
            cmd.MovementWarehouseIdTo = state.MovementWarehouseIdTo;
            cmd.MovementDescription = state.MovementDescription;
            cmd.MovementCreatedBy = state.MovementCreatedBy;
            cmd.MovementCreatedAt = state.MovementCreatedAt;
            cmd.MovementUpdatedBy = state.MovementUpdatedBy;
            cmd.MovementUpdatedAt = state.MovementUpdatedAt;
            cmd.MovementActive = state.MovementActive;
            cmd.MovementDeleted = state.MovementDeleted;
            
            if (state.ProductId == null) { cmd.IsPropertyProductIdRemoved = true; }
            if (state.LocatorIdFrom == null) { cmd.IsPropertyLocatorIdFromRemoved = true; }
            if (state.LocatorIdTo == null) { cmd.IsPropertyLocatorIdToRemoved = true; }
            if (state.AttributeSetInstanceId == null) { cmd.IsPropertyAttributeSetInstanceIdRemoved = true; }
            if (state.ReversalLineNumber == null) { cmd.IsPropertyReversalLineNumberRemoved = true; }
            if (state.MovementDocumentStatusId == null) { cmd.IsPropertyMovementDocumentStatusIdRemoved = true; }
            if (state.MovementProcessing == null) { cmd.IsPropertyMovementProcessingRemoved = true; }
            if (state.MovementDocumentTypeId == null) { cmd.IsPropertyMovementDocumentTypeIdRemoved = true; }
            if (state.MovementShipperId == null) { cmd.IsPropertyMovementShipperIdRemoved = true; }
            if (state.MovementSalesRepresentativeId == null) { cmd.IsPropertyMovementSalesRepresentativeIdRemoved = true; }
            if (state.MovementBusinessPartnerId == null) { cmd.IsPropertyMovementBusinessPartnerIdRemoved = true; }
            if (state.MovementCreateFrom == null) { cmd.IsPropertyMovementCreateFromRemoved = true; }
            if (state.MovementReversalDocumentNumber == null) { cmd.IsPropertyMovementReversalDocumentNumberRemoved = true; }
            if (state.MovementWarehouseIdFrom == null) { cmd.IsPropertyMovementWarehouseIdFromRemoved = true; }
            if (state.MovementWarehouseIdTo == null) { cmd.IsPropertyMovementWarehouseIdToRemoved = true; }
            if (state.MovementDescription == null) { cmd.IsPropertyMovementDescriptionRemoved = true; }
            if (state.MovementCreatedBy == null) { cmd.IsPropertyMovementCreatedByRemoved = true; }
            if (state.MovementUpdatedBy == null) { cmd.IsPropertyMovementUpdatedByRemoved = true; }
            return cmd;
        }

        public static TCreateMovementLineMvo ToCreateMovementLineMvo<TCreateMovementLineMvo>(this IMovementLineMvoState state)
            where TCreateMovementLineMvo : ICreateMovementLineMvo, new()
        {
            var cmd = new TCreateMovementLineMvo();

            cmd.MovementVersion = ((IMovementLineMvoStateProperties)state).MovementVersion;

            cmd.MovementLineId = state.MovementLineId;
            cmd.MovementQuantity = state.MovementQuantity;
            cmd.ProductId = state.ProductId;
            cmd.LocatorIdFrom = state.LocatorIdFrom;
            cmd.LocatorIdTo = state.LocatorIdTo;
            cmd.AttributeSetInstanceId = state.AttributeSetInstanceId;
            cmd.Processed = state.Processed;
            cmd.ReversalLineNumber = state.ReversalLineNumber;
            cmd.Version = ((IMovementLineMvoStateProperties)state).Version;
            cmd.Active = ((IMovementLineMvoStateProperties)state).Active;
            cmd.MovementDocumentStatusId = state.MovementDocumentStatusId;
            cmd.MovementMovementDate = state.MovementMovementDate;
            cmd.MovementPosted = state.MovementPosted;
            cmd.MovementProcessed = state.MovementProcessed;
            cmd.MovementProcessing = state.MovementProcessing;
            cmd.MovementDateReceived = state.MovementDateReceived;
            cmd.MovementDocumentTypeId = state.MovementDocumentTypeId;
            cmd.MovementIsInTransit = state.MovementIsInTransit;
            cmd.MovementIsApproved = state.MovementIsApproved;
            cmd.MovementApprovalAmount = state.MovementApprovalAmount;
            cmd.MovementShipperId = state.MovementShipperId;
            cmd.MovementSalesRepresentativeId = state.MovementSalesRepresentativeId;
            cmd.MovementBusinessPartnerId = state.MovementBusinessPartnerId;
            cmd.MovementChargeAmount = state.MovementChargeAmount;
            cmd.MovementCreateFrom = state.MovementCreateFrom;
            cmd.MovementFreightAmount = state.MovementFreightAmount;
            cmd.MovementReversalDocumentNumber = state.MovementReversalDocumentNumber;
            cmd.MovementWarehouseIdFrom = state.MovementWarehouseIdFrom;
            cmd.MovementWarehouseIdTo = state.MovementWarehouseIdTo;
            cmd.MovementDescription = state.MovementDescription;
            cmd.MovementCreatedBy = state.MovementCreatedBy;
            cmd.MovementCreatedAt = state.MovementCreatedAt;
            cmd.MovementUpdatedBy = state.MovementUpdatedBy;
            cmd.MovementUpdatedAt = state.MovementUpdatedAt;
            cmd.MovementActive = state.MovementActive;
            cmd.MovementDeleted = state.MovementDeleted;
            return cmd;
        }
		

	}

}

