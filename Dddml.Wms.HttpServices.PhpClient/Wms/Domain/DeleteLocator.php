<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Dddml\Serializer\Type\Long;
use Wms\Domain\CommandTrait;

class DeleteLocator extends AbstractLocatorCommand
{

    /**
     * @return string
     */
    public function getCommandType()
    {
        return 'Delete';
    }


}

