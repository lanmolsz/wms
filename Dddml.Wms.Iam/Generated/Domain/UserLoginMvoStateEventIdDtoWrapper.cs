﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserLoginMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserLoginMvo
{

	public class UserLoginMvoStateEventIdDtoWrapper : UserLoginMvoStateEventIdDto
	{

        private UserLoginMvoStateEventId _value = new UserLoginMvoStateEventId();

		public UserLoginMvoStateEventIdDtoWrapper()
		{
		}

		public UserLoginMvoStateEventIdDtoWrapper(UserLoginMvoStateEventId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override UserLoginMvoStateEventId ToUserLoginMvoStateEventId()
        {
            return this._value;
        }

		public override UserLoginIdDto UserLoginId { 
			get { return new UserLoginIdDtoWrapper(_value.UserLoginId); } 
			set { _value.UserLoginId = value.ToUserLoginId(); } 
		}

		public override long UserVersion { 
			get { return _value.UserVersion; } 
			set { _value.UserVersion = value; } 
		}


	}

}


