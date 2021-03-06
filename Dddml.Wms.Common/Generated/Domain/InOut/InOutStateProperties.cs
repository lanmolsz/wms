﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

	public abstract class InOutStateProperties : IInOutStateProperties
	{
		public virtual string DocumentNumber { get; set; }

		public virtual string DocumentStatusId { get; set; }

		public virtual bool Posted { get; set; }

		public virtual bool Processed { get; set; }

		public virtual string Processing { get; set; }

		public virtual string DocumentTypeId { get; set; }

		public virtual string Description { get; set; }

		public virtual string OrderId { get; set; }

		public virtual DateTime? DateOrdered { get; set; }

		public virtual bool IsPrinted { get; set; }

		public virtual string MovementTypeId { get; set; }

		public virtual DateTime? MovementDate { get; set; }

		public virtual string BusinessPartnerId { get; set; }

		public virtual string WarehouseId { get; set; }

		public virtual string POReference { get; set; }

		public virtual decimal FreightAmount { get; set; }

		public virtual string ShipperId { get; set; }

		public virtual decimal ChargeAmount { get; set; }

		public virtual DateTime? DatePrinted { get; set; }

		public virtual string CreatedFrom { get; set; }

		public virtual string SalesRepresentativeId { get; set; }

		public virtual int NumberOfPackages { get; set; }

		public virtual DateTime? PickDate { get; set; }

		public virtual DateTime? ShipDate { get; set; }

		public virtual string TrackingNumber { get; set; }

		public virtual DateTime? DateReceived { get; set; }

		public virtual bool IsInTransit { get; set; }

		public virtual bool IsApproved { get; set; }

		public virtual bool IsInDispute { get; set; }

		public virtual string RmaDocumentNumber { get; set; }

		public virtual string ReversalDocumentNumber { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
