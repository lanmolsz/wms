﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistItemMvo;
using Dddml.Wms.Domain.PicklistBin;

namespace Dddml.Wms.Domain.PicklistItemMvo
{

	public abstract class PicklistItemMvoCommandDtoBase : ICommandDto, ICreatePicklistItemMvo, IMergePatchPicklistItemMvo, IDeletePicklistItemMvo
	{

		PicklistBinPicklistItemId IAggregateCommand<PicklistBinPicklistItemId, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeletePicklistItemMvo)this).PicklistBinPicklistItemId;
			}
		}


		long IAggregateCommand<PicklistBinPicklistItemId, long>.AggregateVersion
		{
			get
			{
				return this.PicklistBinVersion;
			}
		}

		public virtual long PicklistBinVersion { get; set; }

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

		public virtual PicklistBinPicklistItemId PicklistBinPicklistItemId { get; set; }

		public virtual string ItemStatusId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string PicklistBinPicklistId { get; set; }

		public virtual long? PicklistBinBinLocationNumber { get; set; }

		public virtual string PicklistBinPrimaryOrderId { get; set; }

		public virtual long? PicklistBinPrimaryShipGroupSeqId { get; set; }

		public virtual string PicklistBinCreatedBy { get; set; }

		public virtual DateTime? PicklistBinCreatedAt { get; set; }

		public virtual string PicklistBinUpdatedBy { get; set; }

		public virtual DateTime? PicklistBinUpdatedAt { get; set; }

		public virtual bool? PicklistBinActive { get; set; }

		public virtual bool? PicklistBinDeleted { get; set; }

		public virtual bool? IsPropertyItemStatusIdRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyItemStatusIdRemoved
        {
            get
            {
                var b = this.IsPropertyItemStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyItemStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuantityRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyVersionRemoved
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

        bool IMergePatchPicklistItemMvo.IsPropertyActiveRemoved
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

		public virtual bool? IsPropertyPicklistBinPicklistIdRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyPicklistBinPicklistIdRemoved
        {
            get
            {
                var b = this.IsPropertyPicklistBinPicklistIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPicklistBinPicklistIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPicklistBinBinLocationNumberRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyPicklistBinBinLocationNumberRemoved
        {
            get
            {
                var b = this.IsPropertyPicklistBinBinLocationNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPicklistBinBinLocationNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyPicklistBinPrimaryOrderIdRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyPicklistBinPrimaryOrderIdRemoved
        {
            get
            {
                var b = this.IsPropertyPicklistBinPrimaryOrderIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPicklistBinPrimaryOrderIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPicklistBinPrimaryShipGroupSeqIdRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyPicklistBinPrimaryShipGroupSeqIdRemoved
        {
            get
            {
                var b = this.IsPropertyPicklistBinPrimaryShipGroupSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPicklistBinPrimaryShipGroupSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPicklistBinCreatedByRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyPicklistBinCreatedByRemoved
        {
            get
            {
                var b = this.IsPropertyPicklistBinCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPicklistBinCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyPicklistBinCreatedAtRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyPicklistBinCreatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyPicklistBinCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPicklistBinCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyPicklistBinUpdatedByRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyPicklistBinUpdatedByRemoved
        {
            get
            {
                var b = this.IsPropertyPicklistBinUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPicklistBinUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyPicklistBinUpdatedAtRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyPicklistBinUpdatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyPicklistBinUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPicklistBinUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyPicklistBinActiveRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyPicklistBinActiveRemoved
        {
            get
            {
                var b = this.IsPropertyPicklistBinActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPicklistBinActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyPicklistBinDeletedRemoved { get; set; }

        bool IMergePatchPicklistItemMvo.IsPropertyPicklistBinDeletedRemoved
        {
            get
            {
                var b = this.IsPropertyPicklistBinDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPicklistBinDeletedRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeletePicklistItemMvoDto : PicklistItemMvoCommandDtoBase
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



	public class CreatePicklistItemMvoDto : CreateOrMergePatchOrDeletePicklistItemMvoDto
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


	public class MergePatchPicklistItemMvoDto : CreateOrMergePatchOrDeletePicklistItemMvoDto
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

	public class DeletePicklistItemMvoDto : CreateOrMergePatchOrDeletePicklistItemMvoDto
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

    public static partial class PicklistItemMvoCommandDtos
    {

    }

}

