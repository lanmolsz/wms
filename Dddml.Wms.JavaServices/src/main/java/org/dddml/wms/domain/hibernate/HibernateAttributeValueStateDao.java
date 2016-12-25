package org.dddml.wms.domain.hibernate;

import java.util.Date;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.springframework.transaction.annotation.Transactional;

public class HibernateAttributeValueStateDao implements AttributeValueStateDao
{
    private SessionFactory sessionFactory;

    public SessionFactory getSessionFactory() { return this.sessionFactory; }

    public void setSessionFactory(SessionFactory sessionFactory) { this.sessionFactory = sessionFactory; }

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }

    @Transactional(readOnly = true)
    @Override
    public AttributeValueState get(AttributeValueId id)
    {
        return get(id, false);
    }

    @Transactional(readOnly = true)
    @Override
    public AttributeValueState get(AttributeValueId id, boolean nullAllowed)
    {
        AttributeValueState state = (AttributeValueState) getCurrentSession().get(AbstractAttributeValueState.SimpleAttributeValueState.class, id);
        if (!nullAllowed && state == null) {
            state = new AbstractAttributeValueState.SimpleAttributeValueState();
            state.setAttributeValueId(id);
        }
        return state;
    }

    @Override
    public void save(AttributeValueState state)
    {
        if(state.getVersion() == null) {
            getCurrentSession().save(state);
        }else {
            getCurrentSession().update(state);
        }

        if (state instanceof Saveable)
        {
            Saveable saveable = (Saveable) state;
            saveable.save();
        }
    }

    @Transactional(readOnly = true)
    @Override
    public Iterable<AttributeValueState> findByAttributeId(String attributeId)
    {
        Criteria criteria = getCurrentSession().createCriteria(AbstractAttributeValueState.SimpleAttributeValueState.class);
        Junction partIdCondition = Restrictions.conjunction()
            .add(Restrictions.eq("attributeValueId.attributeId", attributeId))
            ;
        return criteria.add(partIdCondition).list();
    }

    @Override
    public void delete(AttributeValueState state)
    {
        if (state instanceof Saveable)
        {
            Saveable saveable = (Saveable) state;
            saveable.save();
        }
        getCurrentSession().delete(state);
    }

}

