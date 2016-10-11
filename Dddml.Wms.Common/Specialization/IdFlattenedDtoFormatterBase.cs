﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace Dddml.Wms.Specialization
{
    public abstract class IdFlattenedDtoFormatterBase<TDto> : IIdFlattenedDtoFormatter<TDto> where TDto : IIdFlattenedDto, new()
    {

        public TDto Parse(string text)
        {
            string[] strValues = text.Split(new string[] { FieldSeparator }, StringSplitOptions.None);
            var obj = new TDto();

            var fieldNames = obj.FieldNames;
            if (strValues.Length != fieldNames.Length)
            {
                throw new ArgumentException(String.Format("The fields count in argument \"{0}\" is NOT right.", "text"));
            }
            for (int i = 0; i < fieldNames.Length; i++)
            {
                var fieldName = fieldNames[i];
                var strVal = strValues[i].Trim();
                var val = ApplicationContext.Current.TypeConverter.ConvertFromString(obj.GetFieldType(fieldName), strVal);
                obj.SetFieldValue(fieldName, val);
            }
            return obj;
        }

        public virtual string ToString(TDto value)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var f in value.FieldNames)
            {
                var fVal = value.GetFieldValue(f);
                if (!String.IsNullOrWhiteSpace(sb.ToString()))
                {
                    sb.Append(FieldSeparator);
                }
                var type = fVal.GetType();
                sb.Append(ApplicationContext.Current.TypeConverter.ConvertToString(type, fVal));
            }
            return sb.ToString();
        }


        protected virtual string FieldSeparator
        {
            get
            {
                return ",";
            }
        }
    }


}
