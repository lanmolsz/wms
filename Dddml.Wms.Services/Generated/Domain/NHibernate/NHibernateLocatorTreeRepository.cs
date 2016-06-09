﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateNHibernateTrees.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.NHibernate
{

    public partial class NHibernateLocatorTreeRepository : ILocatorTreeRepository
    {

        private ILocatorStateRepository _locatorStateRepository;

        public ILocatorStateRepository LocatorStateRepository
        {
            get { return this._locatorStateRepository; }
            set { this._locatorStateRepository = value; }
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<ILocatorTree> GetRoots(Dddml.Support.Criterion.ICriterion filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = LocatorStateRepository.GetLocatorTreeRoots(filter, orders, firstResult, maxResults);
            return ToLocatorTreeCollection(states);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<ILocatorTree> GetChildren(string parentId, Dddml.Support.Criterion.ICriterion filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = LocatorStateRepository.GetLocatorTreeChildren(parentId, filter, orders, firstResult, maxResults);
            return ToLocatorTreeCollection(states);
        }

        private IEnumerable<ILocatorTree> ToLocatorTreeCollection(IEnumerable<ILocatorState> states)
        {
            var trees = new List<LocatorTree>();
            foreach (var state in states)
            {
                trees.Add(new LocatorTree(state, this));
            }
            return trees;
        }


    }

}

