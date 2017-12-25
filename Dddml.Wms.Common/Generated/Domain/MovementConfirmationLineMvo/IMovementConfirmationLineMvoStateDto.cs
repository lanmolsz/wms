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

    public interface IMovementConfirmationLineMvoStateDto
    {

        MovementConfirmationLineIdDto MovementConfirmationLineId
        {
            get;
            set;
        }

        string MovementLineNumber
        {
            get;
            set;
        }

        decimal? TargetQuantity
        {
            get;
            set;
        }

        decimal? ConfirmedQuantity
        {
            get;
            set;
        }

        decimal? DifferenceQuantity
        {
            get;
            set;
        }

        decimal? ScrappedQuantity
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        bool? Processed
        {
            get;
            set;
        }

        long? Version
        {
            get;
            set;
        }

        bool? Active
        {
            get;
            set;
        }

        string MovementConfirmationDocumentStatusId
        {
            get;
            set;
        }

        string MovementConfirmationMovementDocumentNumber
        {
            get;
            set;
        }

        bool? MovementConfirmationIsApproved
        {
            get;
            set;
        }

        decimal? MovementConfirmationApprovalAmount
        {
            get;
            set;
        }

        bool? MovementConfirmationProcessed
        {
            get;
            set;
        }

        string MovementConfirmationProcessing
        {
            get;
            set;
        }

        string MovementConfirmationDocumentTypeId
        {
            get;
            set;
        }

        string MovementConfirmationDescription
        {
            get;
            set;
        }

        string MovementConfirmationCreatedBy
        {
            get;
            set;
        }

        DateTime? MovementConfirmationCreatedAt
        {
            get;
            set;
        }

        string MovementConfirmationUpdatedBy
        {
            get;
            set;
        }

        DateTime? MovementConfirmationUpdatedAt
        {
            get;
            set;
        }

        bool? MovementConfirmationActive
        {
            get;
            set;
        }

        bool? MovementConfirmationDeleted
        {
            get;
            set;
        }

        long? MovementConfirmationVersion
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

        IMovementConfirmationLineMvoState ToMovementConfirmationLineMvoState();

    }

}

