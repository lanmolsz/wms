﻿<?php

namespace Dddml\Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Dddml\Wms\Domain\SkuId;
use Dddml\Wms\Domain\DocumentAction;
use Dddml\Wms\Domain\OrganizationStructureId;
use Dddml\Wms\Domain\RolePermissionId;
use Dddml\Wms\Domain\AttributeValue;
use Dddml\Wms\Domain\AttributeValueId;

class AttributeValueStateEventId
{
    /**
     * @Type("string")
     */
    private $attributeId;

    /**
     * @return string
     */
    public function getAttributeId()
    {
        return $this->attributeId;
    }

    /**
     * @var string $attributeId
     */
    public function setAttributeId($attributeId)
    {
        $this->attributeId = $attributeId;
    }

    /**
     * @Type("string")
     */
    private $value;

    /**
     * @return string
     */
    public function getValue()
    {
        return $this->value;
    }

    /**
     * @var string $value
     */
    public function setValue($value)
    {
        $this->value = $value;
    }

    /**
     * @Type("integer")
     */
    private $attributeVersion;

    /**
     * @return integer
     */
    public function getAttributeVersion()
    {
        return $this->attributeVersion;
    }

    /**
     * @var integer $attributeVersion
     */
    public function setAttributeVersion($attributeVersion)
    {
        $this->attributeVersion = $attributeVersion;
    }

}

