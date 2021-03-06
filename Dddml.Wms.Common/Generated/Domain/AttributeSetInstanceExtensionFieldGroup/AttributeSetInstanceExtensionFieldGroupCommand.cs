﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldGroupDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup
{

	public abstract class AttributeSetInstanceExtensionFieldGroupCommandBase : IAttributeSetInstanceExtensionFieldGroupCommand
	{
		public virtual string Id { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.Id;
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

		public virtual string FieldType { get; set; }

		public virtual int? FieldLength { get; set; }

		public virtual int? FieldCount { get; set; }

		public virtual string NameFormat { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateAttributeSetInstanceExtensionFieldGroup : AttributeSetInstanceExtensionFieldGroupCommandBase, ICreateAttributeSetInstanceExtensionFieldGroup
	{
		
		public CreateAttributeSetInstanceExtensionFieldGroup ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchAttributeSetInstanceExtensionFieldGroup :AttributeSetInstanceExtensionFieldGroupCommandBase, IMergePatchAttributeSetInstanceExtensionFieldGroup
	{

		public virtual bool IsPropertyFieldTypeRemoved { get; set; }

		public virtual bool IsPropertyFieldLengthRemoved { get; set; }

		public virtual bool IsPropertyFieldCountRemoved { get; set; }

		public virtual bool IsPropertyNameFormatRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchAttributeSetInstanceExtensionFieldGroup ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteAttributeSetInstanceExtensionFieldGroup : AttributeSetInstanceExtensionFieldGroupCommandBase, IDeleteAttributeSetInstanceExtensionFieldGroup
	{
		public DeleteAttributeSetInstanceExtensionFieldGroup ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class AttributeSetInstanceExtensionFieldGroupCommands
    {
    }

}
