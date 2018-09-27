﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Product;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Product.NHibernate
{

	public class NHibernateGoodIdentificationStateDao : IGoodIdentificationStateDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "GoodIdentificationTypeId", "IdValue", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "ProductId" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateGoodIdentificationStateDao()
		{
		}

        [Transaction(ReadOnly = true)]
        public IGoodIdentificationState Get(ProductGoodIdentificationId id, bool nullAllowed)
        {
            IGoodIdentificationState state = CurrentSession.Get<GoodIdentificationState>(id);
            if (!nullAllowed && state == null)
            {
                state = new GoodIdentificationState();
                (state as GoodIdentificationState).ProductGoodIdentificationId = id;
            }
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IGoodIdentificationState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
            return state;
        }

       
        public void Save(IGoodIdentificationState state)
        {
            IGoodIdentificationState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IGoodIdentificationState>(state);
            }
            CurrentSession.SaveOrUpdate(s);
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }


        public void Delete(IGoodIdentificationState state)
        {
            IGoodIdentificationState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IGoodIdentificationState>(state);
            }
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
            CurrentSession.Delete(s);
        }


        [Transaction(ReadOnly = true)]
        public IEnumerable<IGoodIdentificationState> FindByProductId(string productId)
        {
            var criteria = CurrentSession.CreateCriteria<GoodIdentificationState>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("ProductGoodIdentificationId.ProductId", productId))
                ;

            return criteria.Add(partIdCondition).List<GoodIdentificationState>();
        }

    }

	
}
