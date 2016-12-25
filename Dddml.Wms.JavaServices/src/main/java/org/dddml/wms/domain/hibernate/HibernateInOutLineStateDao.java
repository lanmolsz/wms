package org.dddml.wms.domain.hibernate;

import java.math.BigDecimal;
import java.util.Date;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.springframework.transaction.annotation.Transactional;

public class HibernateInOutLineStateDao implements InOutLineStateDao
{
    private SessionFactory sessionFactory;

    public SessionFactory getSessionFactory() { return this.sessionFactory; }

    public void setSessionFactory(SessionFactory sessionFactory) { this.sessionFactory = sessionFactory; }

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }

    @Transactional(readOnly = true)
    @Override
    public InOutLineState get(InOutLineId id)
    {
        return get(id, false);
    }

    @Transactional(readOnly = true)
    @Override
    public InOutLineState get(InOutLineId id, boolean nullAllowed)
    {
        InOutLineState state = (InOutLineState) getCurrentSession().get(AbstractInOutLineState.SimpleInOutLineState.class, id);
        if (!nullAllowed && state == null) {
            state = new AbstractInOutLineState.SimpleInOutLineState();
            state.setInOutLineId(id);
        }
        return state;
    }

    @Override
    public void save(InOutLineState state)
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
    public Iterable<InOutLineState> findByInOutDocumentNumber(String inOutDocumentNumber)
    {
        Criteria criteria = getCurrentSession().createCriteria(AbstractInOutLineState.SimpleInOutLineState.class);
        Junction partIdCondition = Restrictions.conjunction()
            .add(Restrictions.eq("inOutLineId.inOutDocumentNumber", inOutDocumentNumber))
            ;
        return criteria.add(partIdCondition).list();
    }

    @Override
    public void delete(InOutLineState state)
    {
        if (state instanceof Saveable)
        {
            Saveable saveable = (Saveable) state;
            saveable.save();
        }
        getCurrentSession().delete(state);
    }

}

