﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

	public class LoginKeyFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "LoginProvider", "ProviderKey" };

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
            if (fieldName.Equals("LoginProvider", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("ProviderKey", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private LoginKeyDto _value = new LoginKeyDto();

		public LoginKeyFlattenedDto()
		{
		}

		public LoginKeyFlattenedDto(LoginKeyDto val)
		{
			this._value = val;
		}

        public LoginKeyDto ToLoginKeyDto()
        {
            return this._value;
        }

		public LoginKeyFlattenedDto(LoginKey val)
		{
			this._value = new LoginKeyDtoWrapper(val);
		}

        public LoginKey ToLoginKey()
        {
            return this._value.ToLoginKey();
        }

		public virtual string LoginProvider { 
			get { return _value.LoginProvider; } 
			set { _value.LoginProvider = value; } 
		}

		public virtual string ProviderKey { 
			get { return _value.ProviderKey; } 
			set { _value.ProviderKey = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			LoginKeyFlattenedDto other = obj as LoginKeyFlattenedDto;
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

    public class LoginKeyFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<LoginKeyFlattenedDto>
    {

    }

}


