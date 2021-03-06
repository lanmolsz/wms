﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomConversionDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomConversion;

namespace Dddml.Wms.Domain.UomConversion
{

	public static partial class UomConversionStateDtoExtension
	{

        public static IUomConversionCommand ToCreateOrMergePatchUomConversion(this UomConversionStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchUomConversion<CreateUomConversionDto, MergePatchUomConversionDto>();
        }

        public static DeleteUomConversionDto ToDeleteUomConversion(this UomConversionStateDtoWrapper state)
        {
            return state.ToDeleteUomConversion<DeleteUomConversionDto>();
        }

        public static MergePatchUomConversionDto ToMergePatchUomConversion(this UomConversionStateDtoWrapper state)
        {
            return state.ToMergePatchUomConversion<MergePatchUomConversionDto>();
        }

        public static CreateUomConversionDto ToCreateUomConversion(this UomConversionStateDtoWrapper state)
        {
            return state.ToCreateUomConversion<CreateUomConversionDto>();
        }
		

	}

}

