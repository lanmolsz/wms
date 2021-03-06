<?php

namespace Dddml\Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Dddml\Serializer\Type\Long;

class Attribute
{

    use AttributeStatePropertiesTrait;

    /**
     * @Type("array<Dddml\Wms\Domain\AttributeValue>")
     * @var AttributeValue[]
     */
    private $attributeValues;

    /**
     * @return AttributeValue[]
     */
    public function getAttributeValues()
    {
        return $this->attributeValues;
    }	

    /**
     * @param AttributeValue[] $attributeValues
     */
    public function setAttributeValues($attributeValues)
    {
        $this->attributeValues = $attributeValues;
    }


}

