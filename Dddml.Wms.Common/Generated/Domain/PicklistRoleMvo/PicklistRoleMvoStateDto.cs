﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistRoleMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistRoleMvo;
using Dddml.Wms.Domain.Picklist;

namespace Dddml.Wms.Domain.PicklistRoleMvo
{

    public partial class PicklistRoleMvoStateDto : IPicklistRoleMvoStateDto
    {
        public virtual PicklistRoleId PicklistRoleId
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

        public virtual string PicklistDescription
        {
            get;
            set;
        }

        public virtual string PicklistFacilityId
        {
            get;
            set;
        }

        public virtual string PicklistShipmentMethodTypeId
        {
            get;
            set;
        }

        public virtual string PicklistStatusId
        {
            get;
            set;
        }

        public virtual DateTime? PicklistPicklistDate
        {
            get;
            set;
        }

        public virtual long? PicklistPickwaveId
        {
            get;
            set;
        }

        public virtual string PicklistCreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? PicklistCreatedAt
        {
            get;
            set;
        }

        public virtual string PicklistUpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? PicklistUpdatedAt
        {
            get;
            set;
        }

        public virtual bool? PicklistActive
        {
            get;
            set;
        }

        public virtual bool? PicklistDeleted
        {
            get;
            set;
        }

        public virtual long? PicklistVersion
        {
            get;
            set;
        }

        public virtual string CreatedByUserLogin
        {
            get;
            set;
        }

        public virtual DateTime? CreatedAt
        {
            get;
            set;
        }

        public virtual string LastModifiedByUserLogin
        {
            get;
            set;
        }

        public virtual DateTime? UpdatedAt
        {
            get;
            set;
        }

        public virtual IPicklistRoleMvoState ToPicklistRoleMvoState()
        {
            var state = new PicklistRoleMvoState(true);
            state.PicklistRoleId = this.PicklistRoleId;
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            state.PicklistDescription = this.PicklistDescription;
            state.PicklistFacilityId = this.PicklistFacilityId;
            state.PicklistShipmentMethodTypeId = this.PicklistShipmentMethodTypeId;
            state.PicklistStatusId = this.PicklistStatusId;
            state.PicklistPicklistDate = this.PicklistPicklistDate;
            state.PicklistPickwaveId = this.PicklistPickwaveId;
            state.PicklistCreatedBy = this.PicklistCreatedBy;
            if (this.PicklistCreatedAt != null && this.PicklistCreatedAt.HasValue) { state.PicklistCreatedAt = this.PicklistCreatedAt.Value; }
            state.PicklistUpdatedBy = this.PicklistUpdatedBy;
            if (this.PicklistUpdatedAt != null && this.PicklistUpdatedAt.HasValue) { state.PicklistUpdatedAt = this.PicklistUpdatedAt.Value; }
            if (this.PicklistActive != null && this.PicklistActive.HasValue) { state.PicklistActive = this.PicklistActive.Value; }
            if (this.PicklistDeleted != null && this.PicklistDeleted.HasValue) { state.PicklistDeleted = this.PicklistDeleted.Value; }
            if (this.PicklistVersion != null && this.PicklistVersion.HasValue) { state.PicklistVersion = this.PicklistVersion.Value; }
            state.CreatedByUserLogin = this.CreatedByUserLogin;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.LastModifiedByUserLogin = this.LastModifiedByUserLogin;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}

