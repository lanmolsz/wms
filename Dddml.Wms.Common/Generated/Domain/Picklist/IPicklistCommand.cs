﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Picklist
{
	public interface IPicklistCommand : IAggregateCommand<string, long>, ICommandDto
	{
		long Version { get; set; }

		string PicklistId { get; set; }

	}


	public interface ICreateOrMergePatchOrDeletePicklist : IPicklistCommand
	{

		string Description { get; set; }

		string FacilityId { get; set; }

		string ShipmentMethodTypeId { get; set; }

		string StatusId { get; set; }

		DateTime? PicklistDate { get; set; }

		long? PickwaveId { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreatePicklist : ICreateOrMergePatchOrDeletePicklist
	{
        ICreatePicklistRoleCommands PicklistRoles { get; }

        ICreatePicklistRole NewCreatePicklistRole();

	}

	public interface IMergePatchPicklist : ICreateOrMergePatchOrDeletePicklist
	{

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyFacilityIdRemoved { get; set; }

		bool IsPropertyShipmentMethodTypeIdRemoved { get; set; }

		bool IsPropertyStatusIdRemoved { get; set; }

		bool IsPropertyPicklistDateRemoved { get; set; }

		bool IsPropertyPickwaveIdRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

        IPicklistRoleCommands PicklistRoleCommands { get; }

        ICreatePicklistRole NewCreatePicklistRole();

        IMergePatchPicklistRole NewMergePatchPicklistRole();

        IRemovePicklistRole NewRemovePicklistRole();


	}

	public interface IDeletePicklist : ICreateOrMergePatchOrDeletePicklist
	{
	}

    public interface ICreatePicklistRoleCommands : IEnumerable<ICreatePicklistRole>
    {
        void Add(ICreatePicklistRole c);

        void Remove(ICreatePicklistRole c);

        void Clear();

    }

    public interface IPicklistRoleCommands : IEnumerable<IPicklistRoleCommand>
    {
        void Add(IPicklistRoleCommand c);

        void Remove(IPicklistRoleCommand c);

        void Clear();

    }


}

