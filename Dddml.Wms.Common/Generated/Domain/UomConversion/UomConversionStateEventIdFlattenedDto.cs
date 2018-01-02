﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomConversionDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomConversion;

namespace Dddml.Wms.Domain.UomConversion
{

	public class UomConversionStateEventIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "UomConversionIdUomId", "UomConversionIdUomIdTo", "Version" };

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
            if (fieldName.Equals("UomConversionIdUomId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("UomConversionIdUomIdTo", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("Version", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private UomConversionStateEventIdDto _value = new UomConversionStateEventIdDto();

		public UomConversionStateEventIdFlattenedDto()
		{
		}

		public UomConversionStateEventIdFlattenedDto(UomConversionStateEventIdDto val)
		{
			this._value = val;
		}

        public UomConversionStateEventIdDto ToUomConversionStateEventIdDto()
        {
            return this._value;
        }

		public UomConversionStateEventIdFlattenedDto(UomConversionStateEventId val)
		{
			this._value = new UomConversionStateEventIdDtoWrapper(val);
		}

        public UomConversionStateEventId ToUomConversionStateEventId()
        {
            return this._value.ToUomConversionStateEventId();
        }

		public virtual string UomConversionIdUomId {
			get { return _value.UomConversionId.UomId; }
			set { _value.UomConversionId.UomId = value; }
		}

		public virtual string UomConversionIdUomIdTo {
			get { return _value.UomConversionId.UomIdTo; }
			set { _value.UomConversionId.UomIdTo = value; }
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

			UomConversionStateEventIdFlattenedDto other = obj as UomConversionStateEventIdFlattenedDto;
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

    public class UomConversionStateEventIdFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<UomConversionStateEventIdFlattenedDto>
    {

    }

}

