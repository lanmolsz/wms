﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{

	public class InOutLineStateEventIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "InOutDocumentNumber", "SkuIdProductId", "SkuIdAttributeSetInstanceId", "InOutVersion" };

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
            if (fieldName.Equals("InOutDocumentNumber", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("SkuIdProductId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("SkuIdAttributeSetInstanceId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("InOutVersion", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private InOutLineStateEventId _value = new InOutLineStateEventId();

		public InOutLineStateEventIdFlattenedDto()
		{
		}

		public InOutLineStateEventIdFlattenedDto(InOutLineStateEventId val)
		{
			this._value = val;
		}

        public InOutLineStateEventId ToInOutLineStateEventId()
        {
            return this._value;
        }


		public virtual string InOutDocumentNumber { 
			get { return _value.InOutDocumentNumber; } 
			set { _value.InOutDocumentNumber = value; } 
		}

		public virtual string SkuIdProductId {
			get { return _value.SkuId.ProductId; }
			set { _value.SkuId.ProductId = value; }
		}

		public virtual string SkuIdAttributeSetInstanceId {
			get { return _value.SkuId.AttributeSetInstanceId; }
			set { _value.SkuId.AttributeSetInstanceId = value; }
		}

		public virtual long InOutVersion { 
			get { return _value.InOutVersion; } 
			set { _value.InOutVersion = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InOutLineStateEventIdFlattenedDto other = obj as InOutLineStateEventIdFlattenedDto;
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

}


