﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public interface IAttributeSetInstanceExtensionFieldMvoStateProperties
	{
		AttributeSetInstanceExtensionFieldId AttributeSetInstanceExtensionFieldId { get; set; }

		string Name { get; set; }

		string Type { get; set; }

		int? Length { get; set; }

		string Alias { get; set; }

		string Description { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

		string AttrSetInstEFGroupFieldType { get; set; }

		int? AttrSetInstEFGroupFieldLength { get; set; }

		int AttrSetInstEFGroupFieldCount { get; set; }

		string AttrSetInstEFGroupNameFormat { get; set; }

		string AttrSetInstEFGroupDescription { get; set; }

		long AttrSetInstEFGroupVersion { get; set; }

		string AttrSetInstEFGroupCreatedBy { get; set; }

		DateTime AttrSetInstEFGroupCreatedAt { get; set; }

		string AttrSetInstEFGroupUpdatedBy { get; set; }

		DateTime AttrSetInstEFGroupUpdatedAt { get; set; }

		bool AttrSetInstEFGroupActive { get; set; }

		bool AttrSetInstEFGroupDeleted { get; set; }


	}

}