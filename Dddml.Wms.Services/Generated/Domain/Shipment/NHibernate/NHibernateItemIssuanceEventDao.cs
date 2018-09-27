﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Shipment.NHibernate
{

	public class NHibernateItemIssuanceEventDao : IItemIssuanceEventDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernateItemIssuanceEventDao ()
		{
		}

		public void Save(IItemIssuanceEvent stateEvent)
		{
			CurrentSession.Save(stateEvent);
            var saveable = stateEvent as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IItemIssuanceEvent> FindByShipmentEventId(ShipmentEventId shipmentEventId)
        {
            var criteria = CurrentSession.CreateCriteria<ItemIssuanceEventBase>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("ItemIssuanceEventId.ShipmentId", shipmentEventId.ShipmentId))
                .Add(Restrictions.Eq("ItemIssuanceEventId.ShipmentVersion", shipmentEventId.Version))
                ;

            return criteria.Add(partIdCondition).List<ItemIssuanceEventBase>();
        }

	}
}
