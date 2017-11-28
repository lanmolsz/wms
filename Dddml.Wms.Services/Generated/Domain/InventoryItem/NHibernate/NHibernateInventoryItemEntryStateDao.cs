﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
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

	public class NHibernateInventoryItemEntryStateDao : IInventoryItemEntryStateDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "EntrySeqId", "QuantityOnHandVar", "QuantityReservedVar", "QuantityOccupiedVar", "QuantityVirtualVar", "EventVO", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "InventoryItemId" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateInventoryItemEntryStateDao()
		{
		}

        [Transaction(ReadOnly = true)]
        public IInventoryItemEntryState Get(InventoryItemEntryId id, bool nullAllowed)
        {
            IInventoryItemEntryState state = CurrentSession.Get<InventoryItemEntryState>(id);
            if (!nullAllowed && state == null)
            {
                state = new InventoryItemEntryState();
                (state as InventoryItemEntryState).InventoryItemEntryId = id;
            }
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IInventoryItemEntryState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
            return state;
        }

       
        public void Save(IInventoryItemEntryState state)
        {
            IInventoryItemEntryState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IInventoryItemEntryState>(state);
            }
            CurrentSession.SaveOrUpdate(s);
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }


        public void Delete(IInventoryItemEntryState state)
        {
            IInventoryItemEntryState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IInventoryItemEntryState>(state);
            }
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
            CurrentSession.Delete(s);
        }


        [Transaction(ReadOnly = true)]
        public IEnumerable<IInventoryItemEntryState> FindByInventoryItemId(InventoryItemId inventoryItemId)
        {
            var criteria = CurrentSession.CreateCriteria<InventoryItemEntryState>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("InventoryItemEntryId.InventoryItemIdProductId", inventoryItemId.ProductId))
                .Add(Restrictions.Eq("InventoryItemEntryId.InventoryItemIdLocatorId", inventoryItemId.LocatorId))
                .Add(Restrictions.Eq("InventoryItemEntryId.InventoryItemIdAttributeSetInstanceId", inventoryItemId.AttributeSetInstanceId))
                ;

            return criteria.Add(partIdCondition).List<InventoryItemEntryState>();
        }

    }

	
}

