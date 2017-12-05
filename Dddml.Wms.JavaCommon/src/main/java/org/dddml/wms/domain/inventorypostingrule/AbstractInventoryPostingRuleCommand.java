package org.dddml.wms.domain.inventorypostingrule;

import java.util.*;
import org.dddml.wms.domain.inventoryitem.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractInventoryPostingRuleCommand extends AbstractCommand implements InventoryPostingRuleCommand
{
    private String inventoryPostingRuleId;

    public String getInventoryPostingRuleId()
    {
        return this.inventoryPostingRuleId;
    }

    public void setInventoryPostingRuleId(String inventoryPostingRuleId)
    {
        this.inventoryPostingRuleId = inventoryPostingRuleId;
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


    public static abstract class AbstractCreateOrMergePatchInventoryPostingRule extends AbstractInventoryPostingRuleCommand implements CreateOrMergePatchInventoryPostingRule
    {
        private InventoryItemId trigger;

        public InventoryItemId getTrigger()
        {
            return this.trigger;
        }

        public void setTrigger(InventoryItemId trigger)
        {
            this.trigger = trigger;
        }

        private InventoryItemId output;

        public InventoryItemId getOutput()
        {
            return this.output;
        }

        public void setOutput(InventoryItemId output)
        {
            this.output = output;
        }

        private String triggerAccountName;

        public String getTriggerAccountName()
        {
            return this.triggerAccountName;
        }

        public void setTriggerAccountName(String triggerAccountName)
        {
            this.triggerAccountName = triggerAccountName;
        }

        private String outputAccountName;

        public String getOutputAccountName()
        {
            return this.outputAccountName;
        }

        public void setOutputAccountName(String outputAccountName)
        {
            this.outputAccountName = outputAccountName;
        }

        private Boolean isOutputNegated;

        public Boolean getIsOutputNegated()
        {
            return this.isOutputNegated;
        }

        public void setIsOutputNegated(Boolean isOutputNegated)
        {
            this.isOutputNegated = isOutputNegated;
        }

        private Boolean active;

        public Boolean getActive()
        {
            return this.active;
        }

        public void setActive(Boolean active)
        {
            this.active = active;
        }

    }

    public static abstract class AbstractCreateInventoryPostingRule extends AbstractCreateOrMergePatchInventoryPostingRule implements CreateInventoryPostingRule
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }

    }

    public static abstract class AbstractMergePatchInventoryPostingRule extends AbstractCreateOrMergePatchInventoryPostingRule implements MergePatchInventoryPostingRule
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }

        private Boolean isPropertyTriggerRemoved;

        public Boolean getIsPropertyTriggerRemoved()
        {
            return this.isPropertyTriggerRemoved;
        }

        public void setIsPropertyTriggerRemoved(Boolean removed)
        {
            this.isPropertyTriggerRemoved = removed;
        }

        private Boolean isPropertyOutputRemoved;

        public Boolean getIsPropertyOutputRemoved()
        {
            return this.isPropertyOutputRemoved;
        }

        public void setIsPropertyOutputRemoved(Boolean removed)
        {
            this.isPropertyOutputRemoved = removed;
        }

        private Boolean isPropertyTriggerAccountNameRemoved;

        public Boolean getIsPropertyTriggerAccountNameRemoved()
        {
            return this.isPropertyTriggerAccountNameRemoved;
        }

        public void setIsPropertyTriggerAccountNameRemoved(Boolean removed)
        {
            this.isPropertyTriggerAccountNameRemoved = removed;
        }

        private Boolean isPropertyOutputAccountNameRemoved;

        public Boolean getIsPropertyOutputAccountNameRemoved()
        {
            return this.isPropertyOutputAccountNameRemoved;
        }

        public void setIsPropertyOutputAccountNameRemoved(Boolean removed)
        {
            this.isPropertyOutputAccountNameRemoved = removed;
        }

        private Boolean isPropertyIsOutputNegatedRemoved;

        public Boolean getIsPropertyIsOutputNegatedRemoved()
        {
            return this.isPropertyIsOutputNegatedRemoved;
        }

        public void setIsPropertyIsOutputNegatedRemoved(Boolean removed)
        {
            this.isPropertyIsOutputNegatedRemoved = removed;
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

    }

    public static class SimpleCreateInventoryPostingRule extends AbstractCreateInventoryPostingRule
    {
    }

    
    public static class SimpleMergePatchInventoryPostingRule extends AbstractMergePatchInventoryPostingRule
    {
    }

    
	public static class SimpleDeleteInventoryPostingRule extends AbstractInventoryPostingRuleCommand implements DeleteInventoryPostingRule
	{
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_DELETE;
        }
	}

    

}

