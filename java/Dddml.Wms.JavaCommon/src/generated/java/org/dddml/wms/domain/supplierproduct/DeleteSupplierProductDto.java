package org.dddml.wms.domain.supplierproduct;


public class DeleteSupplierProductDto extends AbstractSupplierProductCommandDto
{

    @Override
    public String getCommandType() {
        return COMMAND_TYPE_DELETE;
    }

    public SupplierProductCommand.DeleteSupplierProduct toDeleteSupplierProduct()
    {
        AbstractSupplierProductCommand.SimpleDeleteSupplierProduct command = new AbstractSupplierProductCommand.SimpleDeleteSupplierProduct();
        ((AbstractSupplierProductCommandDto)this).copyTo(command);
        return command;
    }
}

