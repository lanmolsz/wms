﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOutLineMvo
{

	public static partial class InOutLineMvoStateDtoExtension
	{

        public static IInOutLineMvoCommand ToCreateOrMergePatchInOutLineMvo(this InOutLineMvoStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchInOutLineMvo<CreateInOutLineMvoDto, MergePatchInOutLineMvoDto>();
        }

        public static DeleteInOutLineMvoDto ToDeleteInOutLineMvo(this InOutLineMvoStateDtoWrapper state)
        {
            return state.ToDeleteInOutLineMvo<DeleteInOutLineMvoDto>();
        }

        public static MergePatchInOutLineMvoDto ToMergePatchInOutLineMvo(this InOutLineMvoStateDtoWrapper state)
        {
            return state.ToMergePatchInOutLineMvo<MergePatchInOutLineMvoDto>();
        }

        public static CreateInOutLineMvoDto ToCreateInOutLineMvo(this InOutLineMvoStateDtoWrapper state)
        {
            return state.ToCreateInOutLineMvo<CreateInOutLineMvoDto>();
        }
		

	}

}

