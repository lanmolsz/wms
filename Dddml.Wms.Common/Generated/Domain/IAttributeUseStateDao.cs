﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{
	public interface IAttributeUseStateDao
	{	
		IAttributeUseState Get (AttributeSetAttributeUseId id);

		void Save (IAttributeUseState state);

        IEnumerable<IAttributeUseState> FindByAttributeSetId(string attributeSetId);

        void Delete(IAttributeUseState state);

    }
}


