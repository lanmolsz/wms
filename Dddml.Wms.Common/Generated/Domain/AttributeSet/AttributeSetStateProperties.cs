﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeSet
{

	public abstract class AttributeSetStateProperties : IAttributeSetStateProperties
	{
		public virtual string AttributeSetId { get; set; }

		public virtual string AttributeSetName { get; set; }

		public virtual string OrganizationId { get; set; }

		public virtual string Description { get; set; }

		public virtual string SerialNumberAttributeId { get; set; }

		public virtual string LotAttributeId { get; set; }

		public virtual string ReferenceId { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
