package org.dddml.wms.domain.movement.hibernate;

import java.util.*;
import java.util.Date;
import java.math.BigDecimal;
import org.dddml.wms.domain.*;
import org.hibernate.Session;
import org.hibernate.Criteria;
import org.hibernate.criterion.Order;
import org.hibernate.criterion.Criterion;
import org.hibernate.criterion.Projections;
import org.hibernate.SessionFactory;
import org.dddml.wms.domain.movement.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.*;
import org.springframework.transaction.annotation.Transactional;

public class HibernateMovementStateQueryRepository implements MovementStateQueryRepository
{
    private SessionFactory sessionFactory;

    public SessionFactory getSessionFactory() { return this.sessionFactory; }

    public void setSessionFactory(SessionFactory sessionFactory) { this.sessionFactory = sessionFactory; }

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }
    
    private static final Set<String> readOnlyPropertyPascalCaseNames = new HashSet<String>(Arrays.asList("DocumentNumber", "DocumentTypeId", "DocumentStatusId", "MovementTypeId", "Description", "MovementLines", "MovementConfirmationLines", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted"));
    
    private ReadOnlyProxyGenerator readOnlyProxyGenerator;
    
    public ReadOnlyProxyGenerator getReadOnlyProxyGenerator() {
        return readOnlyProxyGenerator;
    }

    public void setReadOnlyProxyGenerator(ReadOnlyProxyGenerator readOnlyProxyGenerator) {
        this.readOnlyProxyGenerator = readOnlyProxyGenerator;
    }

    @Transactional(readOnly = true)
    public MovementState get(String id) {

        MovementState state = (MovementState)getCurrentSession().get(AbstractMovementState.SimpleMovementState.class, id);
        if (getReadOnlyProxyGenerator() != null && state != null) {
            return (MovementState) getReadOnlyProxyGenerator().createProxy(state, new Class[]{MovementState.class, Saveable.class}, "getStateReadOnly", readOnlyPropertyPascalCaseNames);
        }
        return state;
    }

    @Transactional(readOnly = true)
    public Iterable<MovementState> getAll(Integer firstResult, Integer maxResults)
    {
        Criteria criteria = getCurrentSession().createCriteria(MovementState.class);
        if (firstResult != null) { criteria.setFirstResult(firstResult); }
        if (maxResults != null) { criteria.setMaxResults(maxResults); }
         addNotDeletedRestriction(criteria);
        return criteria.list();
    }

    @Transactional(readOnly = true)
    public Iterable<MovementState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults)
    {
        Criteria criteria = getCurrentSession().createCriteria(MovementState.class);

        HibernateUtils.criteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
        addNotDeletedRestriction(criteria);
        return criteria.list();
    }

    @Transactional(readOnly = true)
    public Iterable<MovementState> get(org.dddml.support.criterion.Criterion filter, List<String> orders, Integer firstResult, Integer maxResults)
    {
        Criteria criteria = getCurrentSession().createCriteria(MovementState.class);

        HibernateUtils.criteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
        addNotDeletedRestriction(criteria);
        return criteria.list();
    }

    @Transactional(readOnly = true)
    public MovementState getFirst(Iterable<Map.Entry<String, Object>> filter, List<String> orders)
    {
        List<MovementState> list = (List<MovementState>)get(filter, orders, 0, 1);
        if (list == null || list.size() <= 0)
        {
            return null;
        }
        return list.get(0);
    }

    @Transactional(readOnly = true)
    public MovementState getFirst(Map.Entry<String, Object> keyValue, List<String> orders)
    {
        List<Map.Entry<String, Object>> filter = new ArrayList<>();
        filter.add(keyValue);
        return getFirst(filter, orders);
    }

    @Transactional(readOnly = true)
    public Iterable<MovementState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults)
    {
        Map.Entry<String, Object> keyValue = new java.util.AbstractMap.SimpleEntry<String, Object> (propertyName, propertyValue);
        List<Map.Entry<String, Object>> filter = new ArrayList<Map.Entry<String, Object>>();
        filter.add(keyValue);
        return get(filter, orders, firstResult, maxResults);
    }

    @Transactional(readOnly = true)
    public long getCount(Iterable<Map.Entry<String, Object>> filter)
    {
        Criteria criteria = getCurrentSession().createCriteria(MovementState.class);
        criteria.setProjection(Projections.rowCount());
        if (filter != null) {
            HibernateUtils.criteriaAddFilter(criteria, filter);
        }
        addNotDeletedRestriction(criteria);
        return (long)criteria.uniqueResult();
    }

    @Transactional(readOnly = true)
    public long getCount(org.dddml.support.criterion.Criterion filter)
    {
        Criteria criteria = getCurrentSession().createCriteria(MovementState.class);
        criteria.setProjection(Projections.rowCount());
        if (filter != null)
        {
            org.hibernate.criterion.Criterion hc = CriterionUtils.toHibernateCriterion(filter);
            criteria.add(hc);
        }
        addNotDeletedRestriction(criteria);
        return (long)criteria.uniqueResult();
    }

    @Transactional(readOnly = true)
    public MovementLineState getMovementLine(String movementDocumentNumber, String lineNumber)
    {
        MovementLineId entityId = new MovementLineId(movementDocumentNumber, lineNumber);
        return (MovementLineState) getCurrentSession().get(AbstractMovementLineState.SimpleMovementLineState.class, entityId);
    }

    @Transactional(readOnly = true)
    public MovementConfirmationLineState getMovementConfirmationLine(String movementDocumentNumber, String lineNumber)
    {
        MovementConfirmationLineId entityId = new MovementConfirmationLineId(movementDocumentNumber, lineNumber);
        return (MovementConfirmationLineState) getCurrentSession().get(AbstractMovementConfirmationLineState.SimpleMovementConfirmationLineState.class, entityId);
    }


    protected static void addNotDeletedRestriction(Criteria criteria) {
        criteria.add(org.hibernate.criterion.Restrictions.eq("deleted", false));
    }

}

