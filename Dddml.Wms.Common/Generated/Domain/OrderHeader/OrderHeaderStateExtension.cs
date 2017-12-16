﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderHeaderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderHeader;

namespace Dddml.Wms.Domain.OrderHeader
{

	public static partial class OrderHeaderStateExtension
	{

        public static IOrderHeaderCommand ToCreateOrMergePatchOrderHeader(this OrderHeaderState state)
        {
            return state.ToCreateOrMergePatchOrderHeader<CreateOrderHeader, MergePatchOrderHeader>();
        }

        public static DeleteOrderHeader ToDeleteOrderHeader(this OrderHeaderState state)
        {
            return state.ToDeleteOrderHeader<DeleteOrderHeader>();
        }

        public static MergePatchOrderHeader ToMergePatchOrderHeader(this OrderHeaderState state)
        {
            return state.ToMergePatchOrderHeader<MergePatchOrderHeader>();
        }

        public static CreateOrderHeader ToCreateOrderHeader(this OrderHeaderState state)
        {
            return state.ToCreateOrderHeader<CreateOrderHeader>();
        }
		

	}

}

