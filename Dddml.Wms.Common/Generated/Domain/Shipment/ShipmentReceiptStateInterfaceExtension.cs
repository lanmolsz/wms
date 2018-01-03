﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{

	public static partial class ShipmentReceiptStateInterfaceExtension
	{

        public static IShipmentReceiptCommand ToCreateOrMergePatchShipmentReceipt<TCreateShipmentReceipt, TMergePatchShipmentReceipt>(this IShipmentReceiptState state)
            where TCreateShipmentReceipt : ICreateShipmentReceipt, new()
            where TMergePatchShipmentReceipt : IMergePatchShipmentReceipt, new()
        {
            bool bUnsaved = ((IShipmentReceiptState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateShipmentReceipt<TCreateShipmentReceipt>();
            }
            else 
            {
                return state.ToMergePatchShipmentReceipt<TMergePatchShipmentReceipt>();
            }
        }

        public static TRemoveShipmentReceipt ToRemoveShipmentReceipt<TRemoveShipmentReceipt>(this IShipmentReceiptState state)
            where TRemoveShipmentReceipt : IRemoveShipmentReceipt, new()
        {
            var cmd = new TRemoveShipmentReceipt();
            cmd.ReceiptSeqId = state.ReceiptSeqId;
            return cmd;
        }

        public static TMergePatchShipmentReceipt ToMergePatchShipmentReceipt<TMergePatchShipmentReceipt>(this IShipmentReceiptState state)
            where TMergePatchShipmentReceipt : IMergePatchShipmentReceipt, new()
        {
            var cmd = new TMergePatchShipmentReceipt();

            cmd.ReceiptSeqId = state.ReceiptSeqId;
            cmd.ProductId = state.ProductId;
            cmd.ShipmentItemSeqId = state.ShipmentItemSeqId;
            cmd.RejectionReasonId = state.RejectionReasonId;
            cmd.DamageStatusId = state.DamageStatusId;
            cmd.DamageReasonId = state.DamageReasonId;
            cmd.ReceivedBy = state.ReceivedBy;
            cmd.DatetimeReceived = state.DatetimeReceived;
            cmd.ItemDescription = state.ItemDescription;
            cmd.AcceptedQuantity = state.AcceptedQuantity;
            cmd.RejectedQuantity = state.RejectedQuantity;
            cmd.DamagedQuantity = state.DamagedQuantity;
            cmd.Active = ((IShipmentReceiptStateProperties)state).Active;
            cmd.ShipmentId = state.ShipmentId;
            
            if (state.ProductId == null) { cmd.IsPropertyProductIdRemoved = true; }
            if (state.ShipmentItemSeqId == null) { cmd.IsPropertyShipmentItemSeqIdRemoved = true; }
            if (state.RejectionReasonId == null) { cmd.IsPropertyRejectionReasonIdRemoved = true; }
            if (state.DamageStatusId == null) { cmd.IsPropertyDamageStatusIdRemoved = true; }
            if (state.DamageReasonId == null) { cmd.IsPropertyDamageReasonIdRemoved = true; }
            if (state.ReceivedBy == null) { cmd.IsPropertyReceivedByRemoved = true; }
            if (state.DatetimeReceived == null) { cmd.IsPropertyDatetimeReceivedRemoved = true; }
            if (state.ItemDescription == null) { cmd.IsPropertyItemDescriptionRemoved = true; }
            if (state.AcceptedQuantity == null) { cmd.IsPropertyAcceptedQuantityRemoved = true; }
            if (state.RejectedQuantity == null) { cmd.IsPropertyRejectedQuantityRemoved = true; }
            if (state.DamagedQuantity == null) { cmd.IsPropertyDamagedQuantityRemoved = true; }
            return cmd;
        }

        public static TCreateShipmentReceipt ToCreateShipmentReceipt<TCreateShipmentReceipt>(this IShipmentReceiptState state)
            where TCreateShipmentReceipt : ICreateShipmentReceipt, new()
        {
            var cmd = new TCreateShipmentReceipt();

            cmd.ReceiptSeqId = state.ReceiptSeqId;
            cmd.ProductId = state.ProductId;
            cmd.ShipmentItemSeqId = state.ShipmentItemSeqId;
            cmd.RejectionReasonId = state.RejectionReasonId;
            cmd.DamageStatusId = state.DamageStatusId;
            cmd.DamageReasonId = state.DamageReasonId;
            cmd.ReceivedBy = state.ReceivedBy;
            cmd.DatetimeReceived = state.DatetimeReceived;
            cmd.ItemDescription = state.ItemDescription;
            cmd.AcceptedQuantity = state.AcceptedQuantity;
            cmd.RejectedQuantity = state.RejectedQuantity;
            cmd.DamagedQuantity = state.DamagedQuantity;
            cmd.Active = ((IShipmentReceiptStateProperties)state).Active;
            cmd.ShipmentId = state.ShipmentId;
            return cmd;
        }
		

	}

}

