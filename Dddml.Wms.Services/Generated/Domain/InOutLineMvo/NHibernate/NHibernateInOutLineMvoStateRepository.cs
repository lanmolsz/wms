﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.InOutLineMvo.NHibernate
{

	public partial class NHibernateInOutLineMvoStateRepository : IInOutLineMvoStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "InOutLineId", "LocatorId", "ProductId", "AttributeSetInstanceId", "Description", "QuantityUomId", "MovementQuantity", "PickedQuantity", "IsInvoiced", "Processed", "RmaLineNumber", "ReversalLineNumber", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "InOutDocumentStatusId", "InOutPosted", "InOutProcessed", "InOutProcessing", "InOutDocumentTypeId", "InOutDescription", "InOutOrderId", "InOutDateOrdered", "InOutIsPrinted", "InOutMovementTypeId", "InOutMovementDate", "InOutBusinessPartnerId", "InOutWarehouseId", "InOutPOReference", "InOutFreightAmount", "InOutShipperId", "InOutChargeAmount", "InOutDatePrinted", "InOutCreatedFrom", "InOutSalesRepresentativeId", "InOutNumberOfPackages", "InOutPickDate", "InOutShipDate", "InOutTrackingNumber", "InOutDateReceived", "InOutIsInTransit", "InOutIsApproved", "InOutIsInDispute", "InOutRmaDocumentNumber", "InOutReversalDocumentNumber", "InOutInOutLines", "InOutVersion", "InOutCreatedBy", "InOutCreatedAt", "InOutUpdatedBy", "InOutUpdatedAt", "InOutActive" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateInOutLineMvoStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IInOutLineMvoState Get(InOutLineId id, bool nullAllowed)
		{
			IInOutLineMvoState state = CurrentSession.Get<InOutLineMvoState> (id);
			if (!nullAllowed && state == null) {
				state = new InOutLineMvoState ();
				(state as InOutLineMvoState).InOutLineId = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IInOutLineMvoState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(IInOutLineMvoState state)
		{
            IInOutLineMvoState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IInOutLineMvoState>(state);
            }
			CurrentSession.SaveOrUpdate (s);

			var saveable = s as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
            CurrentSession.Flush();
		}

        //protected static void AddNotDeletedRestriction(ICriteria criteria)
        //{
        //    criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        //}

	}
}

