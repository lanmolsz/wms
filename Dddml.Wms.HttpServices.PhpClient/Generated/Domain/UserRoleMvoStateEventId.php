﻿<?php

namespace Dddml\Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Dddml\Wms\Domain\SkuId;
use Dddml\Wms\Domain\DocumentAction;
use Dddml\Wms\Domain\OrganizationStructureId;
use Dddml\Wms\Domain\RolePermissionId;
use Dddml\Wms\Domain\UserRole;
use Dddml\Wms\Domain\UserClaim;
use Dddml\Wms\Domain\UserPermission;
use Dddml\Wms\Domain\UserLogin;
use Dddml\Wms\Domain\LoginKey;
use Dddml\Wms\Domain\UserRoleId;
use Dddml\Wms\Domain\UserClaimId;
use Dddml\Wms\Domain\UserPermissionId;
use Dddml\Wms\Domain\UserLoginId;

class UserRoleMvoStateEventId
{
    /**
     * @Type("_UNKNOWN_")
     */
    private $userRoleId;

    /**
     * @return _UNKNOWN_
     */
    public function getUserRoleId()
    {
        return $this->userRoleId;
    }

    /**
     * @var _UNKNOWN_ $userRoleId
     */
    public function setUserRoleId($userRoleId)
    {
        $this->userRoleId = $userRoleId;
    }

    /**
     * @Type("integer")
     */
    private $userVersion;

    /**
     * @return integer
     */
    public function getUserVersion()
    {
        return $this->userVersion;
    }

    /**
     * @var integer $userVersion
     */
    public function setUserVersion($userVersion)
    {
        $this->userVersion = $userVersion;
    }

}

