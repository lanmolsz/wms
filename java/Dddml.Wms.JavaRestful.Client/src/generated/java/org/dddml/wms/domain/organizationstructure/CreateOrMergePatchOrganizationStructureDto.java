package org.dddml.wms.domain.organizationstructure;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchOrganizationStructureDto extends AbstractOrganizationStructureCommandDto
{
    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved()
    {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed)
    {
        this.isPropertyActiveRemoved = removed;
    }

    public static class CreateOrganizationStructureDto extends CreateOrMergePatchOrganizationStructureDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }

    }

    public static class MergePatchOrganizationStructureDto extends CreateOrMergePatchOrganizationStructureDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }

    }

}

