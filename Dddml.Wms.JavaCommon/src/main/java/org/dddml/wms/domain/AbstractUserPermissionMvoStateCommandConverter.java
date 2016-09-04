package org.dddml.wms.domain;

import java.util.*;
import java.util.Date;

public abstract class AbstractUserPermissionMvoStateCommandConverter<TCreateUserPermissionMvo extends UserPermissionMvoCommand.CreateUserPermissionMvo, TMergePatchUserPermissionMvo extends UserPermissionMvoCommand.MergePatchUserPermissionMvo, TDeleteUserPermissionMvo extends UserPermissionMvoCommand.DeleteUserPermissionMvo>
{
    public UserPermissionMvoCommand toCreateOrMergePatchUserPermissionMvo(UserPermissionMvoState state)
    {
        //where TCreateUserPermissionMvo : ICreateUserPermissionMvo, new()
        //where TMergePatchUserPermissionMvo : IMergePatchUserPermissionMvo, new()
        boolean bUnsaved = state.isStateUnsaved();
        if (bUnsaved)
        {
            return toCreateUserPermissionMvo(state);
        }
        else 
        {
            return toMergePatchUserPermissionMvo(state);
        }
    }

    public TDeleteUserPermissionMvo toDeleteUserPermissionMvo(UserPermissionMvoState state) //where TDeleteUserPermissionMvo : IDeleteUserPermissionMvo, new()
    {
        TDeleteUserPermissionMvo cmd = newDeleteUserPermissionMvo();
        cmd.setUserPermissionId(state.getUserPermissionId());
        cmd.setUserVersion(state.getUserVersion());

        return cmd;
    }

    public TMergePatchUserPermissionMvo toMergePatchUserPermissionMvo(UserPermissionMvoState state) //where TMergePatchUserPermissionMvo : IMergePatchUserPermissionMvo, new()
    {
        TMergePatchUserPermissionMvo cmd = newMergePatchUserPermissionMvo();

        cmd.setUserVersion(state.getUserVersion());

        cmd.setUserPermissionId(state.getUserPermissionId());
        cmd.setVersion(state.getVersion());
        cmd.setActive(state.getActive());
        cmd.setUserUserName(state.getUserUserName());
        cmd.setUserAccessFailedCount(state.getUserAccessFailedCount());
        cmd.setUserEmail(state.getUserEmail());
        cmd.setUserEmailConfirmed(state.getUserEmailConfirmed());
        cmd.setUserLockoutEnabled(state.getUserLockoutEnabled());
        cmd.setUserLockoutEndDateUtc(state.getUserLockoutEndDateUtc());
        cmd.setUserPasswordHash(state.getUserPasswordHash());
        cmd.setUserPhoneNumber(state.getUserPhoneNumber());
        cmd.setUserPhoneNumberConfirmed(state.getUserPhoneNumberConfirmed());
        cmd.setUserTwoFactorEnabled(state.getUserTwoFactorEnabled());
        cmd.setUserSecurityStamp(state.getUserSecurityStamp());
        cmd.setUserCreatedBy(state.getUserCreatedBy());
        cmd.setUserCreatedAt(state.getUserCreatedAt());
        cmd.setUserUpdatedBy(state.getUserUpdatedBy());
        cmd.setUserUpdatedAt(state.getUserUpdatedAt());
        cmd.setUserActive(state.getUserActive());
        cmd.setUserDeleted(state.getUserDeleted());
            
        if (state.getVersion() == null) { cmd.setIsPropertyVersionRemoved(true); }
        if (state.getActive() == null) { cmd.setIsPropertyActiveRemoved(true); }
        if (state.getUserUserName() == null) { cmd.setIsPropertyUserUserNameRemoved(true); }
        if (state.getUserAccessFailedCount() == null) { cmd.setIsPropertyUserAccessFailedCountRemoved(true); }
        if (state.getUserEmail() == null) { cmd.setIsPropertyUserEmailRemoved(true); }
        if (state.getUserEmailConfirmed() == null) { cmd.setIsPropertyUserEmailConfirmedRemoved(true); }
        if (state.getUserLockoutEnabled() == null) { cmd.setIsPropertyUserLockoutEnabledRemoved(true); }
        if (state.getUserLockoutEndDateUtc() == null) { cmd.setIsPropertyUserLockoutEndDateUtcRemoved(true); }
        if (state.getUserPasswordHash() == null) { cmd.setIsPropertyUserPasswordHashRemoved(true); }
        if (state.getUserPhoneNumber() == null) { cmd.setIsPropertyUserPhoneNumberRemoved(true); }
        if (state.getUserPhoneNumberConfirmed() == null) { cmd.setIsPropertyUserPhoneNumberConfirmedRemoved(true); }
        if (state.getUserTwoFactorEnabled() == null) { cmd.setIsPropertyUserTwoFactorEnabledRemoved(true); }
        if (state.getUserSecurityStamp() == null) { cmd.setIsPropertyUserSecurityStampRemoved(true); }
        if (state.getUserCreatedBy() == null) { cmd.setIsPropertyUserCreatedByRemoved(true); }
        if (state.getUserCreatedAt() == null) { cmd.setIsPropertyUserCreatedAtRemoved(true); }
        if (state.getUserUpdatedBy() == null) { cmd.setIsPropertyUserUpdatedByRemoved(true); }
        if (state.getUserUpdatedAt() == null) { cmd.setIsPropertyUserUpdatedAtRemoved(true); }
        if (state.getUserActive() == null) { cmd.setIsPropertyUserActiveRemoved(true); }
        if (state.getUserDeleted() == null) { cmd.setIsPropertyUserDeletedRemoved(true); }
        return cmd;
    }

    public TCreateUserPermissionMvo toCreateUserPermissionMvo(UserPermissionMvoState state) //where TCreateUserPermissionMvo : ICreateUserPermissionMvo, new()
    {
        TCreateUserPermissionMvo cmd = newCreateUserPermissionMvo();

        cmd.setUserVersion(state.getUserVersion());
        cmd.setUserPermissionId(state.getUserPermissionId());
        cmd.setVersion(state.getVersion());
        cmd.setActive(state.getActive());
        cmd.setUserUserName(state.getUserUserName());
        cmd.setUserAccessFailedCount(state.getUserAccessFailedCount());
        cmd.setUserEmail(state.getUserEmail());
        cmd.setUserEmailConfirmed(state.getUserEmailConfirmed());
        cmd.setUserLockoutEnabled(state.getUserLockoutEnabled());
        cmd.setUserLockoutEndDateUtc(state.getUserLockoutEndDateUtc());
        cmd.setUserPasswordHash(state.getUserPasswordHash());
        cmd.setUserPhoneNumber(state.getUserPhoneNumber());
        cmd.setUserPhoneNumberConfirmed(state.getUserPhoneNumberConfirmed());
        cmd.setUserTwoFactorEnabled(state.getUserTwoFactorEnabled());
        cmd.setUserSecurityStamp(state.getUserSecurityStamp());
        cmd.setUserCreatedBy(state.getUserCreatedBy());
        cmd.setUserCreatedAt(state.getUserCreatedAt());
        cmd.setUserUpdatedBy(state.getUserUpdatedBy());
        cmd.setUserUpdatedAt(state.getUserUpdatedAt());
        cmd.setUserActive(state.getUserActive());
        cmd.setUserDeleted(state.getUserDeleted());
        return cmd;
    }

    protected abstract TCreateUserPermissionMvo newCreateUserPermissionMvo();

    protected abstract TMergePatchUserPermissionMvo newMergePatchUserPermissionMvo(); 

    protected abstract TDeleteUserPermissionMvo newDeleteUserPermissionMvo();

    public static class SimpleUserPermissionMvoStateCommandConverter extends AbstractUserPermissionMvoStateCommandConverter<AbstractUserPermissionMvoCommand.SimpleCreateUserPermissionMvo, AbstractUserPermissionMvoCommand.SimpleMergePatchUserPermissionMvo, AbstractUserPermissionMvoCommand.SimpleDeleteUserPermissionMvo>
    {
        @Override
        protected AbstractUserPermissionMvoCommand.SimpleCreateUserPermissionMvo newCreateUserPermissionMvo() {
            return new AbstractUserPermissionMvoCommand.SimpleCreateUserPermissionMvo();
        }

        @Override
        protected AbstractUserPermissionMvoCommand.SimpleMergePatchUserPermissionMvo newMergePatchUserPermissionMvo() {
            return new AbstractUserPermissionMvoCommand.SimpleMergePatchUserPermissionMvo();
        }

        @Override
        protected AbstractUserPermissionMvoCommand.SimpleDeleteUserPermissionMvo newDeleteUserPermissionMvo() {
            return new AbstractUserPermissionMvoCommand.SimpleDeleteUserPermissionMvo();
        }


    }

}

