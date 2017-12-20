﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.InOut
{
	public partial interface IInOutStateQueryRepository
	{
        IInOutState Get(string id);

        IEnumerable<IInOutState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IInOutState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IInOutState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IInOutState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IInOutState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IInOutState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IInOutLineState GetInOutLine(string inOutDocumentNumber, string lineNumber);

	}

}

