package org.dddml.wms.domain;

import java.util.Date;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractRolePermissionCommandDto extends AbstractCommand
{
    private RolePermissionIdDto id;

    public RolePermissionIdDto getId()
    {
        return this.id;
    }

    public void setId(RolePermissionIdDto id)
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


    public void copyTo(AbstractRolePermissionCommand command)
    {
        command.setId((this.getId() == null) ? null : this.getId().toRolePermissionId());
        command.setVersion(this.getVersion());
        
        command.setRequesterId(this.getRequesterId());
        command.setCommandId(this.getCommandId());
    }

}
