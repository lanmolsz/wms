﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.MovementConfirmation.NHibernate
{

	public partial class NHibernateMovementConfirmationStateRepository : IMovementConfirmationStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "DocumentNumber", "DocumentStatusId", "MovementDocumentNumber", "IsApproved", "ApprovalAmount", "Processed", "Processing", "DocumentTypeId", "Description", "MovementConfirmationLines", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateMovementConfirmationStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IMovementConfirmationState Get(string id, bool nullAllowed)
		{
			IMovementConfirmationState state = CurrentSession.Get<MovementConfirmationState> (id);
			if (!nullAllowed && state == null) {
				state = new MovementConfirmationState ();
				(state as MovementConfirmationState).DocumentNumber = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IMovementConfirmationState>(state, new Type[] { typeof(ISaveable) }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(IMovementConfirmationState state)
		{
            IMovementConfirmationState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IMovementConfirmationState>(state);
            }
			CurrentSession.SaveOrUpdate (s);

			var saveable = s as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
		}

        //protected static void AddNotDeletedRestriction(ICriteria criteria)
        //{
        //    criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        //}

	}
}

