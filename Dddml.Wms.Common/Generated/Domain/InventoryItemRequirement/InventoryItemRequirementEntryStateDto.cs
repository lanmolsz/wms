﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirement
{

    public partial class InventoryItemRequirementEntryStateDto : IInventoryItemRequirementEntryStateDto
    {
        public virtual long? EntrySeqId
        {
            get;
            set;
        }

        public virtual decimal? Quantity
        {
            get;
            set;
        }


        public virtual InventoryPRTriggeredIdDto SourceEventId
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }


        public virtual InventoryItemIdDto InventoryItemRequirementId
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

        public virtual IInventoryItemRequirementEntryState ToInventoryItemRequirementEntryState()
        {
            var state = new InventoryItemRequirementEntryState(true);
            if (this.EntrySeqId != null && this.EntrySeqId.HasValue) { state.EntrySeqId = this.EntrySeqId.Value; }
            if (this.Quantity != null && this.Quantity.HasValue) { state.Quantity = this.Quantity.Value; }
            state.SourceEventId = (this.SourceEventId == null) ? null : this.SourceEventId.ToInventoryPRTriggeredId();
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.InventoryItemRequirementId = (this.InventoryItemRequirementId == null) ? null : this.InventoryItemRequirementId.ToInventoryItemId();
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}

