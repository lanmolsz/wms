﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Product;

namespace Dddml.Wms.Domain.Product
{
	public interface IGoodIdentificationState : IGoodIdentificationStateProperties, 
		IGlobalIdentity<ProductGoodIdentificationId>, 
		ILocalIdentity<string>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IEntityVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IGoodIdentificationStateCreated e);

		void When(IGoodIdentificationStateMergePatched e);

		void When(IGoodIdentificationStateRemoved e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}

}
