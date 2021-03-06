package org.dddml.wms.domain.movement;

import java.util.Set;
import java.util.Date;
import java.math.BigDecimal;
import org.dddml.wms.domain.*;

public class MovementCommands
{
    private MovementCommands() {
    }

    public static class DocumentAction implements MovementCommand {

        public String getCommandType() {
            return "DocumentAction";
        }

        public void setCommandType(String commandType) {
            //do nothing
        }

        private String value;

        public String getValue() {
            return this.value;
        }

        public void setValue(String value) {
            this.value = value;
        }

        private String documentNumber;

        public String getDocumentNumber() {
            return this.documentNumber;
        }

        public void setDocumentNumber(String documentNumber) {
            this.documentNumber = documentNumber;
        }

        private Long version;

        public Long getVersion() {
            return this.version;
        }

        public void setVersion(Long version) {
            this.version = version;
        }

        private String commandId;

        public String getCommandId() {
            return this.commandId;
        }

        public void setCommandId(String commandId) {
            this.commandId = commandId;
        }

        private String requesterId;

        public String getRequesterId() {
            return this.requesterId;
        }

        public void setRequesterId(String requesterId) {
            this.requesterId = requesterId;
        }

    }

}

