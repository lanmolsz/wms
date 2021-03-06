﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

	public partial class UserLoginState : UserLoginStateProperties, IUserLoginState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

        private UserLoginId _userLoginId = new UserLoginId();

        public virtual UserLoginId UserLoginId 
        {
            get { return this._userLoginId; }
            set { this._userLoginId = value; }
        }

		UserLoginId IGlobalIdentity<UserLoginId>.GlobalId {
			get {
				return  this.UserLoginId;
			}
		}

        LoginKey ILocalIdentity<LoginKey>.LocalId
        {
            get
            {
                return this.LoginKey;
            }
        }


        public override string UserId {
			get {
				return this.UserLoginId.UserId;
			}
			set {
				this.UserLoginId.UserId = value;
			}
		}

        public override LoginKey LoginKey {
			get {
				return this.UserLoginId.LoginKey;
			}
			set {
				this.UserLoginId.LoginKey = value;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IEntityVersioned<long>.EntityVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IUserLoginState.IsUnsaved
        {
            get { return this.Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public UserLoginState() : this(false)
        {
        }

        public UserLoginState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IUserLoginStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IUserLoginStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IUserLoginStateRemoved e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IUserLoginEvent e)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("UserLogin|");

            var stateEntityIdUserId = (this as IGlobalIdentity<UserLoginId>).GlobalId.UserId;
            var eventEntityIdUserId = e.UserLoginEventId.UserId;
            if (stateEntityIdUserId != eventEntityIdUserId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id UserId {0} in state but entity id UserId {1} in event", stateEntityIdUserId, eventEntityIdUserId);
            }
            id.Append(stateEntityIdUserId).Append(",");

            var stateEntityIdLoginKey = (this as IGlobalIdentity<UserLoginId>).GlobalId.LoginKey;
            var eventEntityIdLoginKey = e.UserLoginEventId.LoginKey;
            if (stateEntityIdLoginKey != eventEntityIdLoginKey)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id LoginKey {0} in state but entity id LoginKey {1} in event", stateEntityIdLoginKey, eventEntityIdLoginKey);
            }
            id.Append(stateEntityIdLoginKey).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var stateEvent = e is IUserLoginStateEvent ? (IUserLoginStateEvent)e : null;
            if (e == null) { return; }
            stateEvent.Version = stateVersion;
            //var stateEventStateVersion = stateEvent.Version;
            //if (UserLoginState.VersionZero == stateEventStateVersion)
            //{
            //    stateEventStateVersion = stateEvent.Version = stateVersion;
            //}
            //if (stateVersion != stateEventStateVersion)
            //{
            //    throw OptimisticConcurrencyException.Create(stateVersion, stateEventStateVersion, id.ToString());
            //}
        }
    }

}

