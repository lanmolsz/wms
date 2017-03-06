﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

	public abstract class UserStateProperties : IUserStateProperties
	{
		public virtual string UserId { get; set; }

		public virtual string UserName { get; set; }

		public virtual int AccessFailedCount { get; set; }

		public virtual string Email { get; set; }

		public virtual bool EmailConfirmed { get; set; }

		public virtual bool LockoutEnabled { get; set; }

		public virtual DateTime? LockoutEndDateUtc { get; set; }

		public virtual string PasswordHash { get; set; }

		public virtual string PhoneNumber { get; set; }

		public virtual bool PhoneNumberConfirmed { get; set; }

		public virtual bool TwoFactorEnabled { get; set; }

		public virtual string SecurityStamp { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
