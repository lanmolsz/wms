﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextTreeApplicationServices.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Party;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain
{

	public partial class OrganizationTreeApplicationService : IOrganizationTreeApplicationService
	{

        public IOrganizationTreeRepository OrganizationTreeRepository { get; set; }

        public virtual IEnumerable<IOrganizationState> GetRoots(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var trees = OrganizationTreeRepository.GetRoots(filter, orders, firstResult, maxResults);
            return ToContentCollection(trees);
        }

        public virtual IEnumerable<IOrganizationState> GetChildren(string parentId, ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var trees = OrganizationTreeRepository.GetChildren(parentId, filter, orders, firstResult, maxResults);
            return ToContentCollection(trees);
        }

        public virtual IEnumerable<string> GetRootIds(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var ids = OrganizationTreeRepository.GetRootIds(filter, orders, firstResult, maxResults);
            return ids;
        }

        public virtual IEnumerable<string> GetChildIds(string parentId, ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var ids = OrganizationTreeRepository.GetChildIds(parentId, filter, orders, firstResult, maxResults);
            return ids;
        }

        public virtual IEnumerable<IOrganizationState> GetRoots(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var trees = OrganizationTreeRepository.GetRoots(filter, orders, firstResult, maxResults);
            return ToContentCollection(trees);
        }

        public virtual IEnumerable<IOrganizationState> GetChildren(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var trees = OrganizationTreeRepository.GetChildren(parentId, filter, orders, firstResult, maxResults);
            return ToContentCollection(trees);
        }

        public virtual IEnumerable<string> GetRootIds(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var ids = OrganizationTreeRepository.GetRootIds(filter, orders, firstResult, maxResults);
            return ids;
        }

        public virtual IEnumerable<string> GetChildIds(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var ids = OrganizationTreeRepository.GetChildIds(parentId, filter, orders, firstResult, maxResults);
            return ids;
        }

        private static IEnumerable<IOrganizationState> ToContentCollection(IEnumerable<IOrganizationTreeNode> trees)
        {
            var states = new List<IOrganizationState>();
            foreach (var t in trees)
            {
                states.Add(t.Content);
            }
            return states;
        }

	}

	public partial class OrganizationTreeApplicationServiceFactory : IOrganizationTreeApplicationServiceFactory
	{
        public virtual IOrganizationTreeApplicationService OrganizationTreeApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["OrganizationTreeApplicationService"] as IOrganizationTreeApplicationService;
		    }
        }
	}

}

