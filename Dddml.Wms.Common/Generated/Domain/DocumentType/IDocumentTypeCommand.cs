﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDocumentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DocumentType;

namespace Dddml.Wms.Domain.DocumentType
{
	public interface IDocumentTypeCommand : IAggregateCommand<string, long>, ICommandDto
	{
		long Version { get; set; }

		string DocumentTypeId { get; set; }

	}


	public interface ICreateOrMergePatchOrDeleteDocumentType : IDocumentTypeCommand
	{

		string Description { get; set; }

		string ParentDocumentTypeId { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateDocumentType : ICreateOrMergePatchOrDeleteDocumentType
	{
	}

	public interface IMergePatchDocumentType : ICreateOrMergePatchOrDeleteDocumentType
	{

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyParentDocumentTypeIdRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IDeleteDocumentType : ICreateOrMergePatchOrDeleteDocumentType
	{
	}


}

