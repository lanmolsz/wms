﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItemMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentItemMvo
{

	public static partial class ShipmentItemMvoStateInterfaceExtension
	{

        public static IShipmentItemMvoCommand ToCreateOrMergePatchShipmentItemMvo<TCreateShipmentItemMvo, TMergePatchShipmentItemMvo>(this IShipmentItemMvoState state)
            where TCreateShipmentItemMvo : ICreateShipmentItemMvo, new()
            where TMergePatchShipmentItemMvo : IMergePatchShipmentItemMvo, new()
        {
            bool bUnsaved = ((IShipmentItemMvoState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateShipmentItemMvo<TCreateShipmentItemMvo>();
            }
            else 
            {
                return state.ToMergePatchShipmentItemMvo<TMergePatchShipmentItemMvo>();
            }
        }

        public static TDeleteShipmentItemMvo ToDeleteShipmentItemMvo<TDeleteShipmentItemMvo>(this IShipmentItemMvoState state)
            where TDeleteShipmentItemMvo : IDeleteShipmentItemMvo, new()
        {
            var cmd = new TDeleteShipmentItemMvo();
            cmd.ShipmentItemId = state.ShipmentItemId;
            cmd.ShipmentVersion = ((IShipmentItemMvoStateProperties)state).ShipmentVersion;

            return cmd;
        }

        public static TMergePatchShipmentItemMvo ToMergePatchShipmentItemMvo<TMergePatchShipmentItemMvo>(this IShipmentItemMvoState state)
            where TMergePatchShipmentItemMvo : IMergePatchShipmentItemMvo, new()
        {
            var cmd = new TMergePatchShipmentItemMvo();

            cmd.ShipmentVersion = ((IShipmentItemMvoStateProperties)state).ShipmentVersion;

            cmd.ShipmentItemId = state.ShipmentItemId;
            cmd.ProductId = state.ProductId;
            cmd.AttributeSetInstanceId = state.AttributeSetInstanceId;
            cmd.Quantity = state.Quantity;
            cmd.ShipmentContentDescription = state.ShipmentContentDescription;
            cmd.Version = ((IShipmentItemMvoStateProperties)state).Version;
            cmd.Active = ((IShipmentItemMvoStateProperties)state).Active;
            cmd.ShipmentShipmentTypeId = state.ShipmentShipmentTypeId;
            cmd.ShipmentStatusId = state.ShipmentStatusId;
            cmd.ShipmentPrimaryOrderId = state.ShipmentPrimaryOrderId;
            cmd.ShipmentPrimaryReturnId = state.ShipmentPrimaryReturnId;
            cmd.ShipmentPrimaryShipGroupSeqId = state.ShipmentPrimaryShipGroupSeqId;
            cmd.ShipmentPicklistBinId = state.ShipmentPicklistBinId;
            cmd.ShipmentEstimatedReadyDate = state.ShipmentEstimatedReadyDate;
            cmd.ShipmentEstimatedShipDate = state.ShipmentEstimatedShipDate;
            cmd.ShipmentEstimatedShipWorkEffId = state.ShipmentEstimatedShipWorkEffId;
            cmd.ShipmentEstimatedArrivalDate = state.ShipmentEstimatedArrivalDate;
            cmd.ShipmentEstimatedArrivalWorkEffId = state.ShipmentEstimatedArrivalWorkEffId;
            cmd.ShipmentLatestCancelDate = state.ShipmentLatestCancelDate;
            cmd.ShipmentEstimatedShipCost = state.ShipmentEstimatedShipCost;
            cmd.ShipmentCurrencyUomId = state.ShipmentCurrencyUomId;
            cmd.ShipmentHandlingInstructions = state.ShipmentHandlingInstructions;
            cmd.ShipmentOriginFacilityId = state.ShipmentOriginFacilityId;
            cmd.ShipmentDestinationFacilityId = state.ShipmentDestinationFacilityId;
            cmd.ShipmentOriginContactMechId = state.ShipmentOriginContactMechId;
            cmd.ShipmentOriginTelecomNumberId = state.ShipmentOriginTelecomNumberId;
            cmd.ShipmentDestinationContactMechId = state.ShipmentDestinationContactMechId;
            cmd.ShipmentDestinationTelecomNumberId = state.ShipmentDestinationTelecomNumberId;
            cmd.ShipmentPartyIdTo = state.ShipmentPartyIdTo;
            cmd.ShipmentPartyIdFrom = state.ShipmentPartyIdFrom;
            cmd.ShipmentAdditionalShippingCharge = state.ShipmentAdditionalShippingCharge;
            cmd.ShipmentAddtlShippingChargeDesc = state.ShipmentAddtlShippingChargeDesc;
            cmd.ShipmentCreatedBy = state.ShipmentCreatedBy;
            cmd.ShipmentCreatedAt = state.ShipmentCreatedAt;
            cmd.ShipmentUpdatedBy = state.ShipmentUpdatedBy;
            cmd.ShipmentUpdatedAt = state.ShipmentUpdatedAt;
            cmd.ShipmentActive = state.ShipmentActive;
            
            if (state.ProductId == null) { cmd.IsPropertyProductIdRemoved = true; }
            if (state.AttributeSetInstanceId == null) { cmd.IsPropertyAttributeSetInstanceIdRemoved = true; }
            if (state.Quantity == null) { cmd.IsPropertyQuantityRemoved = true; }
            if (state.ShipmentContentDescription == null) { cmd.IsPropertyShipmentContentDescriptionRemoved = true; }
            if (state.ShipmentShipmentTypeId == null) { cmd.IsPropertyShipmentShipmentTypeIdRemoved = true; }
            if (state.ShipmentStatusId == null) { cmd.IsPropertyShipmentStatusIdRemoved = true; }
            if (state.ShipmentPrimaryOrderId == null) { cmd.IsPropertyShipmentPrimaryOrderIdRemoved = true; }
            if (state.ShipmentPrimaryReturnId == null) { cmd.IsPropertyShipmentPrimaryReturnIdRemoved = true; }
            if (state.ShipmentPrimaryShipGroupSeqId == null) { cmd.IsPropertyShipmentPrimaryShipGroupSeqIdRemoved = true; }
            if (state.ShipmentPicklistBinId == null) { cmd.IsPropertyShipmentPicklistBinIdRemoved = true; }
            if (state.ShipmentEstimatedReadyDate == null) { cmd.IsPropertyShipmentEstimatedReadyDateRemoved = true; }
            if (state.ShipmentEstimatedShipDate == null) { cmd.IsPropertyShipmentEstimatedShipDateRemoved = true; }
            if (state.ShipmentEstimatedShipWorkEffId == null) { cmd.IsPropertyShipmentEstimatedShipWorkEffIdRemoved = true; }
            if (state.ShipmentEstimatedArrivalDate == null) { cmd.IsPropertyShipmentEstimatedArrivalDateRemoved = true; }
            if (state.ShipmentEstimatedArrivalWorkEffId == null) { cmd.IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved = true; }
            if (state.ShipmentLatestCancelDate == null) { cmd.IsPropertyShipmentLatestCancelDateRemoved = true; }
            if (state.ShipmentEstimatedShipCost == null) { cmd.IsPropertyShipmentEstimatedShipCostRemoved = true; }
            if (state.ShipmentCurrencyUomId == null) { cmd.IsPropertyShipmentCurrencyUomIdRemoved = true; }
            if (state.ShipmentHandlingInstructions == null) { cmd.IsPropertyShipmentHandlingInstructionsRemoved = true; }
            if (state.ShipmentOriginFacilityId == null) { cmd.IsPropertyShipmentOriginFacilityIdRemoved = true; }
            if (state.ShipmentDestinationFacilityId == null) { cmd.IsPropertyShipmentDestinationFacilityIdRemoved = true; }
            if (state.ShipmentOriginContactMechId == null) { cmd.IsPropertyShipmentOriginContactMechIdRemoved = true; }
            if (state.ShipmentOriginTelecomNumberId == null) { cmd.IsPropertyShipmentOriginTelecomNumberIdRemoved = true; }
            if (state.ShipmentDestinationContactMechId == null) { cmd.IsPropertyShipmentDestinationContactMechIdRemoved = true; }
            if (state.ShipmentDestinationTelecomNumberId == null) { cmd.IsPropertyShipmentDestinationTelecomNumberIdRemoved = true; }
            if (state.ShipmentPartyIdTo == null) { cmd.IsPropertyShipmentPartyIdToRemoved = true; }
            if (state.ShipmentPartyIdFrom == null) { cmd.IsPropertyShipmentPartyIdFromRemoved = true; }
            if (state.ShipmentAdditionalShippingCharge == null) { cmd.IsPropertyShipmentAdditionalShippingChargeRemoved = true; }
            if (state.ShipmentAddtlShippingChargeDesc == null) { cmd.IsPropertyShipmentAddtlShippingChargeDescRemoved = true; }
            if (state.ShipmentCreatedBy == null) { cmd.IsPropertyShipmentCreatedByRemoved = true; }
            if (state.ShipmentUpdatedBy == null) { cmd.IsPropertyShipmentUpdatedByRemoved = true; }
            return cmd;
        }

        public static TCreateShipmentItemMvo ToCreateShipmentItemMvo<TCreateShipmentItemMvo>(this IShipmentItemMvoState state)
            where TCreateShipmentItemMvo : ICreateShipmentItemMvo, new()
        {
            var cmd = new TCreateShipmentItemMvo();

            cmd.ShipmentVersion = ((IShipmentItemMvoStateProperties)state).ShipmentVersion;

            cmd.ShipmentItemId = state.ShipmentItemId;
            cmd.ProductId = state.ProductId;
            cmd.AttributeSetInstanceId = state.AttributeSetInstanceId;
            cmd.Quantity = state.Quantity;
            cmd.ShipmentContentDescription = state.ShipmentContentDescription;
            cmd.Version = ((IShipmentItemMvoStateProperties)state).Version;
            cmd.Active = ((IShipmentItemMvoStateProperties)state).Active;
            cmd.ShipmentShipmentTypeId = state.ShipmentShipmentTypeId;
            cmd.ShipmentStatusId = state.ShipmentStatusId;
            cmd.ShipmentPrimaryOrderId = state.ShipmentPrimaryOrderId;
            cmd.ShipmentPrimaryReturnId = state.ShipmentPrimaryReturnId;
            cmd.ShipmentPrimaryShipGroupSeqId = state.ShipmentPrimaryShipGroupSeqId;
            cmd.ShipmentPicklistBinId = state.ShipmentPicklistBinId;
            cmd.ShipmentEstimatedReadyDate = state.ShipmentEstimatedReadyDate;
            cmd.ShipmentEstimatedShipDate = state.ShipmentEstimatedShipDate;
            cmd.ShipmentEstimatedShipWorkEffId = state.ShipmentEstimatedShipWorkEffId;
            cmd.ShipmentEstimatedArrivalDate = state.ShipmentEstimatedArrivalDate;
            cmd.ShipmentEstimatedArrivalWorkEffId = state.ShipmentEstimatedArrivalWorkEffId;
            cmd.ShipmentLatestCancelDate = state.ShipmentLatestCancelDate;
            cmd.ShipmentEstimatedShipCost = state.ShipmentEstimatedShipCost;
            cmd.ShipmentCurrencyUomId = state.ShipmentCurrencyUomId;
            cmd.ShipmentHandlingInstructions = state.ShipmentHandlingInstructions;
            cmd.ShipmentOriginFacilityId = state.ShipmentOriginFacilityId;
            cmd.ShipmentDestinationFacilityId = state.ShipmentDestinationFacilityId;
            cmd.ShipmentOriginContactMechId = state.ShipmentOriginContactMechId;
            cmd.ShipmentOriginTelecomNumberId = state.ShipmentOriginTelecomNumberId;
            cmd.ShipmentDestinationContactMechId = state.ShipmentDestinationContactMechId;
            cmd.ShipmentDestinationTelecomNumberId = state.ShipmentDestinationTelecomNumberId;
            cmd.ShipmentPartyIdTo = state.ShipmentPartyIdTo;
            cmd.ShipmentPartyIdFrom = state.ShipmentPartyIdFrom;
            cmd.ShipmentAdditionalShippingCharge = state.ShipmentAdditionalShippingCharge;
            cmd.ShipmentAddtlShippingChargeDesc = state.ShipmentAddtlShippingChargeDesc;
            cmd.ShipmentCreatedBy = state.ShipmentCreatedBy;
            cmd.ShipmentCreatedAt = state.ShipmentCreatedAt;
            cmd.ShipmentUpdatedBy = state.ShipmentUpdatedBy;
            cmd.ShipmentUpdatedAt = state.ShipmentUpdatedAt;
            cmd.ShipmentActive = state.ShipmentActive;
            return cmd;
        }
		

	}

}

