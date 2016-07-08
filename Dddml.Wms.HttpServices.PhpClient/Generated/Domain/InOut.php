﻿<?php

namespace Dddml\Wms\Domain;

use Dddml\BaseEntity;
use JMS\Serializer\Annotation\Type;
use Dddml\Wms\Domain\SkuId;
use Dddml\Wms\Domain\DocumentAction;
use Dddml\Wms\Domain\OrganizationStructureId;
use Dddml\Wms\Domain\RolePermissionId;
use Dddml\Wms\Domain\InOutLine;
use Dddml\Wms\Domain\InOutLineId;
use NodaMoney\Money;


class InOut extends BaseEntity
{

    /**
     * @Type("string")
     */
    private $documentNumber;

    /**
     * @return string
     */
    public function getDocumentNumber()
    {
        return $this->documentNumber;
    }

    /**
     * @var string $documentNumber
     */
    public function setDocumentNumber($documentNumber)
    {
        $this->documentNumber = $documentNumber;
    }

    /**
     * @Type("boolean")
     */
    private $isSoTransaction;

    /**
     * @return boolean
     */
    public function getIsSoTransaction()
    {
        return $this->isSoTransaction;
    }

    /**
     * @var boolean $isSoTransaction
     */
    public function setIsSoTransaction($isSoTransaction)
    {
        $this->isSoTransaction = $isSoTransaction;
    }

    /**
     * @Type("string")
     */
    private $documentStatus;

    /**
     * @return string
     */
    public function getDocumentStatus()
    {
        return $this->documentStatus;
    }

    /**
     * @var string $documentStatus
     */
    public function setDocumentStatus($documentStatus)
    {
        $this->documentStatus = $documentStatus;
    }

    /**
     * @Type("boolean")
     */
    private $posted;

    /**
     * @return boolean
     */
    public function getPosted()
    {
        return $this->posted;
    }

    /**
     * @var boolean $posted
     */
    public function setPosted($posted)
    {
        $this->posted = $posted;
    }

    /**
     * @Type("boolean")
     */
    private $processing;

    /**
     * @return boolean
     */
    public function getProcessing()
    {
        return $this->processing;
    }

    /**
     * @var boolean $processing
     */
    public function setProcessing($processing)
    {
        $this->processing = $processing;
    }

    /**
     * @Type("boolean")
     */
    private $processed;

    /**
     * @return boolean
     */
    public function getProcessed()
    {
        return $this->processed;
    }

    /**
     * @var boolean $processed
     */
    public function setProcessed($processed)
    {
        $this->processed = $processed;
    }

    /**
     * @Type("integer")
     */
    private $documentType;

    /**
     * @return integer
     */
    public function getDocumentType()
    {
        return $this->documentType;
    }

    /**
     * @var integer $documentType
     */
    public function setDocumentType($documentType)
    {
        $this->documentType = $documentType;
    }

    /**
     * @Type("string")
     */
    private $description;

    /**
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * @var string $description
     */
    public function setDescription($description)
    {
        $this->description = $description;
    }

    /**
     * @Type("string")
     */
    private $orderNumber;

    /**
     * @return string
     */
    public function getOrderNumber()
    {
        return $this->orderNumber;
    }

    /**
     * @var string $orderNumber
     */
    public function setOrderNumber($orderNumber)
    {
        $this->orderNumber = $orderNumber;
    }

    /**
     * @Type("string")
     */
    private $dateOrdered;

    /**
     * @return string
     */
    public function getDateOrdered()
    {
        return $this->dateOrdered;
    }

    /**
     * @var string $dateOrdered
     */
    public function setDateOrdered($dateOrdered)
    {
        $this->dateOrdered = $dateOrdered;
    }

    /**
     * @Type("boolean")
     */
    private $isPrinted;

    /**
     * @return boolean
     */
    public function getIsPrinted()
    {
        return $this->isPrinted;
    }

    /**
     * @var boolean $isPrinted
     */
    public function setIsPrinted($isPrinted)
    {
        $this->isPrinted = $isPrinted;
    }

    /**
     * @Type("string")
     */
    private $movementType;

    /**
     * @return string
     */
    public function getMovementType()
    {
        return $this->movementType;
    }

    /**
     * @var string $movementType
     */
    public function setMovementType($movementType)
    {
        $this->movementType = $movementType;
    }

    /**
     * @Type("string")
     */
    private $movementDate;

    /**
     * @return string
     */
    public function getMovementDate()
    {
        return $this->movementDate;
    }

    /**
     * @var string $movementDate
     */
    public function setMovementDate($movementDate)
    {
        $this->movementDate = $movementDate;
    }

    /**
     * @Type("string")
     */
    private $businessPartnerId;

    /**
     * @return string
     */
    public function getBusinessPartnerId()
    {
        return $this->businessPartnerId;
    }

    /**
     * @var string $businessPartnerId
     */
    public function setBusinessPartnerId($businessPartnerId)
    {
        $this->businessPartnerId = $businessPartnerId;
    }

    /**
     * @Type("string")
     */
    private $warehouseId;

    /**
     * @return string
     */
    public function getWarehouseId()
    {
        return $this->warehouseId;
    }

    /**
     * @var string $warehouseId
     */
    public function setWarehouseId($warehouseId)
    {
        $this->warehouseId = $warehouseId;
    }

    /**
     * @Type("string")
     */
    private $poReference;

    /**
     * @return string
     */
    public function getPoReference()
    {
        return $this->poReference;
    }

    /**
     * @var string $poReference
     */
    public function setPoReference($poReference)
    {
        $this->poReference = $poReference;
    }

    /**
     * @Type("_UNKNOWN_")
     */
    private $freightAmount;

    /**
     * @return _UNKNOWN_
     */
    public function getFreightAmount()
    {
        return $this->freightAmount;
    }

    /**
     * @var _UNKNOWN_ $freightAmount
     */
    public function setFreightAmount($freightAmount)
    {
        $this->freightAmount = $freightAmount;
    }

    /**
     * @Type("string")
     */
    private $shipperId;

    /**
     * @return string
     */
    public function getShipperId()
    {
        return $this->shipperId;
    }

    /**
     * @var string $shipperId
     */
    public function setShipperId($shipperId)
    {
        $this->shipperId = $shipperId;
    }

    /**
     * @Type("_UNKNOWN_")
     */
    private $chargeAmount;

    /**
     * @return _UNKNOWN_
     */
    public function getChargeAmount()
    {
        return $this->chargeAmount;
    }

    /**
     * @var _UNKNOWN_ $chargeAmount
     */
    public function setChargeAmount($chargeAmount)
    {
        $this->chargeAmount = $chargeAmount;
    }

    /**
     * @Type("string")
     */
    private $datePrinted;

    /**
     * @return string
     */
    public function getDatePrinted()
    {
        return $this->datePrinted;
    }

    /**
     * @var string $datePrinted
     */
    public function setDatePrinted($datePrinted)
    {
        $this->datePrinted = $datePrinted;
    }

    /**
     * @Type("string")
     */
    private $salesRepresentative;

    /**
     * @return string
     */
    public function getSalesRepresentative()
    {
        return $this->salesRepresentative;
    }

    /**
     * @var string $salesRepresentative
     */
    public function setSalesRepresentative($salesRepresentative)
    {
        $this->salesRepresentative = $salesRepresentative;
    }

    /**
     * @Type("integer")
     */
    private $numberOfPackages;

    /**
     * @return integer
     */
    public function getNumberOfPackages()
    {
        return $this->numberOfPackages;
    }

    /**
     * @var integer $numberOfPackages
     */
    public function setNumberOfPackages($numberOfPackages)
    {
        $this->numberOfPackages = $numberOfPackages;
    }

    /**
     * @Type("string")
     */
    private $pickDate;

    /**
     * @return string
     */
    public function getPickDate()
    {
        return $this->pickDate;
    }

    /**
     * @var string $pickDate
     */
    public function setPickDate($pickDate)
    {
        $this->pickDate = $pickDate;
    }

    /**
     * @Type("string")
     */
    private $shipDate;

    /**
     * @return string
     */
    public function getShipDate()
    {
        return $this->shipDate;
    }

    /**
     * @var string $shipDate
     */
    public function setShipDate($shipDate)
    {
        $this->shipDate = $shipDate;
    }

    /**
     * @Type("string")
     */
    private $trackingNumber;

    /**
     * @return string
     */
    public function getTrackingNumber()
    {
        return $this->trackingNumber;
    }

    /**
     * @var string $trackingNumber
     */
    public function setTrackingNumber($trackingNumber)
    {
        $this->trackingNumber = $trackingNumber;
    }

    /**
     * @Type("string")
     */
    private $dateReceived;

    /**
     * @return string
     */
    public function getDateReceived()
    {
        return $this->dateReceived;
    }

    /**
     * @var string $dateReceived
     */
    public function setDateReceived($dateReceived)
    {
        $this->dateReceived = $dateReceived;
    }

    /**
     * @Type("boolean")
     */
    private $isInTransit;

    /**
     * @return boolean
     */
    public function getIsInTransit()
    {
        return $this->isInTransit;
    }

    /**
     * @var boolean $isInTransit
     */
    public function setIsInTransit($isInTransit)
    {
        $this->isInTransit = $isInTransit;
    }

    /**
     * @Type("boolean")
     */
    private $isApproved;

    /**
     * @return boolean
     */
    public function getIsApproved()
    {
        return $this->isApproved;
    }

    /**
     * @var boolean $isApproved
     */
    public function setIsApproved($isApproved)
    {
        $this->isApproved = $isApproved;
    }

    /**
     * @Type("boolean")
     */
    private $isInDispute;

    /**
     * @return boolean
     */
    public function getIsInDispute()
    {
        return $this->isInDispute;
    }

    /**
     * @var boolean $isInDispute
     */
    public function setIsInDispute($isInDispute)
    {
        $this->isInDispute = $isInDispute;
    }

    /**
     * @Type("double")
     */
    private $volume;

    /**
     * @return double
     */
    public function getVolume()
    {
        return $this->volume;
    }

    /**
     * @var double $volume
     */
    public function setVolume($volume)
    {
        $this->volume = $volume;
    }

    /**
     * @Type("double")
     */
    private $weight;

    /**
     * @return double
     */
    public function getWeight()
    {
        return $this->weight;
    }

    /**
     * @var double $weight
     */
    public function setWeight($weight)
    {
        $this->weight = $weight;
    }

    /**
     * @Type("string")
     */
    private $rmaNumber;

    /**
     * @return string
     */
    public function getRmaNumber()
    {
        return $this->rmaNumber;
    }

    /**
     * @var string $rmaNumber
     */
    public function setRmaNumber($rmaNumber)
    {
        $this->rmaNumber = $rmaNumber;
    }

    /**
     * @Type("string")
     */
    private $reversalNumber;

    /**
     * @return string
     */
    public function getReversalNumber()
    {
        return $this->reversalNumber;
    }

    /**
     * @var string $reversalNumber
     */
    public function setReversalNumber($reversalNumber)
    {
        $this->reversalNumber = $reversalNumber;
    }

    /**
     * @Type("boolean")
     */
    private $isDropShip;

    /**
     * @return boolean
     */
    public function getIsDropShip()
    {
        return $this->isDropShip;
    }

    /**
     * @var boolean $isDropShip
     */
    public function setIsDropShip($isDropShip)
    {
        $this->isDropShip = $isDropShip;
    }

    /**
     * @Type("string")
     */
    private $dropShipBusinessPartnerId;

    /**
     * @return string
     */
    public function getDropShipBusinessPartnerId()
    {
        return $this->dropShipBusinessPartnerId;
    }

    /**
     * @var string $dropShipBusinessPartnerId
     */
    public function setDropShipBusinessPartnerId($dropShipBusinessPartnerId)
    {
        $this->dropShipBusinessPartnerId = $dropShipBusinessPartnerId;
    }

    /**
     * @Type("boolean")
     */
    private $active;

    /**
     * @return boolean
     */
    public function getActive()
    {
        return $this->active;
    }

    /**
     * @var boolean $active
     */
    public function setActive($active)
    {
        $this->active = $active;
    }

    /**
     * @Type("integer")
     */
    private $version;

    /**
     * @return integer
     */
    public function getVersion()
    {
        return $this->version;
    }

    /**
     * @var integer $version
     */
    public function setVersion($version)
    {
        $this->version = $version;
    }

    /**
     * @Type("string")
     */
    private $createdBy;

    /**
     * @return string
     */
    public function getCreatedBy()
    {
        return $this->createdBy;
    }

    /**
     * @var string $createdBy
     */
    public function setCreatedBy($createdBy)
    {
        $this->createdBy = $createdBy;
    }

    /**
     * @Type("string")
     */
    private $createdAt;

    /**
     * @return string
     */
    public function getCreatedAt()
    {
        return $this->createdAt;
    }

    /**
     * @var string $createdAt
     */
    public function setCreatedAt($createdAt)
    {
        $this->createdAt = $createdAt;
    }

    /**
     * @Type("string")
     */
    private $updatedBy;

    /**
     * @return string
     */
    public function getUpdatedBy()
    {
        return $this->updatedBy;
    }

    /**
     * @var string $updatedBy
     */
    public function setUpdatedBy($updatedBy)
    {
        $this->updatedBy = $updatedBy;
    }

    /**
     * @Type("string")
     */
    private $updatedAt;

    /**
     * @return string
     */
    public function getUpdatedAt()
    {
        return $this->updatedAt;
    }

    /**
     * @var string $updatedAt
     */
    public function setUpdatedAt($updatedAt)
    {
        $this->updatedAt = $updatedAt;
    }

    /**
     * @Type("array<_UNKNOWN_>")
     * @var _UNKNOWN_[]
     */
    private $inOutLines;

    /**
     * @return _UNKNOWN_[]
     */
    public function getInOutLines()
    {
        return $this->inOutLines;
    }	

    /**
     * @var _UNKNOWN_[] $inOutLines
     */
    public function setInOutLines($inOutLines)
    {
        $this->inOutLines = $inOutLines;
    }

}

