﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

    public partial class InOutLineStateDto : IInOutLineStateDto
    {
        public virtual string LineNumber
        {
            get;
            set;
        }

        public virtual string LocatorId
        {
            get;
            set;
        }

        public virtual string ProductId
        {
            get;
            set;
        }

        public virtual string AttributeSetInstanceId
        {
            get;
            set;
        }

        public virtual string Description
        {
            get;
            set;
        }

        public virtual string QuantityUomId
        {
            get;
            set;
        }

        public virtual decimal? MovementQuantity
        {
            get;
            set;
        }

        public virtual decimal? PickedQuantity
        {
            get;
            set;
        }

        public virtual bool? IsInvoiced
        {
            get;
            set;
        }

        public virtual bool? Processed
        {
            get;
            set;
        }

        public virtual string RmaLineNumber
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

        public virtual string InOutDocumentNumber
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

        public virtual IInOutLineState ToInOutLineState()
        {
            var state = new InOutLineState(true);
            state.LineNumber = this.LineNumber;
            state.LocatorId = this.LocatorId;
            state.ProductId = this.ProductId;
            state.AttributeSetInstanceId = this.AttributeSetInstanceId;
            state.Description = this.Description;
            state.QuantityUomId = this.QuantityUomId;
            if (this.MovementQuantity != null && this.MovementQuantity.HasValue) { state.MovementQuantity = this.MovementQuantity.Value; }
            if (this.PickedQuantity != null && this.PickedQuantity.HasValue) { state.PickedQuantity = this.PickedQuantity.Value; }
            if (this.IsInvoiced != null && this.IsInvoiced.HasValue) { state.IsInvoiced = this.IsInvoiced.Value; }
            if (this.Processed != null && this.Processed.HasValue) { state.Processed = this.Processed.Value; }
            state.RmaLineNumber = this.RmaLineNumber;
            state.ReversalLineNumber = this.ReversalLineNumber;
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.InOutDocumentNumber = this.InOutDocumentNumber;
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}

