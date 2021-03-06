﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistRoleMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistRoleMvo;
using Dddml.Wms.Domain.Picklist;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.PicklistRoleMvo
{
	public partial interface IPicklistRoleMvoStateQueryRepository
	{
        IPicklistRoleMvoState Get(PicklistRoleId id);

        IEnumerable<IPicklistRoleMvoState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IPicklistRoleMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IPicklistRoleMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IPicklistRoleMvoState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IPicklistRoleMvoState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IPicklistRoleMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}

