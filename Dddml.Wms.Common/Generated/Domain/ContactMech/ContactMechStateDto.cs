﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateContactMechDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ContactMech;

namespace Dddml.Wms.Domain.ContactMech
{

    public partial class ContactMechStateDto : IContactMechStateDto
    {
        public virtual string ContactMechId
        {
            get;
            set;
        }

        public virtual string ContactMechTypeId
        {
            get;
            set;
        }

        public virtual string InfoString
        {
            get;
            set;
        }

        public virtual string ToName
        {
            get;
            set;
        }

        public virtual string AttnName
        {
            get;
            set;
        }

        public virtual string Address1
        {
            get;
            set;
        }

        public virtual string Address2
        {
            get;
            set;
        }

        public virtual string Directions
        {
            get;
            set;
        }

        public virtual string City
        {
            get;
            set;
        }

        public virtual string PostalCode
        {
            get;
            set;
        }

        public virtual string PostalCodeExt
        {
            get;
            set;
        }

        public virtual string CountryGeoId
        {
            get;
            set;
        }

        public virtual string StateProvinceGeoId
        {
            get;
            set;
        }

        public virtual string CountyGeoId
        {
            get;
            set;
        }

        public virtual string PostalCodeGeoId
        {
            get;
            set;
        }

        public virtual string GeoPointId
        {
            get;
            set;
        }

        public virtual string CountryCode
        {
            get;
            set;
        }

        public virtual string AreaCode
        {
            get;
            set;
        }

        public virtual string ContactNumber
        {
            get;
            set;
        }

        public virtual string AskForName
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

        public virtual IContactMechState ToContactMechState()
        {
            var state = new ContactMechState(true);
            state.ContactMechId = this.ContactMechId;
            state.ContactMechTypeId = this.ContactMechTypeId;
            state.InfoString = this.InfoString;
            state.ToName = this.ToName;
            state.AttnName = this.AttnName;
            state.Address1 = this.Address1;
            state.Address2 = this.Address2;
            state.Directions = this.Directions;
            state.City = this.City;
            state.PostalCode = this.PostalCode;
            state.PostalCodeExt = this.PostalCodeExt;
            state.CountryGeoId = this.CountryGeoId;
            state.StateProvinceGeoId = this.StateProvinceGeoId;
            state.CountyGeoId = this.CountyGeoId;
            state.PostalCodeGeoId = this.PostalCodeGeoId;
            state.GeoPointId = this.GeoPointId;
            state.CountryCode = this.CountryCode;
            state.AreaCode = this.AreaCode;
            state.ContactNumber = this.ContactNumber;
            state.AskForName = this.AskForName;
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

        public virtual IPostalAddressState ToPostalAddressState()
        {
            var state = new PostalAddressState(true);
            state.ContactMechId = this.ContactMechId;
            state.ContactMechTypeId = this.ContactMechTypeId;
            state.InfoString = this.InfoString;
            state.ToName = this.ToName;
            state.AttnName = this.AttnName;
            state.Address1 = this.Address1;
            state.Address2 = this.Address2;
            state.Directions = this.Directions;
            state.City = this.City;
            state.PostalCode = this.PostalCode;
            state.PostalCodeExt = this.PostalCodeExt;
            state.CountryGeoId = this.CountryGeoId;
            state.StateProvinceGeoId = this.StateProvinceGeoId;
            state.CountyGeoId = this.CountyGeoId;
            state.PostalCodeGeoId = this.PostalCodeGeoId;
            state.GeoPointId = this.GeoPointId;
            state.CountryCode = this.CountryCode;
            state.AreaCode = this.AreaCode;
            state.ContactNumber = this.ContactNumber;
            state.AskForName = this.AskForName;
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

        public virtual ITelecomNumberState ToTelecomNumberState()
        {
            var state = new TelecomNumberState(true);
            state.ContactMechId = this.ContactMechId;
            state.ContactMechTypeId = this.ContactMechTypeId;
            state.InfoString = this.InfoString;
            state.ToName = this.ToName;
            state.AttnName = this.AttnName;
            state.Address1 = this.Address1;
            state.Address2 = this.Address2;
            state.Directions = this.Directions;
            state.City = this.City;
            state.PostalCode = this.PostalCode;
            state.PostalCodeExt = this.PostalCodeExt;
            state.CountryGeoId = this.CountryGeoId;
            state.StateProvinceGeoId = this.StateProvinceGeoId;
            state.CountyGeoId = this.CountyGeoId;
            state.PostalCodeGeoId = this.PostalCodeGeoId;
            state.GeoPointId = this.GeoPointId;
            state.CountryCode = this.CountryCode;
            state.AreaCode = this.AreaCode;
            state.ContactNumber = this.ContactNumber;
            state.AskForName = this.AskForName;
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

