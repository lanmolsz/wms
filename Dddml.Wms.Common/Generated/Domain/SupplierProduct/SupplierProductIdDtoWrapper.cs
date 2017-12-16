﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSupplierProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SupplierProduct;

namespace Dddml.Wms.Domain.SupplierProduct
{

	public class SupplierProductIdDtoWrapper : SupplierProductIdDto
	{

        private SupplierProductId _value = new SupplierProductId();

		public SupplierProductIdDtoWrapper()
		{
		}

		public SupplierProductIdDtoWrapper(SupplierProductId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override SupplierProductId ToSupplierProductId()
        {
            return this._value;
        }

		public override string ProductId { 
			get { return _value.ProductId; } 
			set { _value.ProductId = value; } 
		}

		public override string PartyId { 
			get { return _value.PartyId; } 
			set { _value.PartyId = value; } 
		}

		public override string CurrencyUomId { 
			get { return _value.CurrencyUomId; } 
			set { _value.CurrencyUomId = value; } 
		}

		public override decimal? MinimumOrderQuantity { 
			get { return _value.MinimumOrderQuantity; } 
			set { _value.MinimumOrderQuantity = value; } 
		}


	}

}


