﻿<?php

namespace Dddml\Wms\Domain;

use Dddml\BaseEntity;
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


class User extends BaseEntity
{

    /**
     * @Type("string")
     */
    private $userId;

    /**
     * @return string
     */
    public function getUserId()
    {
        return $this->userId;
    }

    /**
     * @var string $userId
     */
    public function setUserId($userId)
    {
        $this->userId = $userId;
    }

    /**
     * @Type("string")
     */
    private $userName;

    /**
     * @return string
     */
    public function getUserName()
    {
        return $this->userName;
    }

    /**
     * @var string $userName
     */
    public function setUserName($userName)
    {
        $this->userName = $userName;
    }

    /**
     * @Type("integer")
     */
    private $accessFailedCount;

    /**
     * @return integer
     */
    public function getAccessFailedCount()
    {
        return $this->accessFailedCount;
    }

    /**
     * @var integer $accessFailedCount
     */
    public function setAccessFailedCount($accessFailedCount)
    {
        $this->accessFailedCount = $accessFailedCount;
    }

    /**
     * @Type("string")
     */
    private $email;

    /**
     * @return string
     */
    public function getEmail()
    {
        return $this->email;
    }

    /**
     * @var string $email
     */
    public function setEmail($email)
    {
        $this->email = $email;
    }

    /**
     * @Type("boolean")
     */
    private $emailConfirmed;

    /**
     * @return boolean
     */
    public function getEmailConfirmed()
    {
        return $this->emailConfirmed;
    }

    /**
     * @var boolean $emailConfirmed
     */
    public function setEmailConfirmed($emailConfirmed)
    {
        $this->emailConfirmed = $emailConfirmed;
    }

    /**
     * @Type("boolean")
     */
    private $lockoutEnabled;

    /**
     * @return boolean
     */
    public function getLockoutEnabled()
    {
        return $this->lockoutEnabled;
    }

    /**
     * @var boolean $lockoutEnabled
     */
    public function setLockoutEnabled($lockoutEnabled)
    {
        $this->lockoutEnabled = $lockoutEnabled;
    }

    /**
     * @Type("string")
     */
    private $lockoutEndDateUtc;

    /**
     * @return string
     */
    public function getLockoutEndDateUtc()
    {
        return $this->lockoutEndDateUtc;
    }

    /**
     * @var string $lockoutEndDateUtc
     */
    public function setLockoutEndDateUtc($lockoutEndDateUtc)
    {
        $this->lockoutEndDateUtc = $lockoutEndDateUtc;
    }

    /**
     * @Type("string")
     */
    private $passwordHash;

    /**
     * @return string
     */
    public function getPasswordHash()
    {
        return $this->passwordHash;
    }

    /**
     * @var string $passwordHash
     */
    public function setPasswordHash($passwordHash)
    {
        $this->passwordHash = $passwordHash;
    }

    /**
     * @Type("string")
     */
    private $phoneNumber;

    /**
     * @return string
     */
    public function getPhoneNumber()
    {
        return $this->phoneNumber;
    }

    /**
     * @var string $phoneNumber
     */
    public function setPhoneNumber($phoneNumber)
    {
        $this->phoneNumber = $phoneNumber;
    }

    /**
     * @Type("boolean")
     */
    private $phoneNumberConfirmed;

    /**
     * @return boolean
     */
    public function getPhoneNumberConfirmed()
    {
        return $this->phoneNumberConfirmed;
    }

    /**
     * @var boolean $phoneNumberConfirmed
     */
    public function setPhoneNumberConfirmed($phoneNumberConfirmed)
    {
        $this->phoneNumberConfirmed = $phoneNumberConfirmed;
    }

    /**
     * @Type("boolean")
     */
    private $twoFactorEnabled;

    /**
     * @return boolean
     */
    public function getTwoFactorEnabled()
    {
        return $this->twoFactorEnabled;
    }

    /**
     * @var boolean $twoFactorEnabled
     */
    public function setTwoFactorEnabled($twoFactorEnabled)
    {
        $this->twoFactorEnabled = $twoFactorEnabled;
    }

    /**
     * @Type("string")
     */
    private $securityStamp;

    /**
     * @return string
     */
    public function getSecurityStamp()
    {
        return $this->securityStamp;
    }

    /**
     * @var string $securityStamp
     */
    public function setSecurityStamp($securityStamp)
    {
        $this->securityStamp = $securityStamp;
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
    private $userRoles;

    /**
     * @return _UNKNOWN_[]
     */
    public function getUserRoles()
    {
        return $this->userRoles;
    }	

    /**
     * @var _UNKNOWN_[] $userRoles
     */
    public function setUserRoles($userRoles)
    {
        $this->userRoles = $userRoles;
    }

    /**
     * @Type("array<_UNKNOWN_>")
     * @var _UNKNOWN_[]
     */
    private $userClaims;

    /**
     * @return _UNKNOWN_[]
     */
    public function getUserClaims()
    {
        return $this->userClaims;
    }	

    /**
     * @var _UNKNOWN_[] $userClaims
     */
    public function setUserClaims($userClaims)
    {
        $this->userClaims = $userClaims;
    }

    /**
     * @Type("array<_UNKNOWN_>")
     * @var _UNKNOWN_[]
     */
    private $userPermissions;

    /**
     * @return _UNKNOWN_[]
     */
    public function getUserPermissions()
    {
        return $this->userPermissions;
    }	

    /**
     * @var _UNKNOWN_[] $userPermissions
     */
    public function setUserPermissions($userPermissions)
    {
        $this->userPermissions = $userPermissions;
    }

    /**
     * @Type("array<_UNKNOWN_>")
     * @var _UNKNOWN_[]
     */
    private $userLogins;

    /**
     * @return _UNKNOWN_[]
     */
    public function getUserLogins()
    {
        return $this->userLogins;
    }	

    /**
     * @var _UNKNOWN_[] $userLogins
     */
    public function setUserLogins($userLogins)
    {
        $this->userLogins = $userLogins;
    }

}

