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

	public abstract class AttributeCommandDtoBase : ICommandDto, ICreateAttribute, IMergePatchAttribute, IDeleteAttribute
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return (this as IAttributeStateProperties).AttributeId;
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

		public virtual string RequesterId { get; set; }//TODO RequesterId 应该是可以支持自定义名称

		public virtual string CommandId { get; set; }//TODO CommandId 太特殊了！！！应该可以支持自定义名称（即不一定要叫 CommandId）

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

		public virtual string AttributeId { get; set; }

		public virtual string Name { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? IsMandatory { get; set; }

        bool IAttributeStateProperties.IsMandatory
        {
            get 
            {
                var b = this.IsMandatory;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsMandatory = value;
            }
        }

		public virtual bool? IsInstanceAttribute { get; set; }

        bool IAttributeStateProperties.IsInstanceAttribute
        {
            get 
            {
                var b = this.IsInstanceAttribute;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsInstanceAttribute = value;
            }
        }

		public virtual string AttributeValueType { get; set; }

		public virtual string FieldName { get; set; }

		public virtual bool? Active { get; set; }

        bool IAttributeStateProperties.Active
        {
            get 
            {
                var b = this.Active;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.Active = value;
            }
        }

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyNameRemoved
        {
            get
            {
                var b = this.IsPropertyNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsMandatoryRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyIsMandatoryRemoved
        {
            get
            {
                var b = this.IsPropertyIsMandatoryRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsMandatoryRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInstanceAttributeRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyIsInstanceAttributeRemoved
        {
            get
            {
                var b = this.IsPropertyIsInstanceAttributeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsInstanceAttributeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeValueTypeRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyAttributeValueTypeRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeValueTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeValueTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyFieldNameRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyFieldNameRemoved
        {
            get
            {
                var b = this.IsPropertyFieldNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyFieldNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchAttribute.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

        ICreateAttributeValueCommands ICreateAttribute.AttributeValues
        {
            get
            {
                return this._attributeValues;
            }
        }

        IAttributeValueCommands IMergePatchAttribute.AttributeValueCommands
        {
            get
            {
                return this._attributeValues;
            }
        }

        public virtual CreateAttributeValueDto NewCreateAttributeValue()
        {
            var c = new CreateAttributeValueDto();
            c.AttributeId = this.AttributeId;

            return c;
        }

        ICreateAttributeValue ICreateAttribute.NewCreateAttributeValue()
        {
            return this.NewCreateAttributeValue();
        }

        ICreateAttributeValue IMergePatchAttribute.NewCreateAttributeValue()
        {
            return this.NewCreateAttributeValue();
        }

        public virtual MergePatchAttributeValueDto NewMergePatchAttributeValue()
        {
            var c = new MergePatchAttributeValueDto();
            c.AttributeId = this.AttributeId;

            return c;
        }

        IMergePatchAttributeValue IMergePatchAttribute.NewMergePatchAttributeValue()
        {
            return this.NewMergePatchAttributeValue();
        }

        public virtual RemoveAttributeValueDto NewRemoveAttributeValue()
        {
            var c = new RemoveAttributeValueDto();
            c.AttributeId = this.AttributeId;

            return c;
        }

        IRemoveAttributeValue IMergePatchAttribute.NewRemoveAttributeValue()
        {
            return this.NewRemoveAttributeValue();
        }

        private CreateOrMergePatchOrRemoveAttributeValueDtos _attributeValues = new CreateOrMergePatchOrRemoveAttributeValueDtos();

        public virtual CreateOrMergePatchOrRemoveAttributeValueDto[] AttributeValues
        {
            get
            {
                return _attributeValues.ToArray();
            }
            set
            {
                _attributeValues.Clear();
                _attributeValues.AddRange(value);
            }
        }


        // //////////////////////////////////////////////

        private IAttributeCommand _innerCommand;

        public virtual ICommand ToCommand()
        {
            //if (this._innerCommand != null)
            //{
                //return this._innerCommand;
            //}
            var cmdType = GetCommandType();
            if (cmdType == CommandType.Create)
            {
                var cmd = ToCreateAttribute();
                this._innerCommand = cmd;
            }
            else if (cmdType == CommandType.MergePatch)
            {
                var cmd = ToMergePatchAttribute();
                this._innerCommand = cmd;
            }
            else if (cmdType == CommandType.Delete)
            {
                var cmd = ToDeleteAttribute();
                this._innerCommand = cmd;
            }
            else
            {
                throw DomainError.Named("invalidCommandType", String.Format("Invalid command type: {0}", cmdType));
            }
            return this._innerCommand;
        }

        internal DeleteAttribute ToDeleteAttribute()
        {
            var cmd = new DeleteAttribute();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.AttributeId = (this as IAttributeStateProperties).AttributeId;
            cmd.Version = this.Version;

            return cmd;
        }

        internal MergePatchAttribute ToMergePatchAttribute()
        {
            var cmd = new MergePatchAttribute();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.Version = this.Version;

            cmd.AttributeId = (this as IAttributeStateProperties).AttributeId;
            cmd.Name = (this as IAttributeStateProperties).Name;
            cmd.Description = (this as IAttributeStateProperties).Description;
            cmd.IsMandatory = (this as IAttributeStateProperties).IsMandatory;
            cmd.IsInstanceAttribute = (this as IAttributeStateProperties).IsInstanceAttribute;
            cmd.AttributeValueType = (this as IAttributeStateProperties).AttributeValueType;
            cmd.FieldName = (this as IAttributeStateProperties).FieldName;
            cmd.Active = (this as IAttributeStateProperties).Active;
            
            cmd.IsPropertyNameRemoved = (this as IMergePatchAttribute).IsPropertyNameRemoved;
            cmd.IsPropertyDescriptionRemoved = (this as IMergePatchAttribute).IsPropertyDescriptionRemoved;
            cmd.IsPropertyIsMandatoryRemoved = (this as IMergePatchAttribute).IsPropertyIsMandatoryRemoved;
            cmd.IsPropertyIsInstanceAttributeRemoved = (this as IMergePatchAttribute).IsPropertyIsInstanceAttributeRemoved;
            cmd.IsPropertyAttributeValueTypeRemoved = (this as IMergePatchAttribute).IsPropertyAttributeValueTypeRemoved;
            cmd.IsPropertyFieldNameRemoved = (this as IMergePatchAttribute).IsPropertyFieldNameRemoved;
            cmd.IsPropertyActiveRemoved = (this as IMergePatchAttribute).IsPropertyActiveRemoved;
            foreach (var d in (IEnumerable<CreateOrMergePatchOrRemoveAttributeValueDto>)_attributeValues)
            {
                var c = (IAttributeValueCommand)d.ToCommand();
                cmd.AttributeValueCommands.Add(c);
            }
            return cmd;
        }

        internal CreateAttribute ToCreateAttribute()
        {
            var cmd = new CreateAttribute();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.Version = this.Version;

            cmd.AttributeId = (this as IAttributeStateProperties).AttributeId;
            cmd.Name = (this as IAttributeStateProperties).Name;
            cmd.Description = (this as IAttributeStateProperties).Description;
            cmd.IsMandatory = (this as IAttributeStateProperties).IsMandatory;
            cmd.IsInstanceAttribute = (this as IAttributeStateProperties).IsInstanceAttribute;
            cmd.AttributeValueType = (this as IAttributeStateProperties).AttributeValueType;
            cmd.FieldName = (this as IAttributeStateProperties).FieldName;
            cmd.Active = (this as IAttributeStateProperties).Active;
            foreach (var d in (IEnumerable<CreateOrMergePatchOrRemoveAttributeValueDto>)_attributeValues)
            {
                var c = d.ToCreateAttributeValue();
                cmd.AttributeValues.Add(c);
            }
            return cmd;
        }

        // //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteAttributeDto : AttributeCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            //TODO (Command Type）的名称应该允许自定义
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateAttributeDto : CreateOrMergePatchOrDeleteAttributeDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				//base.CommandType = value; 
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchAttributeDto : CreateOrMergePatchOrDeleteAttributeDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				//base.CommandType = value; 
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteAttributeDto : CreateOrMergePatchOrDeleteAttributeDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				//base.CommandType = value; 
            }
        }

	}





}

