﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDomainMetadata.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.Metadata
{

    public class MovementMetadata
    {
        private static PropertyMetadata[] _properties = new PropertyMetadata[]{
                new PropertyMetadata {
                    Name = "DocumentNumber",
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
                    Name = "DocumentTypeId",
                    Type = typeof(string),
                    TypeName = "string",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "DocumentType",
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
                    Name = "DocumentStatusId",
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
                    Name = "MovementTypeId",
                    Type = typeof(string),
                    TypeName = "string",
                    IsSimpleValueObjectType = true,
                    IsNullableType = false,
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "MovementType",
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
                    Name = "MovementLines",
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "MovementLine",
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
                    Name = "MovementConfirmationLines",
                    DisplayName = "",
                    Description = "",
                    Length = 0,
                    GenericTypeName = "",
                    ReferenceTypeName = "",
                    ReferenceName = "",
                    ItemTypeName = "MovementConfirmationLine",
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
            d.Add("DocumentNumber", "DocumentNumber");
            d.Add("documentNumber", "DocumentNumber");
            d.Add("DocumentTypeId", "DocumentTypeId");
            d.Add("documentTypeId", "DocumentTypeId");
            d.Add("DocumentStatusId", "DocumentStatusId");
            d.Add("documentStatusId", "DocumentStatusId");
            d.Add("MovementTypeId", "MovementTypeId");
            d.Add("movementTypeId", "MovementTypeId");
            d.Add("Description", "Description");
            d.Add("description", "Description");
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

        static MovementMetadata()
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

        private static MovementMetadata _instance = new MovementMetadata();

        public static MovementMetadata Instance
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

        protected MovementMetadata()
        { 
        }


    }

}
