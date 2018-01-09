﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementTypeDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementType;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.MovementType.NHibernate
{

	public partial class NHibernateMovementTypeStateRepository : IMovementTypeStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "MovementTypeId", "Description", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateMovementTypeStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IMovementTypeState Get(string id, bool nullAllowed)
		{
			IMovementTypeState state = CurrentSession.Get<MovementTypeState> (id);
			if (!nullAllowed && state == null) {
				state = new MovementTypeState ();
				(state as MovementTypeState).MovementTypeId = id;
			}
			return state;
		}

		[Transaction]
		public void Save(IMovementTypeState state)
		{
            IMovementTypeState s = state;
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

