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
	public interface IDocumentTypeStateEvent : IEvent, IStateEventDto, IGlobalIdentity<DocumentTypeStateEventId>, ICreated<string>
	{
		DocumentTypeStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string Description { get; set; }

		string ParentDocumentTypeId { get; set; }

		bool? Active { get; set; }

	}

	public interface IDocumentTypeStateCreated : IDocumentTypeStateEvent//, IDocumentTypeStateProperties
	{
	
	}


	public interface IDocumentTypeStateMergePatched : IDocumentTypeStateEvent//, IDocumentTypeStateProperties
	{
		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyParentDocumentTypeIdRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IDocumentTypeStateDeleted : IDocumentTypeStateEvent
	{
	}


}

