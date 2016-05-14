﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{
	public interface IAttributeValueCommand : ICommand
	{
	}

	public interface ICreateAttributeValue : IAttributeValueCommand, IAttributeValueStateProperties
	{
	}


	public interface IMergePatchAttributeValue : IAttributeValueCommand, IAttributeValueStateProperties
	{

		bool IsPropertyNameRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyReferenceIdRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRemoveAttributeValue : IAttributeValueCommand, IAttributeValueStateProperties
	{
	}


}

