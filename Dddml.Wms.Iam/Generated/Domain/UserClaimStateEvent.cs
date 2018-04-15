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

	public abstract class UserClaimStateEventBase : IUserClaimStateEvent
	{

		public virtual UserClaimEventId UserClaimEventId { get; set; }

        public virtual int ClaimId
        {
            get { return UserClaimEventId.ClaimId; }
            set { UserClaimEventId.ClaimId = value; }
        }

		public virtual string ClaimType { get; set; }

		public virtual string ClaimValue { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		UserClaimEventId IGlobalIdentity<UserClaimEventId>.GlobalId {
			get
			{
				return this.UserClaimEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IUserClaimStateEvent.ReadOnly
        {
            get
            {
                return this.EventReadOnly;
            }
            set
            {
                this.EventReadOnly = value;
            }
        }

		public virtual long Version { get; set; }


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

        protected UserClaimStateEventBase()
        {
        }

        protected UserClaimStateEventBase(UserClaimEventId stateEventId)
        {
            this.UserClaimEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class UserClaimStateCreated : UserClaimStateEventBase, IUserClaimStateCreated
	{
		public UserClaimStateCreated () : this(new UserClaimEventId())
		{
		}

		public UserClaimStateCreated (UserClaimEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class UserClaimStateMergePatched : UserClaimStateEventBase, IUserClaimStateMergePatched
	{
		public virtual bool IsPropertyClaimTypeRemoved { get; set; }

		public virtual bool IsPropertyClaimValueRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public UserClaimStateMergePatched ()
		{
		}

		public UserClaimStateMergePatched (UserClaimEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class UserClaimStateRemoved : UserClaimStateEventBase, IUserClaimStateRemoved
	{
		public UserClaimStateRemoved ()
		{
		}

		public UserClaimStateRemoved (UserClaimEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}

