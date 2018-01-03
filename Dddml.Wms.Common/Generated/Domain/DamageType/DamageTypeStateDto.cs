﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageType;

namespace Dddml.Wms.Domain.DamageType
{

    public partial class DamageTypeStateDto : IDamageTypeStateDto
    {
        public virtual string DamageTypeId
        {
            get;
            set;
        }

        public virtual string Description
        {
            get;
            set;
        }

        public virtual string SequenceId
        {
            get;
            set;
        }

        public virtual string DefaultHandlingMethodId
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

        public virtual IDamageTypeState ToDamageTypeState()
        {
            var state = new DamageTypeState(true);
            state.DamageTypeId = this.DamageTypeId;
            state.Description = this.Description;
            state.SequenceId = this.SequenceId;
            state.DefaultHandlingMethodId = this.DefaultHandlingMethodId;
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

