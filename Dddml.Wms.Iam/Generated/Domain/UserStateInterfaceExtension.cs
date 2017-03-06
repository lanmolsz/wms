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

	public static partial class UserStateInterfaceExtension
	{

        public static IUserCommand ToCreateOrMergePatchUser<TCreateUser, TMergePatchUser, TCreateUserRole, TMergePatchUserRole, TCreateUserClaim, TMergePatchUserClaim, TCreateUserPermission, TMergePatchUserPermission, TCreateUserLogin, TMergePatchUserLogin>(this IUserState state)
            where TCreateUser : ICreateUser, new()
            where TMergePatchUser : IMergePatchUser, new()
            where TCreateUserRole : ICreateUserRole, new()
            where TMergePatchUserRole : IMergePatchUserRole, new()
            where TCreateUserClaim : ICreateUserClaim, new()
            where TMergePatchUserClaim : IMergePatchUserClaim, new()
            where TCreateUserPermission : ICreateUserPermission, new()
            where TMergePatchUserPermission : IMergePatchUserPermission, new()
            where TCreateUserLogin : ICreateUserLogin, new()
            where TMergePatchUserLogin : IMergePatchUserLogin, new()
        {
            bool bUnsaved = ((IUserState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateUser<TCreateUser, TCreateUserRole, TCreateUserClaim, TCreateUserPermission, TCreateUserLogin>();
            }
            else 
            {
                return state.ToMergePatchUser<TMergePatchUser, TCreateUserRole, TMergePatchUserRole, TCreateUserClaim, TMergePatchUserClaim, TCreateUserPermission, TMergePatchUserPermission, TCreateUserLogin, TMergePatchUserLogin>();
            }
        }

        public static TDeleteUser ToDeleteUser<TDeleteUser>(this IUserState state)
            where TDeleteUser : IDeleteUser, new()
        {
            var cmd = new TDeleteUser();
            cmd.UserId = state.UserId;
            cmd.Version = ((IUserStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchUser ToMergePatchUser<TMergePatchUser, TCreateUserRole, TMergePatchUserRole, TCreateUserClaim, TMergePatchUserClaim, TCreateUserPermission, TMergePatchUserPermission, TCreateUserLogin, TMergePatchUserLogin>(this IUserState state)
            where TMergePatchUser : IMergePatchUser, new()
            where TCreateUserRole : ICreateUserRole, new()
            where TMergePatchUserRole : IMergePatchUserRole, new()
            where TCreateUserClaim : ICreateUserClaim, new()
            where TMergePatchUserClaim : IMergePatchUserClaim, new()
            where TCreateUserPermission : ICreateUserPermission, new()
            where TMergePatchUserPermission : IMergePatchUserPermission, new()
            where TCreateUserLogin : ICreateUserLogin, new()
            where TMergePatchUserLogin : IMergePatchUserLogin, new()
        {
            var cmd = new TMergePatchUser();

            cmd.Version = ((IUserStateProperties)state).Version;

            cmd.UserId = state.UserId;
            cmd.UserName = state.UserName;
            cmd.AccessFailedCount = state.AccessFailedCount;
            cmd.Email = state.Email;
            cmd.EmailConfirmed = state.EmailConfirmed;
            cmd.LockoutEnabled = state.LockoutEnabled;
            cmd.LockoutEndDateUtc = state.LockoutEndDateUtc;
            cmd.PasswordHash = state.PasswordHash;
            cmd.PhoneNumber = state.PhoneNumber;
            cmd.PhoneNumberConfirmed = state.PhoneNumberConfirmed;
            cmd.TwoFactorEnabled = state.TwoFactorEnabled;
            cmd.SecurityStamp = state.SecurityStamp;
            cmd.Active = ((IUserStateProperties)state).Active;
            
            if (state.UserName == null) { cmd.IsPropertyUserNameRemoved = true; }
            if (state.Email == null) { cmd.IsPropertyEmailRemoved = true; }
            if (state.LockoutEndDateUtc == null) { cmd.IsPropertyLockoutEndDateUtcRemoved = true; }
            if (state.PasswordHash == null) { cmd.IsPropertyPasswordHashRemoved = true; }
            if (state.PhoneNumber == null) { cmd.IsPropertyPhoneNumberRemoved = true; }
            if (state.SecurityStamp == null) { cmd.IsPropertySecurityStampRemoved = true; }
            foreach (var d in state.UserRoles)
            {
                var c = d.ToCreateOrMergePatchUserRole<TCreateUserRole, TMergePatchUserRole>();
                cmd.UserRoleCommands.Add(c);
            }
            foreach (var d in state.UserClaims)
            {
                var c = d.ToCreateOrMergePatchUserClaim<TCreateUserClaim, TMergePatchUserClaim>();
                cmd.UserClaimCommands.Add(c);
            }
            foreach (var d in state.UserPermissions)
            {
                var c = d.ToCreateOrMergePatchUserPermission<TCreateUserPermission, TMergePatchUserPermission>();
                cmd.UserPermissionCommands.Add(c);
            }
            foreach (var d in state.UserLogins)
            {
                var c = d.ToCreateOrMergePatchUserLogin<TCreateUserLogin, TMergePatchUserLogin>();
                cmd.UserLoginCommands.Add(c);
            }
            return cmd;
        }

        public static TCreateUser ToCreateUser<TCreateUser, TCreateUserRole, TCreateUserClaim, TCreateUserPermission, TCreateUserLogin>(this IUserState state)
            where TCreateUser : ICreateUser, new()
            where TCreateUserRole : ICreateUserRole, new()
            where TCreateUserClaim : ICreateUserClaim, new()
            where TCreateUserPermission : ICreateUserPermission, new()
            where TCreateUserLogin : ICreateUserLogin, new()
        {
            var cmd = new TCreateUser();

            cmd.Version = ((IUserStateProperties)state).Version;

            cmd.UserId = state.UserId;
            cmd.UserName = state.UserName;
            cmd.AccessFailedCount = state.AccessFailedCount;
            cmd.Email = state.Email;
            cmd.EmailConfirmed = state.EmailConfirmed;
            cmd.LockoutEnabled = state.LockoutEnabled;
            cmd.LockoutEndDateUtc = state.LockoutEndDateUtc;
            cmd.PasswordHash = state.PasswordHash;
            cmd.PhoneNumber = state.PhoneNumber;
            cmd.PhoneNumberConfirmed = state.PhoneNumberConfirmed;
            cmd.TwoFactorEnabled = state.TwoFactorEnabled;
            cmd.SecurityStamp = state.SecurityStamp;
            cmd.Active = ((IUserStateProperties)state).Active;
            foreach (var d in state.UserRoles)
            {
                var c = d.ToCreateUserRole<TCreateUserRole>();
                cmd.UserRoles.Add(c);
            }
            foreach (var d in state.UserClaims)
            {
                var c = d.ToCreateUserClaim<TCreateUserClaim>();
                cmd.UserClaims.Add(c);
            }
            foreach (var d in state.UserPermissions)
            {
                var c = d.ToCreateUserPermission<TCreateUserPermission>();
                cmd.UserPermissions.Add(c);
            }
            foreach (var d in state.UserLogins)
            {
                var c = d.ToCreateUserLogin<TCreateUserLogin>();
                cmd.UserLogins.Add(c);
            }
            return cmd;
        }
		

	}

}

