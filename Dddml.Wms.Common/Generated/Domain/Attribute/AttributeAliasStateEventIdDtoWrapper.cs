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

	public class AttributeAliasStateEventIdDtoWrapper : AttributeAliasStateEventIdDto
	{

        private AttributeAliasStateEventId _value = new AttributeAliasStateEventId();

		public AttributeAliasStateEventIdDtoWrapper()
		{
		}

		public AttributeAliasStateEventIdDtoWrapper(AttributeAliasStateEventId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override AttributeAliasStateEventId ToAttributeAliasStateEventId()
        {
            return this._value;
        }

		public override string AttributeId { 
			get { return _value.AttributeId; } 
			set { _value.AttributeId = value; } 
		}

		public override string Code { 
			get { return _value.Code; } 
			set { _value.Code = value; } 
		}

		public override long AttributeVersion { 
			get { return _value.AttributeVersion; } 
			set { _value.AttributeVersion = value; } 
		}


	}

}


