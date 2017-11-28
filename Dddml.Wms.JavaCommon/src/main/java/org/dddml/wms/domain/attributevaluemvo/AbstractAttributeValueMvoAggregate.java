package org.dddml.wms.domain.attributevaluemvo;

import java.util.*;
import org.dddml.wms.domain.attribute.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public abstract class AbstractAttributeValueMvoAggregate extends AbstractAggregate implements AttributeValueMvoAggregate
{
    private AttributeValueMvoState state;

    private List<Event> changes = new ArrayList<Event>();

    public AbstractAttributeValueMvoAggregate(AttributeValueMvoState state)
    {
        this.state = state;
    }

    public AttributeValueMvoState getState() {
        return this.state;
    }

    public List<Event> getChanges() {
        return this.changes;
    }

    public void create(AttributeValueMvoCommand.CreateAttributeValueMvo c)
    {
        if (c.getAttributeVersion() == null) { c.setAttributeVersion(AttributeValueMvoState.VERSION_NULL); }
        AttributeValueMvoStateEvent e = map(c);
        apply(e);
    }

    public void mergePatch(AttributeValueMvoCommand.MergePatchAttributeValueMvo c)
    {
        AttributeValueMvoStateEvent e = map(c);
        apply(e);
    }

    public void delete(AttributeValueMvoCommand.DeleteAttributeValueMvo c)
    {
        AttributeValueMvoStateEvent e = map(c);
        apply(e);
    }

    public void throwOnInvalidStateTransition(Command c)
    {
        if (this.state.getAttributeVersion() == null)
        {
            if (isCommandCreate((AttributeValueMvoCommand)c))
            {
                return;
            }
            throw DomainError.named("premature", "Can't do anything to unexistent aggregate");
        }
        if (this.state.getDeleted())
        {
            throw DomainError.named("zombie", "Can't do anything to deleted aggregate.");
        }
        if (isCommandCreate((AttributeValueMvoCommand)c))
            throw DomainError.named("rebirth", "Can't create aggregate that already exists");
    }

    protected void apply(Event e)
    {
        onApplying(e);
        state.mutate(e);
        changes.add(e);
    }

    protected AttributeValueMvoStateEvent map(AttributeValueMvoCommand.CreateAttributeValueMvo c) {
        AttributeValueMvoStateEventId stateEventId = new AttributeValueMvoStateEventId(c.getAttributeValueId(), c.getAttributeVersion());
        AttributeValueMvoStateEvent.AttributeValueMvoStateCreated e = newAttributeValueMvoStateCreated(stateEventId);
        e.setName(c.getName());
        e.setDescription(c.getDescription());
        e.setReferenceId(c.getReferenceId());
        e.setVersion(c.getVersion());
        e.setActive(c.getActive());
        e.setAttributeName(c.getAttributeName());
        e.setAttributeOrganizationId(c.getAttributeOrganizationId());
        e.setAttributeDescription(c.getAttributeDescription());
        e.setAttributeIsMandatory(c.getAttributeIsMandatory());
        e.setAttributeIsInstanceAttribute(c.getAttributeIsInstanceAttribute());
        e.setAttributeAttributeValueType(c.getAttributeAttributeValueType());
        e.setAttributeAttributeValueLength(c.getAttributeAttributeValueLength());
        e.setAttributeIsList(c.getAttributeIsList());
        e.setAttributeFieldName(c.getAttributeFieldName());
        e.setAttributeReferenceId(c.getAttributeReferenceId());
        e.setAttributeCreatedBy(c.getAttributeCreatedBy());
        e.setAttributeCreatedAt(c.getAttributeCreatedAt());
        e.setAttributeUpdatedBy(c.getAttributeUpdatedBy());
        e.setAttributeUpdatedAt(c.getAttributeUpdatedAt());
        e.setAttributeActive(c.getAttributeActive());
        e.setAttributeDeleted(c.getAttributeDeleted());
        ((AbstractAttributeValueMvoStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected AttributeValueMvoStateEvent map(AttributeValueMvoCommand.MergePatchAttributeValueMvo c) {
        AttributeValueMvoStateEventId stateEventId = new AttributeValueMvoStateEventId(c.getAttributeValueId(), c.getAttributeVersion());
        AttributeValueMvoStateEvent.AttributeValueMvoStateMergePatched e = newAttributeValueMvoStateMergePatched(stateEventId);
        e.setName(c.getName());
        e.setDescription(c.getDescription());
        e.setReferenceId(c.getReferenceId());
        e.setVersion(c.getVersion());
        e.setActive(c.getActive());
        e.setAttributeName(c.getAttributeName());
        e.setAttributeOrganizationId(c.getAttributeOrganizationId());
        e.setAttributeDescription(c.getAttributeDescription());
        e.setAttributeIsMandatory(c.getAttributeIsMandatory());
        e.setAttributeIsInstanceAttribute(c.getAttributeIsInstanceAttribute());
        e.setAttributeAttributeValueType(c.getAttributeAttributeValueType());
        e.setAttributeAttributeValueLength(c.getAttributeAttributeValueLength());
        e.setAttributeIsList(c.getAttributeIsList());
        e.setAttributeFieldName(c.getAttributeFieldName());
        e.setAttributeReferenceId(c.getAttributeReferenceId());
        e.setAttributeCreatedBy(c.getAttributeCreatedBy());
        e.setAttributeCreatedAt(c.getAttributeCreatedAt());
        e.setAttributeUpdatedBy(c.getAttributeUpdatedBy());
        e.setAttributeUpdatedAt(c.getAttributeUpdatedAt());
        e.setAttributeActive(c.getAttributeActive());
        e.setAttributeDeleted(c.getAttributeDeleted());
        e.setIsPropertyNameRemoved(c.getIsPropertyNameRemoved());
        e.setIsPropertyDescriptionRemoved(c.getIsPropertyDescriptionRemoved());
        e.setIsPropertyReferenceIdRemoved(c.getIsPropertyReferenceIdRemoved());
        e.setIsPropertyVersionRemoved(c.getIsPropertyVersionRemoved());
        e.setIsPropertyActiveRemoved(c.getIsPropertyActiveRemoved());
        e.setIsPropertyAttributeNameRemoved(c.getIsPropertyAttributeNameRemoved());
        e.setIsPropertyAttributeOrganizationIdRemoved(c.getIsPropertyAttributeOrganizationIdRemoved());
        e.setIsPropertyAttributeDescriptionRemoved(c.getIsPropertyAttributeDescriptionRemoved());
        e.setIsPropertyAttributeIsMandatoryRemoved(c.getIsPropertyAttributeIsMandatoryRemoved());
        e.setIsPropertyAttributeIsInstanceAttributeRemoved(c.getIsPropertyAttributeIsInstanceAttributeRemoved());
        e.setIsPropertyAttributeAttributeValueTypeRemoved(c.getIsPropertyAttributeAttributeValueTypeRemoved());
        e.setIsPropertyAttributeAttributeValueLengthRemoved(c.getIsPropertyAttributeAttributeValueLengthRemoved());
        e.setIsPropertyAttributeIsListRemoved(c.getIsPropertyAttributeIsListRemoved());
        e.setIsPropertyAttributeFieldNameRemoved(c.getIsPropertyAttributeFieldNameRemoved());
        e.setIsPropertyAttributeReferenceIdRemoved(c.getIsPropertyAttributeReferenceIdRemoved());
        e.setIsPropertyAttributeCreatedByRemoved(c.getIsPropertyAttributeCreatedByRemoved());
        e.setIsPropertyAttributeCreatedAtRemoved(c.getIsPropertyAttributeCreatedAtRemoved());
        e.setIsPropertyAttributeUpdatedByRemoved(c.getIsPropertyAttributeUpdatedByRemoved());
        e.setIsPropertyAttributeUpdatedAtRemoved(c.getIsPropertyAttributeUpdatedAtRemoved());
        e.setIsPropertyAttributeActiveRemoved(c.getIsPropertyAttributeActiveRemoved());
        e.setIsPropertyAttributeDeletedRemoved(c.getIsPropertyAttributeDeletedRemoved());
        ((AbstractAttributeValueMvoStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected AttributeValueMvoStateEvent map(AttributeValueMvoCommand.DeleteAttributeValueMvo c) {
        AttributeValueMvoStateEventId stateEventId = new AttributeValueMvoStateEventId(c.getAttributeValueId(), c.getAttributeVersion());
        AttributeValueMvoStateEvent.AttributeValueMvoStateDeleted e = newAttributeValueMvoStateDeleted(stateEventId);
        ((AbstractAttributeValueMvoStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }


    private static boolean isCommandCreate(AttributeValueMvoCommand c)
    {
        return ((c instanceof AttributeValueMvoCommand.CreateAttributeValueMvo) 
            && c.getAttributeVersion().equals(AttributeValueMvoState.VERSION_NULL));
    }


    ////////////////////////

    protected AttributeValueMvoStateEvent.AttributeValueMvoStateCreated newAttributeValueMvoStateCreated(String commandId, String requesterId) {
        AttributeValueMvoStateEventId stateEventId = new AttributeValueMvoStateEventId(this.state.getAttributeValueId(), this.state.getAttributeVersion());
        AttributeValueMvoStateEvent.AttributeValueMvoStateCreated e = newAttributeValueMvoStateCreated(stateEventId);
        ((AbstractAttributeValueMvoStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected AttributeValueMvoStateEvent.AttributeValueMvoStateMergePatched newAttributeValueMvoStateMergePatched(String commandId, String requesterId) {
        AttributeValueMvoStateEventId stateEventId = new AttributeValueMvoStateEventId(this.state.getAttributeValueId(), this.state.getAttributeVersion());
        AttributeValueMvoStateEvent.AttributeValueMvoStateMergePatched e = newAttributeValueMvoStateMergePatched(stateEventId);
        ((AbstractAttributeValueMvoStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected AttributeValueMvoStateEvent.AttributeValueMvoStateDeleted newAttributeValueMvoStateDeleted(String commandId, String requesterId) {
        AttributeValueMvoStateEventId stateEventId = new AttributeValueMvoStateEventId(this.state.getAttributeValueId(), this.state.getAttributeVersion());
        AttributeValueMvoStateEvent.AttributeValueMvoStateDeleted e = newAttributeValueMvoStateDeleted(stateEventId);
        ((AbstractAttributeValueMvoStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected AttributeValueMvoStateEvent.AttributeValueMvoStateCreated newAttributeValueMvoStateCreated(AttributeValueMvoStateEventId stateEventId) {
        return new AbstractAttributeValueMvoStateEvent.SimpleAttributeValueMvoStateCreated(stateEventId);
    }

    protected AttributeValueMvoStateEvent.AttributeValueMvoStateMergePatched newAttributeValueMvoStateMergePatched(AttributeValueMvoStateEventId stateEventId) {
        return new AbstractAttributeValueMvoStateEvent.SimpleAttributeValueMvoStateMergePatched(stateEventId);
    }

    protected AttributeValueMvoStateEvent.AttributeValueMvoStateDeleted newAttributeValueMvoStateDeleted(AttributeValueMvoStateEventId stateEventId)
    {
        return new AbstractAttributeValueMvoStateEvent.SimpleAttributeValueMvoStateDeleted(stateEventId);
    }


    public static class SimpleAttributeValueMvoAggregate extends AbstractAttributeValueMvoAggregate
    {
        public SimpleAttributeValueMvoAggregate(AttributeValueMvoState state) {
            super(state);
        }

    }

}

