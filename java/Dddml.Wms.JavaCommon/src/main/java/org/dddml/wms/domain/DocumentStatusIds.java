package org.dddml.wms.domain;

public final class DocumentStatusIds {
    private DocumentStatusIds() {
    }

    public static final String INITIAL = "Initial";

    /**
     * 草稿状态。可以添加行项。Drafted的单据可以撤销（VOID）或完成（COMPLETE）。
     */
    public static final String DRAFTED = "Drafted";

    /**
     * 移交中。允许的在途的单据会有这个状态。
     */
    public static final String IN_PROGRESS = "InProgress";

    /**
     * 不可用。
     */
    public static final String INVALID = "Invalid";

    /**
     * 完成状态。Completed的单据可以Close / REVERSE。
     * （在 ADempiere 中可以对 COMPLETED 的单据作 VOID，但是好像和 REVERSE 的效果没有什么不同？）
     */
    public static final String COMPLETED = "Completed";

    /**
     * 关闭。不能再进行修改。属于最终的状态之一。
     */
    public static final String CLOSED = "Closed";

    /**
     * VOIDED，已经被撤销。不能再做任何操作。属于最终的状态之一。
     */
    public static final String VOIDED = "Voided";

    /**
     * 反转的。属于最终的状态之一。
     */
    public static final String REVERSED = "Reversed";

}