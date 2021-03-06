﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGrpInvReservationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGrpInvReservation;

namespace Dddml.Wms.Domain.OrderItemShipGrpInvReservation
{

	public abstract class OrderItemShipGrpInvReservationStateProperties : IOrderItemShipGrpInvReservationStateProperties
	{
		public virtual OrderItemShipGrpInvResId OrderItemShipGrpInvResId { get; set; }

		public virtual string ReserveOrderEnumId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual decimal? QuantityNotAvailable { get; set; }

		public virtual DateTime? ReservedDatetime { get; set; }

		public virtual DateTime? CreatedDatetime { get; set; }

		public virtual DateTime? PromisedDatetime { get; set; }

		public virtual DateTime? CurrentPromisedDate { get; set; }

		public virtual string Priority { get; set; }

		public virtual long? SequenceId { get; set; }

		public virtual DateTime? OldPickStartDate { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
