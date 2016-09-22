package org.dddml.wms.domain;


public class PermissionStateEventIdDto
{

    public PermissionStateEventIdDto()
    {
    }

    public PermissionStateEventId toPermissionStateEventId()
    {
        PermissionStateEventId v = new PermissionStateEventId();
        v.setPermissionId(this.getPermissionId());
        v.setVersion(this.getVersion());
        return v;
    }

    private String permissionId;

    public String getPermissionId()
    {
        return this.permissionId;
    }

    public void setPermissionId(String permissionId)
    {
        this.permissionId = permissionId;
    }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }


    @Override
    public boolean equals(Object obj)
    {
        if (obj == this) {
            return true;
        }
        if (obj == null || obj.getClass() != PermissionStateEventIdDto.class) {
            return false;
        }

        PermissionStateEventIdDto other = (PermissionStateEventIdDto)obj;
        return true 
            && (permissionId == other.permissionId || (permissionId != null && permissionId.equals(other.permissionId)))
            && (version == other.version || (version != null && version.equals(other.version)))
            ;

    }

    @Override
    public int hashCode()
    {
        int hash = 0;
        if (this.permissionId != null) {
            hash += 13 * this.permissionId.hashCode();
        }
        if (this.version != null) {
            hash += 13 * this.version.hashCode();
        }
        return hash;
    }

}

