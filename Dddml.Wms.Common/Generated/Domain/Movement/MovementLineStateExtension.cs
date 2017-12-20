﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.Movement
{

	public static partial class MovementLineStateExtension
	{

        public static IMovementLineCommand ToCreateOrMergePatchMovementLine(this MovementLineState state)
        {
            return state.ToCreateOrMergePatchMovementLine<CreateMovementLine, MergePatchMovementLine>();
        }

        public static RemoveMovementLine ToRemoveMovementLine(this MovementLineState state)
        {
            return state.ToRemoveMovementLine<RemoveMovementLine>();
        }

        public static MergePatchMovementLine ToMergePatchMovementLine(this MovementLineState state)
        {
            return state.ToMergePatchMovementLine<MergePatchMovementLine>();
        }

        public static CreateMovementLine ToCreateMovementLine(this MovementLineState state)
        {
            return state.ToCreateMovementLine<CreateMovementLine>();
        }
		

	}

}

