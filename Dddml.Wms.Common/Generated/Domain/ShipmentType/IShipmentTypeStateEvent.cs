﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentType;

namespace Dddml.Wms.Domain.ShipmentType
{
	public interface IShipmentTypeStateEvent : IEvent, IStateEventDto, IGlobalIdentity<ShipmentTypeEventId>, ICreated<string>
	{
		ShipmentTypeEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string ParentTypeId { get; set; }

		string HasTable { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }

	}

	public interface IShipmentTypeStateCreated : IShipmentTypeStateEvent//, IShipmentTypeStateProperties
	{
	
	}


	public interface IShipmentTypeStateMergePatched : IShipmentTypeStateEvent//, IShipmentTypeStateProperties
	{
		bool IsPropertyParentTypeIdRemoved { get; set; }

		bool IsPropertyHasTableRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}


}

