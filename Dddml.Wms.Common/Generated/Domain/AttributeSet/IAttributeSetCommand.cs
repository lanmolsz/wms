﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeSet
{
	public interface IAttributeSetCommand : IAggregateCommand<string, long>, ICommandDto
	{
		long Version { get; set; }

		string AttributeSetId { get; set; }

	}


	public interface ICreateOrMergePatchOrDeleteAttributeSet : IAttributeSetCommand
	{

		string AttributeSetName { get; set; }

		string OrganizationId { get; set; }

		string Description { get; set; }

		string SerialNumberAttributeId { get; set; }

		string LotAttributeId { get; set; }

		string ReferenceId { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateAttributeSet : ICreateOrMergePatchOrDeleteAttributeSet
	{
        ICreateAttributeUseCommands AttributeUses { get; }

        ICreateAttributeUse NewCreateAttributeUse();

	}

	public interface IMergePatchAttributeSet : ICreateOrMergePatchOrDeleteAttributeSet
	{

		bool IsPropertyAttributeSetNameRemoved { get; set; }

		bool IsPropertyOrganizationIdRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertySerialNumberAttributeIdRemoved { get; set; }

		bool IsPropertyLotAttributeIdRemoved { get; set; }

		bool IsPropertyReferenceIdRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

        IAttributeUseCommands AttributeUseCommands { get; }

        ICreateAttributeUse NewCreateAttributeUse();

        IMergePatchAttributeUse NewMergePatchAttributeUse();

        IRemoveAttributeUse NewRemoveAttributeUse();


	}

	public interface IDeleteAttributeSet : ICreateOrMergePatchOrDeleteAttributeSet
	{
	}

    public interface ICreateAttributeUseCommands : IEnumerable<ICreateAttributeUse>
    {
        void Add(ICreateAttributeUse c);

        void Remove(ICreateAttributeUse c);

        void Clear();

    }

    public interface IAttributeUseCommands : IEnumerable<IAttributeUseCommand>
    {
        void Add(IAttributeUseCommand c);

        void Remove(IAttributeUseCommand c);

        void Clear();

    }


}

