﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateContactMechDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ContactMech;

namespace Dddml.Wms.Domain.ContactMech
{
	public interface IContactMechEvent : IEvent, IEventDto, IGlobalIdentity<ContactMechEventId>, ICreated<string>
	{
		ContactMechEventId ContactMechEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface IContactMechStateEvent : IContactMechEvent
    {
		string ContactMechTypeId { get; set; }

		string InfoString { get; set; }

		string ToName { get; set; }

		string AttnName { get; set; }

		string Address1 { get; set; }

		string Address2 { get; set; }

		string Directions { get; set; }

		string City { get; set; }

		string PostalCode { get; set; }

		string PostalCodeExt { get; set; }

		string CountryGeoId { get; set; }

		string StateProvinceGeoId { get; set; }

		string CountyGeoId { get; set; }

		string PostalCodeGeoId { get; set; }

		string GeoPointId { get; set; }

		string CountryCode { get; set; }

		string AreaCode { get; set; }

		string ContactNumber { get; set; }

		string AskForName { get; set; }

		bool? Active { get; set; }

    }
   
	public interface IContactMechStateCreated : IContactMechStateEvent
	{
	
	}


	public interface IContactMechStateMergePatched : IContactMechStateEvent
	{
		bool IsPropertyContactMechTypeIdRemoved { get; set; }

		bool IsPropertyInfoStringRemoved { get; set; }

		bool IsPropertyToNameRemoved { get; set; }

		bool IsPropertyAttnNameRemoved { get; set; }

		bool IsPropertyAddress1Removed { get; set; }

		bool IsPropertyAddress2Removed { get; set; }

		bool IsPropertyDirectionsRemoved { get; set; }

		bool IsPropertyCityRemoved { get; set; }

		bool IsPropertyPostalCodeRemoved { get; set; }

		bool IsPropertyPostalCodeExtRemoved { get; set; }

		bool IsPropertyCountryGeoIdRemoved { get; set; }

		bool IsPropertyStateProvinceGeoIdRemoved { get; set; }

		bool IsPropertyCountyGeoIdRemoved { get; set; }

		bool IsPropertyPostalCodeGeoIdRemoved { get; set; }

		bool IsPropertyGeoPointIdRemoved { get; set; }

		bool IsPropertyCountryCodeRemoved { get; set; }

		bool IsPropertyAreaCodeRemoved { get; set; }

		bool IsPropertyContactNumberRemoved { get; set; }

		bool IsPropertyAskForNameRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IContactMechStateDeleted : IContactMechStateEvent
	{
	}


}
