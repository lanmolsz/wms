﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLotDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Lot;

namespace Dddml.Wms.Domain.Lot
{

	public class LotStateEventIdDtoWrapper : LotStateEventIdDto
	{

        private LotStateEventId _value = new LotStateEventId();

		public LotStateEventIdDtoWrapper()
		{
		}

		public LotStateEventIdDtoWrapper(LotStateEventId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override LotStateEventId ToLotStateEventId()
        {
            return this._value;
        }

		public override string LotId { 
			get { return _value.LotId; } 
			set { _value.LotId = value; } 
		}

		public override long Version { 
			get { return _value.Version; } 
			set { _value.Version = value; } 
		}


	}

}

