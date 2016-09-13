package org.dddml.wms.domain;

import java.util.Date;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractUserLoginMvoCommandDto extends AbstractCommand
{
    private UserLoginIdDto userLoginId;

    public UserLoginIdDto getUserLoginId()
    {
        return this.userLoginId;
    }

    public void setUserLoginId(UserLoginIdDto userLoginId)
    {
        this.userLoginId = userLoginId;
    }

    private Long userVersion;

    public Long getUserVersion()
    {
        return this.userVersion;
    }

    public void setUserVersion(Long userVersion)
    {
        this.userVersion = userVersion;
    }


    public void copyTo(AbstractUserLoginMvoCommand command)
    {
        command.setUserLoginId((this.getUserLoginId() == null) ? null : this.getUserLoginId().toUserLoginId());
        command.setUserVersion(this.getUserVersion());
        
        command.setRequesterId(this.getRequesterId());
        command.setCommandId(this.getCommandId());
    }

}
