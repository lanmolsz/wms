﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRejectionReasonDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RejectionReason;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.RejectionReason
{
	public partial interface IRejectionReasonStateQueryRepository
	{
        IRejectionReasonState Get(string id);

        IEnumerable<IRejectionReasonState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IRejectionReasonState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IRejectionReasonState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IRejectionReasonState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IRejectionReasonState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IRejectionReasonState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}

