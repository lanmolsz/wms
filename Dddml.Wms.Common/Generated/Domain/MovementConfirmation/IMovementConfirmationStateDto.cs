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

    public interface IMovementConfirmationStateDto
    {
        string DocumentNumber
        {
            get;
            set;
        }

        string DocumentTypeId
        {
            get;
            set;
        }

        string DocumentStatusId
        {
            get;
            set;
        }

        string MovementDocumentNumber
        {
            get;
            set;
        }

        bool? IsApproved
        {
            get;
            set;
        }

        decimal? ApprovalAmount
        {
            get;
            set;
        }

        string Processing
        {
            get;
            set;
        }

        bool? Processed
        {
            get;
            set;
        }

        string Description
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

        IMovementConfirmationLineStateDto[] MovementConfirmationLines
        {
            get;
            set;
        }

        IMovementConfirmationState ToMovementConfirmationState();

    }

}

