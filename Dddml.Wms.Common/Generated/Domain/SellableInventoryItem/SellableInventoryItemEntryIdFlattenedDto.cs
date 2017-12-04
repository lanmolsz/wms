﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItem
{

	public class SellableInventoryItemEntryIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "SellableInventoryItemIdProductId", "SellableInventoryItemIdLocatorId", "SellableInventoryItemIdAttributeSetInstanceId", "EntrySeqId" };

        string[] IIdFlattenedDto.FieldNames
        {
            get { return _flattenedPropertyNames; }
        }

        object IIdFlattenedDto.GetFieldValue(string fieldName)
        {
            return ReflectUtils.GetPropertyValue(fieldName, this._value);
        }

        void IIdFlattenedDto.SetFieldValue(string fieldName, object fieldValue)
        {
            ReflectUtils.SetPropertyValue(fieldName, this._value, fieldValue);
        }

        Type IIdFlattenedDto.GetFieldType(string fieldName)
        {
            if (fieldName.Equals("SellableInventoryItemIdProductId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("SellableInventoryItemIdLocatorId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("SellableInventoryItemIdAttributeSetInstanceId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("EntrySeqId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private SellableInventoryItemEntryIdDto _value = new SellableInventoryItemEntryIdDto();

		public SellableInventoryItemEntryIdFlattenedDto()
		{
		}

		public SellableInventoryItemEntryIdFlattenedDto(SellableInventoryItemEntryIdDto val)
		{
			this._value = val;
		}

        public SellableInventoryItemEntryIdDto ToSellableInventoryItemEntryIdDto()
        {
            return this._value;
        }

		public SellableInventoryItemEntryIdFlattenedDto(SellableInventoryItemEntryId val)
		{
			this._value = new SellableInventoryItemEntryIdDtoWrapper(val);
		}

        public SellableInventoryItemEntryId ToSellableInventoryItemEntryId()
        {
            return this._value.ToSellableInventoryItemEntryId();
        }

		public virtual string SellableInventoryItemIdProductId {
			get { return _value.SellableInventoryItemId.ProductId; }
			set { _value.SellableInventoryItemId.ProductId = value; }
		}

		public virtual string SellableInventoryItemIdLocatorId {
			get { return _value.SellableInventoryItemId.LocatorId; }
			set { _value.SellableInventoryItemId.LocatorId = value; }
		}

		public virtual string SellableInventoryItemIdAttributeSetInstanceId {
			get { return _value.SellableInventoryItemId.AttributeSetInstanceId; }
			set { _value.SellableInventoryItemId.AttributeSetInstanceId = value; }
		}

		public virtual long EntrySeqId { 
			get { return _value.EntrySeqId; } 
			set { _value.EntrySeqId = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			SellableInventoryItemEntryIdFlattenedDto other = obj as SellableInventoryItemEntryIdFlattenedDto;
			if (other == null) {
				return false;
			}

            return _value.Equals(other._value);

		}

		public override int GetHashCode ()
		{
			return _value.GetHashCode();
		}

	}

    public class SellableInventoryItemEntryIdFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<SellableInventoryItemEntryIdFlattenedDto>
    {

    }

}

