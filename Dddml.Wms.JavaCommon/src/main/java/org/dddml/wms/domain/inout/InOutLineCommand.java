package org.dddml.wms.domain.inout;

import java.util.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.Command;
import org.dddml.wms.specialization.DomainError;

public interface InOutLineCommand extends Command
{
    String getLineNumber();

    void setLineNumber(String lineNumber);

    String getInOutDocumentNumber();

    void setInOutDocumentNumber(String inOutDocumentNumber);

    interface CreateOrMergePatchInOutLine extends InOutLineCommand
    {
        String getLocatorId();

        void setLocatorId(String locatorId);

        String getProductId();

        void setProductId(String productId);

        String getAttributeSetInstanceId();

        void setAttributeSetInstanceId(String attributeSetInstanceId);

        String getDescription();

        void setDescription(String description);

        String getUomId();

        void setUomId(String uomId);

        BigDecimal getMovementQuantity();

        void setMovementQuantity(BigDecimal movementQuantity);

        BigDecimal getPickedQuantity();

        void setPickedQuantity(BigDecimal pickedQuantity);

        Boolean getIsInvoiced();

        void setIsInvoiced(Boolean isInvoiced);

        Boolean getProcessed();

        void setProcessed(Boolean processed);

        Long getRmaLineNumber();

        void setRmaLineNumber(Long rmaLineNumber);

        Long getReversalLineNumber();

        void setReversalLineNumber(Long reversalLineNumber);

        Boolean getActive();

        void setActive(Boolean active);

    }

    interface CreateInOutLine extends CreateOrMergePatchInOutLine
    {
    }

    interface MergePatchInOutLine extends CreateOrMergePatchInOutLine
    {
        Boolean getIsPropertyLocatorIdRemoved();

        void setIsPropertyLocatorIdRemoved(Boolean removed);

        Boolean getIsPropertyProductIdRemoved();

        void setIsPropertyProductIdRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetInstanceIdRemoved();

        void setIsPropertyAttributeSetInstanceIdRemoved(Boolean removed);

        Boolean getIsPropertyDescriptionRemoved();

        void setIsPropertyDescriptionRemoved(Boolean removed);

        Boolean getIsPropertyUomIdRemoved();

        void setIsPropertyUomIdRemoved(Boolean removed);

        Boolean getIsPropertyMovementQuantityRemoved();

        void setIsPropertyMovementQuantityRemoved(Boolean removed);

        Boolean getIsPropertyPickedQuantityRemoved();

        void setIsPropertyPickedQuantityRemoved(Boolean removed);

        Boolean getIsPropertyIsInvoicedRemoved();

        void setIsPropertyIsInvoicedRemoved(Boolean removed);

        Boolean getIsPropertyProcessedRemoved();

        void setIsPropertyProcessedRemoved(Boolean removed);

        Boolean getIsPropertyRmaLineNumberRemoved();

        void setIsPropertyRmaLineNumberRemoved(Boolean removed);

        Boolean getIsPropertyReversalLineNumberRemoved();

        void setIsPropertyReversalLineNumberRemoved(Boolean removed);

        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);

    }

	interface RemoveInOutLine extends InOutLineCommand
	{
	}

}

