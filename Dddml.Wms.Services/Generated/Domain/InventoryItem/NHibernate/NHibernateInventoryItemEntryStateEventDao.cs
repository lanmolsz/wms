﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.InventoryItem.NHibernate
{

	public class NHibernateInventoryItemEntryStateEventDao : IInventoryItemEntryStateEventDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernateInventoryItemEntryStateEventDao ()
		{
		}

		public void Save(IInventoryItemEntryStateEvent stateEvent)
		{
            InventoryItemEntryState state = ((InventoryItemEntryStateCreated)stateEvent).InventoryItemEntryState;
			CurrentSession.Save(state);
            var saveable = stateEvent as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IInventoryItemEntryStateEvent> FindByInventoryItemEventId(InventoryItemEventId inventoryItemEventId)
        {
            var criteria = CurrentSession.CreateCriteria<InventoryItemEntryState>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("InventoryItemEntryId.InventoryItemIdProductId", inventoryItemEventId.InventoryItemId.ProductId))
                .Add(Restrictions.Eq("InventoryItemEntryId.InventoryItemIdLocatorId", inventoryItemEventId.InventoryItemId.LocatorId))
                .Add(Restrictions.Eq("InventoryItemEntryId.InventoryItemIdAttributeSetInstanceId", inventoryItemEventId.InventoryItemId.AttributeSetInstanceId))
                ;

            return criteria.Add(partIdCondition).List<InventoryItemEntryState>().Select(s => new InventoryItemEntryStateCreated(s));
        }

	}
}

