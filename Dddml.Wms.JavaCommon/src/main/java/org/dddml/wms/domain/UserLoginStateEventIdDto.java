package org.dddml.wms.domain;


public class UserLoginStateEventIdDto
{
	
    private UserLoginStateEventId value;

    public UserLoginStateEventIdDto()
    {
        this(new UserLoginStateEventId());
    }

    public UserLoginStateEventIdDto(UserLoginStateEventId value)
    {
        this.value = value;
    }

    public UserLoginStateEventId toUserLoginStateEventId()
    {
        return this.value;
    }

    public String getUserId()
    {
        return this.value.getUserId();
    }

    public void setUserId(String userId)
    {
        this.value.setUserId(userId);
    }

    public LoginKeyDto getLoginKey()
    {
        return new LoginKeyDto(this.value.getLoginKey());
    }

    public void setLoginKey(LoginKeyDto loginKey)
    {
        this.value.setLoginKey(loginKey.toLoginKey());
    }

    public Long getUserVersion()
    {
        return this.value.getUserVersion();
    }

    public void setUserVersion(Long userVersion)
    {
        this.value.setUserVersion(userVersion);
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

        UserLoginStateEventIdDto other = (UserLoginStateEventIdDto)obj;
        return value.equals(other.value);
    }

    @Override
    public int hashCode()
    {
        return value.hashCode();
    }

}

