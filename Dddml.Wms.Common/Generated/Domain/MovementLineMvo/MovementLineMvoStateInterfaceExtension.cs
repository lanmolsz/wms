﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementLineMvo;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.MovementLineMvo
{

	public static partial class MovementLineMvoStateInterfaceExtension
	{

        public static IMovementLineMvoCommand ToCreateOrMergePatchMovementLineMvo<TCreateMovementLineMvo, TMergePatchMovementLineMvo>(this IMovementLineMvoState state)
            where TCreateMovementLineMvo : ICreateMovementLineMvo, new()
            where TMergePatchMovementLineMvo : IMergePatchMovementLineMvo, new()
        {
            bool bUnsaved = ((IMovementLineMvoState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateMovementLineMvo<TCreateMovementLineMvo>();
            }
            else 
            {
                return state.ToMergePatchMovementLineMvo<TMergePatchMovementLineMvo>();
            }
        }

        public static TDeleteMovementLineMvo ToDeleteMovementLineMvo<TDeleteMovementLineMvo>(this IMovementLineMvoState state)
            where TDeleteMovementLineMvo : IDeleteMovementLineMvo, new()
        {
            var cmd = new TDeleteMovementLineMvo();
            cmd.MovementLineId = state.MovementLineId;
            cmd.MovementVersion = ((IMovementLineMvoStateProperties)state).MovementVersion;

            return cmd;
        }

        public static TMergePatchMovementLineMvo ToMergePatchMovementLineMvo<TMergePatchMovementLineMvo>(this IMovementLineMvoState state)
            where TMergePatchMovementLineMvo : IMergePatchMovementLineMvo, new()
        {
            var cmd = new TMergePatchMovementLineMvo();

            cmd.MovementVersion = ((IMovementLineMvoStateProperties)state).MovementVersion;

            cmd.MovementLineId = state.MovementLineId;
            cmd.MovementQuantity = state.MovementQuantity;
            cmd.ProductId = state.ProductId;
            cmd.LocatorIdFrom = state.LocatorIdFrom;
            cmd.LocatorIdTo = state.LocatorIdTo;
            cmd.AttributeSetInstanceIdFrom = state.AttributeSetInstanceIdFrom;
            cmd.AttributeSetInstanceIdTo = state.AttributeSetInstanceIdTo;
            cmd.Processed = state.Processed;
            cmd.ReversalLineNumber = state.ReversalLineNumber;
            cmd.Version = ((IMovementLineMvoStateProperties)state).Version;
            cmd.Active = ((IMovementLineMvoStateProperties)state).Active;
            cmd.MovementDocumentTypeId = state.MovementDocumentTypeId;
            cmd.MovementDescription = state.MovementDescription;
            cmd.MovementCreatedBy = state.MovementCreatedBy;
            cmd.MovementCreatedAt = state.MovementCreatedAt;
            cmd.MovementUpdatedBy = state.MovementUpdatedBy;
            cmd.MovementUpdatedAt = state.MovementUpdatedAt;
            cmd.MovementActive = state.MovementActive;
            cmd.MovementDeleted = state.MovementDeleted;
            
            if (state.ProductId == null) { cmd.IsPropertyProductIdRemoved = true; }
            if (state.LocatorIdFrom == null) { cmd.IsPropertyLocatorIdFromRemoved = true; }
            if (state.LocatorIdTo == null) { cmd.IsPropertyLocatorIdToRemoved = true; }
            if (state.AttributeSetInstanceIdFrom == null) { cmd.IsPropertyAttributeSetInstanceIdFromRemoved = true; }
            if (state.AttributeSetInstanceIdTo == null) { cmd.IsPropertyAttributeSetInstanceIdToRemoved = true; }
            if (state.ReversalLineNumber == null) { cmd.IsPropertyReversalLineNumberRemoved = true; }
            if (state.MovementDocumentTypeId == null) { cmd.IsPropertyMovementDocumentTypeIdRemoved = true; }
            if (state.MovementDescription == null) { cmd.IsPropertyMovementDescriptionRemoved = true; }
            if (state.MovementCreatedBy == null) { cmd.IsPropertyMovementCreatedByRemoved = true; }
            if (state.MovementUpdatedBy == null) { cmd.IsPropertyMovementUpdatedByRemoved = true; }
            return cmd;
        }

        public static TCreateMovementLineMvo ToCreateMovementLineMvo<TCreateMovementLineMvo>(this IMovementLineMvoState state)
            where TCreateMovementLineMvo : ICreateMovementLineMvo, new()
        {
            var cmd = new TCreateMovementLineMvo();

            cmd.MovementVersion = ((IMovementLineMvoStateProperties)state).MovementVersion;

            cmd.MovementLineId = state.MovementLineId;
            cmd.MovementQuantity = state.MovementQuantity;
            cmd.ProductId = state.ProductId;
            cmd.LocatorIdFrom = state.LocatorIdFrom;
            cmd.LocatorIdTo = state.LocatorIdTo;
            cmd.AttributeSetInstanceIdFrom = state.AttributeSetInstanceIdFrom;
            cmd.AttributeSetInstanceIdTo = state.AttributeSetInstanceIdTo;
            cmd.Processed = state.Processed;
            cmd.ReversalLineNumber = state.ReversalLineNumber;
            cmd.Version = ((IMovementLineMvoStateProperties)state).Version;
            cmd.Active = ((IMovementLineMvoStateProperties)state).Active;
            cmd.MovementDocumentTypeId = state.MovementDocumentTypeId;
            cmd.MovementDescription = state.MovementDescription;
            cmd.MovementCreatedBy = state.MovementCreatedBy;
            cmd.MovementCreatedAt = state.MovementCreatedAt;
            cmd.MovementUpdatedBy = state.MovementUpdatedBy;
            cmd.MovementUpdatedAt = state.MovementUpdatedAt;
            cmd.MovementActive = state.MovementActive;
            cmd.MovementDeleted = state.MovementDeleted;
            return cmd;
        }
		

	}

}

