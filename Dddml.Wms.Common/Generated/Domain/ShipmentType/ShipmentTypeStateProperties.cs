﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentType;

namespace Dddml.Wms.Domain.ShipmentType
{

	public abstract class ShipmentTypeStateProperties : IShipmentTypeStateProperties
	{
		public virtual string ShipmentTypeId { get; set; }

		public virtual string ParentTypeId { get; set; }

		public virtual string HasTable { get; set; }

		public virtual string Description { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
