﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDomainMetadata.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Metadata
{

    public class AttributeMetadata
    {
        private static PropertyMetadata[] _properties = new PropertyMetadata[]{
                new PropertyMetadata {
                    Name = "AttributeId",
                    Type = typeof(string),
                    TypeName = "string",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 50,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = true,
                    IsGlobalId = true,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "AttributeName",
                    Type = typeof(string),
                    TypeName = "string",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "OrganizationId",
                    Type = typeof(string),
                    TypeName = "string",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "Description",
                    Type = typeof(string),
                    TypeName = "string",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "IsMandatory",
                    Type = typeof(bool),
                    TypeName = "bool",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "IsInstanceAttribute",
                    Type = typeof(bool),
                    TypeName = "bool",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "AttributeValueType",
                    Type = typeof(string),
                    TypeName = "string",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "AttributeValueLength",
                    Type = typeof(int),
                    TypeName = "int",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "IsList",
                    Type = typeof(bool),
                    TypeName = "bool",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "FieldName",
                    Type = typeof(string),
                    TypeName = "string",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "ReferenceId",
                    Type = typeof(string),
                    TypeName = "string",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "AttributeValues",
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "AttributeValue",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = false,
                },
                new PropertyMetadata {
                    Name = "Aliases",
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "AttributeAlias",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = false,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = false,
                },
                new PropertyMetadata {
                    Name = "Version",
                    Type = typeof(long),
                    TypeName = "long",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = true,
                    IsReservedPropertyVersion = true,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "CreatedBy",
                    Type = typeof(string),
                    TypeName = "string",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = true,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = true,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "CreatedAt",
                    Type = typeof(DateTime),
                    TypeName = "DateTime",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = true,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = true,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "UpdatedBy",
                    Type = typeof(string),
                    TypeName = "string",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = true,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = true,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "UpdatedAt",
                    Type = typeof(DateTime),
                    TypeName = "DateTime",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = true,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = true,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "Active",
                    Type = typeof(bool),
                    TypeName = "bool",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = true,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = false,
                    IsReservedPropertyActive = true,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
                new PropertyMetadata {
                    Name = "Deleted",
                    Type = typeof(bool),
                    TypeName = "bool",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "",
                    InverseOf = "",
                    IsHoisted = false,
                    IsId = false,
                    IsGlobalId = false,
                    IsDerived = false,
                    IsDiscriminator = false,
                    IsReservedProperty = true,
                    IsReservedPropertyVersion = false,
                    IsReservedPropertyDeleted = true,
                    IsReservedPropertyActive = false,
                    IsReservedPropertyCreatedBy = false,
                    IsReservedPropertyCreatedAt = false,
                    IsReservedPropertyUpdatedBy = false,
                    IsReservedPropertyUpdatedAt = false,
                    IsFilteringProperty = true,
                },
            };


        private static IDictionary<string, PropertyMetadata> _propertyMetadataDictionary;

        private static IDictionary<string, string> _filteringPropertyAliasDictionary;

        public IDictionary<string, string> FilteringPropertyAliasDictionary
        {
            get { return _filteringPropertyAliasDictionary; }
        }

        private static void InitFilteringPropertyAliasDictionary()
        {
            var d = new Dictionary<string, string>();
            d.Add("AttributeId", "AttributeId");
            d.Add("attributeId", "AttributeId");
            d.Add("AttributeName", "AttributeName");
            d.Add("attributeName", "AttributeName");
            d.Add("OrganizationId", "OrganizationId");
            d.Add("organizationId", "OrganizationId");
            d.Add("Description", "Description");
            d.Add("description", "Description");
            d.Add("IsMandatory", "IsMandatory");
            d.Add("isMandatory", "IsMandatory");
            d.Add("IsInstanceAttribute", "IsInstanceAttribute");
            d.Add("isInstanceAttribute", "IsInstanceAttribute");
            d.Add("AttributeValueType", "AttributeValueType");
            d.Add("attributeValueType", "AttributeValueType");
            d.Add("AttributeValueLength", "AttributeValueLength");
            d.Add("attributeValueLength", "AttributeValueLength");
            d.Add("IsList", "IsList");
            d.Add("isList", "IsList");
            d.Add("FieldName", "FieldName");
            d.Add("fieldName", "FieldName");
            d.Add("ReferenceId", "ReferenceId");
            d.Add("referenceId", "ReferenceId");
            d.Add("Version", "Version");
            d.Add("version", "Version");
            d.Add("CreatedBy", "CreatedBy");
            d.Add("createdBy", "CreatedBy");
            d.Add("CreatedAt", "CreatedAt");
            d.Add("createdAt", "CreatedAt");
            d.Add("UpdatedBy", "UpdatedBy");
            d.Add("updatedBy", "UpdatedBy");
            d.Add("UpdatedAt", "UpdatedAt");
            d.Add("updatedAt", "UpdatedAt");
            d.Add("Active", "Active");
            d.Add("active", "Active");
            d.Add("Deleted", "Deleted");
            d.Add("deleted", "Deleted");
            _filteringPropertyAliasDictionary = d;
        }

        static AttributeMetadata()
        {
            InitFilteringPropertyAliasDictionary();
            _propertyMetadataDictionary = new Dictionary<string, PropertyMetadata>();
            foreach (var p in _properties)
            {
                _propertyMetadataDictionary.Add(p.Name, p);
            }
            foreach (var kv in _filteringPropertyAliasDictionary)
            {
                if (_propertyMetadataDictionary.ContainsKey(kv.Value) && !_propertyMetadataDictionary.ContainsKey(kv.Key))
                {
                    var p = _propertyMetadataDictionary[kv.Value];
                    _propertyMetadataDictionary.Add(kv.Key, p);
                }
            }
        }

        private static AttributeMetadata _instance = new AttributeMetadata();

        public static AttributeMetadata Instance
        {
            get
            {
                return _instance;
            }
        }


        public IEnumerable<PropertyMetadata> Properties
        {
            get { return _properties; }
        }

        public IDictionary<string, PropertyMetadata> PropertyMetadataDictionary
        {
            get { return _propertyMetadataDictionary; }
        }

        protected AttributeMetadata()
        { 
        }


    }

}
