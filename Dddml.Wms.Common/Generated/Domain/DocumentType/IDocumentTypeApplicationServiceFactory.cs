﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDocumentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DocumentType;

namespace Dddml.Wms.Domain.DocumentType
{

    public partial interface IDocumentTypeApplicationServiceFactory
    {

        IDocumentTypeApplicationService DocumentTypeApplicationService { get; }

        ICreateDocumentType NewCreateDocumentType();

        IMergePatchDocumentType NewMergePatchDocumentType();

        IDeleteDocumentType NewDeleteDocumentType();
    }


}

