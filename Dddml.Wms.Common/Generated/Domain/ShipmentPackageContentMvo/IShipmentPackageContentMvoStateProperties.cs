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

	public interface IShipmentPackageContentMvoStateProperties
	{
		ShipmentPackageContentId ShipmentPackageContentId { get; set; }

		decimal? Quantity { get; set; }

		string SubProductId { get; set; }

		decimal? SubProductQuantity { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

		string ShipmentPackageShipmentBoxTypeId { get; set; }

		DateTime? ShipmentPackageDateCreated { get; set; }

		decimal? ShipmentPackageBoxLength { get; set; }

		decimal? ShipmentPackageBoxHeight { get; set; }

		decimal? ShipmentPackageBoxWidth { get; set; }

		string ShipmentPackageDimensionUomId { get; set; }

		decimal? ShipmentPackageWeight { get; set; }

		string ShipmentPackageWeightUomId { get; set; }

		decimal? ShipmentPackageInsuredValue { get; set; }

		long ShipmentPackageVersion { get; set; }

		string ShipmentPackageCreatedBy { get; set; }

		DateTime ShipmentPackageCreatedAt { get; set; }

		string ShipmentPackageUpdatedBy { get; set; }

		DateTime ShipmentPackageUpdatedAt { get; set; }

		bool ShipmentPackageActive { get; set; }

		bool ShipmentPackageDeleted { get; set; }

	}

}