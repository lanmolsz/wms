﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEntryMvo;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItemEntryMvo
{

    public partial class InventoryItemEntryMvoStateDto : IInventoryItemEntryMvoStateDto
    {

        public virtual InventoryItemEntryIdDto InventoryItemEntryId
        {
            get;
            set;
        }

        public virtual decimal? QuantityOnHand
        {
            get;
            set;
        }

        public virtual decimal? QuantityReserved
        {
            get;
            set;
        }

        public virtual decimal? QuantityOccupied
        {
            get;
            set;
        }

        public virtual decimal? QuantityVirtual
        {
            get;
            set;
        }


        public virtual InventoryItemSourceVODto Source
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }

        public virtual bool? Active
        {
            get;
            set;
        }

        public virtual decimal? InventoryItemQuantityOnHand
        {
            get;
            set;
        }

        public virtual decimal? InventoryItemQuantityReserved
        {
            get;
            set;
        }

        public virtual decimal? InventoryItemQuantityOccupied
        {
            get;
            set;
        }

        public virtual decimal? InventoryItemQuantityVirtual
        {
            get;
            set;
        }

        public virtual string InventoryItemCreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? InventoryItemCreatedAt
        {
            get;
            set;
        }

        public virtual string InventoryItemUpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? InventoryItemUpdatedAt
        {
            get;
            set;
        }

        public virtual long? InventoryItemVersion
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

        public virtual IInventoryItemEntryMvoState ToInventoryItemEntryMvoState()
        {
            var state = new InventoryItemEntryMvoState(true);
            state.InventoryItemEntryId = (this.InventoryItemEntryId == null) ? null : this.InventoryItemEntryId.ToInventoryItemEntryId();
            if (this.QuantityOnHand != null && this.QuantityOnHand.HasValue) { state.QuantityOnHand = this.QuantityOnHand.Value; }
            if (this.QuantityReserved != null && this.QuantityReserved.HasValue) { state.QuantityReserved = this.QuantityReserved.Value; }
            if (this.QuantityOccupied != null && this.QuantityOccupied.HasValue) { state.QuantityOccupied = this.QuantityOccupied.Value; }
            if (this.QuantityVirtual != null && this.QuantityVirtual.HasValue) { state.QuantityVirtual = this.QuantityVirtual.Value; }
            state.Source = (this.Source == null) ? null : this.Source.ToInventoryItemSourceVO();
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.InventoryItemQuantityOnHand != null && this.InventoryItemQuantityOnHand.HasValue) { state.InventoryItemQuantityOnHand = this.InventoryItemQuantityOnHand.Value; }
            if (this.InventoryItemQuantityReserved != null && this.InventoryItemQuantityReserved.HasValue) { state.InventoryItemQuantityReserved = this.InventoryItemQuantityReserved.Value; }
            if (this.InventoryItemQuantityOccupied != null && this.InventoryItemQuantityOccupied.HasValue) { state.InventoryItemQuantityOccupied = this.InventoryItemQuantityOccupied.Value; }
            if (this.InventoryItemQuantityVirtual != null && this.InventoryItemQuantityVirtual.HasValue) { state.InventoryItemQuantityVirtual = this.InventoryItemQuantityVirtual.Value; }
            state.InventoryItemCreatedBy = this.InventoryItemCreatedBy;
            if (this.InventoryItemCreatedAt != null && this.InventoryItemCreatedAt.HasValue) { state.InventoryItemCreatedAt = this.InventoryItemCreatedAt.Value; }
            state.InventoryItemUpdatedBy = this.InventoryItemUpdatedBy;
            if (this.InventoryItemUpdatedAt != null && this.InventoryItemUpdatedAt.HasValue) { state.InventoryItemUpdatedAt = this.InventoryItemUpdatedAt.Value; }
            if (this.InventoryItemVersion != null && this.InventoryItemVersion.HasValue) { state.InventoryItemVersion = this.InventoryItemVersion.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}

