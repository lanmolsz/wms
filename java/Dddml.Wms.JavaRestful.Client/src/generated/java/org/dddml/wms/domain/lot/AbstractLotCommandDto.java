package org.dddml.wms.domain.lot;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractLotCommandDto extends AbstractCommand
{
    private String lotId;

    public String getLotId()
    {
        return this.lotId;
    }

    public void setLotId(String lotId)
    {
        this.lotId = lotId;
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


}
