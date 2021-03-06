﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateNHibernateTrees.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Party;
using Dddml.Wms.Domain.OrganizationStructure;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.NHibernate
{

    public partial class NHibernateOrganizationTreeRepository : IOrganizationTreeRepository
    {

        private IOrganizationStateQueryRepository _organizationStateQueryRepository;

        public IOrganizationStateQueryRepository OrganizationStateQueryRepository
        {
            get { return this._organizationStateQueryRepository; }
            set { this._organizationStateQueryRepository = value; }
        }

        private IOrganizationStructureStateQueryRepository _organizationStructureStateQueryRepository;

        public IOrganizationStructureStateQueryRepository OrganizationStructureStateQueryRepository
        {
            get { return this._organizationStructureStateQueryRepository; }
            set { this._organizationStructureStateQueryRepository = value; }
        }



        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrganizationTreeNode> GetRoots(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateQueryRepository.GetOrganizationTreeRoots(filter, orders, firstResult, maxResults);
            return ToOrganizationTreeNodeCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrganizationTreeNode> GetChildren(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateQueryRepository.GetOrganizationTreeChildren(parentId, filter, orders, firstResult, maxResults);
            return ToOrganizationTreeNodeCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<string> GetRootIds(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateQueryRepository.GetOrganizationTreeRoots(filter, orders, firstResult, maxResults);
            return ToIdCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<string> GetChildIds(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateQueryRepository.GetOrganizationTreeChildren(parentId, filter, orders, firstResult, maxResults);
            return ToIdCollection(structureStates);
        }



        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrganizationTreeNode> GetRoots(Dddml.Support.Criterion.ICriterion filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateQueryRepository.GetOrganizationTreeRoots(filter, orders, firstResult, maxResults);
            return ToOrganizationTreeNodeCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrganizationTreeNode> GetChildren(string parentId, Dddml.Support.Criterion.ICriterion filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateQueryRepository.GetOrganizationTreeChildren(parentId, filter, orders, firstResult, maxResults);
            return ToOrganizationTreeNodeCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<string> GetRootIds(Dddml.Support.Criterion.ICriterion filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateQueryRepository.GetOrganizationTreeRoots(filter, orders, firstResult, maxResults);
            return ToIdCollection(structureStates);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<string> GetChildIds(string parentId, Dddml.Support.Criterion.ICriterion filter, IList<string> orders, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var structureStates = OrganizationStructureStateQueryRepository.GetOrganizationTreeChildren(parentId, filter, orders, firstResult, maxResults);
            return ToIdCollection(structureStates);
        }


        private IEnumerable<IOrganizationTreeNode> ToOrganizationTreeNodeCollection(IEnumerable<IOrganizationState> states)
        {
            var trees = new List<OrganizationTreeNode>();
            foreach (var state in states)
            {
                trees.Add(new OrganizationTreeNode(state, this));
            }
            return trees;
        }

        private IEnumerable<string> ToIdCollection(IEnumerable<IOrganizationState> states)
        {
            var ids = new List<string>();
            foreach (var state in states)
            {
                ids.Add(state.PartyId);
            }
            return ids;
        }

        private IEnumerable<IOrganizationTreeNode> ToOrganizationTreeNodeCollection(IEnumerable<IOrganizationStructureState> structureStates)
        {
            var trees = new List<OrganizationTreeNode>();
            foreach (var ss in structureStates)
            {
                var state = OrganizationStateQueryRepository.Get(ss.Id.SubsidiaryId);
                if (state != null)
                {
                    trees.Add(new OrganizationTreeNode(state, this) { Structure = ss });
                }
            }
            return trees;
        }

        private IEnumerable<string> ToIdCollection(IEnumerable<IOrganizationStructureState> structureStates)
        {
            var ids = new List<string>();
            foreach (var ss in structureStates)
            {
                ids.Add(ss.Id.SubsidiaryId);
            }
            return ids;
        }


    }

}

