﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmationLineMvo;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmationLineMvo
{

	public static partial class MovementConfirmationLineMvoStateDtoExtension
	{

        public static IMovementConfirmationLineMvoCommand ToCreateOrMergePatchMovementConfirmationLineMvo(this MovementConfirmationLineMvoStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchMovementConfirmationLineMvo<CreateMovementConfirmationLineMvoDto, MergePatchMovementConfirmationLineMvoDto>();
        }

        public static DeleteMovementConfirmationLineMvoDto ToDeleteMovementConfirmationLineMvo(this MovementConfirmationLineMvoStateDtoWrapper state)
        {
            return state.ToDeleteMovementConfirmationLineMvo<DeleteMovementConfirmationLineMvoDto>();
        }

        public static MergePatchMovementConfirmationLineMvoDto ToMergePatchMovementConfirmationLineMvo(this MovementConfirmationLineMvoStateDtoWrapper state)
        {
            return state.ToMergePatchMovementConfirmationLineMvo<MergePatchMovementConfirmationLineMvoDto>();
        }

        public static CreateMovementConfirmationLineMvoDto ToCreateMovementConfirmationLineMvo(this MovementConfirmationLineMvoStateDtoWrapper state)
        {
            return state.ToCreateMovementConfirmationLineMvo<CreateMovementConfirmationLineMvoDto>();
        }
		

	}

}

