﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public class OrganizationStructureIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "OrganizationStructureTypeId", "ParentId", "SubsidiaryId" };

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
            if (fieldName.Equals("OrganizationStructureTypeId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("ParentId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("SubsidiaryId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private OrganizationStructureIdDto _value = new OrganizationStructureIdDto();

		public OrganizationStructureIdFlattenedDto()
		{
		}

		public OrganizationStructureIdFlattenedDto(OrganizationStructureIdDto val)
		{
			this._value = val;
		}

        public OrganizationStructureIdDto ToOrganizationStructureIdDto()
        {
            return this._value;
        }

		public OrganizationStructureIdFlattenedDto(OrganizationStructureId val)
		{
			this._value = new OrganizationStructureIdDtoWrapper(val);
		}

        public OrganizationStructureId ToOrganizationStructureId()
        {
            return this._value.ToOrganizationStructureId();
        }

		public virtual string OrganizationStructureTypeId { 
			get { return _value.OrganizationStructureTypeId; } 
			set { _value.OrganizationStructureTypeId = value; } 
		}

		public virtual string ParentId { 
			get { return _value.ParentId; } 
			set { _value.ParentId = value; } 
		}

		public virtual string SubsidiaryId { 
			get { return _value.SubsidiaryId; } 
			set { _value.SubsidiaryId = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			OrganizationStructureIdFlattenedDto other = obj as OrganizationStructureIdFlattenedDto;
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


