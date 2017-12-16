﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

	public static partial class InOutLineStateExtension
	{

        public static IInOutLineCommand ToCreateOrMergePatchInOutLine(this InOutLineState state)
        {
            return state.ToCreateOrMergePatchInOutLine<CreateInOutLine, MergePatchInOutLine>();
        }

        public static RemoveInOutLine ToRemoveInOutLine(this InOutLineState state)
        {
            return state.ToRemoveInOutLine<RemoveInOutLine>();
        }

        public static MergePatchInOutLine ToMergePatchInOutLine(this InOutLineState state)
        {
            return state.ToMergePatchInOutLine<MergePatchInOutLine>();
        }

        public static CreateInOutLine ToCreateInOutLine(this InOutLineState state)
        {
            return state.ToCreateInOutLine<CreateInOutLine>();
        }
		

	}

}

