package org.dddml.wms.domain;

import java.io.Serializable;

public class UserPermissionMvoStateEventId implements Serializable
{
    private UserPermissionId userPermissionId = new UserPermissionId();

    public UserPermissionId getUserPermissionId()
    {
        return this.userPermissionId;
    }

    public void setUserPermissionId(UserPermissionId userPermissionId)
    {
        this.userPermissionId = userPermissionId;
    }

    private Long userVersion;

    public Long getUserVersion()
    {
        return this.userVersion;
    }

    public void setUserVersion(Long userVersion)
    {
        this.userVersion = userVersion;
    }

    public String getUserPermissionIdUserId()
    {
        return getUserPermissionId().getUserId();
    }

    public void setUserPermissionIdUserId(String userPermissionIdUserId)
    {
        getUserPermissionId().setUserId(userPermissionIdUserId);
    }

    public String getUserPermissionIdPermissionId()
    {
        return getUserPermissionId().getPermissionId();
    }

    public void setUserPermissionIdPermissionId(String userPermissionIdPermissionId)
    {
        getUserPermissionId().setPermissionId(userPermissionIdPermissionId);
    }

    public UserPermissionMvoStateEventId()
    {
    }

    public UserPermissionMvoStateEventId(UserPermissionId userPermissionId, Long userVersion)
    {
        this.userPermissionId = userPermissionId;
        this.userVersion = userVersion;
    }

    @Override
    public boolean equals(Object obj)
    {
        if (obj == this) {
            return true;
        }
        if (obj == null || obj.getClass() != this.getClass()) {
            return false;
        }

        UserPermissionMvoStateEventId other = (UserPermissionMvoStateEventId)obj;
        return true 
            && (userPermissionId == other.userPermissionId || (userPermissionId != null && userPermissionId.equals(other.userPermissionId)))
            && (userVersion == other.userVersion || (userVersion != null && userVersion.equals(other.userVersion)))
            ;
    }

    @Override
    public int hashCode()
    {
        int hash = 0;
        if (this.userPermissionId != null) {
            hash += 13 * this.userPermissionId.hashCode();
        }
        if (this.userVersion != null) {
            hash += 13 * this.userVersion.hashCode();
        }
        return hash;
    }

}

