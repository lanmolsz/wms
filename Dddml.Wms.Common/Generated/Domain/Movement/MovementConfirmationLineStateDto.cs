﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.Movement
{

    public partial class MovementConfirmationLineStateDto : IMovementConfirmationLineStateDto
    {
        public virtual string LineNumber
        {
            get;
            set;
        }

        public virtual decimal? TargetQuantity
        {
            get;
            set;
        }

        public virtual decimal? ConfirmedQuantity
        {
            get;
            set;
        }

        public virtual decimal? DifferenceQuantity
        {
            get;
            set;
        }

        public virtual decimal? ScrappedQuantity
        {
            get;
            set;
        }

        public virtual bool? Active
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }

        public virtual string MovementDocumentNumber
        {
            get;
            set;
        }

        public virtual string CreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? CreatedAt
        {
            get;
            set;
        }

        public virtual string UpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? UpdatedAt
        {
            get;
            set;
        }

        public virtual IMovementConfirmationLineState ToMovementConfirmationLineState()
        {
            var state = new MovementConfirmationLineState(true);
            state.LineNumber = this.LineNumber;
            if (this.TargetQuantity != null && this.TargetQuantity.HasValue) { state.TargetQuantity = this.TargetQuantity.Value; }
            if (this.ConfirmedQuantity != null && this.ConfirmedQuantity.HasValue) { state.ConfirmedQuantity = this.ConfirmedQuantity.Value; }
            if (this.DifferenceQuantity != null && this.DifferenceQuantity.HasValue) { state.DifferenceQuantity = this.DifferenceQuantity.Value; }
            if (this.ScrappedQuantity != null && this.ScrappedQuantity.HasValue) { state.ScrappedQuantity = this.ScrappedQuantity.Value; }
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.MovementDocumentNumber = this.MovementDocumentNumber;
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}

