﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeAliasMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeAliasMvo;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.AttributeAliasMvo
{

	public abstract class AttributeAliasMvoCommandDtoBase : ICommandDto, ICreateAttributeAliasMvo, IMergePatchAttributeAliasMvo, IDeleteAttributeAliasMvo
	{

		AttributeAliasId IAggregateCommand<AttributeAliasId, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteAttributeAliasMvo)this).AttributeAliasId;
			}
		}


		long IAggregateCommand<AttributeAliasId, long>.AggregateVersion
		{
			get
			{
				return this.AttributeVersion;
			}
		}

		public virtual long AttributeVersion { get; set; }

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

		public virtual AttributeAliasId AttributeAliasId { get; set; }

		public virtual string Name { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string AttributeAttributeName { get; set; }

		public virtual string AttributeOrganizationId { get; set; }

		public virtual string AttributeDescription { get; set; }

		public virtual bool? AttributeIsMandatory { get; set; }

		public virtual string AttributeAttributeValueType { get; set; }

		public virtual int? AttributeAttributeValueLength { get; set; }

		public virtual bool? AttributeIsList { get; set; }

		public virtual string AttributeFieldName { get; set; }

		public virtual string AttributeReferenceId { get; set; }

		public virtual string AttributeCreatedBy { get; set; }

		public virtual DateTime? AttributeCreatedAt { get; set; }

		public virtual string AttributeUpdatedBy { get; set; }

		public virtual DateTime? AttributeUpdatedAt { get; set; }

		public virtual bool? AttributeActive { get; set; }

		public virtual bool? AttributeDeleted { get; set; }

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyNameRemoved
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

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyVersionRemoved
        {
            get
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyActiveRemoved
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

		public virtual bool? IsPropertyAttributeAttributeNameRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeAttributeNameRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeAttributeNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeAttributeNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeOrganizationIdRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeOrganizationIdRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeOrganizationIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeOrganizationIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeDescriptionRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeIsMandatoryRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeIsMandatoryRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeIsMandatoryRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeIsMandatoryRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeAttributeValueTypeRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeAttributeValueTypeRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeAttributeValueTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeAttributeValueTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeAttributeValueLengthRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeAttributeValueLengthRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeAttributeValueLengthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeAttributeValueLengthRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeIsListRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeIsListRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeIsListRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeIsListRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeFieldNameRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeFieldNameRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeFieldNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeFieldNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeReferenceIdRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeReferenceIdRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeReferenceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeReferenceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeCreatedByRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeCreatedByRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeCreatedAtRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeCreatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeUpdatedByRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeUpdatedByRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeUpdatedAtRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeUpdatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeActiveRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeActiveRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeDeletedRemoved { get; set; }

        bool IMergePatchAttributeAliasMvo.IsPropertyAttributeDeletedRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeDeletedRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteAttributeAliasMvoDto : AttributeAliasMvoCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateAttributeAliasMvoDto : CreateOrMergePatchOrDeleteAttributeAliasMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchAttributeAliasMvoDto : CreateOrMergePatchOrDeleteAttributeAliasMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteAttributeAliasMvoDto : CreateOrMergePatchOrDeleteAttributeAliasMvoDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}

    public static partial class AttributeAliasMvoCommandDtos
    {

    }

}

