﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public class AttributeSetAttributeUseIdDto
	{

        private AttributeSetAttributeUseId _value = new AttributeSetAttributeUseId();

		public AttributeSetAttributeUseIdDto()
		{
		}

		public AttributeSetAttributeUseIdDto(AttributeSetAttributeUseId val)
		{
			this._value = val;
		}

        public AttributeSetAttributeUseId ToAttributeSetAttributeUseId()
        {
            return this._value;
        }

		public virtual string AttributeSetId { 
			get { return _value.AttributeSetId; } 
			set { _value.AttributeSetId = value; } 
		}

		public virtual string AttributeId { 
			get { return _value.AttributeId; } 
			set { _value.AttributeId = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeSetAttributeUseIdDto other = obj as AttributeSetAttributeUseIdDto;
			if (other == null) {
				return false;
			}

            return _value.Equals(other._value);

		}

		public override int GetHashCode ()
		{
			return _value.GetHashCode();
		}

	}

}


