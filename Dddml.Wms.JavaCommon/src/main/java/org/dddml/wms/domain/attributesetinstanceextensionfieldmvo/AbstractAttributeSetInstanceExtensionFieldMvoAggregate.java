package org.dddml.wms.domain.attributesetinstanceextensionfieldmvo;

import java.util.*;
import org.dddml.wms.domain.attributesetinstanceextensionfieldgroup.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public abstract class AbstractAttributeSetInstanceExtensionFieldMvoAggregate extends AbstractAggregate implements AttributeSetInstanceExtensionFieldMvoAggregate
{
    private AttributeSetInstanceExtensionFieldMvoState state;

    private List<Event> changes = new ArrayList<Event>();

    public AbstractAttributeSetInstanceExtensionFieldMvoAggregate(AttributeSetInstanceExtensionFieldMvoState state)
    {
        this.state = state;
    }

    public AttributeSetInstanceExtensionFieldMvoState getState() {
        return this.state;
    }

    public List<Event> getChanges() {
        return this.changes;
    }

    public void create(AttributeSetInstanceExtensionFieldMvoCommand.CreateAttributeSetInstanceExtensionFieldMvo c)
    {
        if (c.getAttrSetInstEFGroupVersion() == null) { c.setAttrSetInstEFGroupVersion(AttributeSetInstanceExtensionFieldMvoState.VERSION_NULL); }
        AttributeSetInstanceExtensionFieldMvoStateEvent e = map(c);
        apply(e);
    }

    public void mergePatch(AttributeSetInstanceExtensionFieldMvoCommand.MergePatchAttributeSetInstanceExtensionFieldMvo c)
    {
        AttributeSetInstanceExtensionFieldMvoStateEvent e = map(c);
        apply(e);
    }

    public void delete(AttributeSetInstanceExtensionFieldMvoCommand.DeleteAttributeSetInstanceExtensionFieldMvo c)
    {
        AttributeSetInstanceExtensionFieldMvoStateEvent e = map(c);
        apply(e);
    }

    public void throwOnInvalidStateTransition(Command c)
    {
        if (this.state.getAttrSetInstEFGroupVersion() == null)
        {
            if (isCommandCreate((AttributeSetInstanceExtensionFieldMvoCommand)c))
            {
                return;
            }
            throw DomainError.named("premature", "Can't do anything to unexistent aggregate");
        }
        if (this.state.getDeleted())
        {
            throw DomainError.named("zombie", "Can't do anything to deleted aggregate.");
        }
        if (isCommandCreate((AttributeSetInstanceExtensionFieldMvoCommand)c))
            throw DomainError.named("rebirth", "Can't create aggregate that already exists");
    }

    protected void apply(Event e)
    {
        onApplying(e);
        state.mutate(e);
        changes.add(e);
    }

    protected AttributeSetInstanceExtensionFieldMvoStateEvent map(AttributeSetInstanceExtensionFieldMvoCommand.CreateAttributeSetInstanceExtensionFieldMvo c) {
        AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(c.getAttributeSetInstanceExtensionFieldId(), c.getAttrSetInstEFGroupVersion());
        AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateCreated e = newAttributeSetInstanceExtensionFieldMvoStateCreated(stateEventId);
        e.setName(c.getName());
        e.setType(c.getType());
        e.setLength(c.getLength());
        e.setAlias(c.getAlias());
        e.setDescription(c.getDescription());
        e.setVersion(c.getVersion());
        e.setActive(c.getActive());
        e.setAttrSetInstEFGroupFieldType(c.getAttrSetInstEFGroupFieldType());
        e.setAttrSetInstEFGroupFieldLength(c.getAttrSetInstEFGroupFieldLength());
        e.setAttrSetInstEFGroupFieldCount(c.getAttrSetInstEFGroupFieldCount());
        e.setAttrSetInstEFGroupNameFormat(c.getAttrSetInstEFGroupNameFormat());
        e.setAttrSetInstEFGroupDescription(c.getAttrSetInstEFGroupDescription());
        e.setAttrSetInstEFGroupCreatedBy(c.getAttrSetInstEFGroupCreatedBy());
        e.setAttrSetInstEFGroupCreatedAt(c.getAttrSetInstEFGroupCreatedAt());
        e.setAttrSetInstEFGroupUpdatedBy(c.getAttrSetInstEFGroupUpdatedBy());
        e.setAttrSetInstEFGroupUpdatedAt(c.getAttrSetInstEFGroupUpdatedAt());
        e.setAttrSetInstEFGroupActive(c.getAttrSetInstEFGroupActive());
        e.setAttrSetInstEFGroupDeleted(c.getAttrSetInstEFGroupDeleted());
        ((AbstractAttributeSetInstanceExtensionFieldMvoStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected AttributeSetInstanceExtensionFieldMvoStateEvent map(AttributeSetInstanceExtensionFieldMvoCommand.MergePatchAttributeSetInstanceExtensionFieldMvo c) {
        AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(c.getAttributeSetInstanceExtensionFieldId(), c.getAttrSetInstEFGroupVersion());
        AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateMergePatched e = newAttributeSetInstanceExtensionFieldMvoStateMergePatched(stateEventId);
        e.setName(c.getName());
        e.setType(c.getType());
        e.setLength(c.getLength());
        e.setAlias(c.getAlias());
        e.setDescription(c.getDescription());
        e.setVersion(c.getVersion());
        e.setActive(c.getActive());
        e.setAttrSetInstEFGroupFieldType(c.getAttrSetInstEFGroupFieldType());
        e.setAttrSetInstEFGroupFieldLength(c.getAttrSetInstEFGroupFieldLength());
        e.setAttrSetInstEFGroupFieldCount(c.getAttrSetInstEFGroupFieldCount());
        e.setAttrSetInstEFGroupNameFormat(c.getAttrSetInstEFGroupNameFormat());
        e.setAttrSetInstEFGroupDescription(c.getAttrSetInstEFGroupDescription());
        e.setAttrSetInstEFGroupCreatedBy(c.getAttrSetInstEFGroupCreatedBy());
        e.setAttrSetInstEFGroupCreatedAt(c.getAttrSetInstEFGroupCreatedAt());
        e.setAttrSetInstEFGroupUpdatedBy(c.getAttrSetInstEFGroupUpdatedBy());
        e.setAttrSetInstEFGroupUpdatedAt(c.getAttrSetInstEFGroupUpdatedAt());
        e.setAttrSetInstEFGroupActive(c.getAttrSetInstEFGroupActive());
        e.setAttrSetInstEFGroupDeleted(c.getAttrSetInstEFGroupDeleted());
        e.setIsPropertyNameRemoved(c.getIsPropertyNameRemoved());
        e.setIsPropertyTypeRemoved(c.getIsPropertyTypeRemoved());
        e.setIsPropertyLengthRemoved(c.getIsPropertyLengthRemoved());
        e.setIsPropertyAliasRemoved(c.getIsPropertyAliasRemoved());
        e.setIsPropertyDescriptionRemoved(c.getIsPropertyDescriptionRemoved());
        e.setIsPropertyVersionRemoved(c.getIsPropertyVersionRemoved());
        e.setIsPropertyActiveRemoved(c.getIsPropertyActiveRemoved());
        e.setIsPropertyAttrSetInstEFGroupFieldTypeRemoved(c.getIsPropertyAttrSetInstEFGroupFieldTypeRemoved());
        e.setIsPropertyAttrSetInstEFGroupFieldLengthRemoved(c.getIsPropertyAttrSetInstEFGroupFieldLengthRemoved());
        e.setIsPropertyAttrSetInstEFGroupFieldCountRemoved(c.getIsPropertyAttrSetInstEFGroupFieldCountRemoved());
        e.setIsPropertyAttrSetInstEFGroupNameFormatRemoved(c.getIsPropertyAttrSetInstEFGroupNameFormatRemoved());
        e.setIsPropertyAttrSetInstEFGroupDescriptionRemoved(c.getIsPropertyAttrSetInstEFGroupDescriptionRemoved());
        e.setIsPropertyAttrSetInstEFGroupCreatedByRemoved(c.getIsPropertyAttrSetInstEFGroupCreatedByRemoved());
        e.setIsPropertyAttrSetInstEFGroupCreatedAtRemoved(c.getIsPropertyAttrSetInstEFGroupCreatedAtRemoved());
        e.setIsPropertyAttrSetInstEFGroupUpdatedByRemoved(c.getIsPropertyAttrSetInstEFGroupUpdatedByRemoved());
        e.setIsPropertyAttrSetInstEFGroupUpdatedAtRemoved(c.getIsPropertyAttrSetInstEFGroupUpdatedAtRemoved());
        e.setIsPropertyAttrSetInstEFGroupActiveRemoved(c.getIsPropertyAttrSetInstEFGroupActiveRemoved());
        e.setIsPropertyAttrSetInstEFGroupDeletedRemoved(c.getIsPropertyAttrSetInstEFGroupDeletedRemoved());
        ((AbstractAttributeSetInstanceExtensionFieldMvoStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected AttributeSetInstanceExtensionFieldMvoStateEvent map(AttributeSetInstanceExtensionFieldMvoCommand.DeleteAttributeSetInstanceExtensionFieldMvo c) {
        AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(c.getAttributeSetInstanceExtensionFieldId(), c.getAttrSetInstEFGroupVersion());
        AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateDeleted e = newAttributeSetInstanceExtensionFieldMvoStateDeleted(stateEventId);
        ((AbstractAttributeSetInstanceExtensionFieldMvoStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }


    private static boolean isCommandCreate(AttributeSetInstanceExtensionFieldMvoCommand c)
    {
        return ((c instanceof AttributeSetInstanceExtensionFieldMvoCommand.CreateAttributeSetInstanceExtensionFieldMvo) 
            && c.getAttrSetInstEFGroupVersion().equals(AttributeSetInstanceExtensionFieldMvoState.VERSION_NULL));
    }


    ////////////////////////

    protected AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateCreated newAttributeSetInstanceExtensionFieldMvoStateCreated(String commandId, String requesterId) {
        AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(this.state.getAttributeSetInstanceExtensionFieldId(), this.state.getAttrSetInstEFGroupVersion());
        AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateCreated e = newAttributeSetInstanceExtensionFieldMvoStateCreated(stateEventId);
        ((AbstractAttributeSetInstanceExtensionFieldMvoStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateMergePatched newAttributeSetInstanceExtensionFieldMvoStateMergePatched(String commandId, String requesterId) {
        AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(this.state.getAttributeSetInstanceExtensionFieldId(), this.state.getAttrSetInstEFGroupVersion());
        AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateMergePatched e = newAttributeSetInstanceExtensionFieldMvoStateMergePatched(stateEventId);
        ((AbstractAttributeSetInstanceExtensionFieldMvoStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateDeleted newAttributeSetInstanceExtensionFieldMvoStateDeleted(String commandId, String requesterId) {
        AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(this.state.getAttributeSetInstanceExtensionFieldId(), this.state.getAttrSetInstEFGroupVersion());
        AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateDeleted e = newAttributeSetInstanceExtensionFieldMvoStateDeleted(stateEventId);
        ((AbstractAttributeSetInstanceExtensionFieldMvoStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateCreated newAttributeSetInstanceExtensionFieldMvoStateCreated(AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId) {
        return new AbstractAttributeSetInstanceExtensionFieldMvoStateEvent.SimpleAttributeSetInstanceExtensionFieldMvoStateCreated(stateEventId);
    }

    protected AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateMergePatched newAttributeSetInstanceExtensionFieldMvoStateMergePatched(AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId) {
        return new AbstractAttributeSetInstanceExtensionFieldMvoStateEvent.SimpleAttributeSetInstanceExtensionFieldMvoStateMergePatched(stateEventId);
    }

    protected AttributeSetInstanceExtensionFieldMvoStateEvent.AttributeSetInstanceExtensionFieldMvoStateDeleted newAttributeSetInstanceExtensionFieldMvoStateDeleted(AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId)
    {
        return new AbstractAttributeSetInstanceExtensionFieldMvoStateEvent.SimpleAttributeSetInstanceExtensionFieldMvoStateDeleted(stateEventId);
    }


    public static class SimpleAttributeSetInstanceExtensionFieldMvoAggregate extends AbstractAttributeSetInstanceExtensionFieldMvoAggregate
    {
        public SimpleAttributeSetInstanceExtensionFieldMvoAggregate(AttributeSetInstanceExtensionFieldMvoState state) {
            super(state);
        }

    }

}

