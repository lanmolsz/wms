﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{
	public interface IAttributeValueStateEventDao
	{
		void Save(IAttributeValueStateEvent e);

        IEnumerable<IAttributeValueStateEvent> FindByAttributeEventId(AttributeEventId attributeEventId);

	}

}


