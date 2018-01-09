﻿using Dddml.Wms.Specialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dddml.Wms.Domain.InOut
{
    /// <summary>
    /// InOut Aggregate.
    /// </summary>
    public partial class InOutAggregate
    {
        // //////////////////////////////////////////////
        // Aggregate 只负责更新聚合内的状态。
        // //////////////////////////////////////////////

        public virtual void DocumentAction(string value, long version, string commandId, string requesterId)
        {
            var e = NewInOutStateMergePatched(version, commandId, requesterId);
            DoDocumentAction(value, ts => e.DocumentStatusId = ts);
            Apply(e);
        }

        public virtual void Complete(long version, string commandId, string requesterId)
        {
            DocumentAction(global::Dddml.Wms.Domain.DocumentAction.Complete, version, commandId, requesterId);
        }

        public virtual void Close(long version, string commandId, string requesterId)
        {
            DocumentAction(global::Dddml.Wms.Domain.DocumentAction.Close, version, commandId, requesterId);
        }

        public virtual void Void(long version, string commandId, string requesterId)
        {
            DocumentAction(global::Dddml.Wms.Domain.DocumentAction.Void, version, commandId, requesterId);
        }

        public virtual void Reverse(long version, string commandId, string requesterId)
        {
            DocumentAction(global::Dddml.Wms.Domain.DocumentAction.Reverse, version, commandId, requesterId);
        }
    }
}