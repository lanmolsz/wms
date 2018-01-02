﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLotDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Lot;

namespace Dddml.Wms.Domain.Lot
{
	public interface ILotStateEvent : IEvent, IStateEventDto, IGlobalIdentity<LotStateEventId>, ICreated<string>
	{
		LotStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		DateTime? CreationDate { get; set; }

		decimal? Quantity { get; set; }

		DateTime? ExpirationDate { get; set; }

		bool? Active { get; set; }

	}

	public interface ILotStateCreated : ILotStateEvent//, ILotStateProperties
	{
	
	}


	public interface ILotStateMergePatched : ILotStateEvent//, ILotStateProperties
	{
		bool IsPropertyCreationDateRemoved { get; set; }

		bool IsPropertyQuantityRemoved { get; set; }

		bool IsPropertyExpirationDateRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface ILotStateDeleted : ILotStateEvent
	{
	}


}
