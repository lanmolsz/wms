package org.dddml.wms.domain.movement;

import java.util.*;
import java.util.Date;
import java.math.BigDecimal;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractStateEvent;

public abstract class AbstractMovementStateEvent extends AbstractStateEvent implements MovementStateEvent 
{
    private MovementStateEventId stateEventId;

    public MovementStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(MovementStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }
    
    public String getDocumentNumber() {
        return getStateEventId().getDocumentNumber();
    }

    public void setDocumentNumber(String documentNumber) {
        getStateEventId().setDocumentNumber(documentNumber);
    }

    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

    private String documentTypeId;

    public String getDocumentTypeId()
    {
        return this.documentTypeId;
    }

    public void setDocumentTypeId(String documentTypeId)
    {
        this.documentTypeId = documentTypeId;
    }

    private String documentStatusId;

    public String getDocumentStatusId()
    {
        return this.documentStatusId;
    }

    public void setDocumentStatusId(String documentStatusId)
    {
        this.documentStatusId = documentStatusId;
    }

    private String movementTypeId;

    public String getMovementTypeId()
    {
        return this.movementTypeId;
    }

    public void setMovementTypeId(String movementTypeId)
    {
        this.movementTypeId = movementTypeId;
    }

    private String description;

    public String getDescription()
    {
        return this.description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    private String createdBy;

    public String getCreatedBy()
    {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy)
    {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt()
    {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt)
    {
        this.createdAt = createdAt;
    }

    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }


    private String commandId;

    public String getCommandId() {
        return commandId;
    }

    public void setCommandId(String commandId) {
        this.commandId = commandId;
    }

    protected AbstractMovementStateEvent() {
    }

    protected AbstractMovementStateEvent(MovementStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }

    protected MovementLineStateEventDao getMovementLineStateEventDao() {
        return (MovementLineStateEventDao)ApplicationContext.current.get("MovementLineStateEventDao");
    }

    protected MovementLineStateEventId newMovementLineStateEventId(String lineNumber)
    {
        MovementLineStateEventId stateEventId = new MovementLineStateEventId(this.getStateEventId().getDocumentNumber(), 
            lineNumber, 
            this.getStateEventId().getVersion());
        return stateEventId;
    }

    protected void throwOnInconsistentEventIds(MovementLineStateEvent e)
    {
        throwOnInconsistentEventIds(this, e);
    }

    public static void throwOnInconsistentEventIds(MovementStateEvent oe, MovementLineStateEvent e)
    {
        if (!oe.getStateEventId().getDocumentNumber().equals(e.getStateEventId().getMovementDocumentNumber()))
        { 
            throw DomainError.named("inconsistentEventIds", "Outer Id DocumentNumber %1$s but inner id MovementDocumentNumber %2$s", 
                oe.getStateEventId().getDocumentNumber(), e.getStateEventId().getMovementDocumentNumber());
        }
    }

    protected MovementConfirmationLineStateEventDao getMovementConfirmationLineStateEventDao() {
        return (MovementConfirmationLineStateEventDao)ApplicationContext.current.get("MovementConfirmationLineStateEventDao");
    }

    protected MovementConfirmationLineStateEventId newMovementConfirmationLineStateEventId(String lineNumber)
    {
        MovementConfirmationLineStateEventId stateEventId = new MovementConfirmationLineStateEventId(this.getStateEventId().getDocumentNumber(), 
            lineNumber, 
            this.getStateEventId().getVersion());
        return stateEventId;
    }

    protected void throwOnInconsistentEventIds(MovementConfirmationLineStateEvent e)
    {
        throwOnInconsistentEventIds(this, e);
    }

    public static void throwOnInconsistentEventIds(MovementStateEvent oe, MovementConfirmationLineStateEvent e)
    {
        if (!oe.getStateEventId().getDocumentNumber().equals(e.getStateEventId().getMovementDocumentNumber()))
        { 
            throw DomainError.named("inconsistentEventIds", "Outer Id DocumentNumber %1$s but inner id MovementDocumentNumber %2$s", 
                oe.getStateEventId().getDocumentNumber(), e.getStateEventId().getMovementDocumentNumber());
        }
    }

    public MovementLineStateEvent.MovementLineStateCreated newMovementLineStateCreated(String lineNumber) {
        return new AbstractMovementLineStateEvent.SimpleMovementLineStateCreated(newMovementLineStateEventId(lineNumber));
    }

    public MovementLineStateEvent.MovementLineStateMergePatched newMovementLineStateMergePatched(String lineNumber) {
        return new AbstractMovementLineStateEvent.SimpleMovementLineStateMergePatched(newMovementLineStateEventId(lineNumber));
    }

    public MovementLineStateEvent.MovementLineStateRemoved newMovementLineStateRemoved(String lineNumber) {
        return new AbstractMovementLineStateEvent.SimpleMovementLineStateRemoved(newMovementLineStateEventId(lineNumber));
    }

    public MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated newMovementConfirmationLineStateCreated(String lineNumber) {
        return new AbstractMovementConfirmationLineStateEvent.SimpleMovementConfirmationLineStateCreated(newMovementConfirmationLineStateEventId(lineNumber));
    }

    public MovementConfirmationLineStateEvent.MovementConfirmationLineStateMergePatched newMovementConfirmationLineStateMergePatched(String lineNumber) {
        return new AbstractMovementConfirmationLineStateEvent.SimpleMovementConfirmationLineStateMergePatched(newMovementConfirmationLineStateEventId(lineNumber));
    }

    public MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved newMovementConfirmationLineStateRemoved(String lineNumber) {
        return new AbstractMovementConfirmationLineStateEvent.SimpleMovementConfirmationLineStateRemoved(newMovementConfirmationLineStateEventId(lineNumber));
    }


    public abstract String getStateEventType();


    public static abstract class AbstractMovementStateCreated extends AbstractMovementStateEvent implements MovementStateEvent.MovementStateCreated, Saveable
    {
        public AbstractMovementStateCreated() {
            this(new MovementStateEventId());
        }

        public AbstractMovementStateCreated(MovementStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

        private Map<MovementLineStateEventId, MovementLineStateEvent.MovementLineStateCreated> movementLineEvents = new HashMap<MovementLineStateEventId, MovementLineStateEvent.MovementLineStateCreated>();
        
        private Iterable<MovementLineStateEvent.MovementLineStateCreated> readOnlyMovementLineEvents;

        public Iterable<MovementLineStateEvent.MovementLineStateCreated> getMovementLineEvents()
        {
            if (!getStateEventReadOnly())
            {
                return this.movementLineEvents.values();
            }
            else
            {
                if (readOnlyMovementLineEvents != null) { return readOnlyMovementLineEvents; }
                MovementLineStateEventDao eventDao = getMovementLineStateEventDao();
                List<MovementLineStateEvent.MovementLineStateCreated> eL = new ArrayList<MovementLineStateEvent.MovementLineStateCreated>();
                for (MovementLineStateEvent e : eventDao.findByMovementStateEventId(this.getStateEventId()))
                {
                    e.setStateEventReadOnly(true);
                    eL.add((MovementLineStateEvent.MovementLineStateCreated)e);
                }
                return (readOnlyMovementLineEvents = eL);
            }
        }

        public void setMovementLineEvents(Iterable<MovementLineStateEvent.MovementLineStateCreated> es)
        {
            if (es != null)
            {
                for (MovementLineStateEvent.MovementLineStateCreated e : es)
                {
                    addMovementLineEvent(e);
                }
            }
            else { this.movementLineEvents.clear(); }
        }
        
        public void addMovementLineEvent(MovementLineStateEvent.MovementLineStateCreated e)
        {
            throwOnInconsistentEventIds(e);
            this.movementLineEvents.put(e.getStateEventId(), e);
        }

        private Map<MovementConfirmationLineStateEventId, MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated> movementConfirmationLineEvents = new HashMap<MovementConfirmationLineStateEventId, MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated>();
        
        private Iterable<MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated> readOnlyMovementConfirmationLineEvents;

        public Iterable<MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated> getMovementConfirmationLineEvents()
        {
            if (!getStateEventReadOnly())
            {
                return this.movementConfirmationLineEvents.values();
            }
            else
            {
                if (readOnlyMovementConfirmationLineEvents != null) { return readOnlyMovementConfirmationLineEvents; }
                MovementConfirmationLineStateEventDao eventDao = getMovementConfirmationLineStateEventDao();
                List<MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated> eL = new ArrayList<MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated>();
                for (MovementConfirmationLineStateEvent e : eventDao.findByMovementStateEventId(this.getStateEventId()))
                {
                    e.setStateEventReadOnly(true);
                    eL.add((MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated)e);
                }
                return (readOnlyMovementConfirmationLineEvents = eL);
            }
        }

        public void setMovementConfirmationLineEvents(Iterable<MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated> es)
        {
            if (es != null)
            {
                for (MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated e : es)
                {
                    addMovementConfirmationLineEvent(e);
                }
            }
            else { this.movementConfirmationLineEvents.clear(); }
        }
        
        public void addMovementConfirmationLineEvent(MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated e)
        {
            throwOnInconsistentEventIds(e);
            this.movementConfirmationLineEvents.put(e.getStateEventId(), e);
        }

        public void save()
        {
            for (MovementLineStateEvent.MovementLineStateCreated e : this.getMovementLineEvents()) {
                getMovementLineStateEventDao().save(e);
            }
            for (MovementConfirmationLineStateEvent.MovementConfirmationLineStateCreated e : this.getMovementConfirmationLineEvents()) {
                getMovementConfirmationLineStateEventDao().save(e);
            }
        }
    }


    public static abstract class AbstractMovementStateMergePatched extends AbstractMovementStateEvent implements MovementStateEvent.MovementStateMergePatched, Saveable
    {
        public AbstractMovementStateMergePatched() {
            this(new MovementStateEventId());
        }

        public AbstractMovementStateMergePatched(MovementStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.MERGE_PATCHED;
        }

        private Boolean isPropertyDocumentTypeIdRemoved;

        public Boolean getIsPropertyDocumentTypeIdRemoved() {
            return this.isPropertyDocumentTypeIdRemoved;
        }

        public void setIsPropertyDocumentTypeIdRemoved(Boolean removed) {
            this.isPropertyDocumentTypeIdRemoved = removed;
        }

        private Boolean isPropertyDocumentStatusIdRemoved;

        public Boolean getIsPropertyDocumentStatusIdRemoved() {
            return this.isPropertyDocumentStatusIdRemoved;
        }

        public void setIsPropertyDocumentStatusIdRemoved(Boolean removed) {
            this.isPropertyDocumentStatusIdRemoved = removed;
        }

        private Boolean isPropertyMovementTypeIdRemoved;

        public Boolean getIsPropertyMovementTypeIdRemoved() {
            return this.isPropertyMovementTypeIdRemoved;
        }

        public void setIsPropertyMovementTypeIdRemoved(Boolean removed) {
            this.isPropertyMovementTypeIdRemoved = removed;
        }

        private Boolean isPropertyDescriptionRemoved;

        public Boolean getIsPropertyDescriptionRemoved() {
            return this.isPropertyDescriptionRemoved;
        }

        public void setIsPropertyDescriptionRemoved(Boolean removed) {
            this.isPropertyDescriptionRemoved = removed;
        }

        private Boolean isPropertyActiveRemoved;

        public Boolean getIsPropertyActiveRemoved() {
            return this.isPropertyActiveRemoved;
        }

        public void setIsPropertyActiveRemoved(Boolean removed) {
            this.isPropertyActiveRemoved = removed;
        }

        private Map<MovementLineStateEventId, MovementLineStateEvent> movementLineEvents = new HashMap<MovementLineStateEventId, MovementLineStateEvent>();
        
        private Iterable<MovementLineStateEvent> readOnlyMovementLineEvents;

        public Iterable<MovementLineStateEvent> getMovementLineEvents()
        {
            if (!getStateEventReadOnly())
            {
                return this.movementLineEvents.values();
            }
            else
            {
                if (readOnlyMovementLineEvents != null) { return readOnlyMovementLineEvents; }
                MovementLineStateEventDao eventDao = getMovementLineStateEventDao();
                List<MovementLineStateEvent> eL = new ArrayList<MovementLineStateEvent>();
                for (MovementLineStateEvent e : eventDao.findByMovementStateEventId(this.getStateEventId()))
                {
                    e.setStateEventReadOnly(true);
                    eL.add((MovementLineStateEvent)e);
                }
                return (readOnlyMovementLineEvents = eL);
            }
        }

        public void setMovementLineEvents(Iterable<MovementLineStateEvent> es)
        {
            if (es != null)
            {
                for (MovementLineStateEvent e : es)
                {
                    addMovementLineEvent(e);
                }
            }
            else { this.movementLineEvents.clear(); }
        }
        
        public void addMovementLineEvent(MovementLineStateEvent e)
        {
            throwOnInconsistentEventIds(e);
            this.movementLineEvents.put(e.getStateEventId(), e);
        }

        private Map<MovementConfirmationLineStateEventId, MovementConfirmationLineStateEvent> movementConfirmationLineEvents = new HashMap<MovementConfirmationLineStateEventId, MovementConfirmationLineStateEvent>();
        
        private Iterable<MovementConfirmationLineStateEvent> readOnlyMovementConfirmationLineEvents;

        public Iterable<MovementConfirmationLineStateEvent> getMovementConfirmationLineEvents()
        {
            if (!getStateEventReadOnly())
            {
                return this.movementConfirmationLineEvents.values();
            }
            else
            {
                if (readOnlyMovementConfirmationLineEvents != null) { return readOnlyMovementConfirmationLineEvents; }
                MovementConfirmationLineStateEventDao eventDao = getMovementConfirmationLineStateEventDao();
                List<MovementConfirmationLineStateEvent> eL = new ArrayList<MovementConfirmationLineStateEvent>();
                for (MovementConfirmationLineStateEvent e : eventDao.findByMovementStateEventId(this.getStateEventId()))
                {
                    e.setStateEventReadOnly(true);
                    eL.add((MovementConfirmationLineStateEvent)e);
                }
                return (readOnlyMovementConfirmationLineEvents = eL);
            }
        }

        public void setMovementConfirmationLineEvents(Iterable<MovementConfirmationLineStateEvent> es)
        {
            if (es != null)
            {
                for (MovementConfirmationLineStateEvent e : es)
                {
                    addMovementConfirmationLineEvent(e);
                }
            }
            else { this.movementConfirmationLineEvents.clear(); }
        }
        
        public void addMovementConfirmationLineEvent(MovementConfirmationLineStateEvent e)
        {
            throwOnInconsistentEventIds(e);
            this.movementConfirmationLineEvents.put(e.getStateEventId(), e);
        }

        public void save()
        {
            for (MovementLineStateEvent e : this.getMovementLineEvents()) {
                getMovementLineStateEventDao().save(e);
            }
            for (MovementConfirmationLineStateEvent e : this.getMovementConfirmationLineEvents()) {
                getMovementConfirmationLineStateEventDao().save(e);
            }
        }
    }


    public static abstract class AbstractMovementStateDeleted extends AbstractMovementStateEvent implements MovementStateEvent.MovementStateDeleted, Saveable
    {
        public AbstractMovementStateDeleted() {
            this(new MovementStateEventId());
        }

        public AbstractMovementStateDeleted(MovementStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.DELETED;
        }

		
        private Map<MovementLineStateEventId, MovementLineStateEvent.MovementLineStateRemoved> movementLineEvents = new HashMap<MovementLineStateEventId, MovementLineStateEvent.MovementLineStateRemoved>();
        
        private Iterable<MovementLineStateEvent.MovementLineStateRemoved> readOnlyMovementLineEvents;

        public Iterable<MovementLineStateEvent.MovementLineStateRemoved> getMovementLineEvents()
        {
            if (!getStateEventReadOnly())
            {
                return this.movementLineEvents.values();
            }
            else
            {
                if (readOnlyMovementLineEvents != null) { return readOnlyMovementLineEvents; }
                MovementLineStateEventDao eventDao = getMovementLineStateEventDao();
                List<MovementLineStateEvent.MovementLineStateRemoved> eL = new ArrayList<MovementLineStateEvent.MovementLineStateRemoved>();
                for (MovementLineStateEvent e : eventDao.findByMovementStateEventId(this.getStateEventId()))
                {
                    e.setStateEventReadOnly(true);
                    eL.add((MovementLineStateEvent.MovementLineStateRemoved)e);
                }
                return (readOnlyMovementLineEvents = eL);
            }
        }

        public void setMovementLineEvents(Iterable<MovementLineStateEvent.MovementLineStateRemoved> es)
        {
            if (es != null)
            {
                for (MovementLineStateEvent.MovementLineStateRemoved e : es)
                {
                    addMovementLineEvent(e);
                }
            }
            else { this.movementLineEvents.clear(); }
        }
        
        public void addMovementLineEvent(MovementLineStateEvent.MovementLineStateRemoved e)
        {
            throwOnInconsistentEventIds(e);
            this.movementLineEvents.put(e.getStateEventId(), e);
        }

		
        private Map<MovementConfirmationLineStateEventId, MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved> movementConfirmationLineEvents = new HashMap<MovementConfirmationLineStateEventId, MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved>();
        
        private Iterable<MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved> readOnlyMovementConfirmationLineEvents;

        public Iterable<MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved> getMovementConfirmationLineEvents()
        {
            if (!getStateEventReadOnly())
            {
                return this.movementConfirmationLineEvents.values();
            }
            else
            {
                if (readOnlyMovementConfirmationLineEvents != null) { return readOnlyMovementConfirmationLineEvents; }
                MovementConfirmationLineStateEventDao eventDao = getMovementConfirmationLineStateEventDao();
                List<MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved> eL = new ArrayList<MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved>();
                for (MovementConfirmationLineStateEvent e : eventDao.findByMovementStateEventId(this.getStateEventId()))
                {
                    e.setStateEventReadOnly(true);
                    eL.add((MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved)e);
                }
                return (readOnlyMovementConfirmationLineEvents = eL);
            }
        }

        public void setMovementConfirmationLineEvents(Iterable<MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved> es)
        {
            if (es != null)
            {
                for (MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved e : es)
                {
                    addMovementConfirmationLineEvent(e);
                }
            }
            else { this.movementConfirmationLineEvents.clear(); }
        }
        
        public void addMovementConfirmationLineEvent(MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved e)
        {
            throwOnInconsistentEventIds(e);
            this.movementConfirmationLineEvents.put(e.getStateEventId(), e);
        }

        public void save()
        {
            for (MovementLineStateEvent.MovementLineStateRemoved e : this.getMovementLineEvents()) {
                getMovementLineStateEventDao().save(e);
            }
            for (MovementConfirmationLineStateEvent.MovementConfirmationLineStateRemoved e : this.getMovementConfirmationLineEvents()) {
                getMovementConfirmationLineStateEventDao().save(e);
            }
        }
    }
    public static class SimpleMovementStateCreated extends AbstractMovementStateCreated
    {
        public SimpleMovementStateCreated() {
        }

        public SimpleMovementStateCreated(MovementStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleMovementStateMergePatched extends AbstractMovementStateMergePatched
    {
        public SimpleMovementStateMergePatched() {
        }

        public SimpleMovementStateMergePatched(MovementStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleMovementStateDeleted extends AbstractMovementStateDeleted
    {
        public SimpleMovementStateDeleted() {
        }

        public SimpleMovementStateDeleted(MovementStateEventId stateEventId) {
            super(stateEventId);
        }
    }

}

