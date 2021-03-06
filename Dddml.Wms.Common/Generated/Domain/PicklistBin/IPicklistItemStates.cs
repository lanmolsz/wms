﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistBinDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistBin;

namespace Dddml.Wms.Domain.PicklistBin
{

    public interface IPicklistItemStates : IEnumerable<IPicklistItemState>, ISaveable
    {
        
        IPicklistItemState Get(PicklistItemOrderShipGrpInvId picklistItemOrderShipGrpInvId);

        IPicklistItemState Get(PicklistItemOrderShipGrpInvId picklistItemOrderShipGrpInvId, bool forCreation);

        IPicklistItemState Get(PicklistItemOrderShipGrpInvId picklistItemOrderShipGrpInvId, bool forCreation, bool nullAllowed);
        
        void Remove(IPicklistItemState state);

        void AddToSave(IPicklistItemState state);
        
    }

}


