﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirementEntryMvo;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirementEntryMvo
{

    public partial class InventoryItemRequirementEntryMvoStateDto : IInventoryItemRequirementEntryMvoStateDto
    {
        public virtual InventoryItemRequirementEntryId InventoryItemRequirementEntryId
        {
            get;
            set;
        }

        public virtual decimal? Quantity
        {
            get;
            set;
        }

        public virtual InventoryPRTriggeredId SourceEventId
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }

        public virtual decimal? InventoryItemRequirementQuantity
        {
            get;
            set;
        }

        public virtual string InventoryItemRequirementCreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? InventoryItemRequirementCreatedAt
        {
            get;
            set;
        }

        public virtual string InventoryItemRequirementUpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? InventoryItemRequirementUpdatedAt
        {
            get;
            set;
        }

        public virtual long? InventoryItemRequirementVersion
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

        public virtual IInventoryItemRequirementEntryMvoState ToInventoryItemRequirementEntryMvoState()
        {
            var state = new InventoryItemRequirementEntryMvoState(true);
            state.InventoryItemRequirementEntryId = this.InventoryItemRequirementEntryId;
            if (this.Quantity != null && this.Quantity.HasValue) { state.Quantity = this.Quantity.Value; }
            state.SourceEventId = this.SourceEventId;
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            if (this.InventoryItemRequirementQuantity != null && this.InventoryItemRequirementQuantity.HasValue) { state.InventoryItemRequirementQuantity = this.InventoryItemRequirementQuantity.Value; }
            state.InventoryItemRequirementCreatedBy = this.InventoryItemRequirementCreatedBy;
            if (this.InventoryItemRequirementCreatedAt != null && this.InventoryItemRequirementCreatedAt.HasValue) { state.InventoryItemRequirementCreatedAt = this.InventoryItemRequirementCreatedAt.Value; }
            state.InventoryItemRequirementUpdatedBy = this.InventoryItemRequirementUpdatedBy;
            if (this.InventoryItemRequirementUpdatedAt != null && this.InventoryItemRequirementUpdatedAt.HasValue) { state.InventoryItemRequirementUpdatedAt = this.InventoryItemRequirementUpdatedAt.Value; }
            if (this.InventoryItemRequirementVersion != null && this.InventoryItemRequirementVersion.HasValue) { state.InventoryItemRequirementVersion = this.InventoryItemRequirementVersion.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}

