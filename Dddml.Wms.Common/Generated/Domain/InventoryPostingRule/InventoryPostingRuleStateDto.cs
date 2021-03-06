﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryPostingRuleDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryPostingRule;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryPostingRule
{

    public partial class InventoryPostingRuleStateDto : IInventoryPostingRuleStateDto
    {
        public virtual string InventoryPostingRuleId
        {
            get;
            set;
        }

        public virtual InventoryItemId TriggerInventoryItemId
        {
            get;
            set;
        }

        public virtual InventoryItemId OutputInventoryItemId
        {
            get;
            set;
        }

        public virtual string TriggerAccountName
        {
            get;
            set;
        }

        public virtual string OutputAccountName
        {
            get;
            set;
        }

        public virtual bool? IsOutputNegated
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

        public virtual IInventoryPostingRuleState ToInventoryPostingRuleState()
        {
            var state = new InventoryPostingRuleState(true);
            state.InventoryPostingRuleId = this.InventoryPostingRuleId;
            state.TriggerInventoryItemId = this.TriggerInventoryItemId;
            state.OutputInventoryItemId = this.OutputInventoryItemId;
            state.TriggerAccountName = this.TriggerAccountName;
            state.OutputAccountName = this.OutputAccountName;
            if (this.IsOutputNegated != null && this.IsOutputNegated.HasValue) { state.IsOutputNegated = this.IsOutputNegated.Value; }
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}

