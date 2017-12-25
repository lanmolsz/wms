﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.InOut.NHibernate
{

	public class NHibernateInOutLineStateDao : IInOutLineStateDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "LineNumber", "LocatorId", "ProductId", "AttributeSetInstanceId", "Description", "UomId", "MovementQuantity", "PickedQuantity", "IsInvoiced", "Processed", "RmaLineNumber", "ReversalLineNumber", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "InOutDocumentNumber" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateInOutLineStateDao()
		{
		}

        [Transaction(ReadOnly = true)]
        public IInOutLineState Get(InOutLineId id, bool nullAllowed)
        {
            IInOutLineState state = CurrentSession.Get<InOutLineState>(id);
            if (!nullAllowed && state == null)
            {
                state = new InOutLineState();
                (state as InOutLineState).InOutLineId = id;
            }
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IInOutLineState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
            return state;
        }

       
        public void Save(IInOutLineState state)
        {
            IInOutLineState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IInOutLineState>(state);
            }
            CurrentSession.SaveOrUpdate(s);
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }


        public void Delete(IInOutLineState state)
        {
            IInOutLineState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IInOutLineState>(state);
            }
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
            CurrentSession.Delete(s);
        }


        [Transaction(ReadOnly = true)]
        public IEnumerable<IInOutLineState> FindByInOutDocumentNumber(string inOutDocumentNumber)
        {
            var criteria = CurrentSession.CreateCriteria<InOutLineState>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("InOutLineId.InOutDocumentNumber", inOutDocumentNumber))
                ;

            return criteria.Add(partIdCondition).List<InOutLineState>();
        }

    }

	
}

