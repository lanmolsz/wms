﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmation
{

	public static partial class MovementConfirmationLineStateDtoExtension
	{

        public static IMovementConfirmationLineCommand ToCreateOrMergePatchMovementConfirmationLine(this MovementConfirmationLineStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchMovementConfirmationLine<CreateMovementConfirmationLineDto, MergePatchMovementConfirmationLineDto>();
        }

        public static RemoveMovementConfirmationLineDto ToRemoveMovementConfirmationLine(this MovementConfirmationLineStateDtoWrapper state)
        {
            return state.ToRemoveMovementConfirmationLine<RemoveMovementConfirmationLineDto>();
        }

        public static MergePatchMovementConfirmationLineDto ToMergePatchMovementConfirmationLine(this MovementConfirmationLineStateDtoWrapper state)
        {
            return state.ToMergePatchMovementConfirmationLine<MergePatchMovementConfirmationLineDto>();
        }

        public static CreateMovementConfirmationLineDto ToCreateMovementConfirmationLine(this MovementConfirmationLineStateDtoWrapper state)
        {
            return state.ToCreateMovementConfirmationLine<CreateMovementConfirmationLineDto>();
        }
		

	}

}
