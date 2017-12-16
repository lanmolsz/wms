﻿CREATE VIEW `AttributeValue_RV` AS
    SELECT 
        `AttributeValues`.`AttributeValueIdAttributeId`,
        `AttributeValues`.`AttributeValueIdValue`,
        `AttributeValues`.`AttributeValueName`,
        `AttributeValues`.`Description`,
        `AttributeValues`.`ReferenceId`,
        `AttributeValues`.`Version`,
        `AttributeValues`.`CreatedBy`,
        `AttributeValues`.`CreatedAt`,
        `AttributeValues`.`UpdatedBy`,
        `AttributeValues`.`UpdatedAt`,
        `AttributeValues`.`Active`,
        `AttributeValues`.`Deleted`,
        `Attributes`.`AttributeName` AS `AttributeAttributeName`,
        `Attributes`.`OrganizationId` AS `AttributeOrganizationId`,
        `Attributes`.`Description` AS `AttributeDescription`,
        `Attributes`.`IsMandatory` AS `AttributeIsMandatory`,
        `Attributes`.`IsInstanceAttribute` AS `AttributeIsInstanceAttribute`,
        `Attributes`.`AttributeValueType` AS `AttributeAttributeValueType`,
        `Attributes`.`AttributeValueLength` AS `AttributeAttributeValueLength`,
        `Attributes`.`IsList` AS `AttributeIsList`,
        `Attributes`.`FieldName` AS `AttributeFieldName`,
        `Attributes`.`ReferenceId` AS `AttributeReferenceId`,
        `Attributes`.`Version` AS `AttributeVersion`,
        `Attributes`.`CreatedBy` AS `AttributeCreatedBy`,
        `Attributes`.`CreatedAt` AS `AttributeCreatedAt`,
        `Attributes`.`UpdatedBy` AS `AttributeUpdatedBy`,
        `Attributes`.`UpdatedAt` AS `AttributeUpdatedAt`,
        `Attributes`.`Active` AS `AttributeActive`,
        `Attributes`.`Deleted` AS `AttributeDeleted`
    FROM
        (`AttributeValues`
            JOIN `Attributes` ON ( 1=1 
                and (`AttributeValues`.`AttributeValueIdAttributeId` = `Attributes`.`AttributeId`)
            )
        );


CREATE VIEW `AttributeUse_RV` AS
    SELECT 
        `AttributeUses`.`AttributeSetAttributeUseIdAttributeSetId`,
        `AttributeUses`.`AttributeSetAttributeUseIdAttributeId`,
        `AttributeUses`.`SequenceNumber`,
        `AttributeUses`.`Version`,
        `AttributeUses`.`CreatedBy`,
        `AttributeUses`.`CreatedAt`,
        `AttributeUses`.`UpdatedBy`,
        `AttributeUses`.`UpdatedAt`,
        `AttributeUses`.`Active`,
        `AttributeUses`.`Deleted`,
        `AttributeSets`.`AttributeSetName` AS `AttributeSetAttributeSetName`,
        `AttributeSets`.`OrganizationId` AS `AttributeSetOrganizationId`,
        `AttributeSets`.`Description` AS `AttributeSetDescription`,
        `AttributeSets`.`SerialNumberAttributeId` AS `AttributeSetSerialNumberAttributeId`,
        `AttributeSets`.`LotAttributeId` AS `AttributeSetLotAttributeId`,
        `AttributeSets`.`ReferenceId` AS `AttributeSetReferenceId`,
        `AttributeSets`.`Version` AS `AttributeSetVersion`,
        `AttributeSets`.`CreatedBy` AS `AttributeSetCreatedBy`,
        `AttributeSets`.`CreatedAt` AS `AttributeSetCreatedAt`,
        `AttributeSets`.`UpdatedBy` AS `AttributeSetUpdatedBy`,
        `AttributeSets`.`UpdatedAt` AS `AttributeSetUpdatedAt`,
        `AttributeSets`.`Active` AS `AttributeSetActive`,
        `AttributeSets`.`Deleted` AS `AttributeSetDeleted`
    FROM
        (`AttributeUses`
            JOIN `AttributeSets` ON ( 1=1 
                and (`AttributeUses`.`AttributeSetAttributeUseIdAttributeSetId` = `AttributeSets`.`AttributeSetId`)
            )
        );


CREATE VIEW `InOutLine_RV` AS
    SELECT 
        `InOutLines`.`InOutLineIdInOutDocumentNumber`,
        `InOutLines`.`InOutLineIdLineNumber`,
        `InOutLines`.`LocatorId`,
        `InOutLines`.`ProductId`,
        `InOutLines`.`AttributeSetInstanceId`,
        `InOutLines`.`Description`,
        `InOutLines`.`UomId`,
        `InOutLines`.`MovementQuantity`,
        `InOutLines`.`ConfirmedQuantity`,
        `InOutLines`.`ScrappedQuantity`,
        `InOutLines`.`TargetQuantity`,
        `InOutLines`.`PickedQuantity`,
        `InOutLines`.`IsInvoiced`,
        `InOutLines`.`Processed`,
        `InOutLines`.`QuantityEntered`,
        `InOutLines`.`RmaLineNumber`,
        `InOutLines`.`ReversalLineNumber`,
        `InOutLines`.`Version`,
        `InOutLines`.`CreatedBy`,
        `InOutLines`.`CreatedAt`,
        `InOutLines`.`UpdatedBy`,
        `InOutLines`.`UpdatedAt`,
        `InOutLines`.`Active`,
        `InOutLines`.`Deleted`,
        `InOuts`.`DocumentStatus` AS `InOutDocumentStatus`,
        `InOuts`.`Posted` AS `InOutPosted`,
        `InOuts`.`Processing` AS `InOutProcessing`,
        `InOuts`.`Processed` AS `InOutProcessed`,
        `InOuts`.`DocumentTypeId` AS `InOutDocumentTypeId`,
        `InOuts`.`Description` AS `InOutDescription`,
        `InOuts`.`OrderId` AS `InOutOrderId`,
        `InOuts`.`DateOrdered` AS `InOutDateOrdered`,
        `InOuts`.`IsPrinted` AS `InOutIsPrinted`,
        `InOuts`.`MovementTypeId` AS `InOutMovementTypeId`,
        `InOuts`.`MovementDate` AS `InOutMovementDate`,
        `InOuts`.`BusinessPartnerId` AS `InOutBusinessPartnerId`,
        `InOuts`.`WarehouseId` AS `InOutWarehouseId`,
        `InOuts`.`POReference` AS `InOutPOReference`,
        `InOuts`.`ShipperId` AS `InOutShipperId`,
        `InOuts`.`DatePrinted` AS `InOutDatePrinted`,
        `InOuts`.`SalesRepresentative` AS `InOutSalesRepresentative`,
        `InOuts`.`NumberOfPackages` AS `InOutNumberOfPackages`,
        `InOuts`.`PickDate` AS `InOutPickDate`,
        `InOuts`.`ShipDate` AS `InOutShipDate`,
        `InOuts`.`TrackingNumber` AS `InOutTrackingNumber`,
        `InOuts`.`DateReceived` AS `InOutDateReceived`,
        `InOuts`.`IsInTransit` AS `InOutIsInTransit`,
        `InOuts`.`IsApproved` AS `InOutIsApproved`,
        `InOuts`.`IsInDispute` AS `InOutIsInDispute`,
        `InOuts`.`RmaNumber` AS `InOutRmaNumber`,
        `InOuts`.`ReversalNumber` AS `InOutReversalNumber`,
        `InOuts`.`Version` AS `InOutVersion`,
        `InOuts`.`CreatedBy` AS `InOutCreatedBy`,
        `InOuts`.`CreatedAt` AS `InOutCreatedAt`,
        `InOuts`.`UpdatedBy` AS `InOutUpdatedBy`,
        `InOuts`.`UpdatedAt` AS `InOutUpdatedAt`,
        `InOuts`.`Active` AS `InOutActive`,
        `InOuts`.`Deleted` AS `InOutDeleted`
    FROM
        (`InOutLines`
            JOIN `InOuts` ON ( 1=1 
                and (`InOutLines`.`InOutLineIdInOutDocumentNumber` = `InOuts`.`DocumentNumber`)
            )
        );


CREATE VIEW `InventoryItemEntry_RV` AS
    SELECT 
        `InventoryItemEntries`.`ProductId`,
        `InventoryItemEntries`.`LocatorId`,
        `InventoryItemEntries`.`AttributeSetInstanceId`,
        `InventoryItemEntries`.`EntrySeqId`,
        `InventoryItemEntries`.`QuantityOnHand`,
        `InventoryItemEntries`.`QuantityReserved`,
        `InventoryItemEntries`.`QuantityOccupied`,
        `InventoryItemEntries`.`QuantityVirtual`,
        `InventoryItemEntries`.`SourceDocumentTypeId`,
        `InventoryItemEntries`.`SourceDocumentNumber`,
        `InventoryItemEntries`.`SourceLineNumber`,
        `InventoryItemEntries`.`Version`,
        `InventoryItemEntries`.`CreatedBy`,
        `InventoryItemEntries`.`CreatedAt`,
        `InventoryItemEntries`.`UpdatedBy`,
        `InventoryItemEntries`.`UpdatedAt`,
        `InventoryItems`.`QuantityOnHand` AS `InventoryItemQuantityOnHand`,
        `InventoryItems`.`QuantityReserved` AS `InventoryItemQuantityReserved`,
        `InventoryItems`.`QuantityOccupied` AS `InventoryItemQuantityOccupied`,
        `InventoryItems`.`QuantityVirtual` AS `InventoryItemQuantityVirtual`,
        `InventoryItems`.`Version` AS `InventoryItemVersion`,
        `InventoryItems`.`CreatedBy` AS `InventoryItemCreatedBy`,
        `InventoryItems`.`CreatedAt` AS `InventoryItemCreatedAt`,
        `InventoryItems`.`UpdatedBy` AS `InventoryItemUpdatedBy`,
        `InventoryItems`.`UpdatedAt` AS `InventoryItemUpdatedAt`
    FROM
        (`InventoryItemEntries`
            JOIN `InventoryItems` ON ( 1=1 
                and (`InventoryItemEntries`.`ProductId` = `InventoryItems`.`ProductId`)
                and (`InventoryItemEntries`.`LocatorId` = `InventoryItems`.`LocatorId`)
                and (`InventoryItemEntries`.`AttributeSetInstanceId` = `InventoryItems`.`AttributeSetInstanceId`)
            )
        );


CREATE VIEW `SellableInventoryItemEntry_RV` AS
    SELECT 
        `SellableInventoryItemEntries`.`ProductId`,
        `SellableInventoryItemEntries`.`LocatorId`,
        `SellableInventoryItemEntries`.`AttributeSetInstanceId`,
        `SellableInventoryItemEntries`.`EntrySeqId`,
        `SellableInventoryItemEntries`.`QuantitySellable`,
        `SellableInventoryItemEntries`.`SrcEventProductId`,
        `SellableInventoryItemEntries`.`SrcEventLocatorId`,
        `SellableInventoryItemEntries`.`SrcEventAttributeSetInstanceId`,
        `SellableInventoryItemEntries`.`SrcEventEntrySeqId`,
        `SellableInventoryItemEntries`.`SrcEventInventoryPostingRuleId`,
        `SellableInventoryItemEntries`.`Version`,
        `SellableInventoryItemEntries`.`CreatedBy`,
        `SellableInventoryItemEntries`.`CreatedAt`,
        `SellableInventoryItemEntries`.`UpdatedBy`,
        `SellableInventoryItemEntries`.`UpdatedAt`,
        `SellableInventoryItems`.`QuantitySellable` AS `SellableInventoryItemQuantitySellable`,
        `SellableInventoryItems`.`Version` AS `SellableInventoryItemVersion`,
        `SellableInventoryItems`.`CreatedBy` AS `SellableInventoryItemCreatedBy`,
        `SellableInventoryItems`.`CreatedAt` AS `SellableInventoryItemCreatedAt`,
        `SellableInventoryItems`.`UpdatedBy` AS `SellableInventoryItemUpdatedBy`,
        `SellableInventoryItems`.`UpdatedAt` AS `SellableInventoryItemUpdatedAt`
    FROM
        (`SellableInventoryItemEntries`
            JOIN `SellableInventoryItems` ON ( 1=1 
                and (`SellableInventoryItemEntries`.`ProductId` = `SellableInventoryItems`.`ProductId`)
                and (`SellableInventoryItemEntries`.`LocatorId` = `SellableInventoryItems`.`LocatorId`)
                and (`SellableInventoryItemEntries`.`AttributeSetInstanceId` = `SellableInventoryItems`.`AttributeSetInstanceId`)
            )
        );


CREATE VIEW `AttributeSetInstanceExtensionField_RV` AS
    SELECT 
        `AttributeSetInstanceExtensionFields`.`AttributeSetInstanceExtensionFieldIdGroupId`,
        `AttributeSetInstanceExtensionFields`.`AttributeSetInstanceExtensionFieldIdIndex`,
        `AttributeSetInstanceExtensionFields`.`Name`,
        `AttributeSetInstanceExtensionFields`.`Type`,
        `AttributeSetInstanceExtensionFields`.`Length`,
        `AttributeSetInstanceExtensionFields`.`Alias`,
        `AttributeSetInstanceExtensionFields`.`Description`,
        `AttributeSetInstanceExtensionFields`.`Version`,
        `AttributeSetInstanceExtensionFields`.`CreatedBy`,
        `AttributeSetInstanceExtensionFields`.`CreatedAt`,
        `AttributeSetInstanceExtensionFields`.`UpdatedBy`,
        `AttributeSetInstanceExtensionFields`.`UpdatedAt`,
        `AttributeSetInstanceExtensionFields`.`Active`,
        `AttributeSetInstanceExtensionFields`.`Deleted`,
        `AttributeSetInstanceExtensionFieldGroups`.`FieldType` AS `AttrSetInstEFGroupFieldType`,
        `AttributeSetInstanceExtensionFieldGroups`.`FieldLength` AS `AttrSetInstEFGroupFieldLength`,
        `AttributeSetInstanceExtensionFieldGroups`.`FieldCount` AS `AttrSetInstEFGroupFieldCount`,
        `AttributeSetInstanceExtensionFieldGroups`.`NameFormat` AS `AttrSetInstEFGroupNameFormat`,
        `AttributeSetInstanceExtensionFieldGroups`.`Description` AS `AttrSetInstEFGroupDescription`,
        `AttributeSetInstanceExtensionFieldGroups`.`Version` AS `AttrSetInstEFGroupVersion`,
        `AttributeSetInstanceExtensionFieldGroups`.`CreatedBy` AS `AttrSetInstEFGroupCreatedBy`,
        `AttributeSetInstanceExtensionFieldGroups`.`CreatedAt` AS `AttrSetInstEFGroupCreatedAt`,
        `AttributeSetInstanceExtensionFieldGroups`.`UpdatedBy` AS `AttrSetInstEFGroupUpdatedBy`,
        `AttributeSetInstanceExtensionFieldGroups`.`UpdatedAt` AS `AttrSetInstEFGroupUpdatedAt`,
        `AttributeSetInstanceExtensionFieldGroups`.`Active` AS `AttrSetInstEFGroupActive`,
        `AttributeSetInstanceExtensionFieldGroups`.`Deleted` AS `AttrSetInstEFGroupDeleted`
    FROM
        (`AttributeSetInstanceExtensionFields`
            JOIN `AttributeSetInstanceExtensionFieldGroups` ON ( 1=1 
                and (`AttributeSetInstanceExtensionFields`.`AttributeSetInstanceExtensionFieldIdGroupId` = `AttributeSetInstanceExtensionFieldGroups`.`Id`)
            )
        );


