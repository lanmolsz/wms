package org.dddml.wms.domain.physicalinventory;

import java.util.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.Command;
import org.dddml.wms.specialization.DomainError;

public interface PhysicalInventoryLineCommand extends Command
{
    String getLineNumber();

    void setLineNumber(String lineNumber);

    String getPhysicalInventoryDocumentNumber();

    void setPhysicalInventoryDocumentNumber(String physicalInventoryDocumentNumber);

    interface CreateOrMergePatchPhysicalInventoryLine extends PhysicalInventoryLineCommand
    {
        String getLocatorId();

        void setLocatorId(String locatorId);

        String getProductId();

        void setProductId(String productId);

        String getAttributeSetInstanceId();

        void setAttributeSetInstanceId(String attributeSetInstanceId);

        BigDecimal getBookQuantity();

        void setBookQuantity(BigDecimal bookQuantity);

        BigDecimal getCountedQuantity();

        void setCountedQuantity(BigDecimal countedQuantity);

        Boolean getProcessed();

        void setProcessed(Boolean processed);

        Long getReversalLineNumber();

        void setReversalLineNumber(Long reversalLineNumber);

        String getDescription();

        void setDescription(String description);

        Boolean getActive();

        void setActive(Boolean active);

    }

    interface CreatePhysicalInventoryLine extends CreateOrMergePatchPhysicalInventoryLine
    {
    }

    interface MergePatchPhysicalInventoryLine extends CreateOrMergePatchPhysicalInventoryLine
    {
        Boolean getIsPropertyLocatorIdRemoved();

        void setIsPropertyLocatorIdRemoved(Boolean removed);

        Boolean getIsPropertyProductIdRemoved();

        void setIsPropertyProductIdRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetInstanceIdRemoved();

        void setIsPropertyAttributeSetInstanceIdRemoved(Boolean removed);

        Boolean getIsPropertyBookQuantityRemoved();

        void setIsPropertyBookQuantityRemoved(Boolean removed);

        Boolean getIsPropertyCountedQuantityRemoved();

        void setIsPropertyCountedQuantityRemoved(Boolean removed);

        Boolean getIsPropertyProcessedRemoved();

        void setIsPropertyProcessedRemoved(Boolean removed);

        Boolean getIsPropertyReversalLineNumberRemoved();

        void setIsPropertyReversalLineNumberRemoved(Boolean removed);

        Boolean getIsPropertyDescriptionRemoved();

        void setIsPropertyDescriptionRemoved(Boolean removed);

        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);

    }

	interface RemovePhysicalInventoryLine extends PhysicalInventoryLineCommand
	{
	}

}
