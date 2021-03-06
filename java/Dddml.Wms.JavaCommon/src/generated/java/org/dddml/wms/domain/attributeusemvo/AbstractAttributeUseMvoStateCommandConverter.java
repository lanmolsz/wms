package org.dddml.wms.domain.attributeusemvo;

import java.util.*;
import org.dddml.wms.domain.attributeset.*;
import java.util.Date;
import org.dddml.wms.domain.*;

public abstract class AbstractAttributeUseMvoStateCommandConverter<TCreateAttributeUseMvo extends AttributeUseMvoCommand.CreateAttributeUseMvo, TMergePatchAttributeUseMvo extends AttributeUseMvoCommand.MergePatchAttributeUseMvo, TDeleteAttributeUseMvo extends AttributeUseMvoCommand.DeleteAttributeUseMvo>
{
    public AttributeUseMvoCommand toCreateOrMergePatchAttributeUseMvo(AttributeUseMvoState state)
    {
        //where TCreateAttributeUseMvo : ICreateAttributeUseMvo, new()
        //where TMergePatchAttributeUseMvo : IMergePatchAttributeUseMvo, new()
        boolean bUnsaved = state.isStateUnsaved();
        if (bUnsaved)
        {
            return toCreateAttributeUseMvo(state);
        }
        else 
        {
            return toMergePatchAttributeUseMvo(state);
        }
    }

    public TDeleteAttributeUseMvo toDeleteAttributeUseMvo(AttributeUseMvoState state) //where TDeleteAttributeUseMvo : IDeleteAttributeUseMvo, new()
    {
        TDeleteAttributeUseMvo cmd = newDeleteAttributeUseMvo();
        cmd.setAttributeSetAttributeUseId(state.getAttributeSetAttributeUseId());
        cmd.setAttributeSetVersion(state.getAttributeSetVersion());

        return cmd;
    }

    public TMergePatchAttributeUseMvo toMergePatchAttributeUseMvo(AttributeUseMvoState state) //where TMergePatchAttributeUseMvo : IMergePatchAttributeUseMvo, new()
    {
        TMergePatchAttributeUseMvo cmd = newMergePatchAttributeUseMvo();

        cmd.setAttributeSetVersion(state.getAttributeSetVersion());

        cmd.setAttributeSetAttributeUseId(state.getAttributeSetAttributeUseId());
        cmd.setSequenceNumber(state.getSequenceNumber());
        cmd.setVersion(state.getVersion());
        cmd.setActive(state.getActive());
        cmd.setAttributeSetAttributeSetName(state.getAttributeSetAttributeSetName());
        cmd.setAttributeSetOrganizationId(state.getAttributeSetOrganizationId());
        cmd.setAttributeSetDescription(state.getAttributeSetDescription());
        cmd.setAttributeSetReferenceId(state.getAttributeSetReferenceId());
        cmd.setAttributeSetIsInstanceAttributeSet(state.getAttributeSetIsInstanceAttributeSet());
        cmd.setAttributeSetIsMandatory(state.getAttributeSetIsMandatory());
        cmd.setAttributeSetCreatedBy(state.getAttributeSetCreatedBy());
        cmd.setAttributeSetCreatedAt(state.getAttributeSetCreatedAt());
        cmd.setAttributeSetUpdatedBy(state.getAttributeSetUpdatedBy());
        cmd.setAttributeSetUpdatedAt(state.getAttributeSetUpdatedAt());
        cmd.setAttributeSetActive(state.getAttributeSetActive());
        cmd.setAttributeSetDeleted(state.getAttributeSetDeleted());
            
        if (state.getSequenceNumber() == null) { cmd.setIsPropertySequenceNumberRemoved(true); }
        if (state.getVersion() == null) { cmd.setIsPropertyVersionRemoved(true); }
        if (state.getActive() == null) { cmd.setIsPropertyActiveRemoved(true); }
        if (state.getAttributeSetAttributeSetName() == null) { cmd.setIsPropertyAttributeSetAttributeSetNameRemoved(true); }
        if (state.getAttributeSetOrganizationId() == null) { cmd.setIsPropertyAttributeSetOrganizationIdRemoved(true); }
        if (state.getAttributeSetDescription() == null) { cmd.setIsPropertyAttributeSetDescriptionRemoved(true); }
        if (state.getAttributeSetReferenceId() == null) { cmd.setIsPropertyAttributeSetReferenceIdRemoved(true); }
        if (state.getAttributeSetIsInstanceAttributeSet() == null) { cmd.setIsPropertyAttributeSetIsInstanceAttributeSetRemoved(true); }
        if (state.getAttributeSetIsMandatory() == null) { cmd.setIsPropertyAttributeSetIsMandatoryRemoved(true); }
        if (state.getAttributeSetCreatedBy() == null) { cmd.setIsPropertyAttributeSetCreatedByRemoved(true); }
        if (state.getAttributeSetCreatedAt() == null) { cmd.setIsPropertyAttributeSetCreatedAtRemoved(true); }
        if (state.getAttributeSetUpdatedBy() == null) { cmd.setIsPropertyAttributeSetUpdatedByRemoved(true); }
        if (state.getAttributeSetUpdatedAt() == null) { cmd.setIsPropertyAttributeSetUpdatedAtRemoved(true); }
        if (state.getAttributeSetActive() == null) { cmd.setIsPropertyAttributeSetActiveRemoved(true); }
        if (state.getAttributeSetDeleted() == null) { cmd.setIsPropertyAttributeSetDeletedRemoved(true); }
        return cmd;
    }

    public TCreateAttributeUseMvo toCreateAttributeUseMvo(AttributeUseMvoState state) //where TCreateAttributeUseMvo : ICreateAttributeUseMvo, new()
    {
        TCreateAttributeUseMvo cmd = newCreateAttributeUseMvo();

        cmd.setAttributeSetVersion(state.getAttributeSetVersion());
        cmd.setAttributeSetAttributeUseId(state.getAttributeSetAttributeUseId());
        cmd.setSequenceNumber(state.getSequenceNumber());
        cmd.setVersion(state.getVersion());
        cmd.setActive(state.getActive());
        cmd.setAttributeSetAttributeSetName(state.getAttributeSetAttributeSetName());
        cmd.setAttributeSetOrganizationId(state.getAttributeSetOrganizationId());
        cmd.setAttributeSetDescription(state.getAttributeSetDescription());
        cmd.setAttributeSetReferenceId(state.getAttributeSetReferenceId());
        cmd.setAttributeSetIsInstanceAttributeSet(state.getAttributeSetIsInstanceAttributeSet());
        cmd.setAttributeSetIsMandatory(state.getAttributeSetIsMandatory());
        cmd.setAttributeSetCreatedBy(state.getAttributeSetCreatedBy());
        cmd.setAttributeSetCreatedAt(state.getAttributeSetCreatedAt());
        cmd.setAttributeSetUpdatedBy(state.getAttributeSetUpdatedBy());
        cmd.setAttributeSetUpdatedAt(state.getAttributeSetUpdatedAt());
        cmd.setAttributeSetActive(state.getAttributeSetActive());
        cmd.setAttributeSetDeleted(state.getAttributeSetDeleted());
        return cmd;
    }

    protected abstract TCreateAttributeUseMvo newCreateAttributeUseMvo();

    protected abstract TMergePatchAttributeUseMvo newMergePatchAttributeUseMvo(); 

    protected abstract TDeleteAttributeUseMvo newDeleteAttributeUseMvo();

    public static class SimpleAttributeUseMvoStateCommandConverter extends AbstractAttributeUseMvoStateCommandConverter<AbstractAttributeUseMvoCommand.SimpleCreateAttributeUseMvo, AbstractAttributeUseMvoCommand.SimpleMergePatchAttributeUseMvo, AbstractAttributeUseMvoCommand.SimpleDeleteAttributeUseMvo>
    {
        @Override
        protected AbstractAttributeUseMvoCommand.SimpleCreateAttributeUseMvo newCreateAttributeUseMvo() {
            return new AbstractAttributeUseMvoCommand.SimpleCreateAttributeUseMvo();
        }

        @Override
        protected AbstractAttributeUseMvoCommand.SimpleMergePatchAttributeUseMvo newMergePatchAttributeUseMvo() {
            return new AbstractAttributeUseMvoCommand.SimpleMergePatchAttributeUseMvo();
        }

        @Override
        protected AbstractAttributeUseMvoCommand.SimpleDeleteAttributeUseMvo newDeleteAttributeUseMvo() {
            return new AbstractAttributeUseMvoCommand.SimpleDeleteAttributeUseMvo();
        }


    }

}

