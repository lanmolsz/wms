﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentPackageContentMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackageContentMvo;
using Dddml.Wms.Domain.ShipmentPackage;

namespace Dddml.Wms.Domain.ShipmentPackageContentMvo
{

	public static partial class ShipmentPackageContentMvoStateExtension
	{

        public static IShipmentPackageContentMvoCommand ToCreateOrMergePatchShipmentPackageContentMvo(this ShipmentPackageContentMvoState state)
        {
            return state.ToCreateOrMergePatchShipmentPackageContentMvo<CreateShipmentPackageContentMvo, MergePatchShipmentPackageContentMvo>();
        }

        public static DeleteShipmentPackageContentMvo ToDeleteShipmentPackageContentMvo(this ShipmentPackageContentMvoState state)
        {
            return state.ToDeleteShipmentPackageContentMvo<DeleteShipmentPackageContentMvo>();
        }

        public static MergePatchShipmentPackageContentMvo ToMergePatchShipmentPackageContentMvo(this ShipmentPackageContentMvoState state)
        {
            return state.ToMergePatchShipmentPackageContentMvo<MergePatchShipmentPackageContentMvo>();
        }

        public static CreateShipmentPackageContentMvo ToCreateShipmentPackageContentMvo(this ShipmentPackageContentMvoState state)
        {
            return state.ToCreateShipmentPackageContentMvo<CreateShipmentPackageContentMvo>();
        }
		

	}

}
