package org.dddml.wms.domain.attribute;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;

public abstract class AbstractAttributeValueStateCommandConverter<TCreateAttributeValue extends AttributeValueCommand.CreateAttributeValue, TMergePatchAttributeValue extends AttributeValueCommand.MergePatchAttributeValue, TRemoveAttributeValue extends AttributeValueCommand.RemoveAttributeValue>
{
    public AttributeValueCommand toCreateOrMergePatchAttributeValue(AttributeValueState state)
    {
        //where TCreateAttributeValue : ICreateAttributeValue, new()
        //where TMergePatchAttributeValue : IMergePatchAttributeValue, new()
        boolean bUnsaved = state.isStateUnsaved();
        if (bUnsaved)
        {
            return toCreateAttributeValue(state);
        }
        else 
        {
            return toMergePatchAttributeValue(state);
        }
    }

    public TRemoveAttributeValue toRemoveAttributeValue(AttributeValueState state) //where TRemoveAttributeValue : IRemoveAttributeValue, new()
    {
        TRemoveAttributeValue cmd = newRemoveAttributeValue();
        cmd.setValue(state.getValue());
        return cmd;
    }

    public TMergePatchAttributeValue toMergePatchAttributeValue(AttributeValueState state) //where TMergePatchAttributeValue : IMergePatchAttributeValue, new()
    {
        TMergePatchAttributeValue cmd = newMergePatchAttributeValue();

        cmd.setValue(state.getValue());
        cmd.setAttributeValueName(state.getAttributeValueName());
        cmd.setDescription(state.getDescription());
        cmd.setReferenceId(state.getReferenceId());
        cmd.setActive(state.getActive());
        cmd.setAttributeId(state.getAttributeId());
            
        if (state.getAttributeValueName() == null) { cmd.setIsPropertyAttributeValueNameRemoved(true); }
        if (state.getDescription() == null) { cmd.setIsPropertyDescriptionRemoved(true); }
        if (state.getReferenceId() == null) { cmd.setIsPropertyReferenceIdRemoved(true); }
        if (state.getActive() == null) { cmd.setIsPropertyActiveRemoved(true); }
        return cmd;
    }

    public TCreateAttributeValue toCreateAttributeValue(AttributeValueState state) //where TCreateAttributeValue : ICreateAttributeValue, new()
    {
        TCreateAttributeValue cmd = newCreateAttributeValue();

        cmd.setValue(state.getValue());
        cmd.setAttributeValueName(state.getAttributeValueName());
        cmd.setDescription(state.getDescription());
        cmd.setReferenceId(state.getReferenceId());
        cmd.setActive(state.getActive());
        cmd.setAttributeId(state.getAttributeId());
        return cmd;
    }

    protected abstract TCreateAttributeValue newCreateAttributeValue();

    protected abstract TMergePatchAttributeValue newMergePatchAttributeValue(); 

    protected abstract TRemoveAttributeValue newRemoveAttributeValue();

    public static class SimpleAttributeValueStateCommandConverter extends AbstractAttributeValueStateCommandConverter<AbstractAttributeValueCommand.SimpleCreateAttributeValue, AbstractAttributeValueCommand.SimpleMergePatchAttributeValue, AbstractAttributeValueCommand.SimpleRemoveAttributeValue>
    {
        @Override
        protected AbstractAttributeValueCommand.SimpleCreateAttributeValue newCreateAttributeValue() {
            return new AbstractAttributeValueCommand.SimpleCreateAttributeValue();
        }

        @Override
        protected AbstractAttributeValueCommand.SimpleMergePatchAttributeValue newMergePatchAttributeValue() {
            return new AbstractAttributeValueCommand.SimpleMergePatchAttributeValue();
        }

        @Override
        protected AbstractAttributeValueCommand.SimpleRemoveAttributeValue newRemoveAttributeValue() {
            return new AbstractAttributeValueCommand.SimpleRemoveAttributeValue();
        }


    }

}

