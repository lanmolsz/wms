﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmationLineMvo;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmationLineMvo
{

	public abstract class MovementConfirmationLineMvoStateProperties : IMovementConfirmationLineMvoStateProperties
	{
		public virtual MovementConfirmationLineId MovementConfirmationLineId { get; set; }

		public virtual string MovementLineNumber { get; set; }

		public virtual decimal TargetQuantity { get; set; }

		public virtual decimal ConfirmedQuantity { get; set; }

		public virtual decimal DifferenceQuantity { get; set; }

		public virtual decimal ScrappedQuantity { get; set; }

		public virtual string Description { get; set; }

		public virtual bool Processed { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

		public virtual string MovementConfirmationDocumentTypeId { get; set; }

		public virtual string MovementConfirmationDocumentStatusId { get; set; }

		public virtual string MovementConfirmationMovementDocumentNumber { get; set; }

		public virtual bool MovementConfirmationIsApproved { get; set; }

		public virtual decimal MovementConfirmationApprovalAmount { get; set; }

		public virtual string MovementConfirmationProcessing { get; set; }

		public virtual bool MovementConfirmationProcessed { get; set; }

		public virtual string MovementConfirmationDescription { get; set; }

		public virtual long MovementConfirmationVersion { get; set; }

		public virtual string MovementConfirmationCreatedBy { get; set; }

		public virtual DateTime MovementConfirmationCreatedAt { get; set; }

		public virtual string MovementConfirmationUpdatedBy { get; set; }

		public virtual DateTime MovementConfirmationUpdatedAt { get; set; }

		public virtual bool MovementConfirmationActive { get; set; }

		public virtual bool MovementConfirmationDeleted { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
