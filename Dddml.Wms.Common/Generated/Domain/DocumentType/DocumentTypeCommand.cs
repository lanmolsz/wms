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

	public abstract class DocumentTypeCommandBase : IDocumentTypeCommand
	{
		public virtual string DocumentTypeId { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.DocumentTypeId;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual string Description { get; set; }

		public virtual string ParentDocumentTypeId { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateDocumentType : DocumentTypeCommandBase, ICreateDocumentType
	{
		
		public CreateDocumentType ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchDocumentType :DocumentTypeCommandBase, IMergePatchDocumentType
	{

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyParentDocumentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchDocumentType ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteDocumentType : DocumentTypeCommandBase, IDeleteDocumentType
	{
		public DeleteDocumentType ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class DocumentTypeCommands
    {
    }

}
