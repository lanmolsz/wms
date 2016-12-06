﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

    public interface IAttributeSetStateDto
    {
        string AttributeSetId
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        string OrganizationId
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        string SerialNumberAttributeId
        {
            get;
            set;
        }

        string LotAttributeId
        {
            get;
            set;
        }

        string ReferenceId
        {
            get;
            set;
        }

        bool? Active
        {
            get;
            set;
        }

        long? Version
        {
            get;
            set;
        }

        string CreatedBy
        {
            get;
            set;
        }

        DateTime? CreatedAt
        {
            get;
            set;
        }

        string UpdatedBy
        {
            get;
            set;
        }

        DateTime? UpdatedAt
        {
            get;
            set;
        }

        IAttributeUseStateDto[] AttributeUses
        {
            get;
            set;
        }

        IAttributeSetState ToAttributeSetState();

    }

}
