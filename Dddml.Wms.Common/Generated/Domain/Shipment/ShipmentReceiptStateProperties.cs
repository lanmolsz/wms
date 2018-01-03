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

	public abstract class ShipmentReceiptStateProperties : IShipmentReceiptStateProperties
	{
		public virtual string ReceiptSeqId { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string ShipmentItemSeqId { get; set; }

		public virtual string RejectionReasonId { get; set; }

		public virtual string DamageStatusId { get; set; }

		public virtual string DamageReasonId { get; set; }

		public virtual string ReceivedBy { get; set; }

		public virtual DateTime? DatetimeReceived { get; set; }

		public virtual string ItemDescription { get; set; }

		public virtual decimal? AcceptedQuantity { get; set; }

		public virtual decimal? RejectedQuantity { get; set; }

		public virtual decimal? DamagedQuantity { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

		// Outer Id:

		public virtual string ShipmentId { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
