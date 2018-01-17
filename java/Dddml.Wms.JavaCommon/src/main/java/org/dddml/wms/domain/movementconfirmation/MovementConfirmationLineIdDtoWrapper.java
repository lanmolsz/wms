package org.dddml.wms.domain.movementconfirmation;

import org.dddml.wms.domain.*;

public class MovementConfirmationLineIdDtoWrapper extends MovementConfirmationLineIdDto
{
	
    private MovementConfirmationLineId value;

    public MovementConfirmationLineIdDtoWrapper()
    {
        this(new MovementConfirmationLineId());
    }

    public MovementConfirmationLineIdDtoWrapper(MovementConfirmationLineId value)
    {
        if (value == null) { throw new IllegalArgumentException("value == null"); }
        this.value = value;
    }

    public MovementConfirmationLineId toMovementConfirmationLineId()
    {
        return this.value;
    }

    @Override
    public String getMovementConfirmationDocumentNumber()
    {
        return this.value.getMovementConfirmationDocumentNumber();
    }

    @Override
    public void setMovementConfirmationDocumentNumber(String movementConfirmationDocumentNumber)
    {
        this.value.setMovementConfirmationDocumentNumber(movementConfirmationDocumentNumber);
    }

    @Override
    public String getLineNumber()
    {
        return this.value.getLineNumber();
    }

    @Override
    public void setLineNumber(String lineNumber)
    {
        this.value.setLineNumber(lineNumber);
    }


    @Override
    public boolean equals(Object obj)
    {
        if (obj == this) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (obj.getClass() == MovementConfirmationLineIdDto.class) {
            return super.equals(obj);
        }
        if (obj.getClass() != this.getClass()) {
            return false;
        }

        MovementConfirmationLineIdDtoWrapper other = (MovementConfirmationLineIdDtoWrapper)obj;
        return value.equals(other.value);
    }

}
