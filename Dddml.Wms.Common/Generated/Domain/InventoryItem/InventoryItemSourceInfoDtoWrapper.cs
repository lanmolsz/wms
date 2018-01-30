﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{

	public class InventoryItemSourceInfoDtoWrapper : InventoryItemSourceInfoDto
	{

        private InventoryItemSourceInfo _value = new InventoryItemSourceInfo();

		public InventoryItemSourceInfoDtoWrapper()
		{
		}

		public InventoryItemSourceInfoDtoWrapper(InventoryItemSourceInfo val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override InventoryItemSourceInfo ToInventoryItemSourceInfo()
        {
            return this._value;
        }

		public override string DocumentTypeId { 
			get { return _value.DocumentTypeId; } 
			set { _value.DocumentTypeId = value; } 
		}

		public override string DocumentNumber { 
			get { return _value.DocumentNumber; } 
			set { _value.DocumentNumber = value; } 
		}

		public override string LineNumber { 
			get { return _value.LineNumber; } 
			set { _value.LineNumber = value; } 
		}

		public override int LineSubSeqId { 
			get { return _value.LineSubSeqId; } 
			set { _value.LineSubSeqId = value; } 
		}


	}

}


