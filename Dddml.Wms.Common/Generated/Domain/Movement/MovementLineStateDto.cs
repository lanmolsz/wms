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

    public partial class MovementLineStateDto : IMovementLineStateDto
    {
        public virtual string LineNumber
        {
            get;
            set;
        }

        public virtual decimal? MovementQuantity
        {
            get;
            set;
        }

        public virtual string ProductId
        {
            get;
            set;
        }

        public virtual string LocatorIdFrom
        {
            get;
            set;
        }

        public virtual string LocatorIdTo
        {
            get;
            set;
        }

        public virtual string AttributeSetInstanceIdFrom
        {
            get;
            set;
        }

        public virtual string AttributeSetInstanceIdTo
        {
            get;
            set;
        }

        public virtual bool? Processed
        {
            get;
            set;
        }

        public virtual string ReversalLineNumber
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

        public virtual IMovementLineState ToMovementLineState()
        {
            var state = new MovementLineState(true);
            state.LineNumber = this.LineNumber;
            if (this.MovementQuantity != null && this.MovementQuantity.HasValue) { state.MovementQuantity = this.MovementQuantity.Value; }
            state.ProductId = this.ProductId;
            state.LocatorIdFrom = this.LocatorIdFrom;
            state.LocatorIdTo = this.LocatorIdTo;
            state.AttributeSetInstanceIdFrom = this.AttributeSetInstanceIdFrom;
            state.AttributeSetInstanceIdTo = this.AttributeSetInstanceIdTo;
            if (this.Processed != null && this.Processed.HasValue) { state.Processed = this.Processed.Value; }
            state.ReversalLineNumber = this.ReversalLineNumber;
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

