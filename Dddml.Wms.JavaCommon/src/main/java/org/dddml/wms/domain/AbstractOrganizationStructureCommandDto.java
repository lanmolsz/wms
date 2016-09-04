package org.dddml.wms.domain;

import java.util.Date;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractOrganizationStructureCommandDto extends AbstractCommand
{
    private OrganizationStructureIdDto id;

    public OrganizationStructureIdDto getId()
    {
        return this.id;
    }

    public void setId(OrganizationStructureIdDto id)
    {
        this.id = id;
    }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }


    public void copyTo(AbstractOrganizationStructureCommand command)
    {
        command.setId((this.getId() == null) ? null : this.getId().toOrganizationStructureId());
        command.setVersion(this.getVersion());
    }

}

