﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Permission;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain
{

	public partial interface IPermissionTreeApplicationService
	{
        IEnumerable<IPermissionState> GetRoots(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IPermissionState> GetChildren(string parentId, ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<string> GetRootIds(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<string> GetChildIds(string parentId, ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IPermissionState> GetRoots(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IPermissionState> GetChildren(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<string> GetRootIds(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<string> GetChildIds(string parentId, IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

	}

    public partial interface IPermissionTreeApplicationServiceFactory
    {

        IPermissionTreeApplicationService PermissionTreeApplicationService { get; }

    }

}

