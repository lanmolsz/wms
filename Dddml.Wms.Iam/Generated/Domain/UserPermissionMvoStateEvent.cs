﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserPermissionMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserPermissionMvo
{

	public abstract class UserPermissionMvoStateEventBase : IUserPermissionMvoStateEvent
	{

		public virtual UserPermissionMvoEventId StateEventId { get; set; }

        public virtual UserPermissionId UserPermissionId
        {
            get { return StateEventId.UserPermissionId; }
            set { StateEventId.UserPermissionId = value; }
        }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string UserUserName { get; set; }

		public virtual int? UserAccessFailedCount { get; set; }

		public virtual string UserEmail { get; set; }

		public virtual bool? UserEmailConfirmed { get; set; }

		public virtual bool? UserLockoutEnabled { get; set; }

		public virtual DateTime? UserLockoutEndDateUtc { get; set; }

		public virtual string UserPasswordHash { get; set; }

		public virtual string UserPhoneNumber { get; set; }

		public virtual bool? UserPhoneNumberConfirmed { get; set; }

		public virtual bool? UserTwoFactorEnabled { get; set; }

		public virtual string UserSecurityStamp { get; set; }

		public virtual string UserCreatedBy { get; set; }

		public virtual DateTime? UserCreatedAt { get; set; }

		public virtual string UserUpdatedBy { get; set; }

		public virtual DateTime? UserUpdatedAt { get; set; }

		public virtual bool? UserActive { get; set; }

		public virtual bool? UserDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		UserPermissionMvoEventId IGlobalIdentity<UserPermissionMvoEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IUserPermissionMvoStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}

        protected UserPermissionMvoStateEventBase()
        {
        }

        protected UserPermissionMvoStateEventBase(UserPermissionMvoEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class UserPermissionMvoStateCreated : UserPermissionMvoStateEventBase, IUserPermissionMvoStateCreated
	{
		public UserPermissionMvoStateCreated () : this(new UserPermissionMvoEventId())
		{
		}

		public UserPermissionMvoStateCreated (UserPermissionMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class UserPermissionMvoStateMergePatched : UserPermissionMvoStateEventBase, IUserPermissionMvoStateMergePatched
	{
		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyUserUserNameRemoved { get; set; }

		public virtual bool IsPropertyUserAccessFailedCountRemoved { get; set; }

		public virtual bool IsPropertyUserEmailRemoved { get; set; }

		public virtual bool IsPropertyUserEmailConfirmedRemoved { get; set; }

		public virtual bool IsPropertyUserLockoutEnabledRemoved { get; set; }

		public virtual bool IsPropertyUserLockoutEndDateUtcRemoved { get; set; }

		public virtual bool IsPropertyUserPasswordHashRemoved { get; set; }

		public virtual bool IsPropertyUserPhoneNumberRemoved { get; set; }

		public virtual bool IsPropertyUserPhoneNumberConfirmedRemoved { get; set; }

		public virtual bool IsPropertyUserTwoFactorEnabledRemoved { get; set; }

		public virtual bool IsPropertyUserSecurityStampRemoved { get; set; }

		public virtual bool IsPropertyUserCreatedByRemoved { get; set; }

		public virtual bool IsPropertyUserCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyUserUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyUserUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyUserActiveRemoved { get; set; }

		public virtual bool IsPropertyUserDeletedRemoved { get; set; }


		public UserPermissionMvoStateMergePatched ()
		{
		}

		public UserPermissionMvoStateMergePatched (UserPermissionMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class UserPermissionMvoStateDeleted : UserPermissionMvoStateEventBase, IUserPermissionMvoStateDeleted
	{
		public UserPermissionMvoStateDeleted ()
		{
		}

		public UserPermissionMvoStateDeleted (UserPermissionMvoEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

