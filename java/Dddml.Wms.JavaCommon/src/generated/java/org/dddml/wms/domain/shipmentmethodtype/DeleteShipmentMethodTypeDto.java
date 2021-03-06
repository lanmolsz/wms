package org.dddml.wms.domain.shipmentmethodtype;


public class DeleteShipmentMethodTypeDto extends AbstractShipmentMethodTypeCommandDto
{

    @Override
    public String getCommandType() {
        return COMMAND_TYPE_DELETE;
    }

    public ShipmentMethodTypeCommand.DeleteShipmentMethodType toDeleteShipmentMethodType()
    {
        AbstractShipmentMethodTypeCommand.SimpleDeleteShipmentMethodType command = new AbstractShipmentMethodTypeCommand.SimpleDeleteShipmentMethodType();
        ((AbstractShipmentMethodTypeCommandDto)this).copyTo(command);
        return command;
    }
}

