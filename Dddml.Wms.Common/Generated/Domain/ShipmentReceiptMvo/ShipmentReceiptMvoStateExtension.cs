﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentReceiptMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentReceiptMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentReceiptMvo
{

	public static partial class ShipmentReceiptMvoStateExtension
	{

        public static IShipmentReceiptMvoCommand ToCreateOrMergePatchShipmentReceiptMvo(this ShipmentReceiptMvoState state)
        {
            return state.ToCreateOrMergePatchShipmentReceiptMvo<CreateShipmentReceiptMvo, MergePatchShipmentReceiptMvo>();
        }

        public static DeleteShipmentReceiptMvo ToDeleteShipmentReceiptMvo(this ShipmentReceiptMvoState state)
        {
            return state.ToDeleteShipmentReceiptMvo<DeleteShipmentReceiptMvo>();
        }

        public static MergePatchShipmentReceiptMvo ToMergePatchShipmentReceiptMvo(this ShipmentReceiptMvoState state)
        {
            return state.ToMergePatchShipmentReceiptMvo<MergePatchShipmentReceiptMvo>();
        }

        public static CreateShipmentReceiptMvo ToCreateShipmentReceiptMvo(this ShipmentReceiptMvoState state)
        {
            return state.ToCreateShipmentReceiptMvo<CreateShipmentReceiptMvo>();
        }
		

	}

}

