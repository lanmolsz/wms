<?php

namespace Dddml\Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Dddml\Serializer\Type\Long;
use Dddml\Wms\Domain\CommandTrait;

class CreateOrMergePatchDayPlanMvo extends AbstractDayPlanMvoCommand
{

    use DayPlanMvoIsPropertyRemovedTrait;

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
     * @param string $description
     */
    public function setDescription($description)
    {
        $this->description = $description;
    }

    /**
     * @Type("Dddml\Serializer\Type\Long")
     */
    private $version;

    /**
     * @return Long
     */
    public function getVersion()
    {
        return $this->version;
    }

    /**
     * @param Long $version
     */
    public function setVersion($version)
    {
        $this->version = $version;
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
     * @param boolean $active
     */
    public function setActive($active)
    {
        $this->active = $active;
    }

    /**
     * @Type("string")
     */
    private $monthPlanDescription;

    /**
     * @return string
     */
    public function getMonthPlanDescription()
    {
        return $this->monthPlanDescription;
    }

    /**
     * @param string $monthPlanDescription
     */
    public function setMonthPlanDescription($monthPlanDescription)
    {
        $this->monthPlanDescription = $monthPlanDescription;
    }

    /**
     * @Type("string")
     */
    private $monthPlanCreatedBy;

    /**
     * @return string
     */
    public function getMonthPlanCreatedBy()
    {
        return $this->monthPlanCreatedBy;
    }

    /**
     * @param string $monthPlanCreatedBy
     */
    public function setMonthPlanCreatedBy($monthPlanCreatedBy)
    {
        $this->monthPlanCreatedBy = $monthPlanCreatedBy;
    }

    /**
     * @Type("string")
     */
    private $monthPlanUpdatedBy;

    /**
     * @return string
     */
    public function getMonthPlanUpdatedBy()
    {
        return $this->monthPlanUpdatedBy;
    }

    /**
     * @param string $monthPlanUpdatedBy
     */
    public function setMonthPlanUpdatedBy($monthPlanUpdatedBy)
    {
        $this->monthPlanUpdatedBy = $monthPlanUpdatedBy;
    }

    /**
     * @Type("Dddml\Serializer\Type\Long")
     */
    private $monthPlanVersion;

    /**
     * @return Long
     */
    public function getMonthPlanVersion()
    {
        return $this->monthPlanVersion;
    }

    /**
     * @param Long $monthPlanVersion
     */
    public function setMonthPlanVersion($monthPlanVersion)
    {
        $this->monthPlanVersion = $monthPlanVersion;
    }

    /**
     * @Type("DateTime")
     */
    private $monthPlanCreatedAt;

    /**
     * @return \DateTime
     */
    public function getMonthPlanCreatedAt()
    {
        return $this->monthPlanCreatedAt;
    }

    /**
     * @param \DateTime $monthPlanCreatedAt
     */
    public function setMonthPlanCreatedAt($monthPlanCreatedAt)
    {
        $this->monthPlanCreatedAt = $monthPlanCreatedAt;
    }

    /**
     * @Type("DateTime")
     */
    private $monthPlanUpdatedAt;

    /**
     * @return \DateTime
     */
    public function getMonthPlanUpdatedAt()
    {
        return $this->monthPlanUpdatedAt;
    }

    /**
     * @param \DateTime $monthPlanUpdatedAt
     */
    public function setMonthPlanUpdatedAt($monthPlanUpdatedAt)
    {
        $this->monthPlanUpdatedAt = $monthPlanUpdatedAt;
    }

    /**
     * @Type("boolean")
     */
    private $monthPlanActive;

    /**
     * @return boolean
     */
    public function getMonthPlanActive()
    {
        return $this->monthPlanActive;
    }

    /**
     * @param boolean $monthPlanActive
     */
    public function setMonthPlanActive($monthPlanActive)
    {
        $this->monthPlanActive = $monthPlanActive;
    }

    /**
     * @Type("boolean")
     */
    private $monthPlanDeleted;

    /**
     * @return boolean
     */
    public function getMonthPlanDeleted()
    {
        return $this->monthPlanDeleted;
    }

    /**
     * @param boolean $monthPlanDeleted
     */
    public function setMonthPlanDeleted($monthPlanDeleted)
    {
        $this->monthPlanDeleted = $monthPlanDeleted;
    }

    /**
     * @Type("string")
     */
    private $yearPlanDescription;

    /**
     * @return string
     */
    public function getYearPlanDescription()
    {
        return $this->yearPlanDescription;
    }

    /**
     * @param string $yearPlanDescription
     */
    public function setYearPlanDescription($yearPlanDescription)
    {
        $this->yearPlanDescription = $yearPlanDescription;
    }

    /**
     * @Type("string")
     */
    private $yearPlanCreatedBy;

    /**
     * @return string
     */
    public function getYearPlanCreatedBy()
    {
        return $this->yearPlanCreatedBy;
    }

    /**
     * @param string $yearPlanCreatedBy
     */
    public function setYearPlanCreatedBy($yearPlanCreatedBy)
    {
        $this->yearPlanCreatedBy = $yearPlanCreatedBy;
    }

    /**
     * @Type("string")
     */
    private $yearPlanUpdatedBy;

    /**
     * @return string
     */
    public function getYearPlanUpdatedBy()
    {
        return $this->yearPlanUpdatedBy;
    }

    /**
     * @param string $yearPlanUpdatedBy
     */
    public function setYearPlanUpdatedBy($yearPlanUpdatedBy)
    {
        $this->yearPlanUpdatedBy = $yearPlanUpdatedBy;
    }

    /**
     * @Type("Dddml\Serializer\Type\Long")
     */
    private $yearPlanVersion;

    /**
     * @return Long
     */
    public function getYearPlanVersion()
    {
        return $this->yearPlanVersion;
    }

    /**
     * @param Long $yearPlanVersion
     */
    public function setYearPlanVersion($yearPlanVersion)
    {
        $this->yearPlanVersion = $yearPlanVersion;
    }

    /**
     * @Type("DateTime")
     */
    private $yearPlanCreatedAt;

    /**
     * @return \DateTime
     */
    public function getYearPlanCreatedAt()
    {
        return $this->yearPlanCreatedAt;
    }

    /**
     * @param \DateTime $yearPlanCreatedAt
     */
    public function setYearPlanCreatedAt($yearPlanCreatedAt)
    {
        $this->yearPlanCreatedAt = $yearPlanCreatedAt;
    }

    /**
     * @Type("DateTime")
     */
    private $yearPlanUpdatedAt;

    /**
     * @return \DateTime
     */
    public function getYearPlanUpdatedAt()
    {
        return $this->yearPlanUpdatedAt;
    }

    /**
     * @param \DateTime $yearPlanUpdatedAt
     */
    public function setYearPlanUpdatedAt($yearPlanUpdatedAt)
    {
        $this->yearPlanUpdatedAt = $yearPlanUpdatedAt;
    }

    /**
     * @Type("boolean")
     */
    private $yearPlanActive;

    /**
     * @return boolean
     */
    public function getYearPlanActive()
    {
        return $this->yearPlanActive;
    }

    /**
     * @param boolean $yearPlanActive
     */
    public function setYearPlanActive($yearPlanActive)
    {
        $this->yearPlanActive = $yearPlanActive;
    }

    /**
     * @Type("boolean")
     */
    private $yearPlanDeleted;

    /**
     * @return boolean
     */
    public function getYearPlanDeleted()
    {
        return $this->yearPlanDeleted;
    }

    /**
     * @param boolean $yearPlanDeleted
     */
    public function setYearPlanDeleted($yearPlanDeleted)
    {
        $this->yearPlanDeleted = $yearPlanDeleted;
    }

    /**
     * @Type("DateTime")
     */
    private $personBirthDate;

    /**
     * @return \DateTime
     */
    public function getPersonBirthDate()
    {
        return $this->personBirthDate;
    }

    /**
     * @param \DateTime $personBirthDate
     */
    public function setPersonBirthDate($personBirthDate)
    {
        $this->personBirthDate = $personBirthDate;
    }

    /**
     * @Type("Dddml\Wms\Domain\PersonalName")
     */
    private $personLoves;

    /**
     * @return PersonalName
     */
    public function getPersonLoves()
    {
        return $this->personLoves;
    }

    /**
     * @param PersonalName $personLoves
     */
    public function setPersonLoves($personLoves)
    {
        $this->personLoves = $personLoves;
    }

    /**
     * @Type("Dddml\Wms\Domain\Contact")
     */
    private $personEmergencyContact;

    /**
     * @return Contact
     */
    public function getPersonEmergencyContact()
    {
        return $this->personEmergencyContact;
    }

    /**
     * @param Contact $personEmergencyContact
     */
    public function setPersonEmergencyContact($personEmergencyContact)
    {
        $this->personEmergencyContact = $personEmergencyContact;
    }

    /**
     * @Type("string")
     */
    private $personEmail;

    /**
     * @return string
     */
    public function getPersonEmail()
    {
        return $this->personEmail;
    }

    /**
     * @param string $personEmail
     */
    public function setPersonEmail($personEmail)
    {
        $this->personEmail = $personEmail;
    }

    /**
     * @Type("string")
     */
    private $personCreatedBy;

    /**
     * @return string
     */
    public function getPersonCreatedBy()
    {
        return $this->personCreatedBy;
    }

    /**
     * @param string $personCreatedBy
     */
    public function setPersonCreatedBy($personCreatedBy)
    {
        $this->personCreatedBy = $personCreatedBy;
    }

    /**
     * @Type("string")
     */
    private $personUpdatedBy;

    /**
     * @return string
     */
    public function getPersonUpdatedBy()
    {
        return $this->personUpdatedBy;
    }

    /**
     * @param string $personUpdatedBy
     */
    public function setPersonUpdatedBy($personUpdatedBy)
    {
        $this->personUpdatedBy = $personUpdatedBy;
    }

    /**
     * @Type("DateTime")
     */
    private $personCreatedAt;

    /**
     * @return \DateTime
     */
    public function getPersonCreatedAt()
    {
        return $this->personCreatedAt;
    }

    /**
     * @param \DateTime $personCreatedAt
     */
    public function setPersonCreatedAt($personCreatedAt)
    {
        $this->personCreatedAt = $personCreatedAt;
    }

    /**
     * @Type("DateTime")
     */
    private $personUpdatedAt;

    /**
     * @return \DateTime
     */
    public function getPersonUpdatedAt()
    {
        return $this->personUpdatedAt;
    }

    /**
     * @param \DateTime $personUpdatedAt
     */
    public function setPersonUpdatedAt($personUpdatedAt)
    {
        $this->personUpdatedAt = $personUpdatedAt;
    }

    /**
     * @Type("boolean")
     */
    private $personActive;

    /**
     * @return boolean
     */
    public function getPersonActive()
    {
        return $this->personActive;
    }

    /**
     * @param boolean $personActive
     */
    public function setPersonActive($personActive)
    {
        $this->personActive = $personActive;
    }

    /**
     * @Type("boolean")
     */
    private $personDeleted;

    /**
     * @return boolean
     */
    public function getPersonDeleted()
    {
        return $this->personDeleted;
    }

    /**
     * @param boolean $personDeleted
     */
    public function setPersonDeleted($personDeleted)
    {
        $this->personDeleted = $personDeleted;
    }


}

