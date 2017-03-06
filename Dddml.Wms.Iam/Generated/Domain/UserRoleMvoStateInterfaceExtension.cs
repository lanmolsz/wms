﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserRoleMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserRoleMvo
{

	public static partial class UserRoleMvoStateInterfaceExtension
	{

        public static IUserRoleMvoCommand ToCreateOrMergePatchUserRoleMvo<TCreateUserRoleMvo, TMergePatchUserRoleMvo>(this IUserRoleMvoState state)
            where TCreateUserRoleMvo : ICreateUserRoleMvo, new()
            where TMergePatchUserRoleMvo : IMergePatchUserRoleMvo, new()
        {
            bool bUnsaved = ((IUserRoleMvoState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateUserRoleMvo<TCreateUserRoleMvo>();
            }
            else 
            {
                return state.ToMergePatchUserRoleMvo<TMergePatchUserRoleMvo>();
            }
        }

        public static TDeleteUserRoleMvo ToDeleteUserRoleMvo<TDeleteUserRoleMvo>(this IUserRoleMvoState state)
            where TDeleteUserRoleMvo : IDeleteUserRoleMvo, new()
        {
            var cmd = new TDeleteUserRoleMvo();
            cmd.UserRoleId = state.UserRoleId;
            cmd.UserVersion = ((IUserRoleMvoStateProperties)state).UserVersion;

            return cmd;
        }

        public static TMergePatchUserRoleMvo ToMergePatchUserRoleMvo<TMergePatchUserRoleMvo>(this IUserRoleMvoState state)
            where TMergePatchUserRoleMvo : IMergePatchUserRoleMvo, new()
        {
            var cmd = new TMergePatchUserRoleMvo();

            cmd.UserVersion = ((IUserRoleMvoStateProperties)state).UserVersion;

            cmd.UserRoleId = state.UserRoleId;
            cmd.Version = ((IUserRoleMvoStateProperties)state).Version;
            cmd.Active = ((IUserRoleMvoStateProperties)state).Active;
            cmd.UserUserName = state.UserUserName;
            cmd.UserAccessFailedCount = state.UserAccessFailedCount;
            cmd.UserEmail = state.UserEmail;
            cmd.UserEmailConfirmed = state.UserEmailConfirmed;
            cmd.UserLockoutEnabled = state.UserLockoutEnabled;
            cmd.UserLockoutEndDateUtc = state.UserLockoutEndDateUtc;
            cmd.UserPasswordHash = state.UserPasswordHash;
            cmd.UserPhoneNumber = state.UserPhoneNumber;
            cmd.UserPhoneNumberConfirmed = state.UserPhoneNumberConfirmed;
            cmd.UserTwoFactorEnabled = state.UserTwoFactorEnabled;
            cmd.UserSecurityStamp = state.UserSecurityStamp;
            cmd.UserCreatedBy = state.UserCreatedBy;
            cmd.UserCreatedAt = state.UserCreatedAt;
            cmd.UserUpdatedBy = state.UserUpdatedBy;
            cmd.UserUpdatedAt = state.UserUpdatedAt;
            cmd.UserActive = state.UserActive;
            cmd.UserDeleted = state.UserDeleted;
            
            if (state.UserUserName == null) { cmd.IsPropertyUserUserNameRemoved = true; }
            if (state.UserEmail == null) { cmd.IsPropertyUserEmailRemoved = true; }
            if (state.UserLockoutEndDateUtc == null) { cmd.IsPropertyUserLockoutEndDateUtcRemoved = true; }
            if (state.UserPasswordHash == null) { cmd.IsPropertyUserPasswordHashRemoved = true; }
            if (state.UserPhoneNumber == null) { cmd.IsPropertyUserPhoneNumberRemoved = true; }
            if (state.UserSecurityStamp == null) { cmd.IsPropertyUserSecurityStampRemoved = true; }
            if (state.UserCreatedBy == null) { cmd.IsPropertyUserCreatedByRemoved = true; }
            if (state.UserUpdatedBy == null) { cmd.IsPropertyUserUpdatedByRemoved = true; }
            return cmd;
        }

        public static TCreateUserRoleMvo ToCreateUserRoleMvo<TCreateUserRoleMvo>(this IUserRoleMvoState state)
            where TCreateUserRoleMvo : ICreateUserRoleMvo, new()
        {
            var cmd = new TCreateUserRoleMvo();

            cmd.UserVersion = ((IUserRoleMvoStateProperties)state).UserVersion;

            cmd.UserRoleId = state.UserRoleId;
            cmd.Version = ((IUserRoleMvoStateProperties)state).Version;
            cmd.Active = ((IUserRoleMvoStateProperties)state).Active;
            cmd.UserUserName = state.UserUserName;
            cmd.UserAccessFailedCount = state.UserAccessFailedCount;
            cmd.UserEmail = state.UserEmail;
            cmd.UserEmailConfirmed = state.UserEmailConfirmed;
            cmd.UserLockoutEnabled = state.UserLockoutEnabled;
            cmd.UserLockoutEndDateUtc = state.UserLockoutEndDateUtc;
            cmd.UserPasswordHash = state.UserPasswordHash;
            cmd.UserPhoneNumber = state.UserPhoneNumber;
            cmd.UserPhoneNumberConfirmed = state.UserPhoneNumberConfirmed;
            cmd.UserTwoFactorEnabled = state.UserTwoFactorEnabled;
            cmd.UserSecurityStamp = state.UserSecurityStamp;
            cmd.UserCreatedBy = state.UserCreatedBy;
            cmd.UserCreatedAt = state.UserCreatedAt;
            cmd.UserUpdatedBy = state.UserUpdatedBy;
            cmd.UserUpdatedAt = state.UserUpdatedAt;
            cmd.UserActive = state.UserActive;
            cmd.UserDeleted = state.UserDeleted;
            return cmd;
        }
		

	}

}

