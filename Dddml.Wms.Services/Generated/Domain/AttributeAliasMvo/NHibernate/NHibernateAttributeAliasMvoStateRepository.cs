﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeAliasMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeAliasMvo;
using Dddml.Wms.Domain.Attribute;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.AttributeAliasMvo.NHibernate
{

	public partial class NHibernateAttributeAliasMvoStateRepository : IAttributeAliasMvoStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "AttributeAliasId", "Name", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "AttributeAttributeName", "AttributeOrganizationId", "AttributeDescription", "AttributeIsMandatory", "AttributeAttributeValueType", "AttributeAttributeValueLength", "AttributeIsList", "AttributeFieldName", "AttributeReferenceId", "AttributeAttributeValues", "AttributeAliases", "AttributeVersion", "AttributeCreatedBy", "AttributeCreatedAt", "AttributeUpdatedBy", "AttributeUpdatedAt", "AttributeActive", "AttributeDeleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateAttributeAliasMvoStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IAttributeAliasMvoState Get(AttributeAliasId id, bool nullAllowed)
		{
			IAttributeAliasMvoState state = CurrentSession.Get<AttributeAliasMvoState> (id);
			if (!nullAllowed && state == null) {
				state = new AttributeAliasMvoState ();
				(state as AttributeAliasMvoState).AttributeAliasId = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IAttributeAliasMvoState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(IAttributeAliasMvoState state)
		{
            IAttributeAliasMvoState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IAttributeAliasMvoState>(state);
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

