﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEventTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEventType;

namespace Dddml.Wms.Domain.InventoryItemEventType
{

	public static partial class InventoryItemEventTypeStateInterfaceExtension
	{

        public static IInventoryItemEventTypeCommand ToCreateOrMergePatchInventoryItemEventType<TCreateInventoryItemEventType, TMergePatchInventoryItemEventType>(this IInventoryItemEventTypeState state)
            where TCreateInventoryItemEventType : ICreateInventoryItemEventType, new()
            where TMergePatchInventoryItemEventType : IMergePatchInventoryItemEventType, new()
        {
            bool bUnsaved = ((IInventoryItemEventTypeState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateInventoryItemEventType<TCreateInventoryItemEventType>();
            }
            else 
            {
                return state.ToMergePatchInventoryItemEventType<TMergePatchInventoryItemEventType>();
            }
        }

        public static TDeleteInventoryItemEventType ToDeleteInventoryItemEventType<TDeleteInventoryItemEventType>(this IInventoryItemEventTypeState state)
            where TDeleteInventoryItemEventType : IDeleteInventoryItemEventType, new()
        {
            var cmd = new TDeleteInventoryItemEventType();
            cmd.InventoryItemEventTypeId = state.InventoryItemEventTypeId;
            cmd.Version = ((IInventoryItemEventTypeStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchInventoryItemEventType ToMergePatchInventoryItemEventType<TMergePatchInventoryItemEventType>(this IInventoryItemEventTypeState state)
            where TMergePatchInventoryItemEventType : IMergePatchInventoryItemEventType, new()
        {
            var cmd = new TMergePatchInventoryItemEventType();

            cmd.Version = ((IInventoryItemEventTypeStateProperties)state).Version;

            cmd.InventoryItemEventTypeId = state.InventoryItemEventTypeId;
            cmd.Description = state.Description;
            cmd.Active = ((IInventoryItemEventTypeStateProperties)state).Active;
            
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            return cmd;
        }

        public static TCreateInventoryItemEventType ToCreateInventoryItemEventType<TCreateInventoryItemEventType>(this IInventoryItemEventTypeState state)
            where TCreateInventoryItemEventType : ICreateInventoryItemEventType, new()
        {
            var cmd = new TCreateInventoryItemEventType();

            cmd.Version = ((IInventoryItemEventTypeStateProperties)state).Version;

            cmd.InventoryItemEventTypeId = state.InventoryItemEventTypeId;
            cmd.Description = state.Description;
            cmd.Active = ((IInventoryItemEventTypeStateProperties)state).Active;
            return cmd;
        }
		

	}

}
