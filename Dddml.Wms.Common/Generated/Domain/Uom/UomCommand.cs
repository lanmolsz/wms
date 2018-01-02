﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Uom;

namespace Dddml.Wms.Domain.Uom
{

	public abstract class UomCommandBase : IUomCommand
	{
		public virtual string UomId { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.UomId;
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

		public virtual string UomTypeId { get; set; }

		public virtual string Abbreviation { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateUom : UomCommandBase, ICreateUom
	{
		
		public CreateUom ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchUom :UomCommandBase, IMergePatchUom
	{

		public virtual bool IsPropertyUomTypeIdRemoved { get; set; }

		public virtual bool IsPropertyAbbreviationRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchUom ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteUom : UomCommandBase, IDeleteUom
	{
		public DeleteUom ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class UomCommands
    {
    }

}