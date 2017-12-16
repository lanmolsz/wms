﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderHeaderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderHeader;

namespace Dddml.Wms.Domain.OrderHeader
{

	public class OrderHeaderStateEventIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "OrderId", "Version" };

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
            if (fieldName.Equals("OrderId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("Version", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private OrderHeaderStateEventIdDto _value = new OrderHeaderStateEventIdDto();

		public OrderHeaderStateEventIdFlattenedDto()
		{
		}

		public OrderHeaderStateEventIdFlattenedDto(OrderHeaderStateEventIdDto val)
		{
			this._value = val;
		}

        public OrderHeaderStateEventIdDto ToOrderHeaderStateEventIdDto()
        {
            return this._value;
        }

		public OrderHeaderStateEventIdFlattenedDto(OrderHeaderStateEventId val)
		{
			this._value = new OrderHeaderStateEventIdDtoWrapper(val);
		}

        public OrderHeaderStateEventId ToOrderHeaderStateEventId()
        {
            return this._value.ToOrderHeaderStateEventId();
        }

		public virtual string OrderId { 
			get { return _value.OrderId; } 
			set { _value.OrderId = value; } 
		}

		public virtual long Version { 
			get { return _value.Version; } 
			set { _value.Version = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			OrderHeaderStateEventIdFlattenedDto other = obj as OrderHeaderStateEventIdFlattenedDto;
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

    public class OrderHeaderStateEventIdFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<OrderHeaderStateEventIdFlattenedDto>
    {

    }

}


