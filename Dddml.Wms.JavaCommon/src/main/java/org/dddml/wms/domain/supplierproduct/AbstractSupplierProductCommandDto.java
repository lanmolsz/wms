package org.dddml.wms.domain.supplierproduct;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractSupplierProductCommandDto extends AbstractCommand
{
    private SupplierProductIdDto supplierProductId;

    public SupplierProductIdDto getSupplierProductId()
    {
        return this.supplierProductId;
    }

    public void setSupplierProductId(SupplierProductIdDto supplierProductId)
    {
        this.supplierProductId = supplierProductId;
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


    public void copyTo(AbstractSupplierProductCommand command)
    {
        command.setSupplierProductId((this.getSupplierProductId() == null) ? null : this.getSupplierProductId().toSupplierProductId());
        command.setVersion(this.getVersion());
        
        command.setRequesterId(this.getRequesterId());
        command.setCommandId(this.getCommandId());
    }

}
