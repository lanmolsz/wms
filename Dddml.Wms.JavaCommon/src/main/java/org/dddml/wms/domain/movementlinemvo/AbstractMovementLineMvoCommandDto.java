package org.dddml.wms.domain.movementlinemvo;

import org.dddml.wms.domain.movement.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractMovementLineMvoCommandDto extends AbstractCommand
{
    private MovementLineIdDto movementLineId;

    public MovementLineIdDto getMovementLineId()
    {
        return this.movementLineId;
    }

    public void setMovementLineId(MovementLineIdDto movementLineId)
    {
        this.movementLineId = movementLineId;
    }

    private Long movementVersion;

    public Long getMovementVersion()
    {
        return this.movementVersion;
    }

    public void setMovementVersion(Long movementVersion)
    {
        this.movementVersion = movementVersion;
    }


    public void copyTo(AbstractMovementLineMvoCommand command)
    {
        command.setMovementLineId((this.getMovementLineId() == null) ? null : this.getMovementLineId().toMovementLineId());
        command.setMovementVersion(this.getMovementVersion());
        
        command.setRequesterId(this.getRequesterId());
        command.setCommandId(this.getCommandId());
    }

}
