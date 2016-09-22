package org.dddml.wms.domain;


public class UserStateEventIdDto
{

    public UserStateEventIdDto()
    {
    }

    public UserStateEventId toUserStateEventId()
    {
        UserStateEventId v = new UserStateEventId();
        v.setUserId(this.getUserId());
        v.setVersion(this.getVersion());
        return v;
    }

    private String userId;

    public String getUserId()
    {
        return this.userId;
    }

    public void setUserId(String userId)
    {
        this.userId = userId;
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
        if (obj == null || obj.getClass() != UserStateEventIdDto.class) {
            return false;
        }

        UserStateEventIdDto other = (UserStateEventIdDto)obj;
        return true 
            && (userId == other.userId || (userId != null && userId.equals(other.userId)))
            && (version == other.version || (version != null && version.equals(other.version)))
            ;

    }

    @Override
    public int hashCode()
    {
        int hash = 0;
        if (this.userId != null) {
            hash += 13 * this.userId.hashCode();
        }
        if (this.version != null) {
            hash += 13 * this.version.hashCode();
        }
        return hash;
    }

}

